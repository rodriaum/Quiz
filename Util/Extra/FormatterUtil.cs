using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Util.Extra
{
    internal class FormatterUtil
    {
        public static string NumberFormatter(long n)
        {
            string s = n.ToString();

            if (s.Length > 1)
                s = $"0{s}";

            return s;
        }

        public static string TimeFormatted()
        {
            DateTime now = DateTime.Now;

            return $"{NumberFormatter(now.Hour)}:{NumberFormatter(now.Minute)}:{NumberFormatter(now.Second)}:{NumberFormatter(now.Millisecond)}";
        }

        public static string RemoveAccents(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
