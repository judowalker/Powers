using CommandLine;

namespace Powers.Commands
{
    public interface ICommand
    {
        [Option('u', "username", Required = true, HelpText = "Username used for authentication.")]
        string Username { get; set; }

        [Option('p', "password", Required = true, HelpText = "Password for specified username.")]
        string Password { get; set; }

        void Run();
    }
}
