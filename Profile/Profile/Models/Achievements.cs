using SQLite;

namespace Profile.Models
{
    public class Achievements
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }    
        [Indexed]
        public string UserName { get; set; }
        public string AchievementName { get; set; }
        public string AchievementDescription { get; set; }
        public string AchievementYear { get; set; }
        public string InstitutionName { get; set; }
        public string AchievementType { get; set; }
    }
}
