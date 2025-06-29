using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WinASAR.ArchiveLib.ASAR;
using WinASAR.WinForm.Common;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000007 RID: 7
	public partial class ExtractForm : Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00011960 File Offset: 0x0000FB60
		public ExtractForm(string asarFileName, string targetDirectory, List<ItemFilter> fileFilters = null, List<ItemFilter> directoryFilters = null)
		{
			this.method_6();
			this.InitializeEvent();
			this.InitializeData(asarFileName, targetDirectory, fileFilters, directoryFilters);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000119B0 File Offset: 0x0000FBB0
		public void InitializeData(string asarFileName, string targetDirectory, List<ItemFilter> fileFilters = null, List<ItemFilter> directoryFilters = null)
		{
			Class24.smethod_1(6, new object[] { asarFileName, targetDirectory, fileFilters, directoryFilters }, this);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00011A04 File Offset: 0x0000FC04
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					Class24.smethod_1(7, array, this);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00011A68 File Offset: 0x0000FC68
		private void method_0(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				folderBrowserDialog = new FolderBrowserDialog();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					break;
				}
				break;
			}
			try
			{
				folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
				int num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0082;
				}
				do
				{
					IL_00A5:
					switch (num2)
					{
					case 1:
						goto IL_00BE;
					case 2:
						goto IL_0066;
					case 3:
						folderBrowserDialog.ShowNewFolderButton = true;
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							goto IL_0066;
						}
						continue;
					}
					break;
					IL_0066:
					if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
					{
						goto IL_00BE;
					}
					num2 = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0);
				IL_0082:
				this.comboBox_0.Text = folderBrowserDialog.SelectedPath;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_00A5;
				}
				IL_00BE:;
			}
			finally
			{
				if (folderBrowserDialog != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto IL_00EE;
					}
					IL_00D6:
					((IDisposable)folderBrowserDialog).Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_00FF;
					}
					IL_00EE:
					switch (num3)
					{
					case 0:
						goto IL_00D6;
					case 1:
						break;
					default:
						goto IL_00D6;
					}
				}
				IL_00FF:;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00011B88 File Offset: 0x0000FD88
		private void method_1(object sender, KeyEventArgs e)
		{
			IL_0044:
			while (e.KeyCode == Keys.Return)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_2(sender, e);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0044;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00011BEC File Offset: 0x0000FDEC
		private void method_2(object sender, EventArgs e)
		{
			for (;;)
			{
				object[] array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0043;
				}
				IL_0051:
				switch (num)
				{
				case 0:
					goto IL_0021;
				case 1:
					IL_0043:
					array[0] = sender;
					break;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					break;
				default:
					goto IL_0021;
				}
				array[1] = e;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					goto IL_0051;
				}
				IL_0021:
				Class24.smethod_1(8, array, this);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					break;
				}
				goto IL_0051;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00011C88 File Offset: 0x0000FE88
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				base.DialogResult = DialogResult.Cancel;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_001D;
				}
				do
				{
					IL_0003:
					base.Close();
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0);
				IL_001D:
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

		// Token: 0x06000047 RID: 71 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		private void method_4(object sender, EventArgs e)
		{
			for (;;)
			{
				this.comboBox_0.Focus();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
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

		// Token: 0x06000048 RID: 72 RVA: 0x00011D20 File Offset: 0x0000FF20
		private void method_5(object sender, CancelEventArgs e)
		{
			for (;;)
			{
				AppHelper.AppConfigCenter.IsExtractAsk = this.checkBox_0.Checked;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
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

		// Token: 0x0600004A RID: 74 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		private void method_6()
		{
			for (;;)
			{
				IL_0DC5:
				this.tabControl_0 = new TabControl();
				for (;;)
				{
					IL_0DA0:
					this.tabPage_0 = new TabPage();
					int num = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						goto IL_0AEA;
					}
					for (;;)
					{
						IL_0BDD:
						switch (num)
						{
						case 1:
							goto IL_002F;
						case 2:
							goto IL_09E6;
						case 3:
							goto IL_0289;
						case 4:
							goto IL_05B0;
						case 5:
							this.groupBox_0.TabIndex = 2;
							num = 17;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
							{
								goto IL_0B56;
							}
							continue;
						case 6:
							goto IL_0504;
						case 7:
							goto IL_02BE;
						case 8:
							goto IL_00BA;
						case 9:
							goto IL_065F;
						case 10:
							goto IL_0215;
						case 11:
							goto IL_0A5D;
						case 12:
							this.button_2.Size = new Size(90, 26);
							goto IL_0A51;
						case 13:
							goto IL_033B;
						case 14:
							goto IL_00C6;
						case 15:
							goto IL_0B90;
						case 16:
							goto IL_02C9;
						case 17:
							goto IL_09A3;
						case 18:
							goto IL_0910;
						case 19:
							this.label_0.Size = new Size(197, 12);
							num = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
							{
								goto IL_0B90;
							}
							continue;
						case 20:
							goto IL_0B56;
						case 21:
							goto IL_0411;
						case 22:
							goto IL_0476;
						case 23:
							goto IL_0A41;
						case 24:
							goto IL_01DD;
						case 25:
							goto IL_032A;
						case 26:
							goto IL_053A;
						case 27:
							goto IL_0631;
						case 28:
							goto IL_030A;
						case 29:
							goto IL_0070;
						case 30:
							goto IL_0456;
						case 31:
							goto IL_0767;
						case 32:
							goto IL_03D8;
						case 33:
							this.button_1.Font = new Font(Class15.smethod_17(642133526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
							num = 48;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
							{
								goto IL_065F;
							}
							continue;
						case 34:
							goto IL_0A17;
						case 35:
							goto IL_08EA;
						case 36:
							this.tabControl_0.SelectedIndex = 0;
							goto IL_0738;
						case 37:
							goto IL_0520;
						case 38:
							goto IL_0253;
						case 39:
							goto IL_0AEA;
						case 40:
							goto IL_0050;
						case 41:
							goto IL_089C;
						case 42:
							goto IL_0738;
						case 43:
							goto IL_0247;
						case 44:
							goto IL_0181;
						case 45:
							goto IL_0611;
						case 46:
							this.tabPage_0.Size = new Size(486, 156);
							goto IL_0910;
						case 47:
							goto IL_0834;
						case 48:
							this.button_1.Location = new Point(310, 207);
							num = 95;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								goto IL_0070;
							}
							continue;
						case 49:
							goto IL_0A51;
						case 50:
							goto IL_0840;
						case 51:
							goto IL_016A;
						case 52:
							goto IL_077F;
						case 53:
							goto IL_0997;
						case 54:
							goto IL_06A5;
						case 55:
							goto IL_02EA;
						case 56:
							goto IL_0546;
						case 57:
							goto IL_0A36;
						case 58:
							goto IL_0567;
						case 59:
							goto IL_09B1;
						case 60:
							goto IL_007C;
						case 61:
							goto IL_04B2;
						case 62:
							goto IL_0DA0;
						case 63:
							goto IL_0DC5;
						case 64:
							goto IL_0652;
						case 65:
							goto IL_038F;
						case 66:
							goto IL_0120;
						case 67:
							goto IL_06E2;
						case 68:
							goto IL_012C;
						case 69:
							goto IL_02D4;
						case 70:
							goto IL_079A;
						case 71:
							goto IL_0590;
						case 72:
							goto IL_02DF;
						case 73:
							goto IL_0962;
						case 74:
							this.tabPage_0.Controls.Add(this.label_0);
							goto IL_07B6;
						case 75:
							return;
						case 76:
							goto IL_070D;
						case 77:
							goto IL_086B;
						case 78:
							goto IL_07E7;
						case 79:
							goto IL_0200;
						case 80:
							goto IL_0100;
						case 81:
							goto IL_01E4;
						case 82:
							goto IL_0936;
						case 83:
							goto IL_035E;
						case 84:
							this.tabPage_0.Name = Class15.smethod_17(89038194 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
							num = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
							{
								goto IL_08EA;
							}
							continue;
						case 85:
							goto IL_01B7;
						case 86:
							this.tabPage_0.Text = Class15.smethod_17(41446635 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d);
							goto IL_0834;
						case 87:
							goto IL_0605;
						case 88:
							goto IL_05F1;
						case 89:
							goto IL_07B6;
						case 90:
							goto IL_0519;
						case 91:
							this.tabPage_0.PerformLayout();
							goto IL_0584;
						case 92:
							base.MinimizeBox = false;
							goto IL_077F;
						case 93:
							goto IL_06CC;
						case 94:
							goto IL_0685;
						case 95:
							this.button_1.Name = Class15.smethod_17(299953511 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
							goto IL_05F1;
						case 96:
							goto IL_0335;
						case 97:
							goto IL_0584;
						case 98:
							goto IL_0531;
						case 99:
							goto IL_0139;
						case 100:
							goto IL_04E3;
						case 101:
							goto IL_03A3;
						case 102:
							goto IL_0089;
						case 103:
							goto IL_0348;
						case 104:
							this.comboBox_0.Name = Class15.smethod_17(1802340405 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
							goto IL_04B2;
						case 105:
							goto IL_0442;
						case 106:
							goto IL_03F1;
						case 107:
							base.Controls.Add(this.button_1);
							goto IL_01B7;
						case 108:
							goto IL_00F4;
						case 109:
							goto IL_0006;
						}
						goto Block_13;
						IL_0006:
						this.button_0.Size = new Size(75, 26);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							goto IL_002F;
						}
						continue;
						IL_0181:
						this.button_0.Name = Class15.smethod_17(1802340381 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
						goto IL_0006;
						IL_016A:
						this.button_0.Location = new Point(390, 14);
						goto IL_0181;
						IL_0139:
						this.button_0.Font = new Font(Class15.smethod_17(41446613 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_016A;
						IL_012C:
						this.button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
						goto IL_0139;
						IL_0120:
						this.checkBox_0.UseVisualStyleBackColor = true;
						goto IL_012C;
						IL_0100:
						this.checkBox_0.Text = Class15.smethod_17(89038374 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
						goto IL_0120;
						IL_00F4:
						this.checkBox_0.TabIndex = 3;
						goto IL_0100;
						IL_0476:
						this.checkBox_0.Size = new Size(204, 16);
						goto IL_00F4;
						IL_0456:
						this.checkBox_0.Name = Class15.smethod_17(642133914 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
						goto IL_0476;
						IL_0442:
						this.checkBox_0.Location = new Point(15, 29);
						goto IL_0456;
						IL_0936:
						this.checkBox_0.CheckState = CheckState.Checked;
						goto IL_0442;
						IL_09A3:
						this.checkBox_0.Checked = true;
						goto IL_0936;
						IL_0997:
						this.checkBox_0.AutoSize = true;
						goto IL_09A3;
						IL_002F:
						this.button_0.TabIndex = 1;
						num = 31;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							goto IL_0050;
						}
						continue;
						IL_00C6:
						this.comboBox_0.Location = new Point(18, 46);
						num = 104;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							return;
						}
						continue;
						IL_00BA:
						this.comboBox_0.FormattingEnabled = true;
						goto IL_00C6;
						IL_0089:
						this.comboBox_0.Font = new Font(Class15.smethod_17(41446613 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_00BA;
						IL_007C:
						this.comboBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
						goto IL_0089;
						IL_0070:
						this.button_0.UseVisualStyleBackColor = true;
						goto IL_007C;
						IL_0050:
						this.button_0.Text = Class15.smethod_17(124841336 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
						goto IL_0070;
						IL_01B7:
						base.Controls.Add(this.tabControl_0);
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							goto IL_01DD;
						}
						continue;
						IL_01E4:
						base.MaximizeBox = false;
						num = 92;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto IL_0200;
						}
						continue;
						IL_01DD:
						base.FormBorderStyle = FormBorderStyle.FixedSingle;
						goto IL_01E4;
						IL_0215:
						base.Controls.Add(this.button_2);
						num = 107;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
						{
							goto IL_023B;
						}
						continue;
						IL_0200:
						base.ClientSize = new Size(518, 245);
						goto IL_0215;
						IL_0520:
						base.CancelButton = this.button_2;
						goto IL_0200;
						IL_0519:
						base.AutoScaleMode = AutoScaleMode.Font;
						goto IL_0520;
						IL_0504:
						base.AutoScaleDimensions = new SizeF(6f, 12f);
						goto IL_0519;
						IL_0411:
						this.groupBox_0.Size = new Size(447, 63);
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							goto Block_2;
						}
						continue;
						IL_03F1:
						this.groupBox_0.Name = Class15.smethod_17(613121979 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6);
						goto IL_0411;
						IL_089C:
						this.groupBox_0.Location = new Point(18, 75);
						goto IL_03F1;
						IL_086B:
						this.groupBox_0.Font = new Font(Class15.smethod_17(299952941 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_089C;
						IL_04B2:
						this.comboBox_0.Size = new Size(447, 20);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto Block_3;
						}
						continue;
						IL_04E3:
						this.button_2.UseVisualStyleBackColor = true;
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_0504;
						}
						continue;
						IL_0546:
						this.tabPage_0.ResumeLayout(false);
						num = 91;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto IL_0567;
						}
						continue;
						IL_053A:
						this.tabControl_0.ResumeLayout(false);
						goto IL_0546;
						IL_0567:
						this.Text = Class15.smethod_17(564887596 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
						goto IL_053A;
						IL_0531:
						base.StartPosition = FormStartPosition.CenterScreen;
						goto IL_0567;
						IL_079A:
						base.ShowInTaskbar = false;
						goto IL_0531;
						IL_077F:
						base.Name = Class15.smethod_17(1788753739 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
						goto IL_079A;
						IL_0590:
						this.groupBox_0.PerformLayout();
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
						{
							goto IL_05B0;
						}
						continue;
						IL_0584:
						this.groupBox_0.ResumeLayout(false);
						goto IL_0590;
						IL_05B0:
						base.ResumeLayout(false);
						num = 32;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							return;
						}
						continue;
						IL_0631:
						this.button_1.UseVisualStyleBackColor = true;
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
						{
							goto IL_0652;
						}
						continue;
						IL_0611:
						this.button_1.Text = Class15.smethod_17(1743168346 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
						goto IL_0631;
						IL_0605:
						this.button_1.TabIndex = 0;
						goto IL_0611;
						IL_05F1:
						this.button_1.Size = new Size(90, 26);
						goto IL_0605;
						IL_065F:
						this.button_2.DialogResult = DialogResult.Cancel;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
						{
							goto Block_5;
						}
						continue;
						IL_0652:
						this.button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
						goto IL_065F;
						IL_06A5:
						this.button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto IL_002F;
						}
						continue;
						IL_0685:
						this.label_0.Text = Class15.smethod_17(642133978 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
						goto IL_06A5;
						IL_0B90:
						this.label_0.TabIndex = 5;
						goto IL_0685;
						IL_06E2:
						this.tabPage_0.Controls.Add(this.button_0);
						num = 48;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
						{
							goto IL_070D;
						}
						continue;
						IL_06CC:
						this.tabPage_0.Controls.Add(this.groupBox_0);
						goto IL_06E2;
						IL_0767:
						this.tabControl_0.TabIndex = 2;
						goto IL_06CC;
						IL_070D:
						this.tabPage_0.Controls.Add(this.comboBox_0);
						num = 74;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
						{
							continue;
						}
						IL_0738:
						this.tabControl_0.Size = new Size(494, 182);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
						{
							goto IL_0767;
						}
						continue;
						IL_07E7:
						this.tabPage_0.Location = new Point(4, 22);
						num = 84;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
						{
							break;
						}
						continue;
						IL_07B6:
						this.tabPage_0.Font = new Font(Class15.smethod_17(552174984 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_07E7;
						IL_0840:
						this.groupBox_0.Controls.Add(this.checkBox_0);
						num = 77;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							goto IL_086B;
						}
						continue;
						IL_0834:
						this.tabPage_0.UseVisualStyleBackColor = true;
						goto IL_0840;
						IL_08EA:
						this.tabPage_0.Padding = new Padding(3);
						num = 46;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							continue;
						}
						IL_0910:
						this.tabPage_0.TabIndex = 0;
						num = 86;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
						{
							goto IL_089C;
						}
						continue;
						IL_0962:
						this.groupBox_0.Text = Class15.smethod_17(197587617 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81);
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto IL_0997;
						}
						continue;
						IL_0B56:
						this.groupBox_0.TabStop = false;
						goto IL_0962;
						IL_09B1:
						this.button_2.Name = Class15.smethod_17(538805923 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
						{
							goto IL_09E6;
						}
						continue;
						IL_0A17:
						this.button_2.Location = new Point(416, 207);
						goto IL_09B1;
						IL_09E6:
						this.button_2.Font = new Font(Class15.smethod_17(2071396536 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						goto IL_0A17;
						IL_0A5D:
						this.button_2.Text = Class15.smethod_17(2008550529 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
						num = 84;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_04E3;
						}
						continue;
						IL_0A51:
						this.button_2.TabIndex = 1;
						goto IL_0A5D;
					}
					IL_0253:
					this.label_0.Font = new Font(Class15.smethod_17(974447919 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_03D8;
					goto IL_0253;
					IL_0247:
					this.label_0.AutoSize = true;
					goto IL_0253;
					IL_023B:
					this.comboBox_0.TabIndex = 0;
					goto IL_0247;
					Block_13:
					Block_5:
					Block_3:
					Block_2:
					goto IL_023B;
					IL_0289:
					this.label_0.Name = Class15.smethod_17(299952785 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_02BE;
					}
					goto IL_0BDD;
					IL_03D8:
					this.label_0.Location = new Point(16, 21);
					goto IL_0289;
					IL_02EA:
					this.tabControl_0.SuspendLayout();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_030A;
					}
					goto IL_0BDD;
					IL_02DF:
					this.button_2 = new Button();
					goto IL_02EA;
					IL_02D4:
					this.button_1 = new Button();
					goto IL_02DF;
					IL_02C9:
					this.label_0 = new Label();
					goto IL_02D4;
					IL_02BE:
					this.comboBox_0 = new ComboBox();
					goto IL_02C9;
					IL_0A41:
					this.button_0 = new Button();
					goto IL_02BE;
					IL_0A36:
					this.checkBox_0 = new CheckBox();
					goto IL_0A41;
					IL_0AEA:
					this.groupBox_0 = new GroupBox();
					goto IL_0A36;
					IL_030A:
					this.tabPage_0.SuspendLayout();
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_032A;
					}
					goto IL_0BDD;
					IL_03A3:
					this.tabControl_0.Name = Class15.smethod_17(564888516 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_03D8;
					}
					goto IL_0BDD;
					IL_038F:
					this.tabControl_0.Location = new Point(12, 12);
					goto IL_03A3;
					IL_035E:
					this.tabControl_0.Font = new Font(Class15.smethod_17(82301622 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_038F;
					IL_0348:
					this.tabControl_0.Controls.Add(this.tabPage_0);
					goto IL_035E;
					IL_033B:
					this.tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					goto IL_0348;
					IL_0335:
					base.SuspendLayout();
					goto IL_033B;
					IL_032A:
					this.groupBox_0.SuspendLayout();
					goto IL_0335;
				}
			}
		}

		// Token: 0x04000027 RID: 39
		private string string_0 = string.Empty;

		// Token: 0x04000028 RID: 40
		private readonly List<ItemFilter> list_0 = new List<ItemFilter>();

		// Token: 0x04000029 RID: 41
		private readonly List<ItemFilter> list_1 = new List<ItemFilter>();

		// Token: 0x0400002B RID: 43
		private TabControl tabControl_0;

		// Token: 0x0400002C RID: 44
		private TabPage tabPage_0;

		// Token: 0x0400002D RID: 45
		private Button button_0;

		// Token: 0x0400002E RID: 46
		private ComboBox comboBox_0;

		// Token: 0x0400002F RID: 47
		private Label label_0;

		// Token: 0x04000030 RID: 48
		private GroupBox groupBox_0;

		// Token: 0x04000031 RID: 49
		private Button button_1;

		// Token: 0x04000032 RID: 50
		private Button button_2;

		// Token: 0x04000033 RID: 51
		private CheckBox checkBox_0;
	}
}
