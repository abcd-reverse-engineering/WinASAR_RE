using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinASAR.ArchiveLib.ASAR;
using WinASAR.Common.Enums;
using WinASAR.Common.Helpers;
using WinASAR.WinForm.Common;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000006 RID: 6
	public partial class CompressForm : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000026C2 File Offset: 0x000008C2
		public CompressForm(string asarFileName, List<string> fileOrDirectories = null, List<ItemFilter> addFileFilters = null)
		{
			this.method_7();
			this.InitializeEvent();
			this.InitializeData(asarFileName, fileOrDirectories, addFileFilters);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		public void InitializeData(string asarFileName, List<string> fileOrDirectories = null, List<ItemFilter> addFileFilters = null)
		{
			int overwriteType = AppHelper.AppConfigCenter.OverwriteType;
			if (overwriteType != 1)
			{
				if (overwriteType != 2)
				{
					this.radioButton_3.Checked = true;
				}
				else
				{
					this.radioButton_1.Checked = true;
				}
			}
			else
			{
				this.radioButton_2.Checked = true;
			}
			if (!string.IsNullOrEmpty(asarFileName))
			{
				this.string_0 = asarFileName;
			}
			if (fileOrDirectories != null && fileOrDirectories.Count > 0)
			{
				this.list_0.AddRange(fileOrDirectories);
			}
			if (addFileFilters != null && addFileFilters.Count > 0)
			{
				this.list_1.AddRange(addFileFilters);
			}
			KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(0, EnumHelper.GetEnumDescription(CompressTypes.Normal));
			this.oaZzrqUxR.ValueMember = Class15.smethod_17(642133144 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
			this.oaZzrqUxR.DisplayMember = Class15.smethod_17(41446577 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d);
			this.oaZzrqUxR.Items.Add(keyValuePair);
			this.oaZzrqUxR.SelectedIndex = 0;
			this.comboBox_0.Text = asarFileName;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
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
				Class24.smethod_1(3, array, this);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00010014 File Offset: 0x0000E214
		private void method_0(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_006F:
				object[] array = new object[2];
				for (;;)
				{
					IL_004F:
					array[0] = sender;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						return;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							array[1] = e;
							goto IL_0003;
						case 2:
							goto IL_004F;
						case 3:
							goto IL_006F;
						case 4:
							goto IL_0003;
						}
						return;
						IL_0003:
						Class24.smethod_1(4, array, this);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000100A4 File Offset: 0x0000E2A4
		private void method_1(object sender, KeyEventArgs e)
		{
			IL_0044:
			while (e.KeyCode == Keys.Return)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_3(sender, e);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
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

		// Token: 0x06000036 RID: 54 RVA: 0x00010108 File Offset: 0x0000E308
		private void method_2(object sender, EventArgs e)
		{
			for (;;)
			{
				string text = this.comboBox_0.Text;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_005C;
				}
				IL_0067:
				string directoryName;
				switch (num)
				{
				case 1:
					IL_005C:
					directoryName = Path.GetDirectoryName(text);
					goto IL_0055;
				case 2:
					continue;
				case 3:
					goto IL_0034;
				case 4:
					goto IL_0055;
				case 5:
					goto IL_000F;
				case 6:
					goto IL_0006;
				}
				break;
				IL_0034:
				this.comboBox_0.Text = text;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					break;
				}
				goto IL_0067;
				IL_000F:
				string fileNameWithoutExtension;
				text = Path.Combine(directoryName, fileNameWithoutExtension + Class15.smethod_17(552175098 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
				goto IL_0034;
				IL_0006:
				fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				goto IL_000F;
				IL_0055:
				if (directoryName != null)
				{
					goto IL_0006;
				}
				break;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000101C4 File Offset: 0x0000E3C4
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_007E:
				object[] array = new object[2];
				for (;;)
				{
					IL_005E:
					array[0] = sender;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_0025;
					}
					for (;;)
					{
						IL_0042:
						switch (num)
						{
						case 1:
							goto IL_0025;
						case 2:
							goto IL_005E;
						case 3:
							goto IL_007E;
						case 4:
							Class24.smethod_1(5, array, this);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
							{
								continue;
							}
							break;
						}
						return;
					}
					IL_0025:
					array[1] = e;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_0042;
					}
					return;
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00010264 File Offset: 0x0000E464
		private void method_4(object sender, EventArgs e)
		{
			for (;;)
			{
				base.DialogResult = DialogResult.Cancel;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_0003;
				}
				IL_001A:
				switch (num)
				{
				case 1:
					IL_0003:
					base.Close();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto IL_001A;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000102BC File Offset: 0x0000E4BC
		private void method_5(object sender, EventArgs e)
		{
			for (;;)
			{
				this.comboBox_0.Focus();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
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

		// Token: 0x0600003A RID: 58 RVA: 0x000102F8 File Offset: 0x0000E4F8
		private void method_6(object sender, CancelEventArgs e)
		{
			while (!this.radioButton_2.Checked)
			{
				if (this.radioButton_1.Checked)
				{
					goto IL_0045;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0079;
				}
				IL_0021:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0079:
					AppHelper.AppConfigCenter.OverwriteType = 0;
					return;
				case 2:
					IL_0086:
					AppHelper.AppConfigCenter.OverwriteType = 1;
					break;
				case 3:
					continue;
				case 4:
					break;
				case 5:
					return;
				case 6:
					IL_0045:
					AppHelper.AppConfigCenter.OverwriteType = 2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						return;
					}
					goto IL_0021;
				default:
					return;
				}
				return;
			}
			goto IL_0086;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00010400 File Offset: 0x0000E600
		private void method_7()
		{
			for (;;)
			{
				IL_151B:
				this.tabControl_0 = new TabControl();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_0775;
				}
				for (;;)
				{
					IL_1258:
					switch (num)
					{
					case 1:
						goto IL_0775;
					case 2:
						this.tabPage_0 = new TabPage();
						goto IL_10FA;
					case 3:
						goto IL_151B;
					case 4:
						goto IL_0073;
					case 5:
						goto IL_0CD6;
					case 6:
						this.groupBox_1.TabStop = false;
						num = 73;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
						{
							goto IL_10B9;
						}
						continue;
					case 7:
						goto IL_0545;
					case 8:
						goto IL_0B53;
					case 9:
						goto IL_1105;
					case 10:
						goto IL_04EB;
					case 11:
						goto IL_09FD;
					case 12:
						this.tabPage_0.Controls.Add(this.comboBox_0);
						goto IL_1176;
					case 13:
						goto IL_0E44;
					case 14:
						goto IL_0539;
					case 15:
						goto IL_11E7;
					case 16:
						goto IL_0B73;
					case 17:
						goto IL_0603;
					case 18:
						goto IL_0877;
					case 19:
						goto IL_10A8;
					case 20:
						goto IL_0619;
					case 21:
						goto IL_0F40;
					case 22:
						goto IL_01DD;
					case 23:
						goto IL_0127;
					case 24:
						goto IL_0803;
					case 25:
						goto IL_11C7;
					case 26:
						goto IL_05ED;
					case 27:
						goto IL_06FC;
					case 28:
						goto IL_0C96;
					case 29:
						goto IL_01FD;
					case 30:
						goto IL_0634;
					case 31:
						this.tabPage_0.TabIndex = 0;
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto IL_11C7;
						}
						continue;
					case 32:
						goto IL_101D;
					case 33:
						goto IL_0CF7;
					case 34:
						goto IL_0F6A;
					case 35:
						goto IL_088D;
					case 36:
						goto IL_02A0;
					case 37:
						goto IL_1176;
					case 38:
						goto IL_0F9D;
					case 39:
						goto IL_0851;
					case 40:
						goto IL_0369;
					case 41:
						goto IL_01E9;
					case 42:
						goto IL_0276;
					case 43:
						this.tabPage_0.Controls.Add(this.button_0);
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
						{
							goto Block_14;
						}
						continue;
					case 44:
						return;
					case 45:
						goto IL_0505;
					case 46:
						goto IL_0AD1;
					case 47:
						goto IL_0255;
					case 48:
						goto IL_03E8;
					case 49:
						goto IL_0052;
					case 50:
						goto IL_046C;
					case 51:
						this.oaZzrqUxR.Location = new Point(18, 159);
						goto IL_0B0B;
					case 52:
						goto IL_08D3;
					case 53:
						goto IL_0443;
					case 54:
						goto IL_08FE;
					case 55:
						goto IL_0C42;
					case 56:
						goto IL_086B;
					case 57:
						goto IL_07F6;
					case 58:
						goto IL_0715;
					case 59:
						goto IL_0EF9;
					case 60:
						goto IL_0E1A;
					case 61:
						goto IL_03B7;
					case 62:
						goto IL_0640;
					case 63:
						goto IL_02FD;
					case 64:
						goto IL_0B2B;
					case 65:
						goto IL_00D8;
					case 66:
						goto IL_0661;
					case 67:
						goto IL_10FA;
					case 68:
						goto IL_154C;
					case 69:
						goto IL_043C;
					case 70:
						goto IL_07AA;
					case 71:
						goto IL_0026;
					case 72:
						goto IL_0A56;
					case 73:
						goto IL_0CAA;
					case 74:
						goto IL_0ED8;
					case 75:
						goto IL_019E;
					case 76:
						goto IL_00E3;
					case 77:
						goto IL_060E;
					case 78:
						this.groupBox_0.Size = new Size(206, 58);
						goto IL_1011;
					case 79:
						goto IL_1029;
					case 80:
						goto IL_0A99;
					case 81:
						goto IL_10B9;
					case 82:
						goto IL_1081;
					case 83:
						goto IL_021D;
					case 84:
						goto IL_009F;
					case 85:
						goto IL_0708;
					case 86:
						goto IL_068B;
					case 87:
						goto IL_0329;
					case 88:
						goto IL_04A2;
					case 89:
						goto IL_08C8;
					case 90:
						goto IL_0929;
					case 91:
						this.radioButton_0.TabIndex = 0;
						goto IL_10A8;
					case 92:
						goto IL_0CB6;
					case 93:
						goto IL_0746;
					case 94:
						goto IL_0E58;
					case 95:
						goto IL_1541;
					case 96:
						goto IL_0D20;
					case 97:
						goto IL_041A;
					case 98:
						goto IL_0409;
					case 99:
						goto IL_0249;
					case 100:
						goto IL_0A62;
					case 101:
						goto IL_02B4;
					case 102:
						goto IL_04B6;
					case 103:
						goto IL_0DAC;
					case 104:
						goto IL_0D76;
					case 105:
						goto IL_0C18;
					case 106:
						goto IL_00EF;
					case 107:
						this.tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
						num = 73;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_1081;
						}
						continue;
					case 108:
						this.radioButton_1.TabIndex = 2;
						goto IL_0D20;
					case 109:
						goto IL_0BDF;
					case 110:
						goto IL_03CC;
					case 111:
						goto IL_0D55;
					case 112:
						goto IL_0974;
					case 113:
						goto IL_07EA;
					case 114:
						goto IL_0BB5;
					case 115:
						goto IL_1011;
					case 116:
						goto IL_05F8;
					case 117:
						goto IL_03F4;
					case 118:
						goto IL_0FAE;
					case 119:
						goto IL_0309;
					case 120:
						goto IL_0F7D;
					case 121:
						goto IL_012E;
					case 122:
						goto IL_02D4;
					case 123:
						goto IL_0B89;
					case 124:
						goto IL_0525;
					case 125:
						goto IL_0FE2;
					case 126:
						goto IL_033F;
					case 127:
						goto IL_07BE;
					case 128:
						goto IL_0934;
					case 129:
						goto IL_0AC5;
					case 130:
						goto IL_08DE;
					case 131:
						goto IL_07CA;
					case 132:
						goto IL_06DC;
					case 133:
						goto IL_0D82;
					case 134:
						goto IL_00FA;
					case 135:
						goto IL_080F;
					case 136:
						goto IL_0F2A;
					case 137:
						goto IL_0161;
					case 138:
						this.radioButton_2.UseVisualStyleBackColor = true;
						num = 39;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_0ED8;
						}
						continue;
					case 139:
						this.tabControl_0.Name = Class15.smethod_17(1743168778 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
						goto IL_0845;
					case 140:
						this.radioButton_3.Checked = true;
						goto IL_0E1A;
					case 141:
						goto IL_05B4;
					case 142:
						goto IL_0DC0;
					case 143:
						goto IL_0B9F;
					case 144:
						goto IL_0DF5;
					case 145:
						this.button_0.Name = Class15.smethod_17(82301748 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909);
						goto IL_0C96;
					case 146:
						goto IL_0A6F;
					case 147:
						this.radioButton_3.TabIndex = 0;
						goto IL_0BFB;
					case 148:
						goto IL_0C0C;
					case 149:
						goto IL_0954;
					case 150:
						goto IL_037D;
					case 151:
						goto IL_09D3;
					case 152:
						goto IL_0478;
					case 153:
						goto IL_0BFB;
					case 154:
						this.label_1.TabIndex = 4;
						goto IL_0B53;
					case 155:
						goto IL_0B0B;
					case 156:
						goto IL_0A11;
					case 157:
						goto IL_0A36;
					case 158:
						goto IL_09B2;
					case 159:
						goto IL_091E;
					case 160:
						goto IL_0984;
					case 161:
						goto IL_08BD;
					case 162:
						goto IL_0149;
					case 163:
						goto IL_0845;
					case 164:
						goto IL_06A7;
					case 165:
						goto IL_0191;
					case 166:
						goto IL_042B;
					case 167:
						goto IL_05E2;
					case 168:
						goto IL_057F;
					case 169:
						goto IL_0460;
					case 170:
						goto IL_015A;
					case 171:
						base.ShowInTaskbar = false;
						goto IL_0127;
					case 172:
						goto IL_00CC;
					case 173:
						goto IL_0006;
					}
					goto Block_18;
					IL_0026:
					this.groupBox_1.Size = new Size(218, 104);
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0052;
					}
					continue;
					IL_0006:
					this.groupBox_1.Name = Class15.smethod_17(1042091477 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
					goto IL_0026;
					IL_0BDF:
					this.groupBox_1.Location = new Point(247, 75);
					goto IL_0006;
					IL_0BB5:
					this.groupBox_1.Font = new Font(Class15.smethod_17(594365582 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b), 9f);
					goto IL_0BDF;
					IL_0B9F:
					this.groupBox_1.Controls.Add(this.radioButton_3);
					goto IL_0BB5;
					IL_0B89:
					this.groupBox_1.Controls.Add(this.radioButton_2);
					goto IL_0B9F;
					IL_0B73:
					this.groupBox_1.Controls.Add(this.radioButton_1);
					goto IL_0B89;
					IL_0B53:
					this.label_1.Text = Class15.smethod_17(1760312223 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_0B73;
					IL_0052:
					this.groupBox_1.TabIndex = 3;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						continue;
					}
					IL_0073:
					this.radioButton_1.Size = new Size(137, 16);
					num = 108;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						goto IL_009F;
					}
					continue;
					IL_0A11:
					this.radioButton_1.Name = Class15.smethod_17(1985311308 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
					goto IL_0073;
					IL_09FD:
					this.radioButton_1.Location = new Point(24, 73);
					goto IL_0A11;
					IL_09D3:
					this.radioButton_1.Font = new Font(Class15.smethod_17(613121301 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), 9f);
					goto IL_09FD;
					IL_009F:
					this.tabPage_0.Controls.Add(this.groupBox_1);
					num = 43;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						goto IL_0073;
					}
					continue;
					IL_00FA:
					this.groupBox_0.ResumeLayout(false);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
					{
						goto Block_2;
					}
					continue;
					IL_00EF:
					this.groupBox_1.PerformLayout();
					goto IL_00FA;
					IL_00E3:
					this.groupBox_1.ResumeLayout(false);
					goto IL_00EF;
					IL_00D8:
					this.tabPage_0.PerformLayout();
					goto IL_00E3;
					IL_00CC:
					this.tabPage_0.ResumeLayout(false);
					goto IL_00D8;
					IL_0149:
					this.tabControl_0.ResumeLayout(false);
					goto IL_00CC;
					IL_012E:
					this.Text = Class15.smethod_17(768783584 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
					goto IL_0149;
					IL_0127:
					base.StartPosition = FormStartPosition.CenterScreen;
					goto IL_012E;
					IL_04B6:
					this.radioButton_0.Name = Class15.smethod_17(1396559826 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
					num = 59;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_04EB;
					}
					continue;
					IL_04A2:
					this.radioButton_0.Location = new Point(16, 29);
					goto IL_04B6;
					IL_0478:
					this.radioButton_0.Font = new Font(Class15.smethod_17(197587437 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), 9f);
					goto IL_04A2;
					IL_046C:
					this.radioButton_0.Checked = true;
					goto IL_0478;
					IL_0460:
					this.radioButton_0.AutoSize = true;
					goto IL_046C;
					IL_1029:
					this.groupBox_0.Text = Class15.smethod_17(432125477 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
					goto IL_0460;
					IL_101D:
					this.groupBox_0.TabStop = false;
					goto IL_1029;
					IL_1011:
					this.groupBox_0.TabIndex = 2;
					goto IL_101D;
					IL_057F:
					this.label_1.Name = Class15.smethod_17(2008551071 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					num = 139;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_05B4;
					}
					continue;
					IL_068B:
					this.label_1.Location = new Point(16, 141);
					goto IL_057F;
					IL_0661:
					this.label_1.Font = new Font(Class15.smethod_17(1678096732 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a), 9f);
					goto IL_068B;
					IL_05B4:
					this.label_1.Size = new Size(71, 12);
					num = 154;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto Block_5;
					}
					continue;
					IL_0619:
					base.SuspendLayout();
					num = 107;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0634;
					}
					continue;
					IL_060E:
					this.groupBox_0.SuspendLayout();
					goto IL_0619;
					IL_0603:
					this.groupBox_1.SuspendLayout();
					goto IL_060E;
					IL_05F8:
					this.tabPage_0.SuspendLayout();
					goto IL_0603;
					IL_05ED:
					this.tabControl_0.SuspendLayout();
					goto IL_05F8;
					IL_05E2:
					this.button_2 = new Button();
					goto IL_05ED;
					IL_0974:
					this.button_1 = new Button();
					goto IL_05E2;
					IL_0640:
					this.label_1.AutoSize = true;
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_0661;
					}
					continue;
					IL_0634:
					this.oaZzrqUxR.TabIndex = 5;
					goto IL_0640;
					IL_0B2B:
					this.oaZzrqUxR.Size = new Size(206, 20);
					goto IL_0634;
					IL_0B0B:
					this.oaZzrqUxR.Name = Class15.smethod_17(635811301 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_0B2B;
					IL_06A7:
					this.radioButton_0.Tag = Class15.smethod_17(2048538027 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					num = 102;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_06DC;
					}
					continue;
					IL_10A8:
					this.radioButton_0.TabStop = true;
					goto IL_06A7;
					IL_0746:
					this.button_1.Location = new Point(310, 251);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						goto IL_0775;
					}
					continue;
					IL_0715:
					this.button_1.Font = new Font(Class15.smethod_17(299952633 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_0746;
					IL_0708:
					this.button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					goto IL_0715;
					IL_06FC:
					this.radioButton_0.UseVisualStyleBackColor = true;
					goto IL_0708;
					IL_06DC:
					this.radioButton_0.Text = Class15.smethod_17(1743169322 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
					goto IL_06FC;
					IL_088D:
					this.tabPage_0.Controls.Add(this.label_1);
					num = 84;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						break;
					}
					continue;
					IL_0877:
					this.tabPage_0.Controls.Add(this.oaZzrqUxR);
					goto IL_088D;
					IL_086B:
					this.tabControl_0.TabIndex = 2;
					goto IL_0877;
					IL_0851:
					this.tabControl_0.Size = new Size(494, 226);
					goto IL_086B;
					IL_0845:
					this.tabControl_0.SelectedIndex = 0;
					goto IL_0851;
					IL_08DE:
					this.radioButton_3 = new RadioButton();
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_08FE;
					}
					continue;
					IL_08D3:
					this.radioButton_2 = new RadioButton();
					goto IL_08DE;
					IL_08C8:
					this.radioButton_1 = new RadioButton();
					goto IL_08D3;
					IL_08BD:
					this.groupBox_1 = new GroupBox();
					goto IL_08C8;
					IL_08FE:
					this.button_0 = new Button();
					num = 154;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						goto IL_091E;
					}
					continue;
					IL_0934:
					this.groupBox_0 = new GroupBox();
					num = 59;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_0954;
					}
					continue;
					IL_0929:
					this.label_0 = new Label();
					goto IL_0934;
					IL_091E:
					this.comboBox_0 = new ComboBox();
					goto IL_0929;
					IL_0954:
					this.radioButton_0 = new RadioButton();
					num = 96;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_0974;
					}
					continue;
					IL_0984:
					this.tabControl_0.Location = new Point(12, 12);
					num = 139;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_05ED;
					}
					continue;
					IL_0FE2:
					this.tabControl_0.Font = new Font(Class15.smethod_17(1807889656 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), 9f);
					goto IL_0984;
					IL_1081:
					this.tabControl_0.Controls.Add(this.tabPage_0);
					goto IL_0FE2;
					IL_09B2:
					this.radioButton_1.AutoSize = true;
					num = 93;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_09D3;
					}
					continue;
					IL_10B9:
					this.groupBox_1.Text = Class15.smethod_17(1743168578 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
					goto IL_09B2;
					IL_0A99:
					this.button_0.Location = new Point(390, 14);
					num = 145;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						goto IL_0AC5;
					}
					continue;
					IL_0A6F:
					this.button_0.Font = new Font(Class15.smethod_17(197587437 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), 9f);
					goto IL_0A99;
					IL_0A62:
					this.button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
					goto IL_0A6F;
					IL_0A56:
					this.radioButton_3.UseVisualStyleBackColor = true;
					goto IL_0A62;
					IL_0A36:
					this.radioButton_3.Text = Class15.smethod_17(1953682503 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
					goto IL_0A56;
					IL_0BFB:
					this.radioButton_3.TabStop = true;
					goto IL_0A36;
					IL_0AD1:
					this.radioButton_2.Text = Class15.smethod_17(486530562 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c);
					num = 138;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_04B6;
					}
					continue;
					IL_0AC5:
					this.radioButton_2.TabIndex = 1;
					goto IL_0AD1;
					IL_0DF5:
					this.radioButton_2.Size = new Size(101, 16);
					goto IL_0AC5;
					IL_0C42:
					this.oaZzrqUxR.FormattingEnabled = true;
					num = 51;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_0052;
					}
					continue;
					IL_0C18:
					this.oaZzrqUxR.Font = new Font(Class15.smethod_17(649958896 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff), 9f);
					goto IL_0C42;
					IL_0C0C:
					this.oaZzrqUxR.DropDownStyle = ComboBoxStyle.DropDownList;
					goto IL_0C18;
					IL_0CD6:
					this.button_0.UseVisualStyleBackColor = true;
					num = 165;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						goto IL_0CF7;
					}
					continue;
					IL_0CB6:
					this.button_0.Text = Class15.smethod_17(1985311380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
					goto IL_0CD6;
					IL_0CAA:
					this.button_0.TabIndex = 1;
					goto IL_0CB6;
					IL_0C96:
					this.button_0.Size = new Size(75, 26);
					goto IL_0CAA;
					IL_0CF7:
					this.radioButton_3.Size = new Size(101, 16);
					num = 147;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						continue;
					}
					IL_0D20:
					this.radioButton_1.Text = Class15.smethod_17(552174840 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						continue;
					}
					IL_0D55:
					this.radioButton_1.UseVisualStyleBackColor = true;
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_0D76;
					}
					continue;
					IL_0DC0:
					this.radioButton_2.Name = Class15.smethod_17(538805583 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
					num = 96;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_0DF5;
					}
					continue;
					IL_0DAC:
					this.radioButton_2.Location = new Point(24, 51);
					goto IL_0DC0;
					IL_0D82:
					this.radioButton_2.Font = new Font(Class15.smethod_17(926377407 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), 9f);
					goto IL_0DAC;
					IL_0D76:
					this.radioButton_2.AutoSize = true;
					goto IL_0D82;
					IL_0E58:
					this.radioButton_3.Name = Class15.smethod_17(1788753223 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_05ED;
					}
					continue;
					IL_0E44:
					this.radioButton_3.Location = new Point(24, 29);
					goto IL_0E58;
					IL_0E1A:
					this.radioButton_3.Font = new Font(Class15.smethod_17(642133186 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), 9f);
					goto IL_0E44;
					IL_0ED8:
					this.radioButton_3.AutoSize = true;
					num = 140;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						continue;
					}
					IL_0EF9:
					this.radioButton_0.Size = new Size(143, 16);
					num = 91;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto IL_0AD1;
					}
					continue;
					IL_0FAE:
					this.tabPage_0.Size = new Size(486, 200);
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto Block_12;
					}
					continue;
					IL_0F9D:
					this.tabPage_0.Padding = new Padding(3);
					goto IL_0FAE;
					IL_0F7D:
					this.tabPage_0.Name = Class15.smethod_17(1116167421 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
					goto IL_0F9D;
					IL_0F6A:
					this.tabPage_0.Location = new Point(4, 22);
					goto IL_0F7D;
					IL_0F40:
					this.tabPage_0.Font = new Font(Class15.smethod_17(82301622 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), 9f);
					goto IL_0F6A;
					IL_0F2A:
					this.tabPage_0.Controls.Add(this.groupBox_0);
					goto IL_0F40;
					IL_1105:
					this.label_1 = new Label();
					num = 65;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_08BD;
					}
					continue;
					IL_10FA:
					this.oaZzrqUxR = new ComboBox();
					goto IL_1105;
					IL_1176:
					this.tabPage_0.Controls.Add(this.label_0);
					num = 41;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_0F2A;
					}
					continue;
					IL_11E7:
					this.tabPage_0.UseVisualStyleBackColor = true;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						goto IL_0C0C;
					}
					continue;
					IL_11C7:
					this.tabPage_0.Text = Class15.smethod_17(649958862 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
					goto IL_11E7;
				}
				goto IL_01DD;
				Block_5:
				goto IL_03CC;
				Block_18:
				goto IL_044F;
				Block_12:
				goto IL_0545;
				Block_14:
				goto IL_0775;
				IL_0161:
				base.Name = Class15.smethod_17(649959286 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
				num = 171;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_0191;
				}
				goto IL_1258;
				IL_015A:
				base.MinimizeBox = false;
				goto IL_0161;
				IL_0443:
				base.MaximizeBox = false;
				goto IL_015A;
				IL_043C:
				base.FormBorderStyle = FormBorderStyle.FixedSingle;
				goto IL_0443;
				IL_042B:
				base.Controls.Add(this.tabControl_0);
				goto IL_043C;
				IL_041A:
				base.Controls.Add(this.button_1);
				goto IL_042B;
				IL_0409:
				base.Controls.Add(this.button_2);
				goto IL_041A;
				IL_03F4:
				base.ClientSize = new Size(518, 289);
				goto IL_0409;
				IL_03E8:
				base.CancelButton = this.button_2;
				goto IL_03F4;
				IL_019E:
				this.comboBox_0.Font = new Font(Class15.smethod_17(486530870 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), 9f);
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_01DD;
				}
				goto IL_1258;
				IL_0191:
				this.comboBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
				goto IL_019E;
				IL_021D:
				this.comboBox_0.Size = new Size(447, 20);
				num = 87;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_0249;
				}
				goto IL_1258;
				IL_01FD:
				this.comboBox_0.Name = Class15.smethod_17(2071397318 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
				goto IL_021D;
				IL_01E9:
				this.comboBox_0.Location = new Point(18, 46);
				goto IL_01FD;
				IL_01DD:
				this.comboBox_0.FormattingEnabled = true;
				goto IL_01E9;
				IL_0255:
				this.label_0.AutoSize = true;
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_0276;
				}
				goto IL_1258;
				IL_0249:
				this.comboBox_0.TabIndex = 0;
				goto IL_0255;
				IL_02D4:
				this.label_0.Size = new Size(95, 12);
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
				{
					goto IL_02FD;
				}
				goto IL_1258;
				IL_02B4:
				this.label_0.Name = Class15.smethod_17(1243251010 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
				goto IL_02D4;
				IL_02A0:
				this.label_0.Location = new Point(16, 21);
				goto IL_02B4;
				IL_0276:
				this.label_0.Font = new Font(Class15.smethod_17(538805315 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), 9f);
				goto IL_02A0;
				IL_037D:
				this.groupBox_0.Name = Class15.smethod_17(1471365037 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e);
				num = 78;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					goto IL_044F;
				}
				goto IL_1258;
				IL_0369:
				this.groupBox_0.Location = new Point(18, 75);
				goto IL_037D;
				IL_033F:
				this.groupBox_0.Font = new Font(Class15.smethod_17(1471364555 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e), 9f);
				goto IL_0369;
				IL_0329:
				this.groupBox_0.Controls.Add(this.radioButton_0);
				goto IL_033F;
				IL_0309:
				this.label_0.Text = Class15.smethod_17(1387466408 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
				goto IL_0329;
				IL_02FD:
				this.label_0.TabIndex = 6;
				goto IL_0309;
				IL_03CC:
				base.AutoScaleMode = AutoScaleMode.Font;
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					goto IL_03E8;
				}
				goto IL_1258;
				IL_03B7:
				base.AutoScaleDimensions = new SizeF(6f, 12f);
				goto IL_03CC;
				IL_044F:
				this.button_2.UseVisualStyleBackColor = true;
				goto IL_03B7;
				IL_0545:
				this.button_2.Text = Class15.smethod_17(974448601 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_044F;
				}
				goto IL_1258;
				IL_0539:
				this.button_2.TabIndex = 1;
				goto IL_0545;
				IL_0525:
				this.button_2.Size = new Size(90, 26);
				goto IL_0539;
				IL_0505:
				this.button_2.Name = Class15.smethod_17(552175464 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
				goto IL_0525;
				IL_04EB:
				this.button_2.Location = new Point(416, 251);
				goto IL_0505;
				IL_080F:
				this.button_2.Font = new Font(Class15.smethod_17(1396559628 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
				goto IL_04EB;
				IL_0803:
				this.button_2.DialogResult = DialogResult.Cancel;
				goto IL_080F;
				IL_07F6:
				this.button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
				goto IL_0803;
				IL_07EA:
				this.button_1.UseVisualStyleBackColor = true;
				goto IL_07F6;
				IL_07CA:
				this.button_1.Text = Class15.smethod_17(2021173180 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
				goto IL_07EA;
				IL_07BE:
				this.button_1.TabIndex = 0;
				goto IL_07CA;
				IL_07AA:
				this.button_1.Size = new Size(90, 26);
				goto IL_07BE;
				IL_0775:
				this.button_1.Name = Class15.smethod_17(1570983245 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_07AA;
				}
				goto IL_1258;
			}
			Block_2:
			IL_1541:
			this.groupBox_0.PerformLayout();
			IL_154C:
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private string string_0 = string.Empty;

		// Token: 0x04000014 RID: 20
		private readonly List<string> list_0 = new List<string>();

		// Token: 0x04000015 RID: 21
		private readonly List<ItemFilter> list_1 = new List<ItemFilter>();

		// Token: 0x04000017 RID: 23
		private TabControl tabControl_0;

		// Token: 0x04000018 RID: 24
		private TabPage tabPage_0;

		// Token: 0x04000019 RID: 25
		private Button button_0;

		// Token: 0x0400001A RID: 26
		private ComboBox comboBox_0;

		// Token: 0x0400001B RID: 27
		private Label label_0;

		// Token: 0x0400001C RID: 28
		private GroupBox groupBox_0;

		// Token: 0x0400001D RID: 29
		private RadioButton radioButton_0;

		// Token: 0x0400001E RID: 30
		private GroupBox groupBox_1;

		// Token: 0x0400001F RID: 31
		private RadioButton radioButton_1;

		// Token: 0x04000020 RID: 32
		private RadioButton radioButton_2;

		// Token: 0x04000021 RID: 33
		private RadioButton radioButton_3;

		// Token: 0x04000022 RID: 34
		private Button button_1;

		// Token: 0x04000023 RID: 35
		private Button button_2;

		// Token: 0x04000024 RID: 36
		private ComboBox oaZzrqUxR;

		// Token: 0x04000025 RID: 37
		private Label label_1;
	}
}
