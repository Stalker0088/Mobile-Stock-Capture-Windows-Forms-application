using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MobileStockCapture
{
    public class Form1 : Form
    {
        Label lblCode = new Label();
        Label lblMake = new Label();
        Label lblQuantity = new Label();
        Label lblOutput = new Label();

        TextBox txtCode = new TextBox();
        TextBox txtMake = new TextBox();
        TextBox txtQuantity = new TextBox();

        Button btnAdd = new Button();
        Button btnDelete = new Button();
        Button btnFind = new Button();

        List<string> codes = new List<string>();
        List<string> makes = new List<string>();
        List<int> quantities = new List<int>();

        public Form1()
        {
            this.Text = "Mobile Stock Capture";
            this.Size = new Size(500, 350);

            lblCode.Text = "Mobile Code";
            lblCode.Location = new Point(30, 30);

            txtCode.Location = new Point(150, 30);
            txtCode.Width = 200;

            lblMake.Text = "Make";
            lblMake.Location = new Point(30, 80);

            txtMake.Location = new Point(150, 80);
            txtMake.Width = 200;

            lblQuantity.Text = "Quantity";
            lblQuantity.Location = new Point(30, 130);

            txtQuantity.Location = new Point(150, 130);
            txtQuantity.Width = 200;

            btnAdd.Text = "Add";
            btnAdd.Location = new Point(30, 190);
            btnAdd.Click += btnAdd_Click;

            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(150, 190);
            btnDelete.Click += btnDelete_Click;

            btnFind.Text = "Find";
            btnFind.Location = new Point(270, 190);
            btnFind.Click += btnFind_Click;

            lblOutput.Location = new Point(30, 250);
            lblOutput.Size = new Size(300, 30);

            Controls.Add(lblCode);
            Controls.Add(txtCode);

            Controls.Add(lblMake);
            Controls.Add(txtMake);

            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);

            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);

            Controls.Add(lblOutput);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            codes.Add(txtCode.Text);
            makes.Add(txtMake.Text);
            quantities.Add(Convert.ToInt32(txtQuantity.Text));

            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = codes.IndexOf(txtCode.Text);

            if (index >= 0)
            {
                codes.RemoveAt(index);
                makes.RemoveAt(index);
                quantities.RemoveAt(index);

                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int index = codes.IndexOf(txtCode.Text);

            if (index >= 0)
            {
                txtMake.Text = makes[index];
                txtQuantity.Text = quantities[index].ToString();

                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}