namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void DiceRoller_Clicked(object sender, EventArgs e)
        {
            int selecionarLados = Convert.ToInt32(picker.SelectedItem);
            int sorteio = new Random().Next(1, selecionarLados +1);
            Dado.Text = sorteio.ToString(); 
        }
    }

}
