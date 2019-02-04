using CommandLine;
using System;

namespace Powers.Commands
{
    [Verb("PullProject", HelpText = "Fetch and download a project.")]
    public class PullProject : ICommand
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [Option("project-number", Required = true, HelpText = "The project number.")]
        public string ProjectNumber { get; set; }

        [Option("order-number", Required = true, HelpText = "The order number.")]
        public string OrderNumber { get; set; }

        [Option("mod-number", Required = true, HelpText = "The modification number")]
        public string ModNumber { get; set; }

        public void Run()
        {
            Console.WriteLine("Downloading project...");

            // TODO: Add code to download specified project.
        }
    }
}
