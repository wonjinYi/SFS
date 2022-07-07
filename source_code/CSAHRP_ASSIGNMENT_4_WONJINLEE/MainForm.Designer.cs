namespace CSAHRP_ASSIGNMENT_4_WONJINLEE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_directory = new System.Windows.Forms.TextBox();
            this.textbox_configfile = new System.Windows.Forms.TextBox();
            this.button_directory = new System.Windows.Forms.Button();
            this.button_configfile = new System.Windows.Forms.Button();
            this.button_startworkapp = new System.Windows.Forms.Button();
            this.button_createnewconfigfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "SFS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Super Fast Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "디렉토리 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "설정파일 선택 (*.sfs)";
            // 
            // textbox_directory
            // 
            this.textbox_directory.Location = new System.Drawing.Point(29, 198);
            this.textbox_directory.Name = "textbox_directory";
            this.textbox_directory.Size = new System.Drawing.Size(379, 27);
            this.textbox_directory.TabIndex = 4;
            // 
            // textbox_configfile
            // 
            this.textbox_configfile.Location = new System.Drawing.Point(29, 287);
            this.textbox_configfile.Name = "textbox_configfile";
            this.textbox_configfile.Size = new System.Drawing.Size(379, 27);
            this.textbox_configfile.TabIndex = 5;
            // 
            // button_directory
            // 
            this.button_directory.Location = new System.Drawing.Point(414, 198);
            this.button_directory.Name = "button_directory";
            this.button_directory.Size = new System.Drawing.Size(94, 29);
            this.button_directory.TabIndex = 6;
            this.button_directory.Text = "select";
            this.button_directory.UseVisualStyleBackColor = true;
            this.button_directory.Click += new System.EventHandler(this.button_directory_Click);
            // 
            // button_configfile
            // 
            this.button_configfile.Location = new System.Drawing.Point(414, 287);
            this.button_configfile.Name = "button_configfile";
            this.button_configfile.Size = new System.Drawing.Size(94, 29);
            this.button_configfile.TabIndex = 7;
            this.button_configfile.Text = "select";
            this.button_configfile.UseVisualStyleBackColor = true;
            this.button_configfile.Click += new System.EventHandler(this.button_configfile_Click);
            // 
            // button_startworkapp
            // 
            this.button_startworkapp.Location = new System.Drawing.Point(542, 197);
            this.button_startworkapp.Name = "button_startworkapp";
            this.button_startworkapp.Size = new System.Drawing.Size(234, 119);
            this.button_startworkapp.TabIndex = 8;
            this.button_startworkapp.Text = "작업시작";
            this.button_startworkapp.UseVisualStyleBackColor = true;
            this.button_startworkapp.Click += new System.EventHandler(this.button_startworkapp_Click);
            // 
            // button_createnewconfigfile
            // 
            this.button_createnewconfigfile.Location = new System.Drawing.Point(542, 378);
            this.button_createnewconfigfile.Name = "button_createnewconfigfile";
            this.button_createnewconfigfile.Size = new System.Drawing.Size(234, 29);
            this.button_createnewconfigfile.TabIndex = 9;
            this.button_createnewconfigfile.Text = "새로운 설정파일 만들기";
            this.button_createnewconfigfile.UseVisualStyleBackColor = true;
            this.button_createnewconfigfile.Click += new System.EventHandler(this.button_createnewconfigfile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_createnewconfigfile);
            this.Controls.Add(this.button_startworkapp);
            this.Controls.Add(this.button_configfile);
            this.Controls.Add(this.button_directory);
            this.Controls.Add(this.textbox_configfile);
            this.Controls.Add(this.textbox_directory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "SFS : Super Fast Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_directory;
        private System.Windows.Forms.TextBox textbox_configfile;
        private System.Windows.Forms.Button button_directory;
        private System.Windows.Forms.Button button_configfile;
        private System.Windows.Forms.Button button_startworkapp;
        private System.Windows.Forms.Button button_createnewconfigfile;
    }
}
