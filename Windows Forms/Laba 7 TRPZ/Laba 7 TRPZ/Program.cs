namespace Laba_7_TRPZ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Animal animal = new Dolphin("Oleg", 5, "male", "Pacific ocean", "No legs", "No tail", 35.61, "No fur", "Fish style", "Big", "Sonar", 45.2);
            animal.GetInformationInConsole();
        }
    }
}