namespace _4M02kalkulator
{
    public partial class MainPage : ContentPage
    {
        int suma = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDodajClicked(object sender, EventArgs e)
        {
            int liczba = 0;
            if (int.TryParse(entLiczba.Text, out liczba))
                suma += liczba;
            lblWynik.Text = $"suma: {suma.ToString()}";
            entLiczba.Text = "";
        }
        private void btnRozmiarClick(object sender, EventArgs e)
        {
            int rozmiar = 0;
            if(int.TryParse(enRozmiar.Text, out rozmiar))
            {
                lblNapis.FontSize = rozmiar;
            }
            enRozmiar.Text = "";
        }
    }

}
