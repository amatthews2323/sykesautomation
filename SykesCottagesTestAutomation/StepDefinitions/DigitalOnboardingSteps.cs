using System;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class DigitalOnboadingSteps : MethodLibrary
    {
        public DigitalOnboadingSteps(SharedDriver context) : base(context)
        {
        }

        public string emailAddress;
        public string postcode;

        [When(@"I enter the following details on the enquiry form")]
        public void WhenIEnterTheFollowingDetailsOnTheEnquiryForm(Table table)
        {
            var dictionary = ToDictionary(table);
            Type("heroform_first_name", dictionary["Full name"]);

            if (dictionary["Email address"] == "Random")
            {
                Random r = new Random();
                emailAddress = "automation" + r.Next(100000, 999999).ToString() + "@yahoo.com";
                Type("heroform_email", emailAddress);
            }
            else
            {
                Type("heroform_email", dictionary["Email address"]);
            }

            Type("heroform_phone", dictionary["Phone number"]);
            Click("form-heading-container", waitTime: 2);
        }

        [When(@"I select Get Started")]
        public void WhenISelectGetStarted()
        {
            Click("//form[@*='heroform']//*[contains(@class,'enquiry-button')]", waitTime: 1);
        }


        [When(@"I submit the enquiry form")]
        public void WhenISubmitTheEnquiryForm()
        {
            if (Hooks.environemt != "Live")
            {
                Click("//form[@*='heroform']/button[@*='submit']", waitTime: 4);
            }
            else
            {
                Console.WriteLine("DON'T SUBMIT ENQUIRIES ON LIVE!!");
            }
        }

        [Then(@"I am directed to the Property Letting Dashboard page")]
        public void ThenIAmDirectedToThePropertyLettingDashboardPage()
        {
            if (Hooks.environemt != "Live")
            {
                AssertPageTitle("Thank you for your enquiry | Sykes Cottages");
            }
            else
            {
                Console.WriteLine("Step skipped on Live environment");
            }
        }

        [Then(@"I can add a property with the following postcode: (.*)")]
        public void ThenICanAddAPropertyWithTheFollowingPostcode(string _postcode = "Random")
        {
            Click("I have a property I’d like to list");
            Click("Next", waitTime: 2);
            if (_postcode == "Random")
            {
                _postcode = GetPostcode();
            }
            postcode = _postcode;
            Type("location", postcode);
            Click("Search", waitTime: 2);
            ClickIfDisplayed("Expand area", waitTime: 1);
            Click("Select Address", waitTime: 3);
            Click("Finish", waitTime: 2);
        }

        [When(@"I select Get Started Online")]
        public void WhenISelectGetStartedOnline()
        {
            ClickIfDisplayed("Get started online");
            ClickIfDisplayed("thankyoulycgetstartedonline");
        }

        [Then(@"I can create an account using password: (.*)")]
        public void ThenICanCreateAnAccountUsingPassword(string password)
        {
            WaitASecond(2);
            Click("//button/span[contains(text(),'Start taking bookings')]", waitTime: 2);
            Type("digital-onboarding-password", password);
            Click("Create my account");
        }

        [Then(@"I can register my account via the email")]
        public void ThenICanRegisterMyAccountViaTheEmail()
        {
            GoTo("https://mailcatcher.staging.sykes.cloud/");
            Click("//td[text()='<" + emailAddress + ">']", waitTime: 1);
            string emailUrl = GetAttribrute("//dd[text()='<" + emailAddress + ">']/ancestor::article/iframe", "src");
            GoTo(emailUrl);
            SetBrowserSize();
            Click("Verify your account", waitTime: 5);
        }

        [Then(@"I can sign in to my account using the following details")]
        public void ThenICanSignInToMyAccountUsingTheFollowingDetails(Table table)
        {
            var dictionary = ToDictionary(table);
            if (dictionary["Username"] == "Random")
            {
                Type("email", emailAddress);
            }
            else
            {
                Type("email", dictionary["Username"]);
            }
            Type("password", dictionary["Password"]);
            Click("submit", "input", waitTime:3);
        }

        [Then(@"I can complete Additional Property Details Step 1 - Property Location")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep1PropertyLocation()
        {
            Screenshot("DO - Additional Property Details - Step 1 - Property Location");
            AssertTextDisplayed("Property Location");

            JSType("digital-onboarding-directions-to-property", "Automated test");
            JSClick("Directions to your property");
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 2 - Guests and bedrooms")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep2GuestsAndBedrooms(Table table)
        {
            Screenshot("DO - Additional Property Details - Step 2 - Guests and bedrooms");
            AssertTextDisplayed("How many guests can your property sleep?");

            var dictionary = ToDictionary(table);
            int guests = int.Parse(dictionary["Number of guests"]);
            for (int i = 1; i < guests; i++)
            {
                JSClick("//input[@name='ds_guests']/following-sibling::*");
            }
            int bedrooms = int.Parse(dictionary["Number of bedrooms"]);
            for (int i = 1; i < bedrooms; i++)
            {
                JSClick("//input[@name='ds_bedroom_count']/following-sibling::*");
            }
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 3 - Photos of your property")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep3PhotosOfYourProperty()
        {
            Screenshot("DO - Additional Property Details - Step 3 - Photos of your property");
            AssertTextDisplayed("Photos of your property");

            JSClick("//button/span[contains(text(),'Next')]", waitTime: 2);
            Type("//textarea[@id='upload-images-reason']", "Automated test", waitTime: 1);
            JSClick("//button/span[contains(text(),'Continue')]", waitTime: 5);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 4 - About your property")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep4AboutYourProperty()
        {
            Screenshot("DO - Additional Property Details - Step 4 - About your property");
            AssertTextDisplayed("About your property");

            Type("digital-onboarding-property-address", text: "Test", waitTime: 1);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 5);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 5 - Key Collection")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep5KeyCollection()
        {
            Screenshot("DO - Additional Property Details - Step 5 - Key Collection");
            AssertTextDisplayed("Key Collection");

            JSClick("//span[text()='Other']", waitTime: 1);
            Type("//textarea[@id='key-collection-alt-instructions']", "Test");
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 6 - Booking details")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep6BookingDetails()
        {
            Screenshot("DO - Additional Property Details - Step 6 - Booking details");
            AssertTextDisplayed("Booking details");

            JSType("digital-signup-booking-start-date-hidden-input", DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"));
            JSType("digital-signup-booking-start-date", DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"), waitTime: 1);
            JSClick("//span[text()='Friday']");
            JSClick("//span[@class='c-selection-button__label' and text()='Yes']", waitTime: 1);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Additional Property Details Step 7 - Upcoming bookings")]
        public void ThenICanCompleteAdditionalPropertyDetailsStep7UpcomingBookings()
        {
            Screenshot("DO - Additional Property Details - Step 7 - Upcoming bookings");
            AssertTextDisplayed("Upcoming bookings");

            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Personal Details Step 1 - Personal details")]
        public void ThenICanCompletePersonalDetailsStep1PersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 1 - Personal details");
            AssertTextDisplayed("Personal details");

            Type("//input[@id='digital-onboarding-owner-postcode']", text: "SK101NH", waitTime: 3);
            JSClick("//div[@aria-expanded='true']//button/span[contains(text(),'Search')]", waitTime: 2);
            JSClick("//button[@aria-label='Select Address']", waitTime: 2);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Personal Details Step 2 - Your bank details")]
        public void ThenICanCompletePersonalDetailsStep2YourBankDetails()
        {
            Screenshot("DO - Personal Details - Step 2 - Your bank details");
            AssertTextDisplayed("Your bank details");

            Type("//input[@id='digital-onboarding-account-name']", "Test");
            Type("//input[@id='digital-onboarding-account-number']", "01010101");
            Type("//input[@id='digital-onboarding-sort-code']", "010101", waitTime: 1);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Personal Details Step 3 - File uploads")]
        public void ThenICanCompletePersonalDetailsStep3FileUploads()
        {
            Screenshot("DO - Personal Details - Step 3 - File uploads");
            AssertTextDisplayed("File uploads");

            JSClick("//*[@*='digital-onboarding-gas-certificate-no']", waitTime: 1);
            JSClick("//*[@*='digital-onboarding-liability-certificate-no']", waitTime: 1);
            JSClick("//*[@*='digital-onboarding-fire-certificate-no']", waitTime: 1);
            JSClick("//*[@*='digital-onboarding-waterSupply-certificate-no']", waitTime: 1);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Personal Details Step 4 - Select commission tier")]
        public void ThenICanCompletePersonalDetailsStep4SelectCommissionTier()
        {
            Screenshot("DO - Personal Details - Step 4 - Select commission tier");
            AssertTextDisplayed("Select commission tier");

            JSClick("//*[@*='commission-full']", waitTime: 1);
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 3);
            //Refresh();
        }

        [Then(@"I can complete Personal Details Step 5 - Property Pricing")]
        public void ThenICanCompletePersonalDetailsStep5PropertyPricing()
        {
            Screenshot("DO - Personal Details - Step 5 - Property Pricing");
            AssertTextDisplayed("Property Pricing");

            WaitUntilVisible("52 week breakdown");
            JSClick("//button/span[contains(text(),'Next')]", waitTime: 5);
            //Refresh();
        }

        [Then(@"I can sign the contract and complete digital onboarding")]
        public void ThenICanSignTheContractAndCompleteDigitalOnboarding()
        {
            Screenshot("DO - Contract Signing");
            AssertTextDisplayed("Your online agreement");

            JSClick("//*[@*='do_contract_sole_owner']");
            JSClick("//span[text()='I accept the terms and conditions']", waitTime: 2);
            Type("//input[@id='do_contract_signature']", "Automated Test", waitTime: 2);
            JSClick("//button/span[contains(text(),'Submit Contract')]", waitTime: 5);
        }
    }
}
