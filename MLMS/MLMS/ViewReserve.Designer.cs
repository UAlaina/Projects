namespace MLMS
{
    partial class ViewReserve
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReserve));
            this.currentReserveButton = new System.Windows.Forms.Button();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet = new MLMS.LibraryDataSet();
            this.reserveBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveBooksTableAdapter = new MLMS.LibraryDataSetTableAdapters.ReserveBooksTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentReserveButton
            // 
            resources.ApplyResources(this.currentReserveButton, "currentReserveButton");
            this.currentReserveButton.BackColor = System.Drawing.Color.Salmon;
            this.currentReserveButton.ForeColor = System.Drawing.Color.White;
            this.currentReserveButton.Name = "currentReserveButton";
            this.currentReserveButton.UseVisualStyleBackColor = false;
            this.currentReserveButton.Click += new System.EventHandler(this.currentReserveButton_Click);
            // 
            // memberNameLabel
            // 
            resources.ApplyResources(this.memberNameLabel, "memberNameLabel");
            this.memberNameLabel.ForeColor = System.Drawing.Color.Black;
            this.memberNameLabel.Name = "memberNameLabel";
            // 
            // memberNameTextBox
            // 
            resources.ApplyResources(this.memberNameTextBox, "memberNameTextBox");
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.TextChanged += new System.EventHandler(this.memberNameTextBob_TextChanged);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reserveBooksBindingSource
            // 
            this.reserveBooksBindingSource.DataMember = "ReserveBooks";
            this.reserveBooksBindingSource.DataSource = this.libraryDataSet;
            // 
            // reserveBooksTableAdapter
            // 
            this.reserveBooksTableAdapter.ClearBeforeFill = true;
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
            // ViewReserve
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.memberNameTextBox);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.currentReserveButton);
            this.Name = "ViewReserve";
            this.Load += new System.EventHandler(this.ViewReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button currentReserveButton;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource reserveBooksBindingSource;
        private LibraryDataSetTableAdapters.ReserveBooksTableAdapter reserveBooksTableAdapter;
        private System.Windows.Forms.Button backButton;
    }
}