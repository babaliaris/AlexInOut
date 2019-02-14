namespace AlexInOut
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.εξαγωγήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έσοδαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.μαζίToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registered_date_picker = new System.Windows.Forms.DateTimePicker();
            this.register_out_radio = new System.Windows.Forms.RadioButton();
            this.register_in_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.register_category_picker = new System.Windows.Forms.ComboBox();
            this.register_submit_btn = new System.Windows.Forms.Button();
            this.register_value_entry = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.analysis_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.analysis_to_picker = new System.Windows.Forms.DateTimePicker();
            this.analysis_category_chooser = new System.Windows.Forms.ComboBox();
            this.analysis_from_picker = new System.Windows.Forms.DateTimePicker();
            this.register_info_group = new System.Windows.Forms.GroupBox();
            this.register_info_type_label = new System.Windows.Forms.Label();
            this.register_info_price_label = new System.Windows.Forms.Label();
            this.register_info_date_label = new System.Windows.Forms.Label();
            this.register_info_category = new System.Windows.Forms.TextBox();
            this.register_info_type = new System.Windows.Forms.TextBox();
            this.register_info_price = new System.Windows.Forms.TextBox();
            this.register_info_date = new System.Windows.Forms.TextBox();
            this.register_info_category_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_value_entry)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysis_chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.register_info_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εξαγωγήToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // εξαγωγήToolStripMenuItem
            // 
            this.εξαγωγήToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.εξαγωγήToolStripMenuItem.Name = "εξαγωγήToolStripMenuItem";
            this.εξαγωγήToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.εξαγωγήToolStripMenuItem.Text = "Εξαγωγή";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.έσοδαToolStripMenuItem,
            this.έξοδαToolStripMenuItem,
            this.μαζίToolStripMenuItem});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // έσοδαToolStripMenuItem
            // 
            this.έσοδαToolStripMenuItem.Name = "έσοδαToolStripMenuItem";
            this.έσοδαToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.έσοδαToolStripMenuItem.Text = "Έσοδα";
            this.έσοδαToolStripMenuItem.Click += new System.EventHandler(this.έσοδαToolStripMenuItem_Click);
            // 
            // έξοδαToolStripMenuItem
            // 
            this.έξοδαToolStripMenuItem.Name = "έξοδαToolStripMenuItem";
            this.έξοδαToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.έξοδαToolStripMenuItem.Text = "Έξοδα";
            this.έξοδαToolStripMenuItem.Click += new System.EventHandler(this.έξοδαToolStripMenuItem_Click);
            // 
            // μαζίToolStripMenuItem
            // 
            this.μαζίToolStripMenuItem.Name = "μαζίToolStripMenuItem";
            this.μαζίToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.μαζίToolStripMenuItem.Text = "Μαζί";
            this.μαζίToolStripMenuItem.Click += new System.EventHandler(this.μαζίToolStripMenuItem_Click);
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.register_info_group);
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.registered_date_picker);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ημερομηνία";
            // 
            // registered_date_picker
            // 
            this.registered_date_picker.Location = new System.Drawing.Point(6, 67);
            this.registered_date_picker.Name = "registered_date_picker";
            this.registered_date_picker.Size = new System.Drawing.Size(200, 20);
            this.registered_date_picker.TabIndex = 7;
            this.registered_date_picker.ValueChanged += new System.EventHandler(this.registered_date_picker_ValueChanged);
            // 
            // register_out_radio
            // 
            this.register_out_radio.AutoSize = true;
            this.register_out_radio.ForeColor = System.Drawing.Color.Red;
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
            this.register_in_radio.ForeColor = System.Drawing.Color.DarkGreen;
            this.register_in_radio.Location = new System.Drawing.Point(6, 19);
            this.register_in_radio.Name = "register_in_radio";
            this.register_in_radio.Size = new System.Drawing.Size(59, 17);
            this.register_in_radio.TabIndex = 5;
            this.register_in_radio.TabStop = true;
            this.register_in_radio.Text = "Έσοδα";
            this.register_in_radio.UseVisualStyleBackColor = true;
            this.register_in_radio.CheckedChanged += new System.EventHandler(this.register_in_radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(325, 51);
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
            this.register_category_picker.Location = new System.Drawing.Point(325, 67);
            this.register_category_picker.Name = "register_category_picker";
            this.register_category_picker.Size = new System.Drawing.Size(333, 21);
            this.register_category_picker.TabIndex = 3;
            this.register_category_picker.SelectedIndexChanged += new System.EventHandler(this.register_category_picker_SelectedIndexChanged);
            // 
            // register_submit_btn
            // 
            this.register_submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.register_submit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.register_submit_btn.Location = new System.Drawing.Point(674, 65);
            this.register_submit_btn.Name = "register_submit_btn";
            this.register_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.register_submit_btn.TabIndex = 4;
            this.register_submit_btn.Text = "Προσθήκη";
            this.register_submit_btn.UseVisualStyleBackColor = true;
            this.register_submit_btn.Click += new System.EventHandler(this.register_submit_btn_Click);
            // 
            // register_value_entry
            // 
            this.register_value_entry.DecimalPlaces = 2;
            this.register_value_entry.Location = new System.Drawing.Point(212, 67);
            this.register_value_entry.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.register_value_entry.Name = "register_value_entry";
            this.register_value_entry.Size = new System.Drawing.Size(107, 20);
            this.register_value_entry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(209, 51);
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
            // analysis_chart
            // 
            this.analysis_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.analysis_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.analysis_chart.Legends.Add(legend3);
            this.analysis_chart.Location = new System.Drawing.Point(4, 52);
            this.analysis_chart.Name = "analysis_chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Τιμή";
            this.analysis_chart.Series.Add(series3);
            this.analysis_chart.Size = new System.Drawing.Size(760, 329);
            this.analysis_chart.TabIndex = 1;
            this.analysis_chart.Text = "chart1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Κατηγορία";
            // 
            // analysis_to_picker
            // 
            this.analysis_to_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analysis_to_picker.Location = new System.Drawing.Point(538, 14);
            this.analysis_to_picker.Name = "analysis_to_picker";
            this.analysis_to_picker.Size = new System.Drawing.Size(200, 20);
            this.analysis_to_picker.TabIndex = 3;
            this.analysis_to_picker.ValueChanged += new System.EventHandler(this.analysis_to_picker_ValueChanged);
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
            this.analysis_category_chooser.SelectedIndexChanged += new System.EventHandler(this.analysis_category_chooser_SelectedIndexChanged);
            // 
            // analysis_from_picker
            // 
            this.analysis_from_picker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analysis_from_picker.Location = new System.Drawing.Point(310, 14);
            this.analysis_from_picker.Name = "analysis_from_picker";
            this.analysis_from_picker.Size = new System.Drawing.Size(200, 20);
            this.analysis_from_picker.TabIndex = 2;
            this.analysis_from_picker.ValueChanged += new System.EventHandler(this.analysis_from_picker_ValueChanged);
            // 
            // register_info_group
            // 
            this.register_info_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_info_group.Controls.Add(this.register_info_category_label);
            this.register_info_group.Controls.Add(this.register_info_date);
            this.register_info_group.Controls.Add(this.register_info_price);
            this.register_info_group.Controls.Add(this.register_info_type);
            this.register_info_group.Controls.Add(this.register_info_category);
            this.register_info_group.Controls.Add(this.register_info_date_label);
            this.register_info_group.Controls.Add(this.register_info_price_label);
            this.register_info_group.Controls.Add(this.register_info_type_label);
            this.register_info_group.ForeColor = System.Drawing.Color.DarkGreen;
            this.register_info_group.Location = new System.Drawing.Point(6, 123);
            this.register_info_group.Name = "register_info_group";
            this.register_info_group.Size = new System.Drawing.Size(755, 152);
            this.register_info_group.TabIndex = 1;
            this.register_info_group.TabStop = false;
            this.register_info_group.Text = "Πληροφορίες";
            // 
            // register_info_type_label
            // 
            this.register_info_type_label.AutoSize = true;
            this.register_info_type_label.Location = new System.Drawing.Point(6, 60);
            this.register_info_type_label.Name = "register_info_type_label";
            this.register_info_type_label.Size = new System.Drawing.Size(37, 13);
            this.register_info_type_label.TabIndex = 1;
            this.register_info_type_label.Text = "Τύπος";
            // 
            // register_info_price_label
            // 
            this.register_info_price_label.AutoSize = true;
            this.register_info_price_label.Location = new System.Drawing.Point(9, 86);
            this.register_info_price_label.Name = "register_info_price_label";
            this.register_info_price_label.Size = new System.Drawing.Size(28, 13);
            this.register_info_price_label.TabIndex = 2;
            this.register_info_price_label.Text = "Τιμή";
            // 
            // register_info_date_label
            // 
            this.register_info_date_label.AutoSize = true;
            this.register_info_date_label.Location = new System.Drawing.Point(9, 112);
            this.register_info_date_label.Name = "register_info_date_label";
            this.register_info_date_label.Size = new System.Drawing.Size(66, 13);
            this.register_info_date_label.TabIndex = 3;
            this.register_info_date_label.Text = "Ημερομηνία";
            // 
            // register_info_category
            // 
            this.register_info_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_info_category.Location = new System.Drawing.Point(88, 31);
            this.register_info_category.Name = "register_info_category";
            this.register_info_category.ReadOnly = true;
            this.register_info_category.Size = new System.Drawing.Size(661, 20);
            this.register_info_category.TabIndex = 4;
            // 
            // register_info_type
            // 
            this.register_info_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_info_type.Location = new System.Drawing.Point(88, 57);
            this.register_info_type.Name = "register_info_type";
            this.register_info_type.ReadOnly = true;
            this.register_info_type.Size = new System.Drawing.Size(661, 20);
            this.register_info_type.TabIndex = 5;
            // 
            // register_info_price
            // 
            this.register_info_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_info_price.Location = new System.Drawing.Point(88, 83);
            this.register_info_price.Name = "register_info_price";
            this.register_info_price.ReadOnly = true;
            this.register_info_price.Size = new System.Drawing.Size(661, 20);
            this.register_info_price.TabIndex = 6;
            // 
            // register_info_date
            // 
            this.register_info_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_info_date.Location = new System.Drawing.Point(88, 109);
            this.register_info_date.Name = "register_info_date";
            this.register_info_date.ReadOnly = true;
            this.register_info_date.Size = new System.Drawing.Size(661, 20);
            this.register_info_date.TabIndex = 7;
            // 
            // register_info_category_label
            // 
            this.register_info_category_label.AutoSize = true;
            this.register_info_category_label.Location = new System.Drawing.Point(6, 34);
            this.register_info_category_label.Name = "register_info_category_label";
            this.register_info_category_label.Size = new System.Drawing.Size(60, 13);
            this.register_info_category_label.TabIndex = 8;
            this.register_info_category_label.Text = "Κατηγορία";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_value_entry)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analysis_chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.register_info_group.ResumeLayout(false);
            this.register_info_group.PerformLayout();
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
        private System.Windows.Forms.Button register_submit_btn;
        private System.Windows.Forms.NumericUpDown register_value_entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker analysis_to_picker;
        private System.Windows.Forms.ComboBox analysis_category_chooser;
        private System.Windows.Forms.DataVisualization.Charting.Chart analysis_chart;
        public System.Windows.Forms.ComboBox register_category_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker registered_date_picker;
        private System.Windows.Forms.ToolStripMenuItem εξαγωγήToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έσοδαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem μαζίToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker analysis_from_picker;
        private System.Windows.Forms.GroupBox register_info_group;
        private System.Windows.Forms.TextBox register_info_date;
        private System.Windows.Forms.TextBox register_info_price;
        private System.Windows.Forms.TextBox register_info_type;
        private System.Windows.Forms.TextBox register_info_category;
        private System.Windows.Forms.Label register_info_date_label;
        private System.Windows.Forms.Label register_info_price_label;
        private System.Windows.Forms.Label register_info_type_label;
        private System.Windows.Forms.Label register_info_category_label;
    }
}

