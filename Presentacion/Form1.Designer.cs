using System;

namespace Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texCedula = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEliminarTel = new System.Windows.Forms.Button();
            this.btAgregarTel = new System.Windows.Forms.Button();
            this.DGVTelefonos = new System.Windows.Forms.DataGridView();
            this.texDescrip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTel = new System.Windows.Forms.ComboBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtBuscarPer = new System.Windows.Forms.Button();
            this.texBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.DGVPersona = new System.Windows.Forms.DataGridView();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texApellido = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Personales";
            // 
            // txnombre
            // 
            this.txnombre.Location = new System.Drawing.Point(203, 33);
            this.txnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(167, 22);
            this.txnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.texCedula);
            this.panel1.Controls.Add(this.btCargar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btEliminarTel);
            this.panel1.Controls.Add(this.btAgregarTel);
            this.panel1.Controls.Add(this.DGVTelefonos);
            this.panel1.Controls.Add(this.texDescrip);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxTel);
            this.panel1.Controls.Add(this.textTel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtBuscarPer);
            this.panel1.Controls.Add(this.texBuscar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btEliminar);
            this.panel1.Controls.Add(this.btAgregar);
            this.panel1.Controls.Add(this.DGVPersona);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.texID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.texApellido);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txnombre);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 598);
            this.panel1.TabIndex = 6;
            // 
            // texCedula
            // 
            this.texCedula.Location = new System.Drawing.Point(697, 34);
            this.texCedula.Name = "texCedula";
            this.texCedula.Size = new System.Drawing.Size(129, 22);
            this.texCedula.TabIndex = 28;
            // 
            // btCargar
            // 
            this.btCargar.BackColor = System.Drawing.Color.Red;
            this.btCargar.Location = new System.Drawing.Point(839, 433);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(143, 49);
            this.btCargar.TabIndex = 27;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Red;
            this.btSalvar.Location = new System.Drawing.Point(839, 365);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(143, 48);
            this.btSalvar.TabIndex = 26;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // btEliminarTel
            // 
            this.btEliminarTel.BackColor = System.Drawing.Color.GreenYellow;
            this.btEliminarTel.Location = new System.Drawing.Point(578, 512);
            this.btEliminarTel.Name = "btEliminarTel";
            this.btEliminarTel.Size = new System.Drawing.Size(158, 49);
            this.btEliminarTel.TabIndex = 25;
            this.btEliminarTel.Text = "Eliminar";
            this.btEliminarTel.UseVisualStyleBackColor = false;
            // 
            // btAgregarTel
            // 
            this.btAgregarTel.BackColor = System.Drawing.Color.GreenYellow;
            this.btAgregarTel.Location = new System.Drawing.Point(578, 433);
            this.btAgregarTel.Name = "btAgregarTel";
            this.btAgregarTel.Size = new System.Drawing.Size(158, 48);
            this.btAgregarTel.TabIndex = 24;
            this.btAgregarTel.Text = "Agregar";
            this.btAgregarTel.UseVisualStyleBackColor = false;
            this.btAgregarTel.Click += new System.EventHandler(this.btAgregarTel_Click);
            // 
            // DGVTelefonos
            // 
            this.DGVTelefonos.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.DGVTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTelefonos.Location = new System.Drawing.Point(7, 433);
            this.DGVTelefonos.Name = "DGVTelefonos";
            this.DGVTelefonos.RowHeadersWidth = 51;
            this.DGVTelefonos.RowTemplate.Height = 24;
            this.DGVTelefonos.Size = new System.Drawing.Size(496, 150);
            this.DGVTelefonos.TabIndex = 23;
            // 
            // texDescrip
            // 
            this.texDescrip.Location = new System.Drawing.Point(509, 347);
            this.texDescrip.Multiline = true;
            this.texDescrip.Name = "texDescrip";
            this.texDescrip.Size = new System.Drawing.Size(262, 66);
            this.texDescrip.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Decripcion:";
            // 
            // comboBoxTel
            // 
            this.comboBoxTel.FormattingEnabled = true;
            this.comboBoxTel.Items.AddRange(new object[] {
            "Seleccione",
            "-Celular",
            "-Oficina",
            "-Hogar"});
            this.comboBoxTel.Location = new System.Drawing.Point(250, 344);
            this.comboBoxTel.Name = "comboBoxTel";
            this.comboBoxTel.Size = new System.Drawing.Size(162, 24);
            this.comboBoxTel.TabIndex = 20;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(78, 344);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(127, 22);
            this.textTel.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono:";
            // 
            // BtBuscarPer
            // 
            this.BtBuscarPer.BackColor = System.Drawing.Color.GreenYellow;
            this.BtBuscarPer.Location = new System.Drawing.Point(392, 286);
            this.BtBuscarPer.Name = "BtBuscarPer";
            this.BtBuscarPer.Size = new System.Drawing.Size(139, 29);
            this.BtBuscarPer.TabIndex = 17;
            this.BtBuscarPer.Text = "Buscar Persona";
            this.BtBuscarPer.UseVisualStyleBackColor = false;
            // 
            // texBuscar
            // 
            this.texBuscar.Location = new System.Drawing.Point(66, 286);
            this.texBuscar.Name = "texBuscar";
            this.texBuscar.Size = new System.Drawing.Size(292, 22);
            this.texBuscar.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personas";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.GreenYellow;
            this.btEliminar.Location = new System.Drawing.Point(731, 185);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(163, 64);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btAgregar.Location = new System.Drawing.Point(731, 86);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(163, 65);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // DGVPersona
            // 
            this.DGVPersona.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.DGVPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersona.Location = new System.Drawing.Point(7, 103);
            this.DGVPersona.Name = "DGVPersona";
            this.DGVPersona.RowHeadersWidth = 51;
            this.DGVPersona.RowTemplate.Height = 24;
            this.DGVPersona.Size = new System.Drawing.Size(684, 163);
            this.DGVPersona.TabIndex = 11;
            this.DGVPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPersona_CellContentClick);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(912, 33);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(121, 22);
            this.textEmail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cedula:";
            // 
            // texID
            // 
            this.texID.Location = new System.Drawing.Point(40, 33);
            this.texID.Margin = new System.Windows.Forms.Padding(4);
            this.texID.Name = "texID";
            this.texID.Size = new System.Drawing.Size(61, 22);
            this.texID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // texApellido
            // 
            this.texApellido.Location = new System.Drawing.Point(456, 33);
            this.texApellido.Margin = new System.Windows.Forms.Padding(4);
            this.texApellido.Name = "texApellido";
            this.texApellido.Size = new System.Drawing.Size(153, 22);
            this.texApellido.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(379, 37);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Apellidos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(998, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 626);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersona)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox texID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texApellido;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEliminarTel;
        private System.Windows.Forms.Button btAgregarTel;
        private System.Windows.Forms.DataGridView DGVTelefonos;
        private System.Windows.Forms.TextBox texDescrip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTel;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtBuscarPer;
        private System.Windows.Forms.TextBox texBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView DGVPersona;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox texCedula;
        private System.Windows.Forms.Button button1;
    }
}

