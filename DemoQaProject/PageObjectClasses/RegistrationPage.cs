using FrameworkLibraries.Libraries;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace DemoQaProject.PageObjectClasses
{
    class RegistrationPage : BaseConstructor
    {
        [FindsBy(How = How.Id, Using = ("name_3_firstname"))]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = ("name_3_lastname"))]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='single']"))]
        public IWebElement btnSingle { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='married']"))]
        public IWebElement btnMarried { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='divorced']"))]
        public IWebElement btnDivorced { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='dance']"))]
        public IWebElement btnHobbyDance { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='reading']"))]
        public IWebElement btnHobbyReading { get; set; }

        [FindsBy(How = How.CssSelector, Using = ("input[value='cricket']"))]
        public IWebElement btnHobbyCricket { get; set; }

        [FindsBy(How = How.Id, Using = ("dropdown_7"))]
        public IWebElement drpdwnCountrySelection { get; set; }

        [FindsBy(How = How.Id, Using = ("mm_date_8"))]
        public IWebElement drpdwnDobMonth { get; set; }

        [FindsBy(How = How.Id, Using = ("dd_date_8"))]
        public IWebElement drpdwnDobDay { get; set; }

        [FindsBy(How = How.Id, Using = ("yy_date_8"))]
        public IWebElement drpdwnDobYear { get; set; }

        [FindsBy(How = How.Id, Using = ("phone_9"))]
        public IWebElement txtPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = ("username"))]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = ("email_1"))]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = ("profile_pic_10"))]
        public IWebElement btnProfilePicture { get; set; }

        [FindsBy(How = How.Id, Using = ("description"))]
        public IWebElement txtAboutYourself { get; set; }

        [FindsBy(How = How.Id, Using = ("password_2"))]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = ("confirm_password_password_2"))]
        public IWebElement txtConfirmPassword { get; set; }

        public void EnterFirstname(string Firstname)
        {
            txtFirstName.SendKeys(Firstname);
        }
        public void EnterLastname(string Lastname)
        {
            txtLastName.SendKeys(Lastname);
        }
        public void MaritalStatus(string status)
        {
            if (status.Equals("single", StringComparison.InvariantCultureIgnoreCase))
                btnSingle.Click();
            else if (status.Equals("married", StringComparison.InvariantCultureIgnoreCase))
                btnMarried.Click();
            else if (status.Equals("divorced", StringComparison.InvariantCultureIgnoreCase))
                btnDivorced.Click();
        }
        public void HobbySelection(string hobby)
        {
            if (hobby.Equals("dance", StringComparison.InvariantCultureIgnoreCase))
                btnHobbyDance.Click();
            else if (hobby.Equals("reading", StringComparison.InvariantCultureIgnoreCase))
                btnHobbyReading.Click();
            else if (hobby.Equals("cricket", StringComparison.InvariantCultureIgnoreCase))
                btnHobbyCricket.Click();
        }
        public void SelectCountry(string EnterCountry)
        {
            SelectUtils.SelectElement(drpdwnCountrySelection, "value", EnterCountry);
        }
        public void DateOfBirth(string MonthInNumeric, string Day, string year)
        {
            SelectUtils.SelectElement(drpdwnDobMonth, "value", MonthInNumeric);
            SelectUtils.SelectElement(drpdwnDobDay, "value", Day);
            SelectUtils.SelectElement(drpdwnDobYear, "value", year);

        }

        public void PhoneNumber(string number)
        {
            txtPhoneNumber.SendKeys(number);
        }
        public void UserName(string userName)
        {
            txtUsername.SendKeys(userName);
        }
        public void EmailAddress(string email)
        {
            txtEmail.SendKeys(email);
        }
        public void SelectProfilePix(string pathToPix)
        {
            btnProfilePicture.SendKeys(pathToPix);
        }
        public void AboutYourself(string aboutYourself)
        {
            txtAboutYourself.SendKeys(aboutYourself);
        }
        public void Password(string password)
        {
            txtPassword.SendKeys(password);
        }
        public void ConfirmPassword(string confirmPassword)
        {
            txtConfirmPassword.SendKeys(confirmPassword);
        }


    }


}
