namespace CSAHRP_ASSIGNMENT_4_WONJINLEE
{
    partial class CreateNewConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_newConfig = new System.Windows.Forms.TextBox();
            this.button_saveNewConfig = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "새로운 설정파일 만들기";
            // 
            // textbox_newConfig
            // 
            this.textbox_newConfig.Location = new System.Drawing.Point(12, 80);
            this.textbox_newConfig.Multiline = true;
            this.textbox_newConfig.Name = "textbox_newConfig";
            this.textbox_newConfig.PlaceholderText = "선택항목:값";
            this.textbox_newConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox_newConfig.Size = new System.Drawing.Size(457, 261);
            this.textbox_newConfig.TabIndex = 1;
            this.textbox_newConfig.WordWrap = false;
            // 
            // button_saveNewConfig
            // 
            this.button_saveNewConfig.Location = new System.Drawing.Point(12, 361);
            this.button_saveNewConfig.Name = "button_saveNewConfig";
            this.button_saveNewConfig.Size = new System.Drawing.Size(457, 29);
            this.button_saveNewConfig.TabIndex = 2;
            this.button_saveNewConfig.Text = "내보내기";
            this.button_saveNewConfig.UseVisualStyleBackColor = true;
            this.button_saveNewConfig.Click += new System.EventHandler(this.button_saveNewConfig_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(293, 310);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "<설정파일 작성 방법>\r\n\r\n(양식)\r\n선택항목:값\r\n\r\n(제한사항)\r\n문자에 콜론(:)은 사용할 수 없습니다.\r\n\r\n(예시)\r\n학생인가:예\r\n학" +
    "생인가:아니요\r\n성별:남자\r\n성별:여자\r\n성별:기타";
            // 
            // CreateNewConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_saveNewConfig);
            this.Controls.Add(this.textbox_newConfig);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewConfigForm";
            this.Text = "SFS : 새로운 설정파일 만들기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_newConfig;
        private System.Windows.Forms.Button button_saveNewConfig;
        private System.Windows.Forms.TextBox textBox2;
    }
}