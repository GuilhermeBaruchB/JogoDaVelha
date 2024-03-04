namespace Trabalho
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "0")
            {
                disparador.Text = "0";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "0";
            }



            if (btn10.Text == "X" &&
               btn11.Text == "X" &&
               btn12.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "0" &&
            btn11.Text == "0" &&
            btn12.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn20.Text == "X" &&
            btn21.Text == "X" &&
            btn22.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn20.Text == "0" &&
            btn21.Text == "0" &&
             btn22.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn30.Text == "X" &&
            btn31.Text == "X" &&
            btn32.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn30.Text == "0" &&
           btn31.Text == "0" &&
           btn32.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "0" &&
           btn20.Text == "0" &&
           btn30.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "X" &&
           btn20.Text == "X" &&
           btn30.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn11.Text == "X" &&
           btn21.Text == "X" &&
           btn31.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn11.Text == "0" &&
          btn21.Text == "0" &&
          btn31.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn12.Text == "X" &&
          btn22.Text == "X" &&
          btn32.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn12.Text == "0" &&
         btn22.Text == "0" &&
         btn32.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "0" &&
         btn21.Text == "0" &&
         btn32.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "X" &&
        btn21.Text == "X" &&
        btn32.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn12.Text == "X" &&
        btn21.Text == "X" &&
        btn30.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "0" &&
        btn21.Text == "0" &&
        btn32.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn10.Text == "0" &&
       btn21.Text == "0" &&
       btn32.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn12.Text == "0" &&
       btn21.Text == "0" &&
       btn30.Text == "0")

            {
                DisplayAlert("Parabéns!", "O 0 ganhou", "Fechar");
                Limpar();
            }
            else if (btn12.Text == "X" &&
      btn21.Text == "X" &&
      btn30.Text == "X")

            {
                DisplayAlert("Parabéns!", "O X ganhou", "Fechar");
                Limpar();
            }

            else if
                (btn10.IsEnabled == false &&
                btn11.IsEnabled == false &&
                btn12.IsEnabled == false &&
                btn20.IsEnabled == false &&
                btn21.IsEnabled == false &&
                btn22.IsEnabled == false &&
                btn30.IsEnabled == false &&
                btn31.IsEnabled == false &&
                btn32.IsEnabled == false)
            {
                DisplayAlert("Que pena", "Deu velha!", "Fechar");
                Limpar();
            }


        }

        private void Limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;

            btn11.Text = "";
            btn11.IsEnabled = true;

            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;

            btn21.Text = "";
            btn21.IsEnabled = true;

            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;

            btn31.Text = "";
            btn31.IsEnabled = true;

            btn32.Text = "";
            btn32.IsEnabled = true;


        }
    }
}



