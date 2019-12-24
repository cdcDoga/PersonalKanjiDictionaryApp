using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace KanjiDictionaryApp
{
    public partial class DetailsForm : Form
    {
        public Kanji kanji;
        private SpeechSynthesizer synthesizer; 

        public DetailsForm(Kanji kanji)
        {
            this.kanji = kanji;
            synthesizer = new SpeechSynthesizer();

            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            lblKanji.Text = kanji.GetCharacter();
            lblNumOfStrokes.Text = kanji.GetNumOfStrokes().ToString();

            foreach (var item in kanji.GetKunyomi())
            {
                lbKunyomiList.Items.Add(item);
            }

            foreach (var item in kanji.GetOnyomi())
            {
                lbOnyomiList.Items.Add(item);
            }

            foreach (var item in kanji.GetMeaning())
            {
                lbMeaningList.Items.Add(item);
            }

            foreach (var item in kanji.GetStructure())
            {
                if (item == Structure.ADJACTIVE) chkADJACTIVE.Checked = true;
                if (item == Structure.ADVERB) chkADVERB.Checked = true;
                if (item == Structure.NOUN) chkNOUN.Checked = true;
                if (item == Structure.VERB) chkVERB.Checked = true;
            }
        }

        private void Speaker_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync("try text to speech"); // 昨日すき焼きを食べました
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
