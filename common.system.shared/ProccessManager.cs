using c_sharp_apps_shimshon_kebede.BankApp;
using c_sharp_apps_shimshon_kebede.DraftApp;
using c_sharp_apps_shimshon_kebede.SportApp;
using c_sharp_apps_shimshon_kebede.TransportationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimshon_kebede.common.system.shared
{
    public class ProccessManager
    {
        public static void RunMainProccess()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 5);
            Console.Write("{0} - ", num);
            switch (num)
            {
                case 0:
                    Console.WriteLine("Exit");
                    break;
                case 1:
                   BankAppMain.MainEntry();
                    break;
                case 2:
                    DraftAppMain.MainEntry();
                    break;
                case 3:
                    SportAppMain.MainEntry();
                    break;
                case 4:
                    TransportationAppMain.MainEntry();
                    break;
            }
        }
    }
}
