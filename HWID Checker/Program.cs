
// C# program to illustrate the
// Console.Title Property
using System;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HWID_Checker
{

    internal class Program
    {
        [STAThread]
        static void Main(string[] args) 
        {
            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            Clipboard.SetText(HWID);
            Console.WriteLine("                 ██   ██ ██     ██ ██ ██████       ██████ ██   ██ ███████  ██████ ██   ██ ███████ ██████  ");
            Console.WriteLine("                 ██   ██ ██     ██ ██ ██   ██     ██      ██   ██ ██      ██      ██  ██  ██      ██   ██ ");
            Console.WriteLine("                 ███████ ██  █  ██ ██ ██   ██     ██      ███████ █████   ██      █████   █████   ██████  ");
            Console.WriteLine("                 ██   ██ ██ ███ ██ ██ ██   ██     ██      ██   ██ ██      ██      ██  ██  ██      ██   ██ ");
            Console.WriteLine("                 ██   ██  ███ ███  ██ ██████       ██████ ██   ██ ███████  ██████ ██   ██ ███████ ██   ██ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                   GitHub: @heitorrosa");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                     Your HWID is:");
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 1.5 + "}", HWID));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                     They have been copiated too for your CLIPBOARD");

            Console.ReadLine();
        }
    }
}