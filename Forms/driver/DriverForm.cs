using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDDFine
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            
        }

        private void chekFine_Click(object sender, EventArgs e)
        {
            var component = new DriverViewFine();
            component.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            componentPanel.Controls.Add(component);
        }

        private void ViewInfoCar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
