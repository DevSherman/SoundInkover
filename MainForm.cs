using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SoundInvoker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private const int MAX_ITEMS = 25;

        public static MainForm INSTANCE;
        private OptionsUI optionsUI;

        private Button[] buttons;
        private List<SoundItem> items;   
        private KeyboardListener listener;

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

            optionsUI = new OptionsUI
            {
                options = Extensions.LoadOptions()
            };
            splayer = new SoundPlayer(optionsUI.options.max_cache);

            items = new List<SoundItem>(MAX_ITEMS);

            listener = new KeyboardListener();
            listener.KeyDown += Listener_KeyDown;
            listener.KeyUp += Listener_KeyUp;

            buttons = new Button[]
            {
                button0, button1, button2, button3, button4,
                button5, button6, button7, button8, button9,
                button10, button11, button12, button13, button14,
                button15, button16, button17, button18, button19,
                button20, button21, button22, button23, button24
            };
            /*//RESET
            for (int i = 0; i < 25; i++)
            {
                Extensions.SaveJsonFile(new SoundItem(i), buttons[i].Name);
            }
            return;*/
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                items.Add(Extensions.Load(buttons[i].Name));
                if(items[i].path.Length > 0)
                {
                    buttons[i].Text = $"{items[i].name.Replace(".mp3", "")}\n\r\n\r[{items[i].key1} + {items[i].key2}]";
                }        
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
                if (ItemUI.INSTANCE != null)
                {
                    ItemUI.INSTANCE.SetKey(key1, key2);
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
                for (int i = 0; i < items.Count; i++)
                {
                    if(items[i].path.Length > 0)
                    {
                        if(items[i].key1 == key1 && items[i].key2 == key2)
                        {
                            splayer.Play(items[i].path);
                        }
                    }
                }
            }
        }
        //
        internal void SaveItem(SoundItem soundItem)
        {
            int i = index;
            items[i] = soundItem;
            currentButton.Text = $"{soundItem.name}\n\r\n\r[{soundItem.key1} + {soundItem.key2}]";
            Extensions.SaveJsonFile(soundItem, "button"+i);

        }

        private Button currentButton;
        private int index;
        private void MouseButton(object sender, MouseEventArgs e)
        {
            currentButton = (Button)sender;

            if (currentButton == null) return;

            index = GetButtonIndex(currentButton);
            currentButton.Focus();

            if (e.Button == MouseButtons.Left) splayer.Play(items[index].path);

            else if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add("Edit");
                menu.MenuItems[0].Click += EditButton;
                menu.MenuItems.Add("Clear");
                menu.MenuItems[1].Click += ClearButton;
                menu.Show((Control)sender, e.Location);
            }
        }
        private void EditButton(object sender, EventArgs e)
        {
            ItemUI itemUI = new ItemUI();
            itemUI.ShowDialog(this);
        }
        private void ClearButton(object sender, EventArgs e)
        {
            if (currentButton.Text.Length == 0) return;
            splayer.Loaded(items[index].path);
            currentButton.Text = "";

            items[GetButtonIndex(currentButton)] = new SoundItem();
            Extensions.SaveJsonFile(new SoundItem(), currentButton.Name);
        }
        private int GetButtonIndex(Button button)
        {
            return int.Parse(button.Name.Replace("button", ""));
        }
        //Window event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                Hide();
            }
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if(!optionsUI.IsOpen) optionsUI.ShowDialog(this);
            }
        }
    }
}
