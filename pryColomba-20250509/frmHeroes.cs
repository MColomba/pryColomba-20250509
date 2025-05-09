using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryColomba_20250509.Properties;

namespace pryColomba_20250509
{
    public partial class frmHeroes : Form
    {
        public frmHeroes()
        {
            InitializeComponent();
            CargarCmbHeroes();
        }
        public void CargarCmbHeroes()
        {
            cmbHeroes.Items.Clear();
            cmbHeroes.Items.Insert(0, "Superman");
            cmbHeroes.Items.Insert(1, "Batman");
            cmbHeroes.Items.Insert(2, "Wonder Woman");
        }
        public bool ValidaDatos()
        {
            if(cmbHeroes.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono un heroe");
                return false;
            }
            return true;
        }

        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHeroes.SelectedIndex)
            {
                case 0:
                    picSimbolo.Image = Resources.Superman;
                    break;
                case 1:
                    picSimbolo.Image = Resources.batman;
                    break;
                case 2:
                    picSimbolo.Image = Resources.WonderWoman;
                    break;
                default:
                    picSimbolo.Image = Resources.error;
                    break;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(ValidaDatos() == true)
            {
                StreamWriter Guardar = new StreamWriter("Estadisticas.txt", true);
                Guardar.WriteLine(cmbHeroes.Text + "," + nudFuerza.Value + "," + nudDestreza.Value);
                Guardar.Close();
                Guardar.Dispose();
            }
        }
    }
}
