using Language_Learning_Tool.Models;

namespace Language_Learning_Tool
{
    // Shared in-memory state accessible across all forms during one run of the app
    public static class AppSession
    {
        public static SessionProgress Progress { get; set; } = new SessionProgress();
        public static DailyGoal Goal { get; set; } = new DailyGoal();
    }
}
