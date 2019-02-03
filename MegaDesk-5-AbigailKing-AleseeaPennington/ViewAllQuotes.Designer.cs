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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Quote_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surface_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quote_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelViewAll
            // 
            this.btnCancelViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelViewAll.Location = new System.Drawing.Point(513, 358);
            this.btnCancelViewAll.Name = "btnCancelViewAll";
            this.btnCancelViewAll.Size = new System.Drawing.Size(246, 80);
            this.btnCancelViewAll.TabIndex = 0;
            this.btnCancelViewAll.Text = "Cancel";
            this.btnCancelViewAll.UseVisualStyleBackColor = true;
            this.btnCancelViewAll.Click += new System.EventHandler(this.btnCancelViewAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quote_Date,
            this.Customer_Name,
            this.desk_Width,
            this.desk_Depth,
            this.num_Drawers,
            this.surface_Material,
            this.delivery,
            this.quote_Amount});
            this.dataGridView1.Location = new System.Drawing.Point(31, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // Quote_Date
            // 
            this.Quote_Date.HeaderText = "Quote Date";
            this.Quote_Date.Name = "Quote_Date";
            // 
            // Customer_Name
            // 
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            // 
            // desk_Width
            // 
            this.desk_Width.HeaderText = "Desk Width";
            this.desk_Width.Name = "desk_Width";
            // 
            // desk_Depth
            // 
            this.desk_Depth.HeaderText = "Desk Depth";
            this.desk_Depth.Name = "desk_Depth";
            // 
            // num_Drawers
            // 
            this.num_Drawers.HeaderText = "Number of Drawers";
            this.num_Drawers.Name = "num_Drawers";
            // 
            // surface_Material
            // 
            this.surface_Material.HeaderText = "Surface Material";
            this.surface_Material.Name = "surface_Material";
            // 
            // delivery
            // 
            this.delivery.HeaderText = "Delivery Type";
            this.delivery.Name = "delivery";
            // 
            // quote_Amount
            // 
            this.quote_Amount.HeaderText = "Desk Price";
            this.quote_Amount.Name = "quote_Amount";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelViewAll);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelViewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quote_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surface_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn quote_Amount;
    }
}