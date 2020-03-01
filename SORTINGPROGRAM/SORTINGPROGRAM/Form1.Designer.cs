namespace SORTINGPROGRAM
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
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.txtBoxEnd = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelDescending = new System.Windows.Forms.Label();
            this.labelAscending = new System.Windows.Forms.Label();
            this.listBoxOriginal = new System.Windows.Forms.ListBox();
            this.listBoxAscending = new System.Windows.Forms.ListBox();
            this.listBoxDescending = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(12, 9);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(46, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "START:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(170, 9);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(33, 13);
            this.labelEnd.TabIndex = 1;
            this.labelEnd.Text = "END:";
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Location = new System.Drawing.Point(64, 6);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStart.TabIndex = 2;
            this.txtBoxStart.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtBoxStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Location = new System.Drawing.Point(209, 6);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEnd.TabIndex = 3;
            this.txtBoxEnd.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtBoxEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // buttonSort
            // 
            this.buttonSort.Enabled = false;
            this.buttonSort.Location = new System.Drawing.Point(315, 4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "SORT";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(38, 73);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(58, 13);
            this.labelOriginal.TabIndex = 5;
            this.labelOriginal.Text = "ORIGINAL";
            // 
            // labelDescending
            // 
            this.labelDescending.AutoSize = true;
            this.labelDescending.Location = new System.Drawing.Point(356, 73);
            this.labelDescending.Name = "labelDescending";
            this.labelDescending.Size = new System.Drawing.Size(78, 13);
            this.labelDescending.TabIndex = 6;
            this.labelDescending.Text = "DESCENDING";
            // 
            // labelAscending
            // 
            this.labelAscending.AutoSize = true;
            this.labelAscending.Location = new System.Drawing.Point(186, 73);
            this.labelAscending.Name = "labelAscending";
            this.labelAscending.Size = new System.Drawing.Size(70, 13);
            this.labelAscending.TabIndex = 7;
            this.labelAscending.Text = "ASCENDING";
            // 
            // listBoxOriginal
            // 
            this.listBoxOriginal.FormattingEnabled = true;
            this.listBoxOriginal.Location = new System.Drawing.Point(15, 89);
            this.listBoxOriginal.Name = "listBoxOriginal";
            this.listBoxOriginal.Size = new System.Drawing.Size(120, 251);
            this.listBoxOriginal.TabIndex = 8;
            // 
            // listBoxAscending
            // 
            this.listBoxAscending.FormattingEnabled = true;
            this.listBoxAscending.Location = new System.Drawing.Point(173, 89);
            this.listBoxAscending.Name = "listBoxAscending";
            this.listBoxAscending.Size = new System.Drawing.Size(120, 251);
            this.listBoxAscending.TabIndex = 9;
            // 
            // listBoxDescending
            // 
            this.listBoxDescending.FormattingEnabled = true;
            this.listBoxDescending.Location = new System.Drawing.Point(330, 89);
            this.listBoxDescending.Name = "listBoxDescending";
            this.listBoxDescending.Size = new System.Drawing.Size(120, 251);
            this.listBoxDescending.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 347);
            this.Controls.Add(this.listBoxDescending);
            this.Controls.Add(this.listBoxAscending);
            this.Controls.Add(this.listBoxOriginal);
            this.Controls.Add(this.labelAscending);
            this.Controls.Add(this.labelDescending);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.txtBoxEnd);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Name = "Form1";
            this.Text = "SORTING PROGRAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox txtBoxStart;
        private System.Windows.Forms.TextBox txtBoxEnd;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelDescending;
        private System.Windows.Forms.Label labelAscending;
        private System.Windows.Forms.ListBox listBoxOriginal;
        private System.Windows.Forms.ListBox listBoxAscending;
        private System.Windows.Forms.ListBox listBoxDescending;
    }
}

