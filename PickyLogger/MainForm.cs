using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PickyLogger
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int LB_SETHORIZONTALEXTENT = 0x0194;
        private const int WM_HSCROLL = 0x0114;
        private const int SB_RIGHT = 7;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Multiselect = true,
                Filter = "Text and Log Files (*.txt;*.log)|*.txt;*.log|All Files (*.*)|*.*",
                Title = "Select Input Files"
            };

            SetInitialDirectory(openFileDialog, Properties.Settings.Default.LastOpenFolder);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstSelectedFiles.Items.Clear();
                lstSelectedFiles.Items.AddRange(openFileDialog.FileNames);
                ScrollListBoxToEnd(lstSelectedFiles);

                SaveFolderSetting("LastOpenFolder", Path.GetDirectoryName(openFileDialog.FileName));
            }
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text and Log Files (*.txt;*.log)|*.txt;*.log|All Files (*.*)|*.*",
                Title = "Select Output File",
                DefaultExt = "txt"
            };

            SetInitialDirectory(saveFileDialog, Properties.Settings.Default.LastSaveFolder);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = saveFileDialog.FileName;
                txtSavePath.SelectionStart = txtSavePath.Text.Length;
                txtSavePath.ScrollToCaret();

                SaveFolderSetting("LastSaveFolder", Path.GetDirectoryName(saveFileDialog.FileName));
            }
        }

        private void SetInitialDirectory(FileDialog dialog, string folder)
        {
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                dialog.InitialDirectory = folder;
            }
        }

        private void SaveFolderSetting(string propertyName, string folder)
        {
            if (!string.IsNullOrEmpty(folder))
            {
                var settingsType = typeof(Properties.Settings);
                var property = settingsType.GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(Properties.Settings.Default, folder);
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void ScrollListBoxToEnd(ListBox listBox)
        {
            if (listBox.Items.Count == 0)
                return;

            listBox.TopIndex = listBox.Items.Count - 1;

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

            SendMessage(listBox.Handle, LB_SETHORIZONTALEXTENT, maxWidth, 0);
            SendMessage(listBox.Handle, WM_HSCROLL, SB_RIGHT, 0);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            var filters = GetFilterStrings();
            var inputFiles = lstSelectedFiles.Items.Cast<string>().ToArray();
            var outputPath = txtSavePath.Text.Trim();

            if (!ValidateInputs(inputFiles, filters, outputPath))
                return;

            try
            {
                using StreamWriter writer = new(outputPath);
                foreach (string file in inputFiles)
                {
                    txtLog.AppendText($"Processing: {file}{Environment.NewLine}");

                    var lines = File.ReadAllLines(file)
                                    .Where(line => filters.Any(f => line.Contains(f)));

                    foreach (var line in lines)
                        writer.WriteLine(line);

                    txtLog.AppendText($" - Matched lines: {lines.Count()}{Environment.NewLine}");
                }
                txtLog.AppendText("✅ Completed successfully." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtLog.AppendText("❌ Error: " + ex.Message + Environment.NewLine);
            }
        }

        private string[] GetFilterStrings()
        {
            return txtFilterString.Text
                .Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }

        private bool ValidateInputs(string[] inputFiles, string[] filters, string outputPath)
        {
            if (inputFiles.Length == 0)
            {
                ShowWarning("Please select input files.", "Input Required");
                return false;
            }
            if (filters.Length == 0)
            {
                ShowWarning("Please enter a filter string.", "Filter Required");
                return false;
            }
            if (string.IsNullOrWhiteSpace(outputPath))
            {
                ShowWarning("Please select an output file path.", "Output Required");
                return false;
            }
            return true;
        }

        private void ShowWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                ShowWarning("저장 경로가 비어 있습니다.", "경고");
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
                ShowWarning("경로가 존재하지 않습니다.", "경고");
            }
        }
    }
}