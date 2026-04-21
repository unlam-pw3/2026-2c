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
            grpLicencias = new GroupBox();
            label1 = new Label();
            txtTipoLicencia = new TextBox();
            lblTipoLicencia = new Label();
            grpEmpleados = new GroupBox();
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
            cbxDiasSolicitados = new ComboBox();
            grpLicencias.SuspendLayout();
            grpEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlicencias).BeginInit();
            SuspendLayout();
            // 
            // grpLicencias
            // 
            grpLicencias.Controls.Add(cbxDiasSolicitados);
            grpLicencias.Controls.Add(label1);
            grpLicencias.Controls.Add(txtTipoLicencia);
            grpLicencias.Controls.Add(lblTipoLicencia);
            grpLicencias.Location = new Point(24, 14);
            grpLicencias.Name = "grpLicencias";
            grpLicencias.Size = new Size(309, 119);
            grpLicencias.TabIndex = 0;
            grpLicencias.TabStop = false;
            grpLicencias.Text = "Licencias";
            grpLicencias.Enter += groupBox1_Enter;
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
            grpEmpleados.Controls.Add(cbxDepartamento);
            grpEmpleados.Controls.Add(lblDepa);
            grpEmpleados.Controls.Add(txtEmpleado);
            grpEmpleados.Controls.Add(lblEmpleado);
            grpEmpleados.Location = new Point(350, 14);
            grpEmpleados.Name = "grpEmpleados";
            grpEmpleados.Size = new Size(309, 119);
            grpEmpleados.TabIndex = 1;
            grpEmpleados.TabStop = false;
            grpEmpleados.Text = "Empleados";
            grpEmpleados.Enter += groupBox2_Enter;
            // 
            // cbxDepartamento
            // 
            cbxDepartamento.FormattingEnabled = true;
            cbxDepartamento.Items.AddRange(new object[] { "Marketing", "Sistemas", "Recursos Humanos" });
            cbxDepartamento.Location = new Point(113, 82);
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(165, 23);
            cbxDepartamento.TabIndex = 5;
            cbxDepartamento.SelectedIndexChanged += cbxDepartamento_SelectedIndexChanged;
            // 
            // lblDepa
            // 
            lblDepa.AutoSize = true;
            lblDepa.Location = new Point(10, 85);
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
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(24, 144);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(309, 42);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvlicencias
            // 
            dgvlicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlicencias.Columns.AddRange(new DataGridViewColumn[] { TipoLicencia, NombreEmpleado, Area, CantidadDeDias });
            dgvlicencias.Location = new Point(24, 200);
            dgvlicencias.Name = "dgvlicencias";
            dgvlicencias.Size = new Size(635, 189);
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
            btnConsultar.Location = new Point(339, 144);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(309, 42);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 423);
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
    }
}
