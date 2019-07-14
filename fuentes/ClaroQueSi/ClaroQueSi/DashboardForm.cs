using SharpUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Reflection;

namespace ClaroQueSi
{
    public partial class DashboardForm : Form
    {
        private SharpUpdater updater;
        public DashboardForm()
        {
            InitializeComponent();
            updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://dl.dropbox.com/s/8lrlgmq2zdqxhl5/project.xml?dl=1"));
            //updater.DoUpdate();

        }

        private void btnYaSoyCliente_Click(object sender, EventArgs e)
        {
            panelCuatro.Controls["panelCuatroPanelArriba"].Controls.Clear();
            panelCuatro.Controls["panelCuatroPanelArriba"].Visible = true;
            panelCuatro.Controls["panelCuatroPanelArriba"].Controls.Add(new ControlUsuario.LoginUC());
        }
    }
}
