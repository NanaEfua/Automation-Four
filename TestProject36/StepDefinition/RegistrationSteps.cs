using System;
using TechTalk.SpecFlow;
using TestProject36.PageObject;

namespace TestProject36.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [Given(@"I enter my last name")]
        public void GivenIEnterMyLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [Given(@"I enter my phone number")]
        public void GivenIEnterMyPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }
        
        [Given(@"I click on my gender")]
        public void GivenIClickOnMyGender()
        {
            registrationPage.ClickOnGender();
        }
        
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            registrationPage.ClickOnSubmitButton();
        }
        
        [Then(@"I can register successfully")]
        public void ThenICanRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
