using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.CustomControlItem;
using BusinessLayer;



namespace WindowsFormsApp2
{
    public partial class TxtCuotasMensual : Form
    {
        public TxtCuotasMensual()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtMonto.Text = "Ingrese el monto";
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            //ComboBox Tipo Prestamo 
            ComboBoxItem opcionPorDefecto = new ComboBoxItem();
            opcionPorDefecto.Text = "Seleccione una opcion";
            opcionPorDefecto.Value=null;

            ComboBoxItem PersonalOpcion = new ComboBoxItem();
            PersonalOpcion.Text = "Personal";
            PersonalOpcion.Value = 1;

            ComboBoxItem AutomovilOpcion = new ComboBoxItem();
            AutomovilOpcion.Text = "Automovil";
            AutomovilOpcion.Value = 2;

            ComboBoxItem HipotecarioOpcion = new ComboBoxItem();
            HipotecarioOpcion.Text = "Hipotecario";
            HipotecarioOpcion.Value = 3;

            CBxPrestamo.Items.Add(opcionPorDefecto);
            CBxPrestamo.Items.Add(PersonalOpcion);
            CBxPrestamo.Items.Add(AutomovilOpcion);
            CBxPrestamo.Items.Add(HipotecarioOpcion);
            CBxPrestamo.SelectedItem = opcionPorDefecto;

             

            //ComboBox Cantidad Meses
            
            ComboBoxItem opcionMes12 = new ComboBoxItem();
            opcionMes12.Text = "12";
            opcionMes12.Value = 1;

            ComboBoxItem opcionMes18 = new ComboBoxItem();
            opcionMes18.Text = "18";
            opcionMes18.Value = 2;

            ComboBoxItem opcionMes24 = new ComboBoxItem();
            opcionMes24.Text = "24";
            opcionMes24.Value = 3;

            ComboBoxItem opcionMes30 = new ComboBoxItem();
            opcionMes30.Text = "18";
            opcionMes30.Value = 4;

            ComboBoxItem opcionMes36 = new ComboBoxItem();
            opcionMes36.Text = "36";
            opcionMes36.Value = 6;

            ComboBoxItem opcionMes42 = new ComboBoxItem();
            opcionMes42.Text = "42";
            opcionMes42.Value = 7;

            ComboBoxItem opcionMes48 = new ComboBoxItem();
            opcionMes48.Text = "48";
            opcionMes48.Value = 8;

            ComboBoxItem opcionMes54 = new ComboBoxItem();
            opcionMes54.Text = "54";
            opcionMes54.Value = 9;

            ComboBoxItem opcionMes60 = new ComboBoxItem();
            opcionMes60.Text = "60";
            opcionMes60.Value = 10;

            ComboBoxItem opcionMes66 = new ComboBoxItem();
            opcionMes66.Text = "66";
            opcionMes66.Value = 11;

            ComboBoxItem opcionMes72 = new ComboBoxItem();
            opcionMes72.Text = "72";
            opcionMes72.Value = 12;

            ComboBoxItem opcionMes78 = new ComboBoxItem();
            opcionMes78.Text = "78";
            opcionMes78.Value = 13;

            ComboBoxItem opcionMes84 = new ComboBoxItem();
            opcionMes84.Text = "84";
            opcionMes84.Value = 14;

            ComboBoxItem opcionMes90 = new ComboBoxItem();
            opcionMes90.Text = "90";
            opcionMes90.Value = 15;

            ComboBoxItem opcionMes96 = new ComboBoxItem();
            opcionMes96.Text = "96";
            opcionMes96.Value = 16;

            ComboBoxItem opcionMes102 = new ComboBoxItem();
            opcionMes102.Text = "102";
            opcionMes102.Value = 17;

            ComboBoxItem opcionMes108 = new ComboBoxItem();
            opcionMes108.Text = "108";
            opcionMes108.Value = 18;

            ComboBoxItem opcionMes114 = new ComboBoxItem();
            opcionMes114.Text = "114";
            opcionMes114.Value = 2;

