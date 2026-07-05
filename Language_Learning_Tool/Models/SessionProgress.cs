using System.Collections.Generic;

namespace Language_Learning_Tool.Models
{
    // Munaf Kazi - Track Progress / Review Incorrect Answers
    // Holds in-memory stats for the current session only; not saved to disk
    public class SessionProgress
    {
        public int QuizzesTaken { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalQuestions { get; set; }
        public int FlashcardWordsPracticed { get; set; }
        public List<VocabularyEntry> IncorrectWords { get; set; }

        public SessionProgress()
        {
            IncorrectWords = new List<VocabularyEntry>();
        }

        public double AverageScore
        {
            get
            {
                if (TotalQuestions == 0) return 0.0;
                return (double)TotalCorrect / TotalQuestions * 100.0;
            }
        }
    }
}
