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
using System.Collections;

namespace CSAHRP_ASSIGNMENT_4_WONJINLEE
{
    public partial class WorkappForm : Form
    {
        // ================================================================
        //
        //               1. 필드
        //
        // ================================================================

        string TargetDirPath;
        string ConfigPath;

        Dictionary<string, string> FeatureSet = new Dictionary<string, string>(); // "특징항목-하위의 값들"쌍의 집합. 값들은 구분자 :로 구분됨.
        string[] Features; // featureSet 딕셔너리의 키

        List<string> Images = new List<string>(); // 작업대상 디렉토리 내 이미지파일들의 목록
        int CurrentImageIdx = 0; // 현재 작업중인 이미지의 List<> Images 내 인덱스

        Dictionary<string, string> CurrentWork = new Dictionary<string, string>(); // 현재 작업중인 이미지에 대한 "특징항목-값" 쌍의 집합
                                                                                                                       // key는 string[] Features와 같음
        int CurrentFeatureIdx = 0; // 선택중인 특징항목의 Dictionary<> CurrentWork 또는 string[] Features 내 인덱스
        string[] CurrentAvailableValues; // 선택중인 특징항목의 입력가능한 값들

        // ================================================================
        //
        //               2. 생성자
        // -------------------------------
        // a. MainForm에서 내린 데이터 수신 
        // b. 필드 초기화
        // c. 컨트롤 내용 초기화
        // d. 첫 이미지(Work) 표시
        // ================================================================
        public WorkappForm(string _targetDirPath, string _configPath)
        {
            InitializeComponent();

            // MainForm 폼에서 보낸 데이터 받기 (작업대상 디렉토리, 설정파일 경로)
            TargetDirPath = _targetDirPath;
            ConfigPath = _configPath;

            // ArrayList Images 초기화
            var files = (from file in Directory.GetFiles(TargetDirPath)
                         let info = new FileInfo(file)
                         select new
                         {
                             name = info.Name
                         }).ToList();
            foreach (var f in files)
            {
                string ext = Path.GetExtension(f.name);
                if (IsImage(ext))
                    Images.Add(f.name);
            }
            
            // 만약 이미지가 하나도 없으면 더이상 진행하지 않음
            if(Images.Count <= 0)
            {
                MessageBox.Show("작업대상 디렉토리에 이미지가 없습니다. 다른 디렉토리를 선택해주세요.", "SFS : 작업대상 없음", MessageBoxButtons.OK);
                return;
            }

            // 설정파일 불러와 Dictionary<> FeatureSet 초기화
            StreamReader sr = new StreamReader(ConfigPath);
            while (sr.EndOfStream == false)
            {
                string[] splitedLine = (sr.ReadLine()).Split(":");

                string feature = splitedLine[0].Trim();
                string value = splitedLine[1].Trim();

                // FeatureSet 딕셔너리에 해당 행 내용 추가
                string[] keys = FeatureSet.Keys.ToArray();
                bool isExistFeature = Array.Exists(keys, el=>el.Equals(feature));
                if (isExistFeature)
                    FeatureSet[feature] += $":{value}"; // 특징항목 아래의 값들의 구분자는 콜론(:)
                else
                    FeatureSet.Add(feature, value); 
            }
            sr.Close();

            // ArrayList Features 초기화
            Features = FeatureSet.Keys.ToArray();

            // 현재 이미지에 대한 값 선택 내용 초기화
            foreach (string key in Features)
                CurrentWork[key] = "";

            // textbox_targetDir 값 초기화
            textbox_targetDir.Text = _targetDirPath;

            // listbox_imageList 값 초기화
            foreach(var image in Images)
                listbox_imageList.Items.Add(image);
                
            // 첫 이미지 띄우기
            LoadNewWork(CurrentImageIdx);
            updateCurrentWorkStatus();
        }

        private bool IsImage(string ext)
        {
            string[] arr = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            foreach (string s in arr)
            {
                if (ext == s)
                    return true;
            }
            return false;
        }

        private void updateCurrentWorkStatus()
        {
            listView_currentWorkStatus.Items.Clear();

            foreach (string feature in Features)
            {
                listView_currentWorkStatus.Items.Add(
                    new ListViewItem(
                        new string[] { feature, CurrentWork[feature] }
                    )
                );
            }
        }

