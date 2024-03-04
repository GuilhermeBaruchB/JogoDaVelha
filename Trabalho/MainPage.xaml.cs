namespace Trabalho
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if(vez == "0")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text="X";
                vez = "O";
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }
    }

}
