// namespace winform;

// public partial class Form1 : Form
// {
//     public Form1()
//     {
//         InitializeComponent();
//     }
// }
using System;
using System.Windows.Forms;

namespace winform 
{
    public partial class Form1 : Form
    {
        TextBox txtA, txtB;
        Button btnAdd, btnSub, btnMul, btnDiv, btnMod;
        Label lblResult;

        public Form1()
        {
            InitializeComponent();
            CreateUI();
        }

        void CreateUI()
        {
            // Form
            this.Text = "Addition App";
            this.Width = 350;
            this.Height = 250;
            this.BackColor = Color.LightGray;

            // TextBox 1
            txtA = new TextBox();
            txtA.Left = 50;
            txtA.Top = 30;
            txtA.Width = 100;

            // TextBox 2
            txtB = new TextBox();
            txtB.Left = 50;
            txtB.Top = 70;
            txtB.Width = 100;

            // Add Button
            btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Left = 50;
            btnAdd.Top = 110;
            btnAdd.Click += BtnAdd_Click;
            btnAdd.BackColor = Color.White;

            // Sub Button
            btnSub = new Button();
            btnSub.Text = "Sub";
            btnSub.Left = 150;
            btnSub.Top = 110;
            btnSub.Click += BtnSub_Click;
            btnSub.BackColor = Color.White;

            // Mul Button
            btnMul = new Button();
            btnMul.Text = "Mul";
            btnMul.Left = 250;
            btnMul.Top = 110;
            btnMul.Click += BtnMul_Click;
            btnMul.BackColor = Color.White;

            // Div Button
            btnDiv = new Button();
            btnDiv.Text = "Div";
            btnDiv.Left = 350;
            btnDiv.Top = 110;
            btnDiv.Click += BtnDiv_Click;
            btnDiv.BackColor = Color.White;

            // Mod Button
            btnMod = new Button();
            btnMod.Text = "Mod";
            btnMod.Left = 450;
            btnMod.Top = 110;
            btnMod.Click += BtnMod_Click;
            btnMod.BackColor = Color.White;

            // Label
            lblResult = new Label();
            lblResult.Left = 50;
            lblResult.Top = 150;
            lblResult.Width = 200;
            lblResult.Text = "Result";
            lblResult.BackColor = Color.White;

            // Add controls to form
            this.Controls.Add(txtA);
            this.Controls.Add(txtB);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSub);
            this.Controls.Add(btnMul);
            this.Controls.Add(btnDiv);
            this.Controls.Add(btnMod);
            this.Controls.Add(lblResult);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a + b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a - b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a * b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a / b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a % b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }
    }
}