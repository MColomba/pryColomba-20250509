namespace pryColomba_20250509
{
    partial class frmHeroes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeroes = new System.Windows.Forms.Label();
            this.cmbHeroes = new System.Windows.Forms.ComboBox();
            this.picSimbolo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(252, 27);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(41, 13);
            this.lblHeroes.TabIndex = 0;
            this.lblHeroes.Text = "Heroes";
            // 
            // cmbHeroes
            // 
            this.cmbHeroes.FormattingEnabled = true;
            this.cmbHeroes.Location = new System.Drawing.Point(216, 43);
            this.cmbHeroes.Name = "cmbHeroes";
            this.cmbHeroes.Size = new System.Drawing.Size(121, 21);
            this.cmbHeroes.TabIndex = 1;
            this.cmbHeroes.SelectedIndexChanged += new System.EventHandler(this.cmbHeroes_SelectedIndexChanged);
            // 
            // picSimbolo
            // 
            this.picSimbolo.Location = new System.Drawing.Point(12, 70);
            this.picSimbolo.Name = "picSimbolo";
            this.picSimbolo.Size = new System.Drawing.Size(551, 368);
            this.picSimbolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSimbolo.TabIndex = 2;
            this.picSimbolo.TabStop = false;
            // 
            // frmHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.picSimbolo);
            this.Controls.Add(this.cmbHeroes);
            this.Controls.Add(this.lblHeroes);
            this.Name = "frmHeroes";
            this.Text = "Elegi tu Heroe";
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.ComboBox cmbHeroes;
        private System.Windows.Forms.PictureBox picSimbolo;
    }
}

