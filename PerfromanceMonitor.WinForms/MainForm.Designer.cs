
namespace PerfromanceMonitor.WinForms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lstInstances = new System.Windows.Forms.ListBox();
            this.lstCounters = new System.Windows.Forms.ListBox();
            this.lblCatHelp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCounterHelp = new System.Windows.Forms.Label();
            this.lstAddedCounters = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTipDuplicate = new System.Windows.Forms.ToolTip(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSelCounterInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSamplingInterval = new System.Windows.Forms.ComboBox();
            this.mainWindowViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories:";
            // 
            // lstCategories
            // 
            this.lstCategories.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mainWindowViewModelBindingSource, "CurrentCategory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lstCategories.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.mainWindowViewModelBindingSource, "Categories", true));
            this.lstCategories.DisplayMember = "CategoryName";
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(15, 25);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(193, 316);
            this.lstCategories.TabIndex = 1;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lstInstances
            // 
            this.lstInstances.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mainWindowViewModelBindingSource, "CurrentInstance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lstInstances.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.mainWindowViewModelBindingSource, "Instances", true));
            this.lstInstances.FormattingEnabled = true;
            this.lstInstances.Location = new System.Drawing.Point(214, 25);
            this.lstInstances.Name = "lstInstances";
            this.lstInstances.Size = new System.Drawing.Size(193, 316);
            this.lstInstances.TabIndex = 2;
            // 
            // lstCounters
            // 
            this.lstCounters.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mainWindowViewModelBindingSource, "CurrentCounter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lstCounters.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.mainWindowViewModelBindingSource, "Counters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lstCounters.DisplayMember = "CounterName";
            this.lstCounters.FormattingEnabled = true;
            this.lstCounters.Location = new System.Drawing.Point(413, 25);
            this.lstCounters.Name = "lstCounters";
            this.lstCounters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCounters.Size = new System.Drawing.Size(193, 316);
            this.lstCounters.TabIndex = 3;
            this.lstCounters.SelectedIndexChanged += new System.EventHandler(this.lstCounters_SelectedIndexChanged);
            // 
            // lblCatHelp
            // 
            this.lblCatHelp.AutoEllipsis = true;
            this.lblCatHelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainWindowViewModelBindingSource, "CurrentCategoryHelp", true));
            this.lblCatHelp.Location = new System.Drawing.Point(12, 344);
            this.lblCatHelp.MinimumSize = new System.Drawing.Size(20, 0);
            this.lblCatHelp.Name = "lblCatHelp";
            this.lblCatHelp.Size = new System.Drawing.Size(196, 97);
            this.lblCatHelp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instances:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Counters:";
            // 
            // lblCounterHelp
            // 
            this.lblCounterHelp.AutoEllipsis = true;
            this.lblCounterHelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainWindowViewModelBindingSource, "CurrentCounterHelp", true));
            this.lblCounterHelp.Location = new System.Drawing.Point(413, 344);
            this.lblCounterHelp.MinimumSize = new System.Drawing.Size(20, 0);
            this.lblCounterHelp.Name = "lblCounterHelp";
            this.lblCounterHelp.Size = new System.Drawing.Size(196, 97);
            this.lblCounterHelp.TabIndex = 4;
            // 
            // lstAddedCounters
            // 
            this.lstAddedCounters.FormattingEnabled = true;
            this.lstAddedCounters.Location = new System.Drawing.Point(693, 25);
            this.lstAddedCounters.Name = "lstAddedCounters";
            this.lstAddedCounters.Size = new System.Drawing.Size(181, 316);
            this.lstAddedCounters.TabIndex = 5;
            this.lstAddedCounters.SelectedIndexChanged += new System.EventHandler(this.lstAddedCounters_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(612, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolTipDuplicate
            // 
            this.toolTipDuplicate.ToolTipTitle = "Some counters are already addded.";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(720, 388);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 50);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblSelCounterInfo
            // 
            this.lblSelCounterInfo.Location = new System.Drawing.Point(693, 348);
            this.lblSelCounterInfo.Name = "lblSelCounterInfo";
            this.lblSelCounterInfo.Size = new System.Drawing.Size(181, 37);
            this.lblSelCounterInfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sampling Interval:";
            // 
            // cbSamplingInterval
            // 
            this.cbSamplingInterval.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainWindowViewModelBindingSource, "SelectedInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbSamplingInterval.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.mainWindowViewModelBindingSource, "AllIntervals", true));
            this.cbSamplingInterval.DisplayMember = "Text";
            this.cbSamplingInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSamplingInterval.FormattingEnabled = true;
            this.cbSamplingInterval.Location = new System.Drawing.Point(615, 404);
            this.cbSamplingInterval.Name = "cbSamplingInterval";
            this.cbSamplingInterval.Size = new System.Drawing.Size(99, 21);
            this.cbSamplingInterval.TabIndex = 10;
            // 
            // mainWindowViewModelBindingSource
            // 
            this.mainWindowViewModelBindingSource.DataSource = typeof(PerformanceMonitor.Model.MainWindowViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.cbSamplingInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSelCounterInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAddedCounters);
            this.Controls.Add(this.lblCounterHelp);
            this.Controls.Add(this.lblCatHelp);
            this.Controls.Add(this.lstCounters);
            this.Controls.Add(this.lstInstances);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Performance Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListBox lstInstances;
        private System.Windows.Forms.ListBox lstCounters;
        private System.Windows.Forms.Label lblCatHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource mainWindowViewModelBindingSource;
        private System.Windows.Forms.Label lblCounterHelp;
        private System.Windows.Forms.ListBox lstAddedCounters;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTipDuplicate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSelCounterInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSamplingInterval;
    }
}

