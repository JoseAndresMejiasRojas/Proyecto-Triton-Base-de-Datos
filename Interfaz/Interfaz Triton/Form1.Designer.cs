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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Bloques_Group_Box = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datos_Group_Box = new System.Windows.Forms.GroupBox();
            this.Atleta_Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atletaInfoBasicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tritonDataSet = new Interfaz_Triton.TritonDataSet();
            this.Buscar_Atleta_Button = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Atleta_Text_Box = new System.Windows.Forms.TextBox();
            this.Entrenamientos_Tab_Page = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Error_Label = new System.Windows.Forms.Label();
            this.Ganancias_Button = new System.Windows.Forms.Button();
            this.Anno_Combo_Box = new System.Windows.Forms.TextBox();
            this.Mes_Combo_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ganacias_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.AtletaTableAdapter();
            this.atleta_Info_BasicaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Entrenamiento_Tab_Page.SuspendLayout();
            this.Atleta_Tab_Page.SuspendLayout();
            this.Bloques_Group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Datos_Group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrenamiento_Tab_Page
            // 
            this.Entrenamiento_Tab_Page.Controls.Add(this.Atleta_Tab_Page);
            this.Entrenamiento_Tab_Page.Controls.Add(this.Entrenamientos_Tab_Page);
            this.Entrenamiento_Tab_Page.Controls.Add(this.tabPage1);
            this.Entrenamiento_Tab_Page.Controls.Add(this.tabPage2);
            this.Entrenamiento_Tab_Page.Location = new System.Drawing.Point(0, 0);
            this.Entrenamiento_Tab_Page.Name = "Entrenamiento_Tab_Page";
            this.Entrenamiento_Tab_Page.SelectedIndex = 0;
            this.Entrenamiento_Tab_Page.Size = new System.Drawing.Size(891, 710);
            this.Entrenamiento_Tab_Page.TabIndex = 0;
            // 
            // Atleta_Tab_Page
            // 
            this.Atleta_Tab_Page.Controls.Add(this.label3);
            this.Atleta_Tab_Page.Controls.Add(this.button1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obtener numero de pruebas fisica por atleta";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver pruebas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bloques_Group_Box
            // 
            this.Bloques_Group_Box.Controls.Add(this.label1);
            this.Bloques_Group_Box.Controls.Add(this.dataGridView1);
            this.Bloques_Group_Box.Location = new System.Drawing.Point(6, 195);
            this.Bloques_Group_Box.Name = "Bloques_Group_Box";
            this.Bloques_Group_Box.Size = new System.Drawing.Size(877, 294);
            this.Bloques_Group_Box.TabIndex = 1;
            this.Bloques_Group_Box.TabStop = false;
            this.Bloques_Group_Box.Text = "Bloques de entrenamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rutinas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Atleta_Data_Grid_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Atleta_Data_Grid_View_CellContentClick_1);
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
            // atletaInfoBasicaBindingSource
            // 
            this.atletaInfoBasicaBindingSource.DataMember = "Atleta_Info_Basica";
            this.atletaInfoBasicaBindingSource.DataSource = this.tritonDataSet;
            // 
            // tritonDataSet
            // 
            this.tritonDataSet.DataSetName = "TritonDataSet";
            this.tritonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 684);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Contabilidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Error_Label);
            this.groupBox1.Controls.Add(this.Ganancias_Button);
            this.groupBox1.Controls.Add(this.Anno_Combo_Box);
            this.groupBox1.Controls.Add(this.Mes_Combo_Box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Ganacias_Label);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ganancias";
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Label.Location = new System.Drawing.Point(139, 170);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(57, 24);
            this.Error_Label.TabIndex = 5;
            this.Error_Label.Text = "Error";
            this.Error_Label.Visible = false;
            // 
            // Ganancias_Button
            // 
            this.Ganancias_Button.Location = new System.Drawing.Point(131, 129);
            this.Ganancias_Button.Name = "Ganancias_Button";
            this.Ganancias_Button.Size = new System.Drawing.Size(75, 23);
            this.Ganancias_Button.TabIndex = 4;
            this.Ganancias_Button.Text = "Buscar";
            this.Ganancias_Button.UseVisualStyleBackColor = true;
            this.Ganancias_Button.Click += new System.EventHandler(this.Ganancias_Button_Click);
            // 
            // Anno_Combo_Box
            // 
            this.Anno_Combo_Box.Location = new System.Drawing.Point(199, 81);
            this.Anno_Combo_Box.Name = "Anno_Combo_Box";
            this.Anno_Combo_Box.Size = new System.Drawing.Size(121, 20);
            this.Anno_Combo_Box.TabIndex = 3;
            // 
            // Mes_Combo_Box
            // 
            this.Mes_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mes_Combo_Box.FormattingEnabled = true;
            this.Mes_Combo_Box.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Mes_Combo_Box.Location = new System.Drawing.Point(17, 81);
            this.Mes_Combo_Box.Name = "Mes_Combo_Box";
            this.Mes_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Mes_Combo_Box.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
            // 
            // Ganacias_Label
            // 
            this.Ganacias_Label.AutoSize = true;
            this.Ganacias_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganacias_Label.Location = new System.Drawing.Point(51, 54);
            this.Ganacias_Label.Name = "Ganacias_Label";
            this.Ganacias_Label.Size = new System.Drawing.Size(49, 24);
            this.Ganacias_Label.TabIndex = 1;
            this.Ganacias_Label.Text = "Mes";
            this.Ganacias_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(883, 684);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Atleta2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(436, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 478);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar atleta";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 478);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar atleta";
            // 
            // atletaBindingSource1
            // 
            this.atletaBindingSource1.DataMember = "Atleta";
            this.atletaBindingSource1.DataSource = this.tritonDataSet;
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
            // atleta_Info_BasicaTableAdapter
            // 
            this.atleta_Info_BasicaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.atletaBindingSource1;
            this.listBox1.DisplayMember = "Correo";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 69);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "Correo";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.Atleta_Tab_Page.PerformLayout();
            this.Bloques_Group_Box.ResumeLayout(false);
            this.Bloques_Group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Datos_Group_Box.ResumeLayout(false);
            this.Datos_Group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Ganacias_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Mes_Combo_Box;
        private System.Windows.Forms.TextBox Anno_Combo_Box;
        private System.Windows.Forms.Button Ganancias_Button;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

