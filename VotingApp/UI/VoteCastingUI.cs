using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VotingApp.DAL.DAO;

namespace VotingApp
{
    public partial class VoteCastingUI : Form
    {
        public VoteCastingUI()
        {
            InitializeComponent();
        }

        private Voter aVoter = new Voter();
        private void voteCastButton_Click(object sender, EventArgs e)
        {
            aVoter.Email = emailTextBox.Text;
            
            
        }
    }
}
