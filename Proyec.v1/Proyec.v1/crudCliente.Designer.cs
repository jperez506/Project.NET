namespace Proyec.v1
{
    partial class crudCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoTro = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnCrearCli = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultarCli = new System.Windows.Forms.Button();
            this.pError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(286, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(127, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Troquel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(127, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula Juridica/Fisica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(127, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(127, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Contacto:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(332, 126);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(377, 22);
            this.txtCliente.TabIndex = 2;
            // 
            // txtCodigoTro
            // 
            this.txtCodigoTro.Location = new System.Drawing.Point(332, 194);
            this.txtCodigoTro.Name = "txtCodigoTro";
            this.txtCodigoTro.Size = new System.Drawing.Size(377, 22);
            this.txtCodigoTro.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(332, 88);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(377, 22);
            this.txtCedula.TabIndex = 1;

            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(332, 154);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(377, 22);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // btnCrearCli
            // 
            this.btnCrearCli.BackColor = System.Drawing.Color.Navy;
            this.btnCrearCli.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearCli.Location = new System.Drawing.Point(332, 247);
            this.btnCrearCli.Name = "btnCrearCli";
            this.btnCrearCli.Size = new System.Drawing.Size(80, 41);
            this.btnCrearCli.TabIndex = 10;
            this.btnCrearCli.Text = "Crear";
            this.btnCrearCli.UseVisualStyleBackColor = false;
            this.btnCrearCli.Click += new System.EventHandler(this.btnCrearCli_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(534, 247);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.BackColor = System.Drawing.Color.Navy;
            this.btnModificarCli.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnModificarCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarCli.Location = new System.Drawing.Point(418, 247);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(110, 41);
            this.btnModificarCli.TabIndex = 12;
            this.btnModificarCli.Text = "Modificar";
            this.btnModificarCli.UseVisualStyleBackColor = false;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgCliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(131, 305);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.RowHeadersWidth = 51;
            this.dtgCliente.RowTemplate.Height = 24;
            this.dtgCliente.Size = new System.Drawing.Size(890, 382);
            this.dtgCliente.TabIndex = 13;
 
            // 
            // btnConsultarCli
            // 
            this.btnConsultarCli.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarCli.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnConsultarCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarCli.Location = new System.Drawing.Point(633, 247);
            this.btnConsultarCli.Name = "btnConsultarCli";
            this.btnConsultarCli.Size = new System.Drawing.Size(103, 41);
            this.btnConsultarCli.TabIndex = 14;
            this.btnConsultarCli.Text = "Consultar";
            this.btnConsultarCli.UseVisualStyleBackColor = false;
            this.btnConsultarCli.Click += new System.EventHandler(this.btnConsultarCli_Click);
            // 
            // pError
            // 
            this.pError.ContainerControl = this;
            // 
            // crudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1285, 699);
            this.Controls.Add(this.btnConsultarCli);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.btnModificarCli);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrearCli);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCodigoTro);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "crudCliente";
            this.Text = "crudCliente";
            this.Load += new System.EventHandler(this.crudCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoTro;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnCrearCli;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnConsultarCli;
        private System.Windows.Forms.ErrorProvider pError;
    }
}