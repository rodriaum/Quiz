namespace Quiz.Util.Extra
{

    /*
     * TEST
     */

    internal class LogUtil
    {
        /* Procedures */

        public static void Log(string prefix, string message, bool box = false, string error = "")
        {
            Console.WriteLine(Output(prefix, message, box, error));
        }

        public static async Task LogAsync(string prefix, string message, bool box = false, string error = "")
        {
            await Console.Out.WriteLineAsync(Output(prefix, message, box, error));
        }

        /* Functions */

        private static string Output(string prefix, string message, bool box, string error)
        {
            bool isError = !string.IsNullOrEmpty(error);

            DialogResult dialog = MessageBox.Show(message, prefix, 
                (isError ? MessageBoxButtons.OKCancel : MessageBoxButtons.OK), 
                (isError ? MessageBoxIcon.Error : MessageBoxIcon.Information));

            if (dialog == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }

            return $"{FormatterUtil.TimeFormatted} - {(isError ? "ERROR" : "INFO")} {(!string.IsNullOrEmpty(prefix) ? $"{prefix}: " : "")}{message}{(isError ? $"\n -> {error}" : "")}";
        }
    }
}