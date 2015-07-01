using System;
using System.Net.NetworkInformation;
using System.Text;
using CommandLine.Utility;

namespace Program {
    class pingApp {
        public static int Main(string[] args) {
            try {
                Arguments CommandLine=new Arguments(args);
                if (CommandLine["param1"]!=null) {
                    string param1 = CommandLine["param1"];
                    WriteToConsole("Param1: "+param1);
                } else {
                    printHelp();
                }
                return (int) ExitCode.Success;
            } catch (Exception) {
                return (int) ExitCode.Error;
            }
        }

        private static void printHelp() {
            WriteToConsole("Usage: App.exe -param1 (some param).");
            WriteToConsole("Ex: pingApp.exe -param1 'It Works!'");
        }
        public static void WriteToConsole(string message="") {
            if (message.Length>0) {
                Console.WriteLine(message);
            }
        }
        enum ExitCode:int {
            Success=0,
            Error=1,
            UnknownError=10
        }
    }
}
