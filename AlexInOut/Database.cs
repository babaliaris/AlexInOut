using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AlexInOut
{
    class Database
    {
        //__________Class Variables__________//
        private MySqlConnection connection;
        //__________Class Variables__________//



        //Constructor.
        public Database(string ip, string username, string pass, string database)
        {
            string connString = "SERVER=" + ip + ";" + "DATABASE=" + database + ";UID=" + username + ";PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connString);
        }





        //Establish Connection.
        private bool Connect()
        {

            //Try creating the connection.
            try
            {
                connection.Open();
                return true;
            }


            //Connection Failed.
            catch (MySqlException)
            {
                MessageBox.Show("Το πρόγραμμα δεν μπόρεσε να συνδεθεί στην Βάση Δεδομένων. Παρακαλώ ελέγξτε αν η Βάση Δεδομένων" +
                    " είναι ανοιχτεί.", "Πρόβλημα Σύνδεσης Στην Βάση Δεδομένων", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




        //Close the connection.
        private void Close()
        {
            connection.Close();
        }




        //Show Uknown Error.
        private void UknownError(string func, int number, int error_code, uint code, string message)
        {
            MessageBox.Show("Ένα απροσδιόριστο πρόβλημα συνέβει στην βάση δεδομένων. Δοκίμασε ξανά αργότερα." +
                        "\n\nΣυνάρτηση: " + func + "\nΑριθμός Σφάλματος: " + number + "\nΚώδικας Σφάλματος: "
                        + error_code + "\nΓενικός Κώδικας: " + code + "" + "\nΜήνυμα: " + message,
                        "Απροσδιόριστο Πρόβλημα", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





        //Insert a New product into the database.
        public void InsertProduct(Product pd)
        {

            //Connect to execute command.
            if (this.Connect())
            {

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                //Create the procedure.
                cmd.CommandText = "add_product";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add the parameters.
                cmd.Parameters.AddWithValue("price", pd.price);
                cmd.Parameters.AddWithValue("pr_name", pd.name);
                cmd.Parameters.AddWithValue("sup", pd.supplier);
                cmd.Parameters.AddWithValue("phon", pd.phone);
                cmd.Parameters.AddWithValue("des", pd.description);
                cmd.Parameters.AddWithValue("barc", pd.barcode);


                //Try executing the command.
                try
                {

                    //Execute the commant.
                    cmd.ExecuteNonQuery();

                    //Show success message.
                    MessageBox.Show("Το προϊόν:\n\n" + pd.ToString() + "\n\n δημιουργήθηκε με επιτυχία!",
                        "Επιτυχής Εισαγωγή", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                //Something wrong happened.
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Η σύνδεση στην βάση δεδομένων απέτυχε. Δοκίμασε ξάνα αργότερα.", "Σφάλμα Σύνδεσης",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                //Something wrong happened.
                catch (MySqlException e)
                {

                    //Duplicate entry of product name.
                    if (e.Number == 1062)
                        MessageBox.Show("Το προϊόν με Όνομα: " + pd.name + " και Barcode: " + pd.barcode + ", υπάρχει ήδη.", "Υπάρχει",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Uknown Error.
                    else
                        this.UknownError("InsertProduct", e.Number, e.ErrorCode, e.Code, e.Message);

                }

                //Close the connection.
                this.Close();
            }
        }
    }
}
