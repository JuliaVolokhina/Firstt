using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    static class FileReading
    {
        public static Round Reading(string FileName)
        {
            Round round = null;
            StreamReader filein = new StreamReader(FileName);
            char[] charSeparators = new char[] { ' ', '\n' };
            string[] line = filein.ReadToEnd().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (double.TryParse(line[0], out double x))
            {
                if (double.TryParse(line[1], out double y))
                {
                    if (double.TryParse(line[2], out double r) && (r > 0))
                    {
                        round = new Round(x, y, r);
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
            }
            return round;
        }
    }
}