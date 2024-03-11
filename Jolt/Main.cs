using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jolt
{
    public partial class Main : Form
    {
        private readonly NotifyIcon sysTrayIcon;
        private readonly ContextMenu sysTrayMenu;
        private readonly Timer interval = new Timer();
        private int seconds = 300;

        public Main()
        {
            InitializeComponent();

            sysTrayMenu = new ContextMenu();
            sysTrayMenu.MenuItems.Add("Enable Jolt", OnEnabled);
            sysTrayMenu.MenuItems.Add("Disable Jolt", OnDisabled);
            sysTrayMenu.MenuItems.Add("Edit Interval", OnShowed);
            sysTrayMenu.MenuItems.Add("Exit", OnExit);

            sysTrayIcon = new NotifyIcon
            {
                Text = "Jolt",
                Icon = new Icon(SystemIcons.Asterisk, 40, 40),
                ContextMenu = sysTrayMenu,
                Visible = true
            };

            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            maskedTextBox.Text = seconds.ToString();

            interval.Interval = seconds * 1000;
            interval.Tick += new EventHandler(SendKey);

            sysTrayMenu.MenuItems[0].Checked = true;
            interval.Start();

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnEnabled(object sender, EventArgs e)
        {
            interval.Start();
            sysTrayMenu.MenuItems[0].Checked = true;
            sysTrayMenu.MenuItems[1].Checked = false;
        }
        private void OnDisabled(object sender, EventArgs e)
        {
            interval.Stop();
            sysTrayMenu.MenuItems[0].Checked = false;
            sysTrayMenu.MenuItems[1].Checked = true;
        }
        private void OnShowed(object sender, EventArgs e)
        {
            Visible = true;
        }
        private void SendKey(object sender, EventArgs e)
        {           
            SendKeys.Send("{F15}");
        }       

        private void BtnHide_Click(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(maskedTextBox.Text);
            interval.Interval = seconds * 1000;
            Visible = false;
        }
    }
}
