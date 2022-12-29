namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn0.Text;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            option = "-";

            //pass the value to num1 variable from the text box
            num1 = int.Parse(display.Text);

            //clear the text box after operation is done

            display.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            option = "*";

            //pass the value to num1 variable from the text box
            num1 = int.Parse(display.Text);

            //clear the text box after operation is done

            display.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            option = "+";

            //pass the value to num1 variable from the text box
            num1 = int.Parse(display.Text);

            //clear the text box after operation is done

            display.Clear();


        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";

            //pass the value to num1 variable from the text box
            num1 = int.Parse(display.Text);

            //clear the text box after operation is done

            display.Clear();
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            num2= int.Parse(display.Text);

            //checking the option varibale and doing the ralted operation
            if (option.Equals("+"))
                result = num1 + num2;
            if(option.Equals("-"))
                result = num1 - num2;
            if(option.Equals('*'))
                result = num1 * num2;
            if (option.Equals('/'))
                result = num1 / num2;


            display.Text = result+" ";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            //clear all the components after clicking the clear button
            display.Clear();
            num1 = 0;
            num2 = 0;
            result= 0;
        }
    }
}