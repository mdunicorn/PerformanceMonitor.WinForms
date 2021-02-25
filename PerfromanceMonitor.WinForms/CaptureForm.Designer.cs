
namespace PerfromanceMonitor.WinForms
{
    partial class CaptureForm
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
            this.panelCharts = new System.Windows.Forms.Panel();
            this.cbSamplingInterval = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panelCharts
            // 
            this.panelCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCharts.AutoScroll = true;
            this.panelCharts.Location = new System.Drawing.Point(0, 0);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(800, 373);
            this.panelCharts.TabIndex = 0;
            // 
            // cbSamplingInterval
            // 
            this.cbSamplingInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSamplingInterval.DisplayMember = "Text";
            this.cbSamplingInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSamplingInterval.FormattingEnabled = true;
            this.cbSamplingInterval.Location = new System.Drawing.Point(109, 386);
            this.cbSamplingInterval.Name = "cbSamplingInterval";
            this.cbSamplingInterval.Size = new System.Drawing.Size(99, 21);
            this.cbSamplingInterval.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sampling Interval:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Visible TIme Range:";
            // 
            // cbRange
            // 
            this.cbRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Location = new System.Drawing.Point(357, 386);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(121, 21);
            this.cbRange.TabIndex = 14;
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSamplingInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelCharts);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.ComboBox cbSamplingInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRange;
    }
}