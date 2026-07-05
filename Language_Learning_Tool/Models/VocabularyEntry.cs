namespace Language_Learning_Tool.Models
{
    public class VocabularyEntry
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string ExampleSentence { get; set; }
        public string Category { get; set; }

        public VocabularyEntry()
        {
            Category = "Uncategorized";
        }
    }
}
