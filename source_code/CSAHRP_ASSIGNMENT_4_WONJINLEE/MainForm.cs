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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ================================================================
        //
        //               1. "새로운 설정파일 만들기" 버튼 클릭
        //
        // ================================================================
        private void button_createnewconfigfile_Click(object sender, EventArgs e)
        {
            Form CreateNewConfigForm = new CreateNewConfigForm();
            CreateNewConfigForm.ShowDialog();
        }

        // ================================================================
        //
        //               2. "작업하기" 버튼 클릭
        //
        // -------------------------
        // 입력한 작업대상 디렉토리, 설정파일 경로가 존재하는지 검증
        // 설정파일이 올바른 형식인지 검증
        // WorkappForm을 열고 검증된 값 전달.
        // ================================================================

        private void button_startworkapp_Click(object sender, EventArgs e)
        {
            // 작업대상 디렉토리, 설정파일 경로 textbox가 비어있는지 확인
            string targetDirPath = textbox_directory.Text;
            string configPath = textbox_configfile.Text;

            if (targetDirPath == "")
            {
                MessageBox.Show("작업대상 디렉토리가 지정되지 않았습니다.", "SFS : 잘못된 경로", MessageBoxButtons.OK);
                return;
            }
            else if (configPath == "")
            {
                MessageBox.Show("설정파일이 지정되지 않았습니다.", "SFS : 잘못된 경로", MessageBoxButtons.OK);
                return;
            }

            // 지정한 작업대상 디렉토리, 설정파일경로가 존재하는지 확인
            DirectoryInfo di = new DirectoryInfo(targetDirPath);
            FileInfo fi = new FileInfo(configPath);
            if (!di.Exists)
            {
                MessageBox.Show("지정한 작업대상 디렉토리를 찾을 수 없습니다.", "SFS : 잘못된 경로", MessageBoxButtons.OK);
                return;
            }
            else if (!fi.Exists)
            {
                MessageBox.Show("지정한 설정파일을 찾을 수 없습니다.", "SFS : 잘못된 경로", MessageBoxButtons.OK);
                return;
            }

            // 선택한 설정파일의 형식이 올바른지 확인
            using (StreamReader sr = new StreamReader(configPath))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();

                    // 행에 콜론(:)이 포함되어있는지 검사
                    if (!line.Contains(":"))
                    {
                        MessageBox.Show("설정파일의 형식이 올바르지 않습니다.\n콜론(:)을 포함하지 않은 행이 있습니다.", "SFS : 올바르지 않은 설정파일", MessageBoxButtons.OK);
                        return;
                    }

                    // 행의 내용이 없는지 검사
                    if (line.Trim() == "")
                    {
                        MessageBox.Show("설정파일의 형식이 올바르지 않습니다.\n내용이 없는 행이 있습니다.", "SFS : 올바르지 않은 설정파일", MessageBoxButtons.OK);
                        return;
                    }

                    // 행에 특징항목 이름(feature)과 값(value)가 모두 존재하는지 검사
                    string[] splitedLine = line.Split(":");
                    if (splitedLine.Length < 2)
                    {
                        MessageBox.Show("설정파일의 형식이 올바르지 않습니다.\n특징항목 이름 또는 값이 없는 행이 있습니다.", "SFS : 올바르지 않은 설정파일", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
                
            // 작업창 띄우기
            Form WorkappForm = new WorkappForm(textbox_directory.Text, textbox_configfile.Text);
            WorkappForm.ShowDialog();
        }

        // ================================================================
        //
        //               3. 작업대상 디렉토리, 설정파일 경로 지정
        //
        // ================================================================

        private void button_directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                textbox_directory.Text = fbd.SelectedPath;
        }

        private void button_configfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string ext = path.Split(".")[^1];

                if (ext != "sfs")
                {
                    MessageBox.Show("sfs파일이 아닙니다.", "SFS : 잘못된 파일", MessageBoxButtons.OK);
                    return;
                } else
                {
                    textbox_configfile.Text = path;
                }
                
            }
                
        }
    }
}
