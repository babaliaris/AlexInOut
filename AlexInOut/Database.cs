using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AlexInOut
{
    public class Database
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




        /*
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
        */





            
        //Instert Category.
        public bool InsertCategory(string name, string type)
        {

            bool ok = false;

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "INSERT INTO category_names VALUES ('" + name + "', '" + type + "');";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    //Execute the commant.
                    cmd.ExecuteNonQuery();

                    //Show success message.
                    MessageBox.Show("Η κατηγορία: " + name + ", δημιουργήθηκε με επιτυχία!",
                        "Επιτυχής Εισαγωγή", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ok = true;
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
                        MessageBox.Show("Η κατηγορία "+name+", υπάρχει ήδη.", "Υπάρχει",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Uknown Error.
                    else
                        this.UknownError("InsertCategory", e.Number, e.ErrorCode, e.Code, e.Message);

                }

                //Close the connection.
                this.Close();
            }

            return ok;
        }





        //Get Category Names By Type.
        public List<string> GetCategoryNames(string type)
        {

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "SELECT category FROM category_names WHERE type_ = '"+type+"';";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    //Names list.
                    List<string> names = new List<string>();

                    //Execute the commant.
                    MySqlDataReader data = cmd.ExecuteReader();

                    //Get all the names from the data set.
                    while (data.Read())
                        names.Add((string)data["category"]);

                    data.Close();
                    this.Close();

                    return names;
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
                    this.UknownError("GetCategoryNames", e.Number, e.ErrorCode, e.Code, e.Message);
                }

                //Close the connection.
                this.Close();
            }

            return new List<string>();
        }





        //Edit Category.
        public bool EditCategory(string name, string old_name, string type)
        {

            bool ok = false;

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "UPDATE category_names SET category = '" + name + "' WHERE" +
                    " category = '"+ old_name+"' AND type_ = '"+type+"';";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    //Execute the commant.
                    cmd.ExecuteNonQuery();

                    //Show success message.
                    MessageBox.Show("Η κατηγορία: " + old_name + ", ενημερώθηκε με επιτυχία!",
                        "Επιτυχής Εισαγωγή", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ok = true;
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
                        MessageBox.Show("Η κατηγορία " + name + ", υπάρχει ήδη.", "Υπάρχει",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Uknown Error.
                    else
                        this.UknownError("EditCategory", e.Number, e.ErrorCode, e.Code, e.Message);

                }

                //Close the connection.
                this.Close();
            }

            return ok;
        }





        //Get Category.
        public string[] GetCategory(string name, string type)
        {

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "SELECT * FROM category_names WHERE type_ = '" + type + "' AND category = '"+name+"';";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    //Categories.
                    string[] categories = new string[2];

                    //Execute the commant.
                    MySqlDataReader data = cmd.ExecuteReader();

                    //Get the category.
                    while (data.Read())
                    {
                        categories[0] = (string)data["category"];
                        categories[1] = (string)data["type_"];
                    }

                    data.Close();
                    this.Close();

                    return categories;
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
                    this.UknownError("GetCategory", e.Number, e.ErrorCode, e.Code, e.Message);
                }

                //Close the connection.
                this.Close();
            }

            return null;
        }





        //Insert Register.
        public bool InsertRegister(Register register)
        {

            bool ok = false;

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "INSERT INTO registered VALUES ('"+register.category+"', '"+register.type+"', " +
                    register.value.ToString().Replace(",", ".")+", '"+register.date.ToString("yyyy/MM/dd")+"');";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    DialogResult result = MessageBox.Show("Θέλεις σίγουρα να προσθέσεις " + register.value +
                        " ευρό στην κατηγορία " + register.category + "(" + (register.type == "in" ? "Έσοδα" : "Έξοδα") + ") " +
                        " με ημερομηνία " + register.date.ToString("dd/MM/yyyy") + ";", 
                        "Είσαι Σίγουρος;", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                        //Execute the commant.
                        cmd.ExecuteNonQuery();

                        //Show success message.
                        MessageBox.Show("Το Ποσό " + register.value + ", προστέθηκε με επιτυχία για την κατηγορία " + 
                            register.category + " , με ημερομηνία " + register.date.ToString("dd/MM/yyyy"),
                            "Επιτυχής Εισαγωγή", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ok = true;
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
                    this.UknownError("InsertRegister", e.Number, e.ErrorCode, e.Code, e.Message);
                }

                //Close the connection.
                this.Close();
            }

            return ok;
        }





        //Get Analysis.
        public object[] GetAnalysis(string name, string type, DateTime from, DateTime to)
        {

            //Connect to execute command.
            if (this.Connect())
            {

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                //Create the procedure.
                cmd.CommandText = "get_analysis";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add the parameters.
                cmd.Parameters.AddWithValue("in_category_name", name);
                cmd.Parameters.AddWithValue("in_category_type", type);
                cmd.Parameters.AddWithValue("in_date_from", from);
                cmd.Parameters.AddWithValue("in_date_to", to);


                //Try executing the command.
                try
                {

                    //Create an array.
                    object[] objects = new object[2];
                    objects[0]       = null;
                    objects[1]       = null;

                    //Execute the commant.
                    MySqlDataReader data = cmd.ExecuteReader();

                    //Read the data.
                    while (data.Read())
                    {
                        Register r = new Register((string)data["category_name"], (string)data["category_type"],
                            (decimal)data["value_"], (DateTime)data["date_in"]);

                        objects[0] = r;
                        objects[1] = data["total"];
                    }

                    data.Close();
                    this.Close();

                    return objects;
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
                    //Uknown Error.
                    this.UknownError("GetAnalysis", e.Number, e.ErrorCode, e.Code, e.Message);
                }

                //Close the connection.
                this.Close();
            }

            return null;
        }





        //Get Category.
        public List<Register> GetCategoriesByType(string type)
        {

            //Connect to execute command.
            if (this.Connect())
            {
                //Query.
                string q = "SELECT * FROM registered WHERE category_type = '" + type + "';";

                //Create the Command.
                MySqlCommand cmd = new MySqlCommand(q, connection);


                //Try executing the command.
                try
                {

                    //Create the list.
                    List<Register> r_list = new List<Register>();  

                    //Execute the commant.
                    MySqlDataReader data = cmd.ExecuteReader();

                    //Get the category.
                    while (data.Read())
                    {
                        r_list.Add(new Register((string)data["category_name"], (string)data["category_type"],
                            (decimal)data["value_"], (DateTime)data["date_in"]));
                    }

                    //Close everything.
                    data.Close();
                    this.Close();

                    //Return the data.
                    return r_list;
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
                    this.UknownError("GetCategoriesByType", e.Number, e.ErrorCode, e.Code, e.Message);
                }

                //Close the connection.
                this.Close();
            }

            return new List<Register>();
        }
    }
}
