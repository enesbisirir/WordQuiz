﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WordQuiz
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }
        
        private void FrmGame_Load(object sender, EventArgs e)
        {
            ClbUnits.Populate();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {

        }
    }
}