        // ================================================================
        //
        //               3. 메소드 (1) : 이미지 전환
        //
        // -------------------------------
        // a. 작업물 저장하기
        // void SaveCurrentWork() : 현재 작업중이던 이미지에 대한 작업내용을 json파일로 저장
        // string BuildJsonData() : 정보들을 json형태로 구조화
        //
        // b. 작업물 불러오기
        // LoadNewWork() : 새로 작업할 이미지와 기존 작업데이터(json)를 불러와 표시
        // Dictionary<string, string> ParseJson() : json을 읽어들여 기존 작업데이터("data")를 딕셔너리 형태로 변환
        //
        // c. 자동넘기기 해제
        // void disableAutoNextImage() : 자동으로 다음 이미지로 넘어가기 설정 해제
        //
        // z. bool IsCurrentWorkFinished()
        // ================================================================

        // a. 작업물 저장하기
        private void SaveCurrentWork(int CurrentImageIdx)
        {
            string imgName = Images[CurrentImageIdx];

            string imgPath = Path.Combine(TargetDirPath, imgName);
            string jsonPath = imgPath + ".json";

            StreamWriter sw = new StreamWriter(jsonPath);
            sw.Write(BuildJsonData());
            sw.Close();
        }

        private string BuildJsonData()
        {
            string imgName = Images[CurrentImageIdx];

            string res = "";
            res += "{\n";
            res += $"\t\"rawdata\" : \"{imgName}\",\n";
            res += $"\t\"config_name\" : \"{Path.GetFileNameWithoutExtension(ConfigPath)}\",\n";
            res += "\t\"data\" : {\n";
            for (int i = 0; i < Features.Length; i++)
            {
                string feature = Features[i];
                res += $"\t\t\"{feature}\" :  \"{CurrentWork[feature]}\"{ ((i < Features.Length - 1) ? "," : "") }\n";
            }
            res += "\t}\n";
            res += "}\n";

            return res;
        }

        // b. 작업물 불러오기
        private void LoadNewWork(int CurrentImageIdx)
        {
            string imgName = Images[CurrentImageIdx];

            string imgPath = Path.Combine(TargetDirPath, imgName);
            string jsonPath = imgPath + ".json";

            // 이미 json파일이 있는 경우, "현재 이미지에 대한 값 선택 내용" 불러오기
            FileInfo jsonFileInfo = new FileInfo(jsonPath);
            if (jsonFileInfo.Exists)
            {
                Dictionary<string, string> jsonData = ParseJson(jsonPath);
                if (jsonData["_SFS_RESPONSE_result"] == "error")
                {
                    MessageBox.Show($"이 이미지에 대한 레이블데이터(json)의 형식이 올바르지 않습니다. json파일을 확인해주세요.\n현재 이 대화상자를 닫고 새로 작업하면 그 내용으로 저장됩니다.\n다른 이미지로 넘어가면 이 이미지의 기존 데이터가 유실됩니다.\n : {jsonPath}", "SFS:잘못된 데이터", MessageBoxButtons.OK);
                } 
                else
                {
                    foreach (string key in Features)
                        CurrentWork[key] = jsonData[key];
                }
            }
            else // 기존 json파일이 없는 경우 "현재 이미지에 대한 값 선택 내용" 모두 비우기
            {
                foreach (string key in Features)
                    CurrentWork[key] = "";
            }

            // 이미지 교체
            pictureBox_currentImage.Image = Bitmap.FromFile(imgPath);

            // "선택중인 특징항목" 초기화
            CurrentFeatureIdx = 0;
            ChangeCurrentFeature();

            // "현재 이미지 작업현황" 갱신
            updateCurrentWorkStatus();
        }

        private Dictionary<string, string> ParseJson(string jsonPath)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            
            // json파일 읽어들여 문자열로 저장
            StreamReader sr = new StreamReader(jsonPath);
            string str = "";
            while (!sr.EndOfStream)
                str += sr.ReadLine();
            sr.Close();

            // 레이블데이터가 담긴 "data"키가 있는지 확인
            int searchStartIdx = str.IndexOf("\"data\"");
            if(searchStartIdx == -1) // "data"키가 없는 경우 early return
            {
                data["_SFS_RESPONSE_result"] = "error";
                return data;
            }

            // 실제 파싱할 내용이 어디부터(dataStartIdx) 어디까지(dataEndIdx) 있는지 확인
            int dataStartIdx = -1;   // "data" : {  ...  } 에서 {의 바로 뒷 문자 인덱스 
            int dataEndIdx = -1;     //                               }의 바로 앞 문자 인덱스
            for(int i= searchStartIdx; i<str.Length; i++)
            {
                char ch = str[i];
                if (ch == '{') 
                    dataStartIdx = i + 1;
                else if (ch == '}')
                {
                    dataEndIdx = i - 1;
                    break;
                }
            }

