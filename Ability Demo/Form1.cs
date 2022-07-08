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
        private Label label;
        private TextBox text;
        private Size formSize;
        private int controlWidth;
        private int controlHeight;

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
                this.Controls.Remove(this.label);
                this.uc1Button.Text = "Add UC1";
            }
            else
            {
                this.label = new Label();
                this.label.Text = "User Control 1";
                this.label.Height = this.controlHeight;
                this.label.Width = this.controlWidth;
                this.label.Location = new Point(30,30);
                this.Controls.Add(this.label);
                this.labelExists = true;
                this.uc1Button.Text = "Remove UC1";
            }
        }

        private void uc2Button_Click(object sender, EventArgs e)
        {
            if (this.textExists)
            {
                this.Controls.Remove(this.text);
                this.textExists = false;
                this.uc2Button.Text = "Add UC2";
            }
            else
            {
                this.text = new TextBox();
                this.text.Text = "User Control 2";
                this.text.Width = this.controlWidth;
                this.text.Height = this.controlHeight;
                this.text.Location = new Point(30, 70);
                this.Controls.Add(this.text);
                this.textExists = true;
                this.uc2Button.Text = "Remove UC2";
            }
        }
    }
}
