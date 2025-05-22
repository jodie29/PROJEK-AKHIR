using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_AKHIR
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

public class Database
{

    NpgsqlConnection conn;
    public Database()
    {

        string connStr = "Host=localhost;Username=postgres;Password=29MrT06.;Database=pbo";
        conn = new NpgsqlConnection(connStr);
        conn.Open();
    }
    internal List<User> GetDataAdmin()
    {
        List<User> Listuser = new List<User>();
        string query = "SELECT * FROM users";
        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User
                    {
                        username = reader["username"].ToString(),
                        password = reader["password"].ToString()
                    };
                    Listuser.Add(user);
                }
                return Listuser;
            }
        }
    }
}
