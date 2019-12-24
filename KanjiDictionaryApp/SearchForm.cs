using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiDictionaryApp
{
    public enum Tab
    {
        SEARCH = 0,
        MANAGEMENT = 1
    }

    public enum ManagementType
    {
        ADD = 0,
        UPDATE_DELETE = 1
    }

    public partial class SearchForm : Form
    {
        public Tab tab_index;
        public ManagementType management_type;

        User user;
        UserPool user_pool;

        public SearchForm(User user, UserPool user_pool)
        {
            InitializeComponent();

            this.user = user;
            this.user_pool = user_pool;

            lblWelcome.Text = user.GetMail();
            BringAllKanji(user_pool.FindUser(user.GetMail()).GetDictionary());
        }

        private void BringAllKanji(List<Kanji> kanji_list)
        {
            foreach (var item in kanji_list)
            {
                lbKanjiList.Items.Add(item.GetCharacter());
            }
        }

        private void txtKana_Enter(object sender, EventArgs e)
        {
            Placeholder.enter_event_placeholder(txtKana, "Hiragana/Katakana");

            txtMeaning.Text = "";
            numNumOfStroke.Value = 0;
        }

        private void txtKana_Leave(object sender, EventArgs e)
        {
            Placeholder.leave_event_placeholder(txtKana, "Hiragana/Katakana");
        }

        private void txtMeaning_Enter(object sender, EventArgs e)
        {
            txtKana.Text = "";
            Placeholder.leave_event_placeholder(txtKana, "Hiragana/Katakana");
            numNumOfStroke.Value = 0;
        }
        
        private void numNumOfStroke_Enter(object sender, EventArgs e)
        {
            txtKana.Text = "";
            Placeholder.leave_event_placeholder(txtKana, "Hiragana/Katakana");
            txtMeaning.Text = "";
        }

        private void btnSearchTab_Click(object sender, EventArgs e)
        {
            // global tab_index => enum Tab.SEARCH
            tab_index = Tab.SEARCH;

            // move the yellow tab stick
            panelTabStick.Top = 172;

            // add new kanji button disapperance
            btnAddNewKanji.Enabled = false;
            btnAddNewKanji.Visible = false;

            // change double click info text
            lblDoubleClickInfo.Text = "Double click to see details*";
        }

        private void btnManagementTab_Click(object sender, EventArgs e)
        {
            // global tab_index => enum Tab.MANAGEMENT
            tab_index = Tab.MANAGEMENT;

            // move the yellow tab stick
            panelTabStick.Top = 270;

            // add new kanji button apperance
            btnAddNewKanji.Enabled = true;
            btnAddNewKanji.Visible = true;

            // change double click info text
            lblDoubleClickInfo.Text = "Double click to update or delete*";
        }

        private void btnKanaPage_Click(object sender, EventArgs e)
        {
            using (KanaForm form = new KanaForm())
            {
                form.ShowDialog();
            }
        }

        private void pbAccount_MouseHover(object sender, EventArgs e)
        {
            pbAccount.Image = Properties.Resources.logout_512px;
        }

        private void pbAccount_MouseLeave(object sender, EventArgs e)
        {
            pbAccount.Image = Properties.Resources.id_card512;
        }

        private void pbAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewKanji_Click(object sender, EventArgs e)
        {
            // global management_type => enum ManagementType.ADD
            management_type = ManagementType.ADD;

            using (AddModifyDeleteForm form = new AddModifyDeleteForm(management_type, user, user_pool))
            {
                form.ShowDialog();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string criteria = TakeFilterCriteria();
            lbKanjiList.Items.Clear();

            if (criteria == "")
            {
                BringAllKanji(user_pool.FindUser(user.GetMail()).GetDictionary());
            }
            else
            {
                List<Kanji> filtered_kanji_list
                = user_pool.FindUser(user.GetMail()).FilterKanji(criteria);
                
                BringAllKanji(filtered_kanji_list);
            }
            
        }

        private string TakeFilterCriteria()
        {
            if (txtKana.Text != "" && txtKana.Text != "Hiragana/Katakana") return txtKana.Text;
            else if (txtMeaning.Text != "") return txtMeaning.Text;
            else if (numNumOfStroke.Value != 0) return numNumOfStroke.Value.ToString();
            else return "";
        }

        private void lbKanjiList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbKanjiList.SelectedItem != null)
            {
                string character = lbKanjiList.SelectedItem.ToString();
                Kanji kanji = user_pool.FindUser(user.GetMail()).FindKanji(character);

                if (tab_index == Tab.SEARCH)
                {
                    // details page
                    using (DetailsForm form = new DetailsForm(kanji))
                    {
                        form.ShowDialog();
                    }
                }
                else if (tab_index == Tab.MANAGEMENT)
                {
                    management_type = ManagementType.UPDATE_DELETE;

                    // update/delete page
                    using (AddModifyDeleteForm form 
                        = new AddModifyDeleteForm(management_type, kanji, user, user_pool))
                    {
                        form.ShowDialog();
                    }
                }
            }
            
        }
    }
}
