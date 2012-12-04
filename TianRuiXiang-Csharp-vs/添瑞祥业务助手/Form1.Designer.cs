namespace 添瑞祥业务助手
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
            this.rtxtData = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbOperate.SuspendLayout();
            this.gbSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtData
            // 
            this.rtxtData.Location = new System.Drawing.Point(14, 34);
            this.rtxtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtData.Name = "rtxtData";
            this.rtxtData.Size = new System.Drawing.Size(255, 541);
            this.rtxtData.TabIndex = 0;
            this.rtxtData.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbOperate);
            this.panel1.Controls.Add(this.gbSetup);
            this.panel1.Location = new System.Drawing.Point(293, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 541);
            this.panel1.TabIndex = 1;
            // 
            // gbOperate
            // 
            this.gbOperate.Controls.Add(this.btnCopy);
            this.gbOperate.Controls.Add(this.btnTransform);
            this.gbOperate.Controls.Add(this.btnTest);
            this.gbOperate.Controls.Add(this.rtxtInfo);
            this.gbOperate.Font = new System.Drawing.Font("STKaiti", 10.2F);
            this.gbOperate.Location = new System.Drawing.Point(3, 101);
            this.gbOperate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOperate.Size = new System.Drawing.Size(457, 440);
            this.gbOperate.TabIndex = 1;
            this.gbOperate.TabStop = false;
            this.gbOperate.Text = "操作";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("STKaiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopy.Location = new System.Drawing.Point(325, 25);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 48);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "拷贝数据";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Font = new System.Drawing.Font("STKaiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTransform.Location = new System.Drawing.Point(178, 25);
            this.btnTransform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(107, 48);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "模式变换";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("STKaiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTest.Location = new System.Drawing.Point(29, 25);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(107, 48);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "检测数据";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Location = new System.Drawing.Point(29, 101);
            this.rtxtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ReadOnly = true;
            this.rtxtInfo.Size = new System.Drawing.Size(402, 331);
            this.rtxtInfo.TabIndex = 3;
            this.rtxtInfo.Text = "";
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.btnSetDefault);
            this.gbSetup.Controls.Add(this.txtPattern);
            this.gbSetup.Controls.Add(this.lblPattern);
            this.gbSetup.Font = new System.Drawing.Font("STKaiti", 10.2F);
            this.gbSetup.Location = new System.Drawing.Point(3, 4);
            this.gbSetup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSetup.Size = new System.Drawing.Size(457, 77);
            this.gbSetup.TabIndex = 0;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "设置";
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Font = new System.Drawing.Font("STKaiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetDefault.Location = new System.Drawing.Point(325, 15);
            this.btnSetDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(107, 48);
            this.btnSetDefault.TabIndex = 2;
            this.btnSetDefault.Text = "设为默认";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Font = new System.Drawing.Font("STKaiti", 10.2F);
            this.txtPattern.Location = new System.Drawing.Point(125, 25);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(176, 30);
            this.txtPattern.TabIndex = 1;
            this.txtPattern.Text = "111100*";
            this.txtPattern.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Font = new System.Drawing.Font("STKaiti", 10.2F);
            this.lblPattern.Location = new System.Drawing.Point(25, 28);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(94, 19);
            this.lblPattern.TabIndex = 0;
            this.lblPattern.Text = "变换模式：";
            this.lblPattern.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtData);
            this.Font = new System.Drawing.Font("STKaiti", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添瑞祥";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbOperate.ResumeLayout(false);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOperate;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnTest;
    }
}

