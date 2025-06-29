using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WinASAR.Common.Helpers;
using WinASAR.WinForm.Properties;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x02000005 RID: 5
	public partial class AboutForm : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public AboutForm(string productName = "WinASAR 文件管理工具")
		{
			for (;;)
			{
				IL_0055:
				this.method_5();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_003D;
				}
				do
				{
					IL_0022:
					this.InitializeData(productName);
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0);
				for (;;)
				{
					IL_003D:
					switch (num)
					{
					case 1:
						this.InitializeEvent();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0055;
					case 3:
						return;
					}
					break;
				}
				goto IL_0022;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000EE10 File Offset: 0x0000D010
		public void InitializeData(string productName)
		{
			for (;;)
			{
				object[] array = new object[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_0025;
				}
				IL_0033:
				switch (num)
				{
				case 0:
					goto IL_0025;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_0025;
				}
				IL_0003:
				Class24.smethod_1(0, array, this);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					break;
				}
				goto IL_0033;
				IL_0025:
				array[0] = productName;
				goto IL_0003;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000EE8C File Offset: 0x0000D08C
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
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
				Class24.smethod_1(1, array, this);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000EEF0 File Offset: 0x0000D0F0
		private static Version smethod_0()
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[0];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0003;
				}
				IL_0023:
				switch (num)
				{
				case 1:
					IL_0003:
					array2 = Class24.smethod_1(2, array, null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						goto IL_0023;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			return (Version)array2[0];
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000EF60 File Offset: 0x0000D160
		private void method_0(object sender, EventArgs e)
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
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

		// Token: 0x06000028 RID: 40 RVA: 0x0000EF98 File Offset: 0x0000D198
		private void method_1(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(926376171 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
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

		// Token: 0x06000029 RID: 41 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		private void method_2(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(277642644 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
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

		// Token: 0x0600002A RID: 42 RVA: 0x0000F030 File Offset: 0x0000D230
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(2128226152 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
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

		// Token: 0x0600002B RID: 43 RVA: 0x0000F07C File Offset: 0x0000D27C
		private void method_4(object sender, EventArgs e)
		{
			for (;;)
			{
				FileHelper.Start(Class15.smethod_17(299953825 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
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

		// Token: 0x0600002D RID: 45 RVA: 0x0000F144 File Offset: 0x0000D344
		private void method_5()
		{
			for (;;)
			{
				IL_0D43:
				this.button_0 = new Button();
				for (;;)
				{
					IL_0D36:
					this.button_1 = new Button();
					for (;;)
					{
						IL_0D29:
						this.button_2 = new Button();
						for (;;)
						{
							IL_0D04:
							this.aStDuroYc = new Label();
							int num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
							{
								goto IL_0AF4;
							}
							for (;;)
							{
								IL_0B29:
								switch (num)
								{
								case 1:
									return;
								case 2:
									goto IL_01C6;
								case 3:
									goto IL_0D04;
								case 4:
									goto IL_00DF;
								case 5:
									goto IL_0AD6;
								case 6:
									goto IL_0167;
								case 7:
									goto IL_0097;
								case 8:
									goto IL_0272;
								case 9:
									goto IL_0741;
								case 10:
									goto IL_017C;
								case 11:
									goto IL_03C6;
								case 12:
									goto IL_012C;
								case 13:
									goto IL_018F;
								case 14:
									goto IL_07BF;
								case 15:
									goto IL_0989;
								case 16:
									goto IL_0AF4;
								case 17:
									goto IL_04AD;
								case 18:
									goto IL_08C8;
								case 19:
									goto IL_0863;
								case 20:
									goto IL_01D7;
								case 21:
									goto IL_0326;
								case 22:
									goto IL_03F7;
								case 23:
									goto IL_004F;
								case 24:
									goto IL_05BF;
								case 25:
									this.button_0.Text = Class15.smethod_17(635810683 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
									goto IL_0A30;
								case 26:
									goto IL_0A4D;
								case 27:
									this.button_0.Size = new Size(102, 23);
									num = 3;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
									{
										goto IL_0AD6;
									}
									continue;
								case 28:
									((ISupportInitialize)this.pictureBox_0).EndInit();
									goto IL_0982;
								case 29:
									goto IL_00ED;
								case 30:
									goto IL_08FD;
								case 31:
									goto IL_0810;
								case 32:
									goto IL_01A4;
								case 33:
									goto IL_07E0;
								case 34:
									goto IL_04D0;
								case 35:
									this.pictureBox_1.Size = new Size(60, 58);
									goto IL_05CF;
								case 36:
									goto IL_00E6;
								case 37:
									goto IL_040B;
								case 38:
									goto IL_0251;
								case 39:
									goto IL_0D36;
								case 40:
									goto IL_0D43;
								case 41:
									goto IL_083B;
								case 42:
									goto IL_0458;
								case 43:
									goto IL_05EC;
								case 44:
									goto IL_081B;
								case 45:
									goto IL_0917;
								case 46:
									goto IL_057E;
								case 47:
									this.linkLabel_1.TabStop = true;
									goto IL_0A4D;
								case 48:
									goto IL_059F;
								case 49:
									goto IL_0774;
								case 50:
									goto IL_01E8;
								case 51:
									goto IL_0437;
								case 52:
									goto IL_0A30;
								case 53:
									goto IL_0689;
								case 54:
									goto IL_0109;
								case 55:
									goto IL_02DC;
								case 56:
									this.linkLabel_1.Location = new Point(326, 154);
									goto IL_08A8;
								case 57:
									goto IL_0086;
								case 58:
									goto IL_04C4;
								case 59:
									goto IL_09FC;
								case 60:
									goto IL_0652;
								case 61:
									goto IL_0672;
								case 62:
									goto IL_0873;
								case 63:
									goto IL_00CE;
								case 64:
									goto IL_06A1;
								case 65:
									this.label_1.Text = Class15.smethod_17(642132824 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
									num = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
									{
										goto Block_9;
									}
									continue;
								case 66:
									goto IL_035B;
								case 67:
									goto IL_095C;
								case 68:
									goto IL_08ED;
								case 69:
									goto IL_048D;
								case 70:
									goto IL_0D29;
								case 71:
									this.pictureBox_0.Location = new Point(12, 12);
									goto IL_0652;
								case 72:
									goto IL_0982;
								case 73:
									goto IL_003B;
								case 74:
									this.label_0.Text = Class15.smethod_17(1678097946 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
									goto IL_095C;
								case 75:
									goto IL_0209;
								case 76:
									goto IL_078B;
								case 77:
									goto IL_08E1;
								case 78:
									goto IL_0286;
								case 79:
									goto IL_034F;
								case 80:
									goto IL_02AC;
								case 81:
									goto IL_08A8;
								case 82:
									goto IL_0301;
								case 83:
									goto IL_088F;
								case 84:
									this.linkLabel_0.LinkBehavior = LinkBehavior.NeverUnderline;
									goto IL_0863;
								case 85:
									goto IL_05F9;
								case 86:
									goto IL_0572;
								case 87:
									goto IL_0417;
								case 88:
									goto IL_0805;
								case 89:
									goto IL_07AB;
								case 90:
									goto IL_0183;
								case 91:
									goto IL_00A8;
								case 92:
									goto IL_0464;
								case 93:
									goto IL_0695;
								case 94:
									goto IL_0075;
								case 95:
									goto IL_037C;
								case 96:
									goto IL_0767;
								case 97:
									this.pictureBox_1.Name = Class15.smethod_17(1793856396 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
									num = 35;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
									{
										goto IL_0741;
									}
									continue;
								case 98:
									goto IL_06D2;
								case 99:
									goto IL_06B2;
								case 100:
									goto IL_0631;
								case 101:
									this.label_0.Location = new Point(80, 154);
									goto IL_0006;
								case 102:
									goto IL_05E0;
								case 103:
									goto IL_05CF;
								case 104:
									goto IL_04F0;
								case 105:
									goto IL_0244;
								case 106:
									goto IL_0550;
								case 107:
									goto IL_02CC;
								case 108:
									goto IL_0147;
								case 109:
									goto IL_03A1;
								case 110:
									goto IL_0516;
								case 111:
									goto IL_03D7;
								case 112:
									goto IL_01B5;
								case 113:
									goto IL_0229;
								case 114:
									goto IL_01FE;
								case 115:
									goto IL_0006;
								}
								goto Block_11;
								IL_0006:
								this.label_0.Name = Class15.smethod_17(2060611386 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
								num = 15;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
								{
									goto IL_003B;
								}
								continue;
								IL_004F:
								this.label_0.TabIndex = 5;
								num = 74;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
								{
									goto Block_1;
								}
								continue;
								IL_003B:
								this.label_0.Size = new Size(125, 12);
								goto IL_004F;
								IL_0209:
								((ISupportInitialize)this.pictureBox_0).BeginInit();
								num = 63;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
								{
									goto IL_0229;
								}
								continue;
								IL_01FE:
								((ISupportInitialize)this.pictureBox_1).BeginInit();
								goto IL_0209;
								IL_05BF:
								this.label_1 = new Label();
								goto IL_01FE;
								IL_0229:
								base.SuspendLayout();
								num = 38;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
								{
									goto IL_0244;
								}
								continue;
								IL_0251:
								this.button_0.DialogResult = DialogResult.Cancel;
								num = 41;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
								{
									goto IL_0272;
								}
								continue;
								IL_0244:
								this.button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
								goto IL_0251;
								IL_0286:
								this.linkLabel_0.TabIndex = 4;
								num = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
								{
									goto IL_03C6;
								}
								continue;
								IL_0272:
								this.linkLabel_0.Size = new Size(95, 12);
								goto IL_0286;
								IL_02DC:
								this.pictureBox_1.BackColor = Color.Transparent;
								num = 61;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
								{
									goto IL_0301;
								}
								continue;
								IL_02CC:
								this.linkLabel_0.VisitedLinkColor = SystemColors.ControlText;
								goto IL_02DC;
								IL_02AC:
								this.linkLabel_0.Text = Class15.smethod_17(538805079 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
								goto IL_02CC;
								IL_03C6:
								this.linkLabel_0.TabStop = true;
								goto IL_02AC;
								IL_0301:
								this.pictureBox_1.Image = Resources.AppIcon;
								num = 21;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
								{
									continue;
								}
								IL_0326:
								this.pictureBox_1.Location = new Point(12, 108);
								num = 97;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
								{
									goto IL_034F;
								}
								continue;
								IL_035B:
								this.pictureBox_1.TabStop = false;
								num = 48;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
								{
									goto IL_037C;
								}
								continue;
								IL_034F:
								this.pictureBox_1.TabIndex = 4;
								goto IL_035B;
								IL_05CF:
								this.pictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage;
								goto IL_034F;
								IL_037C:
								this.pictureBox_0.BackColor = Color.Transparent;
								num = 79;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
								{
									continue;
								}
								IL_03A1:
								this.pictureBox_0.Image = Resources.Background;
								num = 71;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
								{
									goto IL_03C6;
								}
								continue;
								IL_0437:
								this.button_2.UseVisualStyleBackColor = true;
								num = 13;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
								{
									goto IL_0458;
								}
								continue;
								IL_0417:
								this.button_2.Text = Class15.smethod_17(1788752561 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c);
								goto IL_0437;
								IL_040B:
								this.button_2.TabIndex = 2;
								goto IL_0417;
								IL_03F7:
								this.button_2.Size = new Size(102, 23);
								goto IL_040B;
								IL_03D7:
								this.button_2.Name = Class15.smethod_17(1116166851 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
								goto IL_03F7;
								IL_05F9:
								this.button_2.Location = new Point(304, 70);
								goto IL_03D7;
								IL_05EC:
								this.button_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
								goto IL_05F9;
								IL_05E0:
								this.button_1.UseVisualStyleBackColor = true;
								goto IL_05EC;
								IL_07E0:
								this.button_1.Text = Class15.smethod_17(432124503 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
								goto IL_05E0;
								IL_0464:
								this.aStDuroYc.Location = new Point(80, 108);
								num = 5;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
								{
									goto IL_048D;
								}
								continue;
								IL_0458:
								this.aStDuroYc.AutoSize = true;
								goto IL_0464;
								IL_04F0:
								this.label_0.AutoSize = true;
								num = 101;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
								{
									goto IL_004F;
								}
								continue;
								IL_04D0:
								this.aStDuroYc.Text = Class15.smethod_17(1953682267 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f);
								goto IL_04F0;
								IL_04C4:
								this.aStDuroYc.TabIndex = 3;
								goto IL_04D0;
								IL_04AD:
								this.aStDuroYc.Size = new Size(185, 12);
								goto IL_04C4;
								IL_048D:
								this.aStDuroYc.Name = Class15.smethod_17(1176454202 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
								goto IL_04AD;
								IL_0516:
								this.linkLabel_0.Name = Class15.smethod_17(1396558512 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
								num = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
								{
									goto IL_0272;
								}
								continue;
								IL_0873:
								this.linkLabel_0.Location = new Point(80, 131);
								goto IL_0516;
								IL_0863:
								this.linkLabel_0.LinkColor = SystemColors.ControlText;
								goto IL_0873;
								IL_0550:
								this.linkLabel_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
								num = 36;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
								{
									goto IL_0572;
								}
								continue;
								IL_06A1:
								this.pictureBox_0.TabStop = false;
								goto IL_0550;
								IL_0695:
								this.pictureBox_0.TabIndex = 0;
								goto IL_06A1;
								IL_0689:
								this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
								goto IL_0695;
								IL_0672:
								this.pictureBox_0.Size = new Size(278, 81);
								goto IL_0689;
								IL_0652:
								this.pictureBox_0.Name = Class15.smethod_17(89037458 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
								goto IL_0672;
								IL_057E:
								this.linkLabel_1.LinkBehavior = LinkBehavior.HoverUnderline;
								num = 56;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
								{
									goto IL_059F;
								}
								continue;
								IL_0572:
								this.linkLabel_1.AutoSize = true;
								goto IL_057E;
								IL_059F:
								this.linkLabel_1 = new LinkLabel();
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
								{
									goto IL_05BF;
								}
								continue;
								IL_0631:
								this.label_1.TabIndex = 6;
								num = 65;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
								{
									goto IL_0652;
								}
								continue;
								IL_088F:
								this.label_1.Size = new Size(59, 12);
								goto IL_0631;
								IL_0917:
								this.label_1.Name = Class15.smethod_17(2128225586 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
								goto IL_088F;
								IL_08FD:
								this.label_1.Location = new Point(324, 134);
								goto IL_0917;
								IL_08ED:
								this.label_1.ForeColor = Color.Blue;
								goto IL_08FD;
								IL_08E1:
								this.label_1.AutoSize = true;
								goto IL_08ED;
								IL_09FC:
								this.linkLabel_1.VisitedLinkColor = Color.Blue;
								goto IL_08E1;
								IL_0741:
								this.linkLabel_1.TabIndex = 7;
								num = 47;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
								{
									goto IL_057E;
								}
								continue;
								IL_08C8:
								this.linkLabel_1.Size = new Size(53, 12);
								goto IL_0741;
								IL_08A8:
								this.linkLabel_1.Name = Class15.smethod_17(1603810528 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
								goto IL_08C8;
								IL_07BF:
								this.button_1.TabIndex = 1;
								num = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
								{
									goto IL_07E0;
								}
								continue;
								IL_07AB:
								this.button_1.Size = new Size(102, 23);
								goto IL_07BF;
								IL_078B:
								this.button_1.Name = Class15.smethod_17(1793856200 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
								goto IL_07AB;
								IL_0774:
								this.button_1.Location = new Point(304, 41);
								goto IL_078B;
								IL_0767:
								this.button_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
								goto IL_0774;
								IL_0A30:
								this.button_0.UseVisualStyleBackColor = true;
								goto IL_0767;
								IL_095C:
								this.linkLabel_0.AutoSize = true;
								num = 84;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
								{
									break;
								}
								continue;
								IL_0989:
								base.PerformLayout();
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
								{
									return;
								}
								continue;
								IL_0982:
								base.ResumeLayout(false);
								goto IL_0989;
								IL_0A4D:
								this.linkLabel_1.Text = Class15.smethod_17(699003462 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
								num = 59;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
								{
									goto IL_09FC;
								}
								continue;
								IL_0AD6:
								this.button_0.TabIndex = 0;
								num = 25;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
								{
									goto IL_0AF4;
								}
							}
							goto IL_0086;
							Block_9:
							goto IL_0167;
							Block_1:
							goto IL_01E8;
							IL_06B2:
							base.Name = Class15.smethod_17(89037564 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
							goto IL_0109;
							Block_11:
							goto IL_0125;
							IL_00A8:
							base.Controls.Add(this.pictureBox_0);
							num = 53;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
							{
								goto IL_00CE;
							}
							goto IL_0B29;
							IL_0097:
							base.Controls.Add(this.button_0);
							goto IL_00A8;
							IL_0086:
							base.Controls.Add(this.button_1);
							goto IL_0097;
							IL_0075:
							base.Controls.Add(this.button_2);
							goto IL_0086;
							IL_01E8:
							base.Controls.Add(this.pictureBox_1);
							goto IL_0075;
							IL_01D7:
							base.Controls.Add(this.aStDuroYc);
							goto IL_01E8;
							IL_01C6:
							base.Controls.Add(this.label_0);
							goto IL_01D7;
							IL_01B5:
							base.Controls.Add(this.linkLabel_1);
							goto IL_01C6;
							IL_01A4:
							base.Controls.Add(this.label_1);
							goto IL_01B5;
							IL_018F:
							base.ClientSize = new Size(418, 187);
							goto IL_01A4;
							IL_0183:
							base.CancelButton = this.button_0;
							goto IL_018F;
							IL_017C:
							base.AutoScaleMode = AutoScaleMode.Font;
							goto IL_0183;
							IL_0167:
							base.AutoScaleDimensions = new SizeF(6f, 12f);
							goto IL_017C;
							IL_00ED:
							base.MinimizeBox = false;
							num = 99;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
							{
								goto IL_0109;
							}
							goto IL_0B29;
							IL_00E6:
							base.MaximizeBox = false;
							goto IL_00ED;
							IL_00DF:
							base.FormBorderStyle = FormBorderStyle.FixedSingle;
							goto IL_00E6;
							IL_00CE:
							base.Controls.Add(this.linkLabel_0);
							goto IL_00DF;
							IL_0109:
							base.ShowInTaskbar = false;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
							{
								goto IL_0125;
							}
							goto IL_0B29;
							IL_0147:
							((ISupportInitialize)this.pictureBox_1).EndInit();
							num = 28;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
							{
								goto IL_0167;
							}
							goto IL_0B29;
							IL_012C:
							this.Text = Class15.smethod_17(299953007 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
							goto IL_0147;
							IL_0125:
							base.StartPosition = FormStartPosition.CenterParent;
							goto IL_012C;
							IL_06D2:
							this.button_0.Name = Class15.smethod_17(1387465388 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
							num = 27;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
							{
								goto IL_018F;
							}
							goto IL_0B29;
							IL_083B:
							this.button_0.Location = new Point(304, 12);
							goto IL_06D2;
							IL_081B:
							this.pictureBox_0 = new PictureBox();
							num = 48;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
							{
								goto IL_083B;
							}
							goto IL_0B29;
							IL_0810:
							this.pictureBox_1 = new PictureBox();
							goto IL_081B;
							IL_0805:
							this.linkLabel_0 = new LinkLabel();
							goto IL_0810;
							IL_0AF4:
							this.label_0 = new Label();
							goto IL_0805;
						}
					}
				}
			}
		}

		// Token: 0x04000008 RID: 8
		private PictureBox pictureBox_0;

		// Token: 0x04000009 RID: 9
		private Button button_0;

		// Token: 0x0400000A RID: 10
		private Button button_1;

		// Token: 0x0400000B RID: 11
		private Button button_2;

		// Token: 0x0400000C RID: 12
		private PictureBox pictureBox_1;

		// Token: 0x0400000D RID: 13
		private Label aStDuroYc;

		// Token: 0x0400000E RID: 14
		private Label label_0;

		// Token: 0x0400000F RID: 15
		private LinkLabel linkLabel_0;

		// Token: 0x04000010 RID: 16
		private LinkLabel linkLabel_1;

		// Token: 0x04000011 RID: 17
		private Label label_1;
	}
}
