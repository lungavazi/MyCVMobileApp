using SQLite;
using System;

namespace Profile.Models
{
    public class Education
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string QualilificationName { get; set; }
        public string InstitutionName { get; set; }
        public string QualificationLevel { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; } 
        public string Status { get; set; }
        //public string Achivements { get; set; }
    }
}