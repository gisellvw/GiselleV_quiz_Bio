namespace MauiAppQuiz;

public partial class Questao3 : ContentPage
{

    int respostaCorreta = 4;
    public Questao3()
	{
		InitializeComponent();
	}

    private async void OnAlternativaClicked(object sender, EventArgs e)
    {
        Button botaoClicado = (Button)sender;

        // 2. Destaca o botão clicado com a sua cor
        botaoClicado.BackgroundColor = Color.FromArgb("#525b2a");
        botaoClicado.TextColor = Color.FromArgb("#c6df58");

        // 3. Descobre qual foi o número do botão clicado
        int alternativaEscolhida = 0;

        if (botaoClicado == Button_alt1)
            alternativaEscolhida = 1;
        else if (botaoClicado == Button_alt2)
            alternativaEscolhida = 2;
        else if (botaoClicado == Button_alt3)
            alternativaEscolhida = 3;
        else if (botaoClicado == Button_alt4)
            alternativaEscolhida = 4;

        // 4. Compara com a resposta certa e soma ponto se acertou
        if (alternativaEscolhida == respostaCorreta)
        {
            App.Pontos++;
            botaoClicado.BackgroundColor = Color.FromArgb("#525b2a");
            botaoClicado.TextColor = Color.FromArgb("#c6df58");
            await DisplayAlert("Parabéns! 🎉", "Você acertou a resposta!", "Próxima");
        }
        else
        {
            botaoClicado.BackgroundColor = Color.FromArgb("#bf4260");
            botaoClicado.TextColor = Color.FromArgb("#ffffff");
            await DisplayAlert("Que pena...", "Você errou a resposta! Alternativa correta: D", "Próxima");
        }

        await Navigation.PushAsync(new Questao4());
        Navigation.RemovePage(this);
    }
}