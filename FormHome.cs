using System;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FormHome : Form
    {
        private string _loggedInAdminId;

        public FormHome(string adminId)
        {
            InitializeComponent();
            _loggedInAdminId = adminId;
        }

        public FormHome()
        {
            InitializeComponent();
            _loggedInAdminId = string.Empty;
        }

    private void FormHome_Load(object sender, EventArgs e)
        {
           
        }
    }
}