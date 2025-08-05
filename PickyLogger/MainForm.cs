using System.Diagnostics;
using System.Runtime.InteropServices; // 꼭 추가해야 함



namespace PickyLogger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text and Log Files (*.txt;*.log)|*.txt;*.log|All Files (*.*)|*.*";
            openFileDialog.Title = "Select Input Files";


            string lastFolder = Properties.Settings.Default.LastOpenFolder;

            if (!string.IsNullOrEmpty(lastFolder) && Directory.Exists(lastFolder))
            {
                openFileDialog.InitialDirectory = lastFolder;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstSelectedFiles.Items.Clear();
                lstSelectedFiles.Items.AddRange(openFileDialog.FileNames);
                ScrollListBoxToEnd(lstSelectedFiles);

                // 설정에 폴더 저장 후 저장
                string folder = Path.GetDirectoryName(openFileDialog.FileName);
                Properties.Settings.Default.LastOpenFolder = folder;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Text and Log Files (*.txt;*.log)|*.txt;*.log|All Files (*.*)|*.*";
            saveFileDialog.Title = "Select Output File";
            saveFileDialog.DefaultExt = "txt";

            // 이전에 저장된 폴더를 불러와 초기 경로 지정
            string lastFolder = Properties.Settings.Default.LastSaveFolder;

            if (!string.IsNullOrEmpty(lastFolder) && Directory.Exists(lastFolder))
            {
                saveFileDialog.InitialDirectory = lastFolder;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = saveFileDialog.FileName;

                // 커서를 끝으로 이동 + 스크롤
                txtSavePath.SelectionStart = txtSavePath.Text.Length;
                txtSavePath.ScrollToCaret();

                // 설정에 폴더 저장 후 저장
                string folder = Path.GetDirectoryName(saveFileDialog.FileName);
                Properties.Settings.Default.LastSaveFolder = folder;
                Properties.Settings.Default.Save();
            }
        }

        // Win32 API 선언
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // 메시지 상수 정의
        private const int LB_SETHORIZONTALEXTENT = 0x0194;
        private const int WM_HSCROLL = 0x0114;
        private const int SB_RIGHT = 7;

        private void ScrollListBoxToEnd(ListBox listBox)
        {
            if (listBox.Items.Count == 0)
                return;

            // 세로 스크롤: 마지막 항목으로 이동
            listBox.TopIndex = listBox.Items.Count - 1;

            // 수평 스크롤: 최대 폭 계산
            int maxWidth = 0;
            using (Graphics g = listBox.CreateGraphics())
            {
                foreach (var item in listBox.Items)
                {
                    int itemWidth = (int)g.MeasureString(item.ToString(), listBox.Font).Width;
                    if (itemWidth > maxWidth)
                        maxWidth = itemWidth;
                }
            }

            // 수평 스크롤 최대 폭 설정
            SendMessage(listBox.Handle, LB_SETHORIZONTALEXTENT, maxWidth, 0);

            // 수평 스크롤을 끝으로 이동
            SendMessage(listBox.Handle, WM_HSCROLL, SB_RIGHT, 0);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            string filter = txtFilterString.Text;
            string outputPath = txtSavePath.Text;
            var inputFiles = lstSelectedFiles.Items.Cast<string>().ToArray();

            if (inputFiles.Length == 0)
            {
                MessageBox.Show("Please select input files.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(filter))
            {
                MessageBox.Show("Please enter a filter string.", "Filter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                MessageBox.Show("Please select an output file path.", "Output Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    foreach (string file in inputFiles)
                    {
                        txtLog.AppendText($"Processing: {file}{Environment.NewLine}");

                        var lines = File.ReadAllLines(file)
                                        .Where(line => line.Contains(filter));

                        foreach (var line in lines)
                        {
                            writer.WriteLine(line);
                        }

                        txtLog.AppendText($" - Matched lines: {lines.Count()}{Environment.NewLine}");
                    }
                }

                txtLog.AppendText("✅ Completed successfully." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtLog.AppendText("❌ Error: " + ex.Message + Environment.NewLine);
            }
        }

        private void btnOpenSavePath_Click(object sender, EventArgs e)
        {
            OpenDirectoryFromTextBox(txtSavePath);
        }

        private void OpenDirectoryFromTextBox(TextBox txtSavePath)
        {
            string path = txtSavePath.Text.Trim();

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("저장 경로가 비어 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(path))
            {
                try
                {
                    Process.Start("explorer.exe", path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"폴더를 여는 중 오류가 발생했습니다.\n\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("경로가 존재하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}