using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonaFranca
{
    public class Validaciones : Form
    {
        public Validaciones()
        {

        }

        // VALIDACION QUE VERIFICA SI LOS DATOS INGRESADOS EN UN TEXTBOX SON SOLO NUMEROS
        public void ValidarNro(TextBox entry)
        {
            string cadena = entry.Text;
            for(int i=0; i < cadena.Length; i++)
            {
                if (char.IsDigit(cadena[i]))
                {
                    // TODO EN ORDEN
                }
                else
                {
                    entry.Text = cadena.Remove(cadena.Length - 1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }

        // VALIDACION QUE VERIFICA SI TODOS LOS DATOS INGRESADOS SON NUMEROS O PUNTO O COMA
        // YA QUE SERA VALIDADO TEXTBOXES QUE ACEPTEN COMO ENTRADA NUMEROS DOUBLES
        public void ValidarNroDecimal(TextBox entry)
        {
            string cadena = entry.Text;
            int cont = 0;
            for(int i=0;i<cadena.Length; i++)
            {
                if(char.IsDigit(cadena[i]) || cadena[i]==',' || cadena[i] == '.')
                {
                    // SI EL CONTADOR DE COMA ES MAYOR QUE CERO, ESTO IMPLICA QUE YA HAY UNA COMA EN
                    // EL NUMERO
                    if(cadena[i]=='.' || cadena[i] == ',')
                    {
                        if (cont > 0)
                        {
                            entry.Text = cadena.Remove(cadena.Length - 1);
                            entry.SelectionStart = cadena.Length;
                        }
                        else if (cadena[i] == '.')
                        {
                            entry.Text = cadena.Remove(cadena.Length - 1) + ",";
                            entry.SelectionStart = cadena.Length;
                            cont++;
                        }
                        else if (cadena[i] == ',')
                        {
                            cont++;
                        }
                    }    
                }
                else
                {
                    entry.Text = cadena.Remove(cadena.Length - 1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }

        // VALIDA QUE LAS ENTRADAS SOLO SEAN CARACTERES UNICODE O ESPACIOS EN BLANCO
        public void ValidarAlfaEspacio(TextBox entry)
        {
            string cadena = entry.Text;
            for(int i = 0; i < cadena.Length; i++)
            {
                if(char.IsLetter(cadena[i]) || char.IsWhiteSpace(cadena[i]))
                {
                    // TODO EN ORDEN
                }
                else
                {
                    entry.Text = cadena.Remove(cadena.Length-1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }

        // VERIFICA QUE LOS DATOS SEAN CARACTERES NUMERICOS O ALFABETICOS
        public void ValidarAlfaNro(TextBox entry)
        {
            string cadena = entry.Text;
            for(int i =0; i<cadena.Length; i++)
            {
                if(char.IsLetter(cadena[i]) || char.IsDigit(cadena[i]))
                {
                    //  TODO EN ORDEN
                }

                else
                {
                    entry.Text = cadena.Remove(cadena.Length - 1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }

        public void ValidarAlfaNroEspacio(TextBox entry)
        {
            string cadena = entry.Text;
            for(int i=0; i < cadena.Length; i++)
            {
                if(char.IsLetter(cadena[i]) || char.IsDigit(cadena[i]) || char.IsWhiteSpace(cadena[i]))
                {
                    // TODO EN ORDEN
                }
                else
                {
                    entry.Text = cadena.Remove(cadena.Length - 1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }

        public void ValidarLimiteEntrada(TextBox entry, int max)
        {
            string cadena = entry.Text;
            if (cadena.Length > max)
            {
                entry.Text = cadena.Remove(cadena.Length - 1);
                entry.SelectionStart = cadena.Length;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Validaciones
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Validaciones";
            this.ResumeLayout(false);

        }
    }
}
