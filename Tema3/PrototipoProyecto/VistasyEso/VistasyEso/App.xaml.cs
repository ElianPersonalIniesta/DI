namespace VistasyEso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell()) { 
                Width = 700, Height = 700, X = 100, Y=100, 
                MaximumHeight=double.PositiveInfinity,MinimumHeight=600,
                MaximumWidth=double.PositiveInfinity,MinimumWidth=650
            };
        }
    }
}