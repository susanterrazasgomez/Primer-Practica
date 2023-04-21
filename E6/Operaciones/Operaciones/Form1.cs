using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            comboBox_opciones.Items.Add("Numeros Primos");
            comboBox_opciones.Items.Add("Numeros Perfectos");
            comboBox_opciones.Items.Add("Serie Fibonacci");
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            listBox_resultado.Items.Clear();
            int num = Convert.ToInt32( txt_num.Text);
            if (comboBox_opciones.Text == "Numeros Primos")
            {
                for (int i = 1; i <= num; i++)
                {
                    int c = 1, x=0;
                    while(c<i)
                    {
                        if(i%c == 0 && c!=1) { x++; }
                        c++;
                    }
                    if(x==0 && i!=1) { listBox_resultado.Items.Add(i); }
                }   
            }
            if (comboBox_opciones.Text == "Numeros Perfectos")
            {
                for (int i = 1; i <= num; i++)
                {
                    int c = 1, x = 0;
                    while (c < i)
                    {
                        if (i % c == 0 ) { x+=c; }
                        c++;
                    }
                    if (x == i) { listBox_resultado.Items.Add(i); }
                }
            }
            if (comboBox_opciones.Text == "Serie Fibonacci")
            {
                int ant = 0, sig = 1, aux;
                for (int i = 0; i < num; i++)
                {
                    listBox_resultado.Items.Add(sig);
                    aux = ant;
                    ant = sig;
                    sig = aux + sig;
                }
            }
        }
    }
}
