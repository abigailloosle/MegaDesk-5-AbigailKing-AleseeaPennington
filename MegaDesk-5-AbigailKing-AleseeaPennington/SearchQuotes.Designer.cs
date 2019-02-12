namespace MegaDesk_3_AbigailKing
{
    partial class SearchQuotes
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
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboSurfaceSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.Location = new System.Drawing.Point(737, 487);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(333, 108);
            this.btnCancelSearch.TabIndex = 0;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1124, 369);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Based off of Surface Material";
            // 
            // comboSurfaceSearch
            // 
            this.comboSurfaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSurfaceSearch.FormattingEnabled = true;
            this.comboSurfaceSearch.Location = new System.Drawing.Point(317, 23);
            this.comboSurfaceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.comboSurfaceSearch.Name = "comboSurfaceSearch";
            this.comboSurfaceSearch.Size = new System.Drawing.Size(359, 44);
            this.comboSurfaceSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(703, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(197, 52);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 622);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboSurfaceSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboSurfaceSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}