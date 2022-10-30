using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GroceryExpenseTracker
{
    public partial class ChartViewWindow : Form
    {
        private const string expenseChartSeriesLabel = "Expense";

        private Application mainApp;
        private Dictionary<string, List<Model.Product>> datePurchaseList = new Dictionary<string, List<Model.Product>>();

        private void LoadChart(int interval)
        {
            // ASC order
            mainApp.purchaseHistory.History.Reverse();
            datePurchaseList.Clear();

            for(int _i=0; _i < mainApp.purchaseHistory.History.Count; _i++)
            {
                Model.PurchaseList purchaseList = mainApp.purchaseHistory.History[_i];
                DateTime today = DateTime.Now;

                switch(interval)
                {
                    case 0: // This Month
                    {
                        if(purchaseList.Date.Year  != today.Year
                        || purchaseList.Date.Month != today.Month) continue;        
                    }
                    break;
                    
                    case 1: // Past 2 Months
                    {
                        if(purchaseList.Date < today.AddMonths(-2)) continue;
                    }
                    break;
                    
                    case 2: // Past 3 Months
                    {
                        if(purchaseList.Date < today.AddMonths(-3)) continue;
                    }
                    break;

                    case 3: // This Year
                    {
                        if(purchaseList.Date.Year != today.Year) continue;
                    }
                    break;

                    default:
                    {
                        MessageBox.Show("An error occured while generating expense chart.", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }

                string shortDateString = purchaseList.Date.ToShortDateString();

                if(!datePurchaseList.ContainsKey(shortDateString))
                    datePurchaseList[shortDateString] = new List<Model.Product>();

                datePurchaseList[shortDateString].AddRange(purchaseList.ProductList);
            }

            var chartArea = chartExpenses.ChartAreas[0];

            chartArea.Position       = new ElementPosition(0, 0, 100, 100);
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Minimum  = 1;
            chartArea.AxisX.Maximum  = datePurchaseList.Keys.Count;
            chartArea.AxisY.Minimum  = 0;

            chartExpenses.Series.Clear();

            chartExpenses.Series.Add(expenseChartSeriesLabel);

            chartExpenses.Series[expenseChartSeriesLabel].Color             = Color.Red;
            chartExpenses.Series[expenseChartSeriesLabel].Legend            = "Legend1";
            chartExpenses.Series[expenseChartSeriesLabel].ChartArea         = "ChartArea1";
            chartExpenses.Series[expenseChartSeriesLabel].ChartType         = SeriesChartType.Line;
            chartExpenses.Series[expenseChartSeriesLabel].MarkerStyle       = MarkerStyle.Circle;
            chartExpenses.Series[expenseChartSeriesLabel].MarkerSize        = 8;
            chartExpenses.Series[expenseChartSeriesLabel].BorderWidth       = 3;
            chartExpenses.Series[expenseChartSeriesLabel].IsVisibleInLegend = false;

            float totalExpense = 0;

            int i = 0;
            foreach(KeyValuePair<string, List<Model.Product>> pair in datePurchaseList)
            {
                var date        = pair.Key;
                var productList = pair.Value;

                float grandTotal = productList.Sum(elem => elem.QTY * elem.UnitPrice);
                totalExpense += grandTotal;

                chartExpenses.Series[expenseChartSeriesLabel].Points.AddXY(i + 1, grandTotal);
                chartExpenses.Series[expenseChartSeriesLabel].Points[i].Label     = grandTotal.ToString() + "TL";
                chartExpenses.Series[expenseChartSeriesLabel].Points[i].AxisLabel = date;

                i++;
            }

            lblGrandTotal.Text = "Total Expense: " + totalExpense.ToString() + "TL";
            
            if(datePurchaseList.Count > 0)
                lblGrandTotal.Text += " | Total Day(s): " + DateTime.Parse(datePurchaseList.Last().Key).Subtract(DateTime.Parse(datePurchaseList.First().Key)).Days.ToString();

            // revert back to DESC order
            mainApp.purchaseHistory.History.Reverse();
        }

        public ChartViewWindow(Application mainApp)
        {
            this.mainApp = mainApp;
            this.mainApp.Hide();

            InitializeComponent();
            MinimumSize = Size;

            // Time Interval ComboBox
            cbTimeInterval.Items.Add(new ComboBoxItem(){ Text = "This Month",    Value = "0" });
            cbTimeInterval.Items.Add(new ComboBoxItem(){ Text = "Past 2 Months", Value = "0" });
            cbTimeInterval.Items.Add(new ComboBoxItem(){ Text = "Past 3 Months", Value = "0" });
            cbTimeInterval.Items.Add(new ComboBoxItem(){ Text = "This Year",     Value = "0" });

            cbTimeInterval.SelectedIndex = 0;
        }

        private void ChartViewWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainApp.Show();
        }

        private void cbTimeInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart(cbTimeInterval.SelectedIndex);
        }

        private void chartExpenses_MouseClick(object sender, MouseEventArgs e)
        {
            var pos    = e.Location;
            var result = chartExpenses.HitTest(pos.X, pos.Y);

            if(result.ChartElementType == ChartElementType.DataPoint)
            {
                var pointData = chartExpenses.Series[expenseChartSeriesLabel].Points[result.PointIndex];
                string date   = pointData.AxisLabel;

                Model.PurchaseList expenseList = new Model.PurchaseList();

                expenseList.MarketName = "";
                expenseList.Date       = DateTime.Parse(date);
                expenseList.ProductList.AddRange(datePurchaseList[date]);

                var chartDateProductListWindow = new ChartDateProductListWindow(this, expenseList);
                chartDateProductListWindow.Show();
            }
        }
    }
}
