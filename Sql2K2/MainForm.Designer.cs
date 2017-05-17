namespace Sql2K2
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chColumns = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateContent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCustomeQuery = new System.Windows.Forms.RichTextBox();
            this.chUseSqlStringNotation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(754, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionString.Location = new System.Drawing.Point(79, 14);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(669, 20);
            this.tbConnectionString.TabIndex = 2;
            this.tbConnectionString.TextChanged += new System.EventHandler(this.tbConnectionString_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tables";
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(79, 51);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(750, 21);
            this.cmbTables.TabIndex = 10;
            this.cmbTables.Leave += new System.EventHandler(this.cmbTables_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Columns";
            // 
            // chColumns
            // 
            this.chColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chColumns.FormattingEnabled = true;
            this.chColumns.Location = new System.Drawing.Point(79, 91);
            this.chColumns.Name = "chColumns";
            this.chColumns.Size = new System.Drawing.Size(750, 154);
            this.chColumns.TabIndex = 13;
            // 
            // btnGenerateContent
            // 
            this.btnGenerateContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateContent.Location = new System.Drawing.Point(705, 546);
            this.btnGenerateContent.Name = "btnGenerateContent";
            this.btnGenerateContent.Size = new System.Drawing.Size(124, 23);
            this.btnGenerateContent.TabIndex = 14;
            this.btnGenerateContent.Text = "&Generate content";
            this.btnGenerateContent.UseVisualStyleBackColor = true;
            this.btnGenerateContent.Click += new System.EventHandler(this.btnGenerateContent_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(20, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Output template";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(79, 429);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(750, 111);
            this.tbOutput.TabIndex = 16;
            this.tbOutput.Text = "Use double curly braces instead one, and keep the single for the place holders\n{{" +
    "\n \"id\": \"{0}\"\n}},";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Or custom query";
            // 
            // tbCustomeQuery
            // 
            this.tbCustomeQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomeQuery.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tbCustomeQuery.Location = new System.Drawing.Point(79, 251);
            this.tbCustomeQuery.Name = "tbCustomeQuery";
            this.tbCustomeQuery.Size = new System.Drawing.Size(750, 170);
            this.tbCustomeQuery.TabIndex = 19;
            this.tbCustomeQuery.Text = "";
            this.tbCustomeQuery.TextChanged += new System.EventHandler(this.tbCustomeQuery_TextChanged);
            // 
            // chUseSqlStringNotation
            // 
            this.chUseSqlStringNotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chUseSqlStringNotation.AutoSize = true;
            this.chUseSqlStringNotation.Location = new System.Drawing.Point(514, 550);
            this.chUseSqlStringNotation.Name = "chUseSqlStringNotation";
            this.chUseSqlStringNotation.Size = new System.Drawing.Size(185, 17);
            this.chUseSqlStringNotation.TabIndex = 20;
            this.chUseSqlStringNotation.Text = "&Use Sql string notation ( N\'value\' )";
            this.chUseSqlStringNotation.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 581);
            this.Controls.Add(this.chUseSqlStringNotation);
            this.Controls.Add(this.tbCustomeQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerateContent);
            this.Controls.Add(this.chColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Icon = global::Sql2K2.Properties.Resources.database_export;
            this.Name = "MainForm";
            this.Text = "SQL2K2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chColumns;
        private System.Windows.Forms.Button btnGenerateContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbCustomeQuery;
        private System.Windows.Forms.CheckBox chUseSqlStringNotation;
    }
}

