// namespace winform;

// public partial class Form1 : Form
// {
//     public Form1()
//     {
//         InitializeComponent();
//     }
// }
using System.Data;
using System;
using System.Windows.Forms;

namespace winform 
{
    public partial class Form1 : Form
    {
        TextBox txtA;
        Button btnAdd, btnSub, btnMul, btnDiv, btnMod, btnEquals, btnSignToggle, btnDecimalPoint, btnBackspace, btnCE, btnC, btnInverse, btnSquare, btnSqrt, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0;
        Label lblResult;
        double firstNumber = 0;
        string currentOperator = "";
        bool isNewNumber = false;
        string expression = "";


        public Form1()
        {
            InitializeComponent();
            CreateUI();
        }

        void CreateUI()
        {
            // Form
            this.Text = "Calculator";
            this.Width = 360;
            this.Height = 700;
            this.BackColor = Color.FromArgb(32, 32, 32);

            // Display
            txtA = new TextBox();
            txtA.Width  = 310;
            txtA.Height = 100;
            txtA.Left = 20;
            txtA.Top = 70;
            txtA.Font = new Font("Segoe UI", 36);
            txtA.TextAlign = HorizontalAlignment.Right;

            
            // Display Color
            txtA.BackColor = Color.FromArgb(24, 24, 24);
            txtA.ForeColor = Color.White;
            txtA.BorderStyle = BorderStyle.None;

            // Add Button
            btnAdd = new Button();
            btnAdd.Text = "+";
            btnAdd.Left = 260;
            btnAdd.Top = 460;
            btnAdd.Width = 70;
            btnAdd.Height = 60;
            btnAdd.Click += BtnAdd_Click;

            // Sub Button
            btnSub = new Button();
            btnSub.Text = "-";
            btnSub.Left = 260;
            btnSub.Top = 390;
            btnSub.Width = 70;
            btnSub.Height = 60;
            btnSub.Click += BtnSub_Click;

            // Mul Button
            btnMul = new Button();
            btnMul.Text = "*";
            btnMul.Left = 260;
            btnMul.Top = 320;
            btnMul.Width = 70;
            btnMul.Height = 60;
            btnMul.Click += BtnMul_Click;

            // Div Button
            btnDiv = new Button();
            btnDiv.Text = "÷";
            btnDiv.Left = 260;
            btnDiv.Top = 250;
            btnDiv.Width = 70;
            btnDiv.Height = 60;
            btnDiv.Click += BtnDiv_Click; 

            // Mod Button
            btnMod = new Button();
            btnMod.Text = "%";
            btnMod.Left = 20;
            btnMod.Top = 180;
            btnMod.Width = 70;
            btnMod.Height = 60;
            btnMod.Click += BtnMod_Click;

            // Equals Button
            btnEquals = new Button();
            btnEquals.Text = "=";
            btnEquals.Left = 260;
            btnEquals.Top = 530;
            btnEquals.Width = 70;
            btnEquals.Height = 60;
            btnEquals.Click += BtnEquals_Click;

            // Sighn Toggle Button
            btnSignToggle = new Button();
            btnSignToggle.Text = "+/-";
            btnSignToggle.Left = 20;
            btnSignToggle.Top = 530;
            btnSignToggle.Width = 70;
            btnSignToggle.Height = 60;
            btnSignToggle.Click += BtnSignToggle_Click;
            
            // Decimal Point Button
            btnDecimalPoint = new Button();
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.Left = 180;
            btnDecimalPoint.Top = 530;
            btnDecimalPoint.Width = 70;
            btnDecimalPoint.Height = 60;
            btnDecimalPoint.Click += BtnDecimalPoint_Click;

            // Backspace Button
            btnBackspace = new Button();
            btnBackspace.Text = "⌫";
            btnBackspace.Left = 260;
            btnBackspace.Top = 180;
            btnBackspace.Width = 70;
            btnBackspace.Height = 60;
            btnBackspace.Click += BtnBackspace_Click;

            // Clear Entry Button
            btnCE = new Button();
            btnCE.Text = "CE";
            btnCE.Left = 100;
            btnCE.Top = 180;
            btnCE.Width = 70;
            btnCE.Height = 60;
            btnCE.Click += BtnCE_Click;

            // Clear All Button
            btnC = new Button();
            btnC.Text = "C";
            btnC.Left = 180;
            btnC.Top = 180;
            btnC.Width = 70;
            btnC.Height = 60;
            btnC.Click += BtnC_Click;

            // Inverse Button
            btnInverse = new Button();
            btnInverse.Text = "1/x";
            btnInverse.Left = 20;
            btnInverse.Top = 250;
            btnInverse.Width = 70;
            btnInverse.Height = 60;
            btnInverse.Click += BtnInverse_Click;

            // btnSquare Button
            btnSquare = new Button();
            btnSquare.Text = "x²";
            btnSquare.Left = 100;
            btnSquare.Top = 250;
            btnSquare.Width = 70;
            btnSquare.Height = 60;
            btnSquare.Click += BtnSquare_Click;

            // BtnSqrt Button
            btnSqrt = new Button();
            btnSqrt.Text = "√";
            btnSqrt.Left = 180;
            btnSqrt.Top = 250;
            btnSqrt.Width = 70;
            btnSqrt.Height = 60;
            btnSqrt.Click += BtnSqrt_Click;

            // Numbers Button
            btn1 = new Button();
            btn1.Text = "1";
            btn1.Left = 20;
            btn1.Top = 460;
            btn1.Width = 70;
            btn1.Height = 60;
            btn1.Click += Btn1_Click;


            btn2 = new Button();
            btn2.Text = "2";
            btn2.Left = 100;
            btn2.Top = 460;
            btn2.Width = 70;
            btn2.Height = 60;
            btn2.Click += Btn2_Click;

            btn3 = new Button();
            btn3.Text = "3";
            btn3.Left = 180;
            btn3.Top = 460;
            btn3.Width = 70;
            btn3.Height = 60;
            btn3.Click += Btn3_Click;

            btn4 = new Button();
            btn4.Text = "4";
            btn4.Left = 20;
            btn4.Top = 390;
            btn4.Width = 70;
            btn4.Height = 60;
            btn4.Click += Btn4_Click;

            btn5 = new Button();
            btn5.Text = "5";
            btn5.Left = 100;
            btn5.Top = 390;
            btn5.Width = 70;
            btn5.Height = 60;
            btn5.Click += Btn5_Click;

            btn6 = new Button();
            btn6.Text = "6";
            btn6.Left = 180;
            btn6.Top = 390;
            btn6.Width = 70;
            btn6.Height = 60;
            btn6.Click += Btn6_Click;

            btn7 = new Button();
            btn7.Text = "7";
            btn7.Left = 20;
            btn7.Top = 320;
            btn7.Width = 70;
            btn7.Height = 60;
            btn7.Click += Btn7_Click;

            btn8 = new Button();
            btn8.Text = "8";
            btn8.Left = 100;
            btn8.Top = 320;
            btn8.Width = 70;
            btn8.Height = 60;
            btn8.Click += Btn8_Click;

            btn9 = new Button();
            btn9.Text = "9";
            btn9.Left = 180;
            btn9.Top = 320;
            btn9.Width = 70;
            btn9.Height = 60;
            btn9.Click += Btn9_Click;
           

            btn0 = new Button();
            btn0.Text = "0";
            btn0.Left = 100;
            btn0.Top = 530;
            btn0.Width = 70;
            btn0.Height = 60;
            btn0.Click += Btn0_Click;


            // Label
            lblResult = new Label();
            lblResult.Left = 50;
            lblResult.Top = 150;
            lblResult.Width = 200;
            lblResult.Text = "Result";
            lblResult.BackColor = Color.White;
            

            // Add controls to form
            this.Controls.Add(txtA);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSub);
            this.Controls.Add(btnMul);
            this.Controls.Add(btnDiv);
            this.Controls.Add(btnMod);
            this.Controls.Add(btnEquals);
            this.Controls.Add(btnSignToggle);
            this.Controls.Add(btnDecimalPoint);
            this.Controls.Add(btnBackspace);
            this.Controls.Add(btnInverse);
            this.Controls.Add(btnSquare);
            this.Controls.Add(btnSqrt);
            this.Controls.Add(btnCE);
            this.Controls.Add(btnC);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
            this.Controls.Add(btn9);
            this.Controls.Add(btn0);


