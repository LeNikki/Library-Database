using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sabanal_Satiembre_BookDB
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = localhost; Database = db_book; Uid = root; Pwd = #729SaturnJupiter;";
        int BookID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            if (txtCourseNo.Text == "" || txtCourseNo.Text == "FUN")
            {
                DialogResult dialog = MessageBox.Show("Confirm: Blank course will be set to FUN", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        MySqlCommand mySqlCmd = new MySqlCommand("AddOrEdit", mysqlCon);
                        mySqlCmd.CommandType = CommandType.StoredProcedure;
                        mySqlCmd.Parameters.AddWithValue("_BookID", BookID);
                        mySqlCmd.Parameters.AddWithValue("_ISBN_No", txtISBN_No.Text.Trim());
                        mySqlCmd.Parameters.AddWithValue("_Title", txtTitle.Text.Trim());
                        mySqlCmd.Parameters.AddWithValue("_Copyright_Date", txtCD.Text.Trim());
                        mySqlCmd.Parameters.AddWithValue("_Publisher", txtPub.Text.Trim());
                        mySqlCmd.Parameters.AddWithValue("_Primary_Author", txtPrimAuthor.Text.Trim());
                        mySqlCmd.Parameters.AddWithValue("_Pages", txtPages.Text.Trim());
                        if (txtCourseNo.Text == "")
                        {
                            MessageBox.Show("Course will be set to FUN.", "Saving...");
                            txtCourseNo.Text = "FUN";
                        }
                        mySqlCmd.Parameters.AddWithValue("_Course_No", txtCourseNo.Text.Trim());
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Submitted Successfully");
                        GridFill();
                        GridFillTwo();
                    }
                }
            }
            else { }

                throw new ArgumentException("Do not leave any blanks. As for course, blanks will be set to FUN");
            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            //catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (MySql.Data.MySqlClient.MySqlException ex){MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}


            finally { }
        }

        void GridFill()
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAll", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblBook = new DataTable();
                    sqlDa.Fill(dtblBook);
                    dgvBook.DataSource = dtblBook;

                    /*HIDE*/
                    dgvBook.Columns[0].Visible = false;  //BookID
                    dgvBook.Columns[7].Visible = false;  //Course_No
                }
            }
            catch (System.ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }
        void GridFillTwo() //README
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAll", mysqlCon);  //if naka viewall tanan makita but if naka ViewCourseBooks 
                                                                                         //ang ISBN ray makita kay siya may last sa SELECT Course_No, ISBN_No, unlike sa view all nga naka SELECT *
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblBook2 = new DataTable();
                    sqlDa.Fill(dtblBook2);
                    dataGridView2.DataSource = dtblBook2;

                    /*Hide = false; Show = true */
                    dataGridView2.Columns[0].Visible = false;  //BookID
                    dataGridView2.Columns[1].Visible = true;   //ISBN_No
                    dataGridView2.Columns[2].Visible = false;   //Title
                    dataGridView2.Columns[3].Visible = false;   //CD
                    dataGridView2.Columns[4].Visible = false;   //Publisher
                    dataGridView2.Columns[5].Visible = false;   //PrimAuthor
                    dataGridView2.Columns[6].Visible = false;   //Pages
                    dataGridView2.Columns[7].Visible = true;   //Course_No


                }
            }
            catch (System.ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
            GridFillTwo();

        }
        void Clear()
        {
            txtISBN_No.Text = txtTitle.Text = txtCD.Text = txtPub.Text = txtPrimAuthor.Text = txtPages.Text = txtCourseNo.Text = txtSearch.Text = "";
            BookID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e) //updates new description
        {
            try
            {
                if (dgvBook.CurrentRow.Index != -1)
                {
                    txtISBN_No.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                    txtTitle.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                    txtCD.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
                    txtPub.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
                    txtPrimAuthor.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
                    txtPages.Text = dgvBook.CurrentRow.Cells[6].Value.ToString();
                    
                    BookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
                    btnSave.Text = "Update";
                    btnDelete.Enabled = Enabled; //new
                }
            }
            catch (System.FormatException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow.Index != -1)
                {
                    //continuation
                    txtISBN_No.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    txtCourseNo.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

                    BookID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    btnSave.Text = "Update";
                    btnDelete.Enabled = Enabled; //delete allowed
                }
            }
            catch (System.FormatException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }

        private void btnSearch_Click(object sender, EventArgs e) //will show books with same keyword
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchByVal", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                    DataTable dtblBook = new DataTable();
                    sqlDa.Fill(dtblBook);
                    dgvBook.DataSource = dtblBook;

                    dgvBook.Columns[0].Visible = false;
                }
            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e) //highlights when double clicked 
        {
            DialogResult dialog = MessageBox.Show("Confirm delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("DelByID", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_BookID", BookID);
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    Clear();
                    GridFill();
                    GridFillTwo();
                }
            }
            else { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
               //form closes
            }
            else
            {
                e.Cancel = true;
            }
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copyright_Date_Click(object sender, EventArgs e)
        {

        }

        private void Publisher_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
