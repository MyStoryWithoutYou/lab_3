using System;

namespace lab_2
{
    public class Services
    {
        private int startRange;
        private int endRange;

        public int StartRange
        {
            get { return startRange; }
            set { startRange = value; }
        }
        
        public int EndRange
        {
            get { return endRange; }
            set { endRange = value; }
        }


        public void enterRange()
        {
            Console.WriteLine("Введите начало диапазона: ");
            startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            endRange = Convert.ToInt32(Console.ReadLine());
        }
    }
}