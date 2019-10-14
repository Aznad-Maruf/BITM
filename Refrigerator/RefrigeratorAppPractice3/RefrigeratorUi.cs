using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        private Refrigerator _refrigerator;

        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _refrigerator = new Refrigerator(Convert.ToDouble(maxWeightTakeTextBox.Text));
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (_refrigerator.EnterNewItem(Convert.ToInt32(itemTextBox.Text), Convert.ToDouble(weightTextBox.Text)))
            {
                currentWeightTextBox.Text = _refrigerator.CurrentWeight.ToString();
                remainingWeightTextBox.Text = (_refrigerator.MaximumWeight - _refrigerator.CurrentWeight).ToString();
            }
            else
            {
                //MessageBox.Show("Refrigerator is full man!");
            }
        }
    }
}
