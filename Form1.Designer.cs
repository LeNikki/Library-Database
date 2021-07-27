
namespace Sabanal_Satiembre_BookDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ISBN_No = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtISBN_No = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Copyright_Date = new System.Windows.Forms.Button();
            this.Primary_Author = new System.Windows.Forms.Button();
            this.Publisher = new System.Windows.Forms.Button();
            this.Pages = new System.Windows.Forms.Button();
            this.Course_No = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtPrimAuthor = new System.Windows.Forms.TextBox();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(755, 86);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(321, 330);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(684, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(349, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 28);
            this.txtSearch.TabIndex = 2;
            // 
            // ISBN_No
            // 
            this.ISBN_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.ISBN_No.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ISBN_No.Location = new System.Drawing.Point(351, 86);
            this.ISBN_No.Name = "ISBN_No";
            this.ISBN_No.Size = new System.Drawing.Size(120, 38);
            this.ISBN_No.TabIndex = 3;
            this.ISBN_No.Text = "ISBN No";
            this.ISBN_No.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(349, 130);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(120, 35);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title";
            this.Title.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(383, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtISBN_No
            // 
            this.txtISBN_No.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN_No.Location = new System.Drawing.Point(489, 86);
            this.txtISBN_No.Name = "txtISBN_No";
            this.txtISBN_No.Size = new System.Drawing.Size(250, 28);
            this.txtISBN_No.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(489, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(603, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Copyright_Date
            // 
            this.Copyright_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Copyright_Date.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Copyright_Date.Location = new System.Drawing.Point(351, 171);
            this.Copyright_Date.Name = "Copyright_Date";
            this.Copyright_Date.Size = new System.Drawing.Size(120, 36);
            this.Copyright_Date.TabIndex = 9;
            this.Copyright_Date.Text = "Copyright Date";
            this.Copyright_Date.UseVisualStyleBackColor = false;
            this.Copyright_Date.Click += new System.EventHandler(this.Copyright_Date_Click);
            // 
            // Primary_Author
            // 
            this.Primary_Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Primary_Author.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primary_Author.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Primary_Author.Location = new System.Drawing.Point(351, 213);
            this.Primary_Author.Name = "Primary_Author";
            this.Primary_Author.Size = new System.Drawing.Size(120, 34);
            this.Primary_Author.TabIndex = 10;
            this.Primary_Author.Text = "Primary Author";
            this.Primary_Author.UseVisualStyleBackColor = false;
            // 
            // Publisher
            // 
            this.Publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Publisher.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Publisher.Location = new System.Drawing.Point(351, 291);
            this.Publisher.Margin = new System.Windows.Forms.Padding(0);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(120, 32);
            this.Publisher.TabIndex = 11;
            this.Publisher.Text = "Publisher";
            this.Publisher.UseVisualStyleBackColor = false;
            this.Publisher.Click += new System.EventHandler(this.Publisher_Click);
            // 
            // Pages
            // 
            this.Pages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Pages.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pages.Location = new System.Drawing.Point(351, 253);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(120, 35);
            this.Pages.TabIndex = 12;
            this.Pages.Text = "Pages";
            this.Pages.UseVisualStyleBackColor = false;
            // 
            // Course_No
            // 
            this.Course_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.Course_No.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Course_No.Location = new System.Drawing.Point(351, 326);
            this.Course_No.Name = "Course_No";
            this.Course_No.Size = new System.Drawing.Size(120, 33);
            this.Course_No.TabIndex = 13;
            this.Course_No.Text = "Course No";
            this.Course_No.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(489, 130);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 28);
            this.txtTitle.TabIndex = 14;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtCD
            // 
            this.txtCD.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCD.Location = new System.Drawing.Point(489, 175);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(250, 28);
            this.txtCD.TabIndex = 15;
            // 
            // txtPrimAuthor
            // 
            this.txtPrimAuthor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimAuthor.Location = new System.Drawing.Point(489, 217);
            this.txtPrimAuthor.Name = "txtPrimAuthor";
            this.txtPrimAuthor.Size = new System.Drawing.Size(250, 28);
            this.txtPrimAuthor.TabIndex = 16;
            this.txtPrimAuthor.TextChanged += new System.EventHandler(this.txtPrimAuthor_TextChanged);
            // 
            // txtPub
            // 
            this.txtPub.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPub.Location = new System.Drawing.Point(489, 257);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(250, 28);
            this.txtPub.TabIndex = 17;
            this.txtPub.TextChanged += new System.EventHandler(this.txtPub_TextChanged);
            // 
            // txtPages
            // 
            this.txtPages.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPages.Location = new System.Drawing.Point(489, 295);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(250, 28);
            this.txtPages.TabIndex = 18;
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNo.Location = new System.Drawing.Point(489, 331);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.Size = new System.Drawing.Size(250, 28);
            this.txtCourseNo.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(314, 330);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::Sabanal_Satiembre_BookDB.Properties.Resources.library;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtISBN_No);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dgvBook);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtCourseNo);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.Course_No);
            this.panel1.Controls.Add(this.txtPages);
            this.panel1.Controls.Add(this.ISBN_No);
            this.panel1.Controls.Add(this.txtPub);
            this.panel1.Controls.Add(this.Pages);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.txtPrimAuthor);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.Publisher);
            this.panel1.Controls.Add(this.txtCD);
            this.panel1.Controls.Add(this.Copyright_Date);
            this.panel1.Controls.Add(this.Primary_Author);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 462);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(96, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Course Books";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Location = new System.Drawing.Point(834, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 41);
            this.button2.TabIndex = 22;
            this.button2.Text = "Book Table";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Online Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button ISBN_No;
        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtISBN_No;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Copyright_Date;
        private System.Windows.Forms.Button Primary_Author;
        private System.Windows.Forms.Button Publisher;
        private System.Windows.Forms.Button Pages;
        private System.Windows.Forms.Button Course_No;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtPrimAuthor;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtCourseNo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

