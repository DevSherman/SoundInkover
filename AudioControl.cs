using System;
using System.Windows.Forms;

namespace SoundInvoker
{
    public partial class AudioControl : UserControl
    {
        public static AudioControl INSTANCE;
        private SoundItem item;
        private OpenFileDialog filedialog;
        public bool inKeySet;

        public AudioControl()
        {
            InitializeComponent();
            INSTANCE = this;
            item = new SoundItem();
            inKeySet = false;
        }
        public void SetAudio(SoundItem item)
        {
            this.item = item;

            cmdName.Text = item.cmd;
            openAudioFileButton.Text = item.name;
            shortcutButton.Text = item.key1 + "+" + item.key2;
            inKeySet = false;
        }
        private void OpenAudioFileButton_Click(object sender, EventArgs e)
        {
            filedialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Select audio file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Audio files (*.mp3)|*.mp3",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                item.name = filedialog.SafeFileName;
                item.path = filedialog.FileName;
                openAudioFileButton.Text = item.name;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want remove this item?", "ITEM", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                INSTANCE = null;
                MainForm.INSTANCE.DeleteControl(this);
                this.Dispose();
            }
        }
        private void ShortcutButton_Click(object sender, EventArgs e)
        {
            inKeySet = true;
            MessageBox.Show("Press any combination of 2 keys (ej: Alt + Num4)");
            inKeySet = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item.key1) || string.IsNullOrEmpty(item.key2))
            {
                MessageBox.Show("Key binding needed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(item.path))
            {
                MessageBox.Show("Sound needed, please add a sound.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmdName.Text[0] != '!')
            {
                MessageBox.Show("Command need '!' symbol.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SetEnable(false);
            item.cmd = cmdName.Text;

            MainForm.INSTANCE.SaveItem(item);
            INSTANCE = null;
        }
        internal void SetEnable(bool value)
        {
            saveButton.Enabled = value;
            openAudioFileButton.Enabled = value;
            cmdName.Enabled = value;
            shortcutButton.Enabled = value;
        }

        internal void SetKey(string key1, string key2)
        {
            item.key1 = key1;
            item.key2 = key2;
            shortcutButton.Text = key1 +"+"+ key2;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SetEnable(true);
        }

        private void CmdName_Click(object sender, EventArgs e)
        {
            if(cmdName.Text == "Twitch command")
            {
                cmdName.Text = "";
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.GetSoundPlayer().Play(item.path);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.GetSoundPlayer().Stop(item.path);
        }
    }
}
