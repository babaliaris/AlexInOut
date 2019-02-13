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






        //Tab Selected Index Changed.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                List<string> ins  = db.GetCategoryNames("in");
                List<string> outs = db.GetCategoryNames("out");

                analysis_category_chooser.Items.Clear();

                foreach (string name in ins)
                    analysis_category_chooser.Items.Add(name + " (Έσοδα)");
                foreach (string name in outs)
                    analysis_category_chooser.Items.Add(name + " (Έξοδα)");
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
    }
}
