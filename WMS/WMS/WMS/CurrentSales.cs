using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.IO;

namespace WMS
{
    public partial class CurrentSales : Form
    {
        public CurrentSales()
        {
            InitializeComponent();
            var context = new WMSEntities();
            txtCurrentSales.Text = "Please select a Warehouse";
            var result = (from c in context.Warehouses
                          select c.Address
                                             ).ToList();

            warehousesComboBox.DataSource = (from c in context.Warehouses
                                             select c.WarehouseID
                                             ).ToList();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCurrentSales_Click(object sender, EventArgs e)
        {
            using (var contex = new WMSEntities())
            {
                int WarehouseID = Int32.Parse(warehousesComboBox.SelectedItem.ToString());
                gvCurrentSales.DataSource = (from c in contex.CurrentSales
                                             join cd in contex.ClientOrderDetails on c.OrderID equals cd.OrderID
                                             where c.WarehouseID == WarehouseID & c.OrderID == cd.OrderID
                                             join p in contex.Products on cd.ProductID equals p.ProductID
                                             select new
                                             {
                                                 Order = c.OrderID,
                                                 ProductName = p.ProductName,
                                                 Quantity = cd.Quantity,
                                                 Price = c.TotalPrice
                                             }).Distinct().ToList();



            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvCurrentSales.Rows.Count == 0)
                {
                    throw new Exception("Please select a warehouse and press 'See Current Sales' button!");
                }

                int WarehouseID = Int32.Parse(warehousesComboBox.SelectedItem.ToString());
                using (var contex = new WMSEntities())
                {

                    var queryResult = (from c in contex.CurrentSales
                                       join cd in contex.ClientOrderDetails on c.OrderID equals cd.OrderID
                                       where c.WarehouseID == WarehouseID & c.OrderID == cd.OrderID
                                       join p in contex.Products on cd.ProductID equals p.ProductID
                                       select new
                                       {
                                           Order = c.OrderID,
                                           ProductName = p.ProductName,
                                           Quantity = cd.Quantity,
                                           Price = c.TotalPrice
                                       }).Distinct().ToList();
                    var totalSum = (from c in contex.CurrentSales
                                    select c.TotalPrice).Sum();


                    Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }

                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;


                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Cells[1, 1] = "Sales report for warehouse " + WarehouseID.ToString();
                    xlWorkSheet.Cells[2, 1] = "Order ID";
                    xlWorkSheet.Cells[2, 2] = "Product name";
                    xlWorkSheet.Cells[2, 3] = "Quantity";
                    xlWorkSheet.Cells[2, 4] = "Price";

                    int i = 0;
                    for (i = 0; i < queryResult.Count; i++)
                    {
                        xlWorkSheet.Cells[i + 3, 1] = queryResult[i].Order;
                        xlWorkSheet.Cells[i + 3, 2] = queryResult[i].ProductName;
                        xlWorkSheet.Cells[i + 3, 3] = queryResult[i].Quantity;
                        xlWorkSheet.Cells[i + 3, 4] = queryResult[i].Price;
                    }

                    xlWorkSheet.Cells[i + 4, 1] = "Total sales for warehouse " + WarehouseID.ToString() + " are " + totalSum.ToString();
                    string FileNameAndPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Sales Warehouse " + WarehouseID.ToString() + ".xls";
                    xlWorkBook.SaveAs(FileNameAndPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();


                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);



                    MessageBox.Show("Report in Excel format is created , you can find the file " + FileNameAndPath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        }
 }

