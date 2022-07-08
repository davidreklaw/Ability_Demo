
namespace Ability_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uc1Button = new System.Windows.Forms.Button();
            this.uc2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uc1Button
            // 
            this.uc1Button.Location = new System.Drawing.Point(69, 325);
            this.uc1Button.Name = "uc1Button";
            this.uc1Button.Size = new System.Drawing.Size(136, 23);
            this.uc1Button.TabIndex = 0;
            this.uc1Button.Text = "Add UC1";
            this.uc1Button.UseVisualStyleBackColor = true;
            this.uc1Button.Click += new System.EventHandler(this.uc1Button_Click);
            // 
            // uc2Button
            // 
            this.uc2Button.Location = new System.Drawing.Point(263, 325);
            this.uc2Button.Name = "uc2Button";
            this.uc2Button.Size = new System.Drawing.Size(128, 23);
            this.uc2Button.TabIndex = 1;
            this.uc2Button.Text = "Add UC2";
            this.uc2Button.UseVisualStyleBackColor = true;
            this.uc2Button.Click += new System.EventHandler(this.uc2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 380);
            this.Controls.Add(this.uc2Button);
            this.Controls.Add(this.uc1Button);
            this.Name = "Form1";
            this.Text = "Ability Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uc1Button;
        private System.Windows.Forms.Button uc2Button;
    }
}

