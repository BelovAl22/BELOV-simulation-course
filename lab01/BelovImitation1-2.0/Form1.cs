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

namespace BelovImitation1_2._0
{
    public partial class Form1 : Form
    {
        decimal t, x0, y0, v0, cosa, sina;
        decimal maxHeight;
        decimal lastSpeed;

        int currentSeriesIndex;

        decimal globalMaxX = 0;
        decimal globalMaxY = 0;

        const decimal g = 9.81M;

        public Form1()
        {
            InitializeComponent();

            // привязка событий (если не через дизайнер)
            this.Load += Form1_Load;
            timer1.Tick += timer1_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ===== НАСТРОЙКА ТАБЛИЦЫ =====
            dgvResults.ColumnCount = 4;
            dgvResults.Columns[0].Name = "Шаг dt, c";
            dgvResults.Columns[1].Name = "Дальность, м";
            dgvResults.Columns[2].Name = "Макс высота, м";
            dgvResults.Columns[3].Name = "Скорость в конце, м/с";
            dgvResults.AllowUserToAddRows = false;

            // ===== НАСТРОЙКА ГРАФИКА =====
            chart1.Series.Clear();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 40;

            chart1.ChartAreas[0].AxisX.Title = "Дальность (м)";
            chart1.ChartAreas[0].AxisY.Title = "Высота (м)";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chart1.Legends.Clear();
            chart1.Legends.Add(new Legend("Legend"));
            chart1.Legends[0].Docking = Docking.Top;
        }

        // ===== КНОПКА ЗАПУСКА =====
        private void btLaunch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                t = 0;
                x0 = 0;
                y0 = inputHeight.Value;
                v0 = inputSpeed.Value;

                double a = (double)inputAngle.Value * Math.PI / 180.0;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);

                maxHeight = y0;

                // создаём новую серию
                currentSeriesIndex = chart1.Series.Count;

                var series = chart1.Series.Add($"dt = {inputStep.Value}");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

                // первая точка
                chart1.Series[currentSeriesIndex].Points.AddXY(x0, y0);

                timer1.Start();
            }
        }

        // ===== ТАЙМЕР МОДЕЛИРОВАНИЯ =====
        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal dt = inputStep.Value;
            t += dt;

            decimal x = x0 + v0 * cosa * t;
            decimal y = y0 + v0 * sina * t - g * t * t / 2;

            chart1.Series[currentSeriesIndex].Points.AddXY(x, y);

            if (y > maxHeight)
                maxHeight = y;

            decimal vx = v0 * cosa;
            decimal vy = v0 * sina - g * t;
            lastSpeed = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));

            if (y <= 0)
            {
                timer1.Stop();

                decimal range = x;

                // === добавляем строку в таблицу ===
                dgvResults.Rows.Add(
                    inputStep.Value.ToString(),
                    range.ToString("F2"),
                    maxHeight.ToString("F2"),
                    lastSpeed.ToString("F2")
                );

                // === обновляем глобальные максимумы ===
                if (range > globalMaxX)
                    globalMaxX = range;

                if (maxHeight > globalMaxY)
                    globalMaxY = maxHeight;

                // === масштаб графика с запасом ===
                chart1.ChartAreas[0].AxisX.Maximum = (double)(globalMaxX * 1.1M);
                chart1.ChartAreas[0].AxisY.Maximum = (double)(globalMaxY * 1.1M);
            }
        }

        // ===== КНОПКА ОЧИСТКИ =====
        private void btClear_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            dgvResults.Rows.Clear();

            globalMaxX = 0;
            globalMaxY = 0;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Maximum = 10;
        }
    }
}