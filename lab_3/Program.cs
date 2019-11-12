using System;

namespace lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.readExample();
            controller.exampleIntoArray();
            controller.printUnsortedArray();
            controller.chooseAccordingToParameters();
            controller.bubbleSort();
            Console.WriteLine(controller.countAverageNumOfChannels());
        }
    }
}