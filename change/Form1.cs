using System;
using System.Windows.Forms;

namespace change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetAll();
        }

        private void ResetAll()
        {
            pictureBox1.Visible = false; label2.Visible = false;
            pictureBox2.Visible = false; label3.Visible = false;
            pictureBox3.Visible = false; label5.Visible = false;
            pictureBox4.Visible = false; label6.Visible = false;
            pictureBox5.Visible = false; label7.Visible = false;
            pictureBox6.Visible = false; label4.Visible = false;
            pictureBox7.Visible = false; label9.Visible = false;
            pictureBox8.Visible = false; label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "It cannot be empty!");
                return;
            }

            if (!int.TryParse(maskedTextBox1.Text, out int amount))
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Enter a valid number greater than 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResetAll();

            int a = amount / 500;
            int b = amount % 500;

            int c = b / 200;
            int d = b % 200;

            int f = d / 100;
            int g = d % 100;

            int h = g / 50;
            int i = g % 50;

            int j = i / 20;
            int k = i % 20;

            int l = k / 10;
            int m = k % 10;

            int n = m / 5;
            int o = m % 5;

            int p = o / 1;

            if (a > 0) { pictureBox1.Visible = true; label2.Text = a.ToString(); label2.Visible = true; }
            if (c > 0) { pictureBox2.Visible = true; label3.Text = c.ToString(); label3.Visible = true; }
            if (f > 0) { pictureBox6.Visible = true; label4.Text = f.ToString(); label4.Visible = true; }
            if (h > 0) { pictureBox5.Visible = true; label7.Text = h.ToString(); label7.Visible = true; }
            if (j > 0) { pictureBox4.Visible = true; label6.Text = j.ToString(); label6.Visible = true; }
            if (l > 0) { pictureBox3.Visible = true; label5.Text = l.ToString(); label5.Visible = true; }
            if (n > 0) { pictureBox8.Visible = true; label8.Text = n.ToString(); label8.Visible = true; }
            if (p > 0) { pictureBox7.Visible = true; label9.Text = p.ToString(); label9.Visible = true; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}