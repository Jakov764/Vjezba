namespace cvekSpraljaJakovVjezba
{
    partial class Form1
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
            this.labelIme = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonPodaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(81, 53);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(81, 90);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // buttonPodaci
            // 
            this.buttonPodaci.Location = new System.Drawing.Point(116, 136);
            this.buttonPodaci.Name = "buttonPodaci";
            this.buttonPodaci.Size = new System.Drawing.Size(75, 23);
            this.buttonPodaci.TabIndex = 4;
            this.buttonPodaci.Text = "Prikaži podatke";
            this.buttonPodaci.UseVisualStyleBackColor = true;
            this.buttonPodaci.Click += new System.EventHandler(this.ButtonPodaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 212);
            this.Controls.Add(this.buttonPodaci);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonPodaci;
    }
}

