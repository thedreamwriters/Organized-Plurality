using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC.Logging;
using DiscordRPC;
using Newtonsoft.Json;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Media;

namespace Organized_Plurality
{
	public partial class rpcForm : Form
	{

		DiscordRpcClient client = new DiscordRpcClient("my_client_id");
		public rpcForm()
		{
			InitializeComponent();

			var skinManager = MaterialSkinManager.Instance;

			skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			skinManager.ColorScheme = new ColorScheme(Primary.Grey50, Primary.Grey50, Primary.Grey50, Accent.Blue100, TextShade.BLACK);


		}

		void ComposeRPC()
		{
			client = new DiscordRpcClient("825323774987206687");

			client.OnReady += (sender, e) =>
			{
				try
				{
					if (!(txtFronter.Text == ""))
                    {
						this.Invoke((Action)delegate
						{
							txtConsole.Text += (DateTime.Now + " | Received ready state from user " + e.User);
						});
					}
                    else
                    {
						this.Invoke((Action)delegate
						{
							txtConsole.Text += (DateTime.Now + " ERROR | Could not initialize, make sure the necessary fields are filled");
						});
					}
					
				}
				catch
				{
					this.Invoke((Action)delegate
					{
						txtConsole.Text += (DateTime.Now + " ERROR | Ready state was not received!");
						notifyIcon1.ShowBalloonTip(10);
					});
				}
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				try
				{
					this.Invoke((Action)delegate
					{
						txtConsole.Text += "\n" + (DateTime.Now + " | Updating presence!");
					});
				}
				catch
				{
					txtConsole.Text += (DateTime.Now + " ERROR | Could not update presence!");
					notifyIcon1.ShowBalloonTip(10);
				}
			};

			client.Initialize();

			funcConditionals();
		}

		void funcConditionals()
        {
			if (txtFronter.Text != "" && comboFronterType.SelectedIndex == -1)
			{
				funcSingleFront();
			}

			if (txtFronter.Text != "" && comboFronterType.SelectedIndex == 1 && txtFronter2.Text != "")
			{
				funcCoFront();
			}
			else if (txtFronter.Text != "" && comboFronterType.SelectedIndex == 1 && txtFronter2.Text == "" || txtFronter.Text == "" && comboFronterType.SelectedIndex == 1 && txtFronter2.Text != "")
			{
				txtConsole.Text += "\n" + (DateTime.Now + " ERROR | Make sure to fill all the required fields");
				client.Dispose();
				notifyIcon1.ShowBalloonTip(10);
			}

			if (txtFronter.Text != "" && comboFronterType.SelectedIndex == 2 && txtFronter2.Text != "")
			{
				funcCoCon();
			}
			else if (txtFronter.Text != "" && comboFronterType.SelectedIndex == 2 && txtFronter2.Text == "" || txtFronter.Text == "" && comboFronterType.SelectedIndex == 2 && txtFronter2.Text != "")
			{
				txtConsole.Text += "\n" + (DateTime.Now + " ERROR | Make sure to fill all the required fields");
				client.Dispose();
				notifyIcon1.ShowBalloonTip(10);
			}

			
		}

		void funcSingleFront()
		{
			client.SetPresence(new RichPresence()
			{

				Details = "Now fronting: " + txtFronter.Text,
				Timestamps = Timestamps.Now,

				Assets = new Assets()
				{
					LargeImageKey = "",
					LargeImageText = "",
					SmallImageKey = "",


				}
			});
		}

		void funcCoFront()
		{
			client.SetPresence(new RichPresence()
			{

				Details = "Now fronting: " + txtFronter.Text,
				State = "Co-fronting: " + txtFronter2.Text,
				Timestamps = Timestamps.Now,

				Assets = new Assets()
				{
					LargeImageKey = "image_large",
					LargeImageText = "",
					SmallImageKey = "image_small",


				}
			});
		}

		void funcCoCon()
		{
			client.SetPresence(new RichPresence()
			{

				Details = "Now fronting: " + txtFronter.Text,
				State = "Co-conscious: " + txtFronter2.Text,
				Timestamps = Timestamps.Now,

				Assets = new Assets()
				{
					LargeImageKey = "image_large",
					LargeImageText = "",
					SmallImageKey = "image_small",


				}
			});
		}

		void funcUpdateRPC()
		{
			funcConditionals();
		}

        private void btnStartRPC_Click(object sender, EventArgs e)
        {
			if (!(txtFronter.Text == ""))
            {
				ComposeRPC();
				btnUpdateRPC.Visible = true;
				btnStartRPC.Visible = false;
				btnStopRPC.Visible = true;
			}
        }

        private void comboFronterType_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboFronterType.SelectedIndex == 1 || comboFronterType.SelectedIndex == 2)
			{
				txtFronter2.Enabled = true;
			}
            else
            {
				txtFronter2.Enabled = false;
				txtFronter2.Clear();
            }
		}

        private void btnStopRPC_Click(object sender, EventArgs e)
        {
			client.Dispose();
			btnStopRPC.Visible = false;
			btnUpdateRPC.Visible = false;
        }

        private void checkboxBtn1_CheckedChanged(object sender, EventArgs e)
        {
			if (checkboxBtn1.Checked)
            {
				txtBtnTitle.Enabled = true;
				txtBtnUrl.Enabled = true;
            }
			else
            {
				txtBtnTitle.Enabled = false;
				txtBtnTitle.Clear();

				txtBtnUrl.Enabled = false;
				txtBtnUrl.Clear();
			}
        }

        private void btnUpdateRPC_Click(object sender, EventArgs e)
        {
			funcUpdateRPC();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
			WindowState = FormWindowState.Minimized;
        }
    }
}
