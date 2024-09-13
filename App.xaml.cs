namespace Contabilidad_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Application.Current.Resources["AppTitle"] = "Daily Count";
        }
    }
}
