namespace MegaDesk_3_AbigailKing
{
    partial class ViewAllQuotes
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
            this.btnCancelViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelViewAll
            // 
            this.btnCancelViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelViewAll.Location = new System.Drawing.Point(443, 281);
            this.btnCancelViewAll.Name = "btnCancelViewAll";
            this.btnCancelViewAll.Size = new System.Drawing.Size(246, 80);
            this.btnCancelViewAll.TabIndex = 0;
            this.btnCancelViewAll.Text = "Cancel";
            this.btnCancelViewAll.UseVisualStyleBackColor = true;
            this.btnCancelViewAll.Click += new System.EventHandler(this.btnCancelViewAll_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelViewAll);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelViewAll;
    }
}