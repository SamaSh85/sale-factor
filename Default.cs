using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void btnAnbar_Click(object sender, EventArgs e)
        {
            AnbarInf anbar = new AnbarInf();
            anbar.ShowDialog();
            

        }

        private void btnCommadity_Click(object sender, EventArgs e)
        {
            AddCommadity addCm = new AddCommadity();
            addCm.ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
       
            buy by = new buy();
            by.ShowDialog();
           
        }
    }
}
