using SQLite;
using System;

namespace Profile.Models
{
    public class WorkHistory
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public string UserName { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string WorkDescription { get; set; }
        public string Achievements { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsCurrentJob { get; set; }
    }
}
