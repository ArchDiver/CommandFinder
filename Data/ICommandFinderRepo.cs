using System.Collections.Generic;
using CommandFinder.Models;

namespace CommandFinder.Data
{
    public interface ICommandFinderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}