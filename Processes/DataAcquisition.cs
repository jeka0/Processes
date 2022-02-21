using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Processes
{
    public class DataAcquisition
    {
        public Form1 form { get; set; }
        private Dictionary<String, List<int[]>> threadsInfo = new Dictionary<String, List<int[]>>();
        public void UpdateProcesses()
        {
            DataGridView data = form.GetDataGridView();
            if(data.Rows.Count!=1) data.Rows.Clear();
            threadsInfo.Clear();
            using (Process process = new Process())
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process1 in processes)
                {
                    ProcessThreadCollection threads = process1.Threads;
                    data.Rows.Add(process1.Id, process1.ProcessName, process1.PrivateMemorySize64/(1024*1024) + " МБ", process1.BasePriority, GetProcessOwnerByID(process1), threads.Count);
                    List<int[]> info = new List<int[]>();
                    foreach (ProcessThread tread in threads) info.Add(new int[]{ tread.Id , tread.CurrentPriority});
                    threadsInfo.Add(process1.Id.ToString(), info);
                }
                form.SetLabelProcText("(Количество процессов: " + processes.Length.ToString() + ")");
            }
        }
        public void UpdateThreads()
        {
            DataGridView data = form.GetDataGridView();
            DataGridView data2 = form.GetDataGridView2();
            if (data.SelectedRows.Count != 0 && data.Rows.Count != 1)
            {
                if(data2.Rows.Count!=0) data2.Rows.Clear();
                String id = data.SelectedRows[0].Cells[0].Value.ToString();
                var threadinfo = threadsInfo[id];
                form.SetLabelThreadText(id);
               foreach(int[] info in threadinfo) data2.Rows.Add(info[0], info[1]);
            }
        }
        public static string GetProcessOwnerByID(Process process)
        {
            IntPtr tokenHandle = IntPtr.Zero;
            try
            {
                OpenProcessToken(process.Handle, TOKEN_QUERY, out tokenHandle);
                using (WindowsIdentity wi = new WindowsIdentity(tokenHandle))
                {
                    string user = wi.Name;
                    return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
                }
            }
            catch
            {
                return "NO ACCESS";
            }
            finally
            {
                if (tokenHandle != IntPtr.Zero) CloseHandle(tokenHandle);
            }
        }
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        private const UInt32 TOKEN_QUERY = 0x0008;
    }
}
