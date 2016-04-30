namespace PoetezClient
{
    partial class PoetezClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoetezClient));
            this.WhichDBLabel = new System.Windows.Forms.Label();
            this.WhichTable = new System.Windows.Forms.Label();
            this.DBSelect = new System.Windows.Forms.ComboBox();
            this.DBTableSelect = new System.Windows.Forms.ComboBox();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.DataSaveButton = new System.Windows.Forms.Button();
            this.SQLBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WhichDBLabel
            // 
            this.WhichDBLabel.AutoSize = true;
            this.WhichDBLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhichDBLabel.Location = new System.Drawing.Point(13, 13);
            this.WhichDBLabel.Name = "WhichDBLabel";
            this.WhichDBLabel.Size = new System.Drawing.Size(117, 20);
            this.WhichDBLabel.TabIndex = 0;
            this.WhichDBLabel.Text = "Выберите базу";
            // 
            // WhichTable
            // 
            this.WhichTable.AutoSize = true;
            this.WhichTable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhichTable.Location = new System.Drawing.Point(13, 45);
            this.WhichTable.Name = "WhichTable";
            this.WhichTable.Size = new System.Drawing.Size(145, 20);
            this.WhichTable.TabIndex = 1;
            this.WhichTable.Text = "Выберите таблицу";
            // 
            // DBSelect
            // 
            this.DBSelect.FormattingEnabled = true;
            this.DBSelect.Location = new System.Drawing.Point(178, 12);
            this.DBSelect.Name = "DBSelect";
            this.DBSelect.Size = new System.Drawing.Size(211, 21);
            this.DBSelect.TabIndex = 2;
            this.DBSelect.SelectedIndexChanged += new System.EventHandler(this.DBSelect_SelectedIndexChanged);
            // 
            // DBTableSelect
            // 
            this.DBTableSelect.FormattingEnabled = true;
            this.DBTableSelect.Location = new System.Drawing.Point(178, 44);
            this.DBTableSelect.Name = "DBTableSelect";
            this.DBTableSelect.Size = new System.Drawing.Size(211, 21);
            this.DBTableSelect.TabIndex = 3;
            this.DBTableSelect.SelectedIndexChanged += new System.EventHandler(this.DBTableSelect_SelectedIndexChanged);
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Location = new System.Drawing.Point(17, 82);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowTemplate.Height = 24;
            this.ResultTable.Size = new System.Drawing.Size(478, 162);
            this.ResultTable.TabIndex = 4;
            this.ResultTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ResultTable_DataError);
            // 
            // DataSaveButton
            // 
            this.DataSaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataSaveButton.Location = new System.Drawing.Point(400, 259);
            this.DataSaveButton.Name = "DataSaveButton";
            this.DataSaveButton.Size = new System.Drawing.Size(95, 29);
            this.DataSaveButton.TabIndex = 5;
            this.DataSaveButton.Text = "Сохранить";
            this.DataSaveButton.UseVisualStyleBackColor = true;
            this.DataSaveButton.Click += new System.EventHandler(this.DataSaveButton_Click);
            // 
            // SQLBtn
            // 
            this.SQLBtn.Location = new System.Drawing.Point(400, 13);
            this.SQLBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SQLBtn.Name = "SQLBtn";
            this.SQLBtn.Size = new System.Drawing.Size(95, 50);
            this.SQLBtn.TabIndex = 7;
            this.SQLBtn.Text = "SQL-запросы";
            this.SQLBtn.UseVisualStyleBackColor = true;
            this.SQLBtn.Click += new System.EventHandler(this.SQLBtn_Click);
            // 
            // PoetezClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 296);
            this.Controls.Add(this.SQLBtn);
            this.Controls.Add(this.DataSaveButton);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.DBTableSelect);
            this.Controls.Add(this.DBSelect);
            this.Controls.Add(this.WhichTable);
            this.Controls.Add(this.WhichDBLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PoetezClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poetez Client";
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhichDBLabel;
        private System.Windows.Forms.Label WhichTable;
        private System.Windows.Forms.ComboBox DBSelect;
        private System.Windows.Forms.ComboBox DBTableSelect;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.Button DataSaveButton;
        private System.Windows.Forms.Button SQLBtn;
    }
}

