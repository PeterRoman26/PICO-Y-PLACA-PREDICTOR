using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pico_y_Placa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            
           if(txtDia.Text!="" && !((Convert.ToInt16(txtDia.Text)<=31) && (Convert.ToInt16(txtDia.Text) >= 1)))
            {
                MessageBox.Show("El Numero de Día ingresado es incoherente (debe estar entre 1 y 31 días)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            if (txtMes.Text != "" && !((Convert.ToInt16(txtMes.Text) <= 12) && (Convert.ToInt16(txtMes.Text) >= 1)))
            {
                MessageBox.Show("El Numero de Mes ingresado es incoherente (debe estar entre 1 y 12 meses)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            if (txtAno.Text.Length>3&&!((Convert.ToInt16(txtAno.Text) <= Convert.ToInt16(DateTime.Now.Year)) && (Convert.ToInt16(txtAno.Text) >= 1930)))
            {
                MessageBox.Show("El Numero de Año ingresado es incoherente Año Máximo: "+ DateTime.Now.Year+" Año Minimo: 1930 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            if (txtHora.Text!=""&&!((Convert.ToInt16(txtHora.Text) <= 23) && (Convert.ToInt16(txtHora.Text) >= 0)))
            {
                MessageBox.Show("El Numero de horas ingresado es incoherente (debe estar entre 0 y 23 horas)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMinuto_TextChanged(object sender, EventArgs e)
        {
            if (txtMinuto.Text != "" && !((Convert.ToInt16(txtMinuto.Text) <= 59) && (Convert.ToInt16(txtMinuto.Text) >= 0)))
            {
                MessageBox.Show("El Numero de minutos ingresado es incoherente (debe estar entre 0 y 59 minutos)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesamiento p = new Procesamiento();
            int ultimoDigito = p.tomarUltimoDigito(txtPlaca);
            string dia = p.tomarDia(txtDia, txtMes, txtAno);
            int hora = Convert.ToInt16(txtHora.Text);
            int minutos = Convert.ToInt16(txtMinuto.Text);
            p.prediccion(dia, ultimoDigito, hora, minutos);


        }
    }
}
