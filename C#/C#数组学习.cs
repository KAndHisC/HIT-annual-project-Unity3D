using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PLAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bbb = { 3, 2, 5, 1, 7, 2, 8 };
            string[] name ={
                "heichuan",
                "sdad",
                "aasfff",
            };
            Array.Sort(name);
            Array.Sort(bbb);
            foreach (var n in name) {
                Console.WriteLine(n);
            }
            foreach (var n in bbb)
            {
                Console.WriteLine(n);
            }
            StreamReader sR = new StreamReader("D:\\log.txt");
            string line = "";
            ArrayList LineList = new ArrayList();

            while (line != null) { 

            while (line != null && line.Equals("")) {
                LineList.Add(line);
            }
            }

        }

        public static int abc()
        {
            int numble;
            do {
                try
                {
                    numble = int.Parse(Console.ReadLine());
                    return numble;
                }
                catch {
                    Console.WriteLine("错误" );
                }
            } while (true);
        }
    }
}
