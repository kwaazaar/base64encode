using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Encode
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("base64encode <filename> [--oneline]");
                return 1;
            }

            try
            {
                var base64string = Convert.ToBase64String(File.ReadAllBytes(args[0]));
                if (args.Length > 1 && args[1].Equals("--oneline", StringComparison.OrdinalIgnoreCase))
                    base64string = base64string.Replace("\n", "");
                Console.WriteLine(base64string);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 2;
            }
        }
    }
}
