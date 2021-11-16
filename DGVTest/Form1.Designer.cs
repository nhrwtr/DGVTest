
namespace DGVTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UserListDataGridView = new System.Windows.Forms.DataGridView();
            this.ReflashButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResetButton2 = new System.Windows.Forms.Button();
            this.ReflashButton2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userColumnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListDataGridView
            // 
            this.UserListDataGridView.AllowUserToAddRows = false;
            this.UserListDataGridView.AllowUserToDeleteRows = false;
            this.UserListDataGridView.AutoGenerateColumns = false;
            this.UserListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.UserListDataGridView.DataSource = this.userColumnBindingSource;
            this.UserListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.UserListDataGridView.Name = "UserListDataGridView";
            this.UserListDataGridView.ReadOnly = true;
            this.UserListDataGridView.RowTemplate.Height = 21;
            this.UserListDataGridView.Size = new System.Drawing.Size(458, 426);
            this.UserListDataGridView.TabIndex = 0;
            // 
            // ReflashButton
            // 
            this.ReflashButton.Location = new System.Drawing.Point(504, 71);
            this.ReflashButton.Name = "ReflashButton";
            this.ReflashButton.Size = new System.Drawing.Size(75, 23);
            this.ReflashButton.TabIndex = 1;
            this.ReflashButton.Text = "更新";
            this.ReflashButton.UseVisualStyleBackColor = true;
            this.ReflashButton.Click += new System.EventHandler(this.ReflashButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(643, 71);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "初期化";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResetButton2
            // 
            this.ResetButton2.Location = new System.Drawing.Point(643, 211);
            this.ResetButton2.Name = "ResetButton2";
            this.ResetButton2.Size = new System.Drawing.Size(75, 23);
            this.ResetButton2.TabIndex = 4;
            this.ResetButton2.Text = "初期化";
            this.ResetButton2.UseVisualStyleBackColor = true;
            this.ResetButton2.Click += new System.EventHandler(this.ResetButton2_Click);
            // 
            // ReflashButton2
            // 
            this.ReflashButton2.Location = new System.Drawing.Point(504, 211);
            this.ReflashButton2.Name = "ReflashButton2";
            this.ReflashButton2.Size = new System.Drawing.Size(75, 23);
            this.ReflashButton2.TabIndex = 3;
            this.ReflashButton2.Text = "更新";
            this.ReflashButton2.UseVisualStyleBackColor = true;
            this.ReflashButton2.Click += new System.EventHandler(this.ReflashButton2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userColumnBindingSource
            // 
            this.userColumnBindingSource.DataSource = typeof(DGVTest.UserColumn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetButton2);
            this.Controls.Add(this.ReflashButton2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ReflashButton);
            this.Controls.Add(this.UserListDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userColumnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserListDataGridView;
        private System.Windows.Forms.Button ReflashButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userColumnBindingSource;
        private System.Windows.Forms.Button ResetButton2;
        private System.Windows.Forms.Button ReflashButton2;
    }
}

