using System.Text;

namespace Quiz.Util.Extra
{
    internal class TimeUtil
    {
        public static string FormatTime(long seconds, bool shortFormat = false)
        {
            long years = seconds / (365 * 86400); // 365 dias em um ano
            seconds %= (365 * 86400);

            long months = seconds / (30 * 86400); // 30 dias em um mês
            seconds %= (30 * 86400);

            long weeks = seconds / (7 * 86400); // 7 dias em uma semana
            seconds %= (7 * 86400);

            long days = seconds / 86400; // 86400 segundos em um dia
            seconds %= 86400;

            long hours = seconds / 3600; // 3600 segundos em uma hora
            seconds %= 3600;

            long minutes = seconds / 60; // 60 segundos em um minuto
            seconds %= 60;

            StringBuilder result = new StringBuilder();

            if (years > 0)
            {
                result.Append(years).Append(shortFormat ? " a" : " ano").Append(years > 1 ? (shortFormat ? "s" : "s") : "").Append(", ");
            }
            if (months > 0)
            {
                result.Append(months).Append(shortFormat ? " ms" : " mes").Append(months > 1 ? (shortFormat ? "s" : "es") : "").Append(", ");
            }
            if (weeks > 0)
            {
                result.Append(weeks).Append(shortFormat ? " sem" : " semana").Append(weeks > 1 && !shortFormat ? "s" : "").Append(", ");
            }
            if (days > 0)
            {
                result.Append(days).Append(shortFormat ? " d" : " dia").Append(days > 1 && !shortFormat ? "s" : "").Append(", ");
            }
            if (hours > 0)
            {
                result.Append(hours).Append(shortFormat ? " h" : " hora").Append(hours > 1 && !shortFormat ? "s" : "").Append(", ");
            }
            if (minutes > 0)
            {
                result.Append(minutes).Append(shortFormat ? " m" : " minuto").Append(minutes > 1 && !shortFormat ? "s" : "").Append(", ");
            }
            if (seconds > 0)
            {
                result.Append(seconds).Append(shortFormat ? " s" : " segundo").Append(seconds > 1 && !shortFormat ? "s" : "");
            }

            if (result.Length > 0)
            {
                string time = result.ToString();

                if (time.EndsWith(", "))
                    time = time.Substring(0, time.Length - 2) + ".";

                return time;
            }

            return "0 " + (shortFormat ? "s" : "segundos");
        }

    }
}