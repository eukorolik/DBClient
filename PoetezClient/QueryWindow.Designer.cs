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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактор запроса";
            // 
            // QueryEditor
            // 
            this.QueryEditor.Location = new System.Drawing.Point(6, 21);
            this.QueryEditor.Name = "QueryEditor";
            this.QueryEditor.Size = new System.Drawing.Size(877, 158);
            this.QueryEditor.TabIndex = 0;
            this.QueryEditor.Text = "";
            this.QueryEditor.TextChanged += new System.EventHandler(this.QueryEditor_TextChanged);
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Location = new System.Drawing.Point(13, 256);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowTemplate.Height = 24;
            this.ResultTable.Size = new System.Drawing.Size(889, 247);
            this.ResultTable.TabIndex = 2;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(705, 204);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(197, 46);
            this.ExecuteBtn.TabIndex = 3;
            this.ExecuteBtn.Text = "Выполнить";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.groupBox1);
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