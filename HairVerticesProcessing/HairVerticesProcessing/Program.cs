using System;
using System.IO;
using System.Collections;

namespace HairVerticesProcessing
{

    public class Program
    {
        private const string HAIR_VERTICES = "/Users/apple/Desktop/sample_data/strands00092.txt";
        private const string NEW_HAIR_VERTICES = "/Users/apple/Desktop/sample_data/new_strands00092.txt";

        //private const string HAIR_MODIFY = "/Users/apple/Desktop/data2_v_n.txt";
        //private const string NEW_HAIR_VERTICES2 = "/Users/apple/Desktop/newdata2_v_n.txt";

        public static int totalNum=0;

        static void Main(string[] args)
        {
            
            ReadFile();
            Console.WriteLine("Successful!");
        }

        public static void ReadFile()
        {

            if (File.Exists(HAIR_VERTICES))
            {

                string[] lines = System.IO.File.ReadAllLines(HAIR_VERTICES);
                ArrayList lineElements = new ArrayList();
                
                foreach (string line in lines)
                {
                    if (line.StartsWith("v "))
                    {
                        //System.Console.WriteLine(line.Substring(2));
                        lineElements.Add(line.Substring(2));
                        //i++;
                    }


                }
                totalNum = lineElements.Count;
                //string[] Elements = new string[totalNum];

                System.Console.WriteLine("The number is : {0}", lineElements.Count);

                using (StreamWriter sw = new StreamWriter(NEW_HAIR_VERTICES))
                {

                    for (int i = 0; i < totalNum; i++)
                    {
                        sw.WriteLine(lineElements[i]);
                    }
                }
            }

        }

    }


}
