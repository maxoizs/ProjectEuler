using System;
using System.Linq;

namespace Problems {
  public class Problem4: ISolution {
    public string Description {
      get {
        return "A palindromic number reads the same both ways. "
               + "The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99."
               + "Find the largest palindrome made from the product of two 3-digit numbers.";
      }
    }

    public void Solve() {
      const int Maximum = 999;
      for ( var x = Maximum; x > 0; x-- ) {
        for ( var y = Maximum; y >= x; y-- ) {
          if ( IsPalindromic( x * y ) ) {
            Console.WriteLine( Description );
            Console.WriteLine( "Result is {0} and {1} = {2} ", x, y, x * y );
            return;
          }
        }
      }
    }

    private bool IsPalindromic( int number ) {
      var digits = number.ToString().Select( c => int.Parse( c.ToString() ) ).ToList();
      var count = digits.Count;
      if ( count % 2 != 0 ) {
        digits.Remove( count / 2 );
      }
      for ( var x = 0; x < count; x++ ) {
        if ( digits[x] != digits[digits.Count - 1 - x] ) {
          return false;
        }
      }
      return true;
    }
  }
}