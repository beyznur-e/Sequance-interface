using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Sezon_Arttır : Form
    {
        public Sezon_Arttır()
        {
            InitializeComponent();
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            int dizi = Convert.ToInt32(textBox1.Text);

            if (dizi >= 1000 && dizi <= 9999)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dizi;
                bs.Filter = "id = " + dizi;
                MessageBox.Show(dizi + " ID değerli 1 dizinin sezonu 1 arttırıldı.");
                int id = 0;
                dizi = id + 1;
            }
            else
            {
                MessageBox.Show("Dizi değeri 4 haneli olmalıdır");
            }

        }
    }
}
