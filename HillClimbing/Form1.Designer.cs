
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
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
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(21, 133);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(1207, 585);
            this.chart.TabIndex = 28;
            this.chart.Text = "chart1";
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(HillClimbing.classes.Individual);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 778);
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
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
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
    }
}

