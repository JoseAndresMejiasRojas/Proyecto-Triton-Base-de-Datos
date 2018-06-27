namespace Interfaz_Triton
{
	partial class Form1
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
			this.Entrenamiento_Tab_Page = new System.Windows.Forms.TabControl();
			this.Atleta_Tab_Page = new System.Windows.Forms.TabPage();
			this.Bloques_Group_Box = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Datos_Group_Box = new System.Windows.Forms.GroupBox();
			this.Buscar_Atleta_Button = new System.Windows.Forms.Button();
			this.Nombre = new System.Windows.Forms.Label();
			this.Atleta_Text_Box = new System.Windows.Forms.TextBox();
			this.Entrenamientos_Tab_Page = new System.Windows.Forms.TabPage();
			this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tritonDataSet = new Interfaz_Triton.TritonDataSet();
			this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.atletaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.AtletaTableAdapter();
			this.Atleta_Data_Grid_View = new System.Windows.Forms.DataGridView();
			this.atletaInfoBasicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.atleta_Info_BasicaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Entrenamiento_Tab_Page.SuspendLayout();
			this.Atleta_Tab_Page.SuspendLayout();
			this.Bloques_Group_Box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Datos_Group_Box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Entrenamiento_Tab_Page
			// 
			this.Entrenamiento_Tab_Page.Controls.Add(this.Atleta_Tab_Page);
			this.Entrenamiento_Tab_Page.Controls.Add(this.Entrenamientos_Tab_Page);
			this.Entrenamiento_Tab_Page.Location = new System.Drawing.Point(0, 0);
			this.Entrenamiento_Tab_Page.Name = "Entrenamiento_Tab_Page";
			this.Entrenamiento_Tab_Page.SelectedIndex = 0;
			this.Entrenamiento_Tab_Page.Size = new System.Drawing.Size(891, 710);
			this.Entrenamiento_Tab_Page.TabIndex = 0;
			// 
			// Atleta_Tab_Page
			// 
			this.Atleta_Tab_Page.Controls.Add(this.Bloques_Group_Box);
			this.Atleta_Tab_Page.Controls.Add(this.Datos_Group_Box);
			this.Atleta_Tab_Page.Location = new System.Drawing.Point(4, 22);
			this.Atleta_Tab_Page.Name = "Atleta_Tab_Page";
			this.Atleta_Tab_Page.Padding = new System.Windows.Forms.Padding(3);
			this.Atleta_Tab_Page.Size = new System.Drawing.Size(883, 684);
			this.Atleta_Tab_Page.TabIndex = 0;
			this.Atleta_Tab_Page.Text = "Atleta";
			this.Atleta_Tab_Page.UseVisualStyleBackColor = true;
			this.Atleta_Tab_Page.Click += new System.EventHandler(this.Atleta_Tab_Page_Click);
			// 
			// Bloques_Group_Box
			// 
			this.Bloques_Group_Box.Controls.Add(this.label1);
			this.Bloques_Group_Box.Controls.Add(this.dataGridView1);
			this.Bloques_Group_Box.Location = new System.Drawing.Point(6, 141);
			this.Bloques_Group_Box.Name = "Bloques_Group_Box";
			this.Bloques_Group_Box.Size = new System.Drawing.Size(877, 348);
			this.Bloques_Group_Box.TabIndex = 1;
			this.Bloques_Group_Box.TabStop = false;
			this.Bloques_Group_Box.Text = "Bloques de entrenamiento";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(1, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Rutinas";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(871, 298);
			this.dataGridView1.TabIndex = 1;
			// 
			// Datos_Group_Box
			// 
			this.Datos_Group_Box.Controls.Add(this.Atleta_Data_Grid_View);
			this.Datos_Group_Box.Controls.Add(this.Buscar_Atleta_Button);
			this.Datos_Group_Box.Controls.Add(this.Nombre);
			this.Datos_Group_Box.Controls.Add(this.Atleta_Text_Box);
			this.Datos_Group_Box.Location = new System.Drawing.Point(6, 6);
			this.Datos_Group_Box.Name = "Datos_Group_Box";
			this.Datos_Group_Box.Size = new System.Drawing.Size(877, 129);
			this.Datos_Group_Box.TabIndex = 0;
			this.Datos_Group_Box.TabStop = false;
			this.Datos_Group_Box.Text = "Datos";
			this.Datos_Group_Box.Enter += new System.EventHandler(this.Atleta_Group_Box_Enter);
			// 
			// Buscar_Atleta_Button
			// 
			this.Buscar_Atleta_Button.Location = new System.Drawing.Point(154, 70);
			this.Buscar_Atleta_Button.Name = "Buscar_Atleta_Button";
			this.Buscar_Atleta_Button.Size = new System.Drawing.Size(106, 23);
			this.Buscar_Atleta_Button.TabIndex = 3;
			this.Buscar_Atleta_Button.Text = "Buscar atleta";
			this.Buscar_Atleta_Button.UseVisualStyleBackColor = true;
			this.Buscar_Atleta_Button.Click += new System.EventHandler(this.Buscar_Atleta_Button_Click);
			// 
			// Nombre
			// 
			this.Nombre.AutoSize = true;
			this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nombre.ForeColor = System.Drawing.Color.Black;
			this.Nombre.Location = new System.Drawing.Point(1, 16);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(93, 25);
			this.Nombre.TabIndex = 2;
			this.Nombre.Text = "Nombre";
			// 
			// Atleta_Text_Box
			// 
			this.Atleta_Text_Box.Location = new System.Drawing.Point(2, 44);
			this.Atleta_Text_Box.Name = "Atleta_Text_Box";
			this.Atleta_Text_Box.Size = new System.Drawing.Size(258, 20);
			this.Atleta_Text_Box.TabIndex = 1;
			this.Atleta_Text_Box.TextChanged += new System.EventHandler(this.Atleta_Text_Box_TextChanged);
			// 
			// Entrenamientos_Tab_Page
			// 
			this.Entrenamientos_Tab_Page.Location = new System.Drawing.Point(4, 22);
			this.Entrenamientos_Tab_Page.Name = "Entrenamientos_Tab_Page";
			this.Entrenamientos_Tab_Page.Padding = new System.Windows.Forms.Padding(3);
			this.Entrenamientos_Tab_Page.Size = new System.Drawing.Size(883, 684);
			this.Entrenamientos_Tab_Page.TabIndex = 1;
			this.Entrenamientos_Tab_Page.Text = "Entrenamientos";
			this.Entrenamientos_Tab_Page.UseVisualStyleBackColor = true;
			// 
			// atletaBindingSource1
			// 
			this.atletaBindingSource1.DataMember = "Atleta";
			this.atletaBindingSource1.DataSource = this.tritonDataSet;
			// 
			// tritonDataSet
			// 
			this.tritonDataSet.DataSetName = "TritonDataSet";
			this.tritonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// atletaBindingSource
			// 
			this.atletaBindingSource.DataMember = "Atleta";
			this.atletaBindingSource.DataSource = this.tritonDataSet;
			// 
			// atletaTableAdapter
			// 
			this.atletaTableAdapter.ClearBeforeFill = true;
			// 
			// Atleta_Data_Grid_View
			// 
			this.Atleta_Data_Grid_View.AllowUserToOrderColumns = true;
			this.Atleta_Data_Grid_View.AutoGenerateColumns = false;
			this.Atleta_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Atleta_Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.telefonosDataGridViewTextBoxColumn});
			this.Atleta_Data_Grid_View.DataSource = this.atletaInfoBasicaBindingSource;
			this.Atleta_Data_Grid_View.Location = new System.Drawing.Point(328, 16);
			this.Atleta_Data_Grid_View.Name = "Atleta_Data_Grid_View";
			this.Atleta_Data_Grid_View.Size = new System.Drawing.Size(543, 107);
			this.Atleta_Data_Grid_View.TabIndex = 4;
			// 
			// atletaInfoBasicaBindingSource
			// 
			this.atletaInfoBasicaBindingSource.DataMember = "Atleta_Info_Basica";
			this.atletaInfoBasicaBindingSource.DataSource = this.tritonDataSet;
			// 
			// atleta_Info_BasicaTableAdapter
			// 
			this.atleta_Info_BasicaTableAdapter.ClearBeforeFill = true;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			// 
			// apellido1DataGridViewTextBoxColumn
			// 
			this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
			this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1";
			this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
			// 
			// apellido2DataGridViewTextBoxColumn
			// 
			this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
			this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2";
			this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
			// 
			// fechaNacimientoDataGridViewTextBoxColumn
			// 
			this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
			this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento";
			this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
			// 
			// telefonosDataGridViewTextBoxColumn
			// 
			this.telefonosDataGridViewTextBoxColumn.DataPropertyName = "Telefonos";
			this.telefonosDataGridViewTextBoxColumn.HeaderText = "Telefonos";
			this.telefonosDataGridViewTextBoxColumn.Name = "telefonosDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 513);
			this.Controls.Add(this.Entrenamiento_Tab_Page);
			this.Name = "Form1";
			this.Text = "Triton";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Entrenamiento_Tab_Page.ResumeLayout(false);
			this.Atleta_Tab_Page.ResumeLayout(false);
			this.Bloques_Group_Box.ResumeLayout(false);
			this.Bloques_Group_Box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Datos_Group_Box.ResumeLayout(false);
			this.Datos_Group_Box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Entrenamiento_Tab_Page;
		private System.Windows.Forms.TabPage Atleta_Tab_Page;
		private System.Windows.Forms.GroupBox Datos_Group_Box;
		private System.Windows.Forms.TextBox Atleta_Text_Box;
		private System.Windows.Forms.Button Buscar_Atleta_Button;
		private System.Windows.Forms.Label Nombre;
		private TritonDataSet tritonDataSet;
		private System.Windows.Forms.BindingSource atletaBindingSource;
		private TritonDataSetTableAdapters.AtletaTableAdapter atletaTableAdapter;
		private System.Windows.Forms.GroupBox Bloques_Group_Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage Entrenamientos_Tab_Page;
		private System.Windows.Forms.BindingSource atletaBindingSource1;
		private System.Windows.Forms.DataGridView Atleta_Data_Grid_View;
		private System.Windows.Forms.BindingSource atletaInfoBasicaBindingSource;
		private TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter atleta_Info_BasicaTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonosDataGridViewTextBoxColumn;
	}
}