            ComboBoxItem opcionMes120 = new ComboBoxItem();
            opcionMes120.Text = "120";
            opcionMes120.Value = 2;

            CBxMeses.Items.Add(opcionPorDefecto);
            CBxMeses.Items.Add(opcionMes12);
            CBxMeses.Items.Add(opcionMes18);
            CBxMeses.Items.Add(opcionMes24);
            CBxMeses.Items.Add(opcionMes30);
            CBxMeses.Items.Add(opcionMes36);
            CBxMeses.Items.Add(opcionMes42);
            CBxMeses.Items.Add(opcionMes48);
            CBxMeses.Items.Add(opcionMes54);
            CBxMeses.Items.Add(opcionMes60);
            CBxMeses.Items.Add(opcionMes66);
            CBxMeses.Items.Add(opcionMes72);
            CBxMeses.Items.Add(opcionMes78);
            CBxMeses.Items.Add(opcionMes84);
            CBxMeses.Items.Add(opcionMes90);
            CBxMeses.Items.Add(opcionMes96);
            CBxMeses.Items.Add(opcionMes102);
            CBxMeses.Items.Add(opcionMes108);
            CBxMeses.Items.Add(opcionMes114);
            CBxMeses.Items.Add(opcionMes120);
            CBxMeses.SelectedItem = opcionPorDefecto;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LblTasaInteres_Click(object sender, EventArgs e)
        {

        }

        private void CBxPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtMonto_Click(object sender, EventArgs e)
        {
            if (TxtMonto.Text == "Ingrese el monto")
            {

                TxtMonto.Text = "";
            }
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCuotasMensual_Leave(object sender, EventArgs e)
        {

        }

        private void TxtMonto_Leave(object sender, EventArgs e)
        {
            if (TxtMonto.Text == "")
            {

                TxtMonto.Text = "Ingrese el monto";
            }
        }

        private void TxtInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMonto_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CBxPrestamo_MouseLeave(object sender, EventArgs e)
        {
            
           
        }

        private void CBxPrestamo_Leave(object sender, EventArgs e)
        {

        }

        private void CBxPrestamo_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxItem tipoPrestamo = CBxPrestamo.SelectedItem as ComboBoxItem;

            if (tipoPrestamo.Value !=null)
            {
                int valor = (int)tipoPrestamo.Value;

                switch (valor)
                {
                    case 1:
                        TxtInteres.Text = "22%";
                        break;
                    case 2:
                        TxtInteres.Text = "12%";
                        break;
                    case 3:
                        TxtInteres.Text = "8%";
                        break;
                }
                //MessageBox.Show(valor.ToString(), "tipo");
            }
        }

        private void LblCalcular_Click(object sender, EventArgs e)
        {
            selectOpcionCBx();
        }

        private void selectOpcionCBx()
        {

            try
            {
                ComboBoxItem seleccionarTipoPrestamo = CBxPrestamo.SelectedItem as ComboBoxItem;
                ComboBoxItem seleccionarCantMeses = CBxMeses.SelectedItem as ComboBoxItem;

                if (string.IsNullOrEmpty(TxtMonto.Text)|| (TxtMonto.Text == "Ingrese el monto"))
                {
                    MessageBox.Show("Debe ingresar un monto", "Advertencia");
                }
                else if (seleccionarTipoPrestamo.Value == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de prestamo", "Advertencia");
                }
                else if (seleccionarCantMeses.Value == null)
                {
                    MessageBox.Show("Debe seleccionar una cantidad de meses", "Advertencia");
                }
                else
                {
                    Calculador calculo = new Calculador(); 
                    int prestamo = (int)seleccionarTipoPrestamo.Value;
                    // int meses = (int)seleccionarCantMeses.Value;
                    int meses = Convert.ToInt32(seleccionarCantMeses.Text);
                    double monto = Convert.ToInt32(TxtMonto.Text);

                    double resultado = calculo.Calcular(monto, prestamo,meses);
                    resultado=Math.Round(resultado,2);
                    TxtCuota.Text ="$"+resultado.ToString();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Debe colocar un monto numerico","Advertencia");
            }
        }

        private void TxtCuota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
