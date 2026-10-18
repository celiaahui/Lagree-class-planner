namespace LagreeClassPlanner;
/// <summary>
/// Represents a Lagree exercise created by the user.
/// An exercise must have a name and may optionally have a duration
/// </summary>
public class Exercise
{
    /// <summary>
    /// Gets or sets the exercise name.
    /// </summary>
    public String Name { get; set; }
    
    /// <summary>
    /// Get or set the exercise duration in seconds.
    /// A null value means that no duration has been assigned yet. 
    /// </summary>
    public int? DurationSeconds { get; set; }
   

    /// <summary>
    /// Single argument constructor that sets the name of the exercise. 
    /// </summary>
    /// <param name="name"></param>
    public Exercise(string name)
    {
        Name = name;
    }
    
    
}