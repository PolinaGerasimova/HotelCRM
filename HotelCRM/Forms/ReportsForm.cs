using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelCRM.Models;
using HotelCRM.Helpers;
using Microsoft.EntityFrameworkCore;



namespace HotelCRM.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Инициализация начальных дат
            dateTimePickerStart.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEnd.Value = DateTime.Today;
        }

        private async void GenerateReport()
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var report = await context.Bookings
                        .Where(b => b.Status == "CheckedOut" &&
                                    b.CheckOutDate >= dateTimePickerStart.Value.Date &&
                                    b.CheckOutDate <= dateTimePickerEnd.Value.Date)
                        .Select(b => new
                        {
                            b.BookingID,
                            b.RoomNumber,
                            b.GuestID,
                            b.CheckInDate,
                            b.CheckOutDate,
                            b.FinalBillAmount
                        }).ToListAsync();

                    dataGridViewReport.DataSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка формирования отчета: " + ex.Message);
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Отчет");

                            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridViewReport.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataGridViewReport.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridViewReport.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridViewReport.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Отчет успешно сохранён.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка экспорта в Excel: " + ex.Message);
                    }
                }
            }
        }

        private void ClearFields()
        {
            dataGridViewReport.DataSource = null;
            dateTimePickerStart.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEnd.Value = DateTime.Today;
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
