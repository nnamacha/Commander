using Namacha.Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namacha.Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut Bread ", Line = "Get a knife", Platform = "Knife and Chopping Board" },
                new Command { Id = 2, HowTo = "Make cup of Tea", Line = "Put tea bag in Cup", Platform = "Kettle & Cup" }
            };
            return commands;
            

        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }
    }
}
