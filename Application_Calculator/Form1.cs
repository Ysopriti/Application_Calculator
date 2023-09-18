namespace Application_Calculator
{
    public partial class Form1 : Form
    {
        //declaring the variable calculatorclass named cal
        CalculatorClass cal;
        public Form1()
        {
            InitializeComponent();
            //instantiating 
            cal = new CalculatorClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //set two variable num1 and num2 where datatype are double
        double num1;
        double num2;

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //Get the value of txtBoxInput1 for num1 and txtBoxInput2 for num2
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            //Write a condition that validates the selected arithmetic operator in the ComboBox
            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQoutient);
                lblDisplayTotal.Text = cal.GetQoutient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQoutient);
            }
        }
    }
    }
