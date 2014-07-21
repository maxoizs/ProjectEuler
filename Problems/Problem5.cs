using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems {
  public class Problem5: ISolve {
    public string Description {
      get {
        return "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder."
               + "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
      }
    }

    public void Solve() {
      var dividers = GetDividers( 20 );
      for ( var x = 1; ; x++ ) {
        if ( dividers.Any( d => x % d != 0 ) ) {
          continue;
        }

        Console.WriteLine( Description );
        Console.WriteLine( "Result is {0} ", x );
        return;
      }
    }

    private List<int> GetDividers( int number ) {
      var dividers = new Dictionary<int,bool>();
      for ( var x = 2; x <= number; x++ ) {
        if ( !dividers.ContainsKey( x ) ) {
          dividers.Add(x, false );
        }
        for ( var y = number; y >= x; y-- ) {
          dividers[y] = true; 
          if ( y != x && y % x == 0 ) {
            dividers[x] = false;
            break;
          }
        }
      }

      return dividers.Where( d => d.Value ).Select( d => d.Key ).ToList();
    }
  }
}