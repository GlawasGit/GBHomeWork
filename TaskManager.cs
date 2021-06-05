//using System;
//using System.Diagnostics;

//namespace ConsoleApp8
//{
//    class TaskManager
//    {
        
//        static void Main(string[] args)
//        {
//            foreach (Process process in Process.GetProcesses())
//            {
//                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");              
//            }
//            Console.WriteLine("Enter '1' to get process by Name or '2' to get process by ID");
//            int caseSwitch = Convert.ToInt32(Console.ReadLine());
//            switch (caseSwitch)
//            {
//                case 1:
//                Console.WriteLine("Enter process name to kill...");
//                string choose = Console.ReadLine();
//                KillProcessByName(choose);                
//                break;

//                case 2:                    
//                Console.WriteLine("Enter process ID to kill...");
//                int chooseid = Convert.ToInt32(Console.ReadLine());
//                KillProcessById(chooseid);
//                break;
//            }
            
//             static void KillProcessById(int pid)
//            {
//                Process[] process = Process.GetProcesses();

//                foreach (Process prs in process)
//                {
//                    if (prs.Id == pid)
//                    {
//                        prs.Kill();
//                        break;
//                    }
//                }
//            }

//            static void KillProcessByName(string name)
//            {
//                Process[] process = Process.GetProcesses();

//                foreach (Process nm in process)
//                {
//                    if (nm.ProcessName == name)
//                    {
//                        nm.Kill();
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}
