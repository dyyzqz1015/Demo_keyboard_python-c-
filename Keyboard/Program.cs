using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace Keyboard
{
    class Program
    {

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("kernel32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern int GetCurrentThreadId();

        static void Main(string[] args)
        {
            Console.WriteLine("abc");
            byte bVK = 0x65;


            for(int i = 48; i<= 57; i++)
            {
                keybd_event((byte)i, 0, 0, 0);

                keybd_event((byte)i, 0, 2, 0);
            }

            //int a = GetCurrentThreadId();
            //Console.WriteLine(a);
            Console.ReadLine();


        }



    }  

}



