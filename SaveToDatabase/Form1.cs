using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.Utils;

namespace SaveToDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertPositionen()
        {
            //using the using statement you will insure that the connection is closed and resources released
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db))
            {
                string cmd = "INSERT INTO BelegePositionen (BelID, BelPosId, Artikelnummer, Menge, Preis) " +
                 "VALUES(@BelId, @BelPosId, @ArtNr, @Menge, @Preis);";

                //using the using statement will ensure any reasources are released when exiting the code block
                using (SqlCommand insert = new SqlCommand(cmd, connection))
                {
                    // define the parameters
                    insert.Parameters.Add("@BelId", SqlDbType.Int);
                    insert.Parameters.Add("@BelPosId", SqlDbType.Int);
                    insert.Parameters.Add("@ArtNr", SqlDbType.Int);  // maybe this is a string? 
                    insert.Parameters.Add("@Menge", SqlDbType.Int);
                    insert.Parameters.Add("@Preis", SqlDbType.Decimal, 20, "4");

                    try
                    {
                        //open the connection
                        insert.Connection.Open();

                        // in the loop, only *set* the parameter's values
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            insert.Parameters["@BelId"].Value = dataGridView1.Rows[i].Cells["BelID"];
                            insert.Parameters["@BelPosId"].Value = dataGridView1.Rows[i].Cells["BelPosId"];
                            insert.Parameters["@ArtNr"].Value = dataGridView1.Rows[i].Cells["Artikelnummer"];
                            insert.Parameters["@Menge"].Value = dataGridView1.Rows[i].Cells["Menge"];
                            insert.Parameters["@Preis"].Value = dataGridView1.Rows[i].Cells["Preis"];

                            insert.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Done!");
                    }
                }
            }
        }

        private void UpdatePositionen()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db))
            {
                string cmd = "INSERT INTO BelegePositionen (BelID, BelPosId, Artikelnummer, Menge, Preis) " +
                 "VALUES(@BelId, @BelPosId, @ArtNr, @Menge, @Preis);";

                using (SqlCommand insert = new SqlCommand(cmd, connection))
                {
                    // define the parameters
                    insert.Parameters.Add("@BelId", SqlDbType.Int);
                    insert.Parameters.Add("@BelPosId", SqlDbType.Int);
                    insert.Parameters.Add("@ArtNr", SqlDbType.Int);  // maybe this is a string? 
                    insert.Parameters.Add("@Menge", SqlDbType.Int);
                    insert.Parameters.Add("@Preis", SqlDbType.Decimal, 20, "4");

                    try
                    {
                        //open the connection
                        insert.Connection.Open();

                        // in the loop, only *set* the parameter's values
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            insert.Parameters["@BelId"].Value = 1;
                            insert.Parameters["@BelPosId"].Value = 2;
                            insert.Parameters["@ArtNr"].Value = 3;
                            insert.Parameters["@Menge"].Value = 4;
                            insert.Parameters["@Preis"].Value = 99.95;

                            insert.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Done!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertPositionen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sOQuestionsDataSet.BelegePositionen' table. You can move, or remove it, as needed.
            this.belegePositionenTableAdapter.Fill(this.sOQuestionsDataSet.BelegePositionen);

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            VScrollBar scrollBar = null;
            if (textBox1.ScrollBars.HasAnyFlag(ScrollBars.Vertical))
            {
                foreach (var ctrl in textBox1.Controls)
                {
                    if (ctrl is VScrollBar vScroll)
                        scrollBar = vScroll;

                }
            }
        }
    }
}
