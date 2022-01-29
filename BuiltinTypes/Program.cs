﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinTypes
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"byte: minimum {byte.MinValue}, maximum {byte.MaxValue}");
      Console.WriteLine($"sbyte: minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
      Console.WriteLine($"short: minimum {short.MinValue}, maximum {short.MaxValue}");

      var x = 234;
      Console.WriteLine(x.GetType());

      Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");
      Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");

      Console.WriteLine();

      Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");
      Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");

      float f = 123.456789012345678f;
      double d = 123.456789012345678;
      Console.WriteLine($" f is {f:F99}");
      Console.WriteLine($" d is {d:F99}");

      // var y = 123.4;
      // Console.WriteLine(y.GetType());

      decimal z = 123.4567890123456789012345678901234567890123456789m;
      Console.WriteLine();
      Console.WriteLine($"decimal: minimum {double.MinValue}, maximum {double.MaxValue}");
      System.Console.WriteLine($"z is {z:F99}");

    }
  }
}
