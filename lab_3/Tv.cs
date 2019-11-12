using System;

namespace lab_3
{
    public class Tv : IComparable
    {
        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            { 
                if (value.Length == 0 || value.Trim() == string.Empty)
                {
                    Console.WriteLine("Передана некорректная модель");
                    model = "Телевизор";
                }
                else
                {
                    model = value;
                }
            }
        }
        
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Передано некорректное значение возраста");
                    age = 3;
                }
                else
                {
                    age = value;
                }
            }
        }

        private int numOfChannels;

        public int NumOfChannels
        {
            get
            {
                return numOfChannels;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Передано некорректное количество каналов");
                    numOfChannels = 5;
                }
                else
                {
                    numOfChannels = value;

                }
            }
        }

        private int diagonal;

        public int Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value <= 20)
                {
                    Console.WriteLine("Передано некорректное значение диагонали");
                    diagonal = 32;
                }
                else
                {
                    diagonal = value;
                }
            }
        }

        public bool isTurnedOn;

        public string turnOn()
        {
            isTurnedOn = true;
            return "Телевизор включен!";
        }

        public string turnOff()
        {
            if (isTurnedOn)
            {
                isTurnedOn = false;
                return "\nТелевизор выключен!";
            }
           
            {
                return "\nТелевизор не был включен!";
            }
        }
        
        public override string ToString()
        {
            return "\nМодель: " + Model + ", срок службы: " + Age + ", количество каналов: " + NumOfChannels + ", диагональ: " + Diagonal;
        }
        
        public int CompareTo(object o)
        {
            Tv tw = o as Tv;
            if (tw != null)
                return Model.CompareTo(tw.Model);
     
            throw new Exception("\nНевозможно сравнить два объекта");
        }

        public int Value { get; set; }

        public static bool operator true(Tv c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(Tv c1)
        {
            return c1.Value == 0;
        }

        public static bool operator >(Tv c1, Tv c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator <(Tv c1, Tv c2)
        {
            return c1.Value < c2.Value;
        }

        public static string programInfo()
        {
            return "\nКоличество полей: 5" + "Количество методов: 3" + "Количество конструкторов: 3";
        }

        public Tv()
        {
            model = "LG 43UK6300";
            age = 1;
            numOfChannels = 82;
            diagonal = 43;
        }

        public Tv(string model, int age, int numOfChannels, int diagonal)
        {
            Model = model;
            Age = age;
            NumOfChannels = numOfChannels;
            Diagonal = diagonal;
        }

        public Tv(string model, int age)
        {
            numOfChannels = 127;
            Model = model;
            Age = age;
            Diagonal = 65;
        }
    }
}
