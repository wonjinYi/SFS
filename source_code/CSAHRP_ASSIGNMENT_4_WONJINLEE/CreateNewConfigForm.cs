using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSAHRP_ASSIGNMENT_4_WONJINLEE
{
    public partial class CreateNewConfigForm : Form
    {
        public CreateNewConfigForm()
        {
            InitializeComponent();
        }

        private void button_saveNewConfig_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "설정파일( *.sfs ) 저장";
            sfd.OverwritePrompt = true;
            sfd.Filter = "SFS설정파일(*.sfs)|";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                
                StreamWriter sw = new StreamWriter($"{path}.sfs");
                sw.Write(textbox_newConfig.Text);
                sw.Close();

                MessageBox.Show($"저장되었습니다.\n{path}.sfs", "SFS : 설정파일 저장 완료", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
