
namespace GroceryExpenseTracker
{
    partial class ChartViewWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimeInterval = new System.Windows.Forms.ComboBox();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Interval:";
            // 
            // cbTimeInterval
            // 
            this.cbTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeInterval.FormattingEnabled = true;
            this.cbTimeInterval.Location = new System.Drawing.Point(101, 5);
            this.cbTimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeInterval.Name = "cbTimeInterval";
            this.cbTimeInterval.Size = new System.Drawing.Size(113, 24);
            this.cbTimeInterval.TabIndex = 2;
            this.cbTimeInterval.SelectedIndexChanged += new System.EventHandler(this.cbTimeInterval_SelectedIndexChanged);
            // 
            // chartExpenses
            // 
            this.chartExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend3);
            this.chartExpenses.Location = new System.Drawing.Point(12, 32);
            this.chartExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.chartExpenses.Name = "chartExpenses";
            this.chartExpenses.Size = new System.Drawing.Size(761, 514);
            this.chartExpenses.TabIndex = 3;
            this.chartExpenses.Text = "Expense Chart";
            this.chartExpenses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartExpenses_MouseClick);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(361, 5);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(412, 19);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "Total Expense: 0₺ | Total Day(s): 0";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChartViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 560);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.cbTimeInterval);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "ChartViewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Chart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChartViewWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimeInterval;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}