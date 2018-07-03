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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.atletaInfoBasicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tritonDataSet = new Interfaz_Triton.TritonDataSet();
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.AtletaTableAdapter();
            this.atleta_Info_BasicaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter();
            this.cobroIndividualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobro_IndividualTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Cobro_IndividualTableAdapter();
            this.entrenamientoIndividualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrenamiento_IndividualTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.Entrenamiento_IndividualTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Atleta_CB_Prueba_Fisica2 = new System.Windows.Forms.ComboBox();
            this.button_verPruebasAtleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_pruebasAtleta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_fechaPruebaFisica = new System.Windows.Forms.MaskedTextBox();
            this.Button_Insertar_Prueba_Fisica = new System.Windows.Forms.Button();
            this.Resultados_TB_Prueba_Fisica = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Tipo_Prueba_Fisica_TB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Atleta_CB_Prueba_Fisica = new System.Windows.Forms.ComboBox();
            this.atletaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Vencimiento_Descuento_MTB_Conta = new System.Windows.Forms.MaskedTextBox();
            this.Fecha_Finalizacion_MTB_Conta = new System.Windows.Forms.MaskedTextBox();
            this.Fecha_Pago_MTB_Conta = new System.Windows.Forms.MaskedTextBox();
            this.Fecha_Vencimiento_MTB_Conta = new System.Windows.Forms.MaskedTextBox();
            this.Correo_CB_Conta = new System.Windows.Forms.ComboBox();
            this.Label_Monto_Semanal_Conta = new System.Windows.Forms.Label();
            this.Semanal_TB_Conta = new System.Windows.Forms.TextBox();
            this.Label_Cantidad_Semanas_Conta = new System.Windows.Forms.Label();
            this.Cantidad_Semanas_TB_Conta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Numero_Tarjeta_TB_Conta = new System.Windows.Forms.TextBox();
            this.Label_Monto_Mensual_Conta = new System.Windows.Forms.Label();
            this.Monto_Mensual_TB_Conta = new System.Windows.Forms.TextBox();
            this.Button_Insertar_Factura = new System.Windows.Forms.Button();
            this.Label_Codigo_Descuento = new System.Windows.Forms.Label();
            this.Porcentaje_TB_Descuento = new System.Windows.Forms.TextBox();
            this.Label_Porcentaje_Descuento = new System.Windows.Forms.Label();
            this.Codigo_TB_Descuento = new System.Windows.Forms.TextBox();
            this.Label_Fecha_Descuento = new System.Windows.Forms.Label();
            this.Descuento_Ganancias_Conta = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CVC_TB_Conta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Codigo_Factura_TB_Conta = new System.Windows.Forms.TextBox();
            this.Tipo_Cobro_CB_Conta = new System.Windows.Forms.ComboBox();
            this.Tipo_CB_Conta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Error_Label = new System.Windows.Forms.Label();
            this.Ganancias_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ganancias_Button = new System.Windows.Forms.Button();
            this.Anno_Combo_Box = new System.Windows.Forms.TextBox();
            this.Mes_Combo_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Entrenamientos_Tab_Page = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Button_Borrar = new System.Windows.Forms.Button();
            this.Button_Modificar = new System.Windows.Forms.Button();
            this.Button_Insertar = new System.Windows.Forms.Button();
            this.EntrenamientoDG = new System.Windows.Forms.DataGridView();
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_TB = new System.Windows.Forms.TextBox();
            this.Deporte_TB = new System.Windows.Forms.TextBox();
            this.Nivel_TB = new System.Windows.Forms.TextBox();
            this.Rutina_TB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Atleta_Tab_Page = new System.Windows.Forms.TabPage();
            this.Datos_Group_Box = new System.Windows.Forms.GroupBox();
            this.Correo_CB_Atleta = new System.Windows.Forms.ComboBox();
            this.atletaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.Varios_Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.Etiqueta_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Rutinas_Radio_Button = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Todos_Atletas_Button = new System.Windows.Forms.Button();
            this.Atleta_Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atletaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.Buscar_Atleta_Button = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Atleta_Text_Box = new System.Windows.Forms.TextBox();
            this.Ayuda = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atletaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroIndividualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrenamientoIndividualBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pruebasAtleta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Entrenamientos_Tab_Page.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoDG)).BeginInit();
            this.Atleta_Tab_Page.SuspendLayout();
            this.Datos_Group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Varios_Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).BeginInit();
            this.Ayuda.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource5)).BeginInit();
            this.SuspendLayout();
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
            // cobroIndividualBindingSource
            // 
            this.cobroIndividualBindingSource.DataMember = "Cobro_Individual";
            this.cobroIndividualBindingSource.DataSource = this.tritonDataSet;
            // 
            // cobro_IndividualTableAdapter
            // 
            this.cobro_IndividualTableAdapter.ClearBeforeFill = true;
            // 
            // entrenamientoIndividualBindingSource
            // 
            this.entrenamientoIndividualBindingSource.DataMember = "Entrenamiento_Individual";
            this.entrenamientoIndividualBindingSource.DataSource = this.tritonDataSet;
            // 
            // entrenamiento_IndividualTableAdapter
            // 
            this.entrenamiento_IndividualTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(883, 684);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Pruebas físicas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Atleta_CB_Prueba_Fisica2);
            this.groupBox6.Controls.Add(this.button_verPruebasAtleta);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.dataGridView_pruebasAtleta);
            this.groupBox6.Location = new System.Drawing.Point(398, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(477, 233);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detalles";
            // 
            // Atleta_CB_Prueba_Fisica2
            // 
            this.Atleta_CB_Prueba_Fisica2.DataSource = this.atletaBindingSource;
            this.Atleta_CB_Prueba_Fisica2.DisplayMember = "Correo";
            this.Atleta_CB_Prueba_Fisica2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Atleta_CB_Prueba_Fisica2.FormattingEnabled = true;
            this.Atleta_CB_Prueba_Fisica2.Location = new System.Drawing.Point(208, 42);
            this.Atleta_CB_Prueba_Fisica2.Name = "Atleta_CB_Prueba_Fisica2";
            this.Atleta_CB_Prueba_Fisica2.Size = new System.Drawing.Size(121, 21);
            this.Atleta_CB_Prueba_Fisica2.TabIndex = 14;
            // 
            // button_verPruebasAtleta
            // 
            this.button_verPruebasAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verPruebasAtleta.Location = new System.Drawing.Point(344, 41);
            this.button_verPruebasAtleta.Name = "button_verPruebasAtleta";
            this.button_verPruebasAtleta.Size = new System.Drawing.Size(80, 22);
            this.button_verPruebasAtleta.TabIndex = 5;
            this.button_verPruebasAtleta.Text = "Ver";
            this.button_verPruebasAtleta.UseVisualStyleBackColor = true;
            this.button_verPruebasAtleta.Click += new System.EventHandler(this.button_verPruebasAtleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalles de pruebas físicas por atleta";
            // 
            // dataGridView_pruebasAtleta
            // 
            this.dataGridView_pruebasAtleta.AllowUserToAddRows = false;
            this.dataGridView_pruebasAtleta.AllowUserToDeleteRows = false;
            this.dataGridView_pruebasAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pruebasAtleta.Location = new System.Drawing.Point(52, 70);
            this.dataGridView_pruebasAtleta.Name = "dataGridView_pruebasAtleta";
            this.dataGridView_pruebasAtleta.ReadOnly = true;
            this.dataGridView_pruebasAtleta.Size = new System.Drawing.Size(372, 155);
            this.dataGridView_pruebasAtleta.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(398, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 245);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pruebas";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(344, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(48, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(352, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "Número de pruebas físicas por atleta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(372, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maskedTextBox_fechaPruebaFisica);
            this.groupBox3.Controls.Add(this.Button_Insertar_Prueba_Fisica);
            this.groupBox3.Controls.Add(this.Resultados_TB_Prueba_Fisica);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.Tipo_Prueba_Fisica_TB);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.Atleta_CB_Prueba_Fisica);
            this.groupBox3.Location = new System.Drawing.Point(3, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 478);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar prueba física";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de prueba";
            // 
            // maskedTextBox_fechaPruebaFisica
            // 
            this.maskedTextBox_fechaPruebaFisica.Location = new System.Drawing.Point(29, 158);
            this.maskedTextBox_fechaPruebaFisica.Mask = "0000-00-00";
            this.maskedTextBox_fechaPruebaFisica.Name = "maskedTextBox_fechaPruebaFisica";
            this.maskedTextBox_fechaPruebaFisica.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_fechaPruebaFisica.TabIndex = 12;
            // 
            // Button_Insertar_Prueba_Fisica
            // 
            this.Button_Insertar_Prueba_Fisica.Location = new System.Drawing.Point(262, 410);
            this.Button_Insertar_Prueba_Fisica.Name = "Button_Insertar_Prueba_Fisica";
            this.Button_Insertar_Prueba_Fisica.Size = new System.Drawing.Size(75, 23);
            this.Button_Insertar_Prueba_Fisica.TabIndex = 11;
            this.Button_Insertar_Prueba_Fisica.Text = "Insertar";
            this.Button_Insertar_Prueba_Fisica.UseVisualStyleBackColor = true;
            this.Button_Insertar_Prueba_Fisica.Click += new System.EventHandler(this.Insertar_Prueba_Fisica_Click);
            // 
            // Resultados_TB_Prueba_Fisica
            // 
            this.Resultados_TB_Prueba_Fisica.Location = new System.Drawing.Point(29, 317);
            this.Resultados_TB_Prueba_Fisica.Multiline = true;
            this.Resultados_TB_Prueba_Fisica.Name = "Resultados_TB_Prueba_Fisica";
            this.Resultados_TB_Prueba_Fisica.Size = new System.Drawing.Size(308, 75);
            this.Resultados_TB_Prueba_Fisica.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(24, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 25);
            this.label22.TabIndex = 10;
            this.label22.Text = "Resultados";
            // 
            // Tipo_Prueba_Fisica_TB
            // 
            this.Tipo_Prueba_Fisica_TB.Location = new System.Drawing.Point(29, 225);
            this.Tipo_Prueba_Fisica_TB.Name = "Tipo_Prueba_Fisica_TB";
            this.Tipo_Prueba_Fisica_TB.Size = new System.Drawing.Size(133, 20);
            this.Tipo_Prueba_Fisica_TB.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(24, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(234, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "Tipo de prueba física";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Atleta";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Atleta_CB_Prueba_Fisica
            // 
            this.Atleta_CB_Prueba_Fisica.DataSource = this.atletaBindingSource1;
            this.Atleta_CB_Prueba_Fisica.DisplayMember = "Correo";
            this.Atleta_CB_Prueba_Fisica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Atleta_CB_Prueba_Fisica.FormattingEnabled = true;
            this.Atleta_CB_Prueba_Fisica.Location = new System.Drawing.Point(29, 80);
            this.Atleta_CB_Prueba_Fisica.Name = "Atleta_CB_Prueba_Fisica";
            this.Atleta_CB_Prueba_Fisica.Size = new System.Drawing.Size(121, 21);
            this.Atleta_CB_Prueba_Fisica.TabIndex = 0;
            // 
            // atletaBindingSource2
            // 
            this.atletaBindingSource2.DataMember = "Atleta";
            this.atletaBindingSource2.DataSource = this.tritonDataSet;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 684);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Contabilidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Vencimiento_Descuento_MTB_Conta);
            this.groupBox4.Controls.Add(this.Fecha_Finalizacion_MTB_Conta);
            this.groupBox4.Controls.Add(this.Fecha_Pago_MTB_Conta);
            this.groupBox4.Controls.Add(this.Fecha_Vencimiento_MTB_Conta);
            this.groupBox4.Controls.Add(this.Correo_CB_Conta);
            this.groupBox4.Controls.Add(this.Label_Monto_Semanal_Conta);
            this.groupBox4.Controls.Add(this.Semanal_TB_Conta);
            this.groupBox4.Controls.Add(this.Label_Cantidad_Semanas_Conta);
            this.groupBox4.Controls.Add(this.Cantidad_Semanas_TB_Conta);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Numero_Tarjeta_TB_Conta);
            this.groupBox4.Controls.Add(this.Label_Monto_Mensual_Conta);
            this.groupBox4.Controls.Add(this.Monto_Mensual_TB_Conta);
            this.groupBox4.Controls.Add(this.Button_Insertar_Factura);
            this.groupBox4.Controls.Add(this.Label_Codigo_Descuento);
            this.groupBox4.Controls.Add(this.Porcentaje_TB_Descuento);
            this.groupBox4.Controls.Add(this.Label_Porcentaje_Descuento);
            this.groupBox4.Controls.Add(this.Codigo_TB_Descuento);
            this.groupBox4.Controls.Add(this.Label_Fecha_Descuento);
            this.groupBox4.Controls.Add(this.Descuento_Ganancias_Conta);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.CVC_TB_Conta);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Codigo_Factura_TB_Conta);
            this.groupBox4.Controls.Add(this.Tipo_Cobro_CB_Conta);
            this.groupBox4.Controls.Add(this.Tipo_CB_Conta);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(3, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(880, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Facturación";
            // 
            // Vencimiento_Descuento_MTB_Conta
            // 
            this.Vencimiento_Descuento_MTB_Conta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Vencimiento_Descuento_MTB_Conta.Location = new System.Drawing.Point(718, 142);
            this.Vencimiento_Descuento_MTB_Conta.Mask = "0000-00-00";
            this.Vencimiento_Descuento_MTB_Conta.Name = "Vencimiento_Descuento_MTB_Conta";
            this.Vencimiento_Descuento_MTB_Conta.Size = new System.Drawing.Size(64, 20);
            this.Vencimiento_Descuento_MTB_Conta.TabIndex = 45;
            this.Vencimiento_Descuento_MTB_Conta.ValidatingType = typeof(System.DateTime);
            this.Vencimiento_Descuento_MTB_Conta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Vencimiento_Descuento_MTB_Conta_MaskInputRejected);
            // 
            // Fecha_Finalizacion_MTB_Conta
            // 
            this.Fecha_Finalizacion_MTB_Conta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Fecha_Finalizacion_MTB_Conta.Location = new System.Drawing.Point(408, 142);
            this.Fecha_Finalizacion_MTB_Conta.Mask = "0000-00-00";
            this.Fecha_Finalizacion_MTB_Conta.Name = "Fecha_Finalizacion_MTB_Conta";
            this.Fecha_Finalizacion_MTB_Conta.Size = new System.Drawing.Size(61, 20);
            this.Fecha_Finalizacion_MTB_Conta.TabIndex = 44;
            this.Fecha_Finalizacion_MTB_Conta.ValidatingType = typeof(System.DateTime);
            // 
            // Fecha_Pago_MTB_Conta
            // 
            this.Fecha_Pago_MTB_Conta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Fecha_Pago_MTB_Conta.Location = new System.Drawing.Point(310, 142);
            this.Fecha_Pago_MTB_Conta.Mask = "0000-00-00";
            this.Fecha_Pago_MTB_Conta.Name = "Fecha_Pago_MTB_Conta";
            this.Fecha_Pago_MTB_Conta.Size = new System.Drawing.Size(64, 20);
            this.Fecha_Pago_MTB_Conta.TabIndex = 43;
            this.Fecha_Pago_MTB_Conta.ValidatingType = typeof(System.DateTime);
            // 
            // Fecha_Vencimiento_MTB_Conta
            // 
            this.Fecha_Vencimiento_MTB_Conta.Location = new System.Drawing.Point(211, 142);
            this.Fecha_Vencimiento_MTB_Conta.Mask = "0000-00-00";
            this.Fecha_Vencimiento_MTB_Conta.Name = "Fecha_Vencimiento_MTB_Conta";
            this.Fecha_Vencimiento_MTB_Conta.Size = new System.Drawing.Size(66, 20);
            this.Fecha_Vencimiento_MTB_Conta.TabIndex = 42;
            this.Fecha_Vencimiento_MTB_Conta.ValidatingType = typeof(System.DateTime);
            // 
            // Correo_CB_Conta
            // 
            this.Correo_CB_Conta.DataSource = this.atletaBindingSource1;
            this.Correo_CB_Conta.DisplayMember = "Correo";
            this.Correo_CB_Conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Correo_CB_Conta.FormattingEnabled = true;
            this.Correo_CB_Conta.Location = new System.Drawing.Point(55, 61);
            this.Correo_CB_Conta.Name = "Correo_CB_Conta";
            this.Correo_CB_Conta.Size = new System.Drawing.Size(121, 21);
            this.Correo_CB_Conta.TabIndex = 41;
            // 
            // Label_Monto_Semanal_Conta
            // 
            this.Label_Monto_Semanal_Conta.AutoSize = true;
            this.Label_Monto_Semanal_Conta.Location = new System.Drawing.Point(523, 80);
            this.Label_Monto_Semanal_Conta.Name = "Label_Monto_Semanal_Conta";
            this.Label_Monto_Semanal_Conta.Size = new System.Drawing.Size(79, 13);
            this.Label_Monto_Semanal_Conta.TabIndex = 40;
            this.Label_Monto_Semanal_Conta.Text = "Monto semanal";
            // 
            // Semanal_TB_Conta
            // 
            this.Semanal_TB_Conta.Location = new System.Drawing.Point(424, 77);
            this.Semanal_TB_Conta.Name = "Semanal_TB_Conta";
            this.Semanal_TB_Conta.Size = new System.Drawing.Size(93, 20);
            this.Semanal_TB_Conta.TabIndex = 39;
            // 
            // Label_Cantidad_Semanas_Conta
            // 
            this.Label_Cantidad_Semanas_Conta.AutoSize = true;
            this.Label_Cantidad_Semanas_Conta.Location = new System.Drawing.Point(523, 45);
            this.Label_Cantidad_Semanas_Conta.Name = "Label_Cantidad_Semanas_Conta";
            this.Label_Cantidad_Semanas_Conta.Size = new System.Drawing.Size(109, 13);
            this.Label_Cantidad_Semanas_Conta.TabIndex = 38;
            this.Label_Cantidad_Semanas_Conta.Text = "Cantidad de semanas";
            // 
            // Cantidad_Semanas_TB_Conta
            // 
            this.Cantidad_Semanas_TB_Conta.Location = new System.Drawing.Point(424, 42);
            this.Cantidad_Semanas_TB_Conta.Name = "Cantidad_Semanas_TB_Conta";
            this.Cantidad_Semanas_TB_Conta.Size = new System.Drawing.Size(93, 20);
            this.Cantidad_Semanas_TB_Conta.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Vencimiento tarjeta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Número de tarjeta";
            // 
            // Numero_Tarjeta_TB_Conta
            // 
            this.Numero_Tarjeta_TB_Conta.Location = new System.Drawing.Point(103, 142);
            this.Numero_Tarjeta_TB_Conta.Name = "Numero_Tarjeta_TB_Conta";
            this.Numero_Tarjeta_TB_Conta.Size = new System.Drawing.Size(85, 20);
            this.Numero_Tarjeta_TB_Conta.TabIndex = 33;
            // 
            // Label_Monto_Mensual_Conta
            // 
            this.Label_Monto_Mensual_Conta.AutoSize = true;
            this.Label_Monto_Mensual_Conta.Location = new System.Drawing.Point(523, 65);
            this.Label_Monto_Mensual_Conta.Name = "Label_Monto_Mensual_Conta";
            this.Label_Monto_Mensual_Conta.Size = new System.Drawing.Size(79, 13);
            this.Label_Monto_Mensual_Conta.TabIndex = 32;
            this.Label_Monto_Mensual_Conta.Text = "Monto mensual";
            // 
            // Monto_Mensual_TB_Conta
            // 
            this.Monto_Mensual_TB_Conta.Location = new System.Drawing.Point(424, 61);
            this.Monto_Mensual_TB_Conta.Name = "Monto_Mensual_TB_Conta";
            this.Monto_Mensual_TB_Conta.Size = new System.Drawing.Size(93, 20);
            this.Monto_Mensual_TB_Conta.TabIndex = 31;
            // 
            // Button_Insertar_Factura
            // 
            this.Button_Insertar_Factura.Location = new System.Drawing.Point(396, 193);
            this.Button_Insertar_Factura.Name = "Button_Insertar_Factura";
            this.Button_Insertar_Factura.Size = new System.Drawing.Size(87, 23);
            this.Button_Insertar_Factura.TabIndex = 29;
            this.Button_Insertar_Factura.Text = "Insertar factura";
            this.Button_Insertar_Factura.UseVisualStyleBackColor = true;
            this.Button_Insertar_Factura.Click += new System.EventHandler(this.Button_Insertar_Factura_Click);
            // 
            // Label_Codigo_Descuento
            // 
            this.Label_Codigo_Descuento.AutoSize = true;
            this.Label_Codigo_Descuento.Location = new System.Drawing.Point(584, 126);
            this.Label_Codigo_Descuento.Name = "Label_Codigo_Descuento";
            this.Label_Codigo_Descuento.Size = new System.Drawing.Size(108, 13);
            this.Label_Codigo_Descuento.TabIndex = 28;
            this.Label_Codigo_Descuento.Text = "Código de descuento";
            // 
            // Porcentaje_TB_Descuento
            // 
            this.Porcentaje_TB_Descuento.Location = new System.Drawing.Point(817, 142);
            this.Porcentaje_TB_Descuento.Name = "Porcentaje_TB_Descuento";
            this.Porcentaje_TB_Descuento.Size = new System.Drawing.Size(55, 20);
            this.Porcentaje_TB_Descuento.TabIndex = 27;
            // 
            // Label_Porcentaje_Descuento
            // 
            this.Label_Porcentaje_Descuento.AutoSize = true;
            this.Label_Porcentaje_Descuento.Location = new System.Drawing.Point(816, 126);
            this.Label_Porcentaje_Descuento.Name = "Label_Porcentaje_Descuento";
            this.Label_Porcentaje_Descuento.Size = new System.Drawing.Size(58, 13);
            this.Label_Porcentaje_Descuento.TabIndex = 26;
            this.Label_Porcentaje_Descuento.Text = "Porcentaje";
            // 
            // Codigo_TB_Descuento
            // 
            this.Codigo_TB_Descuento.Location = new System.Drawing.Point(587, 142);
            this.Codigo_TB_Descuento.Name = "Codigo_TB_Descuento";
            this.Codigo_TB_Descuento.Size = new System.Drawing.Size(93, 20);
            this.Codigo_TB_Descuento.TabIndex = 25;
            // 
            // Label_Fecha_Descuento
            // 
            this.Label_Fecha_Descuento.AutoSize = true;
            this.Label_Fecha_Descuento.Location = new System.Drawing.Point(698, 126);
            this.Label_Fecha_Descuento.Name = "Label_Fecha_Descuento";
            this.Label_Fecha_Descuento.Size = new System.Drawing.Size(112, 13);
            this.Label_Fecha_Descuento.TabIndex = 24;
            this.Label_Fecha_Descuento.Text = "Fecha de vencimiento";
            // 
            // Descuento_Ganancias_Conta
            // 
            this.Descuento_Ganancias_Conta.AutoSize = true;
            this.Descuento_Ganancias_Conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento_Ganancias_Conta.Location = new System.Drawing.Point(690, 56);
            this.Descuento_Ganancias_Conta.Name = "Descuento_Ganancias_Conta";
            this.Descuento_Ganancias_Conta.Size = new System.Drawing.Size(129, 28);
            this.Descuento_Ganancias_Conta.TabIndex = 20;
            this.Descuento_Ganancias_Conta.Text = "Descuento";
            this.Descuento_Ganancias_Conta.UseVisualStyleBackColor = true;
            this.Descuento_Ganancias_Conta.CheckedChanged += new System.EventHandler(this.Descuento_Ganancias_Conta_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "CVC";
            // 
            // CVC_TB_Conta
            // 
            this.CVC_TB_Conta.Location = new System.Drawing.Point(500, 142);
            this.CVC_TB_Conta.Name = "CVC_TB_Conta";
            this.CVC_TB_Conta.Size = new System.Drawing.Size(55, 20);
            this.CVC_TB_Conta.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha de finalización";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha de pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código de factura";
            // 
            // Codigo_Factura_TB_Conta
            // 
            this.Codigo_Factura_TB_Conta.Location = new System.Drawing.Point(6, 142);
            this.Codigo_Factura_TB_Conta.Name = "Codigo_Factura_TB_Conta";
            this.Codigo_Factura_TB_Conta.Size = new System.Drawing.Size(85, 20);
            this.Codigo_Factura_TB_Conta.TabIndex = 12;
            // 
            // Tipo_Cobro_CB_Conta
            // 
            this.Tipo_Cobro_CB_Conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_Cobro_CB_Conta.FormattingEnabled = true;
            this.Tipo_Cobro_CB_Conta.Items.AddRange(new object[] {
            "Mensual",
            "Individual"});
            this.Tipo_Cobro_CB_Conta.Location = new System.Drawing.Point(281, 61);
            this.Tipo_Cobro_CB_Conta.Name = "Tipo_Cobro_CB_Conta";
            this.Tipo_Cobro_CB_Conta.Size = new System.Drawing.Size(121, 21);
            this.Tipo_Cobro_CB_Conta.TabIndex = 11;
            this.Tipo_Cobro_CB_Conta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Tipo_CB_Conta
            // 
            this.Tipo_CB_Conta.AutoSize = true;
            this.Tipo_CB_Conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo_CB_Conta.Location = new System.Drawing.Point(266, 36);
            this.Tipo_CB_Conta.Name = "Tipo_CB_Conta";
            this.Tipo_CB_Conta.Size = new System.Drawing.Size(157, 25);
            this.Tipo_CB_Conta.TabIndex = 10;
            this.Tipo_CB_Conta.Text = "Tipo de cobro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Error_Label);
            this.groupBox1.Controls.Add(this.Ganancias_Label);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Ganancias_Button);
            this.groupBox1.Controls.Add(this.Anno_Combo_Box);
            this.groupBox1.Controls.Add(this.Mes_Combo_Box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
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
            this.Error_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Label.Location = new System.Drawing.Point(586, 162);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(85, 33);
            this.Error_Label.TabIndex = 5;
            this.Error_Label.Text = "Error";
            this.Error_Label.Visible = false;
            // 
            // Ganancias_Label
            // 
            this.Ganancias_Label.AutoSize = true;
            this.Ganancias_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganancias_Label.Location = new System.Drawing.Point(586, 162);
            this.Ganancias_Label.Name = "Ganancias_Label";
            this.Ganancias_Label.Size = new System.Drawing.Size(99, 33);
            this.Ganancias_Label.TabIndex = 7;
            this.Ganancias_Label.Text = "label5";
            this.Ganancias_Label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(470, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ganancias";
            // 
            // Ganancias_Button
            // 
            this.Ganancias_Button.Location = new System.Drawing.Point(190, 130);
            this.Ganancias_Button.Name = "Ganancias_Button";
            this.Ganancias_Button.Size = new System.Drawing.Size(75, 23);
            this.Ganancias_Button.TabIndex = 4;
            this.Ganancias_Button.Text = "Buscar";
            this.Ganancias_Button.UseVisualStyleBackColor = true;
            this.Ganancias_Button.Click += new System.EventHandler(this.Ganancias_Button_Click);
            // 
            // Anno_Combo_Box
            // 
            this.Anno_Combo_Box.Location = new System.Drawing.Point(262, 81);
            this.Anno_Combo_Box.Name = "Anno_Combo_Box";
            this.Anno_Combo_Box.Size = new System.Drawing.Size(121, 20);
            this.Anno_Combo_Box.TabIndex = 3;
            this.Anno_Combo_Box.TextChanged += new System.EventHandler(this.Anno_Combo_Box_TextChanged);
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
            this.Mes_Combo_Box.Location = new System.Drawing.Point(85, 80);
            this.Mes_Combo_Box.Name = "Mes_Combo_Box";
            this.Mes_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Mes_Combo_Box.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mes";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // Entrenamientos_Tab_Page
            // 
            this.Entrenamientos_Tab_Page.Controls.Add(this.groupBox5);
            this.Entrenamientos_Tab_Page.Location = new System.Drawing.Point(4, 22);
            this.Entrenamientos_Tab_Page.Name = "Entrenamientos_Tab_Page";
            this.Entrenamientos_Tab_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Entrenamientos_Tab_Page.Size = new System.Drawing.Size(883, 684);
            this.Entrenamientos_Tab_Page.TabIndex = 1;
            this.Entrenamientos_Tab_Page.Text = "Entrenamientos";
            this.Entrenamientos_Tab_Page.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Button_Borrar);
            this.groupBox5.Controls.Add(this.Button_Modificar);
            this.groupBox5.Controls.Add(this.Button_Insertar);
            this.groupBox5.Controls.Add(this.EntrenamientoDG);
            this.groupBox5.Controls.Add(this.Codigo_TB);
            this.groupBox5.Controls.Add(this.Deporte_TB);
            this.groupBox5.Controls.Add(this.Nivel_TB);
            this.groupBox5.Controls.Add(this.Rutina_TB);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(872, 482);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // Button_Borrar
            // 
            this.Button_Borrar.Location = new System.Drawing.Point(287, 287);
            this.Button_Borrar.Name = "Button_Borrar";
            this.Button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.Button_Borrar.TabIndex = 11;
            this.Button_Borrar.Text = "Borrar";
            this.Button_Borrar.UseVisualStyleBackColor = true;
            this.Button_Borrar.Click += new System.EventHandler(this.Button_Borrar_Click);
            // 
            // Button_Modificar
            // 
            this.Button_Modificar.Location = new System.Drawing.Point(287, 221);
            this.Button_Modificar.Name = "Button_Modificar";
            this.Button_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Button_Modificar.TabIndex = 10;
            this.Button_Modificar.Text = "Modificar";
            this.Button_Modificar.UseVisualStyleBackColor = true;
            this.Button_Modificar.Click += new System.EventHandler(this.Button_Modificar_Click);
            // 
            // Button_Insertar
            // 
            this.Button_Insertar.Location = new System.Drawing.Point(287, 157);
            this.Button_Insertar.Name = "Button_Insertar";
            this.Button_Insertar.Size = new System.Drawing.Size(75, 23);
            this.Button_Insertar.TabIndex = 9;
            this.Button_Insertar.Text = "Insertar";
            this.Button_Insertar.UseVisualStyleBackColor = true;
            this.Button_Insertar.Click += new System.EventHandler(this.Button_Insertar_Click);
            // 
            // EntrenamientoDG
            // 
            this.EntrenamientoDG.AllowUserToAddRows = false;
            this.EntrenamientoDG.AllowUserToDeleteRows = false;
            this.EntrenamientoDG.AutoGenerateColumns = false;
            this.EntrenamientoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntrenamientoDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn,
            this.rutinaDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.EntrenamientoDG.DataSource = this.entrenamientoIndividualBindingSource;
            this.EntrenamientoDG.Location = new System.Drawing.Point(400, 116);
            this.EntrenamientoDG.Name = "EntrenamientoDG";
            this.EntrenamientoDG.ReadOnly = true;
            this.EntrenamientoDG.Size = new System.Drawing.Size(466, 222);
            this.EntrenamientoDG.TabIndex = 8;
            this.EntrenamientoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // codigoEntrenamientoPKDataGridViewTextBoxColumn
            // 
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Entrenamiento_PK";
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn.Name = "codigoEntrenamientoPKDataGridViewTextBoxColumn";
            this.codigoEntrenamientoPKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deporteDataGridViewTextBoxColumn
            // 
            this.deporteDataGridViewTextBoxColumn.DataPropertyName = "Deporte";
            this.deporteDataGridViewTextBoxColumn.HeaderText = "Deporte";
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutinaDataGridViewTextBoxColumn
            // 
            this.rutinaDataGridViewTextBoxColumn.DataPropertyName = "Rutina";
            this.rutinaDataGridViewTextBoxColumn.HeaderText = "Rutina";
            this.rutinaDataGridViewTextBoxColumn.Name = "rutinaDataGridViewTextBoxColumn";
            this.rutinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Codigo_TB
            // 
            this.Codigo_TB.Location = new System.Drawing.Point(124, 116);
            this.Codigo_TB.Name = "Codigo_TB";
            this.Codigo_TB.Size = new System.Drawing.Size(100, 20);
            this.Codigo_TB.TabIndex = 7;
            this.Codigo_TB.TextChanged += new System.EventHandler(this.Codigo_TB_TextChanged);
            // 
            // Deporte_TB
            // 
            this.Deporte_TB.Location = new System.Drawing.Point(124, 190);
            this.Deporte_TB.Name = "Deporte_TB";
            this.Deporte_TB.Size = new System.Drawing.Size(100, 20);
            this.Deporte_TB.TabIndex = 6;
            // 
            // Nivel_TB
            // 
            this.Nivel_TB.Location = new System.Drawing.Point(124, 325);
            this.Nivel_TB.Name = "Nivel_TB";
            this.Nivel_TB.Size = new System.Drawing.Size(100, 20);
            this.Nivel_TB.TabIndex = 5;
            // 
            // Rutina_TB
            // 
            this.Rutina_TB.Location = new System.Drawing.Point(124, 257);
            this.Rutina_TB.Name = "Rutina_TB";
            this.Rutina_TB.Size = new System.Drawing.Size(100, 20);
            this.Rutina_TB.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 24);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rutina";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Deporte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nivel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Código";
            // 
            // Atleta_Tab_Page
            // 
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
            // Datos_Group_Box
            // 
            this.Datos_Group_Box.Controls.Add(this.Correo_CB_Atleta);
            this.Datos_Group_Box.Controls.Add(this.Varios_Data_Grid_View);
            this.Datos_Group_Box.Controls.Add(this.Etiqueta_Radio_Button);
            this.Datos_Group_Box.Controls.Add(this.Rutinas_Radio_Button);
            this.Datos_Group_Box.Controls.Add(this.pictureBox1);
            this.Datos_Group_Box.Controls.Add(this.Todos_Atletas_Button);
            this.Datos_Group_Box.Controls.Add(this.Atleta_Data_Grid_View);
            this.Datos_Group_Box.Controls.Add(this.Buscar_Atleta_Button);
            this.Datos_Group_Box.Controls.Add(this.Nombre);
            this.Datos_Group_Box.Controls.Add(this.Atleta_Text_Box);
            this.Datos_Group_Box.Location = new System.Drawing.Point(6, 6);
            this.Datos_Group_Box.Name = "Datos_Group_Box";
            this.Datos_Group_Box.Size = new System.Drawing.Size(877, 485);
            this.Datos_Group_Box.TabIndex = 0;
            this.Datos_Group_Box.TabStop = false;
            this.Datos_Group_Box.Text = "Datos";
            this.Datos_Group_Box.Enter += new System.EventHandler(this.Atleta_Group_Box_Enter);
            // 
            // Correo_CB_Atleta
            // 
            this.Correo_CB_Atleta.DataSource = this.atletaBindingSource6;
            this.Correo_CB_Atleta.DisplayMember = "Correo";
            this.Correo_CB_Atleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Correo_CB_Atleta.FormattingEnabled = true;
            this.Correo_CB_Atleta.Location = new System.Drawing.Point(159, 296);
            this.Correo_CB_Atleta.Name = "Correo_CB_Atleta";
            this.Correo_CB_Atleta.Size = new System.Drawing.Size(121, 21);
            this.Correo_CB_Atleta.TabIndex = 9;
            // 
            // atletaBindingSource6
            // 
            this.atletaBindingSource6.DataMember = "Atleta";
            this.atletaBindingSource6.DataSource = this.tritonDataSet;
            // 
            // Varios_Data_Grid_View
            // 
            this.Varios_Data_Grid_View.AllowUserToAddRows = false;
            this.Varios_Data_Grid_View.AllowUserToDeleteRows = false;
            this.Varios_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Varios_Data_Grid_View.Location = new System.Drawing.Point(556, 234);
            this.Varios_Data_Grid_View.Name = "Varios_Data_Grid_View";
            this.Varios_Data_Grid_View.ReadOnly = true;
            this.Varios_Data_Grid_View.Size = new System.Drawing.Size(166, 142);
            this.Varios_Data_Grid_View.TabIndex = 8;
            // 
            // Etiqueta_Radio_Button
            // 
            this.Etiqueta_Radio_Button.AutoSize = true;
            this.Etiqueta_Radio_Button.Location = new System.Drawing.Point(396, 272);
            this.Etiqueta_Radio_Button.Name = "Etiqueta_Radio_Button";
            this.Etiqueta_Radio_Button.Size = new System.Drawing.Size(64, 17);
            this.Etiqueta_Radio_Button.TabIndex = 7;
            this.Etiqueta_Radio_Button.Text = "Etiqueta";
            this.Etiqueta_Radio_Button.UseVisualStyleBackColor = true;
            this.Etiqueta_Radio_Button.CheckedChanged += new System.EventHandler(this.Etiqueta_Radio_Button_CheckedChanged_2);
            this.Etiqueta_Radio_Button.Click += new System.EventHandler(this.Etiqueta_Radio_Button_CheckedChanged);
            // 
            // Rutinas_Radio_Button
            // 
            this.Rutinas_Radio_Button.AutoSize = true;
            this.Rutinas_Radio_Button.Checked = true;
            this.Rutinas_Radio_Button.Location = new System.Drawing.Point(396, 324);
            this.Rutinas_Radio_Button.Name = "Rutinas_Radio_Button";
            this.Rutinas_Radio_Button.Size = new System.Drawing.Size(61, 17);
            this.Rutinas_Radio_Button.TabIndex = 6;
            this.Rutinas_Radio_Button.TabStop = true;
            this.Rutinas_Radio_Button.Text = "Rutinas";
            this.Rutinas_Radio_Button.UseVisualStyleBackColor = true;
            this.Rutinas_Radio_Button.Click += new System.EventHandler(this.Rutinas_Radio_Button_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz_Triton.Properties.Resources.Logo_completo;
            this.pictureBox1.Location = new System.Drawing.Point(313, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Todos_Atletas_Button
            // 
            this.Todos_Atletas_Button.Location = new System.Drawing.Point(7, 127);
            this.Todos_Atletas_Button.Name = "Todos_Atletas_Button";
            this.Todos_Atletas_Button.Size = new System.Drawing.Size(106, 23);
            this.Todos_Atletas_Button.TabIndex = 5;
            this.Todos_Atletas_Button.Text = "Todos los atletas";
            this.Todos_Atletas_Button.UseVisualStyleBackColor = true;
            this.Todos_Atletas_Button.Click += new System.EventHandler(this.Todos_Atletas_Button_Click);
            // 
            // Atleta_Data_Grid_View
            // 
            this.Atleta_Data_Grid_View.AllowUserToAddRows = false;
            this.Atleta_Data_Grid_View.AllowUserToDeleteRows = false;
            this.Atleta_Data_Grid_View.AllowUserToOrderColumns = true;
            this.Atleta_Data_Grid_View.AutoGenerateColumns = false;
            this.Atleta_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Atleta_Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.telefonosDataGridViewTextBoxColumn});
            this.Atleta_Data_Grid_View.DataSource = this.atletaBindingSource4;
            this.Atleta_Data_Grid_View.Location = new System.Drawing.Point(279, 41);
            this.Atleta_Data_Grid_View.Name = "Atleta_Data_Grid_View";
            this.Atleta_Data_Grid_View.ReadOnly = true;
            this.Atleta_Data_Grid_View.Size = new System.Drawing.Size(595, 161);
            this.Atleta_Data_Grid_View.TabIndex = 4;
            this.Atleta_Data_Grid_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Atleta_Data_Grid_View_CellContentClick_1);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Primer apellido";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Segundo apellido";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            this.apellido2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonosDataGridViewTextBoxColumn
            // 
            this.telefonosDataGridViewTextBoxColumn.DataPropertyName = "Telefonos";
            this.telefonosDataGridViewTextBoxColumn.HeaderText = "Teléfonos";
            this.telefonosDataGridViewTextBoxColumn.Name = "telefonosDataGridViewTextBoxColumn";
            this.telefonosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atletaBindingSource4
            // 
            this.atletaBindingSource4.DataMember = "Atleta";
            this.atletaBindingSource4.DataSource = this.tritonDataSet;
            // 
            // Buscar_Atleta_Button
            // 
            this.Buscar_Atleta_Button.Location = new System.Drawing.Point(159, 127);
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
            this.Nombre.Location = new System.Drawing.Point(6, 73);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(93, 25);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Atleta_Text_Box
            // 
            this.Atleta_Text_Box.Location = new System.Drawing.Point(7, 101);
            this.Atleta_Text_Box.Name = "Atleta_Text_Box";
            this.Atleta_Text_Box.Size = new System.Drawing.Size(258, 20);
            this.Atleta_Text_Box.TabIndex = 1;
            this.Atleta_Text_Box.TextChanged += new System.EventHandler(this.Atleta_Text_Box_TextChanged);
            // 
            // Ayuda
            // 
            this.Ayuda.Controls.Add(this.Atleta_Tab_Page);
            this.Ayuda.Controls.Add(this.Entrenamientos_Tab_Page);
            this.Ayuda.Controls.Add(this.tabPage1);
            this.Ayuda.Controls.Add(this.tabPage2);
            this.Ayuda.Controls.Add(this.tabPage3);
            this.Ayuda.Location = new System.Drawing.Point(0, 0);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.SelectedIndex = 0;
            this.Ayuda.Size = new System.Drawing.Size(891, 710);
            this.Ayuda.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 684);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Ayuda";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(-4, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(887, 492);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // atletaBindingSource3
            // 
            this.atletaBindingSource3.DataMember = "Atleta";
            this.atletaBindingSource3.DataSource = this.tritonDataSet;
            // 
            // atletaBindingSource5
            // 
            this.atletaBindingSource5.DataMember = "Atleta";
            this.atletaBindingSource5.DataSource = this.tritonDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(891, 513);
            this.Controls.Add(this.Ayuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Triton";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atletaInfoBasicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroIndividualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrenamientoIndividualBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pruebasAtleta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Entrenamientos_Tab_Page.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoDG)).EndInit();
            this.Atleta_Tab_Page.ResumeLayout(false);
            this.Datos_Group_Box.ResumeLayout(false);
            this.Datos_Group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Varios_Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atleta_Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).EndInit();
            this.Ayuda.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource5)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private TritonDataSet tritonDataSet;
		private System.Windows.Forms.BindingSource atletaBindingSource;
		private TritonDataSetTableAdapters.AtletaTableAdapter atletaTableAdapter;
		private System.Windows.Forms.BindingSource atletaBindingSource1;
		private System.Windows.Forms.BindingSource atletaInfoBasicaBindingSource;
		private TritonDataSetTableAdapters.Atleta_Info_BasicaTableAdapter atleta_Info_BasicaTableAdapter;
        private System.Windows.Forms.BindingSource cobroIndividualBindingSource;
        private TritonDataSetTableAdapters.Cobro_IndividualTableAdapter cobro_IndividualTableAdapter;
        private System.Windows.Forms.BindingSource entrenamientoIndividualBindingSource;
        private TritonDataSetTableAdapters.Entrenamiento_IndividualTableAdapter entrenamiento_IndividualTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Atleta_CB_Prueba_Fisica;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Label_Monto_Semanal_Conta;
        private System.Windows.Forms.TextBox Semanal_TB_Conta;
        private System.Windows.Forms.Label Label_Cantidad_Semanas_Conta;
        private System.Windows.Forms.TextBox Cantidad_Semanas_TB_Conta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Numero_Tarjeta_TB_Conta;
        private System.Windows.Forms.Label Label_Monto_Mensual_Conta;
        private System.Windows.Forms.TextBox Monto_Mensual_TB_Conta;
        private System.Windows.Forms.Button Button_Insertar_Factura;
        private System.Windows.Forms.Label Label_Codigo_Descuento;
        private System.Windows.Forms.TextBox Porcentaje_TB_Descuento;
        private System.Windows.Forms.Label Label_Porcentaje_Descuento;
        private System.Windows.Forms.TextBox Codigo_TB_Descuento;
        private System.Windows.Forms.Label Label_Fecha_Descuento;
        private System.Windows.Forms.CheckBox Descuento_Ganancias_Conta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CVC_TB_Conta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Codigo_Factura_TB_Conta;
        private System.Windows.Forms.ComboBox Tipo_Cobro_CB_Conta;
        private System.Windows.Forms.Label Tipo_CB_Conta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Label Ganancias_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ganancias_Button;
        private System.Windows.Forms.TextBox Anno_Combo_Box;
        private System.Windows.Forms.ComboBox Mes_Combo_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Entrenamientos_Tab_Page;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Button_Borrar;
        private System.Windows.Forms.Button Button_Modificar;
        private System.Windows.Forms.Button Button_Insertar;
        private System.Windows.Forms.DataGridView EntrenamientoDG;
        private System.Windows.Forms.TextBox Deporte_TB;
        private System.Windows.Forms.TextBox Nivel_TB;
        private System.Windows.Forms.TextBox Rutina_TB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage Atleta_Tab_Page;
        private System.Windows.Forms.GroupBox Datos_Group_Box;
        private System.Windows.Forms.DataGridView Atleta_Data_Grid_View;
        private System.Windows.Forms.Button Buscar_Atleta_Button;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox Atleta_Text_Box;
        private System.Windows.Forms.TabControl Ayuda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource atletaBindingSource2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Resultados_TB_Prueba_Fisica;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Tipo_Prueba_Fisica_TB;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Button_Insertar_Prueba_Fisica;
        private System.Windows.Forms.ComboBox Correo_CB_Conta;
        private System.Windows.Forms.Button Todos_Atletas_Button;
        private System.Windows.Forms.BindingSource atletaBindingSource4;
        private System.Windows.Forms.BindingSource atletaBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEntrenamientoPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox Fecha_Vencimiento_MTB_Conta;
        private System.Windows.Forms.MaskedTextBox Fecha_Pago_MTB_Conta;
        private System.Windows.Forms.MaskedTextBox Fecha_Finalizacion_MTB_Conta;
        private System.Windows.Forms.MaskedTextBox Vencimiento_Descuento_MTB_Conta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fechaPruebaFisica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Codigo_TB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource atletaBindingSource5;
        private System.Windows.Forms.BindingSource atletaBindingSource6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox Atleta_CB_Prueba_Fisica2;
        private System.Windows.Forms.Button button_verPruebasAtleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_pruebasAtleta;
        private System.Windows.Forms.ComboBox Correo_CB_Atleta;
        private System.Windows.Forms.DataGridView Varios_Data_Grid_View;
        private System.Windows.Forms.RadioButton Etiqueta_Radio_Button;
        private System.Windows.Forms.RadioButton Rutinas_Radio_Button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

