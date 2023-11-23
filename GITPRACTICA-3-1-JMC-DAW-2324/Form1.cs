using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITPRACTICA_3_1_JMC_DAW_2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; //Práctica 2.3 JMC - DAWY 23-24 Añadimos una 'o' para que ordinario sea puesto como defecto
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
                //Añadimos rbUrgente GITPRACTICA-3-1-JMC-DAW-2324
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Añadimos tipoTelegrama = 'o' GITPRACTICA-3-1-JMC-DAW-2324
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ', '.', ',', ':', ';').Length;
            //Práctica 2.3 JMC - DAWY 23-24 Este es el código corregido para calcular bien el número de palabras
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                //Práctica 2.3 JMC - DAWY 23-24 Punto de interrupción para comprobar el número de palabras
                if (numPalabras <= 10)
                    //Práctica 2.3 JMC - DAWY 23-24 Punto de interrupción para saber si entra en telegrama ordinario
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            //Práctica 2.3 JMC - DAWY 23-24 Coste de las palabras corregido
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
