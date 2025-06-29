using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinASAR.Common.Helpers;
using WinASAR.WinForm.Common;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000D RID: 13
	public partial class SettingForm : Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0001F14C File Offset: 0x0001D34C
		public SettingForm()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
			{
				goto IL_004E;
			}
			for (;;)
			{
				IL_0068:
				switch (num)
				{
				case 1:
					goto IL_004E;
				case 2:
					goto IL_0034;
				case 3:
					this.InitializeEvent();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_0034;
					}
					continue;
				}
				break;
			}
			return;
			IL_0034:
			this.InitializeData();
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
			{
				return;
			}
			goto IL_0068;
			IL_004E:
			this.OmCoXgxivv();
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
			{
				goto IL_0034;
			}
			goto IL_0068;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001F1DC File Offset: 0x0001D3DC
		public void InitializeData()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				Class24.smethod_1(25, array, this);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0022;
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001F240 File Offset: 0x0001D440
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_0025;
				}
				do
				{
					IL_0003:
					Class24.smethod_1(26, array, this);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0);
				IL_0025:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return;
				default:
					goto IL_0003;
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		private void method_0(string string_0, string string_1, string string_2 = "", string string_3 = "", string string_4 = "")
		{
			for (;;)
			{
				IL_00D3:
				object[] array = new object[5];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_00AB;
				}
				do
				{
					IL_008B:
					array[0] = string_0;
					num = 4;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0);
				for (;;)
				{
					IL_00AB:
					switch (num)
					{
					case 1:
						goto IL_008B;
					case 2:
						goto IL_00D3;
					case 3:
						goto IL_007D;
					case 4:
						array[1] = string_1;
						goto IL_007D;
					case 5:
						goto IL_0051;
					case 6:
						goto IL_002E;
					case 7:
						Class24.smethod_1(27, array, this);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							continue;
						}
						break;
					}
					return;
					IL_002E:
					array[4] = string_4;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						return;
					}
					continue;
					IL_0051:
					array[3] = string_3;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_002E;
					}
					continue;
					IL_007D:
					array[2] = string_2;
					goto IL_0051;
				}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		private void method_1(string string_0)
		{
			try
			{
				if (File.Exists(string_0))
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_0035;
					}
					do
					{
						IL_001B:
						File.Delete(string_0);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0);
					IL_0035:
					switch (num)
					{
					case 0:
						goto IL_001B;
					case 1:
						break;
					default:
						goto IL_001B;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0097;
				}
				IL_005B:
				Console.WriteLine(Class15.smethod_17(768780608 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7) + Environment.NewLine + ex.Message);
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					goto IL_00A8;
				}
				IL_0097:
				switch (num2)
				{
				case 0:
					goto IL_005B;
				case 1:
					break;
				default:
					goto IL_005B;
				}
				IL_00A8:;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001F474 File Offset: 0x0001D674
		private void method_2(object sender, EventArgs e)
		{
			try
			{
				base.Visible = false;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_01C0;
				}
				goto IL_01E4;
				IL_0022:
				string text;
				this.method_1(text);
				IL_002A:
				string executablePath;
				this.method_0(text, executablePath, "", "", "");
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_01E4;
				}
				IL_0058:
				if (!this.checkBox_0.Checked)
				{
					goto IL_009C;
				}
				IL_0065:
				ShellHelper.CreateFileAssociation(Class15.smethod_17(642133168 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Class15.smethod_17(1396557978 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), Application.ExecutablePath, 0);
				goto IL_00CB;
				IL_009C:
				ShellHelper.RemoveFileAssociation(Class15.smethod_17(552175098 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), Class15.smethod_17(1788630700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
				IL_00CB:
				if (MessageBox.Show(Class15.smethod_17(277637054 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98), Class15.smethod_17(974453471 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_0161;
					}
					goto IL_01E4;
				}
				IL_0117:
				if (AppHelper.AppConfigCenter.AppWizardKeys.Contains(Class15.smethod_17(635812615 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2)))
				{
					goto IL_0161;
				}
				IL_013D:
				AppHelper.AppConfigCenter.AppWizardKeys.Add(Class15.smethod_17(974449419 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
				IL_0161:
				base.Close();
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0235;
				}
				goto IL_01E4;
				IL_017E:
				if (!this.checkBox_1.Checked)
				{
					goto IL_0197;
				}
				IL_018B:
				executablePath = Application.ExecutablePath;
				goto IL_0022;
				IL_0197:
				this.method_1(text);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0058;
				}
				goto IL_01E4;
				IL_01C0:
				text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Class15.smethod_17(299955249 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
				goto IL_017E;
				IL_01E4:
				switch (num)
				{
				case 0:
					goto IL_01C0;
				case 1:
				case 10:
					goto IL_0058;
				case 2:
					goto IL_009C;
				case 3:
					goto IL_013D;
				case 4:
					goto IL_0117;
				case 5:
				case 9:
					goto IL_0161;
				case 6:
					goto IL_002A;
				case 7:
				case 13:
					goto IL_00CB;
				case 8:
					goto IL_018B;
				case 11:
					ShellHelper.RefreshIconCache();
					goto IL_0117;
				case 12:
					goto IL_0197;
				case 14:
					goto IL_017E;
				case 15:
					goto IL_0065;
				case 16:
					break;
				case 17:
					goto IL_0022;
				default:
					goto IL_01C0;
				}
				IL_0235:;
			}
			catch (Exception ex)
			{
				if (AppHelper.AppConfigCenter.AppWizardKeys.Contains(Class15.smethod_17(1760310577 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039)))
				{
					AppHelper.AppConfigCenter.AppWizardKeys.Remove(Class15.smethod_17(1743170342 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8));
				}
				MessageBox.Show(ex.Message, Class15.smethod_17(1270980856 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					switch (num2)
					{
					}
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001F764 File Offset: 0x0001D964
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001F79C File Offset: 0x0001D99C
		private void method_4(object sender, CancelEventArgs e)
		{
			for (;;)
			{
				AppHelper.AppConfigCenter.IsAssociationASAR = this.checkBox_0.Checked;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_002C;
				}
				do
				{
					IL_0003:
					AppHelper.AppConfigCenter.IsCreateShortcuts = this.checkBox_1.Checked;
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0);
				IL_002C:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return;
				default:
					goto IL_0003;
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001F890 File Offset: 0x0001DA90
		private void OmCoXgxivv()
		{
			for (;;)
			{
				IL_0B62:
				this.button_0 = new Button();
				for (;;)
				{
					IL_0B55:
					this.button_1 = new Button();
					for (;;)
					{
						IL_0B48:
						this.tabControl_0 = new TabControl();
						for (;;)
						{
							IL_0B3B:
							this.tabPage_0 = new TabPage();
							for (;;)
							{
								IL_0B2E:
								this.groupBox_0 = new GroupBox();
								for (;;)
								{
									IL_0B21:
									this.checkBox_1 = new CheckBox();
									for (;;)
									{
										IL_0AFC:
										this.groupBox_1 = new GroupBox();
										int num = 61;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
										{
											goto IL_0519;
										}
										for (;;)
										{
											IL_0951:
											switch (num)
											{
											case 0:
												goto IL_071E;
											case 1:
												goto IL_0469;
											case 2:
												goto IL_0502;
											case 3:
												goto IL_005B;
											case 4:
												goto IL_0B48;
											case 5:
												this.button_0.Text = Class15.smethod_17(1788629272 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
												goto IL_07E3;
											case 6:
												goto IL_0601;
											case 7:
												goto IL_04D9;
											case 8:
												goto IL_013B;
											case 9:
												goto IL_08F4;
											case 10:
												goto IL_02D5;
											case 11:
												goto IL_072A;
											case 12:
												this.button_1.Location = new Point(176, 241);
												goto IL_022A;
											case 13:
												goto IL_06CC;
											case 14:
												goto IL_0B77;
											case 15:
												break;
											case 16:
												goto IL_0362;
											case 17:
												goto IL_02B4;
											case 18:
												goto IL_0B9E;
											case 19:
												goto IL_0356;
											case 20:
												goto IL_0294;
											case 21:
												goto IL_0654;
											case 22:
												return;
											case 23:
												goto IL_0322;
											case 24:
												goto IL_087D;
											case 25:
												this.groupBox_1.Name = Class15.smethod_17(649956738 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
												goto IL_08F4;
											case 26:
												goto IL_05CA;
											case 27:
												goto IL_01D5;
											case 28:
												goto IL_0593;
											case 29:
												goto IL_0531;
											case 30:
												this.tabPage_0.Size = new Size(352, 190);
												goto IL_07AB;
											case 31:
												goto IL_0B3B;
											case 32:
												goto IL_01E1;
											case 33:
												goto IL_0871;
											case 34:
												goto IL_007C;
											case 35:
												goto IL_00E2;
											case 36:
												goto IL_0826;
											case 37:
												goto IL_00AD;
											case 38:
												goto IL_0519;
											case 39:
												goto IL_0118;
											case 40:
												goto IL_088F;
											case 41:
												goto IL_068B;
											case 42:
												goto IL_03F8;
											case 43:
												goto IL_0BB6;
											case 44:
												goto IL_0BC1;
											case 45:
												goto IL_02E2;
											case 46:
												this.tabPage_0.Text = Class15.smethod_17(2071396946 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
												goto IL_0871;
											case 47:
												goto IL_0475;
											case 48:
												this.tabPage_0.Name = Class15.smethod_17(2056981977 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
												num = 22;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
												{
													goto IL_0826;
												}
												continue;
											case 49:
												goto IL_07E3;
											case 50:
												goto IL_04A1;
											case 51:
												goto IL_041D;
											case 52:
												goto IL_07D1;
											case 53:
												goto IL_07AB;
											case 54:
												goto IL_0786;
											case 55:
												goto IL_0587;
											case 56:
												goto IL_015D;
											case 57:
												goto IL_075A;
											case 58:
												goto IL_022A;
											case 59:
												this.checkBox_0.Size = new Size(276, 16);
												goto IL_067F;
											case 60:
												goto IL_06AB;
											case 61:
												this.checkBox_0 = new CheckBox();
												goto IL_075A;
											case 62:
												goto IL_06B7;
											case 63:
												goto IL_0495;
											case 64:
												goto IL_039D;
											case 65:
												goto IL_0AFC;
											case 66:
												goto IL_06D8;
											case 67:
												goto IL_0BCD;
											case 68:
												goto IL_0B55;
											case 69:
												goto IL_0B62;
											case 70:
												goto IL_01A8;
											case 71:
												goto IL_0525;
											case 72:
												goto IL_043D;
											case 73:
												goto IL_067F;
											case 74:
												goto IL_03C8;
											case 75:
												goto IL_00E8;
											case 76:
												goto IL_0142;
											case 77:
												goto IL_0B2E;
											case 78:
												goto IL_063E;
											case 79:
												goto IL_062D;
											case 80:
												goto IL_00D7;
											case 81:
												goto IL_0B92;
											case 82:
												goto IL_0336;
											case 83:
												goto IL_0566;
											case 84:
												goto IL_02F8;
											case 85:
												goto IL_0288;
											case 86:
												goto IL_0BAA;
											case 87:
												goto IL_037C;
											case 88:
												goto IL_01F5;
											case 89:
												goto IL_011F;
											case 90:
												goto IL_0B70;
											case 91:
												goto IL_05F5;
											case 92:
												goto IL_05B9;
											case 93:
												goto IL_04C3;
											case 94:
												goto IL_0409;
											case 95:
												goto IL_025F;
											case 96:
												goto IL_017E;
											case 97:
												base.Controls.Add(this.tabControl_0);
												goto IL_0118;
											case 98:
												goto IL_0B21;
											case 99:
												goto IL_00FA;
											case 100:
												goto IL_0BD8;
											case 101:
												goto IL_00CC;
											case 102:
												goto IL_0026;
											case 103:
												goto IL_0006;
											default:
												goto IL_071E;
											}
											IL_003A:
											this.button_0.TabIndex = 1;
											num = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
											{
												goto IL_005B;
											}
											continue;
											IL_0026:
											this.button_0.Size = new Size(90, 26);
											goto IL_003A;
											IL_0006:
											this.button_0.Name = Class15.smethod_17(314773181 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
											goto IL_0026;
											IL_00AD:
											this.button_0.Location = new Point(282, 241);
											goto IL_0006;
											IL_007C:
											this.button_0.Font = new Font(Class15.smethod_17(974448635 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
											goto IL_00AD;
											IL_005B:
											this.button_0.DialogResult = DialogResult.Cancel;
											num = 17;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
											{
												goto IL_007C;
											}
											continue;
											IL_00E8:
											this.button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
											goto IL_005B;
											IL_00E2:
											base.SuspendLayout();
											goto IL_00E8;
											IL_00D7:
											this.groupBox_1.SuspendLayout();
											goto IL_00E2;
											IL_00CC:
											this.groupBox_0.SuspendLayout();
											goto IL_00D7;
											IL_00FA:
											this.tabPage_0.SuspendLayout();
											goto IL_00CC;
											IL_075A:
											this.tabControl_0.SuspendLayout();
											goto IL_00FA;
											IL_011F:
											base.MaximizeBox = false;
											num = 6;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
											{
												goto IL_013B;
											}
											continue;
											IL_0118:
											base.FormBorderStyle = FormBorderStyle.FixedSingle;
											goto IL_011F;
											IL_015D:
											base.ShowInTaskbar = false;
											num = 78;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
											{
												goto Block_1;
											}
											continue;
											IL_0142:
											base.Name = Class15.smethod_17(1788750877 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
											goto IL_015D;
											IL_013B:
											base.MinimizeBox = false;
											goto IL_0142;
											IL_01A8:
											this.tabPage_0.Location = new Point(4, 22);
											num = 48;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
											{
												goto IL_03F8;
											}
											continue;
											IL_017E:
											this.tabPage_0.Font = new Font(Class15.smethod_17(1678096732 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a), 9f);
											goto IL_01A8;
											IL_01F5:
											this.checkBox_0.Name = Class15.smethod_17(2071403072 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
											num = 59;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
											{
												goto IL_022A;
											}
											continue;
											IL_01E1:
											this.checkBox_0.Location = new Point(19, 33);
											goto IL_01F5;
											IL_01D5:
											this.checkBox_0.CheckState = CheckState.Checked;
											goto IL_01E1;
											IL_03F8:
											this.checkBox_0.Checked = true;
											goto IL_01D5;
											IL_062D:
											this.checkBox_0.AutoSize = true;
											goto IL_03F8;
											IL_072A:
											this.groupBox_1.Text = Class15.smethod_17(1985309456 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
											goto IL_062D;
											IL_071E:
											this.groupBox_1.TabStop = false;
											goto IL_072A;
											IL_022A:
											this.button_1.Name = Class15.smethod_17(2128225534 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
											num = 61;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
											{
												continue;
											}
											IL_025F:
											this.button_1.Size = new Size(90, 26);
											num = 74;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
											{
												goto IL_0288;
											}
											continue;
											IL_02B4:
											this.button_1.UseVisualStyleBackColor = true;
											num = 9;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
											{
												goto IL_02D5;
											}
											continue;
											IL_0294:
											this.button_1.Text = Class15.smethod_17(2060611576 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
											goto IL_02B4;
											IL_0288:
											this.button_1.TabIndex = 0;
											goto IL_0294;
											IL_037C:
											this.tabControl_0.TabIndex = 2;
											num = 62;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
											{
												goto IL_039D;
											}
											continue;
											IL_0362:
											this.tabControl_0.Size = new Size(360, 216);
											goto IL_037C;
											IL_0356:
											this.tabControl_0.SelectedIndex = 0;
											goto IL_0362;
											IL_0336:
											this.tabControl_0.Name = Class15.smethod_17(1788629990 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
											goto IL_0356;
											IL_0322:
											this.tabControl_0.Location = new Point(12, 12);
											goto IL_0336;
											IL_02F8:
											this.tabControl_0.Font = new Font(Class15.smethod_17(1570982663 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), 9f);
											goto IL_0322;
											IL_02E2:
											this.tabControl_0.Controls.Add(this.tabPage_0);
											goto IL_02F8;
											IL_02D5:
											this.tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
											goto IL_02E2;
											IL_039D:
											this.tabPage_0.Controls.Add(this.groupBox_0);
											num = 73;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
											{
												continue;
											}
											IL_03C8:
											this.tabPage_0.Controls.Add(this.groupBox_1);
											num = 56;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
											{
												goto IL_017E;
											}
											continue;
											IL_05CA:
											base.Controls.Add(this.button_1);
											num = 97;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
											{
												break;
											}
											continue;
											IL_05B9:
											base.Controls.Add(this.button_0);
											goto IL_05CA;
											IL_0601:
											base.ClientSize = new Size(384, 279);
											num = 35;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
											{
												goto IL_05B9;
											}
											continue;
											IL_05F5:
											base.CancelButton = this.button_0;
											goto IL_0601;
											IL_06CC:
											base.AutoScaleMode = AutoScaleMode.Font;
											goto IL_05F5;
											IL_06B7:
											base.AutoScaleDimensions = new SizeF(6f, 12f);
											goto IL_06CC;
											IL_06AB:
											this.checkBox_0.UseVisualStyleBackColor = true;
											goto IL_06B7;
											IL_068B:
											this.checkBox_0.Text = Class15.smethod_17(538811543 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
											goto IL_06AB;
											IL_067F:
											this.checkBox_0.TabIndex = 0;
											goto IL_068B;
											IL_0654:
											this.groupBox_0.Location = new Point(17, 103);
											num = 54;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
											{
												goto IL_0601;
											}
											continue;
											IL_063E:
											this.groupBox_0.Controls.Add(this.checkBox_1);
											goto IL_0654;
											IL_087D:
											this.groupBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
											goto IL_063E;
											IL_0871:
											this.tabPage_0.UseVisualStyleBackColor = true;
											goto IL_087D;
											IL_06D8:
											this.button_1.Font = new Font(Class15.smethod_17(1387466290 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
											num = 12;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
											{
												goto IL_071E;
											}
											continue;
											IL_07D1:
											this.button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
											goto IL_06D8;
											IL_07E3:
											this.button_0.UseVisualStyleBackColor = true;
											goto IL_07D1;
											IL_07AB:
											this.tabPage_0.TabIndex = 0;
											num = 46;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
											{
												goto IL_005B;
											}
											continue;
											IL_0826:
											this.tabPage_0.Padding = new Padding(3);
											num = 30;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
											{
												goto IL_01D5;
											}
											continue;
											IL_088F:
											this.groupBox_1.TabIndex = 0;
											num = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
											{
												goto IL_071E;
											}
											continue;
											IL_08F4:
											this.groupBox_1.Size = new Size(315, 68);
											goto IL_088F;
										}
										goto IL_043D;
										IL_0786:
										this.groupBox_0.Name = Class15.smethod_17(538811327 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
										goto IL_0502;
										IL_043D:
										this.checkBox_1.Size = new Size(204, 16);
										num = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
										{
											goto IL_0469;
										}
										goto IL_0951;
										IL_041D:
										this.checkBox_1.Name = Class15.smethod_17(299955383 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
										goto IL_043D;
										IL_0409:
										this.checkBox_1.Location = new Point(20, 33);
										goto IL_041D;
										IL_04A1:
										this.groupBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
										num = 18;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
										{
											goto IL_04C3;
										}
										goto IL_0951;
										IL_0495:
										this.checkBox_1.UseVisualStyleBackColor = true;
										goto IL_04A1;
										IL_0475:
										this.checkBox_1.Text = Class15.smethod_17(277635274 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
										goto IL_0495;
										IL_0469:
										this.checkBox_1.TabIndex = 1;
										goto IL_0475;
										IL_04D9:
										this.groupBox_1.Location = new Point(17, 19);
										num = 25;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
										{
											goto IL_0502;
										}
										goto IL_0951;
										IL_04C3:
										this.groupBox_1.Controls.Add(this.checkBox_0);
										goto IL_04D9;
										IL_0531:
										this.groupBox_0.Text = Class15.smethod_17(635808433 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
										num = 37;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
										{
											goto IL_0566;
										}
										goto IL_0951;
										IL_0525:
										this.groupBox_0.TabStop = false;
										goto IL_0531;
										IL_0519:
										this.groupBox_0.TabIndex = 1;
										goto IL_0525;
										IL_0502:
										this.groupBox_0.Size = new Size(315, 68);
										goto IL_0519;
										IL_0566:
										this.checkBox_1.AutoSize = true;
										num = 50;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
										{
											goto IL_0587;
										}
										goto IL_0951;
										IL_0593:
										this.checkBox_1.CheckState = CheckState.Checked;
										num = 24;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
										{
											goto IL_0409;
										}
										goto IL_0951;
										IL_0587:
										this.checkBox_1.Checked = true;
										goto IL_0593;
									}
								}
							}
						}
					}
				}
			}
			Block_1:
			IL_0B70:
			base.StartPosition = FormStartPosition.CenterParent;
			IL_0B77:
			this.Text = Class15.smethod_17(124843078 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
			IL_0B92:
			this.tabControl_0.ResumeLayout(false);
			IL_0B9E:
			this.tabPage_0.ResumeLayout(false);
			IL_0BAA:
			this.groupBox_0.ResumeLayout(false);
			IL_0BB6:
			this.groupBox_0.PerformLayout();
			IL_0BC1:
			this.groupBox_1.ResumeLayout(false);
			IL_0BCD:
			this.groupBox_1.PerformLayout();
			IL_0BD8:
			base.ResumeLayout(false);
		}

		// Token: 0x040000B9 RID: 185
		private Button button_0;

		// Token: 0x040000BA RID: 186
		private Button button_1;

		// Token: 0x040000BB RID: 187
		private TabControl tabControl_0;

		// Token: 0x040000BC RID: 188
		private TabPage tabPage_0;

		// Token: 0x040000BD RID: 189
		private GroupBox groupBox_0;

		// Token: 0x040000BE RID: 190
		private GroupBox groupBox_1;

		// Token: 0x040000BF RID: 191
		private CheckBox checkBox_0;

		// Token: 0x040000C0 RID: 192
		private CheckBox checkBox_1;
	}
}
