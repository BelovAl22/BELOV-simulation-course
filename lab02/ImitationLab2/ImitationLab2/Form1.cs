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

namespace ImitationLab2
{
    public partial class Form1 : Form
    {
        private HeatEquationModel model;
        public Form1()
        {
            InitializeComponent();
            model = new HeatEquationModel();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение параметров из формы
                double length = (double)numLength.Value;
                double tLeft = (double)numTLeft.Value;
                double tRight = (double)numTRight.Value;
                double tInitial = (double)numTInitial.Value;

                double totalTime = (double)numTotalTime.Value;
                double tau = (double)numTau.Value;
                double h = (double)numH.Value;

                double rho = (double)numRho.Value;
                double c = (double)numC.Value;
                double lambda = (double)numLambda.Value;

                // Валидация
                if (tau <= 0 || h <= 0)
                    throw new Exception("Шаги должны быть > 0");

                if (length <= 0)
                    throw new Exception("Длина должна быть > 0");

                // Расчёт
                double[] result = model.Solve(length, tLeft, tRight, tInitial,
                                             totalTime, tau, h, rho, c, lambda);

                // Отображение
                DisplayResults(result, h, length);

                int centerIndex = result.Length / 2;
                lblCenterTemp.Text = $"Температура в центре: {result[centerIndex]:F4} °C";
                lblSimulationTime.Text = $"Время симуляции: {totalTime:F3} с";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults(double[] temperatures, double h, double length)
        {
            chartTemperature.Series.Clear();

            var series = new Series("Temperature")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            for (int i = 0; i < temperatures.Length; i++)
            {
                double x = i * h;
                series.Points.AddXY(x, temperatures[i]);
            }

            chartTemperature.Series.Add(series);
            chartTemperature.ChartAreas[0].AxisX.Title = "x, м";
            chartTemperature.ChartAreas[0].AxisY.Title = "T, °C";
            chartTemperature.ChartAreas[0].AxisX.Minimum = 0;
            chartTemperature.ChartAreas[0].AxisX.Maximum = length;
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {
            double length = (double)numLength.Value;
            double tLeft = (double)numTLeft.Value;
            double tRight = (double)numTRight.Value;
            double tInitial = (double)numTInitial.Value;
            double rho = (double)numRho.Value;
            double c = (double)numC.Value;
            double lambda = (double)numLambda.Value;

            double[] timeSteps = { 0.1, 0.01, 0.001, 0.0001 };
            double[] spaceSteps = { 0.1, 0.01, 0.001, 0.0001 };
            double totalTime = 2.0;

            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();

            dataGridViewResults.Columns.Add("Tau_h", "τ \\ h");
            foreach (var h in spaceSteps)
                dataGridViewResults.Columns.Add($"h{h}", h.ToString());

            for (int i = 0; i < timeSteps.Length; i++)
            {
                dataGridViewResults.Rows.Add();
                dataGridViewResults.Rows[i].Cells[0].Value = timeSteps[i].ToString();

                for (int j = 0; j < spaceSteps.Length; j++)
                {
                    try
                    {
                        double[] result = model.Solve(length, tLeft, tRight, tInitial,
                                                     totalTime, timeSteps[i], spaceSteps[j],
                                                     rho, c, lambda);

                        int centerIndex = result.Length / 2;
                        dataGridViewResults.Rows[i].Cells[j + 1].Value =
                            result[centerIndex].ToString("F4");
                    }
                    catch (Exception ex)
                    {
                        dataGridViewResults.Rows[i].Cells[j + 1].Value = "Ошибка";
                    }
                }
            }
        }
    }
}
