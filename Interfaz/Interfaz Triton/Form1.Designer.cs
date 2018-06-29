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
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.AtletaTableAdapter();
            this.atleta_Info_BasicaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tritonDataSet.Namespace = "http://tempuri.org/TritonDataSet2.xsd";
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
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(883, 684);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Insertar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Location = new System.Drawing.Point(3, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 145);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Entrenamientos";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Rutina";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(92, 78);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 30;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(31, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Deporte";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(92, 52);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 28;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Codigo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(31, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nivel";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(92, 105);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(92, 26);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 32;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 155);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar Entrenamientos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(31, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nivel";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(31, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Rutina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(31, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Codigo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(31, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Deporte";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Location = new System.Drawing.Point(3, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 155);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insertar Entrenamientos";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(198, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Insertar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(31, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nivel";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(31, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Rutina";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(31, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Codigo";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(92, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(31, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Deporte";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(92, 52);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 28;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
    }
}

