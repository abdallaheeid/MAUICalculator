using MAUICalculator.MVVM.Views;


namespace MAUICalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //UserAppTheme = AppTheme.Light;

            MainPage = new CalculatorView();
        }
    }
}
