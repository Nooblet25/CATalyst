namespace CATalystttt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signup_close = new System.Windows.Forms.Label();
            this.loginHere = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.loginHere);
            this.panel2.Location = new System.Drawing.Point(-94, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 601);
            this.panel2.TabIndex = 0;
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.BackColor = System.Drawing.Color.Transparent;
            this.signup_close.Font = new System.Drawing.Font("Classic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(1125, 5);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(24, 16);
            this.signup_close.TabIndex = 17;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // loginHere
            // 
            this.loginHere.BackColor = System.Drawing.Color.Chocolate;
            this.loginHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginHere.Font = new System.Drawing.Font("Classic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHere.ForeColor = System.Drawing.Color.SeaShell;
            this.loginHere.Location = new System.Drawing.Point(491, 457);
            this.loginHere.Name = "loginHere";
            this.loginHere.Size = new System.Drawing.Size(226, 49);
            this.loginHere.TabIndex = 18;
            this.loginHere.Text = "LET THE JOURNY BEGIN!";
            this.loginHere.UseVisualStyleBackColor = false;
            this.loginHere.Click += new System.EventHandler(this.loginHere_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 670);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Button loginHere;
    }
}