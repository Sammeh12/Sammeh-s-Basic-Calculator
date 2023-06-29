using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            tbResults.Text = " Total:" + Environment.NewLine + " 000000";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2;
            if (!float.TryParse(tbInput1.Text, out num1))
            {
                MessageBox.Show("First number invalid!");
                return;
            }
            if (!float.TryParse(tbInput2.Text, out num2))
            {
                MessageBox.Show("Second number invalid!");
                return;
            }

            string oper = cbOperator.Text;
            switch (oper)
            {
                case "+":
                    CalculatorPrivateAssembly.BasicComputation add = new CalculatorPrivateAssembly.BasicComputation();
                    tbResults.Text = " Total:" + Environment.NewLine + " " + Convert.ToString(add.Addition(Convert.ToInt16
                        (tbInput1.Text), Convert.ToInt16(tbInput2.Text)));
                    break;
                case "-":
                    CalculatorPrivateAssembly.BasicComputation subtract = new CalculatorPrivateAssembly.BasicComputation();
                    tbResults.Text = " Total:" + Environment.NewLine + " " + Convert.ToString(subtract.Substraction(Convert.ToInt16
                        (tbInput1.Text), Convert.ToInt16(tbInput2.Text)));
                    break;
                case "*":
                    CalculatorPrivateAssembly.BasicComputation multiply = new CalculatorPrivateAssembly.BasicComputation();
                    tbResults.Text = " Total:" + Environment.NewLine + " " + Convert.ToString(multiply.Multiplication(Convert.ToInt16
                        (tbInput1.Text), Convert.ToInt16(tbInput2.Text)));
                    break;
                case "/":
                    CalculatorPrivateAssembly.BasicComputation devide = new CalculatorPrivateAssembly.BasicComputation();
                    tbResults.Text = " Total:" + Environment.NewLine + " " + Convert.ToString(devide.Division(Convert.ToInt16
                        (tbInput1.Text), Convert.ToInt16(tbInput2.Text)));
                    break;
                default:
                    break;
            }
        }
    }
}
