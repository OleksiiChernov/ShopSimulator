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
        public delegate void AddMessageDelegate(string message);

        public MainForm()
        {
            InitializeComponent();
            ShopController.Instance.OnNewLogGenerated += OnNewLogGenerated;
            ShopController.Instance.OnModeChanged += OnModeChanged;
            ShopController.Instance.OnCashChanged += OnCashChanged;
            ShopController.Instance.UpdateValues();
        }

        public void CashLogAdd(string message)
        {
            if (null != cashLabel && !string.IsNullOrWhiteSpace(message))
            {
                cashLabel.Text = message;
            }
        }

        public void ModeLogAdd(string message)
        {
            if (null != currentModeLabel && !string.IsNullOrWhiteSpace(message))
            {
                currentModeLabel.Text = message;
            }
        }

        public void MainLogAdd(string message)
        {
            if (null != mainLog && !string.IsNullOrWhiteSpace(message))
            {
                mainLog.AppendText("\n" + DateTime.Now + "\t" + message + "\r\n");
            }
        }

        private void OnCashChanged(object sender, NewLogEventArgs newLogEventArgs)
        {
            if (IsHandleCreated)
            {
                Invoke(new AddMessageDelegate(CashLogAdd), new object[] {newLogEventArgs.Message});
            }
        }

        private void OnModeChanged(object sender, NewLogEventArgs newLogEventArgs)
        {
            if (IsHandleCreated)
            {
                Invoke(new AddMessageDelegate(ModeLogAdd), new object[] {newLogEventArgs.Message});
            }
        }

        private void OnNewLogGenerated(object sender, NewLogEventArgs newLogEventArgs)
        {
            if (IsHandleCreated)
            {
                Invoke(new AddMessageDelegate(MainLogAdd), new object[] {newLogEventArgs.Message});
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
