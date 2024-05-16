namespace EmployeManageSystem
{
    partial class QueryForm
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
            this.query_label = new System.Windows.Forms.Label();
            this.query_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.query_result_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // query_label
            // 
            this.query_label.AutoSize = true;
            this.query_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query_label.Location = new System.Drawing.Point(386, 9);
            this.query_label.Name = "query_label";
            this.query_label.Size = new System.Drawing.Size(162, 22);
            this.query_label.TabIndex = 0;
            this.query_label.Text = "So\'rovni kiritng:";
            this.query_label.Click += new System.EventHandler(this.query_label_Click);
            // 
            // query_textbox
            // 
            this.query_textbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query_textbox.Location = new System.Drawing.Point(76, 53);
            this.query_textbox.Multiline = true;
            this.query_textbox.Name = "query_textbox";
            this.query_textbox.Size = new System.Drawing.Size(886, 96);
            this.query_textbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 374);
            this.dataGridView1.TabIndex = 2;
            // 
            // query_result_btn
            // 
            this.query_result_btn.BackColor = System.Drawing.Color.Blue;
            this.query_result_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query_result_btn.ForeColor = System.Drawing.Color.White;
            this.query_result_btn.Location = new System.Drawing.Point(379, 164);
            this.query_result_btn.Name = "query_result_btn";
            this.query_result_btn.Size = new System.Drawing.Size(205, 39);
            this.query_result_btn.TabIndex = 3;
            this.query_result_btn.Text = "Query Result";
            this.query_result_btn.UseVisualStyleBackColor = false;
            this.query_result_btn.Click += new System.EventHandler(this.query_result_btn_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 615);
            this.Controls.Add(this.query_result_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.query_textbox);
            this.Controls.Add(this.query_label);
            this.Name = "QueryForm";
            this.Text = "Query";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label query_label;
        private System.Windows.Forms.TextBox query_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button query_result_btn;
    }
}