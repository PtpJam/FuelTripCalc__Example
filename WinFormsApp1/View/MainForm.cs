using FuelCalcLib.Models;

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
            resultLabel.Text = (
                new FuelCalcLib.Controller.TripDBController(
                    new FuelCalcLib.Models.TripModel()
                    {
                        FuelCost = (int)fuelCostUpDown.Value,
                        Avarage = (int)avarageUpDown.Value,
                        Distance = (int)distanceUpDown.Value
                    },
                    new FuelCalcLib.Models.CarModel()
                    {
                        carMark = carMarkTextBox.Text,
                        carModel = modelTextBox.Text,
                        carEngine = (int)engineUpDown.Value
                    }
                )).Calculate().ToString();
        }



        private void avarageUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            int t = new FuelCalcLib.Controller.TripDBController(new FuelCalcLib.Models.CarModel()
            {
                carMark = carMarkTextBox.Text,
                carModel = modelTextBox.Text,
                carEngine = (int)engineUpDown.Value
            }).GetAvarage();

            avarageUpDown.Value = t;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            carMarkTextBox.Text = modelTextBox.Text = string.Empty;
            engineUpDown.Value = avarageUpDown.Value = distanceUpDown.Value = fuelCostUpDown.Value = 0;
        }
    }
}