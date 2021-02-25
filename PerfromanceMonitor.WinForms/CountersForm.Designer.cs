
namespace PerfromanceMonitor.WinForms
{
    partial class CountersForm
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
            this.mainWindowViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstInstances = new System.Windows.Forms.ListBox();
            this.lstCounters = new System.Windows.Forms.ListBox();
            this.lblCatHelp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCounterHelp = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
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
            // 
            // mainWindowViewModelBindingSource
            // 
            this.mainWindowViewModelBindingSource.DataSource = typeof(PerformanceMonitor.Model.CountersFormViewModel);
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
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(625, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 69);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CountersForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCounterHelp);
            this.Controls.Add(this.lblCatHelp);
            this.Controls.Add(this.lstCounters);
            this.Controls.Add(this.lstInstances);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CountersForm";
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
        private System.Windows.Forms.Button btnOK;
    }
}

