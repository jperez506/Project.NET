namespace Proyec.v1
{
    partial class crudTroquel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCrearTro = new System.Windows.Forms.Button();
            this.dtgTroquel = new System.Windows.Forms.DataGridView();
            this.txtTroquel = new System.Windows.Forms.TextBox();
            this.txctMaterial = new System.Windows.Forms.TextBox();
            this.txtCarac = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btModificarTro = new System.Windows.Forms.Button();
            this.btnEliminarTro = new System.Windows.Forms.Button();
            this.dateOrigen = new System.Windows.Forms.DateTimePicker();
            this.dateMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarTro = new System.Windows.Forms.Button();
            this.pError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEstadoT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTroquel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(371, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Troquel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Troquel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Troquel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(92, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion del Troquel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(92, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material donde se aplica el troquel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(92, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caracteristicas del Troquel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(92, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(92, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de Mantenimiento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(92, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha Origen del Troquel:";
            // 
            // btnCrearTro
            // 
            this.btnCrearTro.BackColor = System.Drawing.Color.Navy;
            this.btnCrearTro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearTro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearTro.Location = new System.Drawing.Point(811, 195);
            this.btnCrearTro.Name = "btnCrearTro";
            this.btnCrearTro.Size = new System.Drawing.Size(109, 42);
            this.btnCrearTro.TabIndex = 10;
            this.btnCrearTro.Text = "Crear";
            this.btnCrearTro.UseVisualStyleBackColor = false;
            this.btnCrearTro.Click += new System.EventHandler(this.btnCrearTro_Click);
            // 
            // dtgTroquel
            // 
            this.dtgTroquel.AllowUserToAddRows = false;
            this.dtgTroquel.AllowUserToDeleteRows = false;
            this.dtgTroquel.AllowUserToOrderColumns = true;
            this.dtgTroquel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgTroquel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTroquel.Location = new System.Drawing.Point(21, 408);
            this.dtgTroquel.Name = "dtgTroquel";
            this.dtgTroquel.ReadOnly = true;
            this.dtgTroquel.RowHeadersVisible = false;
            this.dtgTroquel.RowHeadersWidth = 51;
            this.dtgTroquel.RowTemplate.Height = 24;
            this.dtgTroquel.Size = new System.Drawing.Size(1241, 280);
            this.dtgTroquel.TabIndex = 13;
            // 
            // txtTroquel
            // 
            this.txtTroquel.Location = new System.Drawing.Point(377, 123);
            this.txtTroquel.Name = "txtTroquel";
            this.txtTroquel.Size = new System.Drawing.Size(406, 22);
            this.txtTroquel.TabIndex = 14;
            // 
            // txctMaterial
            // 
            this.txctMaterial.Location = new System.Drawing.Point(377, 255);
            this.txctMaterial.Name = "txctMaterial";
            this.txctMaterial.Size = new System.Drawing.Size(406, 22);
            this.txctMaterial.TabIndex = 16;
            // 
            // txtCarac
            // 
            this.txtCarac.Location = new System.Drawing.Point(377, 207);
            this.txtCarac.Name = "txtCarac";
            this.txtCarac.Size = new System.Drawing.Size(406, 22);
            this.txtCarac.TabIndex = 17;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(377, 170);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(406, 22);
            this.txtDesc.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(377, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(406, 22);
            this.txtCodigo.TabIndex = 19;
            // 
            // btModificarTro
            // 
            this.btModificarTro.BackColor = System.Drawing.Color.Navy;
            this.btModificarTro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btModificarTro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btModificarTro.Location = new System.Drawing.Point(811, 255);
            this.btModificarTro.Name = "btModificarTro";
            this.btModificarTro.Size = new System.Drawing.Size(109, 42);
            this.btModificarTro.TabIndex = 22;
            this.btModificarTro.Text = "Modificar";
            this.btModificarTro.UseVisualStyleBackColor = false;
            this.btModificarTro.Click += new System.EventHandler(this.btModificarTro_Click);
            // 
            // btnEliminarTro
            // 
            this.btnEliminarTro.BackColor = System.Drawing.Color.Navy;
            this.btnEliminarTro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTro.Location = new System.Drawing.Point(811, 334);
            this.btnEliminarTro.Name = "btnEliminarTro";
            this.btnEliminarTro.Size = new System.Drawing.Size(109, 42);
            this.btnEliminarTro.TabIndex = 23;
            this.btnEliminarTro.Text = "Eliminar";
            this.btnEliminarTro.UseVisualStyleBackColor = false;
            this.btnEliminarTro.Click += new System.EventHandler(this.btnEliminarTro_Click);
            // 
            // dateOrigen
            // 
            this.dateOrigen.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dateOrigen.Location = new System.Drawing.Point(377, 291);
            this.dateOrigen.Name = "dateOrigen";
            this.dateOrigen.Size = new System.Drawing.Size(275, 27);
            this.dateOrigen.TabIndex = 24;
            this.dateOrigen.ValueChanged += new System.EventHandler(this.dateOrigen_ValueChanged);
            // 
            // dateMantenimiento
            // 
            this.dateMantenimiento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dateMantenimiento.Location = new System.Drawing.Point(377, 326);
            this.dateMantenimiento.Name = "dateMantenimiento";
            this.dateMantenimiento.Size = new System.Drawing.Size(275, 27);
            this.dateMantenimiento.TabIndex = 25;
            // 
            // btnConsultarTro
            // 
            this.btnConsultarTro.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarTro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultarTro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarTro.Location = new System.Drawing.Point(936, 334);
            this.btnConsultarTro.Name = "btnConsultarTro";
            this.btnConsultarTro.Size = new System.Drawing.Size(147, 42);
            this.btnConsultarTro.TabIndex = 26;
            this.btnConsultarTro.Text = "Consultar";
            this.btnConsultarTro.UseVisualStyleBackColor = false;
            this.btnConsultarTro.Click += new System.EventHandler(this.btnConsultarTro_Click);
            // 
            // pError
            // 
            this.pError.ContainerControl = this;
            // 
            // txtEstadoT
            // 
            this.txtEstadoT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstadoT.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtEstadoT.FormattingEnabled = true;
            this.txtEstadoT.Location = new System.Drawing.Point(377, 362);
            this.txtEstadoT.Name = "txtEstadoT";
            this.txtEstadoT.Size = new System.Drawing.Size(406, 30);
            this.txtEstadoT.TabIndex = 27;
            // 
            // crudTroquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1290, 710);
            this.Controls.Add(this.txtEstadoT);
            this.Controls.Add(this.btnConsultarTro);
            this.Controls.Add(this.dateMantenimiento);
            this.Controls.Add(this.dateOrigen);
            this.Controls.Add(this.btnEliminarTro);
            this.Controls.Add(this.btModificarTro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCarac);
            this.Controls.Add(this.txctMaterial);
            this.Controls.Add(this.txtTroquel);
            this.Controls.Add(this.dtgTroquel);
            this.Controls.Add(this.btnCrearTro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "crudTroquel";
            this.Text = "crudTroquel";
            this.Load += new System.EventHandler(this.crudTroquel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTroquel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCrearTro;
        private System.Windows.Forms.DataGridView dtgTroquel;
        private System.Windows.Forms.TextBox txtTroquel;
        private System.Windows.Forms.TextBox txctMaterial;
        private System.Windows.Forms.TextBox txtCarac;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btModificarTro;
        private System.Windows.Forms.Button btnEliminarTro;
        private System.Windows.Forms.DateTimePicker dateOrigen;
        private System.Windows.Forms.DateTimePicker dateMantenimiento;
        private System.Windows.Forms.Button btnConsultarTro;
        private System.Windows.Forms.ErrorProvider pError;
        private System.Windows.Forms.ComboBox txtEstadoT;
    }
}