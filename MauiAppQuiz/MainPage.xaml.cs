namespace MauiAppQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnComecarClicked(object sender, EventArgs e)
        {
            App.Pontos = 0; 
            await Navigation.PushAsync(new Questao1());
        }
    }
}

