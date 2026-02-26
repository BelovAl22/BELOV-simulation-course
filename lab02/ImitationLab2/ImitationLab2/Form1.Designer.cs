namespace ImitationLab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.numTLeft = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTRight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTInitial = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numTau = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numTotalTime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numLambda = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numRho = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnFillTable = new System.Windows.Forms.Button();
            this.lblCenterTemp = new System.Windows.Forms.Label();
            this.lblSimulationTime = new System.Windows.Forms.Label();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Толщина L, м\r\n";
            // 
            // numLength
            // 
            this.numLength.DecimalPlaces = 2;
            this.numLength.Location = new System.Drawing.Point(165, 23);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 20);
            this.numLength.TabIndex = 1;
            this.numLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // numTLeft
            // 
            this.numTLeft.Location = new System.Drawing.Point(165, 47);
            this.numTLeft.Name = "numTLeft";
            this.numTLeft.Size = new System.Drawing.Size(120, 20);
            this.numTLeft.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Температура слева, °C";
            // 
            // numTRight
            // 
            this.numTRight.Location = new System.Drawing.Point(165, 75);
            this.numTRight.Name = "numTRight";
            this.numTRight.Size = new System.Drawing.Size(120, 20);
            this.numTRight.TabIndex = 5;
            this.numTRight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Температура справа, °C";
            // 
            // numTInitial
            // 
            this.numTInitial.Location = new System.Drawing.Point(165, 99);
            this.numTInitial.Name = "numTInitial";
            this.numTInitial.Size = new System.Drawing.Size(120, 20);
            this.numTInitial.TabIndex = 7;
            this.numTInitial.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Начальная температура, °C";
            // 
            // numH
            // 
            this.numH.DecimalPlaces = 4;
            this.numH.Location = new System.Drawing.Point(455, 80);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(120, 20);
            this.numH.TabIndex = 13;
            this.numH.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шаг по пространству h, м";
            // 
            // numTau
            // 
            this.numTau.DecimalPlaces = 4;
            this.numTau.Location = new System.Drawing.Point(455, 52);
            this.numTau.Name = "numTau";
            this.numTau.Size = new System.Drawing.Size(120, 20);
            this.numTau.TabIndex = 11;
            this.numTau.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Шаг по времени τ, с";
            // 
            // numTotalTime
            // 
            this.numTotalTime.Location = new System.Drawing.Point(455, 28);
            this.numTotalTime.Name = "numTotalTime";
            this.numTotalTime.Size = new System.Drawing.Size(120, 20);
            this.numTotalTime.TabIndex = 9;
            this.numTotalTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Общее время, с";
            // 
            // numLambda
            // 
            this.numLambda.Location = new System.Drawing.Point(762, 82);
            this.numLambda.Name = "numLambda";
            this.numLambda.Size = new System.Drawing.Size(120, 20);
            this.numLambda.TabIndex = 19;
            this.numLambda.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Теплопроводность λ, Вт/(м·°C)";
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(762, 54);
            this.numC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(120, 20);
            this.numC.TabIndex = 17;
            this.numC.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Теплоёмкость c, Дж/(кг·°C)";
            // 
            // numRho
            // 
            this.numRho.Location = new System.Drawing.Point(762, 28);
            this.numRho.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRho.Name = "numRho";
            this.numRho.Size = new System.Drawing.Size(120, 20);
            this.numRho.TabIndex = 15;
            this.numRho.Value = new decimal(new int[] {
            7800,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Плотность ρ, кг/м³";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(888, 38);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(143, 23);
            this.btnRun.TabIndex = 20;
            this.btnRun.Text = "Запуск";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnFillTable
            // 
            this.btnFillTable.Location = new System.Drawing.Point(888, 67);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(143, 23);
            this.btnFillTable.TabIndex = 21;
            this.btnFillTable.Text = "Заполнить таблицу";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // lblCenterTemp
            // 
            this.lblCenterTemp.AutoSize = true;
            this.lblCenterTemp.Location = new System.Drawing.Point(402, 120);
            this.lblCenterTemp.Name = "lblCenterTemp";
            this.lblCenterTemp.Size = new System.Drawing.Size(124, 13);
            this.lblCenterTemp.TabIndex = 22;
            this.lblCenterTemp.Text = "Температура в центре:";
            // 
            // lblSimulationTime
            // 
            this.lblSimulationTime.AutoSize = true;
            this.lblSimulationTime.Location = new System.Drawing.Point(731, 120);
            this.lblSimulationTime.Name = "lblSimulationTime";
            this.lblSimulationTime.Size = new System.Drawing.Size(101, 13);
            this.lblSimulationTime.TabIndex = 23;
            this.lblSimulationTime.Text = "Время симуляции:";
            // 
            // chartTemperature
            // 
            chartArea7.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend7);
            this.chartTemperature.Location = new System.Drawing.Point(12, 136);
            this.chartTemperature.Name = "chartTemperature";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartTemperature.Series.Add(series7);
            this.chartTemperature.Size = new System.Drawing.Size(891, 469);
            this.chartTemperature.TabIndex = 24;
            this.chartTemperature.Text = "chart1";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(910, 136);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(556, 469);
            this.dataGridViewResults.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 617);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.lblSimulationTime);
            this.Controls.Add(this.lblCenterTemp);
            this.Controls.Add(this.btnFillTable);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.numLambda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numRho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numTotalTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numTInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.NumericUpDown numTLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTInitial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numTotalTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numLambda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numRho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.Label lblCenterTemp;
        private System.Windows.Forms.Label lblSimulationTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}

