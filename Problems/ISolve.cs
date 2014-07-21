namespace Problems {

  /// <summary>
  /// Solution interface implement solve for the problems 
  /// </summary>
  public interface ISolution {
    /// <summary>
    /// Gets Problem Description 
    /// </summary>
    string Description { get; }

    /// <summary>
    /// solution for the problem. 
    /// </summary>
    void Solve();
  }
}