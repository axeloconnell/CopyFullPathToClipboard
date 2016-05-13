namespace SetClipboard
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
            // We only execute something if the app has at least one argument.
            if (arguments.Length > 0)
            {
                string text = string.Join(" ", arguments);
                Clipboard.SetText(text);
            }
        }
    }
}
