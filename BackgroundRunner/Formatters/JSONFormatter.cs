using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackgroundRunner.Formatters
{
    public static class JSONFormatter
    {
        public static string Format(string input)
        {
			try
			{
				dynamic parsedJson = JsonConvert.DeserializeObject(input);

				var result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
				return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
