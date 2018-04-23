using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.PivotGrid;
using System.Collections;

namespace RankFunctionSample {
    public partial class Form1 : Form {
        Dictionary<int, List<decimal>> salesPerYear;
        List<decimal> totalSales;

        public Form1() {
            InitializeComponent();

            DataTable data = new DataTable();
            data.Columns.Add("Product", typeof(string));
            data.Columns.Add("Year", typeof(int));
            data.Columns.Add("Sales", typeof(decimal));

            Random r = new Random(0);
            for(int i = 0; i < 100; i++) {
                data.Rows.Add("Product " + r.Next(12).ToString(), 2006 + r.Next(3), r.Next(30));
            }

            pivotGridControl1.DataSource = data;

            CalculateSalesPerYear();
            CalculateSalesPerProduct();
        }        
        void CalculateSalesPerYear() {
            salesPerYear = new Dictionary<int, List<decimal>>();
            PivotSummaryDataSource ds = pivotGridControl1.CreateSummaryDataSource();
            for(int i = 0; i < ds.RowCount; i++) {
                int year = (int)ds.GetValue(i, fieldYear);
                List<decimal> list;
                if(!salesPerYear.TryGetValue(year, out list)) {
                    list = new List<decimal>();
                    salesPerYear.Add(year, list);
                }
                list.Add((decimal)ds.GetValue(i, fieldRank));
            }
            foreach(List<decimal> list in salesPerYear.Values)
                list.Sort(ReverseDecimalSort);
        }
        void CalculateSalesPerProduct() {
            Dictionary<string, decimal> sales = new Dictionary<string, decimal>();
            PivotSummaryDataSource ds = pivotGridControl1.CreateSummaryDataSource();
            for(int i = 0; i < ds.RowCount; i++) {
                string product = (string)ds.GetValue(i, fieldProduct);
                decimal sale = (decimal)ds.GetValue(i, fieldRank);
                if(sales.ContainsKey(product))
                    sales[product] += sale;
                else
                    sales.Add(product, sale);
            }
            totalSales = new List<decimal>(sales.Count);
            foreach(decimal value in sales.Values)
                totalSales.Add(value);
            totalSales.Sort(ReverseDecimalSort);
        }
        void pivotGridControl1_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e) {
            if(e.DataField != fieldRank) return;
            e.DisplayText = "";
            if(e.RowValueType == PivotGridValueType.GrandTotal || e.Value == null) {
                return;
            }
            if(e.ColumnValueType == PivotGridValueType.GrandTotal) {
                e.DisplayText = (totalSales.IndexOf(Convert.ToDecimal(e.Value)) + 1).ToString();
                return;
            } else {
                List<decimal> sales;
                if(salesPerYear.TryGetValue((int)e.GetFieldValue(fieldYear), out sales)) {
                    e.DisplayText = (sales.IndexOf(Convert.ToDecimal(e.Value)) + 1).ToString();
                }
            }
        }
        int ReverseDecimalSort(decimal a, decimal b) {
            return -Comparer<decimal>.Default.Compare(a, b);
        }
    }
}