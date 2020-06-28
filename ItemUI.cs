using System;
using System.Windows.Forms;

namespace SoundInvoker
{
    public partial class ItemUI : Form
    {
        public ItemUI()
        {
            item = new SoundItem();
            InitializeComponent();
        }
        private SoundItem item;
        internal void SetKey(string k1, string k2)
        {
            item.key1 = k1;
            item.key2 = k2;

            b1.Text = k1;
            b2.Text = k2;
        }
        private void VCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(item.key1) || string.IsNullOrEmpty(item.key2))
            {
                MessageBox.Show("Key binding needed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(string.IsNullOrEmpty(item.path))
            {
                MessageBox.Show("Sound needed, please add a sound.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MainForm.INSTANCE.SaveItem(item);
            this.Close();
        }
        private OpenFileDialog filedialog;
        private void BLoad_Click(object sender, EventArgs e)
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
                bLoad.Text = item.name;
            }
        }
        public static ItemUI INSTANCE;
        private void ItemUI_Load(object sender, EventArgs e)
        {
            INSTANCE = this;
        }
    }
}
