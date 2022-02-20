using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Processes
{
    public class DataAcquisition
    {
        public Form1 form { get; set; }
        Dictionary<String, List<int[]>> threadsInfo = new Dictionary<String, List<int[]>>();
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
                    data.Rows.Add(process1.Id, process1.ProcessName, process1.VirtualMemorySize64/ 8388608 + " МБ", process1.BasePriority, GetProcessOwner(process1.Id), threads.Count);
                    //Console.WriteLine('\t' + process1.ProcessName + '\t' + process1.Id + '\t' + process1.VirtualMemorySize64 + '\t' + process1.BasePriority + '\t' + GetProcessOwner(process1.Id));
                    //ProcessThreadCollection threads = process1.Threads;
                    List<int[]> info = new List<int[]>();
                    foreach (ProcessThread tread in threads) info.Add(new int[]{ tread.Id , tread.CurrentPriority});
                    threadsInfo.Add(process1.Id.ToString(), info);
                }
                Console.WriteLine(processes.Length);
            }
        }
        private String GetProcessOwner(int processId)
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
        }
        public void UpdateThreads()
        {
            DataGridView data = form.GetDataGridView();
            DataGridView data2 = form.GetDataGridView2();
            if (data.SelectedRows.Count!=0)
            {
                Console.WriteLine(data.SelectedRows[0].Cells[0].Value);
                var info = threadsInfo[data.SelectedRows[0].Cells[0].Value.ToString()];
                data2.Rows.Add(info[0], info[1]);
            }
        }
        /*private Dictionary<int,String> GetProcessOwners()
        {
            Dictionary<int, String> processes = new Dictionary<int, String>();
            String query = "Select * From Win32_Process";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();
            foreach (ManagementObject result in processList)
            {
                var owner = @"Не могу получить владельца процесса";
                String[] argList = new String[] { String.Empty, String.Empty };
                int returnVal = 0;
                    int.TryParse(result.InvokeMethod("GetOwner", argList).ToString(),out returnVal);

                if (returnVal == 0)
                {
                    owner = argList[0];
                    //Console.WriteLine(result["ProcessId"] + "             " + result["Name"] + "  -->  " + argList[1] + "\\" + argList[0]);
                }
                processes.Add(Convert.ToInt32(result["ProcessId"]), owner);
            }
            return processes;
        }*/
    }
}
