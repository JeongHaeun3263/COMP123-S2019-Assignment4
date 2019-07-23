namespace COMP123_S2019_Assignment4
{
    partial class BMICalculatorForm
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
            this.BMICalculateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialradioButton = new System.Windows.Forms.RadioButton();
            this.BMIResulttextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalBMIButton = new System.Windows.Forms.Button();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculateTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculateTableLayoutPanel
            // 
            this.BMICalculateTableLayoutPanel.ColumnCount = 4;
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.Controls.Add(this.HeightTextBox, 2, 1);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.MetricRadioButton, 2, 0);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.ImperialradioButton, 0, 0);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.BMIResulttextBox, 0, 4);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.CalBMIButton, 0, 3);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.WeightTextBox, 2, 2);
            this.BMICalculateTableLayoutPanel.Location = new System.Drawing.Point(15, 12);
            this.BMICalculateTableLayoutPanel.Name = "BMICalculateTableLayoutPanel";
            this.BMICalculateTableLayoutPanel.RowCount = 8;
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.Size = new System.Drawing.Size(278, 409);
            this.BMICalculateTableLayoutPanel.TabIndex = 0;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightTextBox.Location = new System.Drawing.Point(141, 54);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(134, 30);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            this.HeightTextBox.Enter += new System.EventHandler(this.HeightTextBox_Enter);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MetricRadioButton.Location = new System.Drawing.Point(141, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(134, 45);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialradioButton
            // 
            this.ImperialradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialradioButton.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.ImperialradioButton, 2);
            this.ImperialradioButton.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImperialradioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialradioButton.Name = "ImperialradioButton";
            this.ImperialradioButton.Size = new System.Drawing.Size(132, 45);
            this.ImperialradioButton.TabIndex = 1;
            this.ImperialradioButton.TabStop = true;
            this.ImperialradioButton.Text = "Imperial";
            this.ImperialradioButton.UseVisualStyleBackColor = true;
            this.ImperialradioButton.CheckedChanged += new System.EventHandler(this.ImperialradioButton_CheckedChanged);
            // 
            // BMIResulttextBox
            // 
            this.BMIResulttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.BMIResulttextBox, 4);
            this.BMIResulttextBox.Location = new System.Drawing.Point(3, 207);
            this.BMIResulttextBox.Multiline = true;
            this.BMIResulttextBox.Name = "BMIResulttextBox";
            this.BMICalculateTableLayoutPanel.SetRowSpan(this.BMIResulttextBox, 4);
            this.BMIResulttextBox.Size = new System.Drawing.Size(272, 199);
            this.BMIResulttextBox.TabIndex = 1;
            this.BMIResulttextBox.TextChanged += new System.EventHandler(this.BMIResulttextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 51);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(132, 51);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 102);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(132, 51);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalBMIButton
            // 
            this.CalBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.CalBMIButton, 4);
            this.CalBMIButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalBMIButton.Location = new System.Drawing.Point(3, 156);
            this.CalBMIButton.Name = "CalBMIButton";
            this.CalBMIButton.Size = new System.Drawing.Size(272, 45);
            this.CalBMIButton.TabIndex = 7;
            this.CalBMIButton.Text = " Calculate BMI Button";
            this.CalBMIButton.UseVisualStyleBackColor = true;
            this.CalBMIButton.Click += new System.EventHandler(this.CalBMIButton_Click);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightTextBox.Location = new System.Drawing.Point(141, 105);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(134, 30);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.Enter += new System.EventHandler(this.WeightTextBox_Enter);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BMICalculateTableLayoutPanel);
            this.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.BMICalculateTableLayoutPanel.ResumeLayout(false);
            this.BMICalculateTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculateTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialradioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalBMIButton;
        private System.Windows.Forms.TextBox BMIResulttextBox;
    }
}

