using System;
using Atata;
using NUnit.Framework;
using GoogleTestUI.Supports;

namespace GoogleTestUI.Components
{
    public class UITests1 : UITestFixture
    {
        Support tr = new Support();
        String path = @"C:\Users\gianglt\Desktop\ExampleTest.json";
        [Test]
        [Category("VerifySearchFunction")]
        public void HandleSearchGoogle()
        {
            Go.To<GooglePage>().
                TxtSearch.Set("Google").
                BtnSearch2.Click().
                Wait(10).
                LnkGoogle.Exists();
        }
        [Test]
        [Category("VerifySearchFunction")]
        public void HandleSearchFacebook()
        {
            Go.To<GooglePage>().
                TxtSearch.Set(tr.GetJsonData("SearchValue", path)).
                Wait(10).BtnSearch2.Click().
                Wait(10).LnkFacebook.Exists();
        }
        [Test]
        [Category("VerifySearchAndOpenFacebook ")]
        public void HandleSearchAndOpenFacebook()
        {
            Go.To<GooglePage>().
                  Do(temp => { HandleSearchFacebook(); }).
                  LnkFacebook.Click();
            Go.To<FacebookPage>().
                Wait(5).imgFacebook.Exists();
        }
        [Test]
        [Category("VerifyLoginFacebook")]
        public void HandleLoginFacebook()
        {
            Go.To<FacebookPage>().
                Do(temp => { HandleSearchAndOpenFacebook(); });
        }
    }
}
