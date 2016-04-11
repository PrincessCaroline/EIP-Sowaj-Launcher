using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sowaj
{
    public partial class Friends : Form
    {
        private String name;
        public Friends(String _name)
        {
            InitializeComponent();
            name = _name;
            lblFriendPseudo.Text = name;
        }

        private void newMessage()
        {
            if (txtMessage.Text.Length < 256)
                ListBoxMessages.Items.Add("caroline : " + txtMessage.Text);
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            newMessage();
            txtMessage.Clear();
        }
    }
}
