using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void num_clicked(object sender, EventArgs e) // Invoked When any number button is clicked in the form
        {
            string Button_Text = (sender as Button).Text; // Taking the operaion's text
            if(Output.Text=="0") // Checking if it is 0 to clear Output Text Box
            {
                Output.Clear();
            }
            Output.Text += Button_Text; // Adding the number in the Output text box
        }

        private void BackSpace_Click(object sender, EventArgs e) // Invoked when backspace button is clicked
        {
            string temp = Output.Text; // taking the Output's text in a string
            if(temp.Length == 0)
            {
                Output.Text = "0"; // If the lenth is 0 then it set Output's text as 0
            }
            if(temp.Length > 0)
            {
                temp = temp.Remove(temp.Length - 1); // It deletes the last character
            }
            Output.Text = temp; // Updating the Output Text Box
        }

        private void Clear_Click(object sender, EventArgs e) // Invoked when clear ibutton is clicked
        {
            Output.Text = "0"; // Set the Output's text as 0
        }

        double a; // To store 1st Inputed number
        double b; // To store 2nd Inputed number

        string operation; // To store the operation Inputed by user
        private void Operation_Click(object sender, EventArgs e) // Invoked when a operation button is clicked
        {
            string op = (sender as Button).Text; // Geting the text of the operation in op
            operation = op; // setting the op value in operation variable
            a = System.Convert.ToDouble(Output.Text); // Converting the Output Text Box's first num into double and storing into a
            if(Output.Text=="0")
            {
                Output.Clear();
            }
            Output.Text +=op;
            
        }

        private void isEqual_Click(object sender, EventArgs e)
        {
            int length = Output.Text.Length;
            string temp = Output.Text.Remove(0, length - 1);
            b = System.Convert.ToDouble(temp);

            double r = 0; // To store the result
            switch (operation) // Checking the Operation and geting the result
            {
               case "+":
                    r = a + b;
                    break;
               case "-":
                    r = a - b;
                    break;
               case "X":
                    r = a * b;
                    break;
               case "÷":
                    r = a / b;
                    break;
               }
            Output.Text = System.Convert.ToString(r); // Giving the result into Output Text Box
        }
    }
}
