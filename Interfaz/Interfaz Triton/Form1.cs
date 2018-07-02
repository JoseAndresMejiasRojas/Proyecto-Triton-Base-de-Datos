using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interfaz_Triton
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Atleta_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Atleta_Group_Box_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'tritonDataSet.Bloque_Entrenamiento' table. You can move, or remove it, as needed.
            this.bloque_EntrenamientoTableAdapter.Fill(this.tritonDataSet.Bloque_Entrenamiento);
            // TODO: This line of code loads data into the 'tritonDataSet.Etiqueta' table. You can move, or remove it, as needed.
            this.etiquetaTableAdapter.Fill(this.tritonDataSet.Etiqueta);
            // TODO: This line of code loads data into the 'tritonDataSet.Entrenamiento_Individual' table. You can move, or remove it, as needed.
            this.entrenamiento_IndividualTableAdapter.Fill(this.tritonDataSet.Entrenamiento_Individual);
            // TODO: This line of code loads data into the 'tritonDataSet.Atleta_Info_Basica' table. You can move, or remove it, as needed.
            this.atleta_Info_BasicaTableAdapter.Fill(this.tritonDataSet.Atleta_Info_Basica);
			// TODO: This line of code loads data into the 'tritonDataSet.Atleta' table. You can move, or remove it, as needed.
			this.atletaTableAdapter.Fill(this.tritonDataSet.Atleta);

		}

		private void Atleta_Tab_Page_Click(object sender, EventArgs e)
		{

		}

		private void Buscar_Atleta_Button_Click(object sender, EventArgs e)
		{
			String texto_busqueda_atleta = Atleta_Text_Box.Text;					// Obtengo el texto que se digitó.
			String filtro = "Nombre like '%" + texto_busqueda_atleta + "%' or Apellido1 like '%" +
							texto_busqueda_atleta + "%' or Apellido2 like '%" + texto_busqueda_atleta + "%'";

			DataRow[] resultados_busqueda = tritonDataSet.Atleta_Info_Basica.Select(filtro);	// Hago un SELECT acorde a la busqueda.  Ojo, es un VIEW.		
			Atleta_Data_Grid_View.DataSource = resultados_busqueda;
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ganancias_Button_Click(object sender, EventArgs e)
        {
            Error_Label.Visible = false;
            int mes = parseo_mes(Mes_Combo_Box.Text);   // Obtengo el mes en int.
            String anno = Anno_Combo_Box.Text;          // Obtengo el año.

            // Verifico los datos
            if( int.TryParse(anno, out int n) == true ) // Si se digitó un número, todo bien.
            {
                //SqlCommand Totalf = new SqlCommand("SELECT dbo.Tcupom(@code)", );
            }
            else
            {
                Error_Label.Visible = true;
            }
        }

        private int parseo_mes(String mes)
        {
            switch (mes)
            {
                case "Enero":       return 1; break;
                case "Febrero":     return 2; break;
                case "Marzo":       return 3; break;
                case "Abril":       return 4; break;
                case "Mayo":        return 5; break;
                case "Junio":       return 6; break;
                case "Julio":       return 7; break;
                case "Agosto":      return 8; break;
                case "Setiembre":   return 9; break;
                case "Octubre":     return 10; break;
                case "Noviembre":   return 11; break;
                case "Diciembre":   return 12; break;
                default:            return -1; break;   //ERROR
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = tritonDataSet.sp_cantidad_pruebas_fisicas;

        }

        private void Atleta_Data_Grid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cantidad_pruebas_fisicas";
            databaseAdapter.SelectCommand = cmd;
            DataSet dataset = new DataSet();
            //connection.Open();
            databaseAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            //dataGridView1.Update();
            //dataGridView1.Refresh();

        }

        private void Atleta_Data_Grid_View_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Insert into Atelta (Correo,Nombre,Apellido1,Inscripcion,Contraseña) values (@Correo,@Nombre,@Apellido,@Inscripcion,@Contraseña)");

            //Creo los Parametros
            cmd.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Inscripcion", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.Money);

            //Asigno los valores
            cmd.Parameters["@Correo"].Value = InsertCorreo.Text;
            cmd.Parameters["@Nombre"].Value = InsertNombre.Text;
            cmd.Parameters["@Apellido"].Value = InsertApellido.Text;
            cmd.Parameters["@Inscripcion"].Value = Decimal.Parse(InsertInscripcion.Text);
            cmd.Parameters["@Contraseña"].Value = InsertContraseña.Text;

            connection.Open();

            int RowsAffected = cmd.ExecuteNonQuery();

            connection.Close();*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);


            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Insert into Entrenamiento_Individual (Codigo_Entrenamiento_PK,Deporte,Rutina,Nivel) values (@Codigo,@Deporte,@Rutina,@Nivel)", connection);

            //Creo los Parametros
            cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Deporte", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Rutina", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Nivel", System.Data.SqlDbType.VarChar);

            //Asigno los valores

            cmd.Parameters["@Codigo"].Value =     Convert.ToInt32 (textBox15.Text);
            cmd.Parameters["@Deporte"].Value =    textBox12.Text;
            cmd.Parameters["@Rutina"].Value =     textBox11.Text;
            cmd.Parameters["@Nivel"].Value =      textBox14.Text;


            connection.Open();

            cmd.ExecuteNonQuery();

            //////////Actualiza Datos en Tabla///////////////////////////////
            DataTable dt = new DataTable();
            String querySelect = "SELECT * FROM Entrenamiento_Individual";
            SqlCommand cmd2 = new SqlCommand(querySelect, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd2);
            adap.Fill(dt);
            EntrenamientoDG.DataSource = dt;
            EntrenamientoDG.AutoResizeColumns();
            /////////////////////////////////////////////////////////////////

            connection.Close();

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);


            SqlDataAdapter databaseAdapter = new SqlDataAdapter();

            //
            String comando = "Update Entrenamiento_Individual set ";
            bool hayValor = false;
            if (!String.IsNullOrEmpty(BorrarDep.Text))//------------------------------->Deporte
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " , ";
                }
                comando = comando + "Deporte=@Deporte";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarRut.Text))//------------------------------->Rutina
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " , ";
                }
                comando = comando + "Rutina=@Rutina";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarNiv.Text))//------------------------------->niv
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " , ";
                }
                comando = comando + "Nivel=@Nivel";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarCod.Text)) //------------------------------->Codigo
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " where ";
                }
                comando = comando + "Codigo_Entrenamiento_PK =@Codigo";
                hayValor = true;
            }

            MessageBox.Show(comando);
            
            SqlCommand cmd = new SqlCommand(comando, connection);

            //Creo los Parametros
            if (!String.IsNullOrEmpty(BorrarCod.Text)) //------------------------------->Codigo
            {
                cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                cmd.Parameters["@Codigo"].Value = Convert.ToInt32(BorrarCod.Text);
            }

            if (!String.IsNullOrEmpty(BorrarDep.Text))//------------------------------->Deporte
            {
                cmd.Parameters.Add("@Deporte", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Deporte"].Value = BorrarDep.Text;

            }

            if (!String.IsNullOrEmpty(BorrarRut.Text))//------------------------------->Rutina
            {
                cmd.Parameters.Add("@Rutina", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Rutina"].Value = BorrarRut.Text;
            }

            if (!String.IsNullOrEmpty(BorrarNiv.Text))//------------------------------->Nivel
            {
                cmd.Parameters.Add("@Nivel", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Nivel"].Value = BorrarNiv.Text;
            }



            connection.Open();
            if (hayValor)
            {
                cmd.ExecuteNonQuery();
                //////////Actualiza Datos en Tabla///////////////////////////////
                DataTable dt = new DataTable();
                String querySelect = "SELECT * FROM Entrenamiento_Individual";
                SqlCommand cmd2 = new SqlCommand(querySelect, connection);
                SqlDataAdapter adap = new SqlDataAdapter(cmd2);
                adap.Fill(dt);
                EntrenamientoDG.DataSource = dt;
                /////////////////////////////////////////////////////////////////
            }

            connection.Close();
            ////////////////////////////////////////////////////////////////////////////////////////////////*/
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ModNivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);


            SqlDataAdapter databaseAdapter = new SqlDataAdapter();

            //
            String comando = "delete from Entrenamiento_Individual where ";
            bool hayValor= false;
            if (!String.IsNullOrEmpty(BorrarCod.Text)) //------------------------------->Codigo
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " AND ";
                }
                comando = comando + "Codigo_Entrenamiento_PK =@Codigo";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarDep.Text))//------------------------------->Deporte
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " AND ";
                }
                comando = comando + "Deporte=@Deporte";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarRut.Text))//------------------------------->Rutina
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " AND ";
                }
                comando = comando + "Rutina=@Rutina";
                hayValor = true;
            }
            if (!String.IsNullOrEmpty(BorrarNiv.Text))//------------------------------->Codigo
            {
                if (hayValor) //Calcula si hay que poner un OR
                {
                    comando = comando + " AND ";
                }
                comando = comando + "Nivel=@Nivel";
                hayValor = true;
            }
            
            SqlCommand cmd = new SqlCommand(comando, connection);

            //Creo los Parametros
            if (!String.IsNullOrEmpty(BorrarCod.Text)) //------------------------------->Codigo
            {
                cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                cmd.Parameters["@Codigo"].Value = Convert.ToInt32(BorrarCod.Text);
            }

            if (!String.IsNullOrEmpty(BorrarDep.Text))//------------------------------->Deporte
            {
                cmd.Parameters.Add("@Deporte", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Deporte"].Value = BorrarDep.Text;

            }

            if (!String.IsNullOrEmpty(BorrarRut.Text))//------------------------------->Rutina
            {
                cmd.Parameters.Add("@Rutina", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Rutina"].Value = BorrarRut.Text;
            }

            if (!String.IsNullOrEmpty(BorrarNiv.Text))//------------------------------->Nivel
            {
                cmd.Parameters.Add("@Nivel", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Nivel"].Value = BorrarNiv.Text;
            }



            connection.Open();
            if (hayValor)
            {
                cmd.ExecuteNonQuery();
                //////////Actualiza Datos en Tabla///////////////////////////////
                DataTable dt = new DataTable();
                String querySelect = "SELECT * FROM Entrenamiento_Individual";
                SqlCommand cmd2 = new SqlCommand(querySelect, connection);
                SqlDataAdapter adap = new SqlDataAdapter(cmd2);
                adap.Fill(dt);
                EntrenamientoDG.DataSource = dt;
                /////////////////////////////////////////////////////////////////
            }

            connection.Close();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
