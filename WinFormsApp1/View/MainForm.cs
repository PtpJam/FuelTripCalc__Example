namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (new FuelCalcLib.TripController(new FuelCalcLib.TripModel() { FuelCost = (int)fuelCostUpDown.Value, Avarage = (int)avarageUpDown.Value, Distance = (int)distanceUpDown.Value })).Calculate().ToString();
        }
    }
}