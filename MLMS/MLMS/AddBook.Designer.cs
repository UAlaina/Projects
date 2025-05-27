namespace MLMS
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.availabailityLabel = new System.Windows.Forms.Label();
            this.availabilityComboBox = new System.Windows.Forms.ComboBox();
            this.publishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.availabailityLabel);
            this.groupBox1.Controls.Add(this.availabilityComboBox);
            this.groupBox1.Controls.Add(this.publishDateTimePicker);
            this.groupBox1.Controls.Add(this.editionTextBox);
            this.groupBox1.Controls.Add(this.authorTextBox);
            this.groupBox1.Controls.Add(this.ISBNtextBox);
            this.groupBox1.Controls.Add(this.descriptionRichTextBox);
            this.groupBox1.Controls.Add(this.bookTextBox);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ISBNLabel);
            this.groupBox1.Controls.Add(this.bookLabel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // availabailityLabel
            // 
            resources.ApplyResources(this.availabailityLabel, "availabailityLabel");
            this.availabailityLabel.Name = "availabailityLabel";
            // 
            // availabilityComboBox
            // 
            resources.ApplyResources(this.availabilityComboBox, "availabilityComboBox");
            this.availabilityComboBox.FormattingEnabled = true;
            this.availabilityComboBox.Items.AddRange(new object[] {
            resources.GetString("availabilityComboBox.Items"),
            resources.GetString("availabilityComboBox.Items1")});
            this.availabilityComboBox.Name = "availabilityComboBox";
            // 
            // publishDateTimePicker
            // 
            resources.ApplyResources(this.publishDateTimePicker, "publishDateTimePicker");
            this.publishDateTimePicker.Name = "publishDateTimePicker";
            this.publishDateTimePicker.ValueChanged += new System.EventHandler(this.publishDateTimePicker_ValueChanged);
            // 
            // editionTextBox
            // 
            resources.ApplyResources(this.editionTextBox, "editionTextBox");
            this.editionTextBox.Name = "editionTextBox";
            // 
            // authorTextBox
            // 
            resources.ApplyResources(this.authorTextBox, "authorTextBox");
            this.authorTextBox.Name = "authorTextBox";
            // 
            // ISBNtextBox
            // 
            resources.ApplyResources(this.ISBNtextBox, "ISBNtextBox");
            this.ISBNtextBox.Name = "ISBNtextBox";
            // 
            // descriptionRichTextBox
            // 
            resources.ApplyResources(this.descriptionRichTextBox, "descriptionRichTextBox");
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            // 
            // bookTextBox
            // 
            resources.ApplyResources(this.bookTextBox, "bookTextBox");
            this.bookTextBox.Name = "bookTextBox";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.BackColor = System.Drawing.Color.Salmon;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ISBNLabel
            // 
            resources.ApplyResources(this.ISBNLabel, "ISBNLabel");
            this.ISBNLabel.Name = "ISBNLabel";
            // 
            // bookLabel
            // 
            resources.ApplyResources(this.bookLabel, "bookLabel");
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Click += new System.EventHandler(this.bookLabel_Click);
            // 
            // AddBook
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBook";
            this.Load += new System.EventHandler(this.addBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label availabailityLabel;
        private System.Windows.Forms.ComboBox availabilityComboBox;
        private System.Windows.Forms.DateTimePicker publishDateTimePicker;
        private System.Windows.Forms.TextBox editionTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label bookLabel;
    }
}

