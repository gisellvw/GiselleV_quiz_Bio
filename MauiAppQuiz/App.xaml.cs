using Microsoft.Extensions.DependencyInjection;

namespace MauiAppQuiz
{
    public partial class App : Application
    {
        public static int Pontos { get; set; } = 0;
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}