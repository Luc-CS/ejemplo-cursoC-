namespace WinForms2
{
    partial class Form1
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chbChocolate = new System.Windows.Forms.CheckBox();
            this.titulo = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rdbMuggle = new System.Windows.Forms.RadioButton();
            this.rdbSquibs = new System.Windows.Forms.RadioButton();
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbNumeroFav = new System.Windows.Forms.Label();
            this.numFavorito = new System.Windows.Forms.NumericUpDown();
            this.btVerPerfil = new System.Windows.Forms.Button();
            this.gpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btAgregar.Location = new System.Drawing.Point(95, 554);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 26);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElemento.Location = new System.Drawing.Point(238, 81);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(200, 22);
            this.txtElemento.TabIndex = 0;
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(142, 419);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(207, 115);
            this.lwElementos.TabIndex = 6;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(238, 124);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // chbChocolate
            // 
            this.chbChocolate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbChocolate.AutoSize = true;
            this.chbChocolate.Location = new System.Drawing.Point(238, 169);
            this.chbChocolate.Name = "chbChocolate";
            this.chbChocolate.Size = new System.Drawing.Size(165, 20);
            this.chbChocolate.TabIndex = 8;
            this.chbChocolate.Text = "Te gusta el chocolate?";
            this.chbChocolate.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(92, 26);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(257, 32);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "PERFIL PERSONA";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Location = new System.Drawing.Point(6, 30);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(70, 20);
            this.rbtWizard.TabIndex = 8;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rdbMuggle
            // 
            this.rdbMuggle.AutoSize = true;
            this.rdbMuggle.Location = new System.Drawing.Point(112, 30);
            this.rdbMuggle.Name = "rdbMuggle";
            this.rdbMuggle.Size = new System.Drawing.Size(73, 20);
            this.rdbMuggle.TabIndex = 9;
            this.rdbMuggle.TabStop = true;
            this.rdbMuggle.Text = "Muggle";
            this.rdbMuggle.UseVisualStyleBackColor = true;
            // 
            // rdbSquibs
            // 
            this.rdbSquibs.AutoSize = true;
            this.rdbSquibs.Location = new System.Drawing.Point(251, 30);
            this.rdbSquibs.Name = "rdbSquibs";
            this.rdbSquibs.Size = new System.Drawing.Size(70, 20);
            this.rdbSquibs.TabIndex = 10;
            this.rdbSquibs.TabStop = true;
            this.rdbSquibs.Text = "Squibs";
            this.rdbSquibs.UseVisualStyleBackColor = true;
            // 
            // gpTipo
            // 
            this.gpTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpTipo.Controls.Add(this.rbtWizard);
            this.gpTipo.Controls.Add(this.rdbSquibs);
            this.gpTipo.Controls.Add(this.rdbMuggle);
            this.gpTipo.Location = new System.Drawing.Point(98, 210);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Size = new System.Drawing.Size(352, 56);
            this.gpTipo.TabIndex = 2;
            this.gpTipo.TabStop = false;
            this.gpTipo.Text = "Tipo";
            this.gpTipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color Favorito:";
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(238, 285);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(200, 24);
            this.cbColor.TabIndex = 3;
            // 
            // lbNumeroFav
            // 
            this.lbNumeroFav.AutoSize = true;
            this.lbNumeroFav.Location = new System.Drawing.Point(95, 335);
            this.lbNumeroFav.Name = "lbNumeroFav";
            this.lbNumeroFav.Size = new System.Drawing.Size(110, 16);
            this.lbNumeroFav.TabIndex = 14;
            this.lbNumeroFav.Text = "Numero Favorito:";
            // 
            // numFavorito
            // 
            this.numFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFavorito.Location = new System.Drawing.Point(238, 335);
            this.numFavorito.Name = "numFavorito";
            this.numFavorito.Size = new System.Drawing.Size(200, 22);
            this.numFavorito.TabIndex = 4;
            // 
            // btVerPerfil
            // 
            this.btVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerPerfil.Location = new System.Drawing.Point(98, 369);
            this.btVerPerfil.Name = "btVerPerfil";
            this.btVerPerfil.Size = new System.Drawing.Size(88, 34);
            this.btVerPerfil.TabIndex = 5;
            this.btVerPerfil.Text = "Ver Perfil";
            this.btVerPerfil.UseVisualStyleBackColor = true;
            this.btVerPerfil.Click += new System.EventHandler(this.btVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 598);
            this.Controls.Add(this.btVerPerfil);
            this.Controls.Add(this.numFavorito);
            this.Controls.Add(this.lbNumeroFav);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpTipo);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.chbChocolate);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btAgregar);
            this.MinimumSize = new System.Drawing.Size(522, 645);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chbChocolate;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rdbMuggle;
        private System.Windows.Forms.RadioButton rdbSquibs;
        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbNumeroFav;
        private System.Windows.Forms.NumericUpDown numFavorito;
        private System.Windows.Forms.Button btVerPerfil;
    }
}

