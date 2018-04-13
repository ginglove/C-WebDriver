using Atata;

namespace GoogleTestUI.Components
{
    using _ = FacebookPage;

    public class FacebookPage : Page<_>
    {
        [FindByXPath("i[@class='fb_logo img sp_Ql3TJxfFsAW sx_bf51ef']")]
        public Label<_> imgFacebook { get; private set; }
        //[FindByXPath("")]
    }
}
