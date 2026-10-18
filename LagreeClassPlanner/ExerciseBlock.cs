namespace LagreeClassPlanner;

public class ExerciseBlock
{
   
        public string Name { get; set; }
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