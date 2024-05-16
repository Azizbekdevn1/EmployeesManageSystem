namespace EmployeManageSystem
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
            System.Windows.Forms.Panel panelside;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.query_btn = new System.Windows.Forms.Button();
            panelside = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            panelside.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.exitbtn);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1029, 41);
            this.panelheader.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(244, 41);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(785, 562);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panelside
            // 
            panelside.BackColor = System.Drawing.Color.DimGray;
            panelside.BackgroundImage = global::EmployeManageSystem.Properties.Resources.staff;
            panelside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panelside.Controls.Add(this.query_btn);
            panelside.Controls.Add(this.button11);
            panelside.Controls.Add(this.button10);
            panelside.Controls.Add(this.button9);
            panelside.Controls.Add(this.button8);
            panelside.Controls.Add(this.button7);
            panelside.Controls.Add(this.button6);
            panelside.Controls.Add(this.button5);
            panelside.Controls.Add(this.button4);
            panelside.Controls.Add(this.button2);
            panelside.Controls.Add(this.button1);
            panelside.Dock = System.Windows.Forms.DockStyle.Left;
            panelside.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            panelside.Location = new System.Drawing.Point(0, 41);
            panelside.Name = "panelside";
            panelside.Size = new System.Drawing.Size(244, 562);
            panelside.TabIndex = 0;
            panelside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelside_Paint);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DimGray;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(21, 442);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 30);
            this.button11.TabIndex = 8;
            this.button11.Text = "Employees";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DimGray;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(21, 406);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 30);
            this.button10.TabIndex = 7;
            this.button10.Text = "Employees languages";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(21, 370);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 30);
            this.button9.TabIndex = 6;
            this.button9.Text = "Languages";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(21, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 30);
            this.button8.TabIndex = 5;
            this.button8.Text = "Departments";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(21, 226);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 30);
            this.button7.TabIndex = 4;
            this.button7.Text = "Categories";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(21, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 30);
            this.button6.TabIndex = 3;
            this.button6.Text = "Jobs history";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(21, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "Jobs";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(21, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Salaries";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(21, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Addresses";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = global::EmployeManageSystem.Properties.Resources.screen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DimGray;
            this.exitbtn.BackgroundImage = global::EmployeManageSystem.Properties.Resources.button;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(987, 5);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(30, 30);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // query_btn
            // 
            this.query_btn.BackColor = System.Drawing.Color.DimGray;
            this.query_btn.ForeColor = System.Drawing.Color.Yellow;
            this.query_btn.Location = new System.Drawing.Point(21, 492);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(200, 30);
            this.query_btn.TabIndex = 9;
            this.query_btn.Text = "Querys";
            this.query_btn.UseVisualStyleBackColor = false;
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 603);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(panelside);
            this.Controls.Add(this.panelheader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xodimlarni Boshqarish tizimi";
            this.panelheader.ResumeLayout(false);
            panelside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button query_btn;
    }
}

