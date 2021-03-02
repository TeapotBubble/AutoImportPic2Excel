
namespace AutoMatchPic
{
    partial class AutoPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPic));
            this.btn_Import = new System.Windows.Forms.Button();
            this.tb_picFolder = new System.Windows.Forms.TextBox();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.btn_picPath = new System.Windows.Forms.Button();
            this.cb_colPicName = new System.Windows.Forms.ComboBox();
            this.btn_filePath = new System.Windows.Forms.Button();
            this.cb_picAddCol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(378, 211);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 13;
            this.btn_Import.Text = "导入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_picFolder
            // 
            this.tb_picFolder.Location = new System.Drawing.Point(133, 141);
            this.tb_picFolder.Name = "tb_picFolder";
            this.tb_picFolder.Size = new System.Drawing.Size(320, 21);
            this.tb_picFolder.TabIndex = 12;
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(133, 41);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(320, 21);
            this.tb_filePath.TabIndex = 11;
            // 
            // btn_picPath
            // 
            this.btn_picPath.Location = new System.Drawing.Point(493, 141);
            this.btn_picPath.Name = "btn_picPath";
            this.btn_picPath.Size = new System.Drawing.Size(75, 23);
            this.btn_picPath.TabIndex = 10;
            this.btn_picPath.Text = "选择";
            this.btn_picPath.UseVisualStyleBackColor = true;
            this.btn_picPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_colPicName
            // 
            this.cb_colPicName.FormattingEnabled = true;
            this.cb_colPicName.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_colPicName.Location = new System.Drawing.Point(133, 93);
            this.cb_colPicName.Name = "cb_colPicName";
            this.cb_colPicName.Size = new System.Drawing.Size(85, 20);
            this.cb_colPicName.TabIndex = 9;
            this.cb_colPicName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_filePath
            // 
            this.btn_filePath.Location = new System.Drawing.Point(493, 41);
            this.btn_filePath.Name = "btn_filePath";
            this.btn_filePath.Size = new System.Drawing.Size(75, 23);
            this.btn_filePath.TabIndex = 8;
            this.btn_filePath.Text = "选择";
            this.btn_filePath.UseVisualStyleBackColor = true;
            this.btn_filePath.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_picAddCol
            // 
            this.cb_picAddCol.FormattingEnabled = true;
            this.cb_picAddCol.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_picAddCol.Location = new System.Drawing.Point(332, 93);
            this.cb_picAddCol.Name = "cb_picAddCol";
            this.cb_picAddCol.Size = new System.Drawing.Size(121, 20);
            this.cb_picAddCol.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "文件地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "图片文件夹：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "图片名称列：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "图片放置列：";
            // 
            // AutoPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_picAddCol);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.tb_picFolder);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.btn_picPath);
            this.Controls.Add(this.cb_colPicName);
            this.Controls.Add(this.btn_filePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoPic";
            this.Text = "AutoPic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.TextBox tb_picFolder;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Button btn_picPath;
        private System.Windows.Forms.ComboBox cb_colPicName;
        private System.Windows.Forms.Button btn_filePath;
        private System.Windows.Forms.ComboBox cb_picAddCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}