namespace Dado
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int resultado = random.Next(1, 7);

            dadoImagem.Source = $"dado{resultado}.png";


            if (int.Parse(SelecaoPicker.SelectedItem.ToString()) == resultado)
            {
                DisplayAlert("Parabéns", "Você acertou o número!", "Ok");
            }
            else
            {
                DisplayAlert("Tente novamente", "Você errou! O número era " + resultado, "Ok");
            }
        }
    }
}
