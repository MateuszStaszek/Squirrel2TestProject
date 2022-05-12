namespace Squirrel2
{
    partial class Dashboard
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
            this.PeopleList = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.ageInsLabel = new System.Windows.Forms.Label();
            this.ageInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.IDInsLabel = new System.Windows.Forms.Label();
            this.IDInsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PeopleList
            // 
            this.PeopleList.FormattingEnabled = true;
            this.PeopleList.ItemHeight = 23;
            this.PeopleList.Location = new System.Drawing.Point(31, 229);
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.Size = new System.Drawing.Size(719, 119);
            this.PeopleList.TabIndex = 0;
            this.PeopleList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(122, 109);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(224, 30);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(30, 112);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 23);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(168, 162);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 49);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(30, 398);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(92, 23);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            this.firstNameInsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(122, 395);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(224, 30);
            this.firstNameInsText.TabIndex = 4;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(30, 447);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(86, 23);
            this.lastNameInsLabel.TabIndex = 7;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(122, 444);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(224, 30);
            this.lastNameInsText.TabIndex = 6;
            // 
            // ageInsLabel
            // 
            this.ageInsLabel.AutoSize = true;
            this.ageInsLabel.Location = new System.Drawing.Point(30, 502);
            this.ageInsLabel.Name = "ageInsLabel";
            this.ageInsLabel.Size = new System.Drawing.Size(38, 23);
            this.ageInsLabel.TabIndex = 9;
            this.ageInsLabel.Text = "Age";
            // 
            // ageInsText
            // 
            this.ageInsText.Location = new System.Drawing.Point(122, 499);
            this.ageInsText.Name = "ageInsText";
            this.ageInsText.Size = new System.Drawing.Size(224, 30);
            this.ageInsText.TabIndex = 8;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(168, 564);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(106, 49);
            this.insertRecordButton.TabIndex = 10;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // IDInsLabel
            // 
            this.IDInsLabel.AutoSize = true;
            this.IDInsLabel.Location = new System.Drawing.Point(30, 357);
            this.IDInsLabel.Name = "IDInsLabel";
            this.IDInsLabel.Size = new System.Drawing.Size(31, 23);
            this.IDInsLabel.TabIndex = 12;
            this.IDInsLabel.Text = "ID";
            this.IDInsLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // IDInsText
            // 
            this.IDInsText.Location = new System.Drawing.Point(122, 354);
            this.IDInsText.Name = "IDInsText";
            this.IDInsText.Size = new System.Drawing.Size(224, 30);
            this.IDInsText.TabIndex = 11;
            this.IDInsText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 796);
            this.Controls.Add(this.IDInsLabel);
            this.Controls.Add(this.IDInsText);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.ageInsLabel);
            this.Controls.Add(this.ageInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleList);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.Text = "Squirrel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleList;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label ageInsLabel;
        private System.Windows.Forms.TextBox ageInsText;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label IDInsLabel;
        private System.Windows.Forms.TextBox IDInsText;
    }
}

