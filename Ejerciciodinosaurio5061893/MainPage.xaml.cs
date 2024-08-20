namespace Ejerciciodinosaurio5061893
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void ConvertirBtn_Clicked(object sender, EventArgs e)
        {
            string name = nombredinosaurio.Text;
            double weightInPounds = Convert.ToDouble(pesolibras.Text);
            double lengthInFeet = Convert.ToDouble(longitudpies.Text);

            // Conversiones
            double weightInKg = weightInPounds * 0.453592;
            double lengthInMeters = lengthInFeet * 0.3048;

            // Mostrar resultados
            labelresultado.Text = $"{name}: Peso = {weightInKg:F2} kg, Longitud = {lengthInMeters:F2} m";


        }

        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }

}
