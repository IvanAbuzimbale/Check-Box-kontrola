namespace Check_box_kontrola
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
            this.Dorucak = new System.Windows.Forms.CheckBox();
            this.Rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.Sakrij_narudzbu = new System.Windows.Forms.CheckBox();
            this.Popis = new System.Windows.Forms.TextBox();
            this.Posalji_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dorucak
            // 
            this.Dorucak.AutoSize = true;
            this.Dorucak.Location = new System.Drawing.Point(27, 36);
            this.Dorucak.Name = "Dorucak";
            this.Dorucak.Size = new System.Drawing.Size(67, 17);
            this.Dorucak.TabIndex = 0;
            this.Dorucak.Text = "Doručak";
            this.Dorucak.UseVisualStyleBackColor = true;
            // 
            // Rucak
            // 
            this.Rucak.AutoSize = true;
            this.Rucak.Location = new System.Drawing.Point(27, 59);
            this.Rucak.Name = "Rucak";
            this.Rucak.Size = new System.Drawing.Size(58, 17);
            this.Rucak.TabIndex = 1;
            this.Rucak.Text = "Ručak";
            this.Rucak.UseVisualStyleBackColor = true;
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(27, 82);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(60, 17);
            this.Vecera.TabIndex = 2;
            this.Vecera.Text = "Večera";
            this.Vecera.UseVisualStyleBackColor = true;
            // 
            // Sakrij_narudzbu
            // 
            this.Sakrij_narudzbu.AutoSize = true;
            this.Sakrij_narudzbu.Location = new System.Drawing.Point(125, 135);
            this.Sakrij_narudzbu.Name = "Sakrij_narudzbu";
            this.Sakrij_narudzbu.Size = new System.Drawing.Size(99, 17);
            this.Sakrij_narudzbu.TabIndex = 3;
            this.Sakrij_narudzbu.Text = "Sakrij narudžbu";
            this.Sakrij_narudzbu.UseVisualStyleBackColor = true;
            this.Sakrij_narudzbu.CheckedChanged += new System.EventHandler(this.Sakrij_narudzbu_CheckedChanged);
            // 
            // Popis
            // 
            this.Popis.Location = new System.Drawing.Point(113, 34);
            this.Popis.Multiline = true;
            this.Popis.Name = "Popis";
            this.Popis.Size = new System.Drawing.Size(165, 95);
            this.Popis.TabIndex = 4;
            this.Popis.TextChanged += new System.EventHandler(this.Popis_TextChanged);
            // 
            // Posalji_btn
            // 
            this.Posalji_btn.Location = new System.Drawing.Point(27, 135);
            this.Posalji_btn.Name = "Posalji_btn";
            this.Posalji_btn.Size = new System.Drawing.Size(75, 23);
            this.Posalji_btn.TabIndex = 5;
            this.Posalji_btn.Text = "Pošalji";
            this.Posalji_btn.UseVisualStyleBackColor = true;
            this.Posalji_btn.Click += new System.EventHandler(this.Posalji_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Posalji_btn);
            this.Controls.Add(this.Popis);
            this.Controls.Add(this.Sakrij_narudzbu);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.Rucak);
            this.Controls.Add(this.Dorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Dorucak;
        private System.Windows.Forms.CheckBox Rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.CheckBox Sakrij_narudzbu;
        private System.Windows.Forms.TextBox Popis;
        private System.Windows.Forms.Button Posalji_btn;
    }
}