            // Buttons Color
            Button[] allButtons = {
               btnAdd, btnSub, btnMul, btnDiv, btnMod, btnEquals,
               btnSignToggle, btnDecimalPoint, btnBackspace,
               btnCE, btnC, btnInverse, btnSquare, btnSqrt,
               btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0
            };

            foreach (Button btn in allButtons) {
               btn.FlatStyle = FlatStyle.Flat;
               btn.FlatAppearance.BorderSize = 0;
               btn.BackColor = Color.FromArgb(58, 58, 58);
               btn.ForeColor = Color.White;
            }
 
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            expression += "+";
            txtA.Text = expression; 
        }

        private void BtnSub_Click(object sender, EventArgs e) {
            expression += "-";
            txtA.Text = expression;
        }    
        private void BtnMul_Click(object sender, EventArgs e) {
            expression += "*";
            txtA.Text = expression;
        }    
            
        private void BtnDiv_Click(object sender, EventArgs e) {
            expression += "/";
            txtA.Text = expression;
        }    
        private void BtnMod_Click(object sender, EventArgs e) {
            expression += "%";
            txtA.Text = expression;
        }
        private void BtnEquals_Click(object sender, EventArgs e) {
          
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");
                txtA.Text = result.ToString();
                expression = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
                btnEquals.BackColor = Color.FromArgb(76, 194, 255);
                btnEquals.ForeColor = Color.Black;
        }
        private void BtnSignToggle_Click(object sender, EventArgs e) {
            
            if (double.TryParse(txtA.Text, out double value))
            {
                value = -value;
                txtA.Text = value.ToString();
                expression = txtA.Text;
            }
        }
        private void BtnDecimalPoint_Click(object sender, EventArgs e) {
       
            if (!expression.Contains("."))
            {
                expression += ".";
                txtA.Text = expression;
            }
        }
        private void BtnCE_Click(object sender, EventArgs e) {
            txtA.Text = "0";
        }       
        private void BtnBackspace_Click(object sender, EventArgs e) {
        
            if (expression.Length > 0)
            {
                expression = expression.Substring(0, expression.Length - 1);
                txtA.Text = expression;
            }
        }
        private void BtnInverse_Click(object sender, EventArgs e) {
            double value = Convert.ToDouble(txtA.Text);
            txtA.Text = (1 / value).ToString();
            expression = txtA.Text;
        }
        private void BtnC_Click(object sender, EventArgs e) {
            expression = "";
            txtA.Text = "0";
        }
        private void BtnSquare_Click(object sender, EventArgs e) {
            double value = Convert.ToDouble(txtA.Text);
            txtA.Text = (value * value).ToString();
            expression = txtA.Text;
        }
        private void BtnSqrt_Click(object sender, EventArgs e) {
            double value = Convert.ToDouble(txtA.Text);
            txtA.Text = Math.Sqrt(value).ToString();
            expression = txtA.Text;
        }
        private void Btn1_Click(object sender, EventArgs e) {
            expression += "1";
            txtA.Text = expression; 
        }
        private void Btn2_Click(object sender, EventArgs e) {
            expression += "2";
            txtA.Text = expression; 
        }
        private void Btn3_Click(object sender, EventArgs e) {
            expression += "3";
            txtA.Text = expression; 
        }
        private void Btn4_Click(object sender, EventArgs e) {
            expression += "4";
            txtA.Text = expression; 
        }
        private void Btn5_Click(object sender, EventArgs e) {
            expression += "5";
            txtA.Text = expression; 
        }
        private void Btn6_Click(object sender, EventArgs e) {
            expression += "6";
            txtA.Text = expression; 
        }
        private void Btn7_Click(object sender, EventArgs e) {
            expression += "7";
            txtA.Text = expression; 
        }
        private void Btn8_Click(object sender, EventArgs e) {
            expression += "8";
            txtA.Text = expression; 
        }
        private void Btn9_Click(object sender, EventArgs e) {
            expression += "9";
            txtA.Text = expression; 
        }
        private void Btn0_Click(object sender, EventArgs e) {
            expression += "0";
            txtA.Text = expression; 
        }
    }
}