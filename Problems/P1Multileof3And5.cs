using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problems {
  public class P1Multipleof3And5: ISolution {
    public string Description {
      get {
        return "If we list all the natural numbers below 10 that are multiples of 3 or 5,"
               + " we get 3, 5, 6 and 9. The sum of these multiples is 23."
               + "Find the sum of all the multiples of 3 or 5 below 1000.";
      }
    }

    public void Solve() {
      const int Maximum = 1000;
      var dividers = new List<int> { 3, 5 };
      var multiples = new List<int>();

      for ( int x = 1; x < Maximum; x++ ) {
        if ( dividers.Any( number => x % number == 0 ) ) {
          multiples.Add( x );
        }
      }

      Console.WriteLine( Description );
      Console.WriteLine( "Result is {0} ", multiples.Sum().ToString( CultureInfo.InvariantCulture ) );
    }
  }
}