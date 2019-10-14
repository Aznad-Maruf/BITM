using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        private Vehicle _aVehicle;

        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _aVehicle = new Vehicle(vehicleNameTextBox.Text,regNoTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _aVehicle.setNewSpeed( Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = _aVehicle.MaxSpeed.ToString();
            minSpeedTextBox.Text = _aVehicle.MinSpeed.ToString();
            averageSpeedTextBox.Text = _aVehicle.AvgSpeed.ToString();
        }
    }
}
