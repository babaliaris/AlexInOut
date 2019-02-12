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
    public partial class Form1 : Form
    {
        private Database db;

        public Form1()
        {

            //Initialise Graphics.
            InitializeComponent();

            //Initialise the database.
            db = new Database("localhost", "babaliaris", "123456", "alex_in_out");

            //Set mouse up event handler.
            register_category_picker.MouseUp += new MouseEventHandler(this.register_category_picker_MouseUp);

            //Update Register Chooser.
            UpdateRegisterChooser("in");
        }

        


        //Register Chooser Click Event.
        private void register_category_picker_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //The editor form.
                Editor editor;

                //In.
                if (register_in_radio.Checked)
                {
                    editor = new Editor(db, "in", this.register_category_picker);
                    editor.Text = "Επεξεργασία Εσόδων";
                }

                //Out.
                else
                {
                    editor = new Editor(db, "out", this.register_category_picker);
                    editor.Text = "Επεξεργασία Εξόδων";
                }


                //Start the editor.
                editor.ShowDialog();
            }
        }





        //Update Register Chooser.
        private void UpdateRegisterChooser(string type)
        {
            register_category_picker.Items.Clear();

            List<string> names = db.GetCategoryNames(type);

            foreach (string name in names)
                register_category_picker.Items.Add(name);
        }






        //Register Radios Changed.
        private void register_in_radio_CheckedChanged(object sender, EventArgs e)
        {

            //In.
            if (register_in_radio.Checked)
            {
                UpdateRegisterChooser("in");
                label5.ForeColor = Color.DarkGreen;
                label1.ForeColor = Color.DarkGreen;
                label2.ForeColor = Color.DarkGreen;
                register_submit_btn.ForeColor = Color.DarkGreen;
            }

            //Out.
            else
            {
                UpdateRegisterChooser("out");
                label5.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                register_submit_btn.ForeColor = Color.Red;
            }
        }






        //Registered Insert Button Clicked.
        private void register_submit_btn_Click(object sender, EventArgs e)
        {

            //Check if a category is selected.
            if (register_category_picker.SelectedIndex < 0)
            {
                MessageBox.Show("Δεν έχεις επιλέξη κάποια κατηγορία.", "Λάθος Δεδομένα",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Get The user Input.
            string category = (string)register_category_picker.SelectedItem;
            decimal value   = register_value_entry.Value;
            DateTime date   = registered_date_picker.Value;

            //IN.
            if (register_in_radio.Checked)
            {
                Register r = new Register(category, "in", value, date);

                db.InsertRegister(r);
            }


            //OUT.
            else
            {
                Register r = new Register(category, "out", value, date);

                db.InsertRegister(r);
            }
        }
    }
}
