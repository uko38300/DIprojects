
namespace PagesDemo;


public partial class App : Application
{

    public App()
    {
        InitializeComponent();

        MainPage = new TabbedPageDemo();
       // MainPage = new FlyoutPageDemo();
        //MainPage = new MainPage();

    }


}


