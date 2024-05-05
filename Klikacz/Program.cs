namespace Klikacz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread formThread = new Thread(StartForm);
            formThread.Start();
            formThread.Join();

        }
        static void StartForm()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Klikacz());
        }
    }
}