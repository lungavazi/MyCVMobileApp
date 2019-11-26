using System.Collections.Generic;
using SQLite;
using Profile.Models;
using System.IO;
using System;

namespace Profile.Data
{
    public class DataBase
    {
        private readonly SQLiteConnection _db;
        private string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pofile.db3");

        public DataBase()
        {
            _db = new SQLiteConnection(_path);
            _db.CreateTable<AboutMe>();
            _db.CreateTable<Achievements>();
            _db.CreateTable<ContactReference>();
            _db.CreateTable<Education>();
            _db.CreateTable<WorkHistory>();
            _db.CreateTable<User>();
            //SaveUser();

        }

        //private void SaveUser()
        //{
        //    User user = new User { UserName = "Lunga.vazi", Password = "Lunga.vazi" };
        //    _db.Insert(user);
        //}

        public AboutMe GetProfile(string username)
        {
            return _db.Table<AboutMe>().Where(c => c.UserName.ToUpper() == username.ToUpper()).FirstOrDefault();
        }

        public List<Education> GetAcademicList(string username)
        {
            return _db.Table<Education>().Where(c => c.UserName.ToUpper() == username.ToUpper()).ToList();
                  }
        public AboutMe GetProfileByEmail(string email)
        {
            return _db.Table<AboutMe>().Where(c => c.Email.ToUpper() == email.ToUpper()).FirstOrDefault();
        }

        public List<WorkHistory> GetWorkHistoryList(string username)
        {
            return _db.Table<WorkHistory>().Where(c => c.UserName.ToUpper() == username.ToUpper()).ToList();          
        }

        public int SaveEducation(Education education)
        {
            if (education.ID == 0)
            {
                return _db.Insert(education);
            }
            else
            {
                return _db.Update(education);
            }
        }

        public int DeleteEducation(Education education)
        {
            return _db.Delete(education);
        }

        public int SaveProfile(AboutMe profile)
        {
            if (profile.ID == 0)
            {
            return _db.Insert(profile);
            }
            else
            {
                return _db.Update(profile);
            }
        }

        public int SaveUser(User User)
        {
            if (User.ID == 0)
            {
                return _db.Insert(User);
            }
            return User.ID;
            //else
            //{
            //    return _db.Update(User);
            //}
        }

        public User GetUserData(string username, string password)
        {
            return _db.Table<User>().Where(c => c.UserName.ToUpper() == username.ToUpper() && c.Password == password).FirstOrDefault();
        }

        public int SaveWorkHistory(WorkHistory work)
        {
            if (work.ID == 0)
            {
                return _db.Insert(work);
            }
            else
            {
                return _db.Update(work);
            }
        }

        public int DeleteAcount(AboutMe profile)
        {
            return _db.Delete(profile);
        }
    }
}
