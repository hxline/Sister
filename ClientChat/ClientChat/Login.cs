using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class Login : Form
    {
        public string username;
        public Login()
        {
            InitializeComponent();
        }

        private void radButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButtonLogin_Click(object sender, EventArgs e)
        {
            if (radTextUsername.Text != "")
            {
                Chatting chatting = new Chatting(radTextUsername.Text);
                this.Hide();
                try
                {
                    chatting.ShowDialog();
                }
                catch
                { }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nama ID tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
