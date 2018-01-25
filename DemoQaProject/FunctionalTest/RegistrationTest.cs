using System;
using DemoQaProject.PageObjectClasses;
using DemoQaProject.ProjectSetup;
using FrameworkLibraries.Libraries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace DemoQaProject.FunctionalTest
{
    [TestClass]
    public class RegistrationTest:ProjectConfig
    {
        HomePage homepage;
        RegistrationPage registrationpage;

        [SetUp]
        public void SetUp()
        {
            StartAUT();
            homepage = new HomePage();
        }
        [Test]
        public void Registration()
        {
            registrationpage =  homepage.ClckRegistration();
            registrationpage.EnterFirstname("Abake");
            registrationpage.EnterLastname("Oyewole");
            registrationpage.MaritalStatus("Single");
            registrationpage.HobbySelection("reading");
            registrationpage.SelectCountry("Nigeria");
            
            SelectUtils.ImplicitWait(2000);
            registrationpage.DateOfBirth("5", "5", "1989");
           
            registrationpage.PhoneNumber("123456789");
            registrationpage.AboutYourself("I\nam\nTaiwo Oluokun");
            registrationpage.UserName("TeeMax");
            registrationpage.EmailAddress("abake1@yahoo.com");
            registrationpage.Password("lolumi");
            registrationpage.ConfirmPassword("lolumi");
            registrationpage.SelectProfilePix(@"c:\Users\Benjamin\Desktop\FVT.PNG");

        }
        [TearDown]
        public void CloseDriver()
        {

            DriverContent.Driver.Quit();
        }
    }
}
