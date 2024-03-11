using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jolt
{
    public partial class Main : Form
    {
        private readonly NotifyIcon sysTrayIcon;
        private readonly ContextMenuStrip sysTrayMenu;
        private readonly Timer interval = new();
        private int seconds = 300;

        public Main()
        {
            InitializeComponent();

            sysTrayMenu = new ContextMenuStrip();
            sysTrayMenu.Items.Add("Enable Jolt", null, OnEnabled);
            sysTrayMenu.Items.Add("Disable Jolt", null, OnDisabled);
            sysTrayMenu.Items.Add("Edit Interval", null, OnShowed);
            sysTrayMenu.Items.Add("Exit", null, OnExit);

            sysTrayIcon = new NotifyIcon
            {
                Text = "Jolt",
                Icon = new Icon(SystemIcons.Asterisk, 40, 40),
                ContextMenuStrip = sysTrayMenu,
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

            ((ToolStripMenuItem)sysTrayMenu.Items[0]).Checked = true;
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
            ((ToolStripMenuItem)sysTrayMenu.Items[0]).Checked = true;
            ((ToolStripMenuItem)sysTrayMenu.Items[1]).Checked = false;
        }
        private void OnDisabled(object sender, EventArgs e)
        {
            interval.Stop();
            ((ToolStripMenuItem)sysTrayMenu.Items[0]).Checked = false;
            ((ToolStripMenuItem)sysTrayMenu.Items[1]).Checked = true;

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
