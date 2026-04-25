namespace Clase2.FrontForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpLicencias = new GroupBox();
            btnCargarEmpleados = new Button();
            label4 = new Label();
            label1 = new Label();
            txtTipoLicencia = new TextBox();
            lblTipoLicencia = new Label();
            grpEmpleados = new GroupBox();
            btnRegistrarEmpleado = new Button();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            cbxDepartamento = new ComboBox();
            lblDepa = new Label();
            txtEmpleado = new TextBox();
            lblEmpleado = new Label();
            btnRegistrar = new Button();
            dgvlicencias = new DataGridView();
            TipoLicencia = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            CantidadDeDias = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            cbxEmpleados = new ComboBox();
            cbxDiasSolicitados = new ComboBox();
            grpLicencias.SuspendLayout();
            grpEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlicencias).BeginInit();
            SuspendLayout();
            // 
            // cbxDiasSolicitados
            // 
            cbxDiasSolicitados.FormattingEnabled = true;
            cbxDiasSolicitados.Items.AddRange(new object[] { "1 Dia", "7 Dias", "14 Dias", "21 Dias" });
            cbxDiasSolicitados.Location = new Point(153, 82);
            cbxDiasSolicitados.Name = "cbxDiasSolicitados";
            cbxDiasSolicitados.Size = new Size(125, 23);
            cbxDiasSolicitados.TabIndex = 3;
            // 
            // grpLicencias
            // 
            grpLicencias.Controls.Add(cbxEmpleados);
            grpLicencias.Controls.Add(btnCargarEmpleados);
            grpLicencias.Controls.Add(label4);
            grpLicencias.Controls.Add(cbxDiasSolicitados);
            grpLicencias.Controls.Add(label1);
            grpLicencias.Controls.Add(txtTipoLicencia);
            grpLicencias.Controls.Add(lblTipoLicencia);
            grpLicencias.Location = new Point(345, 22);
            grpLicencias.Name = "grpLicencias";
            grpLicencias.Size = new Size(309, 226);
            grpLicencias.TabIndex = 0;
            grpLicencias.TabStop = false;
            grpLicencias.Text = "Licencias";
            grpLicencias.Enter += groupBox1_Enter;
            // 
            // btnCargarEmpleados
            // 
            btnCargarEmpleados.Location = new Point(28, 176);
            btnCargarEmpleados.Name = "btnCargarEmpleados";
            btnCargarEmpleados.Size = new Size(237, 42);
            btnCargarEmpleados.TabIndex = 5;
            btnCargarEmpleados.Text = "Cargar Empleados";
            btnCargarEmpleados.UseVisualStyleBackColor = true;
            btnCargarEmpleados.Click += btnCargarEmpleados_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 118);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Empleado";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 85);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 2;
            label1.Text = "Cantidad Dia Solicitados";
            label1.Click += label1_Click;
            // 
            // txtTipoLicencia
            // 
            txtTipoLicencia.Location = new Point(10, 41);
            txtTipoLicencia.Name = "txtTipoLicencia";
            txtTipoLicencia.Size = new Size(268, 23);
            txtTipoLicencia.TabIndex = 1;
            txtTipoLicencia.TextChanged += txtTipoLicencia_TextChanged;
            // 
            // lblTipoLicencia
            // 
            lblTipoLicencia.AutoSize = true;
            lblTipoLicencia.Location = new Point(6, 23);
            lblTipoLicencia.Name = "lblTipoLicencia";
            lblTipoLicencia.Size = new Size(92, 15);
            lblTipoLicencia.TabIndex = 0;
            lblTipoLicencia.Text = "Tipo de Licencia";
            // 
            // grpEmpleados
            // 
            grpEmpleados.Controls.Add(btnRegistrarEmpleado);
            grpEmpleados.Controls.Add(txtCorreo);
            grpEmpleados.Controls.Add(label3);
            grpEmpleados.Controls.Add(txtDni);
            grpEmpleados.Controls.Add(label2);
            grpEmpleados.Controls.Add(cbxDepartamento);
            grpEmpleados.Controls.Add(lblDepa);
            grpEmpleados.Controls.Add(txtEmpleado);
            grpEmpleados.Controls.Add(lblEmpleado);
            grpEmpleados.Location = new Point(27, 22);
            grpEmpleados.Name = "grpEmpleados";
            grpEmpleados.Size = new Size(309, 278);
            grpEmpleados.TabIndex = 1;
            grpEmpleados.TabStop = false;
            grpEmpleados.Text = "Empleados";
            grpEmpleados.Enter += groupBox2_Enter;
            // 
            // btnRegistrarEmpleado
            // 
            btnRegistrarEmpleado.Location = new Point(40, 213);
            btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            btnRegistrarEmpleado.Size = new Size(206, 42);
            btnRegistrarEmpleado.TabIndex = 5;
            btnRegistrarEmpleado.Text = "Registrar Empleado";
            btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            btnRegistrarEmpleado.Click += btnRegistrarEmpleado_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(10, 136);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(268, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 118);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Correo";
            label3.Click += label3_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(10, 85);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(268, 23);
            txtDni.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "DNI";
            label2.Click += label2_Click;
            // 
            // cbxDepartamento
            // 
            cbxDepartamento.FormattingEnabled = true;
            cbxDepartamento.Items.AddRange(new object[] { "Marketing", "Sistemas", "Recursos Humanos" });
            cbxDepartamento.Location = new Point(113, 176);
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(165, 23);
            cbxDepartamento.TabIndex = 5;
            cbxDepartamento.SelectedIndexChanged += cbxDepartamento_SelectedIndexChanged;
            // 
            // lblDepa
            // 
            lblDepa.AutoSize = true;
            lblDepa.Location = new Point(10, 176);
            lblDepa.Name = "lblDepa";
            lblDepa.Size = new Size(83, 15);
            lblDepa.TabIndex = 4;
            lblDepa.Text = "Departamento";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(10, 41);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(268, 23);
            txtEmpleado.TabIndex = 3;
            txtEmpleado.TextChanged += textBox2_TextChanged;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(6, 23);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(107, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Nombre Empleado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(30, 310);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(309, 42);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar Licencia";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvlicencias
            // 
            dgvlicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlicencias.Columns.AddRange(new DataGridViewColumn[] { TipoLicencia, NombreEmpleado, Area, CantidadDeDias });
            dgvlicencias.Location = new Point(30, 366);
            dgvlicencias.Name = "dgvlicencias";
            dgvlicencias.Size = new Size(624, 189);
            dgvlicencias.TabIndex = 3;
            // 
            // TipoLicencia
            // 
            TipoLicencia.HeaderText = "Tipo Licencia";
            TipoLicencia.Name = "TipoLicencia";
            TipoLicencia.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.HeaderText = "Nombre Empleado";
            NombreEmpleado.Name = "NombreEmpleado";
            NombreEmpleado.Width = 280;
            // 
            // Area
            // 
            Area.HeaderText = "Area/Departamento";
            Area.Name = "Area";
            // 
            // CantidadDeDias
            // 
            CantidadDeDias.HeaderText = "Cantidad De Dias";
            CantidadDeDias.Name = "CantidadDeDias";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(345, 310);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(309, 42);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar Licencias";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // 
            // cbxEmpleados
            // 
            cbxEmpleados.FormattingEnabled = true;
            cbxEmpleados.Location = new Point(10, 136);
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(270, 23);
            cbxEmpleados.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 567);
            Controls.Add(btnConsultar);
            Controls.Add(dgvlicencias);
            Controls.Add(btnRegistrar);
            Controls.Add(grpEmpleados);
            Controls.Add(grpLicencias);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpLicencias.ResumeLayout(false);
            grpLicencias.PerformLayout();
            grpEmpleados.ResumeLayout(false);
            grpEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlicencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox grpLicencias;
        private GroupBox grpEmpleados;
        private TextBox txtTipoLicencia;
        private Label lblTipoLicencia;
        private TextBox txtEmpleado;
        private Label lblEmpleado;
        private Label label1;
        private ComboBox cbxDiasSolicitados;
        private ComboBox cbxDepartamento;
        private Label lblDepa;
        private Button btnRegistrar;
        private DataGridView dgvlicencias;
        private DataGridViewTextBoxColumn TipoLicencia;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn CantidadDeDias;
        private Button btnConsultar;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private Label label4;
        private Button btnRegistrarEmpleado;
        private Button btnCargarEmpleados;
        private ComboBox cbxEmpleados;
    }
}
