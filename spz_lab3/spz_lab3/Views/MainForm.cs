using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using spz_lab3.Controllers;

namespace spz_lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShopController.Instance.OnNewLogGenerated += OnNewLogGenerated;
        }

        private void OnNewLogGenerated(object sender, NewLogEventArgs newLogEventArgs)
        {
            if (null != mainLog && !string.IsNullOrWhiteSpace(newLogEventArgs.Message))
            {
                mainLog.Text += "\n" + newLogEventArgs.Message + "\n";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void normalModeButton_Click(object sender, EventArgs e)
        {
            ShopController.Instance.SetMode(ShopMode.Normal);
        }

        private void inventoryModeButton_Click(object sender, EventArgs e)
        {
            ShopController.Instance.SetMode(ShopMode.Inventory);
        }
    }
}
