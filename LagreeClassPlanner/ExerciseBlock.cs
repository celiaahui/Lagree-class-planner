namespace LagreeClassPlanner;

/// <summary>
/// Represents a section of a Lagree class containing multiple exercises.
/// Examples include Upper Body, Lower Body, Core , Hamstrings, or any custom block name. 
/// </summary>
public class ExerciseBlock
{
   
        /// <summary>
        /// Gets or sets the name of the exercise block . 
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///  Gets or sets the exercises contained in this block.
        /// </summary>
        public List<Exercise> Exercises { get; set; }

        
        public ExerciseBlock(string name)
        {
                Name = name;
                Exercises = new List<Exercise>();
        }

        /// <summary>
        /// This methods add a new exercise in the exercise block 
        /// </summary>
        /// <param name="exo"></param>
        public void AddExercise(string exo)
        {
                Exercises.Add(new Exercise(exo));
        }

        /// <summary>
        /// Assigns a duration to an exercise in the block.
        /// If the exercise does not already exist, it is created and added.
        /// </summary>
        /// <param name="time">The duration in seconds.</param>
        /// <param name="exo">The name of the exercise.</param>
        public void SetTime(int time, string exo)
        {

                Exercise? exercise = Exercises.Find(e => e.Name == exo);
                if (exercise != null)
                {
                        exercise.DurationSeconds = time;
                }
                else
                {
                        Exercise newExercise = new Exercise(exo);
                        Exercises.Add(newExercise);
                }
        }
        
}