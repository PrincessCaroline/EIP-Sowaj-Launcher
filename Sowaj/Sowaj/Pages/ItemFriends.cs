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
    public partial class ItemFriends : Form
    {
        public ItemFriends()
        {
            InitializeComponent();
        }

        public void setFriendName(String _n)
        {
            lblFriendName.Text = _n;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Friends friendChat = new Friends(lblFriendName.Text);
            friendChat.Show();
        }
    }
}
