namespace DadoPAM
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Random aleatorio = new Random();

        public MainPage()
        {
            InitializeComponent();
        }



        private void SortearButton_Clicked(object sender, EventArgs e)
        {
       

 

            if (picker.SelectedItem == null)
            {
                ResultadoLabel.Text = ("SELECIONE UM ITEM");
                return;
            }

            string resultado = picker.SelectedItem.ToString();

            if (resultado == "4")
            {
                
                int sorteio = aleatorio.Next(1, 5); // Gera de 1 a 4
                ResultadoLabel.Text = $"{sorteio}";
                return;

            }

            else if (resultado == "6")
            {
      
                int sorteio = aleatorio.Next(1, 7); // Gera 1 a 6
                ResultadoLabel.Text = $"{sorteio}";
                return;

            }

            else if (resultado == "10")
            {
               
                int sorteio = aleatorio.Next(1, 11); // Gera 1 a 10
                ResultadoLabel.Text = $"{sorteio}";
                return;

            }

            else if (resultado == "20")
            {
               
                int sorteio = aleatorio.Next(1, 21); // Gera 1 a 20
                ResultadoLabel.Text = $"{sorteio}";
                return;

            }

            else if (resultado == "100")
            {
               
                int sorteio = aleatorio.Next(1, 101); // Gera 1 a 100
                ResultadoLabel.Text = $"{sorteio}";
                return;

            }






        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resultado = picker.SelectedItem.ToString();
            
        
            



            if (resultado == "4")
            {
                ImagemDado.Source = "quatro.PNG";


            }

            else if (resultado == "6")
            {
                ImagemDado.Source = "seis.PNG";


            }

            

            else if (resultado == "10")
            {
                ImagemDado.Source = "dez.PNG";


            }
            else if (resultado == "20")
            {
                ImagemDado.Source = "vinte.PNG";


            }
            else if (resultado == "100")
            {
                ImagemDado.Source = "cem.PNG";


            }






        }
    }
}
