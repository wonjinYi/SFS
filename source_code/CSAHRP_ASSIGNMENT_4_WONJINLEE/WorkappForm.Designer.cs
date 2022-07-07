namespace CSAHRP_ASSIGNMENT_4_WONJINLEE
{
    partial class WorkappForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.textbox_targetDir = new System.Windows.Forms.TextBox();
            this.listbox_imageList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelelel = new System.Windows.Forms.Label();
            this.pictureBox_currentImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_currentFeature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listbox_availableValue = new System.Windows.Forms.ListBox();
            this.button_prevFeature = new System.Windows.Forms.Button();
            this.button_nextFeature = new System.Windows.Forms.Button();
            this.textbox_featurePagenation = new System.Windows.Forms.TextBox();
            this.listView_currentWorkStatus = new System.Windows.Forms.ListView();
            this.feature = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox_autoNextFeature = new System.Windows.Forms.CheckBox();
            this.checkbox_autoNextImage = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_targetDir
            // 
            this.textbox_targetDir.Location = new System.Drawing.Point(12, 143);
            this.textbox_targetDir.Multiline = true;
            this.textbox_targetDir.Name = "textbox_targetDir";
            this.textbox_targetDir.ReadOnly = true;
            this.textbox_targetDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_targetDir.Size = new System.Drawing.Size(223, 61);
            this.textbox_targetDir.TabIndex = 1;
            // 
            // listbox_imageList
            // 
            this.listbox_imageList.FormattingEnabled = true;
            this.listbox_imageList.HorizontalScrollbar = true;
            this.listbox_imageList.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listbox_imageList.ItemHeight = 20;
            this.listbox_imageList.Location = new System.Drawing.Point(12, 237);
            this.listbox_imageList.Name = "listbox_imageList";
            this.listbox_imageList.Size = new System.Drawing.Size(223, 524);
            this.listbox_imageList.TabIndex = 0;
            this.listbox_imageList.SelectedIndexChanged += new System.EventHandler(this.listbox_imageList_SelectedIndexChanged);
            this.listbox_imageList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listbox_imageList_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "선택된 디렉토리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "이미지 목록";
            // 
            // labelelel
            // 
            this.labelelel.AutoSize = true;
            this.labelelel.Location = new System.Drawing.Point(1140, 401);
            this.labelelel.Name = "labelelel";
            this.labelelel.Size = new System.Drawing.Size(154, 20);
            this.labelelel.TabIndex = 5;
            this.labelelel.Text = "현재 이미지 작업현황";
            // 
            // pictureBox_currentImage
            // 
            this.pictureBox_currentImage.Location = new System.Drawing.Point(241, 12);
            this.pictureBox_currentImage.Name = "pictureBox_currentImage";
            this.pictureBox_currentImage.Size = new System.Drawing.Size(893, 749);
            this.pictureBox_currentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_currentImage.TabIndex = 7;
            this.pictureBox_currentImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1140, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "선택중인 특징항목의 선택가능한 값";
            // 
            // textbox_currentFeature
            // 
            this.textbox_currentFeature.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_currentFeature.Location = new System.Drawing.Point(1140, 35);
            this.textbox_currentFeature.Name = "textbox_currentFeature";
            this.textbox_currentFeature.ReadOnly = true;
            this.textbox_currentFeature.Size = new System.Drawing.Size(302, 36);
            this.textbox_currentFeature.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1140, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "선택중인 특징항목";
            // 
            // listbox_availableValue
            // 
            this.listbox_availableValue.FormattingEnabled = true;
            this.listbox_availableValue.ItemHeight = 20;
            this.listbox_availableValue.Location = new System.Drawing.Point(1140, 143);
            this.listbox_availableValue.Name = "listbox_availableValue";
            this.listbox_availableValue.Size = new System.Drawing.Size(302, 244);
            this.listbox_availableValue.TabIndex = 12;
            this.listbox_availableValue.SelectedIndexChanged += new System.EventHandler(this.listbox_availableValue_SelectedIndexChanged);
            // 
            // button_prevFeature
            // 
            this.button_prevFeature.Location = new System.Drawing.Point(1376, 77);
            this.button_prevFeature.Name = "button_prevFeature";
            this.button_prevFeature.Size = new System.Drawing.Size(30, 29);
            this.button_prevFeature.TabIndex = 13;
            this.button_prevFeature.Text = "◀";
            this.button_prevFeature.UseVisualStyleBackColor = true;
            this.button_prevFeature.Click += new System.EventHandler(this.button_prevFeature_Click);
            // 
            // button_nextFeature
            // 
            this.button_nextFeature.Location = new System.Drawing.Point(1412, 77);
            this.button_nextFeature.Name = "button_nextFeature";
            this.button_nextFeature.Size = new System.Drawing.Size(30, 29);
            this.button_nextFeature.TabIndex = 14;
            this.button_nextFeature.Text = "▶";
            this.button_nextFeature.UseVisualStyleBackColor = true;
            this.button_nextFeature.Click += new System.EventHandler(this.button_nextFeature_Click);
            // 
            // textbox_featurePagenation
            // 
            this.textbox_featurePagenation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textbox_featurePagenation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_featurePagenation.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_featurePagenation.Location = new System.Drawing.Point(1140, 77);
            this.textbox_featurePagenation.MinimumSize = new System.Drawing.Size(0, 29);
            this.textbox_featurePagenation.Name = "textbox_featurePagenation";
            this.textbox_featurePagenation.ReadOnly = true;
            this.textbox_featurePagenation.Size = new System.Drawing.Size(230, 27);
            this.textbox_featurePagenation.TabIndex = 15;
            this.textbox_featurePagenation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_featurePagenation.WordWrap = false;
            // 
            // listView_currentWorkStatus
            // 
            this.listView_currentWorkStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.feature,
            this.value});
            this.listView_currentWorkStatus.GridLines = true;
            this.listView_currentWorkStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_currentWorkStatus.HideSelection = false;
            this.listView_currentWorkStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_currentWorkStatus.Location = new System.Drawing.Point(1140, 424);
            this.listView_currentWorkStatus.Name = "listView_currentWorkStatus";
            this.listView_currentWorkStatus.Size = new System.Drawing.Size(302, 337);
            this.listView_currentWorkStatus.TabIndex = 16;
            this.listView_currentWorkStatus.UseCompatibleStateImageBehavior = false;
            this.listView_currentWorkStatus.View = System.Windows.Forms.View.Details;
            // 
            // feature
            // 
            this.feature.Text = "특징항목";
            this.feature.Width = 150;
            // 
            // value
            // 
            this.value.Text = "값";
            this.value.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox_autoNextFeature);
            this.groupBox1.Controls.Add(this.checkbox_autoNextImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 94);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "자동넘어가기 설정";
            // 
            // checkbox_autoNextFeature
            // 
            this.checkbox_autoNextFeature.AutoSize = true;
            this.checkbox_autoNextFeature.Checked = true;
            this.checkbox_autoNextFeature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_autoNextFeature.Location = new System.Drawing.Point(16, 56);
            this.checkbox_autoNextFeature.Name = "checkbox_autoNextFeature";
            this.checkbox_autoNextFeature.Size = new System.Drawing.Size(158, 24);
            this.checkbox_autoNextFeature.TabIndex = 20;
            this.checkbox_autoNextFeature.Text = "완료된 특징항목(F)";
            this.checkbox_autoNextFeature.UseVisualStyleBackColor = true;
            // 
            // checkbox_autoNextImage
            // 
            this.checkbox_autoNextImage.AutoSize = true;
            this.checkbox_autoNextImage.Checked = true;
            this.checkbox_autoNextImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_autoNextImage.Location = new System.Drawing.Point(16, 26);
            this.checkbox_autoNextImage.Name = "checkbox_autoNextImage";
            this.checkbox_autoNextImage.Size = new System.Drawing.Size(145, 24);
            this.checkbox_autoNextImage.TabIndex = 21;
            this.checkbox_autoNextImage.Text = "완료된 이미지(R)";
            this.checkbox_autoNextImage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "(&Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "/ &W)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1271, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "(&A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1293, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "/ &S)";
            // 
            // WorkappForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 773);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_currentWorkStatus);
            this.Controls.Add(this.textbox_featurePagenation);
            this.Controls.Add(this.button_nextFeature);
            this.Controls.Add(this.button_prevFeature);
            this.Controls.Add(this.listbox_availableValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_currentFeature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_currentImage);
            this.Controls.Add(this.labelelel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_targetDir);
            this.Controls.Add(this.listbox_imageList);
            this.KeyPreview = true;
            this.Name = "WorkappForm";
            this.Text = "SFS : 작업";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkappForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_targetDir;
        private System.Windows.Forms.ListBox listbox_imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelelel;
        private System.Windows.Forms.PictureBox pictureBox_currentImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_currentFeature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbox_availableValue;
        private System.Windows.Forms.Button button_prevFeature;
        private System.Windows.Forms.Button button_nextFeature;
        private System.Windows.Forms.TextBox textbox_featurePagenation;
        private System.Windows.Forms.ListView listView_currentWorkStatus;
        private System.Windows.Forms.ColumnHeader feature;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox_autoNextFeature;
        private System.Windows.Forms.CheckBox checkbox_autoNextImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}