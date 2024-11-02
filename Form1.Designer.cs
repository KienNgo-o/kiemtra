namespace DOAN_LAPTRINHMANG
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
            this.components = new System.ComponentModel.Container();
            this.button_openfile = new System.Windows.Forms.Button();
            this.button_savefile = new System.Windows.Forms.Button();
            this.nhap = new System.Windows.Forms.RichTextBox();
            this.indam = new System.Windows.Forms.Button();
            this.innghieng = new System.Windows.Forms.Button();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.gachchan = new System.Windows.Forms.Button();
            this.gachbo = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.highlight = new System.Windows.Forms.Button();
            this.canphai = new System.Windows.Forms.Button();
            this.cangiua = new System.Windows.Forms.Button();
            this.cantrai = new System.Windows.Forms.Button();
            this.kocan = new System.Windows.Forms.Button();
            this.button_newfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openfile
            // 
            this.button_openfile.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openfile.Location = new System.Drawing.Point(12, 12);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(147, 34);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "Open file";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button1_docfile);
            // 
            // button_savefile
            // 
            this.button_savefile.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_savefile.Location = new System.Drawing.Point(12, 52);
            this.button_savefile.Name = "button_savefile";
            this.button_savefile.Size = new System.Drawing.Size(127, 34);
            this.button_savefile.TabIndex = 1;
            this.button_savefile.Text = "Save As";
            this.button_savefile.UseVisualStyleBackColor = true;
            this.button_savefile.Click += new System.EventHandler(this.button_ghifile_Click);
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(283, 90);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(921, 494);
            this.nhap.TabIndex = 2;
            this.nhap.Text = "";
            // 
            // indam
            // 
            this.indam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indam.Location = new System.Drawing.Point(184, 12);
            this.indam.Name = "indam";
            this.indam.Size = new System.Drawing.Size(38, 34);
            this.indam.TabIndex = 3;
            this.indam.Text = "B";
            this.indam.UseVisualStyleBackColor = true;
            this.indam.Click += new System.EventHandler(this.indam_click);
            // 
            // innghieng
            // 
            this.innghieng.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.innghieng.Location = new System.Drawing.Point(228, 12);
            this.innghieng.Name = "innghieng";
            this.innghieng.Size = new System.Drawing.Size(38, 34);
            this.innghieng.TabIndex = 4;
            this.innghieng.Text = "I";
            this.innghieng.UseVisualStyleBackColor = true;
            this.innghieng.Click += new System.EventHandler(this.innghieng_click);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(385, 12);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(159, 24);
            this.comboBoxFont.TabIndex = 5;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Location = new System.Drawing.Point(572, 12);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(47, 24);
            this.comboBoxFontSize.TabIndex = 6;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontSize_SelectedIndexChanged);
            // 
            // gachchan
            // 
            this.gachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gachchan.Location = new System.Drawing.Point(272, 12);
            this.gachchan.Name = "gachchan";
            this.gachchan.Size = new System.Drawing.Size(36, 36);
            this.gachchan.TabIndex = 7;
            this.gachchan.Text = "U";
            this.gachchan.UseVisualStyleBackColor = true;
            this.gachchan.Click += new System.EventHandler(this.gachchan_click);
            // 
            // gachbo
            // 
            this.gachbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gachbo.Location = new System.Drawing.Point(314, 12);
            this.gachbo.Name = "gachbo";
            this.gachbo.Size = new System.Drawing.Size(43, 36);
            this.gachbo.TabIndex = 8;
            this.gachbo.Text = "ab";
            this.gachbo.UseVisualStyleBackColor = true;
            this.gachbo.Click += new System.EventHandler(this.gachbo_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // highlight
            // 
            this.highlight.BackgroundImage = global::DOAN_LAPTRINHMANG.Properties.Resources.Screenshot_2024_10_19_1529201;
            this.highlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlight.Location = new System.Drawing.Point(385, 52);
            this.highlight.Name = "highlight";
            this.highlight.Size = new System.Drawing.Size(33, 32);
            this.highlight.TabIndex = 13;
            this.highlight.UseVisualStyleBackColor = true;
            this.highlight.Click += new System.EventHandler(this.highlight_click);
            // 
            // canphai
            // 
            this.canphai.BackgroundImage = global::DOAN_LAPTRINHMANG.Properties.Resources.Screenshot_2024_10_19_145849;
            this.canphai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.canphai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canphai.Location = new System.Drawing.Point(336, 52);
            this.canphai.Name = "canphai";
            this.canphai.Size = new System.Drawing.Size(33, 32);
            this.canphai.TabIndex = 12;
            this.canphai.UseVisualStyleBackColor = true;
            this.canphai.Click += new System.EventHandler(this.canphai_click);
            // 
            // cangiua
            // 
            this.cangiua.BackgroundImage = global::DOAN_LAPTRINHMANG.Properties.Resources.Screenshot_2024_10_19_145135;
            this.cangiua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cangiua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cangiua.Location = new System.Drawing.Point(231, 52);
            this.cangiua.Name = "cangiua";
            this.cangiua.Size = new System.Drawing.Size(33, 32);
            this.cangiua.TabIndex = 11;
            this.cangiua.UseVisualStyleBackColor = true;
            this.cangiua.Click += new System.EventHandler(this.cangiua_click);
            // 
            // cantrai
            // 
            this.cantrai.BackgroundImage = global::DOAN_LAPTRINHMANG.Properties.Resources.Screenshot_2024_10_19_145216;
            this.cantrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cantrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cantrai.Location = new System.Drawing.Point(283, 52);
            this.cantrai.Name = "cantrai";
            this.cantrai.Size = new System.Drawing.Size(33, 32);
            this.cantrai.TabIndex = 10;
            this.cantrai.UseVisualStyleBackColor = true;
            this.cantrai.Click += new System.EventHandler(this.cantrai_click);
            // 
            // kocan
            // 
            this.kocan.BackgroundImage = global::DOAN_LAPTRINHMANG.Properties.Resources.Screenshot_2024_10_19_144709;
            this.kocan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kocan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kocan.Location = new System.Drawing.Point(182, 52);
            this.kocan.Name = "kocan";
            this.kocan.Size = new System.Drawing.Size(33, 32);
            this.kocan.TabIndex = 9;
            this.kocan.UseVisualStyleBackColor = true;
            this.kocan.Click += new System.EventHandler(this.kocan_click);
            // 
            // button_newfile
            // 
            this.button_newfile.Location = new System.Drawing.Point(34, 143);
            this.button_newfile.Name = "button_newfile";
            this.button_newfile.Size = new System.Drawing.Size(124, 32);
            this.button_newfile.TabIndex = 14;
            this.button_newfile.Text = "New file";
            this.button_newfile.UseVisualStyleBackColor = true;
            this.button_newfile.Click += new System.EventHandler(this.button_newfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1252, 629);
            this.Controls.Add(this.button_newfile);
            this.Controls.Add(this.highlight);
            this.Controls.Add(this.canphai);
            this.Controls.Add(this.cangiua);
            this.Controls.Add(this.cantrai);
            this.Controls.Add(this.kocan);
            this.Controls.Add(this.gachbo);
            this.Controls.Add(this.gachchan);
            this.Controls.Add(this.comboBoxFontSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.innghieng);
            this.Controls.Add(this.indam);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.button_savefile);
            this.Controls.Add(this.button_openfile);
            this.Name = "Form1";
            this.Text = "BAI 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Button button_savefile;
        private System.Windows.Forms.RichTextBox nhap;
        private System.Windows.Forms.Button indam;
        private System.Windows.Forms.Button innghieng;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.Button gachchan;
        private System.Windows.Forms.Button gachbo;
        private System.Windows.Forms.Button kocan;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button cantrai;
        private System.Windows.Forms.Button cangiua;
        private System.Windows.Forms.Button canphai;
        private System.Windows.Forms.Button highlight;
        private System.Windows.Forms.Button button_newfile;
    }
}