using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSQLFormatter;

namespace BackgroundRunner.Formatters
{
    public static class SqlFormatter
    {
        public static string Format(string input)
        {
			try
			{
				string output = new SQLFormatter(input).Format();
				return output;
			}
			catch (Exception)
			{

				throw;
			}

			return "";
        }
    }
}
