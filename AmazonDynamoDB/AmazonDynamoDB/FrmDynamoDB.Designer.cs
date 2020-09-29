namespace AmazonDynamoDB
{
    partial class FrmDynamoDB
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
            this.BtnInsert = new System.Windows.Forms.Button();
            this.PnlInsert = new System.Windows.Forms.Panel();
            this.BtnCancel1 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtClassName = new System.Windows.Forms.TextBox();
            this.TxtCollegeName = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.BtnCancel2 = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.PnlInsert.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(273, 199);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(233, 45);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.Text = "Insert Student";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // PnlInsert
            // 
            this.PnlInsert.Controls.Add(this.BtnCancel1);
            this.PnlInsert.Controls.Add(this.BtnSave);
            this.PnlInsert.Controls.Add(this.TxtClassName);
            this.PnlInsert.Controls.Add(this.TxtCollegeName);
            this.PnlInsert.Controls.Add(this.TxtStudentName);
            this.PnlInsert.Controls.Add(this.label3);
            this.PnlInsert.Controls.Add(this.label2);
            this.PnlInsert.Controls.Add(this.label1);
            this.PnlInsert.Location = new System.Drawing.Point(107, 77);
            this.PnlInsert.Margin = new System.Windows.Forms.Padding(2);
            this.PnlInsert.Name = "PnlInsert";
            this.PnlInsert.Size = new System.Drawing.Size(553, 400);
            this.PnlInsert.TabIndex = 6;
            this.PnlInsert.Visible = false;
            // 
            // BtnCancel1
            // 
            this.BtnCancel1.Location = new System.Drawing.Point(328, 252);
            this.BtnCancel1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel1.Name = "BtnCancel1";
            this.BtnCancel1.Size = new System.Drawing.Size(167, 41);
            this.BtnCancel1.TabIndex = 7;
            this.BtnCancel1.Text = "Cancel";
            this.BtnCancel1.UseVisualStyleBackColor = true;
            this.BtnCancel1.Click += new System.EventHandler(this.BtnCancel1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(50, 252);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(167, 41);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtClassName
            // 
            this.TxtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClassName.Location = new System.Drawing.Point(194, 170);
            this.TxtClassName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(228, 23);
            this.TxtClassName.TabIndex = 5;
            // 
            // TxtCollegeName
            // 
            this.TxtCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCollegeName.Location = new System.Drawing.Point(194, 113);
            this.TxtCollegeName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCollegeName.Name = "TxtCollegeName";
            this.TxtCollegeName.Size = new System.Drawing.Size(228, 23);
            this.TxtCollegeName.TabIndex = 4;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStudentName.Location = new System.Drawing.Point(194, 67);
            this.TxtStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(228, 23);
            this.TxtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "College Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.BtnCancel2);
            this.PnlGrid.Controls.Add(this.DGV);
            this.PnlGrid.Location = new System.Drawing.Point(34, 56);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(704, 459);
            this.PnlGrid.TabIndex = 7;
            this.PnlGrid.Visible = false;
            // 
            // BtnCancel2
            // 
            this.BtnCancel2.Location = new System.Drawing.Point(572, 406);
            this.BtnCancel2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel2.Name = "BtnCancel2";
            this.BtnCancel2.Size = new System.Drawing.Size(105, 39);
            this.BtnCancel2.TabIndex = 1;
            this.BtnCancel2.Text = "Cancel";
            this.BtnCancel2.UseVisualStyleBackColor = true;
            this.BtnCancel2.Click += new System.EventHandler(this.BtnCancel2_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(26, 50);
            this.DGV.Margin = new System.Windows.Forms.Padding(2);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(651, 343);
            this.DGV.TabIndex = 0;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(273, 267);
            this.BtnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(233, 45);
            this.BtnDisplay.TabIndex = 8;
            this.BtnDisplay.Text = "Display Students";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // FrmDynamoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 570);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlInsert);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.BtnInsert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDynamoDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon DynamoDB With .NET";
            this.Load += new System.EventHandler(this.FrmDynamoDB_Load);
            this.PnlInsert.ResumeLayout(false);
            this.PnlInsert.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Panel PnlInsert;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtClassName;
        private System.Windows.Forms.TextBox TxtCollegeName;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.Button BtnCancel1;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BtnCancel2;
    }
}

