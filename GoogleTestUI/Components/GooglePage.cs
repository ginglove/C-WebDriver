using Atata;

namespace GoogleTestUI.Components
{
    using _ = GooglePage;
    public class GooglePage : Page<_>
    {
        public H3<_> Title { get; private set; }
        [FindByXPath("input[@name='btnK']")]
        public Button<_> Search { get; private set; }
        [FindByXPath("input[@class='lsb']")]
        public Button<_> BtnSearch2 { get; private set; }
        [FindByXPath("input[@name='btnI']")]
        public Button<_> Lucky { get; private set; }
        [FindByXPath("input[@id='lst-ib']")]
        public TextInput<_> TxtSearch { get; private set; }
        [FindByXPath("h3[@class='r']/a[contains(@href,'google.com')]")]
        public Link<_> LnkGoogle { get; private set; }
        [FindByXPath("a[@href='https://vi-vn.facebook.com/']")]
        public Link<_> LnkFacebook { get; private set; }
        

    }
}
