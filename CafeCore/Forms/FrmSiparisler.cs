using CafeCore.Data;
using CafeCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCore.Forms
{
    public partial class FrmSiparisler : Form
    {
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        public Masa _seciliMasa;
        private CafeContext _context = new CafeContext();
        private void FrmSiparisler_Load(object sender, EventArgs e)
        {

        }
    }
}
