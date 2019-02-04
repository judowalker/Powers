using CommandLine;
using Powers.Commands;
using System.Linq;
using System.Reflection;

namespace Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterface(nameof(ICommand)) != null).ToList();

            var result = Parser.Default.ParseArguments(args, commandTypes.ToArray());

            if (result is Parsed<object> parsed && parsed.Value is ICommand command)
            {
                command.Run();
            }
        }
    }
}
