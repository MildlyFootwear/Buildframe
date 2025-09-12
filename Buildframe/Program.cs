using Instance_Manager.Methods;
using System.Collections.Immutable;
using Buildframe.Methods;

namespace Buildframe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            static void ExceptionHandler(object sender, UnhandledExceptionEventArgs ex)
            {
                MessageBox.Show(ex.ExceptionObject.ToString(), ToolName + " - Exception");
            }

            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler;

            ImmutableList<string> argsL = args.ToImmutableList();

            if (argsL.IndexOf("-debug") != -1)
                ToolDebug = true;

            if (ToolDebug)
            {
                AllocConsole();
            }

            WriteLineIfDebug("Starting.");
            WriteLineIfDebug("Running from: " + envAPPLOC);

            UpdateMethods updateMethods = new UpdateMethods();

            updateMethods.CheckForUpdate();

            if (argsL.Count == 0)
            {
                WriteLineIfDebug("No args passed.");
            }
            else
            {
                WriteLineIfDebug("Using args:");
                int ind = 0;
                foreach (string arg in argsL)
                {
                    WriteLineIfDebug("    " + arg);
                    ind++;
                }
                if (argsL.Count != argsL.Count)
                {
                    WriteLineIfDebug("Exe args:");
                    while (ind < argsL.Count)
                    {
                        WriteLineIfDebug("    " + argsL[ind]);
                        ind++;
                    }
                }
            }

            LoadAndSave.loadFireModeFiles();
            LoadAndSave.loadModFiles();
            LoadAndSave.loadArcaneFiles();
            LoadAndSave.loadMiscFiles();

            Application.Run(new MainWindow());

        }
    }
}