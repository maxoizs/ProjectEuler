using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems {
  public class Problem3: ISolve {
    public string Description {
      get {
        return "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?";
      }
    }

    public void Solve() {
      const double Maximum = 600851475143;
      var factors = new List<double>();
      getFactor( Maximum, factors );

      Console.WriteLine( Description );

      Console.WriteLine( "Result is {0} ", factors.Max() );
    }

    private static void getFactor( double Maximum, List<double> factors ) {
      for ( var x = 2; x <= Maximum; x++ ) {
        var result = Maximum / x;
        if ( result != Math.Round( result ) ) {
          continue;
        }

        if ( !factors.Contains( x ) ) {
          factors.Add( x );
        }

        if ( x == result || result == 1 ) {
          return;
        }

        getFactor( result, factors );
        break;
      }
    }
  }
}