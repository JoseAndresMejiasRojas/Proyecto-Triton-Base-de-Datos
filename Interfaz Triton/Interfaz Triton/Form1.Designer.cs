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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Atleta_Tab_Page = new System.Windows.Forms.TabPage();
			this.Datos_Group_Box = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Nombre = new System.Windows.Forms.Label();
			this.Atleta_Text_Box = new System.Windows.Forms.TextBox();
			this.Entrenamientos_Tab_Page = new System.Windows.Forms.TabPage();
			this.tritonDataSet = new Interfaz_Triton.TritonDataSet();
			this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.atletaTableAdapter = new Interfaz_Triton.TritonDataSetTableAdapters.AtletaTableAdapter();
			this.Bloques_Group_Box = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.Atleta_Tab_Page.SuspendLayout();
			this.Datos_Group_Box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
			this.Bloques_Group_Box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Entrenamientos_Tab_Page);
			this.tabControl1.Controls.Add(this.Atleta_Tab_Page);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1399, 710);
			this.tabControl1.TabIndex = 0;
			// 
			// Atleta_Tab_Page
			// 
			this.Atleta_Tab_Page.Controls.Add(this.Bloques_Group_Box);
			this.Atleta_Tab_Page.Controls.Add(this.Datos_Group_Box);
			this.Atleta_Tab_Page.Location = new System.Drawing.Point(4, 22);
			this.Atleta_Tab_Page.Name = "Atleta_Tab_Page";
			this.Atleta_Tab_Page.Padding = new System.Windows.Forms.Padding(3);
			this.Atleta_Tab_Page.Size = new System.Drawing.Size(1391, 684);
			this.Atleta_Tab_Page.TabIndex = 0;
			this.Atleta_Tab_Page.Text = "Atleta";
			this.Atleta_Tab_Page.UseVisualStyleBackColor = true;
			this.Atleta_Tab_Page.Click += new System.EventHandler(this.Atleta_Tab_Page_Click);
			// 
			// Datos_Group_Box
			// 
			this.Datos_Group_Box.Controls.Add(this.button1);
			this.Datos_Group_Box.Controls.Add(this.Nombre);
			this.Datos_Group_Box.Controls.Add(this.Atleta_Text_Box);
			this.Datos_Group_Box.Location = new System.Drawing.Point(6, 6);
			this.Datos_Group_Box.Name = "Datos_Group_Box";
			this.Datos_Group_Box.Size = new System.Drawing.Size(877, 315);
			this.Datos_Group_Box.TabIndex = 0;
			this.Datos_Group_Box.TabStop = false;
			this.Datos_Group_Box.Text = "Datos";
			this.Datos_Group_Box.Enter += new System.EventHandler(this.Atleta_Group_Box_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(132, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Buscar atleta";
			this.button1.UseVisualStyleBackColor = true;
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
			this.Atleta_Text_Box.Size = new System.Drawing.Size(231, 20);
			this.Atleta_Text_Box.TabIndex = 1;
			this.Atleta_Text_Box.TextChanged += new System.EventHandler(this.Atleta_Text_Box_TextChanged);
			// 
			// Entrenamientos_Tab_Page
			// 
			this.Entrenamientos_Tab_Page.Location = new System.Drawing.Point(4, 22);
			this.Entrenamientos_Tab_Page.Name = "Entrenamientos_Tab_Page";
			this.Entrenamientos_Tab_Page.Padding = new System.Windows.Forms.Padding(3);
			this.Entrenamientos_Tab_Page.Size = new System.Drawing.Size(812, 608);
			this.Entrenamientos_Tab_Page.TabIndex = 1;
			this.Entrenamientos_Tab_Page.Text = "Entrenamientos";
			this.Entrenamientos_Tab_Page.UseVisualStyleBackColor = true;
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
			// Bloques_Group_Box
			// 
			this.Bloques_Group_Box.Controls.Add(this.label1);
			this.Bloques_Group_Box.Controls.Add(this.dataGridView1);
			this.Bloques_Group_Box.Location = new System.Drawing.Point(6, 327);
			this.Bloques_Group_Box.Name = "Bloques_Group_Box";
			this.Bloques_Group_Box.Size = new System.Drawing.Size(877, 351);
			this.Bloques_Group_Box.TabIndex = 1;
			this.Bloques_Group_Box.TabStop = false;
			this.Bloques_Group_Box.Text = "Bloques de entrenamiento";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(865, 292);
			this.dataGridView1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(1, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Rutinas";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 712);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Triton";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.Atleta_Tab_Page.ResumeLayout(false);
			this.Datos_Group_Box.ResumeLayout(false);
			this.Datos_Group_Box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tritonDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
			this.Bloques_Group_Box.ResumeLayout(false);
			this.Bloques_Group_Box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Atleta_Tab_Page;
		private System.Windows.Forms.TabPage Entrenamientos_Tab_Page;
		private System.Windows.Forms.GroupBox Datos_Group_Box;
		private System.Windows.Forms.TextBox Atleta_Text_Box;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Nombre;
		private TritonDataSet tritonDataSet;
		private System.Windows.Forms.BindingSource atletaBindingSource;
		private TritonDataSetTableAdapters.AtletaTableAdapter atletaTableAdapter;
		private System.Windows.Forms.GroupBox Bloques_Group_Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

