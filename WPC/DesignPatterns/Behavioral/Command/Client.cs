using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);

            var command1 = new AddPlantCommand(garden, "tree");
            var command2 = new RemovePlantCommand(garden, "tree");
            var command3 = new AddPlantCommand(garden, "flowers");
            var command4 = new RemovePlantCommand(garden, "flowers");


            var plantTreeButton = new CommandInvoker(command1);
            var removeTreeButton = new CommandInvoker(command2);
            var plantFlowersButton = new CommandInvoker(command3);
            var removeFlowersButton = new CommandInvoker(command4);


            Console.WriteLine(garden);

            plantTreeButton.Click();
            plantTreeButton.Click();
            plantTreeButton.Click();
            Console.WriteLine(garden);


            plantFlowersButton.Click();
            plantFlowersButton.Click();
            plantFlowersButton.Click();
            Console.WriteLine(garden);

            removeTreeButton.Click();
            removeFlowersButton.Click();
            removeFlowersButton.Click();
            removeFlowersButton.Click();
            Console.WriteLine(garden);

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            Console.WriteLine(garden);
        }
    }
}
