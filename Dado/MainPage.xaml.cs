namespace Dado
{
    public partial class MainPage : ContentPage
    {
        private Dado meuDado = new Dado();

        public MainPage()
        {
            InitializeComponent();
        }
        private async void RollButton_Clicked(object sender, EventArgs e)
        {
            if (SelecaoPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Aviso", "Escolha um número antes de rolar!", "Ok");
                return;
            }

            await AnimarDado();

            int resultado = meuDado.Jogar();
            dadoImagem.Source = meuDado.GetImagem(resultado);

            int escolha = int.Parse(SelecaoPicker.SelectedItem.ToString());

            if (escolha == resultado)
            {
                await DisplayAlert("Parabéns", "Você acertou!", "Ok");

            }
            else
            {
                await DisplayAlert("Tente novamente", $"Você escolheu {escolha}, mas saiu {resultado}.", "Ok");
            }
        }

        private async void RollButtonY_Clicked(object sender, EventArgs e)
        {
            if (SelecaoPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Aviso", "Escolha uma opção antes de jogar", "Ok");
                return;
            }

            await AnimarDado();

            int resultado = meuDado.Jogar();
            dadoImagem.Source = meuDado.GetImagem(resultado);

            string ResultadoY;
            if (resultado <= 3)
            {
                ResultadoY = "1>3";
            }
            else
            {
                ResultadoY = "4>6";
            }

            int escolha = int.Parse(SelecaoPicker.SelectedItem.ToString());

            if (escolha == resultado)
            {
                await DisplayAlert("Parabéns", "Você acertou!", "Ok");

            }
            else
            {
                await DisplayAlert("Tente novamente", $"Você escolheu {escolha}, mas saiu {ResultadoY}.", "Ok");
            }
        }

        private async void RollButtonX_Clicked(object sender, EventArgs e)
        {
            if (SelecaoPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Aviso", "Escolha um número antes de rolar!", "Ok");
                return;
            }

            await AnimarDado();

            int resultado = meuDado.Jogar();
            dadoImagem.Source = meuDado.GetImagem(resultado);

            int escolha = int.Parse(SelecaoPicker.SelectedItem.ToString());

            if (escolha >= 4)
            {
                await DisplayAlert("Parabéns", "Você acertou!", "Ok");

            }
            else
            {
                await DisplayAlert("Tente novamente", $"Você escolheu {escolha}, mas saiu {resultado}.", "Ok");
            }
        }

        private async Task AnimarDado()
        {
            for (int i = 0; i < 10; i++)
            {
                int numeroAleatorio = new Random().Next(1, 7);
                dadoImagem.Source = $"dado{numeroAleatorio}.png";
                await Task.Delay(80);
            }
        }
    }
}
