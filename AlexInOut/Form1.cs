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
        private string currDir;

        public Form1()
        {

            //Get current directory.
            currDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

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
                register_info_group.ForeColor = Color.DarkGreen;
            }

            //Out.
            else
            {
                UpdateRegisterChooser("out");
                label5.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                register_submit_btn.ForeColor = Color.Red;
                register_info_group.ForeColor = Color.Red;
            }


            //Clear Register Info.
            register_info_category.Clear();
            register_info_type.Clear();
            register_info_price.Clear();
            register_info_date.Clear();
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

                //Try inserting the register.
                int result = db.InsertRegister(r);
                if (result == 1)
                    UpdateRegisterInfo(r);


                //Already Exists. Maybe update it?
                else if (result == -1)
                {

                    //Get the old register.
                    Register old = db.GetRegister("in", category, date);

                    //Ask the user if he wants to replace the value.
                    DialogResult dresult = MessageBox.Show("Υπάρχει ήδη μια καταχώρηση για την κατηγορία "
                            + r.category + " με ημερομηνία " + r.date.ToString("dd/MM/yyyy") + "" +
                            ". Θέλεις να αντικαταστήσεις την παλιά τιμή με την καινούρια;\n\n" +
                            "Παλιά Τιμή: "+old.value+"\nΝέα Τιμή: "+r.value,
                        "Αντικατάσταση;", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //Update the Register.
                    if (dresult == DialogResult.Yes)
                    {
                        if (db.UpdateRegister(r))
                            UpdateRegisterInfo(r);
                    }
                }
            }


            //OUT.
            else
            {
                Register r = new Register(category, "out", value, date);

                //Try inserting the register.
                int result = db.InsertRegister(r);
                if (result == 1)
                    UpdateRegisterInfo(r);

                //Already Exists. Maybe update it?
                else if (result == -1)
                {

                    //Get the old register.
                    Register old = db.GetRegister("out", category, date);

                    //Ask the user if he wants to replace the value.
                    DialogResult dresult = MessageBox.Show("Υπάρχει ήδη μια καταχώρηση για την κατηγορία "
                            + r.category + " με ημερομηνία " + r.date.ToString("dd/MM/yyyy") + "" +
                            ". Θέλεις να αντικαταστήσεις την παλιά τιμή με την καινούρια;\n\n" +
                            "Παλιά Τιμή: " + old.value + "\nΝέα Τιμή: " + r.value,
                        "Αντικατάσταση;", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //Update the Register.
                    if (dresult == DialogResult.Yes)
                    {
                        if (db.UpdateRegister(r))
                            UpdateRegisterInfo(r);
                    }
                }
            }
        }






        //Tab Selected Index Changed.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {

                //Get all the Categories.
                List<string> ins  = db.GetCategoryNames("in");
                List<string> outs = db.GetCategoryNames("out");

                //Clear the Categry Chooser.
                analysis_category_chooser.Items.Clear();


                //Fill The Categories to the chooser.
                foreach (string name in ins)
                    analysis_category_chooser.Items.Add(name + " (Έσοδα)");
                foreach (string name in outs)
                    analysis_category_chooser.Items.Add(name + " (Έξοδα)");

                //Clear the chart.
                analysis_chart.Series["Τιμή"].Points.Clear();
            }
        }





        //Show analysis.
        private void ShowAnalysis()
        {
            
            //Clear the chart.
            analysis_chart.Series["Τιμή"].Points.Clear();

            //Check if a category is selected.
            if (analysis_category_chooser.SelectedIndex >= 0)
            {

                //Get user input.
                string selected = (string)analysis_category_chooser.SelectedItem;
                string type     = selected.Contains("(Έσοδα)") == true ? "in" : "out";
                string category = selected.Replace("(Έσοδα)", "").Replace("(Έξοδα)", "");
                DateTime from   = analysis_from_picker.Value;
                DateTime to     = analysis_to_picker.Value;


                //Get the analysis from the database.
                object[] obj = db.GetAnalysis(category, type, from, to);

                //If everything went smoothly and the 
                //array has been initialised with db data.
                if (obj != null && obj[0] != null)
                {
                    Register r  = (Register)obj[0];
                    var total   = obj[1];

                    int index = analysis_chart.Series["Τιμή"].Points.AddY(total);

                    string offset = "          ";
                    analysis_chart.Series["Τιμή"].Points[index].Label = offset+total.ToString().Replace(".", ",");
                    analysis_chart.Series["Τιμή"].AxisLabel           = r.category;
                }
            }
        }





        //Analysis Selected Category Changed.
        private void analysis_category_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAnalysis();
        }


        //Analysis From Date Changed.
        private void analysis_from_picker_ValueChanged(object sender, EventArgs e)
        {
            ShowAnalysis();
        }


        //Analysis to date changed.
        private void analysis_to_picker_ValueChanged(object sender, EventArgs e)
        {
            ShowAnalysis();
        }





        //Export Ins.
        private void έσοδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHandler handler = new ExcelHandler();

            handler.WriteIns(db);

            handler.Close();
        }


        //Export outs.
        private void έξοδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHandler handler = new ExcelHandler();

            handler.WriteOuts(db);

            handler.Close();
        }
        

        //Export Everything.
        private void μαζίToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHandler handler = new ExcelHandler();

            handler.WriteEverything(db);

            handler.Close();
        }



        //Update Register Info.
        private void UpdateRegisterInfo(Register r)
        {

            if (r != null)
            {
                register_info_category.Text = r.category;
                register_info_type.Text = (r.type == "in" ? "ΕΣΟΔΑ" : "ΕΞΟΔΑ");
                register_info_price.Text = r.value.ToString();
                register_info_date.Text = r.date.ToString("dd/MM/yyyy");
            }

            else
            {
                register_info_category.Clear();
                register_info_type.Clear();
                register_info_price.Clear();
                register_info_date.Clear();


            }
        }





        //Register Selected Index Changed.
        private void register_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Register r;

            //In radio is selected.
            if (register_in_radio.Checked)
                r = db.GetRegister("in", (string)register_category_picker.SelectedItem, registered_date_picker.Value);

            //Out radio is selected.
            else
                r = db.GetRegister("out", (string)register_category_picker.SelectedItem, registered_date_picker.Value);

            //Update ragister info.
            UpdateRegisterInfo(r);
        }





        //Register Date Picker.
        private void registered_date_picker_ValueChanged(object sender, EventArgs e)
        {
            if (register_category_picker.SelectedIndex >= 0)
            {
                Register r;

                //In radio is selected.
                if (register_in_radio.Checked)
                    r = db.GetRegister("in", (string)register_category_picker.SelectedItem, registered_date_picker.Value);

                //Out radio is selected.
                else
                    r = db.GetRegister("out", (string)register_category_picker.SelectedItem, registered_date_picker.Value);

                UpdateRegisterInfo(r);
            }
        }
    }
}
