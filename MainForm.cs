using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using static SoundInvoker.Extensions;

namespace SoundInvoker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private const int MAX_ITEMS = 25;
        private int DELAY = 500;

        public static MainForm INSTANCE;
        private OptionsUI optionsUI;
        private List<SoundItem> audioITEM;   
        private KeyboardListener listener;

        private TwitchOptions twitchOptions;
        public TwitchAccount account;
        public bool logged = false;
        private TwitchIRC IRC;

        //oauth:j9sh9gd5twuf98cct19w9zk44ycqvg

        private SoundPlayer splayer;
        public SoundPlayer GetSoundPlayer() { return splayer; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("A instance of SoundInvoker are running", "SoundInvoker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            INSTANCE = this;
            audioITEM = Extensions.Load();
            for (int i = 0; i < audioITEM.Count; i++)
            {
                AudioControl control = new AudioControl();
                control.SetAudio(audioITEM[i]);
                flowLayoutPanel.Controls.Add(control);
            }
            optionsUI = new OptionsUI
            {
                options = Extensions.LoadOptions()
            };
            account = Extensions.LoadAccount();
            twitchOptions = new TwitchOptions();
            if (account.auto_login) TwitchLogin();

            splayer = new SoundPlayer(optionsUI.options.max_cache);
            audioITEM = new List<SoundItem>(MAX_ITEMS);

            listener = new KeyboardListener();
            listener.KeyDown += Listener_KeyDown;
            listener.KeyUp += Listener_KeyUp;
        }

        internal void AutoLogin(bool value)
        {
            account.auto_login = value;
            Extensions.SaveAccount(account);
        }

        public void TwitchLogin()
        {
            if (!string.IsNullOrEmpty(account.channel_name) &&
            !string.IsNullOrEmpty(account.oauth))
            {
                IRC = new TwitchIRC(account.channel_name, account.oauth);
                IRC.DataAvailable += IRC_DataAvailable;
                ChangeState("Logging...");
            }
        }
        public void Disconnect()
        {
            IRC.Disconnect();
        }
        delegate void SetTextCallback(string text);
        private void ChangeState(string state)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ChangeState);
                this.Invoke(d, new object[] { state });
            }
            else
            {
                this.Text = $"Sound INVOKER [{state}]";
            }
        }

        private void IRC_DataAvailable(object sender, EventArgs e)
        {
            if(!logged)
            {
                try { string result = IRC.Read(); }
                catch 
                {
                    IRC.StopThread();
                    IRC.Disconnect();
                    MessageBox.Show("Error in twitch credentials.", "SoundInvoker", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                finally 
                { 
                    logged = true;
                    Extensions.SaveAccount(account);
                    ChangeState("Twich logged");
                }
            }
            else
            {
                string result = IRC.Read();
                //Console.WriteLine(result);
            }
        }

        //Key events
        private string key1 = "";
        private string key2 = "";
        private void Listener_KeyUp(object sender, RawKeyEventArgs args)
        {
            switch (args.Key.ToString())
            {
                case "LeftShift": key1 = ""; break;
                case "RightShift": key1 = ""; break;
                case "LeftCtrl": key1 = ""; break;
                case "RightCtrl": key1 = ""; break;
                case "LeftAlt": key1 = ""; break;
                case "RightAlt": key1 = ""; break;

                default: key2 = ""; break;
            }
        }
        private void Listener_KeyDown(object sender, RawKeyEventArgs args)
        {
            switch(args.Key.ToString())
            {
                case "LeftShift": key1 = "LeftShift"; break;
                case "RightShift": key1 = "RightShift"; break;
                case "LeftCtrl": key1 = "LeftCtrl"; break;
                case "RightCtrl": key1 = "RightCtrl"; break;
                case "LeftAlt": key1 = "LeftAlt"; break;
                case "RightAlt": key1 = "RightAlt"; break;

                default: key2 = args.Key.ToString(); break;
            }

            if(key1.Length > 0 && key2.Length > 0)
            {
                if (AudioControl.INSTANCE != null)
                {
                    AudioControl.INSTANCE.SetKey(key1, key2);
                }
                if (optionsUI.IsOpen)
                {
                    if (optionsUI.editk1) optionsUI.SetKeys1(key1, key2);
                    if (optionsUI.editk2) optionsUI.SetKeys2(key1, key2);
                }
                if(key1 == optionsUI.options.b1k1 && key2 == optionsUI.options.b1k2)
                {
                    optionsUI.VolumeUP();
                    return;
                }
                if (key1 == optionsUI.options.b2k1 && key2 == optionsUI.options.b2k2)
                {
                    optionsUI.VolumeDown();
                    return;
                }
                //
                for (int i = 0; i < audioITEM.Count; i++)
                {
                    if(audioITEM[i].key1 == key1 && audioITEM[i].key2 == key2)
                    {
                        splayer.Play(audioITEM[i].path);
                    }
                }
            }
        }
        //
        internal void SaveItem(SoundItem soundItem)
        {
            Extensions.Save(soundItem, soundItem.name);
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
        private void AddNewAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Add(new AudioControl());
        }
        internal void DeleteControl(Control control)
        {
            flowLayoutPanel.Controls.Remove(control);
        }

        private void ConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsUI.ShowDialog(this);
            optionsUI.Reload();
        }

        private void TwitchConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            twitchOptions.ShowDialog(this);
        }
    }
}
