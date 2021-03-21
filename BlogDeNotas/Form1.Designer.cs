namespace BlogDeNotas
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.lblCotenido = new System.Windows.Forms.Label();
            this.cbConsultar = new System.Windows.Forms.ComboBox();
            this.lblNombreConsultar = new System.Windows.Forms.Label();
            this.lblConsultarNota = new System.Windows.Forms.Label();
            this.lblConsultarFecha = new System.Windows.Forms.Label();
            this.txtNombreConsultar = new System.Windows.Forms.TextBox();
            this.txtNotaConsultar = new System.Windows.Forms.TextBox();
            this.txtFechaConsultar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.rbtonDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbtnAutor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir Nota";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(261, 43);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(261, 106);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(89, 116);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(89, 177);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(129, 180);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(31, 116);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAutor.TabIndex = 6;
            this.lblNombreAutor.Text = "Nombre:";
            // 
            // lblCotenido
            // 
            this.lblCotenido.AutoSize = true;
            this.lblCotenido.Location = new System.Drawing.Point(34, 177);
            this.lblCotenido.Name = "lblCotenido";
            this.lblCotenido.Size = new System.Drawing.Size(33, 13);
            this.lblCotenido.TabIndex = 7;
            this.lblCotenido.Text = "Nota:";
            // 
            // cbConsultar
            // 
            this.cbConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultar.FormattingEnabled = true;
            this.cbConsultar.Location = new System.Drawing.Point(569, 140);
            this.cbConsultar.Name = "cbConsultar";
            this.cbConsultar.Size = new System.Drawing.Size(195, 21);
            this.cbConsultar.TabIndex = 8;
            this.cbConsultar.SelectedIndexChanged += new System.EventHandler(this.cbConsultar_SelectedIndexChanged);
            // 
            // lblNombreConsultar
            // 
            this.lblNombreConsultar.AutoSize = true;
            this.lblNombreConsultar.Location = new System.Drawing.Point(566, 187);
            this.lblNombreConsultar.Name = "lblNombreConsultar";
            this.lblNombreConsultar.Size = new System.Drawing.Size(47, 13);
            this.lblNombreConsultar.TabIndex = 9;
            this.lblNombreConsultar.Text = "Nombre:";
            this.lblNombreConsultar.Visible = false;
            // 
            // lblConsultarNota
            // 
            this.lblConsultarNota.AutoSize = true;
            this.lblConsultarNota.Location = new System.Drawing.Point(566, 280);
            this.lblConsultarNota.Name = "lblConsultarNota";
            this.lblConsultarNota.Size = new System.Drawing.Size(33, 13);
            this.lblConsultarNota.TabIndex = 11;
            this.lblConsultarNota.Text = "Nota:";
            this.lblConsultarNota.Visible = false;
            // 
            // lblConsultarFecha
            // 
            this.lblConsultarFecha.AutoSize = true;
            this.lblConsultarFecha.Location = new System.Drawing.Point(566, 231);
            this.lblConsultarFecha.Name = "lblConsultarFecha";
            this.lblConsultarFecha.Size = new System.Drawing.Size(40, 13);
            this.lblConsultarFecha.TabIndex = 13;
            this.lblConsultarFecha.Text = "Fecha:";
            this.lblConsultarFecha.Visible = false;
            // 
            // txtNombreConsultar
            // 
            this.txtNombreConsultar.Location = new System.Drawing.Point(624, 180);
            this.txtNombreConsultar.Name = "txtNombreConsultar";
            this.txtNombreConsultar.Size = new System.Drawing.Size(115, 20);
            this.txtNombreConsultar.TabIndex = 14;
            this.txtNombreConsultar.Visible = false;
            // 
            // txtNotaConsultar
            // 
            this.txtNotaConsultar.Location = new System.Drawing.Point(624, 280);
            this.txtNotaConsultar.Multiline = true;
            this.txtNotaConsultar.Name = "txtNotaConsultar";
            this.txtNotaConsultar.Size = new System.Drawing.Size(115, 153);
            this.txtNotaConsultar.TabIndex = 15;
            this.txtNotaConsultar.Visible = false;
            // 
            // txtFechaConsultar
            // 
            this.txtFechaConsultar.Location = new System.Drawing.Point(624, 224);
            this.txtFechaConsultar.Name = "txtFechaConsultar";
            this.txtFechaConsultar.ReadOnly = true;
            this.txtFechaConsultar.Size = new System.Drawing.Size(115, 20);
            this.txtFechaConsultar.TabIndex = 16;
            this.txtFechaConsultar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "CONSULTAR";
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Location = new System.Drawing.Point(383, 25);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(120, 17);
            this.rbtnFecha.TabIndex = 0;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Consultar por Fecha";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            this.rbtnFecha.CheckedChanged += new System.EventHandler(this.rbtnFecha_CheckedChanged);
            // 
            // rbtonDescripcion
            // 
            this.rbtonDescripcion.AutoSize = true;
            this.rbtonDescripcion.Location = new System.Drawing.Point(383, 119);
            this.rbtonDescripcion.Name = "rbtonDescripcion";
            this.rbtonDescripcion.Size = new System.Drawing.Size(146, 17);
            this.rbtonDescripcion.TabIndex = 2;
            this.rbtonDescripcion.TabStop = true;
            this.rbtonDescripcion.Text = "Consultar por Descrpición";
            this.rbtonDescripcion.UseVisualStyleBackColor = true;
            this.rbtonDescripcion.CheckedChanged += new System.EventHandler(this.rbtonDescripcion_CheckedChanged);
            // 
            // rdbtnAutor
            // 
            this.rdbtnAutor.AutoSize = true;
            this.rdbtnAutor.Location = new System.Drawing.Point(383, 70);
            this.rdbtnAutor.Name = "rdbtnAutor";
            this.rdbtnAutor.Size = new System.Drawing.Size(115, 17);
            this.rdbtnAutor.TabIndex = 4;
            this.rdbtnAutor.TabStop = true;
            this.rdbtnAutor.Text = "Consultar por Autor";
            this.rdbtnAutor.UseVisualStyleBackColor = true;
            this.rdbtnAutor.CheckedChanged += new System.EventHandler(this.rdbtnAutor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.rdbtnAutor);
            this.Controls.Add(this.rbtonDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnFecha);
            this.Controls.Add(this.txtFechaConsultar);
            this.Controls.Add(this.txtNotaConsultar);
            this.Controls.Add(this.txtNombreConsultar);
            this.Controls.Add(this.lblConsultarFecha);
            this.Controls.Add(this.lblConsultarNota);
            this.Controls.Add(this.lblNombreConsultar);
            this.Controls.Add(this.cbConsultar);
            this.Controls.Add(this.lblCotenido);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Bloc De Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Label lblCotenido;
        private System.Windows.Forms.ComboBox cbConsultar;
        private System.Windows.Forms.Label lblNombreConsultar;
        private System.Windows.Forms.Label lblConsultarNota;
        private System.Windows.Forms.Label lblConsultarFecha;
        private System.Windows.Forms.TextBox txtNombreConsultar;
        private System.Windows.Forms.TextBox txtNotaConsultar;
        private System.Windows.Forms.TextBox txtFechaConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnAutor;
        private System.Windows.Forms.RadioButton rbtonDescripcion;
        private System.Windows.Forms.RadioButton rbtnFecha;
    }
}

