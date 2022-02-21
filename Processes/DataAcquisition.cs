using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
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
                //Dictionary<int, String> idName = GetProcessOwners();
                Process[] processes = Process.GetProcesses();
                foreach (Process process1 in processes)
                {
                    ProcessThreadCollection threads = process1.Threads;
                    data.Rows.Add(process1.Id, process1.ProcessName, process1.VirtualMemorySize64/ 8388608 + " МБ", process1.BasePriority, GetProcessOwnerByID(process1.Id), threads.Count);
                    List<int[]> info = new List<int[]>();
                    foreach (ProcessThread tread in threads) info.Add(new int[]{ tread.Id , tread.CurrentPriority});
                    threadsInfo.Add(process1.Id.ToString(), info);
                }
                form.SetLabelProcText("(Количество процессов: " + processes.Length.ToString() + ")");
            }
        }
        /*private String GetProcessOwner(int processId)
        {
            // запрос получения всех процессов связанных с переданным идентификатором processId
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();
            foreach (ManagementObject obj in processList)
            {
                // Получить владельца процесса в argList 
                var owner = @"Не могу получить владельца процесса";
                String[] argList = new String[] { String.Empty, String.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    owner = argList[0]; //  владелец                    
                }

                return owner;
            }
            return null;
        }*/
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
        public static string GetProcessOwnerByID(int processId)
        {
            IntPtr processHandle = IntPtr.Zero;
            IntPtr tokenHandle = IntPtr.Zero;
            try
            {
                processHandle = OpenProcess(PROCESS_QUERY_INFORMATION, false, processId);
                if (processHandle == IntPtr.Zero)
                    return "NO ACCESS";

                OpenProcessToken(processHandle, TOKEN_QUERY, out tokenHandle);
                using (WindowsIdentity wi = new WindowsIdentity(tokenHandle))
                {
                    string user = wi.Name;
                    return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
                }
            }
            finally
            {
                if (tokenHandle != IntPtr.Zero) CloseHandle(tokenHandle);
                if (processHandle != IntPtr.Zero) CloseHandle(processHandle);
            }
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        private const UInt32 PROCESS_QUERY_INFORMATION = 0x0400;
        private const UInt32 TOKEN_QUERY = 0x0008;
    }
}
