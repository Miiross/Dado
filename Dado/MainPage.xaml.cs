﻿using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace Dado
{
    public partial class MainPage : ContentPage
    {
        Dado dado;
        int vitorias = 0;
        int sequencia = 0;
        int somaOpostos = 0;
        int? ultimoCorte = null;

        Dictionary<string, int> limites = new()
        {
            {"D6", 30}, {"D8", 40}, {"D10", 50}, {"D12", 60}, {"D16", 70}, {"D20", 100}
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private void TipoDadoPicker(object sender, EventArgs e)
        {
            string tipo = DadoPicker.SelectedItem.ToString();
            int lados = int.Parse(tipo.Substring(1));
            dado = new Dado(lados);

            NumeroEscolhidoPicker.Items.Clear();
            for (int i = 1; i <= lados; i++)
            {
                NumeroEscolhidoPicker.Items.Add(i.ToString());
            }
            NumeroEscolhidoPicker.SelectedIndex = 0;
        }

<<<<<<< HEAD
        private async void RolarButton_Clicked(object sender, EventArgs e)
        {
            if (dado == null || NumeroEscolhidoPicker.SelectedIndex == -1) return;

            int corte = int.Parse(NumeroEscolhidoPicker.SelectedItem.ToString());
            if (ultimoCorte.HasValue && corte == ultimoCorte.Value)
            {
                await DisplayAlert("Erro", "O número de corte não pode se repetir!", "Ok");
                return;
            }
            ultimoCorte = corte;

            int jogador = dado.Jogar();
            int computador = dado.Jogar();
=======
        private async void RollButtonY_Clicked(object sender, EventArgs e)
        { 
            await AnimarDado();
>>>>>>> 95eb3f0e0b1f199935148eac6ee32c8dec272b8c

            string status;
            bool venceu = false;

<<<<<<< HEAD
            if (jogador < corte)
            {
                await DisplayAlert($"Você perdeu!","O numero tirado é menor que o de corte", "Ok");
                status = $"Você tirou {jogador}, que é menor que o corte {corte}. Perdeu!";
                sequencia = 0;
            }
            else if (computador >= jogador)
            {
                await DisplayAlert($"Você perdeu!", "Computador tirou um numero igual ou maior", "Ok");
                status = $"Você tirou {jogador}, o computador tirou {computador}. Perdeu!";
                sequencia = 0;
            }
            else
            {
                await DisplayAlert($"Você ganhou!", "O numero tirado é igual ou maior que o de corte", "Ok");
                status = $"Você tirou {jogador}, o computador tirou {computador}. Você ganhou!";
                vitorias++;
                sequencia++;
                venceu = true;
            }
            //Meio que virou um jogo de quem tira o numero mais alto não?

            int soma = dado.GetLadoOposto(jogador) + dado.GetLadoOposto(computador);
            somaOpostos += soma;

            int limite = limites[$"D{dado.Lados}"];
            if (somaOpostos >= limite)
            {
                RolarButton.IsEnabled = false;
                status += $"\nTentativas máximas utilizadas. (Limite: {limite})";
            }

            ResultadoLabel.Text = $"Seu número: {jogador} - Computador: {computador}";
            StatusLabel.Text = status;
            VitoriasLabel.Text = $"Vitórias: {vitorias}";
            SequenciaLabel.Text = $"Sequência: {sequencia}";
            SomaOpostosLabel.Text = $"Soma dos lados opostos: {somaOpostos}/{limite}";
=======
            if (resultado <= 3)
            {
                await DisplayAlert("Boa", "voce acertou!", "ok");
            }
            else
            {
                await DisplayAlert("Ixi", "voce errou!", "ok");
            }
        }

        private async void RollButtonX_Clicked(object sender, EventArgs e)
        {
            await AnimarDado();

            int resultado = meuDado.Jogar();
            dadoImagem.Source = meuDado.GetImagem(resultado);

            if (resultado >= 4)
            {
                await DisplayAlert("Boa", "voce acertou!", "ok");
            }
            else
            {
                await DisplayAlert("Ixi", "voce errou!", "ok");
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
>>>>>>> 95eb3f0e0b1f199935148eac6ee32c8dec272b8c
        }
    }
}
