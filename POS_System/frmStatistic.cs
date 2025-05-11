using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace POS_System
{
    public partial class frmStatistic : Sample
    {
        SqlConnection connect;
        List<RevenueByDay> revenueByDays;
        List<RevenueByMonth> revenueByMonths;
        List<StatByProduct> statByProducts;
        int year, month;
        public frmStatistic()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);

        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        public void displayRevenueByDay()
        {
            RevenueByDay revenueByDay = new RevenueByDay();

            year = Convert.ToInt32(cbxYear.SelectedItem);
            month = Convert.ToInt32(cbxMonth.SelectedItem);

            revenueByDays=revenueByDay.GetRevenueByDay(month, year);

            dgv.DataSource = revenueByDays;

            DrawChartByDay(revenueByDays, SeriesChartType.Column);
        }

        public void displayRevenueByMonth()
        {
            RevenueByMonth revenueByMonth = new RevenueByMonth();

            year = Convert.ToInt32(cbxYear.SelectedItem);
            month = Convert.ToInt32(cbxMonth.SelectedItem);

            revenueByMonths = revenueByMonth.GetRevenueByMonth(year);

            dgv.DataSource = revenueByMonths;

            DrawChartByMonth(revenueByMonths, SeriesChartType.Column);
        }

        public void displayStatByProduct()
        {
            StatByProduct statByProduct = new StatByProduct();

            year = Convert.ToInt32(cbxYear.SelectedItem);
            month = Convert.ToInt32(cbxMonth.SelectedItem);

            statByProducts = statByProduct.GetOrderProduct(month,year);

            dgv.DataSource = statByProducts;

            DrawChartByProduct(statByProducts, SeriesChartType.Column);
        }

        private void DrawChartByDay(List<RevenueByDay> data, SeriesChartType type)
        {
            chartDoanhThu.Series.Clear();

            Series series = new Series($"Doanh thu trong {month}/{year}")
            {
                ChartType = type,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9),
            };
            
            foreach(var d in data)
            {
                series.Points.AddXY(d.Day, d.TotalPrice);
            }

            chartDoanhThu.Series.Add(series);
        }

        private void DrawChartByMonth(List<RevenueByMonth> data, SeriesChartType type)
        {
            chartDoanhThu.Series.Clear();

            Series series = new Series($"Doanh thu trong {year}")
            {
                ChartType = type,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9),
            };

            foreach (var d in data)
            {
                series.Points.AddXY(d.Month, d.TotalPrice);
            }

            chartDoanhThu.Series.Add(series);
        }

        private void DrawChartByProduct(List<StatByProduct> data, SeriesChartType type)
        {
            chartDoanhThu.Series.Clear();

            Series series = new Series($"Tong so luong san pham trong {month}/{year}")
            {
                ChartType = type,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9),
            };

            foreach (var d in data)
            {
                series.Points.AddXY(d.ProdName, d.TotalQuantity);
            }

            chartDoanhThu.Series.Add(series);
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            LoadMonth();
            LoadYear();
        }

        private void LoadMonth()
        {
            cbxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
                cbxMonth.Items.Add(i.ToString("D2"));

            cbxMonth.SelectedIndex = -1;
        }

        private void LoadYear()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT DISTINCT YEAR(order_date) AS year FROM Orders ORDER BY year";

                    using(SqlCommand cmd=new SqlCommand(sql, connect))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbxYear.Items.Add(reader["year"].ToString());
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                                          "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cbxThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxThongKeTheo.SelectedIndex == 0)
            {
                displayRevenueByDay();
            }
            else if (cbxThongKeTheo.SelectedIndex == 1)
            {
                displayRevenueByMonth();
            }
            else if (cbxThongKeTheo.SelectedIndex == 2)
            {
                displayStatByProduct();
            }
        }

        private void cbxLoaiBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SeriesChartType chartType;

            switch (cbxLoaiBieuDo.SelectedIndex)
            {
                case 0:
                    chartType = SeriesChartType.Column;
                    break;
                case 1:
                    chartType = SeriesChartType.Line;
                    break;
                case 2:
                    chartType = SeriesChartType.Bar;
                    break;
                default:
                    chartType = SeriesChartType.Column;
                    break;
            }

            if (cbxThongKeTheo.SelectedIndex == 0 && revenueByDays != null)
            {
                DrawChartByDay(revenueByDays, chartType);
            }
            else if (cbxThongKeTheo.SelectedIndex == 1 && revenueByMonths != null)
            {
                DrawChartByMonth(revenueByMonths, chartType);
            }
            else if (cbxThongKeTheo.SelectedIndex == 2 && statByProducts != null)
            {
                DrawChartByProduct(statByProducts, chartType);
            }

        }
    }
}
