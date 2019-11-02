using System;
using System.IO;
using System.Collections;

namespace lab_2
{
    public class Controller
    {
        Tv tv1 = new Tv();
        Tv tv2 = new Tv();
        Tv tv3 = new Tv();
        
        static Tv[] tvArray = new Tv[3];
        Tv[] tvArraySorted = new Tv[tvArray.Length];
        
        Services services = new Services();

        public void readExample()
        {
            using (FileStream fstream = File.OpenRead($"/Users/aliakseihudyma/RiderProjects/lab_3/lab_3/test.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] words = textFromFile.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                int j = 0;
                tv1.Model = words[j];
                tv1.Age = int.Parse(words[j += 1]);
                tv1.NumOfChannels = int.Parse(words[j += 1]);
                tv1.Diagonal = int.Parse(words[j += 1]);

                tv2.Model = words[j += 1];
                tv2.Age = int.Parse(words[j += 1]);
                tv2.NumOfChannels = int.Parse(words[j += 1]);
                tv2.Diagonal = int.Parse(words[j += 1]);

                tv3.Model = words[j += 1];
                tv3.Age = int.Parse(words[j += 1]);
                tv3.NumOfChannels = int.Parse(words[j += 1]);
                tv3.Diagonal = int.Parse(words[j += 1]);

                Console.WriteLine(tv1);
                Console.WriteLine(tv2);
                Console.WriteLine(tv3);

                if (fstream != null)
                {
                    fstream.Close();
                }
            }
        }

        public void exampleIntoArrayList()
        {
            tvArray[0] = tv1;
            tvArray[1] = tv2;
            tvArray[2] = tv3;
        }

        public void sortArrayAccordingToDiagonalAndNumOfChannels()
        {
            //Tv[] tvArraySorted = new Tv[tvArray.Length];
            services.enterRange();

            for(int i = 0; i < tvArray.Length; i++)
            {
                if (tvArray[i].Diagonal > services.StartRange & tvArray[i].Diagonal < services.EndRange)
                {
                    tvArraySorted[i] = tvArray[i];
                }
            }

            services.StartRange = 0;
            services.EndRange = 0;
            
            services.enterRange();
            
            for(int j = 0; j < tvArraySorted.Length; j++)
            {
                if (tvArray[j].NumOfChannels > services.StartRange & tvArray[j].NumOfChannels < services.EndRange)
                {
                    tvArraySorted[j] = tvArray[j];
                }
            }
        }

        public void printSortedArray()
        {
            foreach (Tv tv in tvArraySorted)
            {
                Console.WriteLine(tv);
            }
        }

        public Controller()
        {
           
        }
    }
}