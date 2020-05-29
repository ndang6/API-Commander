using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command
                {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil Water",
                    Platform = "Kettle & Pan"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Cut bread",
                    Line = "Get a knife",
                    Platform = "Chopping Board"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "Make a cup of tea",
                    Line = "Get a teabag",
                    Platform = "Kettle & Cup"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil Water",
                Platform = "Kettle & Pan"
            };
        }
    }
}