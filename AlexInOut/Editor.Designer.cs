namespace AlexInOut
{
    partial class Editor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editor_category_chooser = new System.Windows.Forms.ComboBox();
            this.editor_entry = new System.Windows.Forms.TextBox();
            this.editor_insert_radio = new System.Windows.Forms.RadioButton();
            this.editor_edit_radio = new System.Windows.Forms.RadioButton();
            this.editor_submit_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.editor_submit_btn);
            this.groupBox1.Controls.Add(this.editor_entry);
            this.groupBox1.Controls.Add(this.editor_category_chooser);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Φόρμα";
            // 
            // editor_category_chooser
            // 
            this.editor_category_chooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editor_category_chooser.FormattingEnabled = true;
            this.editor_category_chooser.Location = new System.Drawing.Point(111, 35);
            this.editor_category_chooser.Name = "editor_category_chooser";
            this.editor_category_chooser.Size = new System.Drawing.Size(294, 21);
            this.editor_category_chooser.TabIndex = 0;
            // 
            // editor_entry
            // 
            this.editor_entry.Location = new System.Drawing.Point(111, 121);
            this.editor_entry.Name = "editor_entry";
            this.editor_entry.Size = new System.Drawing.Size(294, 20);
            this.editor_entry.TabIndex = 1;
            // 
            // editor_insert_radio
            // 
            this.editor_insert_radio.AutoSize = true;
            this.editor_insert_radio.Location = new System.Drawing.Point(6, 19);
            this.editor_insert_radio.Name = "editor_insert_radio";
            this.editor_insert_radio.Size = new System.Drawing.Size(74, 17);
            this.editor_insert_radio.TabIndex = 2;
            this.editor_insert_radio.TabStop = true;
            this.editor_insert_radio.Text = "Εισαγωγή";
            this.editor_insert_radio.UseVisualStyleBackColor = true;
            // 
            // editor_edit_radio
            // 
            this.editor_edit_radio.AutoSize = true;
            this.editor_edit_radio.Location = new System.Drawing.Point(6, 42);
            this.editor_edit_radio.Name = "editor_edit_radio";
            this.editor_edit_radio.Size = new System.Drawing.Size(90, 17);
            this.editor_edit_radio.TabIndex = 3;
            this.editor_edit_radio.TabStop = true;
            this.editor_edit_radio.Text = "Επεξεργασία";
            this.editor_edit_radio.UseVisualStyleBackColor = true;
            // 
            // editor_submit_btn
            // 
            this.editor_submit_btn.Location = new System.Drawing.Point(111, 160);
            this.editor_submit_btn.Name = "editor_submit_btn";
            this.editor_submit_btn.Size = new System.Drawing.Size(294, 23);
            this.editor_submit_btn.TabIndex = 4;
            this.editor_submit_btn.Text = "Εισαγωγή";
            this.editor_submit_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editor_insert_radio);
            this.groupBox2.Controls.Add(this.editor_edit_radio);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Λειτουργία";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Κατηγορία";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Επιλογή Κατηγορίας";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 230);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Editor";
            this.Text = "Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton editor_insert_radio;
        private System.Windows.Forms.RadioButton editor_edit_radio;
        private System.Windows.Forms.Button editor_submit_btn;
        private System.Windows.Forms.TextBox editor_entry;
        private System.Windows.Forms.ComboBox editor_category_chooser;
    }
}