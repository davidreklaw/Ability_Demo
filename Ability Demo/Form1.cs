using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ability_Demo
{
    public partial class Form1 : Form
    {
        private bool labelExists = false;
        private bool textExists = false;
        private Size formSize;
        private int controlWidth;
        private int controlHeight;
        private UserControl1.UserControl1 userControl1;
        private UserControl1.UserControl2 userControl2;

        public Form1()
        {
            InitializeComponent();
            this.formSize = this.Size;
            double width = this.formSize.Width * .75;
            double height = this.formSize.Height * .20;
            this.controlWidth = (int)Math.Ceiling(width);
            this.controlHeight = (int)Math.Ceiling(height);
        }

        private void uc1Button_Click(object sender, EventArgs e)
        {
            if (this.labelExists)
            {
                this.labelExists = false;
                this.Controls.Remove(this.userControl1);
                this.uc1Button.Text = "Add UC1";
            }
            else
            {
                this.userControl1 = new UserControl1.UserControl1();
                this.userControl1.Location = new Point(30, 30);
                this.Controls.Add(this.userControl1);
                this.uc1Button.Text = "Remove UC1";
                this.labelExists = true;
            }
        }

        private void uc2Button_Click(object sender, EventArgs e)
        {
            if (this.textExists)
            {
                this.Controls.Remove(this.userControl2);
                this.textExists = false;
                this.uc2Button.Text = "Add UC2";
            }
            else
            {
                this.userControl2 = new UserControl1.UserControl2();
                this.userControl2.Location = new Point(30, 100);
                this.Controls.Add(this.userControl2);
                this.textExists = true;
                this.uc2Button.Text = "Remove UC2";
            }
        }
    }
}
