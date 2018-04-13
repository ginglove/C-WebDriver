using System;
using Atata;
using NUnit.Framework;

namespace GoogleTestUI.Components
{
    public class UITests1 : UITestFixture
    {
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
                TxtSearch.Set("Facebook").
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
