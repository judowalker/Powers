using CommandLine;
using System;

namespace Powers.Commands
{
    [Verb("PullProjectList", HelpText = "Lists the projects.")]
    public class PullProjectList : ICommand
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Run()
        {
            Console.WriteLine("Here's a list of projects:");

            // TODO: Add code to return a list of projects.
        }
    }
}
