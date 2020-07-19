using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoundInvoker
{
    public partial class OptionsUI : Form
    {
        public bool IsOpen = false;
        public Options options;
        public bool editk1 = false;
        public bool editk2 = false;

        public OptionsUI()
        {
            InitializeComponent();
        }
        private void OptionsUI_Load(object sender, EventArgs e)
        {       
            Reload();
        }
        public void Reload()
        {
            IsOpen = true;
            barVolume.Value = options.volume;
            lvolume.Text = options.volume.ToString();
            barCache.Value = options.max_cache;
            lmax.Text = options.max_cache.ToString();

            b1k1.Text = options.b1k1;
            b1k2.Text = options.b1k2;
            b2k1.Text = options.b2k1;
            b2k2.Text = options.b2k2;
        }
        private void B1_Click(object sender, EventArgs e)
        {
            editk1 = true;
            SetEnableControls(false);
            b1k1.BackColor = Color.Green;
            b1k2.BackColor = Color.Green;
        }
        private void B2_Click(object sender, EventArgs e)
        {
            editk2 = true;
            SetEnableControls(false);
            b2k1.BackColor = Color.Green;
            b2k2.BackColor = Color.Green;
        }
        public void SetKeys1(string k1, string k2)
        {
            options.b1k1 = b1k1.Text = k1;
            options.b1k2 = b1k2.Text = k2;

            editk1 = false;
            SetEnableControls(true);
            b1k1.BackColor = Color.Transparent;
            b1k2.BackColor = Color.Transparent;

        }
        public void SetKeys2(string k1, string k2)
        {
            options.b2k1 = b1k1.Text = k1;
            options.b2k2 = b1k2.Text = k2;

            editk2 = false;
            SetEnableControls(true);
            b2k1.BackColor = Color.Transparent;
            b2k2.BackColor = Color.Transparent;
        }
        private void SetEnableControls(bool value)
        {
            b1.Enabled = value;
            b2.Enabled = value;

            barCache.Enabled = value;
            barVolume.Enabled = value;
        }
        private void BarVolume_ValueChanged(object sender, EventArgs e)
        {
            options.volume = barVolume.Value;
            lvolume.Text = options.volume.ToString();
        }
        private void BarCache_ValueChanged(object sender, EventArgs e)
        {
            options.max_cache = barCache.Value;
            lmax.Text = options.max_cache.ToString();
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            IsOpen = false;
            this.Hide();
        }
        private void BReset_Click(object sender, EventArgs e)
        {
            options = new Options();

            barVolume.Value = options.volume;
            lvolume.Text = options.volume.ToString();
            barCache.Value = options.max_cache;
            lmax.Text = options.max_cache.ToString();

            b1k1.Text = options.b1k1;
            b1k2.Text = options.b1k2;
            b2k1.Text = options.b2k1;
            b2k2.Text = options.b2k2;

            b1.Enabled = true;
            b2.Enabled = true;
            b1k1.BackColor = Color.Transparent;
            b1k2.BackColor = Color.Transparent;
        }
        private void BApply_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.GetSoundPlayer().Reset(barCache.Value);
            MainForm.INSTANCE.GetSoundPlayer().SetVolume(options.volume);

            Extensions.SaveOptions(options);
            IsOpen = false;
            this.Hide();
        }

        internal void VolumeDown()
        {
            if (options.volume - 1 < 0) options.volume = 0;
            else options.volume -= 1;

            barVolume.Value = options.volume;
            lvolume.Text = options.volume.ToString();
            MainForm.INSTANCE.GetSoundPlayer().SetVolume(options.volume);
        }

        internal void VolumeUP()
        {
            if (options.volume + 1 > 100) options.volume = 100;
            else options.volume += 1;

            barVolume.Value = options.volume;
            lvolume.Text = options.volume.ToString();
            MainForm.INSTANCE.GetSoundPlayer().SetVolume(options.volume);
        }
    }
}
