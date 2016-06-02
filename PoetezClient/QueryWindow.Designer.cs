namespace PoetezClient
{
    partial class QueryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QueryEditor = new System.Windows.Forms.RichTextBox();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QueryEditor);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(667, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Editor";
            // 
            // QueryEditor
            // 
            this.QueryEditor.Location = new System.Drawing.Point(4, 17);
            this.QueryEditor.Margin = new System.Windows.Forms.Padding(2);
            this.QueryEditor.Name = "QueryEditor";
            this.QueryEditor.Size = new System.Drawing.Size(659, 129);
            this.QueryEditor.TabIndex = 0;
            this.QueryEditor.Text = "";
            this.QueryEditor.TextChanged += new System.EventHandler(this.QueryEditor_TextChanged);
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Location = new System.Drawing.Point(10, 208);
            this.ResultTable.Margin = new System.Windows.Forms.Padding(2);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowTemplate.Height = 24;
            this.ResultTable.Size = new System.Drawing.Size(667, 201);
            this.ResultTable.TabIndex = 2;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(529, 166);
            this.ExecuteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(148, 37);
            this.ExecuteBtn.TabIndex = 3;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QueryWindow";
            this.Text = "QueryWindow";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.RichTextBox QueryEditor;
    }
}