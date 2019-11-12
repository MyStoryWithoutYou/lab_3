using System;

namespace lab_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.readExample();
            controller.exampleIntoArrayList();
            controller.printUnsortedArray();
            controller.chooseAccordingToParameters();
            controller.bubbleSort();
            Console.WriteLine(controller.countAverageNumOfChannels());
        }
    }
}