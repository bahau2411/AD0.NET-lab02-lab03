namespace Lab02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.stdDataGridView = new System.Windows.Forms.DataGridView();
            this.studentBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.classIDBox = new System.Windows.Forms.TextBox();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdDataGridView)).BeginInit();
            this.studentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stdDataGridView);
            this.panel2.Location = new System.Drawing.Point(2, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 330);
            this.panel2.TabIndex = 1;
            // 
            // stdDataGridView
            // 
            this.stdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdDataGridView.Location = new System.Drawing.Point(0, 0);
            this.stdDataGridView.Name = "stdDataGridView";
            this.stdDataGridView.RowHeadersWidth = 51;
            this.stdDataGridView.RowTemplate.Height = 29;
            this.stdDataGridView.Size = new System.Drawing.Size(492, 330);
            this.stdDataGridView.TabIndex = 0;
            this.stdDataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.stdDataGridView_CellStateChanged);
            // 
            // studentBox
            // 
            this.studentBox.Controls.Add(this.label3);
            this.studentBox.Controls.Add(this.label2);
            this.studentBox.Controls.Add(this.deleteBtn);
            this.studentBox.Controls.Add(this.updateBtn);
            this.studentBox.Controls.Add(this.insertBtn);
            this.studentBox.Controls.Add(this.classIDBox);
            this.studentBox.Controls.Add(this.studentNameBox);
            this.studentBox.Controls.Add(this.studentIDBox);
            this.studentBox.Controls.Add(this.label1);
            this.studentBox.Location = new System.Drawing.Point(500, 65);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(473, 403);
            this.studentBox.TabIndex = 0;
            this.studentBox.TabStop = false;
            this.studentBox.Text = "Student Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Name";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(330, 293);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 42);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(181, 293);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 42);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(26, 293);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(105, 42);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // classIDBox
            // 
            this.classIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classIDBox.Location = new System.Drawing.Point(191, 207);
            this.classIDBox.Name = "classIDBox";
            this.classIDBox.Size = new System.Drawing.Size(232, 34);
            this.classIDBox.TabIndex = 3;
            // 
            // studentNameBox
            // 
            this.studentNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameBox.Location = new System.Drawing.Point(191, 128);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(232, 34);
            this.studentNameBox.TabIndex = 2;
            // 
            // studentIDBox
            // 
            this.studentIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentIDBox.Location = new System.Drawing.Point(191, 55);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(232, 34);
            this.studentIDBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(168, 65);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(140, 49);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 480);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stdDataGridView)).EndInit();
            this.studentBox.ResumeLayout(false);
            this.studentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private DataGridView stdDataGridView;
        private GroupBox studentBox;
        private Label label3;
        private Label label2;
        private Button deleteBtn;
        private Button updateBtn;
        private Button insertBtn;
        private TextBox classIDBox;
        private TextBox studentNameBox;
        private TextBox studentIDBox;
        private Label label1;
        private Button loadBtn;
    }
}