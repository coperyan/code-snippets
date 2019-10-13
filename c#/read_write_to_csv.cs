using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    /// <summary>
    /// Summary description for Class1.
    /// </summary>

    class Class1
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string inputfile = @"C:\Users\Administrator\Desktop\FirstFile.csv";
            string outputfile = @"C:\Users\Administrator\Desktop\SecondFile.csv";
            string buffer;
            StreamReader sr = File.OpenText(inputfile);

            buffer = sr.ReadLine(); // first line of the input file.

            if (buffer != null)
            {

                // Create an output stream.
                StreamWriter sw = File.CreateText(outputfile);

                //Read line 2
                buffer = sr.ReadLine();

                while (buffer != null) // keep looping as long as the last line read was not null
                {

                    // write the last read line to the output file
                    sw.WriteLine(buffer);

                    // read the next line and loop
                    buffer = sr.ReadLine();

                }

                sw.Close(); // Close the output file.
            }

            sr.Close(); // Close the input file.
        }

    }

}