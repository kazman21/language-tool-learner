namespace Language_Learning_Tool.Models
{
    // Alexander Borrmann - Set Daily Learning Goal
    // Stores the learner's target number of words to practice per session
    public class DailyGoal
    {
        public int TargetWordCount { get; set; }

        public DailyGoal()
        {
            TargetWordCount = 10;
        }
    }
}
