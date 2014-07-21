using System;

namespace Problems {
  class Program {
    static void Main() {
      ISolve problem = new Problem5();
      problem.Solve();
      Console.ReadKey();
    }
  }
}