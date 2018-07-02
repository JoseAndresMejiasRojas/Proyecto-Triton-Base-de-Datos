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
        private bool descuento;

        public Form1()
        {
            InitializeComponent();

            descuento = false;

            Label_Codigo_Descuento.Visible = false;
            Label_Fecha_Descuento.Visible = false;
            Label_Porcentaje_Descuento.Visible = false;

            Porcentaje_TB_Descuento.Visible = false;
            Vencimiento_Descuento_MTB_Conta.Visible = false;
            Codigo_TB_Descuento.Visible = false;

            Cantidad_Semanas_TB_Conta.Visible = false;
            Label_Cantidad_Semanas_Conta.Visible = false;
            Semanal_TB_Conta.Visible = false;
            Label_Monto_Semanal_Conta.Visible = false;

            Label_Monto_Mensual_Conta.Visible = false;
            Monto_Mensual_TB_Conta.Visible = false;
        }

		private void Atleta_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Atleta_Group_Box_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'tritonDataSet.Entrenamiento_Individual' table. You can move, or remove it, as needed.
            this.entrenamiento_IndividualTableAdapter.Fill(this.tritonDataSet.Entrenamiento_Individual);
            // TODO: This line of code loads data into the 'tritonDataSet.Cobro_Individual' table. You can move, or remove it, as needed.
            this.cobro_IndividualTableAdapter.Fill(this.tritonDataSet.Cobro_Individual);
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

			DataRow[] resultados_busqueda = tritonDataSet.Atleta.Select(filtro);    // Hago un SELECT acorde a la busqueda.

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
            Ganancias_Label.Visible = false;
            int mes = parseo_mes(Mes_Combo_Box.Text);   // Obtengo el mes en int.
            String anno = Anno_Combo_Box.Text;          // Obtengo el año.

            // Verifico los datos
            if( int.TryParse(anno, out int n) == true && mes != -1 ) // Si se digitó un número, todo bien.
            {

                // Conexión Triton.
                String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
                SqlConnection connection = new SqlConnection(connectionStr);
                SqlDataAdapter databaseAdapter = new SqlDataAdapter();

                // Ocupo la conexión abierta.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Hago el SELECT de la función para obtener ganancias.
                SqlCommand cmd = new SqlCommand("SELECT dbo.Obtener_Ganancias_Mes(" + mes.ToString() + "," + anno + ")", connection);

                // Obtengo las ganancias, es obligatorio hacer el cast.
                int ganancias = (int)(cmd.ExecuteScalar());

                Ganancias_Label.Text = "$" + ganancias;
                Ganancias_Label.Visible = true;

                // Cierro conexión.
                connection.Close();
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
                case "Enero":       return 1;
                case "Febrero":     return 2;
                case "Marzo":       return 3;
                case "Abril":       return 4;
                case "Mayo":        return 5;
                case "Junio":       return 6;
                case "Julio":       return 7;
                case "Agosto":      return 8;
                case "Setiembre":   return 9;
                case "Octubre":     return 10;
                case "Noviembre":   return 11;
                case "Diciembre":   return 12;
                default:            return -1;  //ERROR
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( Tipo_Cobro_CB_Conta.Text == "Mensual" )
            {
                Cantidad_Semanas_TB_Conta.Visible = false;
                Label_Cantidad_Semanas_Conta.Visible = false;
                Semanal_TB_Conta.Visible = false;
                Label_Monto_Semanal_Conta.Visible = false;

                Label_Monto_Mensual_Conta.Visible = true;
                Monto_Mensual_TB_Conta.Visible = true;
            }
            else
            {
                Cantidad_Semanas_TB_Conta.Visible = true;
                Label_Cantidad_Semanas_Conta.Visible = true;
                Semanal_TB_Conta.Visible = true;
                Label_Monto_Semanal_Conta.Visible = true;

                Label_Monto_Mensual_Conta.Visible = false;
                Monto_Mensual_TB_Conta.Visible = false;
            }
        }

        private void Anno_Combo_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descuento_Ganancias_Conta_CheckedChanged(object sender, EventArgs e)
        {
            if( descuento == false )   // Si se marca, hay descuento.
            {
                descuento = !descuento;

                Label_Codigo_Descuento.Visible = true;
                Label_Fecha_Descuento.Visible = true;
                Label_Porcentaje_Descuento.Visible = true;

                Porcentaje_TB_Descuento.Visible = true;
                Vencimiento_Descuento_MTB_Conta.Visible = true;
                Codigo_TB_Descuento.Visible = true;
            }
            else // No hay descuento.
            {
                descuento = !descuento;

                Label_Codigo_Descuento.Visible = false;
                Label_Fecha_Descuento.Visible = false;
                Label_Porcentaje_Descuento.Visible = false;

                Porcentaje_TB_Descuento.Visible = false;
                Vencimiento_Descuento_MTB_Conta.Visible = false;
                Codigo_TB_Descuento.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Insertar_Factura_Click(object sender, EventArgs e)
        {
            if (parseo_errores_conta() == false)    // So no hay errores.
            {
                try
                {
                    String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
                    SqlConnection connection = new SqlConnection(connectionStr);

                    SqlCommand cmd = new SqlCommand("Insert into Cobro (ID_Factura_PK,Codigo_Atleta_FK,Fecha_Pago,Fecha_Finalización,Número_Tarjeta,Fecha_Vencimiento,CVC,Codigo_Descuento, Duracion_Descuento,Porcentaje_Descuento ) values (@ID_Factura_PK,@Codigo_Atleta_FK,@Fecha_Pago,@Fecha_Finalización,@Número_Tarjeta,@Fecha_Vencimiento,@CVC,@Codigo_Descuento, @Duracion_Descuento,@Porcentaje_Descuento)", connection);
                    int id_factura = Convert.ToInt32(Codigo_Factura_TB_Conta.Text);
                    connection.Open();

                    // Obtengo el número del atleta acorde al correo.
                    DataRowView drv = (DataRowView)Correo_CB_Conta.SelectedItem;
                    String correo = drv["Correo"].ToString();
                    SqlCommand cmd2 = new SqlCommand("SELECT dbo.ObtenerCodigo(" + "'" + correo + "'" + ")", connection);
                    int codigoAtleta = (int)(cmd2.ExecuteScalar());

                    //Creo los Parametros
                    cmd.Parameters.Add("@ID_Factura_PK", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Codigo_Atleta_FK", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Fecha_Pago", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@Fecha_Finalización", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@Número_Tarjeta", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Fecha_Vencimiento", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@CVC", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Codigo_Descuento", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Duracion_Descuento", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@Porcentaje_Descuento", System.Data.SqlDbType.Int);

                    //Asigno los valores
                    cmd.Parameters["@Codigo_Atleta_FK"].Value = codigoAtleta;
                    cmd.Parameters["@ID_Factura_PK"].Value = id_factura;
                    cmd.Parameters["@Fecha_Pago"].Value = DateTime.Parse(Fecha_Pago_MTB_Conta.Text);
                    cmd.Parameters["@Fecha_Finalización"].Value = DateTime.Parse(Fecha_Finalizacion_MTB_Conta.Text);
                    cmd.Parameters["@Número_Tarjeta"].Value = Numero_Tarjeta_TB_Conta.Text;
                    cmd.Parameters["@Fecha_Vencimiento"].Value = DateTime.Parse(Fecha_Vencimiento_MTB_Conta.Text);
                    cmd.Parameters["@CVC"].Value = Convert.ToInt32(CVC_TB_Conta.Text);

                    if (descuento == true)
                    {
                        cmd.Parameters["@Codigo_Descuento"].Value = Convert.ToInt32(Codigo_TB_Descuento.Text);
                        cmd.Parameters["@Duracion_Descuento"].Value = DateTime.Parse(Vencimiento_Descuento_MTB_Conta.Text);
                        cmd.Parameters["@Porcentaje_Descuento"].Value = Convert.ToInt32(Porcentaje_TB_Descuento.Text);
                    }
                    else
                    {
                        cmd.Parameters["@Codigo_Descuento"].Value = DBNull.Value;
                        cmd.Parameters["@Duracion_Descuento"].Value = DBNull.Value;
                        cmd.Parameters["@Porcentaje_Descuento"].Value = DBNull.Value;
                    }

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    // Inserto el tipo de Cobro.
                    if (Tipo_Cobro_CB_Conta.Text == "Mensual")
                    {
                        insertar_cobro_mensual(id_factura, Convert.ToDecimal(Monto_Mensual_TB_Conta.Text));
                    }
                    else
                    {
                        insertar_cobro_individual(id_factura, Convert.ToDecimal(Semanal_TB_Conta.Text), Convert.ToInt32(Cantidad_Semanas_TB_Conta.Text));
                    }
                    MessageBox.Show("Se ha agregado la factura " + id_factura.ToString() + " al atleta " + correo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch( Exception exception )
                {
                    MessageBox.Show("Error al insertar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Retorna true si hay un error, false si todoe está bien.
        bool parseo_errores_conta()
        {
            bool error = false;
            if( Tipo_Cobro_CB_Conta.Text != "Mensual" && Tipo_Cobro_CB_Conta.Text != "Individual" )
            {
                error = true;
            }
            else if( int.TryParse(Codigo_Factura_TB_Conta.Text, out int n) == false )
            {
                error = true;
            }
            else if( String.IsNullOrEmpty(Numero_Tarjeta_TB_Conta.Text) == true )
            {
                error = true;
            }
            else if( String.IsNullOrEmpty(Fecha_Vencimiento_MTB_Conta.Text) )
            {
                error = true;
            }
            else if ( String.IsNullOrEmpty(Fecha_Pago_MTB_Conta.Text) )
            {
                error = true;
            }
            else if ( String.IsNullOrEmpty(Fecha_Finalizacion_MTB_Conta.Text) )
            {
                error = true;
            }
            else if (int.TryParse(CVC_TB_Conta.Text, out n) == false)
            {
                error = true;
            }
            else if( descuento == true )
            {
                if (String.IsNullOrEmpty(Vencimiento_Descuento_MTB_Conta.Text) == true)
                {
                    error = true;
                }
                else if (int.TryParse(Codigo_TB_Descuento.Text, out n) == false)
                {
                    error = true;
                }
                else if (int.TryParse(Porcentaje_TB_Descuento.Text, out n) == false)
                {
                    error = true;
                }
            }
            else if (Tipo_Cobro_CB_Conta.Text == "Mensual")
            {
                if( int.TryParse(Monto_Mensual_TB_Conta.Text, out n) == false )
                {
                    error = true;
                }
            }
            else if(Tipo_Cobro_CB_Conta.Text == "Individual")
            {
                if (int.TryParse(Semanal_TB_Conta.Text, out n) == false || int.TryParse(Cantidad_Semanas_TB_Conta.Text, out n) == false)
                {
                    error = true;
                }
            }


            if ( error == true )
            {
                MessageBox.Show("Error al insertar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return error;
        }

        private void Fecha_TB_Descuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertar_cobro_mensual( int factura, decimal monto_mensual )
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);

            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Insert into Cobro_Mensual (ID_Factura_FK,Monto_Mensual) values (@ID_Factura_FK,@Monto_Mensual)", connection);

            cmd.Parameters.Add("@ID_Factura_FK", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Monto_Mensual", System.Data.SqlDbType.Money);

            cmd.Parameters["@ID_Factura_FK"].Value = factura;
            cmd.Parameters["@Monto_Mensual"].Value = monto_mensual;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void insertar_cobro_individual(int factura, decimal monto_semanal, int cantidad_semanas)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);

            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Insert into Cobro_Individual (ID_Factura_FK,Monto_Semanal,Monto_Total,Cantidad_Semanas) values (@ID_Factura_FK,@Monto_Semanal,@Monto_Total,@Cantidad_Semanas)", connection);

            cmd.Parameters.Add("@ID_Factura_FK", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Monto_Semanal", System.Data.SqlDbType.Money);
            cmd.Parameters.Add("@Monto_Total", System.Data.SqlDbType.Money);
            cmd.Parameters.Add("@Cantidad_Semanas", System.Data.SqlDbType.Money);

            cmd.Parameters["@ID_Factura_FK"].Value = factura;
            cmd.Parameters["@Monto_Semanal"].Value = monto_semanal;
            cmd.Parameters["@Monto_Total"].Value = monto_semanal*cantidad_semanas;
            cmd.Parameters["@Cantidad_Semanas"].Value = cantidad_semanas;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Insertar_Click(object sender, EventArgs e)
        {
            if( int.TryParse(Codigo_TB.Text, out int n) == true )   // Si es numérico, todo bien.
            {
                try
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

                    cmd.Parameters["@Codigo"].Value = Convert.ToInt32(Codigo_TB.Text);
                    cmd.Parameters["@Deporte"].Value = Deporte_TB.Text;
                    cmd.Parameters["@Rutina"].Value = Rutina_TB.Text;
                    cmd.Parameters["@Nivel"].Value = Nivel_TB.Text;


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
                catch
                {
                    MessageBox.Show("Error al insertar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Solo puede haber números en código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Modificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Codigo_TB.Text, out int n) == true)   // Si es numérico, todo bien.
            {
                try
                {
                    String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
                    SqlConnection connection = new SqlConnection(connectionStr);


                    SqlDataAdapter databaseAdapter = new SqlDataAdapter();

                    //
                    String comando = "Update Entrenamiento_Individual set ";
                    bool hayValor = false;
                    bool hayCodigo = false;


                    if (!String.IsNullOrEmpty(Deporte_TB.Text))//------------------------------->Deporte
                    {
                        if (hayValor) //Calcula si hay que poner un OR
                        {
                            comando = comando + " , ";
                        }
                        comando = comando + "Deporte=@Deporte";
                        hayValor = true;
                    }
                    if (!String.IsNullOrEmpty(Rutina_TB.Text))//------------------------------->Rutina
                    {
                        if (hayValor) //Calcula si hay que poner un OR
                        {
                            comando = comando + " , ";
                        }
                        comando = comando + "Rutina=@Rutina";
                        hayValor = true;
                    }
                    if (!String.IsNullOrEmpty(Nivel_TB.Text))//------------------------------->niv
                    {
                        if (hayValor) //Calcula si hay que poner un OR
                        {
                            comando = comando + " , ";
                        }
                        comando = comando + "Nivel=@Nivel";
                        hayValor = true;
                    }
                    if (!String.IsNullOrEmpty(Codigo_TB.Text)) //------------------------------->Codigo
                    {
                        if (hayValor) //Calcula si hay que poner un OR
                        {
                            comando = comando + " where ";
                        }
                        comando = comando + "Codigo_Entrenamiento_PK =@Codigo";
                        hayValor = true;
                        hayCodigo = true;
                    }
                    if (String.IsNullOrEmpty(Codigo_TB.Text)) //------------------------------->Codigo
                    {
                        MessageBox.Show("Error, favor agregar el codigo de entrenamiento desea modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    SqlCommand cmd = new SqlCommand(comando, connection);

                    //Creo los Parametros
                    if (!String.IsNullOrEmpty(Codigo_TB.Text)) //------------------------------->Codigo
                    {
                        cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                        cmd.Parameters["@Codigo"].Value = Convert.ToInt32(Codigo_TB.Text);
                    }

                    if (!String.IsNullOrEmpty(Deporte_TB.Text))//------------------------------->Deporte
                    {
                        cmd.Parameters.Add("@Deporte", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@Deporte"].Value = Deporte_TB.Text;

                    }

                    if (!String.IsNullOrEmpty(Rutina_TB.Text))//------------------------------->Rutina
                    {
                        cmd.Parameters.Add("@Rutina", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@Rutina"].Value = Rutina_TB.Text;
                    }

                    if (!String.IsNullOrEmpty(Nivel_TB.Text))//------------------------------->Nivel
                    {
                        cmd.Parameters.Add("@Nivel", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@Nivel"].Value = Nivel_TB.Text;
                    }



                    connection.Open();
                    if (hayValor && hayCodigo)
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
                catch
                {
                    MessageBox.Show("Error al insertar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Solo puede haber números en código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Codigo_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Borrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Codigo_TB.Text, out int n) == true)   // Si es numérico, todo bien.
            {
                String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
                SqlConnection connection = new SqlConnection(connectionStr);


                SqlDataAdapter databaseAdapter = new SqlDataAdapter();

                //
                String comando = "delete from Entrenamiento_Individual where ";
                bool hayValor = false;
                if (!String.IsNullOrEmpty(Codigo_TB.Text)) //------------------------------->Codigo
                {
                    if (hayValor) //Calcula si hay que poner un OR
                    {
                        comando = comando + " AND ";
                    }
                    comando = comando + "Codigo_Entrenamiento_PK =@Codigo";
                    hayValor = true;
                }
                if (!String.IsNullOrEmpty(Deporte_TB.Text))//------------------------------->Deporte
                {
                    if (hayValor) //Calcula si hay que poner un OR
                    {
                        comando = comando + " AND ";
                    }
                    comando = comando + "Deporte=@Deporte";
                    hayValor = true;
                }
                if (!String.IsNullOrEmpty(Rutina_TB.Text))//------------------------------->Rutina
                {
                    if (hayValor) //Calcula si hay que poner un OR
                    {
                        comando = comando + " AND ";
                    }
                    comando = comando + "Rutina=@Rutina";
                    hayValor = true;
                }
                if (!String.IsNullOrEmpty(Nivel_TB.Text))//------------------------------->Nivel
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
                if (!String.IsNullOrEmpty(Codigo_TB.Text)) //------------------------------->Codigo
                {
                    cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Codigo"].Value = Convert.ToInt32(Codigo_TB.Text);
                }

                if (!String.IsNullOrEmpty(Deporte_TB.Text))//------------------------------->Deporte
                {
                    cmd.Parameters.Add("@Deporte", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@Deporte"].Value = Deporte_TB.Text;

                }

                if (!String.IsNullOrEmpty(Rutina_TB.Text))//------------------------------->Rutina
                {
                    cmd.Parameters.Add("@Rutina", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@Rutina"].Value = Rutina_TB.Text;
                }

                if (!String.IsNullOrEmpty(Nivel_TB.Text))//------------------------------->Nivel
                {
                    cmd.Parameters.Add("@Nivel", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@Nivel"].Value = Nivel_TB.Text;
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
            else
            {
                MessageBox.Show("Solo puede haber números en código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Insertar_Prueba_Fisica_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("Insert into Prueba_Fisica (Codigo_Atleta_FK, Fecha_Prueba_PK, Tipo_Prueba_PK, Resultados) values (@CodigoAtleta,@Fecha,@Tipo,@Resultados)", connection);

                DataRowView drv = (DataRowView)Atleta_CB_Prueba_Fisica.SelectedItem;
                String correoStr = drv["Correo"].ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT dbo.ObtenerCodigo(" + "'" + correoStr + "'" + ")", connection);

                cmd.Parameters.Add("@CodigoAtleta", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@Fecha", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@Tipo", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Resultados", System.Data.SqlDbType.VarChar);

                //Asigno los valores

                connection.Open();

                int codigoAtleta = (int)(cmd2.ExecuteScalar());

                String tipoStr = Tipo_Prueba_Fisica_TB.Text;
                String resultStr = Resultados_TB_Prueba_Fisica.Text;



                cmd.Parameters["@CodigoAtleta"].Value = codigoAtleta;
                cmd.Parameters["@Fecha"].Value = DateTime.Parse(maskedTextBox_fechaPruebaFisica.Text);
                cmd.Parameters["@Tipo"].Value = tipoStr;
                cmd.Parameters["@Resultados"].Value = resultStr;

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Ha insertado una prueba física al atleta " + correoStr, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarTextoPruebas();
            }
            catch (Exception exception)
            {
                exception.ToString();
                MessageBox.Show("Error al insertar prueba física", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void limpiarTextoPruebas()
        {
            Atleta_CB_Prueba_Fisica.SelectedIndex = -1;
            Resultados_TB_Prueba_Fisica.Clear();
            Tipo_Prueba_Fisica_TB.Clear();
            maskedTextBox_fechaPruebaFisica.Clear();
        }

        private void Todos_Atletas_Button_Click(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            SqlCommand cmd = connection.CreateCommand();
            DataSet dataset = new DataSet();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Atleta";

            databaseAdapter.SelectCommand = cmd;

            connection.Open();
            databaseAdapter.Fill(dataset);
            Atleta_Data_Grid_View.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void Fecha_Vencimiento_Tarjeta_TB_Conta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Fecha_Vencimiento_Tarjeta_TB_Conta_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Vencimiento_Descuento_MTB_Conta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Dia_CB_Prueba_Fisica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rutinas_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {

            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter databaseAdapter;
            SqlCommand cmd = connection.CreateCommand();
            DataSet dataset = new DataSet();
            DataTable dt = new DataTable();

            SqlCommand cmd2 = new SqlCommand("SELECT dbo.ObtenerCodigo(" + "'" + Correo_CB_Busquedas.Text + "'" + ")", connection);

            connection.Open();

            int codigoAtleta = (int)(cmd2.ExecuteScalar());

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT e.Rutina " +
                "FROM Atleta a JOIN Bloque_Entrenamiento b ON b.Codigo_Atleta_FK = a.Codigo_Atleta_PK " +
                "JOIN Compuesto c ON c.Codigo_Atleta_FK = b.Codigo_Atleta_FK " +
                "JOIN Entrenamiento_Individual e ON e.Codigo_Entrenamiento_PK = c.Codigo_Entrenamiento_FK " +
                "WHERE a.Codigo_Atleta_PK = "+ codigoAtleta;

            databaseAdapter = new SqlDataAdapter(cmd);
            databaseAdapter.Fill(dt);
            Varios_Data_Grid_View.DataSource = dt;

            connection.Close();
        }

        private void Etiqueta_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rutinas_Radio_Button_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button_verPruebasAtleta_Click(object sender, EventArgs e)
        {
            String connectionStr = Interfaz_Triton.Properties.Settings.Default.TritonConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter databaseAdapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();

            ///select pruebas fisicas
            ///
            SqlCommand cmd = new SqlCommand("SELECT P.Tipo_Prueba_PK AS 'Tipo prueba', P.Resultados AS 'Resultados', P.Fecha_Prueba_PK AS 'Fecha prueba' FROM Prueba_Fisica P, Atleta A WHERE A.Codigo_Atleta_PK = @CodigoAtleta AND A.Codigo_Atleta_PK = P.Codigo_Atleta_FK", connection);

            databaseAdapter.SelectCommand = cmd;

            ///obtener codigo atleta

            DataRowView drv = (DataRowView)Atleta_CB_Prueba_Fisica2.SelectedItem;
            String correoStr = drv["Correo"].ToString();

            SqlCommand cmd2 = new SqlCommand("SELECT dbo.ObtenerCodigo(" + "'" + correoStr + "'" + ")", connection);

            ///

            cmd.Parameters.Add("@CodigoAtleta", System.Data.SqlDbType.Int);

            connection.Open();

            int codigoAtleta = (int)(cmd2.ExecuteScalar());

            cmd.Parameters["@CodigoAtleta"].Value = codigoAtleta;


            databaseAdapter.SelectCommand = cmd;
            databaseAdapter.Fill(dataset);
            dataGridView_pruebasAtleta.DataSource = dataset.Tables[0];
            connection.Close();
        }
    }
}
