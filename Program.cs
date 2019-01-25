using System;
using System.IO;
using System.Linq;
using System.Globalization;

namespace debugws2
{
  class Program
  {
    private long sum()
    {
      string[] data = File.ReadAllLines("data");
      long total = 0;

      for (int x = 0; x < data.Length; x++)
      {
        
        total += cnv(data[x]);
      }

      return total;
    }

    private int cnv(string val)
    {
      if(val.Contains('G'))
      {
      char[] ch = val.ToCharArray();
       ch[4] = 'E'; // index starts at 0!
      val = new string (ch);
      }
      Int32.TryParse(val, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value);

      return value;
    }

    static void Main(string[] args)
    {
      var p = new Program();
      Console.WriteLine("Total: {0}", p.sum());
    }
  }
}