using System;

namespace Problems {
  public class P8PythagoreanTriplet: ISolution {
    public string Description {
      get {
        return "A Pythagorean triplet is a set of three natural numbers, a < b < c, "
          + "for which, a2 + b2 = c2 "
          + "For example, 32 + 42 = 9 + 16 = 25 = 52."
          + "There exists exactly one Pythagorean triplet for which a + b + c = 1000."
          + "Find the product abc.";
      }
    }

    public void Solve() {
      const int Target = 1000;
      Console.WriteLine( Description );

      for ( var c = 1; c < Target; c++ ) {
        for ( var b = 1; b < c; b++ ) {
          for ( var a = 1; a < b; a++ ) {
            if ( a + b + c != Target ) {
              continue;
            }

            if ( ( ( a * a ) + ( b * b ) ) == ( c * c ) ) {
              Console.WriteLine( "Result is {0}, {1}, {2}, it's product is {3}", a, b, c, a * b * c );
            }
          }
        }
      }
    }
  }
}