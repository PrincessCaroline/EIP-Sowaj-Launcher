﻿using System;
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
    public partial class Card : Form
    {
        Deck        d;
        bool        editionMode;
        CardInfos   infos;

        public Card(Deck _d, bool isEdit)//, CardInfos _infos)
        {
            InitializeComponent();
            d = _d;
//            infos = _infos;
            editionMode = isEdit;
            if (isEdit == false)
                this.btnAddCard.Hide();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (editionMode == true)
                d.addCardToDeck();
        }
    }
}