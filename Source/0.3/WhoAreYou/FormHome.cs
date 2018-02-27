// WhoAreYou 0.3
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;

namespace WhoAreYou
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.click);
            sound.Play();

            WhoAreYou_ You = new WhoAreYou_();

            txtHost.Text = You.Get_Hostname();
            txtLocal_IP.Text = You.Get_LocalIP();
            txtRemote_IP.Text = You.Get_RemoteIP();
        }

        private void btnCopyLocal_IP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.click);
            sound.Play();

            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtLocal_IP.Text);
            }
            catch
            {
                //
            }
        }

        private void btnCopyRemote_IP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.click);
            sound.Play();

            try
            {

                Clipboard.Clear();
                Clipboard.SetText(txtRemote_IP.Text);

            }
            catch
            {
                //
            }
        }

        private void btnResolve_IP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.click);
            sound.Play();

            WhoAreYou_ He = new WhoAreYou_();
            txt_IP_He.Text = He.Get_IP(txtHostHe.Text);
        }

        private void btnCopyIP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.click);
            sound.Play();

            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txt_IP_He.Text);
            }
            catch
            {
                //
            }
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ismaelheredia123.wordpress.com");
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WhoAreYou.Properties.Resources.formcreate);
            sound.Play();
        }

    }
}
