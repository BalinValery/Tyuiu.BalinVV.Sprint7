namespace Tyuiu.BalinVV.Sprint7.Project.V3
{
    partial class Func
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Func));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_BVV = new System.Windows.Forms.Panel();
            this.buttonLoadLesson_BVV = new System.Windows.Forms.Button();
            this.buttonLoadDepartment_BVV = new System.Windows.Forms.Button();
            this.buttonLoadClass_BVV = new System.Windows.Forms.Button();
            this.buttonLoadTeacher_BVV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartPre_BVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft_BVV.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPre_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_BVV
            // 
            this.panelLeft_BVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLeft_BVV.Controls.Add(this.buttonLoadLesson_BVV);
            this.panelLeft_BVV.Controls.Add(this.buttonLoadDepartment_BVV);
            this.panelLeft_BVV.Controls.Add(this.buttonLoadClass_BVV);
            this.panelLeft_BVV.Controls.Add(this.buttonLoadTeacher_BVV);
            this.panelLeft_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_BVV.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft_BVV.Name = "panelLeft_BVV";
            this.panelLeft_BVV.Size = new System.Drawing.Size(267, 617);
            this.panelLeft_BVV.TabIndex = 2;
            // 
            // buttonLoadLesson_BVV
            // 
            this.buttonLoadLesson_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadLesson_BVV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadLesson_BVV.FlatAppearance.BorderSize = 0;
            this.buttonLoadLesson_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadLesson_BVV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadLesson_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadLesson_BVV.Image")));
            this.buttonLoadLesson_BVV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadLesson_BVV.Location = new System.Drawing.Point(0, 459);
            this.buttonLoadLesson_BVV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadLesson_BVV.Name = "buttonLoadLesson_BVV";
            this.buttonLoadLesson_BVV.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadLesson_BVV.TabIndex = 3;
            this.buttonLoadLesson_BVV.Text = "Предметы";
            this.toolTip_BVV.SetToolTip(this.buttonLoadLesson_BVV, "Представление количества часов в виде диаграммы");
            this.buttonLoadLesson_BVV.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDepartment_BVV
            // 
            this.buttonLoadDepartment_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadDepartment_BVV.Enabled = false;
            this.buttonLoadDepartment_BVV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadDepartment_BVV.FlatAppearance.BorderSize = 0;
            this.buttonLoadDepartment_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadDepartment_BVV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadDepartment_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadDepartment_BVV.Image")));
            this.buttonLoadDepartment_BVV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadDepartment_BVV.Location = new System.Drawing.Point(0, 306);
            this.buttonLoadDepartment_BVV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadDepartment_BVV.Name = "buttonLoadDepartment_BVV";
            this.buttonLoadDepartment_BVV.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadDepartment_BVV.TabIndex = 2;
            this.buttonLoadDepartment_BVV.Text = "Кафедры";
            this.toolTip_BVV.SetToolTip(this.buttonLoadDepartment_BVV, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadDepartment_BVV.UseVisualStyleBackColor = true;
            // 
            // buttonLoadClass_BVV
            // 
            this.buttonLoadClass_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadClass_BVV.Enabled = false;
            this.buttonLoadClass_BVV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadClass_BVV.FlatAppearance.BorderSize = 0;
            this.buttonLoadClass_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadClass_BVV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadClass_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadClass_BVV.Image")));
            this.buttonLoadClass_BVV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadClass_BVV.Location = new System.Drawing.Point(0, 153);
            this.buttonLoadClass_BVV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadClass_BVV.Name = "buttonLoadClass_BVV";
            this.buttonLoadClass_BVV.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadClass_BVV.TabIndex = 1;
            this.buttonLoadClass_BVV.Text = "Аудитории";
            this.toolTip_BVV.SetToolTip(this.buttonLoadClass_BVV, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadClass_BVV.UseVisualStyleBackColor = true;
            // 
            // buttonLoadTeacher_BVV
            // 
            this.buttonLoadTeacher_BVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLoadTeacher_BVV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLoadTeacher_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadTeacher_BVV.Enabled = false;
            this.buttonLoadTeacher_BVV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadTeacher_BVV.FlatAppearance.BorderSize = 0;
            this.buttonLoadTeacher_BVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTeacher_BVV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadTeacher_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadTeacher_BVV.Image")));
            this.buttonLoadTeacher_BVV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadTeacher_BVV.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadTeacher_BVV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadTeacher_BVV.Name = "buttonLoadTeacher_BVV";
            this.buttonLoadTeacher_BVV.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadTeacher_BVV.TabIndex = 0;
            this.buttonLoadTeacher_BVV.Text = "Преподаватели";
            this.toolTip_BVV.SetToolTip(this.buttonLoadTeacher_BVV, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadTeacher_BVV.UseVisualStyleBackColor = false;
            this.buttonLoadTeacher_BVV.Click += new System.EventHandler(this.buttonLoadTeacher_BVV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartPre_BVV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(267, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 617);
            this.panel1.TabIndex = 3;
            // 
            // chartPre_BVV
            // 
            this.chartPre_BVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chartPre_BVV.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            this.chartPre_BVV.ChartAreas.Add(chartArea1);
            this.chartPre_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartPre_BVV.Legends.Add(legend1);
            this.chartPre_BVV.Location = new System.Drawing.Point(0, 0);
            this.chartPre_BVV.Margin = new System.Windows.Forms.Padding(4);
            this.chartPre_BVV.Name = "chartPre_BVV";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPre_BVV.Series.Add(series1);
            this.chartPre_BVV.Size = new System.Drawing.Size(945, 617);
            this.chartPre_BVV.TabIndex = 0;
            this.chartPre_BVV.Text = "chart1";
            this.chartPre_BVV.Click += new System.EventHandler(this.chartPre_BVV_Click);
            // 
            // Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft_BVV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1227, 654);
            this.Name = "Func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изображение значений таблиц в виде диаграммы";
            this.Load += new System.EventHandler(this.FormFunc_Load);
            this.panelLeft_BVV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPre_BVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_BVV;
        private System.Windows.Forms.Button buttonLoadLesson_BVV;
        private System.Windows.Forms.Button buttonLoadDepartment_BVV;
        private System.Windows.Forms.Button buttonLoadClass_BVV;
        private System.Windows.Forms.Button buttonLoadTeacher_BVV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPre_BVV;
        private System.Windows.Forms.ToolTip toolTip_BVV;
    }
}
  