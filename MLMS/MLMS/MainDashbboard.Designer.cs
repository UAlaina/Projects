namespace MLMS2
{
    partial class MainDashbboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashbboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputsuggestionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.suggestionLlabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.comboBoxLanguage);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.paymentButton);
            this.groupBox1.Controls.Add(this.reserveButton);
            this.groupBox1.Controls.Add(this.memberButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.ForeColor = System.Drawing.Color.White;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguage.Items"),
            resources.GetString("comboBoxLanguage.Items1")});
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.paymentButton, "paymentButton");
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.reserveButton, "reserveButton");
            this.reserveButton.ForeColor = System.Drawing.Color.White;
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.memberButton, "memberButton");
            this.memberButton.ForeColor = System.Drawing.Color.White;
            this.memberButton.Name = "memberButton";
            this.memberButton.UseVisualStyleBackColor = false;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Peru;
            this.groupBox2.Controls.Add(this.inputsuggestionRichTextBox);
            this.groupBox2.Controls.Add(this.suggestionLlabel);
            this.groupBox2.Controls.Add(this.contactLabel);
            this.groupBox2.Controls.Add(this.emailLabel);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // inputsuggestionRichTextBox
            // 
            this.inputsuggestionRichTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputsuggestionRichTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.inputsuggestionRichTextBox, "inputsuggestionRichTextBox");
            this.inputsuggestionRichTextBox.Name = "inputsuggestionRichTextBox";
            // 
            // suggestionLlabel
            // 
            resources.ApplyResources(this.suggestionLlabel, "suggestionLlabel");
            this.suggestionLlabel.Name = "suggestionLlabel";
            // 
            // contactLabel
            // 
            resources.ApplyResources(this.contactLabel, "contactLabel");
            this.contactLabel.Name = "contactLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // MainDashbboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainDashbboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox inputsuggestionRichTextBox;
        private System.Windows.Forms.Label suggestionLlabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}