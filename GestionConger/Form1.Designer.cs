namespace GestionConger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelStyle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.labelErreur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitter = new FontAwesome.Sharp.IconButton();
            this.btnEntrer = new FontAwesome.Sharp.IconButton();
            this.cbAfficheMdp = new System.Windows.Forms.CheckBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChamps.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStyle
            // 
            this.panelStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelStyle.Controls.Add(this.pictureBox2);
            this.panelStyle.Controls.Add(this.pictureBox1);
            this.panelStyle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStyle.Location = new System.Drawing.Point(0, 0);
            this.panelStyle.Name = "panelStyle";
            this.panelStyle.Size = new System.Drawing.Size(325, 411);
            this.panelStyle.TabIndex = 0;
            this.panelStyle.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // panelChamps
            // 
            this.panelChamps.BackColor = System.Drawing.Color.White;
            this.panelChamps.Controls.Add(this.labelErreur);
            this.panelChamps.Controls.Add(this.label5);
            this.panelChamps.Controls.Add(this.btnQuitter);
            this.panelChamps.Controls.Add(this.btnEntrer);
            this.panelChamps.Controls.Add(this.cbAfficheMdp);
            this.panelChamps.Controls.Add(this.txtMdp);
            this.panelChamps.Controls.Add(this.txtNom);
            this.panelChamps.Controls.Add(this.label2);
            this.panelChamps.Controls.Add(this.label1);
            this.panelChamps.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChamps.Location = new System.Drawing.Point(326, 0);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(308, 411);
            this.panelChamps.TabIndex = 1;
            // 
            // labelErreur
            // 
            this.labelErreur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelErreur.ForeColor = System.Drawing.Color.DarkRed;
            this.labelErreur.Location = new System.Drawing.Point(3, 223);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(302, 13);
            this.labelErreur.TabIndex = 9;
            this.labelErreur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(64, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "BIENVENUE";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuitter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQuitter.IconColor = System.Drawing.Color.Black;
            this.btnQuitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitter.Location = new System.Drawing.Point(181, 337);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(96, 32);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter!";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEntrer
            // 
            this.btnEntrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEntrer.FlatAppearance.BorderSize = 0;
            this.btnEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntrer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEntrer.IconColor = System.Drawing.Color.Black;
            this.btnEntrer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntrer.Location = new System.Drawing.Point(46, 337);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(96, 32);
            this.btnEntrer.TabIndex = 6;
            this.btnEntrer.Text = "Entrer";
            this.btnEntrer.UseVisualStyleBackColor = false;
            this.btnEntrer.Click += new System.EventHandler(this.btnEntrer_Click);
            // 
            // cbAfficheMdp
            // 
            this.cbAfficheMdp.AutoSize = true;
            this.cbAfficheMdp.Location = new System.Drawing.Point(32, 250);
            this.cbAfficheMdp.Name = "cbAfficheMdp";
            this.cbAfficheMdp.Size = new System.Drawing.Size(139, 17);
            this.cbAfficheMdp.TabIndex = 5;
            this.cbAfficheMdp.Text = "Afficher le mot de passe";
            this.cbAfficheMdp.UseVisualStyleBackColor = true;
            this.cbAfficheMdp.CheckedChanged += new System.EventHandler(this.cbAfficheMdp_CheckedChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(130, 189);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(149, 20);
            this.txtMdp.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 114);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(149, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mots de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panelChamps);
            this.Controls.Add(this.panelStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChamps.ResumeLayout(false);
            this.panelChamps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStyle;
        private System.Windows.Forms.Panel panelChamps;
        private FontAwesome.Sharp.IconButton btnQuitter;
        private FontAwesome.Sharp.IconButton btnEntrer;
        private System.Windows.Forms.CheckBox cbAfficheMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelErreur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

