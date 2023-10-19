namespace ClasseAuto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.motoreb = new System.Windows.Forms.Button();
            this.velocitap = new System.Windows.Forms.Button();
            this.velocitam = new System.Windows.Forms.Button();
            this.vel = new System.Windows.Forms.TextBox();
            this.aummarcia = new System.Windows.Forms.Button();
            this.scalamar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.velres = new System.Windows.Forms.TextBox();
            this.marres = new System.Windows.Forms.TextBox();
            this.manuale = new System.Windows.Forms.Button();
            this.automatico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motoreb
            // 
            this.motoreb.Location = new System.Drawing.Point(120, 163);
            this.motoreb.Name = "motoreb";
            this.motoreb.Size = new System.Drawing.Size(75, 23);
            this.motoreb.TabIndex = 0;
            this.motoreb.Text = "MOTORE";
            this.motoreb.UseVisualStyleBackColor = true;
            this.motoreb.Click += new System.EventHandler(this.motoreb_Click);
            // 
            // velocitap
            // 
            this.velocitap.Location = new System.Drawing.Point(312, 163);
            this.velocitap.Name = "velocitap";
            this.velocitap.Size = new System.Drawing.Size(75, 23);
            this.velocitap.TabIndex = 1;
            this.velocitap.Text = "ACCELERA";
            this.velocitap.UseVisualStyleBackColor = true;
            this.velocitap.Click += new System.EventHandler(this.velocitap_Click);
            // 
            // velocitam
            // 
            this.velocitam.Location = new System.Drawing.Point(393, 163);
            this.velocitam.Name = "velocitam";
            this.velocitam.Size = new System.Drawing.Size(75, 23);
            this.velocitam.TabIndex = 2;
            this.velocitam.Text = "DECELERA";
            this.velocitam.UseVisualStyleBackColor = true;
            this.velocitam.Click += new System.EventHandler(this.velocitam_Click);
            // 
            // vel
            // 
            this.vel.Location = new System.Drawing.Point(341, 192);
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(100, 20);
            this.vel.TabIndex = 3;
            // 
            // aummarcia
            // 
            this.aummarcia.Location = new System.Drawing.Point(606, 230);
            this.aummarcia.Name = "aummarcia";
            this.aummarcia.Size = new System.Drawing.Size(75, 23);
            this.aummarcia.TabIndex = 4;
            this.aummarcia.Text = "AUMENTA";
            this.aummarcia.UseVisualStyleBackColor = true;
            this.aummarcia.Click += new System.EventHandler(this.aummarcia_Click);
            // 
            // scalamar
            // 
            this.scalamar.Location = new System.Drawing.Point(606, 260);
            this.scalamar.Name = "scalamar";
            this.scalamar.Size = new System.Drawing.Size(75, 23);
            this.scalamar.TabIndex = 5;
            this.scalamar.Text = "SCALA";
            this.scalamar.UseVisualStyleBackColor = true;
            this.scalamar.Click += new System.EventHandler(this.scalamar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARCIA";
            // 
            // velres
            // 
            this.velres.Location = new System.Drawing.Point(326, 230);
            this.velres.Multiline = true;
            this.velres.Name = "velres";
            this.velres.Size = new System.Drawing.Size(129, 59);
            this.velres.TabIndex = 7;
            // 
            // marres
            // 
            this.marres.Location = new System.Drawing.Point(593, 175);
            this.marres.Multiline = true;
            this.marres.Name = "marres";
            this.marres.Size = new System.Drawing.Size(100, 49);
            this.marres.TabIndex = 8;
            // 
            // manuale
            // 
            this.manuale.Location = new System.Drawing.Point(312, 77);
            this.manuale.Name = "manuale";
            this.manuale.Size = new System.Drawing.Size(75, 23);
            this.manuale.TabIndex = 9;
            this.manuale.Text = "MANUALE";
            this.manuale.UseVisualStyleBackColor = true;
            this.manuale.Click += new System.EventHandler(this.manuale_Click);
            // 
            // automatico
            // 
            this.automatico.Location = new System.Drawing.Point(394, 76);
            this.automatico.Name = "automatico";
            this.automatico.Size = new System.Drawing.Size(75, 23);
            this.automatico.TabIndex = 10;
            this.automatico.Text = "AUTOMATICO";
            this.automatico.UseVisualStyleBackColor = true;
            this.automatico.Click += new System.EventHandler(this.automatico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.automatico);
            this.Controls.Add(this.manuale);
            this.Controls.Add(this.marres);
            this.Controls.Add(this.velres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scalamar);
            this.Controls.Add(this.aummarcia);
            this.Controls.Add(this.vel);
            this.Controls.Add(this.velocitam);
            this.Controls.Add(this.velocitap);
            this.Controls.Add(this.motoreb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button motoreb;
        private System.Windows.Forms.Button velocitap;
        private System.Windows.Forms.Button velocitam;
        private System.Windows.Forms.TextBox vel;
        private System.Windows.Forms.Button aummarcia;
        private System.Windows.Forms.Button scalamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox velres;
        private System.Windows.Forms.TextBox marres;
        private System.Windows.Forms.Button manuale;
        private System.Windows.Forms.Button automatico;
    }
}

