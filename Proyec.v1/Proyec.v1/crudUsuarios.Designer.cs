namespace Proyec.v1
{
    partial class crudUsuarios
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
            this.txCedula = new System.Windows.Forms.TextBox();
            this.txNombreCompleto = new System.Windows.Forms.TextBox();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.bntCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dateMotificacion = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbdate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.ComboBox();
            this.pError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(199, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(125, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Modificacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(125, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(125, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Completo:";
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(311, 96);
            this.txCedula.Name = "txCedula";
            this.txCedula.Size = new System.Drawing.Size(401, 22);
            this.txCedula.TabIndex = 1;
            // 
            // txNombreCompleto
            // 
            this.txNombreCompleto.Location = new System.Drawing.Point(311, 145);
            this.txNombreCompleto.Name = "txNombreCompleto";
            this.txNombreCompleto.Size = new System.Drawing.Size(401, 22);
            this.txNombreCompleto.TabIndex = 2;
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToOrderColumns = true;
            this.dtgUsuario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(89, 354);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            this.dtgUsuario.RowHeadersWidth = 51;
            this.dtgUsuario.RowTemplate.Height = 24;
            this.dtgUsuario.Size = new System.Drawing.Size(1000, 299);
            this.dtgUsuario.TabIndex = 10;
            // 
            // bntCrear
            // 
            this.bntCrear.BackColor = System.Drawing.Color.Navy;
            this.bntCrear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.bntCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntCrear.Location = new System.Drawing.Point(311, 309);
            this.bntCrear.Name = "bntCrear";
            this.bntCrear.Size = new System.Drawing.Size(75, 39);
            this.bntCrear.TabIndex = 6;
            this.bntCrear.Text = "Crear";
            this.bntCrear.UseVisualStyleBackColor = false;
            this.bntCrear.Click += new System.EventHandler(this.bntCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(508, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Navy;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(392, 309);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 39);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dateMotificacion
            // 
            this.dateMotificacion.CustomFormat = "yyyy-MM-dd";
            this.dateMotificacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMotificacion.Location = new System.Drawing.Point(311, 229);
            this.dateMotificacion.Name = "dateMotificacion";
            this.dateMotificacion.Size = new System.Drawing.Size(401, 27);
            this.dateMotificacion.TabIndex = 4;
            this.dateMotificacion.Value = new System.DateTime(2020, 4, 10, 3, 19, 11, 0);
 
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Navy;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(612, 309);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 39);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(751, 132);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(0, 17);
            this.lbdate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 17;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(311, 270);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(401, 22);
            this.txtClave.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(125, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Clave:";
            // 
            // txtRol
            // 
            this.txtRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRol.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(311, 191);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(401, 30);
            this.txtRol.TabIndex = 3;
            // 
            // pError
            // 
            this.pError.ContainerControl = this;
            // 
            // crudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1293, 665);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dateMotificacion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bntCrear);
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.txNombreCompleto);
            this.Controls.Add(this.txCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "crudUsuarios";
            this.Text = "crudUsuario";
            this.Load += new System.EventHandler(this.crudUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
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
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.TextBox txNombreCompleto;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Button bntCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dateMotificacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtRol;
        private System.Windows.Forms.ErrorProvider pError;
    }
}