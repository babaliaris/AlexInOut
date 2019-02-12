using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexInOut
{
    public partial class Editor : Form
    {
        private Database db;
        private string type;
        private ComboBox combo;

        public Editor(Database db, string type, ComboBox combo)
        {
            //Initialise the graphics.
            InitializeComponent();

            //Get a reference to the database object.
            this.db = db;

            //Get the category type.
            this.type = type;

            //Get the outer combo box.
            this.combo = combo;

            //Update the combo boxes.
            UpdateComboboxes();
        }

        //Editor submit button clicked.
        private void editor_submit_btn_Click(object sender, EventArgs e)
        {
            string category = editor_entry.Text;

            //The category field was empty.
            if (category.Length == 0)
            {
                MessageBox.Show("Το πεδίο κατηγορία δεν πρέπει να είναι κενό.", "Λάθος Δεδομένα",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Insert Category.
            if (editor_insert_radio.Checked)
            {

                //Insert category into the database.
                if (db.InsertCategory(category, type))
                {
                    UpdateComboboxes();
                    editor_entry.Clear();
                }
            }



            //Edit Category Name.
            else
            {

                //Check if something is selected.
                if (editor_category_chooser.SelectedIndex < 0)
                {
                    MessageBox.Show("Δεν έχεις επιλέξη κάποια κατηγορία για επεξεργασία.", "Λάθος Δεδομένα",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Edit the selected category name.
                if ( db.EditCategory(category, (string)editor_category_chooser.SelectedItem, type) )
                {
                    UpdateComboboxes();
                    editor_entry.Clear();
                }
            }
        }





        //Update the combo boxes.
        public void UpdateComboboxes()
        {

            //Clear the mobo boxes.
            combo.Items.Clear();
            editor_category_chooser.Items.Clear();

            //Get the names from the database.
            List<string> names = db.GetCategoryNames(type);

            //Fill the combo boxes with the updated data.
            foreach (string name in names)
            {
                combo.Items.Add(name);
                editor_category_chooser.Items.Add(name);
            }
        }





        //Editor Insert Radio Checked Changed.
        private void editor_insert_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (editor_insert_radio.Checked)
                editor_submit_btn.Text = "Εισαγωγή";

            else
                editor_submit_btn.Text = "Επεξεργασία";
        }




        //Editor Category Chooser Changed.
        private void editor_category_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {

            //If there is something indeed selected.
            if (editor_category_chooser.SelectedIndex >= 0)
            {

                //Get the selected category from the database.
                string[] c = db.GetCategory((string)editor_category_chooser.SelectedItem, type);

                //If everything run smoothly.
                if (c != null)
                {
                    editor_entry.Text = c[0];
                }
            }
        }
    }
}
