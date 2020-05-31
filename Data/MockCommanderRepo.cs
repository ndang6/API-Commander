using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{ id = 1, title="Learn Azure", completed="false"},
                new Command{ id = 2, title="Learn VUE", completed="false"},
                new Command{ id = 3, title="Learn .NET CORE", completed="false"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { id = 1, title = "Learn Azure", completed = "true" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}