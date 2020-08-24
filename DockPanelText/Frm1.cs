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
    public partial class Frm1 : DockContent
    {
        public Frm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static Frm1 _instance;
        internal static Frm1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Frm1();
                return _instance;
            }
        }

        /// <summary>
        /// 用于关闭工具箱窗体后，再次打开时还能出现在原来消失的位置，而不是每次只能出现在固定的位置
        /// </summary>
        public static DockState dd;
        private void Frm1_DockStateChanged(object sender, EventArgs e)
        {
            if (Frm1.Instance.DockState != DockState.Unknown)
                dd = Frm1.Instance.DockState;
        }
    }
}
