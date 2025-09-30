using System.Linq.Expressions;

namespace Trivial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

       
    }
}