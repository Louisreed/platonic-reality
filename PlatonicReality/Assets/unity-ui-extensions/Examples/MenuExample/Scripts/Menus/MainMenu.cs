namespace UnityEngine.UI.Extensions.Examples
{
    public class SideMenu : SimpleMenu<SideMenu>
    {
        public void OnPlayPressed()
        {
            GameMenu.Show();
        }

        public void OnOptionsPressed()
        {
            OptionsMenu.Show();
        }

        public override void OnBackPressed()
        {
            Application.Quit();
        }
    }
}