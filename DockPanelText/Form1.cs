using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockPanelText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dockPanel.Dock = DockStyle.Fill;
        }

        private void 窗體1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Frm1.dd == DockState.Unknown)
                    Frm1.Instance.Show(dockPanel, DockState.DockLeft);
                else
                    Frm1.Instance.Show(dockPanel, Frm1.dd);
            }
            catch (Exception ex)
            {
                string ERR = ex.Message;
            }
        }

        private void 窗體2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm2 frm2 = new Frm2();
                frm2.Show(dockPanel, DockState.Document);

                Frm2 frm222 = new Frm2();
                frm222.Show(frm2.Pane, DockAlignment.Bottom, 0.5);

                Frm2 frm223 = new Frm2();
                frm223.Show(frm2.Pane, DockAlignment.Right, 0.5);

                Frm2 frm224 = new Frm2();
                frm224.Show(frm222.Pane, DockAlignment.Right, 0.5);
            }
            catch (Exception ex)
            {
                string ERR = ex.Message;
            }
        }

        private void 窗體3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Frm3.dd == DockState.Unknown)
                    Frm3.Instance.Show(dockPanel, DockState.DockRight);
                else
                    Frm3.Instance.Show(dockPanel, Frm3.dd);
            }
            catch (Exception ex)
            {
                string ERR = ex.Message;
            }
        }

        private void 窗體ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
