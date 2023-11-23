using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            try
            {
                string fpath = "C:\\Users\\kotap\\OneDrive\\Desktop\\Practice project2\\Student data.txt";
                sr = new StreamReader(fpath);
                string text = " ";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}