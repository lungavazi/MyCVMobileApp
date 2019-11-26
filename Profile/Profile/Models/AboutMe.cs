using System;
using SQLite;
using Xamarin.Forms;

namespace Profile.Models
{
    public class AboutMe
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get ; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string IDNumber { get; set; }
        //public Image Image { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Boolean IsProfileActive { get; set; }
    }
}
