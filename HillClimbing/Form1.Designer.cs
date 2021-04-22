
namespace HillClimbing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.testBtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTest = new System.Windows.Forms.Panel();
            this.algorithm = new System.Windows.Forms.Button();
            this.startTestBtn = new System.Windows.Forms.Button();
            this.testTable = new System.Windows.Forms.DataGridView();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iterationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solveCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(509, 24);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 27;
            this.testBtn.Text = "testy";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoGenerateColumns = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.xrealDataGridViewTextBoxColumn,
            this.xintDataGridViewTextBoxColumn,
            this.xbitDataGridViewTextBoxColumn,
            this.fxDataGridViewTextBoxColumn});
            this.table.DataSource = this.individualBindingSource;
            this.table.Location = new System.Drawing.Point(21, 64);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(563, 52);
            this.table.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "a";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(419, 22);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 20;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(274, 24);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(100, 20);
            this.Tbox.TabIndex = 19;
            this.Tbox.Text = "3800";
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(160, 21);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(72, 20);
            this.dBox.TabIndex = 17;
            this.dBox.Text = "0,001";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(100, 21);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(21, 20);
            this.bBox.TabIndex = 16;
            this.bBox.Text = "12";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(52, 20);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(23, 20);
            this.aBox.TabIndex = 15;
            this.aBox.Text = "-4";
            // 
            // chart
            // 
            chartArea7.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart.Legends.Add(legend7);
            this.chart.Location = new System.Drawing.Point(21, 133);
            this.chart.Name = "chart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart.Series.Add(series7);
            this.chart.Size = new System.Drawing.Size(1207, 585);
            this.chart.TabIndex = 28;
            this.chart.Text = "chart1";
            // 
            // panelTest
            // 
            this.panelTest.Controls.Add(this.testChart);
            this.panelTest.Controls.Add(this.testTable);
            this.panelTest.Controls.Add(this.startTestBtn);
            this.panelTest.Controls.Add(this.algorithm);
            this.panelTest.Location = new System.Drawing.Point(12, 12);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(1358, 729);
            this.panelTest.TabIndex = 29;
            // 
            // algorithm
            // 
            this.algorithm.Location = new System.Drawing.Point(34, 21);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(75, 23);
            this.algorithm.TabIndex = 0;
            this.algorithm.Text = "algorytm";
            this.algorithm.UseVisualStyleBackColor = true;
            this.algorithm.Click += new System.EventHandler(this.algorithm_Click);
            // 
            // startTestBtn
            // 
            this.startTestBtn.Location = new System.Drawing.Point(132, 21);
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.Size = new System.Drawing.Size(75, 23);
            this.startTestBtn.TabIndex = 2;
            this.startTestBtn.TabStop = false;
            this.startTestBtn.Text = "start";
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // testTable
            // 
            this.testTable.AllowUserToAddRows = false;
            this.testTable.AllowUserToDeleteRows = false;
            this.testTable.AutoGenerateColumns = false;
            this.testTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterationDataGridViewTextBoxColumn,
            this.solveCountDataGridViewTextBoxColumn,
            this.cumulationDataGridViewTextBoxColumn});
            this.testTable.DataSource = this.generationBindingSource1;
            this.testTable.Location = new System.Drawing.Point(34, 61);
            this.testTable.Name = "testTable";
            this.testTable.ReadOnly = true;
            this.testTable.Size = new System.Drawing.Size(361, 619);
            this.testTable.TabIndex = 3;
            // 
            // testChart
            // 
            chartArea8.Name = "ChartArea1";
            this.testChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.testChart.Legends.Add(legend8);
            this.testChart.Location = new System.Drawing.Point(407, 61);
            this.testChart.Name = "testChart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.testChart.Series.Add(series8);
            this.testChart.Size = new System.Drawing.Size(948, 654);
            this.testChart.TabIndex = 4;
            this.testChart.Text = "chart1";
            // 
            // iterationDataGridViewTextBoxColumn
            // 
            this.iterationDataGridViewTextBoxColumn.DataPropertyName = "Iteration";
            this.iterationDataGridViewTextBoxColumn.HeaderText = "Iteration";
            this.iterationDataGridViewTextBoxColumn.Name = "iterationDataGridViewTextBoxColumn";
            this.iterationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solveCountDataGridViewTextBoxColumn
            // 
            this.solveCountDataGridViewTextBoxColumn.DataPropertyName = "SolveCount";
            this.solveCountDataGridViewTextBoxColumn.HeaderText = "SolveCount";
            this.solveCountDataGridViewTextBoxColumn.Name = "solveCountDataGridViewTextBoxColumn";
            this.solveCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cumulationDataGridViewTextBoxColumn
            // 
            this.cumulationDataGridViewTextBoxColumn.DataPropertyName = "Cumulation";
            this.cumulationDataGridViewTextBoxColumn.HeaderText = "Cumulation";
            this.cumulationDataGridViewTextBoxColumn.Name = "cumulationDataGridViewTextBoxColumn";
            this.cumulationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generationBindingSource1
            // 
            this.generationBindingSource1.DataSource = typeof(HillClimbing.classes.Generation);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xrealDataGridViewTextBoxColumn
            // 
            this.xrealDataGridViewTextBoxColumn.DataPropertyName = "Xreal";
            this.xrealDataGridViewTextBoxColumn.HeaderText = "Xreal";
            this.xrealDataGridViewTextBoxColumn.Name = "xrealDataGridViewTextBoxColumn";
            this.xrealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xintDataGridViewTextBoxColumn
            // 
            this.xintDataGridViewTextBoxColumn.DataPropertyName = "Xint";
            this.xintDataGridViewTextBoxColumn.HeaderText = "Xint";
            this.xintDataGridViewTextBoxColumn.Name = "xintDataGridViewTextBoxColumn";
            this.xintDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xbitDataGridViewTextBoxColumn
            // 
            this.xbitDataGridViewTextBoxColumn.DataPropertyName = "Xbit";
            this.xbitDataGridViewTextBoxColumn.HeaderText = "Xbit";
            this.xbitDataGridViewTextBoxColumn.Name = "xbitDataGridViewTextBoxColumn";
            this.xbitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn
            // 
            this.fxDataGridViewTextBoxColumn.DataPropertyName = "Fx";
            this.fxDataGridViewTextBoxColumn.HeaderText = "Fx";
            this.fxDataGridViewTextBoxColumn.Name = "fxDataGridViewTextBoxColumn";
            this.fxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(HillClimbing.classes.Individual);
            // 
            // generationBindingSource
            // 
            this.generationBindingSource.DataSource = typeof(HillClimbing.classes.Generation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 778);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.dBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Button algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource generationBindingSource;
        private System.Windows.Forms.Button startTestBtn;
        private System.Windows.Forms.DataGridView testTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solveCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generationBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
    }
}

