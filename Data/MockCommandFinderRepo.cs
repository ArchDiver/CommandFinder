using System.Collections.Generic;
using CommandFinder.Models;

namespace CommandFinder.Data
{
    public class MockCommandFinderRepo : ICommandFinderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platfrom="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get knife", Platfrom="Knife & board"},
                new Command{Id=0, HowTo="Make tea", Line="Place tebag", Platfrom="Kettle and cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platfrom="Kettle & Pan"};
        }
    }
}