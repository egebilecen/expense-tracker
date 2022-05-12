using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GroceryExpenseTracker
{
    public partial class Application : Form
    {
        public string                 purchaseDataFile { get; } = "purchase_data.json";
        public Model.PurchaseHistory  purchaseHistory           = null;

        public void LoadPurchaseData()
        {
            if(purchaseHistory == null)
                purchaseHistory = JsonConvert.DeserializeObject<Model.PurchaseHistory>(File.ReadAllText(purchaseDataFile));

            if(purchaseHistory.History.Count > 0)
            {
                purchaseHistory.History = purchaseHistory.History.OrderByDescending(elem => elem.Date).ToList();
                
                btnShowEntry.Enabled    = true;
                btnExpenseChart.Enabled = true;

                cbSelectEntry.Items.Clear();

                for(int i=0; i < purchaseHistory.History.Count; i++)
                {
                    Model.PurchaseList purchaseList = purchaseHistory.History[i];

                    ComboBoxItem item = new ComboBoxItem();
                    item.Text  = purchaseList.Date.ToString();
                    item.Value = purchaseList.Date.ToString();

                    cbSelectEntry.Items.Add(item);
                    cbSelectEntry.SelectedIndex = 0;
                }
            }
            else
            {
                btnShowEntry.Enabled     = false;
                btnExpenseChart.Enabled  = false;
                cbSelectEntry.DataSource = null;
                cbSelectEntry.Items.Clear();
            }
        }

        private void CreateDefaultPurchaseDataFile()
        {
            if(File.Exists(purchaseDataFile)) return;

            Model.PurchaseHistory purchaseHistory = new Model.PurchaseHistory();
            purchaseHistory.Save(purchaseDataFile);
        }

        private void DisplayPurchaseListWindow(Model.PurchaseList purchaseList = null)
        {
            var purchaseListPreviewWindow = new PurchaseListWindow(this, purchaseList);
            purchaseListPreviewWindow.Show();
        }

        public Application()
        {
            InitializeComponent();
            CreateDefaultPurchaseDataFile();
            LoadPurchaseData();
        }

        private void btnShowEntry_Click(object sender, EventArgs e)
        {
            Model.PurchaseList purchaseList = purchaseHistory.History[cbSelectEntry.SelectedIndex];
            DisplayPurchaseListWindow(purchaseList);
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            DisplayPurchaseListWindow(null);
        }

        private void btnExpenseChart_Click(object sender, EventArgs e)
        {
            var chartViewWindow = new ChartViewWindow(this);
            chartViewWindow.Show();
        }
    }
}
