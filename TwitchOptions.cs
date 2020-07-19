using System.Windows.Forms;
using static SoundInvoker.Extensions;

namespace SoundInvoker
{
    public partial class TwitchOptions : Form
    {
        public TwitchOptions()
        {
            InitializeComponent();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi/");
        }

        private void ButtonConnection_Click(object sender, System.EventArgs e)
        {
            if(buttonConnection.Text == "DISCONECT")
            {
                buttonConnection.Text = "CONNECT";
                MainForm.INSTANCE.Disconnect();
                return;
            }

            MainForm.INSTANCE.account = new TwitchAccount
            {
                channel_name = tbChannelName.Text,
                oauth = tbOAuth.Text,
                auto_login = autoLogin.Checked
            };
            MainForm.INSTANCE.TwitchLogin();
        }

        private void TwitchOptions_Load(object sender, System.EventArgs e)
        {
            TwitchAccount account = MainForm.INSTANCE.account;
            tbChannelName.Text = account.channel_name;
            tbOAuth.Text = account.oauth;
            autoLogin.Checked = account.auto_login;
            if (MainForm.INSTANCE.logged) buttonConnection.Text = "DISCONECT";
        }
    }
}
