﻿namespace AlexInOut
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.register_out_radio = new System.Windows.Forms.RadioButton();
            this.register_in_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.register_category_picker = new System.Windows.Forms.ComboBox();
            this.register_submit_btn = new System.Windows.Forms.Button();
            this.register_value_entry = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.analysis_category_chooser = new System.Windows.Forms.ComboBox();
            this.analysis_from_picker = new System.Windows.Forms.DateTimePicker();
            this.analysis_to_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.analysis_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_value_entry)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysis_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Καταχώρηση";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.register_out_radio);
            this.groupBox1.Controls.Add(this.register_in_radio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.register_category_picker);
            this.groupBox1.Controls.Add(this.register_submit_btn);
            this.groupBox1.Controls.Add(this.register_value_entry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Φόρμα Καταχώρησης";
            // 
            // register_out_radio
            // 
            this.register_out_radio.AutoSize = true;
            this.register_out_radio.Location = new System.Drawing.Point(71, 19);
            this.register_out_radio.Name = "register_out_radio";
            this.register_out_radio.Size = new System.Drawing.Size(57, 17);
            this.register_out_radio.TabIndex = 6;
            this.register_out_radio.TabStop = true;
            this.register_out_radio.Text = "Έξοδα";
            this.register_out_radio.UseVisualStyleBackColor = true;
            // 
            // register_in_radio
            // 
            this.register_in_radio.AutoSize = true;
            this.register_in_radio.Checked = true;
            this.register_in_radio.Location = new System.Drawing.Point(6, 19);
            this.register_in_radio.Name = "register_in_radio";
            this.register_in_radio.Size = new System.Drawing.Size(59, 17);
            this.register_in_radio.TabIndex = 5;
            this.register_in_radio.TabStop = true;
            this.register_in_radio.Text = "Έσοδα";
            this.register_in_radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Κατηγορία";
            // 
            // register_category_picker
            // 
            this.register_category_picker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_category_picker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.register_category_picker.FormattingEnabled = true;
            this.register_category_picker.Location = new System.Drawing.Point(212, 67);
            this.register_category_picker.Name = "register_category_picker";
            this.register_category_picker.Size = new System.Drawing.Size(446, 21);
            this.register_category_picker.TabIndex = 3;
            this.register_category_picker.Click += new System.EventHandler(this.register_category_picker_Click);
            // 
            // register_submit_btn
            // 
            this.register_submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.register_submit_btn.Location = new System.Drawing.Point(674, 65);
            this.register_submit_btn.Name = "register_submit_btn";
            this.register_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.register_submit_btn.TabIndex = 4;
            this.register_submit_btn.Text = "Προσθήκη";
            this.register_submit_btn.UseVisualStyleBackColor = true;
            // 
            // register_value_entry
            // 
            this.register_value_entry.DecimalPlaces = 2;
            this.register_value_entry.Location = new System.Drawing.Point(6, 68);
            this.register_value_entry.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.register_value_entry.Name = "register_value_entry";
            this.register_value_entry.Size = new System.Drawing.Size(200, 20);
            this.register_value_entry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Τιμή";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.analysis_chart);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(767, 384);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ανάλυση";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.analysis_to_picker);
            this.groupBox2.Controls.Add(this.analysis_category_chooser);
            this.groupBox2.Controls.Add(this.analysis_from_picker);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Επιλογή";
            // 
            // analysis_category_chooser
            // 
            this.analysis_category_chooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analysis_category_chooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.analysis_category_chooser.FormattingEnabled = true;
            this.analysis_category_chooser.Location = new System.Drawing.Point(72, 14);
            this.analysis_category_chooser.Name = "analysis_category_chooser";
            this.analysis_category_chooser.Size = new System.Drawing.Size(232, 21);
            this.analysis_category_chooser.TabIndex = 1;
            // 
            // analysis_from_picker
            // 
            this.analysis_from_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analysis_from_picker.Location = new System.Drawing.Point(310, 14);
            this.analysis_from_picker.Name = "analysis_from_picker";
            this.analysis_from_picker.Size = new System.Drawing.Size(200, 20);
            this.analysis_from_picker.TabIndex = 2;
            // 
            // analysis_to_picker
            // 
            this.analysis_to_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analysis_to_picker.Location = new System.Drawing.Point(538, 14);
            this.analysis_to_picker.Name = "analysis_to_picker";
            this.analysis_to_picker.Size = new System.Drawing.Size(200, 20);
            this.analysis_to_picker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Κατηγορία";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "--->";
            // 
            // analysis_chart
            // 
            this.analysis_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.analysis_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.analysis_chart.Legends.Add(legend1);
            this.analysis_chart.Location = new System.Drawing.Point(4, 52);
            this.analysis_chart.Name = "analysis_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Τιμή";
            this.analysis_chart.Series.Add(series1);
            this.analysis_chart.Size = new System.Drawing.Size(760, 329);
            this.analysis_chart.TabIndex = 1;
            this.analysis_chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AlexInOut";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_value_entry)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysis_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton register_out_radio;
        private System.Windows.Forms.RadioButton register_in_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox register_category_picker;
        private System.Windows.Forms.Button register_submit_btn;
        private System.Windows.Forms.NumericUpDown register_value_entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker analysis_to_picker;
        private System.Windows.Forms.ComboBox analysis_category_chooser;
        private System.Windows.Forms.DateTimePicker analysis_from_picker;
        private System.Windows.Forms.DataVisualization.Charting.Chart analysis_chart;
    }
}
