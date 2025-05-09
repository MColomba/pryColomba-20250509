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
            this.grbEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.nudFuerza = new System.Windows.Forms.NumericUpDown();
            this.nudDestreza = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).BeginInit();
            this.grbEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).BeginInit();
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
            // grbEstadisticas
            // 
            this.grbEstadisticas.Controls.Add(this.btnCrear);
            this.grbEstadisticas.Controls.Add(this.nudDestreza);
            this.grbEstadisticas.Controls.Add(this.nudFuerza);
            this.grbEstadisticas.Controls.Add(this.lblDestreza);
            this.grbEstadisticas.Controls.Add(this.lblFuerza);
            this.grbEstadisticas.Location = new System.Drawing.Point(569, 70);
            this.grbEstadisticas.Name = "grbEstadisticas";
            this.grbEstadisticas.Size = new System.Drawing.Size(218, 168);
            this.grbEstadisticas.TabIndex = 3;
            this.grbEstadisticas.TabStop = false;
            this.grbEstadisticas.Text = "Stats";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(24, 37);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 0;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(24, 73);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(49, 13);
            this.lblDestreza.TabIndex = 1;
            this.lblDestreza.Text = "Destreza";
            // 
            // nudFuerza
            // 
            this.nudFuerza.Location = new System.Drawing.Point(79, 35);
            this.nudFuerza.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFuerza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFuerza.Name = "nudFuerza";
            this.nudFuerza.Size = new System.Drawing.Size(120, 20);
            this.nudFuerza.TabIndex = 2;
            this.nudFuerza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDestreza
            // 
            this.nudDestreza.Location = new System.Drawing.Point(80, 72);
            this.nudDestreza.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDestreza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDestreza.Name = "nudDestreza";
            this.nudDestreza.Size = new System.Drawing.Size(120, 20);
            this.nudDestreza.TabIndex = 3;
            this.nudDestreza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(79, 127);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.grbEstadisticas);
            this.Controls.Add(this.picSimbolo);
            this.Controls.Add(this.cmbHeroes);
            this.Controls.Add(this.lblHeroes);
            this.Name = "frmHeroes";
            this.Text = "Elegi tu Heroe";
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).EndInit();
            this.grbEstadisticas.ResumeLayout(false);
            this.grbEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.ComboBox cmbHeroes;
        private System.Windows.Forms.PictureBox picSimbolo;
        private System.Windows.Forms.GroupBox grbEstadisticas;
        private System.Windows.Forms.NumericUpDown nudDestreza;
        private System.Windows.Forms.NumericUpDown nudFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Button btnCrear;
    }
}

