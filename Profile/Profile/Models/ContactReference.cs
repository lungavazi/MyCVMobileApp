using SQLite;

namespace Profile.Models
{
    public class ContactReference
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public string UserName { get; set; }
        public string RefTitle { get; set; }
        public string RefName { get; set; }
        public string Relationship { get; set; }
        public string RefTelephone { get; set; }
        public string RefEmailAddre { get; set; }
    }
}
