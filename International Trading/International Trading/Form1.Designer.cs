namespace International_Trading
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
            this.country_listbox = new System.Windows.Forms.ListBox();
            this.gdpGrowth_textBox = new System.Windows.Forms.TextBox();
            this.uniqueC_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inflation_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tradeBalance_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hdiRanking_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gdpGrowth_editButton = new System.Windows.Forms.Button();
            this.Inflation_editButton = new System.Windows.Forms.Button();
            this.tradeBalance_editButton = new System.Windows.Forms.Button();
            this.hdiRanking_editButton = new System.Windows.Forms.Button();
            this.tradePartners_editButton = new System.Windows.Forms.Button();
            this.Depth_label = new System.Windows.Forms.Label();
            this.Remove_button = new System.Windows.Forms.Button();
            this.order_checkBox = new System.Windows.Forms.CheckBox();
            this.tradePartner_listBox = new System.Windows.Forms.ListBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // country_listbox
            // 
            this.country_listbox.FormattingEnabled = true;
            this.country_listbox.Location = new System.Drawing.Point(12, 43);
            this.country_listbox.Name = "country_listbox";
            this.country_listbox.Size = new System.Drawing.Size(123, 277);
            this.country_listbox.TabIndex = 0;
            this.country_listbox.SelectedIndexChanged += new System.EventHandler(this.country_listbox_SelectedIndexChanged);
            // 
            // gdpGrowth_textBox
            // 
            this.gdpGrowth_textBox.Location = new System.Drawing.Point(150, 59);
            this.gdpGrowth_textBox.Name = "gdpGrowth_textBox";
            this.gdpGrowth_textBox.Size = new System.Drawing.Size(120, 20);
            this.gdpGrowth_textBox.TabIndex = 1;
            // 
            // uniqueC_label
            // 
            this.uniqueC_label.AutoSize = true;
            this.uniqueC_label.Location = new System.Drawing.Point(13, 24);
            this.uniqueC_label.Name = "uniqueC_label";
            this.uniqueC_label.Size = new System.Drawing.Size(51, 13);
            this.uniqueC_label.TabIndex = 2;
            this.uniqueC_label.Text = "Countries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GDP Growth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inflation";
            // 
            // inflation_textBox
            // 
            this.inflation_textBox.Location = new System.Drawing.Point(151, 106);
            this.inflation_textBox.Name = "inflation_textBox";
            this.inflation_textBox.Size = new System.Drawing.Size(120, 20);
            this.inflation_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trade Balance";
            // 
            // tradeBalance_textBox
            // 
            this.tradeBalance_textBox.Location = new System.Drawing.Point(150, 155);
            this.tradeBalance_textBox.Name = "tradeBalance_textBox";
            this.tradeBalance_textBox.Size = new System.Drawing.Size(120, 20);
            this.tradeBalance_textBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HDI Ranking";
            // 
            // hdiRanking_textBox
            // 
            this.hdiRanking_textBox.Location = new System.Drawing.Point(150, 204);
            this.hdiRanking_textBox.Name = "hdiRanking_textBox";
            this.hdiRanking_textBox.Size = new System.Drawing.Size(120, 20);
            this.hdiRanking_textBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trade Partners";
            // 
            // gdpGrowth_editButton
            // 
            this.gdpGrowth_editButton.Location = new System.Drawing.Point(276, 59);
            this.gdpGrowth_editButton.Name = "gdpGrowth_editButton";
            this.gdpGrowth_editButton.Size = new System.Drawing.Size(75, 20);
            this.gdpGrowth_editButton.TabIndex = 12;
            this.gdpGrowth_editButton.Text = "Edit";
            this.gdpGrowth_editButton.UseVisualStyleBackColor = true;
            this.gdpGrowth_editButton.Click += new System.EventHandler(this.gdpGrowth_editButton_Click);
            // 
            // Inflation_editButton
            // 
            this.Inflation_editButton.Location = new System.Drawing.Point(276, 106);
            this.Inflation_editButton.Name = "Inflation_editButton";
            this.Inflation_editButton.Size = new System.Drawing.Size(75, 20);
            this.Inflation_editButton.TabIndex = 13;
            this.Inflation_editButton.Text = "Edit";
            this.Inflation_editButton.UseVisualStyleBackColor = true;
            this.Inflation_editButton.Click += new System.EventHandler(this.Inflation_editButton_Click);
            // 
            // tradeBalance_editButton
            // 
            this.tradeBalance_editButton.Location = new System.Drawing.Point(275, 155);
            this.tradeBalance_editButton.Name = "tradeBalance_editButton";
            this.tradeBalance_editButton.Size = new System.Drawing.Size(75, 20);
            this.tradeBalance_editButton.TabIndex = 14;
            this.tradeBalance_editButton.Text = "Edit";
            this.tradeBalance_editButton.UseVisualStyleBackColor = true;
            this.tradeBalance_editButton.Click += new System.EventHandler(this.tradeBalance_editButton_Click);
            // 
            // hdiRanking_editButton
            // 
            this.hdiRanking_editButton.Location = new System.Drawing.Point(276, 203);
            this.hdiRanking_editButton.Name = "hdiRanking_editButton";
            this.hdiRanking_editButton.Size = new System.Drawing.Size(75, 20);
            this.hdiRanking_editButton.TabIndex = 15;
            this.hdiRanking_editButton.Text = "Edit";
            this.hdiRanking_editButton.UseVisualStyleBackColor = true;
            this.hdiRanking_editButton.Click += new System.EventHandler(this.hdiRanking_editButton_Click);
            // 
            // tradePartners_editButton
            // 
            this.tradePartners_editButton.Location = new System.Drawing.Point(276, 252);
            this.tradePartners_editButton.Name = "tradePartners_editButton";
            this.tradePartners_editButton.Size = new System.Drawing.Size(75, 20);
            this.tradePartners_editButton.TabIndex = 16;
            this.tradePartners_editButton.Text = "Edit";
            this.tradePartners_editButton.UseVisualStyleBackColor = true;
            this.tradePartners_editButton.Click += new System.EventHandler(this.tradePartners_editButton_Click);
            // 
            // Depth_label
            // 
            this.Depth_label.AutoSize = true;
            this.Depth_label.Location = new System.Drawing.Point(13, 9);
            this.Depth_label.Name = "Depth_label";
            this.Depth_label.Size = new System.Drawing.Size(36, 13);
            this.Depth_label.TabIndex = 17;
            this.Depth_label.Text = "Depth";
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(12, 373);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(123, 23);
            this.Remove_button.TabIndex = 18;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // order_checkBox
            // 
            this.order_checkBox.AutoSize = true;
            this.order_checkBox.Location = new System.Drawing.Point(12, 341);
            this.order_checkBox.Name = "order_checkBox";
            this.order_checkBox.Size = new System.Drawing.Size(52, 17);
            this.order_checkBox.TabIndex = 19;
            this.order_checkBox.Text = "Order";
            this.order_checkBox.UseVisualStyleBackColor = true;
            this.order_checkBox.CheckedChanged += new System.EventHandler(this.order_checkBox_CheckedChanged);
            // 
            // tradePartner_listBox
            // 
            this.tradePartner_listBox.FormattingEnabled = true;
            this.tradePartner_listBox.Location = new System.Drawing.Point(150, 252);
            this.tradePartner_listBox.Name = "tradePartner_listBox";
            this.tradePartner_listBox.Size = new System.Drawing.Size(120, 69);
            this.tradePartner_listBox.TabIndex = 20;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(70, 335);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(65, 23);
            this.Search_Button.TabIndex = 21;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 411);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.tradePartner_listBox);
            this.Controls.Add(this.order_checkBox);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Depth_label);
            this.Controls.Add(this.tradePartners_editButton);
            this.Controls.Add(this.hdiRanking_editButton);
            this.Controls.Add(this.tradeBalance_editButton);
            this.Controls.Add(this.Inflation_editButton);
            this.Controls.Add(this.gdpGrowth_editButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hdiRanking_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tradeBalance_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inflation_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniqueC_label);
            this.Controls.Add(this.gdpGrowth_textBox);
            this.Controls.Add(this.country_listbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internation Trading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox country_listbox;
        private System.Windows.Forms.TextBox gdpGrowth_textBox;
        private System.Windows.Forms.Label uniqueC_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inflation_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tradeBalance_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hdiRanking_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button gdpGrowth_editButton;
        private System.Windows.Forms.Button Inflation_editButton;
        private System.Windows.Forms.Button tradeBalance_editButton;
        private System.Windows.Forms.Button hdiRanking_editButton;
        private System.Windows.Forms.Button tradePartners_editButton;
        private System.Windows.Forms.Label Depth_label;
        private System.Windows.Forms.Button Remove_button;
        public System.Windows.Forms.CheckBox order_checkBox;
        private System.Windows.Forms.ListBox tradePartner_listBox;
        private System.Windows.Forms.Button Search_Button;
    }
}