            // 실제 파싱 수행
            string rawData = str.Substring(dataStartIdx, dataEndIdx - dataStartIdx+1);
            foreach(string item in rawData.Split(","))
            {
                string[] splitted = item.Split(":");
                string feature = (splitted[0]).Trim();
                feature = feature.Substring(1, feature.Length - 2);
                string value = (splitted[1]).Trim();
                value = value.Substring(1, value.Length - 2);

                data[feature] = value;
            }
            data["_SFS_RESPONSE_result"] = "success";
            return data;
        }

        // c. 자동 넘기기 해제
        private void disableAutoNextImage()
        {
            checkbox_autoNextImage.Checked = false;
        }

        // z. 단순 유틸리티
        // 현재 작업중인 이미지의 모든 특징항목의 값이 선택되었는지(완료되었는지) 여부 반환. (true : 완료 / false : 미완료)
        private bool IsCurrentWorkFinished()
        {
            int res = Array.IndexOf(CurrentWork.Values.ToArray(), "");
            if (res == -1)
                return true;
            else
                return false;
        }

        // ================================================================
        //
        //               4. 메소드 (2) : 특징항목(Feature) 전환
        //
        // -------------------------------
        // void ChangeCurrentFeature() : 특징항목 전환 (호출경로 : 마우스입력, 키보드입력)
        // void disableAutoNextFeature() : 자동으로 다음 선택항목으로 넘어가기 설정 해제
        // ================================================================
        private void ChangeCurrentFeature()
        {
            string currentFeature = Features[CurrentFeatureIdx];

            // "선택중인 특징항목" 변경
            textbox_currentFeature.Text = currentFeature;

            // 특징항목 순서(페이지네이션) 변경
            textbox_featurePagenation.Text = $"{CurrentFeatureIdx+1} / {Features.Length} ";

            // "선택중인 특징항목의 선택가능한 값" 변경
            listbox_availableValue.Items.Clear();
            CurrentAvailableValues = (FeatureSet[currentFeature]).Split(":");
            for (int i = 0; i < CurrentAvailableValues.Length; i++)
            {
                string value = CurrentAvailableValues[i];
                string key = (i < 10) ? $"( {i} )" : ""; // 단축키
                listbox_availableValue.Items.Add($"{key} {value}");
            }

            // 이미 선택된 값이 있었던 경우, select처리함
            string v = CurrentWork[currentFeature];
            if (v != "")
                listbox_availableValue.SelectedIndex = Array.IndexOf(CurrentAvailableValues, v);
        }

        private void disableAutoNextFeature()
        {
            checkbox_autoNextFeature.Checked = false;
        }
        

        // ================================================================
        //
        //               5. 이벤트 핸들러
        //
        // -------------------------------
        // a. 키보드 입력 처리
        // void WorkappForm_KeyDown() : 키보드 입력을 받아 적절한 메소드 호출
        //      ㄴ 특징항목 값 선택  ---- (호출) ----> void listbox_availableValue_SelectedIndexChanged()
        //      ㄴ 특징항목 전환 -------- (호출) ----> void ChangeCurrentFeature()
        //      ㄴ 이미지 전환 ---------- (호출) ----> void listbox_imageList_SelectedIndexChanged()
        //      ㄴ 자동넘기기 설정 변경
        //
        // b. 마우스 입력 처리 (클릭) : 이전/다음 특징항목 클릭입력을 받아 특징항목 전환
        // void button_prevFeature_Click() --- (호출) ---> void ChangeCurrentFeature()
        // void button_nextFeature_Click() --- (호출) ---> void ChangeCurrentFeature()
        //
        // c. listbox 선택된 항목 변경 처리
        // void listbox_imageList_SelectedIndexChanged() : 이미지 변경
        // void listbox_availableValue_SelectedIndexChanged()
        //      ㄴ 특징항목 값 변경에 따른 컨트롤 업데이트
        //      ㄴ 다음 특징항목으로 / 다음 이미지 로 자동으로 넘어갈지 판단하여 특징항목/이미지 전환
        //
        // -------------------------------
        //
        // z. 직접 정의하지 않은 마우스 입력 처리 (클릭) : listbox selectedIndex 변경에 따른 핸들러호출
        // listbox_availableValue에서 선택값 변경 --- (호출) ---> void listbox_availableValue_SelectedIndexChanged()
        // listbox_imageList에서 선택값 변경 -------- (호출) ---> void listbox_imageList_SelectedIndexChanged()
        // ================================================================

