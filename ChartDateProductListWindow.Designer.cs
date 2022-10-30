
namespace GroceryExpenseTracker
{
    partial class ChartDateProductListWindow
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
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPurchaseList
            // 
            this.dgPurchaseList.AllowUserToAddRows = false;
            this.dgPurchaseList.AllowUserToDeleteRows = false;
            this.dgPurchaseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.QTY,
            this.Price,
            this.Total});
            this.dgPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgPurchaseList.EnableHeadersVisualStyles = false;
            this.dgPurchaseList.Location = new System.Drawing.Point(14, 15);
            this.dgPurchaseList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgPurchaseList.Name = "dgPurchaseList";
            this.dgPurchaseList.ReadOnly = true;
            this.dgPurchaseList.RowHeadersVisible = false;
            this.dgPurchaseList.RowHeadersWidth = 51;
            this.dgPurchaseList.RowTemplate.Height = 24;
            this.dgPurchaseList.Size = new System.Drawing.Size(873, 458);
            this.dgPurchaseList.TabIndex = 1;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(541, 482);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(345, 29);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "Grand Total: 0";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 482);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(436, 29);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "23.03.2022 18:29";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChartDateProductListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.dgPurchaseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartDateProductListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChartDateProductListWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPurchaseList;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}