using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace BackgroundRunner.Formatters
{
    public static class CommaSeperator
    {
        public static string Format(string input, string quoteType = null)
        {
            string splitter = DetectSplit(input);

            var splitString = input.Split(new string[] { splitter }, StringSplitOptions.None).Where(x => !string.IsNullOrEmpty(x)).ToList();

            quoteType = quoteType ?? getQuoteType(splitString);

            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            foreach(var each in splitString)
            {
                sb.Append(quoteType).Append(each).Append(quoteType).Append(",");
            }
            sb.Append(")");
            sb.Remove(sb.Length - 2, 1);
            return sb.ToString();
        }
        private static string DetectSplit(string input)
        {
            return input.Any(x => x == '\n') ? Environment.NewLine : " ";
        }

        private static string getQuoteType(List<string> items)
        {
            int tempint;
            decimal tempdecimal;
            foreach (string each in items)
            {
                if (int.TryParse(each, out tempint))
                {
                    if (each.Length > 10)
                    {
                        return "'"; //raincheck
                    }
                    //int
                }
                else if (decimal.TryParse(each, out tempdecimal))
                {
                    if (tempdecimal > int.MaxValue)
                    {
                        return "'";
                    }
                    //decimal
                }
                else if (each.StartsWith("0x") && each.Length == 130)
                {
                    //sha-512 hash... probably
                }
                else
                {
                    return "'";
                }
            }
            return "";
        }
    }
}