        // a. 키보드 입력 처리
        private void WorkappForm_KeyDown(object sender, KeyEventArgs e)
        {
            // 어떤 명령을 처리해야 할지 대분류 결정. 
            int task = -1; // (0:특징항목 값 선택 / 1:특징항목 전환 / 2:이미지 전환 / 3:자동넘기기 설정 변경)
            Keys k = e.KeyCode;
            if (k == Keys.NumPad0 || k == Keys.NumPad1 || k == Keys.NumPad2 || k == Keys.NumPad3 || k == Keys.NumPad4 || k == Keys.NumPad5 || k == Keys.NumPad6 || k == Keys.NumPad7 || k == Keys.NumPad8 || k == Keys.NumPad9)
                task = 0;
            else if (k == Keys.A || k == Keys.S)
                task = 1;
            else if (k == Keys.Q || k == Keys.W)
                task = 2;
            else if (k == Keys.R || k == Keys.F)
                task = 3;

            // 결정된 task에 따라 명령수행
            if (task == 0) // 특징항목 값 선택
            {
                int numkey = (int)e.KeyCode - 96; // Numpad 숫자. 만약 이 값이 2라면, Numpad 2가 눌린 것임.
                if (numkey < CurrentAvailableValues.Length)
                    listbox_availableValue.SelectedIndex = numkey;
            }
            else if (task == 1) // 특징항목 전환
            {
                int delta = 0;
                if (k == Keys.A && CurrentFeatureIdx > 0)
                {
                    disableAutoNextFeature();
                    delta = -1;
                }
                else if (k == Keys.S && CurrentFeatureIdx < Features.Length -1)
                    delta = 1;
                else
                    return;

                CurrentFeatureIdx += delta;
                ChangeCurrentFeature();
            }
            else if (task == 2) // 이미지 전환
            {
                int delta = 0;
                if (e.KeyCode == Keys.Q && CurrentImageIdx > 0)
                {
                    disableAutoNextImage();
                    delta = -1;
                }
                else if (e.KeyCode == Keys.W && CurrentImageIdx < Images.Count - 1)
                    delta = 1;

                else
                    return;

                listbox_imageList.SelectedIndex = CurrentImageIdx+delta; // listbox_imageList_SelectedIndexChanged() 이벤트 핸들러를 통해 이미지 전환 처리
            }
            else if (task == 3) // 자동넘기기 설정 변경
            {
                if(e.KeyCode == Keys.R)
                    checkbox_autoNextImage.Checked = !checkbox_autoNextImage.Checked;
                else if (e.KeyCode ==Keys.F)
                    checkbox_autoNextFeature.Checked = !checkbox_autoNextFeature.Checked;
            }
        }

        // b. 마우스 입력 처리 (클릭)
        private void button_prevFeature_Click(object sender, EventArgs e)
        {
            if(CurrentFeatureIdx > 0)
            {
                CurrentFeatureIdx -= 1;
                disableAutoNextFeature();
                ChangeCurrentFeature();
            }
        }

        private void button_nextFeature_Click(object sender, EventArgs e)
        {
            if (CurrentFeatureIdx < Features.Length - 1)
            {
                CurrentFeatureIdx += 1;
                ChangeCurrentFeature();
            }
        }

        // c. listbox 선택된 항목 변경 처리
        private void listbox_imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIdx = listbox_imageList.SelectedIndex;
            if (newIdx < CurrentImageIdx)
                disableAutoNextImage();

            SaveCurrentWork(CurrentImageIdx);
            CurrentImageIdx = newIdx;
            LoadNewWork(CurrentImageIdx);
        }

        private void listbox_availableValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CurrentWork[현재특징항목] 에 값 넣기
            string feature = Features[CurrentFeatureIdx];

            int listboxItemIdx = listbox_availableValue.SelectedIndex;
            string value = CurrentAvailableValues[listboxItemIdx];

            CurrentWork[feature] = value;
            SaveCurrentWork(CurrentImageIdx);
            // "현재이미지 작업현황" 갱신
            updateCurrentWorkStatus();

            // 해당 이미지의 모든 특징항목에 대한 값이 선택되었는지 확인. 그렇다면 다음이미지로 넘어감.
            if (checkbox_autoNextImage.Checked && IsCurrentWorkFinished())
            {
                if (CurrentImageIdx < Images.Count - 1)
                    listbox_imageList.SelectedIndex = CurrentImageIdx + 1; // listbox_imageList_SelectedIndexChanged() 이벤트 핸들러를 통해 이미지 전환 처리
            }
            // 다음 특징항목으로 넘어가기
            if (checkbox_autoNextFeature.Checked && CurrentWork[feature] !="" && CurrentFeatureIdx < Features.Length - 1)
            {
                CurrentFeatureIdx += 1;
                ChangeCurrentFeature();
            }
        }

        // listbox의 항목이 키보드입력에 의해 의도치않게 선택되는 경우 방지
        private void listbox_imageList_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
