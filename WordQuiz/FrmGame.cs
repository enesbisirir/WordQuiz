using System;
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
            // Ensure user checked at least one unit
            if (ClbUnits.GetCheckedUnitCount() >= 1)
            {
                Game.UpdateGameHolders(ClbUnits.CheckedUnits());
                Game.SetNextWord();
            }
            else
            {
                MessageBox.Show("Please check at least one unit to start game.");
            }

            ShowCurrentWord();

            // TEST if SelectedUnits are updated
            MessageBox.Show(Game.SelectedUnits.GetUnit(0).ToString());

            // TEST if SelectedWords are updated
            MessageBox.Show(Game.SelectedWords.GetRandomWord().ToString());
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (IsAnswerCorrect())
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong! :(");
            }
            ClearInputTextBox();
            Game.RemoveAskedWord();
            Game.SetNextWord();
            ShowCurrentWord();
        }

        private void ClearInputTextBox()
        {
            TbSpanishInput.Text = "";
        }

        private void ShowCurrentWord()
        {
            LblEnglishOutput.Text = Game.CurrentWord.English;
        }

        private bool IsAnswerCorrect()
        {
            if (Game.CurrentWord.Spanish == TbSpanishInput.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
