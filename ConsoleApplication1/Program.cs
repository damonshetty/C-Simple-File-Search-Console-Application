using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSearch;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the directory");
            string strdir = Console.ReadLine();

            File fileobj = new File();
            fileobj.sendFileName += DisplayFileName;


            Thread thread = new Thread(() => 
                fileobj.Search(strdir));
            thread.Start();
            Console.Read();
        }


        static void DisplayFileName(string str)
        {
            Console.WriteLine(str);
        }
    }
}
