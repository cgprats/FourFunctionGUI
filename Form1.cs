using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four_Function_GUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Text ="Four Function GUI";
        }

        public String Calculate(double valueOne, double valueTwo, String operation) {
            String result = "";
            double numericalResult = 0;
            switch (operation) {
                case "Addition":
                    numericalResult = valueOne + valueTwo;
                    break;
                case "Subtraction":
                    numericalResult = valueOne - valueTwo;
                    break;
                case "Multiplication":
                    numericalResult = valueOne * valueTwo;
                    break;
                case "Division":
                    numericalResult = valueOne / valueTwo;
                    break;
            }
            result = Convert.ToString(Math.Round(numericalResult, 2));
            return result;
        }

        private void ValueOneBox_TextChanged(object sender, EventArgs e) {
        }

        private void ValueTwoBox_TextChanged(object sender, EventArgs e) {
        }

        private void AdditionRadio_CheckedChanged(object sender, EventArgs e) {

        }

        private void SubtractionRadio_CheckedChanged(object sender, EventArgs e) {

        }

        private void MultiplicationRadio_CheckedChanged(object sender, EventArgs e) {

        }

        private void DivisionRadio_CheckedChanged(object sender, EventArgs e) {

        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            double valueOne = 0, valueTwo = 0;
            String operation = "";
            if (ValueOneBox.Text != "" && ValueTwoBox.Text != "") {
                valueOne = Convert.ToDouble(ValueOneBox.Text);
                valueTwo = Convert.ToDouble(ValueTwoBox.Text);
            }            
            if (AdditionRadio.Checked) {
                operation = "Addition";
            }
            else if (SubtractionRadio.Checked) {
                operation = "Subtraction";
            }
            else if (MultiplicationRadio.Checked) {
                operation = "Multiplication";
            }
            else if (DivisionRadio.Checked) {
                operation = "Division";
            }
            CalculatedResultLabel.Text = Calculate(valueOne, valueTwo, operation);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void ValueTwoIndicator_Click(object sender, EventArgs e) {

        }
    }
}
