
namespace GroceryExpenseTracker
{
    partial class PurchaseListWindow
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
            this.dgPurchaseList = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarketName = new System.Windows.Forms.Label();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.tbMarketName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPurchaseList
            // 
            this.dgPurchaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPurchaseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.QTY,
            this.Price,
            this.Total});
            this.dgPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgPurchaseList.EnableHeadersVisualStyles = false;
            this.dgPurchaseList.Location = new System.Drawing.Point(9, 31);
            this.dgPurchaseList.Margin = new System.Windows.Forms.Padding(2);
            this.dgPurchaseList.Name = "dgPurchaseList";
            this.dgPurchaseList.RowHeadersVisible = false;
            this.dgPurchaseList.RowHeadersWidth = 51;
            this.dgPurchaseList.RowTemplate.Height = 24;
            this.dgPurchaseList.Size = new System.Drawing.Size(582, 297);
            this.dgPurchaseList.TabIndex = 0;
            this.dgPurchaseList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseList_CellEndEdit);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total (TL)";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Market:";
            // 
            // lblMarketName
            // 
            this.lblMarketName.AutoSize = true;
            this.lblMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketName.Location = new System.Drawing.Point(61, 7);
            this.lblMarketName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarketName.Name = "lblMarketName";
            this.lblMarketName.Size = new System.Drawing.Size(34, 17);
            this.lblMarketName.TabIndex = 2;
            this.lblMarketName.Text = "BIM";
            // 
            // btnSaveList
            // 
            this.btnSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveList.Enabled = false;
            this.btnSaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveList.Location = new System.Drawing.Point(9, 333);
            this.btnSaveList.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(62, 28);
            this.btnSaveList.TabIndex = 3;
            this.btnSaveList.Text = "Save";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(300, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(291, 19);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "23.03.2022 18:29";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(361, 338);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(230, 19);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "Grand Total: 0TL";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMarketName
            // 
            this.tbMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarketName.Location = new System.Drawing.Point(61, 3);
            this.tbMarketName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarketName.Name = "tbMarketName";
            this.tbMarketName.Size = new System.Drawing.Size(118, 23);
            this.tbMarketName.TabIndex = 6;
            this.tbMarketName.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(75, 332);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PurchaseListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 368);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbMarketName);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.lblMarketName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPurchaseList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PurchaseListWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPurchaseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarketName;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox tbMarketName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}