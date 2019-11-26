using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Profile.ViewModel;
using Profile.Models;


namespace UnitTestProject
{
    [TestClass]
    public class ProfileTest
    {
        AddEducationViewModel EducationViwModel;
        [TestMethod,Ignore]
        public void TestAddEducation()
        {
            EducationViwModel = new AddEducationViewModel();
            Education education = new Education{ InstitutionName = "NMMU", FromDate = DateTime.Now.Date, Status = "Completed" };
            Assert.AreEqual(true, EducationViwModel.ValidateSaveEducation(education,true));
        }

        [TestMethod]
        public void TestEmail()
        {
            string email = "LungaBhara@gmail.com";
            EducationViwModel = new AddEducationViewModel();
            Assert.AreEqual(true, EducationViwModel.ValidateEmail(email));
        }
    }
}
