using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Pico_y_Placa
{
    class Procesamiento
    {

        public int tomarUltimoDigito(TextBox txtPlaca)
        {
            int digito = 0;
            try
            {
                digito = Convert.ToInt16(txtPlaca.Text.Substring(txtPlaca.TextLength - 1, 1));
            }
            catch
            {
                MessageBox.Show("Los datos de la placa son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return digito;
        }

        public string tomarDia(TextBox txtDia, TextBox txtMes, TextBox txtAno)
        {
            string dia = "";
            try
            {
                DateTime fecha = new DateTime(Convert.ToInt16(txtAno.Text), Convert.ToInt16(txtMes.Text), Convert.ToInt16(txtDia.Text));
                return fecha.DayOfWeek.ToString();
            }
            catch
            {
                MessageBox.Show("La fecha ingresada tiene errores", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dia;
            }
        }

        public void prediccion(string day,int digito,int hora,int minutos)
        {
            string dia="";
            bool cuidado = false;
            if ((digito==1||digito==2))
            {
                if (day == "Monday")
                {
                    dia = "Lunes";
                    cuidado = true;
                }
                else
                {
                    dia = "";
                    cuidado = false;
                }
                
            }
            
            if(digito == 3 || digito == 4)
            {
                if (day == "Tuesday")
                {
                    dia = "Martes";
                    cuidado = true;
                }
                else
                {
                    dia = "";
                    cuidado = false;
                }
            }

            if (digito == 5 || digito == 6)
            {
                if(day == "Wednesday")
                {
                    dia = "Miercoles";
                    cuidado = true;
                }
                else
                {
                    dia = "";
                    cuidado = false;
                }
            }

            if ((digito == 7 || digito == 8))
            {
                if(day == "Thursday")
                {
                    dia = "Jueves";
                    cuidado = true;
                }
                else
                {
                    dia = "";
                    cuidado = false;
                }
            }

            if (digito == 9 || digito == 0 && day == "Friday")
            {
                dia = "Viernes";
                cuidado = true;
            }
            

            double horario = Convert.ToDouble(hora) + (Convert.ToDouble(minutos) / 60);

            if (((horario>=7 && horario<=9.5)|| (horario >= 16 && horario <= 19.5)) && cuidado)
            {
                MessageBox.Show("Usted Tiene Pico y Placa ( "+dia+" ), la hora ingresada esta dentro del rango de Prohibición, no utilice su Auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (!((horario >= 7 && horario <= 9.5) || (horario >= 16 && horario <= 19.5)) && cuidado)
            {
                MessageBox.Show("Usted Tiene Pico y Placa el día indicado, "+dia+" ,pero la hora indicada esta fuera del rango de prohibición", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            }
            else
            {
                MessageBox.Show("Usted no tiene Pico y Placa ", "CALMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
