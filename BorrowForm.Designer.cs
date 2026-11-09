namespace LibraryMS
{
    partial class BorrowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.membercombo = new System.Windows.Forms.ComboBox();
            this.bookcombo = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.borrowDataGridView = new System.Windows.Forms.DataGridView();
            this.borrowid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Title";
            // 
            // membercombo
            // 
            this.membercombo.Font = new System.Drawing.Font("SimSun", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.membercombo.FormattingEnabled = true;
            this.membercombo.Location = new System.Drawing.Point(298, 86);
            this.membercombo.Name = "membercombo";
            this.membercombo.Size = new System.Drawing.Size(207, 32);
            this.membercombo.TabIndex = 3;
            // 
            // bookcombo
            // 
            this.bookcombo.Font = new System.Drawing.Font("SimSun", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookcombo.FormattingEnabled = true;
            this.bookcombo.Location = new System.Drawing.Point(298, 146);
            this.bookcombo.Name = "bookcombo";
            this.bookcombo.Size = new System.Drawing.Size(207, 32);
            this.bookcombo.TabIndex = 4;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("SimSun", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savebtn.Location = new System.Drawing.Point(626, 73);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(111, 31);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("SimSun", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updatebtn.Location = new System.Drawing.Point(626, 131);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(111, 34);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("SimSun", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deletebtn.Location = new System.Drawing.Point(626, 200);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(111, 29);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // borrowDataGridView
            // 
            this.borrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDataGridView.Location = new System.Drawing.Point(12, 252);
            this.borrowDataGridView.Name = "borrowDataGridView";
            this.borrowDataGridView.RowHeadersWidth = 45;
            this.borrowDataGridView.RowTemplate.Height = 24;
            this.borrowDataGridView.Size = new System.Drawing.Size(776, 186);
            this.borrowDataGridView.TabIndex = 8;
            // 
            // borrowid
            // 
            this.borrowid.Location = new System.Drawing.Point(603, 18);
            this.borrowid.Name = "borrowid";
            this.borrowid.Size = new System.Drawing.Size(100, 22);
            this.borrowid.TabIndex = 9;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borrowid);
            this.Controls.Add(this.borrowDataGridView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.bookcombo);
            this.Controls.Add(this.membercombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox membercombo;
        private System.Windows.Forms.ComboBox bookcombo;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView borrowDataGridView;
        private System.Windows.Forms.TextBox borrowid;
    }
}