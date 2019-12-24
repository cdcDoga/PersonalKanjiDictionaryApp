using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiDictionaryApp
{
    public partial class AddModifyDeleteForm : Form
    {
        public string DB_str = string.Empty;

        public ManagementType management_type;
        public Kanji kanji;
        public User user;
        public UserPool user_pool;

        public AddModifyDeleteForm(ManagementType management_type, Kanji kanji, User user, UserPool user_pool)
        {
            // for MODIFY/DELETE
            this.management_type = management_type;
            this.kanji = kanji;
            this.user = user;
            this.user_pool = user_pool;

            InitializeComponent();
        }

        public AddModifyDeleteForm(ManagementType management_type, User user, UserPool user_pool)
        {
            // for ADD
            this.management_type = management_type;
            this.user = user;
            this.user_pool = user_pool;

            InitializeComponent();
        }

        private void AddModifyDeleteForm_Load(object sender, EventArgs e)
        {
            if(management_type == ManagementType.ADD)
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                btnAddUpdate.Text = "ADD";
            }
            else if(management_type == ManagementType.UPDATE_DELETE)
            {
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                btnAddUpdate.Text = "UPDATE";

                txtKanji.Enabled = false;

                // bring all properties of selected Kanji
                txtKanji.Text = kanji.GetCharacter();
                numNumOfStroke.Value = kanji.GetNumOfStrokes();

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
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            // add to listbox
            if (sender == btnAddMeaning)
            {
                Add_To_List(txtMeaning, lbMeaningList);
            }
            else if(sender == btnAddOnyomi)
            {
                Add_To_List(txtOnyomi, lbOnyomiList);
            }
            else if(sender == btnAddKunyomi)
            {
                Add_To_List(txtKunyomi, lbKunyomiList);
            }
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            // remove from listbox
            if (sender == btnRemoveMeaning)
            {
                Remove_From_List(lbMeaningList);
            }
            else if (sender == btnRemoveOnyomi)
            {
                Remove_From_List(lbOnyomiList);
            }
            else if (sender == btnRemoveKunyomi)
            {
                Remove_From_List(lbKunyomiList);
            }
        }

        public void Add_To_List(TextBox txt, ListBox list)
        {
            if(txt.Text != "")
            {
                list.Items.Add(txt.Text);
                txt.Clear();
            }
        }

        public void Remove_From_List(ListBox list)
        {
            if(list.SelectedIndex != -1)
            {
                list.Items.Remove(list.SelectedItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EmptinessCheck()
        {
            if (txtKanji.Text != "" && numNumOfStroke.Value != 0 && lbKunyomiList.Items.Count != 0
                && lbOnyomiList.Items.Count != 0 && lbMeaningList.Items.Count != 0
                && (chkVERB.Checked == true || chkADJACTIVE.Checked == true
                || chkADVERB.Checked == true || chkNOUN.Checked == true))
            {
                return true;
            }

            return false;
        }

        private Kanji AssignKanjiDetails(Kanji kanji)
        {
            kanji.SetCharacter(txtKanji.Text);

            kanji.SetNumOfStrokes((int)numNumOfStroke.Value);

            List<string> temp_list = new List<string>();
            foreach (var item in lbKunyomiList.Items)
            {
                temp_list.Add(item.ToString());
            }
            kanji.SetKunyomi(temp_list);

            temp_list = new List<string>();
            foreach (var item in lbOnyomiList.Items)
            {
                temp_list.Add(item.ToString());
            }
            kanji.SetOnyomi(temp_list);

            temp_list = new List<string>();
            foreach (var item in lbMeaningList.Items)
            {
                temp_list.Add(item.ToString());
            }
            kanji.SetMeaning(temp_list);

            List<Structure> temp_structure = new List<Structure>();
            if (chkADJACTIVE.Checked == true) temp_structure.Add(Structure.ADJACTIVE);
            if (chkADVERB.Checked == true) temp_structure.Add(Structure.ADVERB);
            if (chkNOUN.Checked == true) temp_structure.Add(Structure.NOUN);
            if (chkVERB.Checked == true) temp_structure.Add(Structure.VERB);
            kanji.SetStructure(temp_structure);

            return kanji;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if(EmptinessCheck())
            {
                if(management_type == ManagementType.ADD)
                {
                    Kanji added_kanji = new Kanji();
                    added_kanji = AssignKanjiDetails(added_kanji);
                    user_pool.FindUser(user.GetMail()).AddKanji(added_kanji);
                    
                    // save
                    DB_str = JsonConvert.SerializeObject(user_pool);
                    File.WriteAllText(user_pool.path, DB_str);

                    this.Close();
                }
                else if(management_type == ManagementType.UPDATE_DELETE)
                {
                    // do update
                    Kanji updated_kanji = new Kanji();
                    updated_kanji = AssignKanjiDetails(updated_kanji);

                    user_pool.FindUser(user.GetMail()).DeleteKanji(kanji);
                    user_pool.FindUser(user.GetMail()).AddKanji(updated_kanji);

                    // save
                    DB_str = JsonConvert.SerializeObject(user_pool);
                    File.WriteAllText(user_pool.path, DB_str);

                    this.Close();
                }
            }
            else { MessageBox.Show("Lack of info!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtKanji.Text != "")
            {
                user_pool.FindUser(user.GetMail()).DeleteKanji(kanji);

                // save
                DB_str = JsonConvert.SerializeObject(user_pool);
                File.WriteAllText(user_pool.path, DB_str);

                this.Close();
            }
        }
    }
}
