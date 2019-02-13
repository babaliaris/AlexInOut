using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlexInOut
{
    public class ExcelHandler
    {
        //Class Variables.
        private Excel.Application app;
        private Excel.Workbook wbook;
        private Excel.Worksheet wsheet;


        //Constructor.
        public ExcelHandler()
        {

            //Create the Excel app.
            app = new Excel.Application();

            //Create an empty workbook.
            wbook = app.Workbooks.Add();

            //Get the workbook's sheet.
            wsheet = (Excel.Worksheet)wbook.ActiveSheet;

            app.Rows.AutoFit();
            app.Columns.AutoFit();

        }




        //Open Folder.
        private string OpenFile(string title)
        {
            //Create a save file dialog.
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Αποθήκευση " + title;
            dialog.DefaultExt = "xlsx";
            dialog.Filter = "Αρχεία Excel (*.xlsx)|*.xlsx";

            //Show the dialog and get the result.
            DialogResult result = dialog.ShowDialog();

            //Open the file to write on it.
            if (result == DialogResult.OK)
                return dialog.FileName;

            return null;
        }




        public void WriteIns(Database db)
        {

            //Get the data from the database.
            List<Register> r_list = db.GetCategoriesByType("in");


            //If there are data to export.
            if (r_list.Count > 0)
            {

                //Get the save path from the user.
                string path = this.OpenFile("Εσόδων");


                //If the path has been chooser correctly.
                if (path != null && path.Length > 0)
                {

                    wsheet.Cells[1, 1] = "Κατηγορία";
                    wsheet.Cells[1, 2] = "Τύπος";
                    wsheet.Cells[1, 2] = "Τιμή";
                    wsheet.Cells[1, 4] = "Ημερομηνία";
                    wsheet.Cells[1, 6] = "Σύνολο";

                    int index = 2;
                    decimal sum = 0;


                    //Go through each registered item.
                    foreach (Register r in r_list)
                    {
                        wsheet.Cells[index, 1] = r.category;
                        wsheet.Cells[index, 2] = "Έσοδα";
                        wsheet.Cells[index, 3] = r.value;
                        wsheet.Cells[index, 4] = r.date.ToString("dd/MM/yyyy");

                        sum += r.value;

                        index++;
                    }

                    //Store the sum.
                    wsheet.Cells[1, 7] = sum;

                    //Save the workbook.
                    wbook.SaveAs(path);

                    MessageBox.Show("Η εξαγωγή των εσόδων έγινε με επιτυχία!", "Επιτυχημένη Εξαγωγή",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //There are no data to e exported.
            else
                MessageBox.Show("Δεν υπάρχουν δεδομένα για εξαγωγή", "Ανεπαρκή Δεδομένα",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }






        public void WriteOuts(Database db)
        {

            //Get the data from the database.
            List<Register> r_list = db.GetCategoriesByType("out");


            //If there are data to export.
            if (r_list.Count > 0)
            {

                //Get the save path from the user.
                string path = this.OpenFile("Εξόδων");


                //If the path has been chooser correctly.
                if (path != null && path.Length > 0)
                {

                    wsheet.Cells[1, 1] = "Κατηγορία";
                    wsheet.Cells[1, 2] = "Τύπος";
                    wsheet.Cells[1, 2] = "Τιμή";
                    wsheet.Cells[1, 4] = "Ημερομηνία";
                    wsheet.Cells[1, 6] = "Σύνολο";

                    int index = 2;
                    decimal sum = 0;


                    //Go through each registered item.
                    foreach (Register r in r_list)
                    {
                        wsheet.Cells[index, 1] = r.category;
                        wsheet.Cells[index, 2] = "Έξοδα";
                        wsheet.Cells[index, 3] = r.value;
                        wsheet.Cells[index, 4] = r.date.ToString("dd/MM/yyyy");

                        sum += r.value;

                        index++;
                    }

                    //Store the sum.
                    wsheet.Cells[1, 7] = sum;

                    //Save the workbook.
                    wbook.SaveAs(path);

                    MessageBox.Show("Η εξαγωγή των εξόδων έγινε με επιτυχία!", "Επιτυχημένη Εξαγωγή",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //There are no data to e exported.
            else
                MessageBox.Show("Δεν υπάρχουν δεδομένα για εξαγωγή", "Ανεπαρκή Δεδομένα",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        public void WriteEverything(Database db)
        {
            //Get the data from the database.
            List<Register> in_list = db.GetCategoriesByType("in");
            List<Register> out_list = db.GetCategoriesByType("out");


            //If there are data to export.
            if (in_list.Count > 0 || out_list.Count > 0)
            {

                //Get the save path from the user.
                string path = this.OpenFile("Εσόδων-Εξόδων");


                //If the path has been chooser correctly.
                if (path != null && path.Length > 0)
                {

                    wsheet.Cells[1, 1] = "Κατηγορία";
                    wsheet.Cells[1, 2] = "Τύπος";
                    wsheet.Cells[1, 2] = "Τιμή";
                    wsheet.Cells[1, 4] = "Ημερομηνία";
                    wsheet.Cells[1, 6] = "Σύνολο Έσοδα";
                    wsheet.Cells[2, 6] = "Σύνολο Έξοδα";
                    wsheet.Cells[3, 6] = "Διαφορά";

                    int index       = 2;
                    decimal in_sum  = 0;
                    decimal out_sum = 0;


                    //Go through each registered item.
                    foreach (Register r in in_list)
                    {
                        wsheet.Cells[index, 1] = r.category;
                        wsheet.Cells[index, 2] = "Έσοδα";
                        wsheet.Cells[index, 3] = r.value;
                        wsheet.Cells[index, 4] = r.date.ToString("dd/MM/yyyy");

                        in_sum += r.value;

                        index++;
                    }

                    //Go through each registered item.
                    foreach (Register r in out_list)
                    {
                        wsheet.Cells[index, 1] = r.category;
                        wsheet.Cells[index, 2] = "Έξοδα";
                        wsheet.Cells[index, 3] = r.value;
                        wsheet.Cells[index, 4] = r.date.ToString("dd/MM/yyyy");

                        out_sum += r.value;

                        index++;
                    }

                    //Write last data.
                    wsheet.Cells[1, 7] = in_sum;
                    wsheet.Cells[2, 7] = out_sum;
                    wsheet.Cells[3, 7] = in_sum - out_sum;

                    //Save the workbook.
                    wbook.SaveAs(path);

                    MessageBox.Show("Η εξαγωγή των εσόδων-εξόδων έγινε με επιτυχία!", "Επιτυχημένη Εξαγωγή",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //There are no data to e exported.
            else
                MessageBox.Show("Δεν υπάρχουν δεδομένα για εξαγωγή", "Ανεπαρκή Δεδομένα",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





        //Close the Excel handler.
        public void Close()
        {
            object misValue = System.Reflection.Missing.Value;
            wbook.Close(false, misValue, misValue);
            app.Quit();

            app = null;
            wbook = null;
            wsheet = null;
        }
    }
}
