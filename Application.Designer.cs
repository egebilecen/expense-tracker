
namespace GroceryExpenseTracker
{
    partial class Application
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
            this.cbSelectEntry = new System.Windows.Forms.ComboBox();
            this.btnShowEntry = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnExpenseChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Entry:";
            // 
            // cbSelectEntry
            // 
            this.cbSelectEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectEntry.FormattingEnabled = true;
            this.cbSelectEntry.Location = new System.Drawing.Point(123, 11);
            this.cbSelectEntry.Name = "cbSelectEntry";
            this.cbSelectEntry.Size = new System.Drawing.Size(177, 28);
            this.cbSelectEntry.TabIndex = 1;
            // 
            // btnShowEntry
            // 
            this.btnShowEntry.Enabled = false;
            this.btnShowEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEntry.Location = new System.Drawing.Point(88, 45);
            this.btnShowEntry.Name = "btnShowEntry";
            this.btnShowEntry.Size = new System.Drawing.Size(66, 30);
            this.btnShowEntry.TabIndex = 2;
            this.btnShowEntry.Text = "Show";
            this.btnShowEntry.UseVisualStyleBackColor = true;
            this.btnShowEntry.Click += new System.EventHandler(this.btnShowEntry_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntry.Location = new System.Drawing.Point(16, 45);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(66, 30);
            this.btnAddEntry.TabIndex = 3;
            this.btnAddEntry.Text = "Add";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnExpenseChart
            // 
            this.btnExpenseChart.Enabled = false;
            this.btnExpenseChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseChart.Location = new System.Drawing.Point(161, 45);
            this.btnExpenseChart.Name = "btnExpenseChart";
            this.btnExpenseChart.Size = new System.Drawing.Size(140, 30);
            this.btnExpenseChart.TabIndex = 4;
            this.btnExpenseChart.Text = "Expense Chart";
            this.btnExpenseChart.UseVisualStyleBackColor = true;
            this.btnExpenseChart.Click += new System.EventHandler(this.btnExpenseChart_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 82);
            this.Controls.Add(this.btnExpenseChart);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnShowEntry);
            this.Controls.Add(this.cbSelectEntry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Expense Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectEntry;
        private System.Windows.Forms.Button btnShowEntry;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnExpenseChart;
    }
}

