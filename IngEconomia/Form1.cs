using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngEconomia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrarTabla_Click(object sender, EventArgs e)
        {
            gestionarTabla();
        }
        private void gestionarTabla()
        {
            // limpiar tabla
            limpiar();

            int Periodos;
            float Tasa;
            String Tpago, Tamortizacion;

            Periodos = int.Parse(txtbTiempoAnual.Text);
            Tasa = float.Parse(txtbTasaAnual.Text);

            Tpago = cbTipoPago.Text;
            Tamortizacion = cbTipoAmortizacion.Text;

            // Tipo de Pago
            if (Tpago.Equals("Semestral"))
            {
                Periodos *= 2;
                Tasa /= 2;
            }
            else if (Tpago.Equals("Trimestral"))
            {
                Periodos *= 4;
                Tasa /= 4;
            }
            else if (Tpago.Equals("Mensual"))
            {
                Periodos *= 12;
                Tasa /= 12;
            }
            lblDatos.Text = "Tasa: " + Tasa.ToString() + "%, Periodos:  " + Periodos.ToString();

            // Tipo de Amortizacion
            if (Tamortizacion.Equals("Americana"))
            {
                tablaAmericana(Periodos, Tasa);
            }
            else if (Tamortizacion.Equals("Alemana"))
            {
                tablaAlemana(Periodos, Tasa);
            }
            else
            {
                tablaFrancesa(Periodos, Tasa);
            }
        }

        // ------------- Mostrar Tablas ------------
        private void tablaFrancesa(int Periodos, float Tasa)
        {
            int n;    // =
            float Prestamo = float.Parse(txtbPrestamo.Text);    // =
            float Cuota, Amortizacion, Interes, Residuo;    // =
            Residuo = Prestamo;    // =
            float SumaInteres = 0, SumaAmortizacion = 0;

            Cuota = Convert.ToSingle(Prestamo * Math.Pow(1 + Tasa / 100, Periodos) * Tasa / ((Math.Pow(1 + Tasa / 100, Periodos) - 1) * 100));
            for(int k = 1; k <= Periodos; k++)
            {
                n = dtgvTabla.Rows.Add();
                Interes = (Tasa / 100) * Residuo;
                Amortizacion = Cuota - Interes;

                SumaAmortizacion += Amortizacion;
                SumaInteres += Interes;
                Residuo -= Amortizacion;    // =
                cambiarFila(n, k.ToString(), Cuota.ToString("0.00"), Amortizacion.ToString("0.00"), Interes.ToString("0.00"), Residuo.ToString("0.00"));    // =
            }
            n = dtgvTabla.Rows.Add();
            cambiarFila(n, "Total", (SumaAmortizacion + SumaInteres).ToString("0.00"), SumaAmortizacion.ToString("0.00"), SumaInteres.ToString("0.00"), "");    // =
        }
        private void tablaAlemana(int Periodos, float Tasa)
        {
            int n;
            float Prestamo = float.Parse(txtbPrestamo.Text);
            float Cuota, Amortizacion, Interes, Residuo;
            Residuo = Prestamo;
            float SumaInteres = 0, SumaAmortizacion = 0;

            Amortizacion = Prestamo / Periodos;
            for (int k = 1; k <= Periodos; k++)
            {
                n = dtgvTabla.Rows.Add();
                Interes = Tasa * Amortizacion * (Periodos - k + 1) / 100;
                Cuota = Amortizacion + Interes;

                SumaAmortizacion += Amortizacion;
                SumaInteres += Interes;
                Residuo -= Amortizacion;
                cambiarFila(n, k.ToString(), Cuota.ToString("0.00"), Amortizacion.ToString("0.00"), Interes.ToString("0.00"), Residuo.ToString("0.00"));    // =
            }
            n = dtgvTabla.Rows.Add();
            cambiarFila(n, "Total", (SumaAmortizacion + SumaInteres).ToString("0.00"), SumaAmortizacion.ToString("0.00"), SumaInteres.ToString("0.00"), "");    // =
        }
        private void tablaAmericana(int Periodos, float Tasa)
        {
            int n;
            float Prestamo = float.Parse(txtbPrestamo.Text);
            float Cuota, Amortizacion, Interes, Residuo;
            Residuo = Prestamo;
            float SumaInteres = 0, SumaAmortizacion = 0;

            Interes = Prestamo * Tasa / 100;
            Cuota = Interes;
            Amortizacion = 0;
            for (int k = 1; k < Periodos; k++)
            {
                SumaAmortizacion += Amortizacion;
                SumaInteres += Interes;
                n = dtgvTabla.Rows.Add();
                cambiarFila(n, k.ToString(), Cuota.ToString("0.00"), Amortizacion.ToString("0.00"), Interes.ToString("0.00"), Residuo.ToString("0.00"));    // =
            }
            Cuota = Prestamo + Interes;
            Amortizacion = Prestamo;
            
            SumaAmortizacion += Amortizacion;
            SumaInteres += Interes;
            Residuo = Prestamo - Amortizacion;
            
            n = dtgvTabla.Rows.Add();
            cambiarFila(n, Periodos.ToString(), Cuota.ToString("0.00"), Amortizacion.ToString("0.00"), Interes.ToString("0.00"), Residuo.ToString("0.00"));    // =
            n = dtgvTabla.Rows.Add();
            cambiarFila(n, "Total", (SumaAmortizacion + SumaInteres).ToString("0.00"), SumaAmortizacion.ToString("0.00"), SumaInteres.ToString("0.00"), "");    // =
        }
        // --------------- Cambiar Filas --------------
        private void cambiarFila(int n, String k, String c, String a, String i, String r)
        {
            //float Prestamo = float.Parse(txtbPrestamo.Text);
            //float c, a, i, r;
            //Cuota = Convert.ToSingle(Prestamo * Math.Pow(1 + Tasa / 100, Periodos) * Tasa / (Math.Pow(1 + Tasa / 100, Periodos) - 1) * 100);
            //Residuo = Prestamo;
            // c = cuota();
            // a = amortizacion();
            // i = interes();
            // r = residuo();
            //for (int k = 1; k <= Periodos; k++)
            //{
            //    int n = dtgvTabla.Rows.Add();
            //    Interes = (Tasa / 100) * Residuo;
            //    Amortizacion = Cuota - Interes;
            //    cambiarFila(n, k, Cuota, Amortizacion, Interes, Residuo);
            //}
            dtgvTabla.Rows[n].Cells[0].Value = k;
            dtgvTabla.Rows[n].Cells[1].Value = c;
            dtgvTabla.Rows[n].Cells[2].Value = a;
            dtgvTabla.Rows[n].Cells[3].Value = i;
            dtgvTabla.Rows[n].Cells[4].Value = r;
        }
        // ---------------- Linmpiar Tabla ---------------
        private void limpiar()
        {
            dtgvTabla.Rows.Clear();
        }
    }
}
