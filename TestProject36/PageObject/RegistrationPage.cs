using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject36.Utilities;

namespace TestProject36.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[1]/input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("#eid > input"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(2) > input"));
        IWebElement SubmitButton => driver.FindElement(By.XPath("//*[@id='submitbtn']"));
      
        public void EnterFirstName()
        {
            FirstName.SendKeys("Owusu");
        }


        public void EnterLastName()
        {
            LastName.SendKeys("Siaw");
        }


        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("owusu.siaw@gmail.com");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
        }

        public void EnterPhoneNumber()
        {
            PhoneNumber.SendKeys("0233556677");
        }


        public void ClickOnGender()
        {
            Gender.Click();
        }


        public void ClickOnSubmitButton()
        {
            SubmitButton.Click();
        }



    }
}
