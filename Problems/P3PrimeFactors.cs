using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems {
  public class P3PrimeFactors: ISolution {
    public string Description {
      get {
        return "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?";
      }
    }

    public void Solve() {
      const double Maximum = 600851475143;
      Console.WriteLine( Description ); 
      
      var factors = new List<double>();
      GetFactor( Maximum, factors );
      
      Console.WriteLine( "Result is {0} ", factors.Max() );
    }

    private static void GetFactor( double maximum, List<double> factors ) {
      for ( var x = 2; x <= maximum; x++ ) {
        var result = maximum / x;
        if ( result != Math.Round( result ) ) {
          continue;
        }

        if ( !factors.Contains( x ) ) {
          factors.Add( x );
        }

        if ( x == result || result == 1 ) {
          return;
        }

        GetFactor( result, factors );
        break;
      }
    }
  }
}
