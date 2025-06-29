using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinASAR.Common.Helpers;
using WinASAR.Common.Models;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000F RID: 15
	public partial class ViewerForm : Form
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x0002047C File Offset: 0x0001E67C
		public ViewerForm(string filePath)
		{
			int num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
			{
				goto IL_0046;
			}
			do
			{
				IL_0083:
				switch (num)
				{
				case 1:
					this.InitializeEvent();
					goto IL_0060;
				case 2:
					goto IL_0060;
				case 3:
					goto IL_0046;
				}
				break;
				IL_0060:
				this.InitializeData(filePath);
				num = 0;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0);
			return;
			IL_0046:
			this.method_19();
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
			{
				goto IL_0083;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00020528 File Offset: 0x0001E728
		public void InitializeData(string filePath)
		{
			object[] array;
			for (;;)
			{
				array = new object[1];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					IL_0003:
					array[0] = filePath;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_0020;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			Class24.smethod_1(28, array, this);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0002059C File Offset: 0x0001E79C
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
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
				Class24.smethod_1(29, array, this);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00020600 File Offset: 0x0001E800
		private void method_0(Encoding encoding_1)
		{
			for (;;)
			{
				IL_024C:
				this.encoding_0 = encoding_1;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_0158;
				}
				for (;;)
				{
					IL_0205:
					switch (num)
					{
					case 1:
						goto IL_018C;
					case 2:
						goto IL_01C0;
					case 3:
						return;
					case 4:
						goto IL_0089;
					case 5:
						goto IL_0068;
					case 6:
						this.toolStripMenuItem_17.Checked = this.toolStripMenuItem_9.Checked;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
						{
							goto Block_2;
						}
						continue;
					case 7:
						goto IL_0101;
					case 8:
						goto IL_00DF;
					case 9:
						goto IL_007E;
					case 10:
						goto IL_0158;
					case 11:
						goto IL_024C;
					case 12:
						goto IL_011C;
					case 13:
						this.toolStripMenuItem_19.Checked = this.toolStripMenuItem_11.Checked;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							goto IL_00DF;
						}
						continue;
					case 14:
						goto IL_0006;
					}
					break;
				}
				goto IL_0031;
				IL_0101:
				this.toolStripMenuItem_18.Checked = this.toolStripMenuItem_10.Checked;
				goto IL_0068;
				IL_00DF:
				this.toolStripMenuItem_10.Checked = this.encoding_0.CodePage == Encoding.BigEndianUnicode.CodePage;
				goto IL_0101;
				Block_2:
				goto IL_018C;
				IL_0006:
				this.toolStripMenuItem_16.Checked = this.toolStripMenuItem_8.Checked;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_0031;
				}
				goto IL_0205;
				IL_011C:
				this.toolStripMenuItem_8.Checked = this.encoding_0.CodePage == Encoding.GetEncoding(Class15.smethod_17(2048535915 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)).CodePage;
				goto IL_0006;
				IL_01C0:
				this.toolStripMenuItem_15.Checked = this.toolStripMenuItem_7.Checked;
				goto IL_011C;
				IL_0031:
				this.toolStripMenuItem_9.Checked = this.encoding_0.CodePage == Encoding.UTF8.CodePage;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_0068;
				}
				goto IL_0205;
				IL_0089:
				this.backgroundWorker_0.RunWorkerAsync(this.string_0);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					break;
				}
				goto IL_0205;
				IL_007E:
				this.textBox_0.Clear();
				goto IL_0089;
				IL_0068:
				this.toolStripStatusLabel_2.Text = this.encoding_0.EncodingName;
				goto IL_007E;
				IL_0158:
				this.toolStripMenuItem_7.Checked = this.encoding_0.CodePage == Encoding.ASCII.CodePage;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					goto IL_0205;
				}
				IL_018C:
				this.toolStripMenuItem_11.Checked = this.encoding_0.CodePage == Encoding.Unicode.CodePage;
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					goto IL_01C0;
				}
				goto IL_0205;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00020878 File Offset: 0x0001EA78
		private void method_1(object sender, RunWorkerCompletedEventArgs e)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(this.string_0);
				for (;;)
				{
					this.toolStripStatusLabel_0.Text = Class15.smethod_17(594367538 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b) + FileHelper.GetHumanReadableSize(fileInfo.Length);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_004D;
					}
					IL_005B:
					switch (num)
					{
					case 0:
						goto IL_004D;
					case 1:
						goto IL_002E;
					case 2:
						continue;
					case 3:
						goto IL_00CD;
					case 4:
						goto IL_00C1;
					case 5:
						break;
					default:
						goto IL_004D;
					}
					IL_0010:
					this.textBox_0.SelectionLength = 0;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto IL_002E;
					}
					goto IL_005B;
					IL_004D:
					this.textBox_0.SelectionStart = 0;
					goto IL_0010;
					IL_002E:
					this.textBox_0.ScrollToCaret();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						break;
					}
					goto IL_005B;
				}
				IL_00C1:
				this.textBox_0.Focus();
				IL_00CD:;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					switch (num2)
					{
					}
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00020990 File Offset: 0x0001EB90
		private void method_2(object sender, DoWorkEventArgs e)
		{
			try
			{
				FileStream fileStream = new FileStream((string)e.Argument, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 1048576, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0159;
					}
				}
				try
				{
					byte[] array = new byte[1048576];
					int num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_00D3;
					}
					goto IL_00EA;
					IL_0077:
					ViewerForm.<>c__DisplayClass9_0 CS$<>8__locals1 = new ViewerForm.<>c__DisplayClass9_0();
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_00EA;
					}
					IL_0090:
					CS$<>8__locals1.viewerForm_0 = this;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_00EA;
					}
					IL_00AA:
					int num3;
					CS$<>8__locals1.string_0 = this.encoding_0.GetString(array, 0, num3);
					num2 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_00EA;
					}
					IL_00D3:
					if ((num3 = fileStream.Read(array, 0, array.Length)) <= 0)
					{
						goto IL_0111;
					}
					goto IL_0077;
					IL_00EA:
					switch (num2)
					{
					case 0:
						goto IL_0077;
					case 1:
						goto IL_0090;
					case 2:
						break;
					case 3:
						goto IL_00AA;
					case 4:
					case 5:
						goto IL_00D3;
					case 6:
						base.Invoke(new MethodInvoker(CS$<>8__locals1.method_0));
						goto IL_00D3;
					default:
						goto IL_0077;
					}
					IL_0111:;
				}
				finally
				{
					if (fileStream != null)
					{
						goto IL_013F;
					}
					int num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						goto IL_0158;
					}
					IL_012B:
					switch (num4)
					{
					case 2:
						IL_013F:
						((IDisposable)fileStream).Dispose();
						num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto IL_012B;
						}
						break;
					}
					IL_0158:;
				}
				IL_0159:;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				int num5 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
				{
					switch (num5)
					{
					}
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00020B58 File Offset: 0x0001ED58
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
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

		// Token: 0x060000DA RID: 218 RVA: 0x00020B90 File Offset: 0x0001ED90
		private void method_4(object sender, EventArgs e)
		{
			for (;;)
			{
				this.textBox_0.Focus();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					IL_0003:
					this.textBox_0.Copy();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_001F;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		private void method_5(object sender, EventArgs e)
		{
			for (;;)
			{
				this.textBox_0.Focus();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.textBox_0.SelectAll();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_001F;
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00020C58 File Offset: 0x0001EE58
		private void method_6(object sender, EventArgs e)
		{
			for (;;)
			{
				SearchForm searchForm = new SearchForm(this.searchItem_0);
				searchForm.SearchSubmitted += this.method_8;
				searchForm.StartPosition = FormStartPosition.CenterParent;
				searchForm.Icon = base.Icon;
				searchForm.ShowDialog(this);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
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

		// Token: 0x060000DD RID: 221 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void method_7(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_8(this.searchItem_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
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

		// Token: 0x060000DE RID: 222 RVA: 0x00020CFC File Offset: 0x0001EEFC
		private void method_8(SearchItem searchItem_1)
		{
			IL_024F:
			while (searchItem_1 != null)
			{
				for (;;)
				{
					IL_0227:
					this.searchItem_0 = new SearchItem
					{
						Keyword = searchItem_1.Keyword,
						IsMatchCase = searchItem_1.IsMatchCase
					};
					for (;;)
					{
						IL_0006:
						int num = this.textBox_0.Text.IndexOf(this.searchItem_0.Keyword, this.textBox_0.SelectionStart + this.textBox_0.SelectionLength, this.searchItem_0.IsMatchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
						{
							goto IL_01BF;
						}
						for (;;)
						{
							IL_01D5:
							switch (num2)
							{
							case 1:
							case 10:
							case 12:
								return;
							case 2:
								goto IL_019B;
							case 3:
								this.textBox_0.SelectionLength = this.searchItem_0.Keyword.Length;
								num2 = 13;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
								{
									goto Block_7;
								}
								continue;
							case 4:
								goto IL_0006;
							case 5:
								goto IL_00B4;
							case 6:
								return;
							case 7:
								goto IL_007C;
							case 8:
								goto IL_0146;
							case 9:
								goto IL_0088;
							case 11:
								goto IL_024F;
							case 13:
								this.textBox_0.ScrollToCaret();
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
								{
									goto IL_0146;
								}
								continue;
							case 14:
								goto IL_0071;
							case 15:
								goto IL_0227;
							case 16:
								goto IL_0065;
							}
							break;
							IL_0146:
							this.textBox_0.Focus();
							num2 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
							{
								goto Block_6;
							}
						}
						goto IL_01BF;
						IL_0088:
						if (!string.IsNullOrEmpty(this.searchItem_0.Keyword))
						{
							goto IL_00B4;
						}
						num2 = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto Block_4;
						}
						goto IL_01D5;
						IL_007C:
						this.textBox_0.Focus();
						goto IL_0088;
						IL_0071:
						this.textBox_0.ScrollToCaret();
						goto IL_007C;
						IL_0065:
						this.textBox_0.SelectionLength = 0;
						goto IL_0071;
						IL_01BF:
						if (num <= -1)
						{
							this.textBox_0.SelectionStart = 0;
							goto IL_0065;
						}
						goto IL_019B;
						IL_00B4:
						MessageBox.Show(Class15.smethod_17(277640572 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98) + this.searchItem_0.Keyword + Class15.smethod_17(1788754185 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), Class15.smethod_17(41443501 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto Block_5;
						}
						goto IL_01D5;
						IL_019B:
						this.textBox_0.SelectionStart = num;
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
						{
							goto Block_8;
						}
						goto IL_01D5;
					}
				}
				Block_4:
				Block_5:
				break;
				Block_6:
				return;
				Block_7:
				Block_8:
				break;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00020F6C File Offset: 0x0001F16C
		private void method_9(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_0(Encoding.ASCII);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
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

		// Token: 0x060000E0 RID: 224 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		private void method_10(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_0(Encoding.GetEncoding(Class15.smethod_17(314774767 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927)));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
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

		// Token: 0x060000E1 RID: 225 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		private void method_11(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_0(Encoding.UTF8);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00021034 File Offset: 0x0001F234
		private void method_12(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_0(Encoding.Unicode);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
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

		// Token: 0x060000E3 RID: 227 RVA: 0x00021070 File Offset: 0x0001F270
		private void method_13(object sender, EventArgs e)
		{
			for (;;)
			{
				this.method_0(Encoding.BigEndianUnicode);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
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

		// Token: 0x060000E4 RID: 228 RVA: 0x000210AC File Offset: 0x0001F2AC
		private void method_14(object sender, EventArgs e)
		{
			for (;;)
			{
				this.toolStripMenuItem_12.Checked = !this.toolStripMenuItem_12.Checked;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_0003;
				}
				IL_002A:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.textBox_0.WordWrap = this.toolStripMenuItem_12.Checked;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_002A;
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00021128 File Offset: 0x0001F328
		private void method_15(object sender, EventArgs e)
		{
			for (;;)
			{
				FontDialog fontDialog = new FontDialog();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0031;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0030;
			}
			return;
			IL_0030:
			IL_0031:
			try
			{
				FontDialog fontDialog;
				fontDialog.Font = this.textBox_0.Font;
				int num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0072;
				}
				for (;;)
				{
					IL_00B1:
					switch (num2)
					{
					case 1:
						goto IL_0072;
					case 2:
						goto IL_007A;
					case 3:
						goto IL_0097;
					case 4:
						fontDialog.ShowEffects = true;
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_0072;
						}
						continue;
					case 5:
						goto IL_00DF;
					}
					break;
				}
				goto IL_00D2;
				IL_0072:
				fontDialog.AllowVerticalFonts = true;
				IL_007A:
				if (fontDialog.ShowDialog(this) != DialogResult.OK)
				{
					goto IL_00DF;
				}
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto IL_00B1;
				}
				IL_0097:
				Font font = fontDialog.Font;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					goto IL_00B1;
				}
				IL_00D2:
				this.textBox_0.Font = font;
				IL_00DF:;
			}
			finally
			{
				FontDialog fontDialog;
				int num3;
				if (fontDialog == null)
				{
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto IL_0125;
					}
					goto IL_00F9;
				}
				do
				{
					IL_010A:
					((IDisposable)fontDialog).Dispose();
					num3 = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0);
				IL_00F9:
				switch (num3)
				{
				default:
					goto IL_010A;
				case 1:
				case 2:
					IL_0125:
					break;
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0002126C File Offset: 0x0001F46C
		private void method_16(object sender, EventArgs e)
		{
			for (;;)
			{
				new AboutForm(Class15.smethod_17(82299874 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909))
				{
					StartPosition = FormStartPosition.CenterParent,
					Icon = base.Icon
				}.ShowDialog(this);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					IL_0003:
					this.textBox_0.Focus();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_0020;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000212F8 File Offset: 0x0001F4F8
		private void method_17(object sender, MouseEventArgs e)
		{
			while (e.Button == MouseButtons.Left)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto IL_0015;
				}
				IL_003D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0015:
				this.contextMenuStrip_0.Show(this, base.PointToClient(Control.MousePosition));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_003D;
				}
				break;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00021368 File Offset: 0x0001F568
		private void method_18(object sender, EventArgs e)
		{
			try
			{
				this.encoding_0 = FileHelper.DetectFileEncoding(this.string_0);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.method_0(this.encoding_0);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
							{
								continue;
							}
							break;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class15.smethod_17(82304718 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_00A2;
				}
				IL_008B:
				base.Close();
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					goto IL_00B3;
				}
				IL_00A2:
				switch (num2)
				{
				case 0:
					goto IL_008B;
				case 1:
					break;
				default:
					goto IL_008B;
				}
				IL_00B3:;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000214C8 File Offset: 0x0001F6C8
		private void method_19()
		{
			for (;;)
			{
				IL_190D:
				this.icontainer_0 = new Container();
				int num = 113;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_067D;
				}
				for (;;)
				{
					IL_1626:
					switch (num)
					{
					case 1:
						goto IL_1352;
					case 2:
						goto IL_0FF0;
					case 3:
						goto IL_0FA2;
					case 4:
						goto IL_01A1;
					case 5:
						goto IL_046D;
					case 6:
						goto IL_03BB;
					case 7:
						goto IL_0D12;
					case 8:
						goto IL_127E;
					case 9:
						goto IL_05C3;
					case 10:
						goto IL_0CFC;
					case 11:
						goto IL_0D57;
					case 12:
						goto IL_07F0;
					case 13:
						goto IL_0494;
					case 14:
						goto IL_027E;
					case 15:
						goto IL_0670;
					case 16:
						goto IL_0A8D;
					case 17:
						goto IL_0526;
					case 18:
						this.toolStripSeparator_2.Size = new Size(182, 6);
						goto IL_15E9;
					case 19:
						goto IL_0419;
					case 20:
						goto IL_1010;
					case 21:
						goto IL_049F;
					case 22:
						goto IL_0F01;
					case 23:
						goto IL_15E9;
					case 24:
						goto IL_1153;
					case 25:
						goto IL_111E;
					case 26:
						goto IL_00A5;
					case 27:
						goto IL_1067;
					case 28:
						goto IL_0C97;
					case 29:
						goto IL_004D;
					case 30:
						this.toolStripMenuItem_2.Text = Class15.smethod_17(314774923 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
						goto IL_131D;
					case 31:
						goto IL_04FF;
					case 32:
						goto IL_06A9;
					case 33:
						goto IL_01FF;
					case 34:
						goto IL_0442;
					case 35:
						goto IL_0B43;
					case 36:
						goto IL_1228;
					case 37:
						goto IL_1263;
					case 38:
						goto IL_0850;
					case 39:
						goto IL_0258;
					case 40:
						goto IL_12C2;
					case 41:
						goto IL_0AD6;
					case 42:
						goto IL_09F3;
					case 43:
						goto IL_152E;
					case 44:
						this.QodFuBgdm3.Text = Class15.smethod_17(552177266 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
						num = 127;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
						{
							goto Block_18;
						}
						continue;
					case 45:
						goto IL_002D;
					case 46:
						goto IL_081C;
					case 47:
						goto IL_1949;
					case 48:
						goto IL_1438;
					case 49:
						goto IL_0B9E;
					case 50:
						goto IL_1418;
					case 51:
						goto IL_1463;
					case 52:
						goto IL_0E3C;
					case 53:
						goto IL_0A6D;
					case 54:
						goto IL_070B;
					case 55:
						return;
					case 56:
						goto IL_0F56;
					case 57:
						goto IL_074C;
					case 58:
						goto IL_0E99;
					case 59:
						goto IL_138E;
					case 60:
						this.toolStripStatusLabel_2.Size = new Size(89, 17);
						goto IL_13F8;
					case 61:
						base.AutoScaleMode = AutoScaleMode.Font;
						num = 162;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_1438;
						}
						continue;
					case 62:
						goto IL_14FD;
					case 63:
						goto IL_0384;
					case 64:
						goto IL_061B;
					case 65:
						goto IL_0968;
					case 66:
						this.toolStripStatusLabel_0.Font = new Font(Class15.smethod_17(594366042 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
						num = 104;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_12C2;
						}
						continue;
					case 67:
						goto IL_0364;
					case 68:
						goto IL_006E;
					case 69:
						goto IL_10FE;
					case 70:
						goto IL_0B93;
					case 71:
						goto IL_022B;
					case 72:
						goto IL_1399;
					case 73:
						goto IL_09B4;
					case 74:
						goto IL_1443;
					case 75:
						this.toolStripStatusLabel_1.ForeColor = Color.Silver;
						goto IL_13BE;
					case 76:
						goto IL_03F0;
					case 77:
						goto IL_067D;
					case 78:
						this.toolStripMenuItem_5.ShortcutKeyDisplayString = "";
						num = 134;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
						{
							goto Block_15;
						}
						continue;
					case 79:
						goto IL_1950;
					case 80:
						goto IL_08B9;
					case 81:
						goto IL_1233;
					case 82:
						goto IL_02F8;
					case 83:
						goto IL_0C05;
					case 84:
						goto IL_099D;
					case 85:
						this.toolStripMenuItem_9 = new ToolStripMenuItem();
						goto IL_1438;
					case 86:
						goto IL_0AAD;
					case 87:
						goto IL_0344;
					case 88:
						goto IL_0126;
					case 89:
						goto IL_0478;
					case 90:
						goto IL_020B;
					case 91:
						goto IL_0D07;
					case 92:
						goto IL_13F8;
					case 93:
						goto IL_0085;
					case 94:
						goto IL_13BE;
					case 95:
						this.toolStripMenuItem_2 = new ToolStripMenuItem();
						goto IL_138E;
					case 96:
						goto IL_0F21;
					case 97:
						goto IL_0106;
					case 98:
						goto IL_0717;
					case 99:
						goto IL_131D;
					case 100:
						goto IL_0AF6;
					case 101:
						goto IL_0A44;
					case 102:
						goto IL_0BFF;
					case 103:
						goto IL_0021;
					case 104:
						this.toolStripStatusLabel_0.Name = Class15.smethod_17(649966006 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff);
						goto IL_1296;
					case 105:
						this.toolStripMenuItem_8.Text = Class15.smethod_17(1829604523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
						goto IL_118D;
					case 106:
						goto IL_04AA;
					case 107:
						goto IL_10C9;
					case 108:
						goto IL_01EC;
					case 109:
						goto IL_1296;
					case 110:
						goto IL_02E1;
					case 111:
						goto IL_1289;
					case 112:
						goto IL_014B;
					case 113:
						this.menuStrip_0 = new MenuStrip();
						goto IL_127E;
					case 114:
						goto IL_190D;
					case 115:
						goto IL_0318;
					case 116:
						goto IL_00DA;
					case 117:
						goto IL_024C;
					case 118:
						goto IL_0F82;
					case 119:
						goto IL_0C54;
					case 120:
						goto IL_0A24;
					case 121:
						goto IL_1258;
					case 122:
						goto IL_02C1;
					case 123:
						goto IL_09D4;
					case 124:
						goto IL_0B63;
					case 125:
						goto IL_092D;
					case 126:
						goto IL_0C6B;
					case 127:
						goto IL_04D5;
					case 128:
						goto IL_044D;
					case 129:
						goto IL_08FC;
					case 130:
						goto IL_121D;
					case 131:
						this.toolStripMenuItem_3 = new ToolStripMenuItem();
						num = 121;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
						{
							goto IL_09F3;
						}
						continue;
					case 132:
						goto IL_0546;
					case 133:
						this.toolStripMenuItem_17.Size = new Size(248, 22);
						goto IL_0EAA;
					case 134:
						this.toolStripMenuItem_5.ShortcutKeys = (Keys)131139;
						num = 95;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto IL_10B2;
						}
						continue;
					case 135:
						goto IL_0E62;
					case 136:
						goto IL_0ECA;
					case 137:
						goto IL_0870;
					case 138:
						goto IL_04B5;
					case 139:
						goto IL_118D;
					case 140:
						goto IL_0830;
					case 141:
						this.toolStripMenuItem_1.Text = Class15.smethod_17(974453773 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
						goto IL_1153;
					case 142:
						goto IL_10B2;
					case 143:
						goto IL_0EEA;
					case 144:
						goto IL_0BDF;
					case 145:
						goto IL_01C2;
					case 146:
						goto IL_078A;
					case 147:
						goto IL_108C;
					case 148:
						goto IL_0272;
					case 149:
						goto IL_039B;
					case 150:
						goto IL_06BF;
					case 151:
						goto IL_0E73;
					case 152:
						this.toolStripMenuItem_12.CheckState = CheckState.Checked;
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_1067;
						}
						continue;
					case 153:
						goto IL_018B;
					case 154:
						goto IL_0DA3;
					case 155:
						goto IL_0BA9;
					case 156:
						this.toolStripStatusLabel_1.Size = new Size(11, 17);
						goto IL_0FF0;
					case 157:
						goto IL_0EAA;
					case 158:
						goto IL_0884;
					case 159:
						goto IL_050F;
					case 160:
						goto IL_193D;
					case 161:
						goto IL_0CB6;
					case 162:
						base.ClientSize = new Size(834, 561);
						goto IL_0E3C;
					case 163:
						goto IL_0E02;
					case 164:
						goto IL_05EF;
					case 165:
						goto IL_0BD4;
					case 166:
						goto IL_0483;
					case 167:
						goto IL_1932;
					case 168:
						goto IL_0C77;
					case 169:
						goto IL_0BC9;
					case 170:
						goto IL_0DC8;
					case 171:
						this.menuStrip_0.Location = new Point(0, 0);
						goto IL_0DA3;
					case 172:
						goto IL_0D37;
					case 173:
						this.toolStripMenuItem_18 = new ToolStripMenuItem();
						goto IL_0B93;
					case 174:
						goto IL_0B2C;
					case 175:
						goto IL_0952;
					case 176:
						this.toolStripMenuItem_0.Name = Class15.smethod_17(1678096374 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a);
						goto IL_081C;
					case 177:
						goto IL_07D5;
					case 178:
						goto IL_077D;
					case 179:
						goto IL_06DF;
					case 180:
						goto IL_016B;
					case 181:
						goto IL_05DF;
					case 182:
						goto IL_0006;
					}
					goto Block_19;
					IL_002D:
					this.menuStrip_0.PerformLayout();
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_004D;
					}
					continue;
					IL_0021:
					this.menuStrip_0.ResumeLayout(false);
					goto IL_002D;
					IL_0006:
					this.Text = Class15.smethod_17(1042094647 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
					goto IL_0021;
					IL_07F0:
					base.StartPosition = FormStartPosition.CenterScreen;
					goto IL_0006;
					IL_07D5:
					base.Name = Class15.smethod_17(1743159426 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8);
					goto IL_07F0;
					IL_0E99:
					base.MainMenuStrip = this.menuStrip_0;
					goto IL_07D5;
					IL_004D:
					this.statusStrip_0.ResumeLayout(false);
					num = 167;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
					{
						goto IL_006E;
					}
					continue;
					IL_00A5:
					this.toolStripMenuItem_11.Name = Class15.smethod_17(1116161773 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
					num = 112;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_00DA;
					}
					continue;
					IL_0085:
					this.toolStripMenuItem_9.Text = Class15.smethod_17(676695608 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
					goto IL_00A5;
					IL_006E:
					this.toolStripMenuItem_9.Size = new Size(248, 22);
					goto IL_0085;
					IL_118D:
					this.toolStripMenuItem_9.Name = Class15.smethod_17(642135724 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
					goto IL_006E;
					IL_00DA:
					this.toolStripMenuItem_11.Size = new Size(248, 22);
					num = 72;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0106;
					}
					continue;
					IL_05EF:
					this.toolStripMenuItem_20.Size = new Size(185, 22);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_061B;
					}
					continue;
					IL_05DF:
					this.toolStripMenuItem_20.ShortcutKeys = (Keys)131142;
					goto IL_05EF;
					IL_15E9:
					this.toolStripMenuItem_20.Name = Class15.smethod_17(1760309307 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_05DF;
					IL_061B:
					this.toolStripMenuItem_20.Text = Class15.smethod_17(89031178 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_0650;
					}
					continue;
					IL_078A:
					this.toolStripStatusLabel_1.Font = new Font(Class15.smethod_17(538805911 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					num = 75;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_077D:
					this.toolStripStatusLabel_0.TextAlign = ContentAlignment.MiddleLeft;
					goto IL_078A;
					IL_0E02:
					this.toolStripStatusLabel_0.Text = Class15.smethod_17(2128217810 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
					goto IL_077D;
					IL_12C2:
					this.toolStripStatusLabel_0.Spring = true;
					goto IL_0E02;
					IL_0884:
					this.toolStripMenuItem_4.Text = Class15.smethod_17(538807713 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
					num = 49;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
					{
						goto IL_08B9;
					}
					continue;
					IL_0870:
					this.toolStripMenuItem_4.Size = new Size(116, 22);
					goto IL_0884;
					IL_0850:
					this.toolStripMenuItem_4.Name = Class15.smethod_17(1243253040 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					goto IL_0870;
					IL_0830:
					this.toolStripMenuItem_0.Text = Class15.smethod_17(1243254336 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					goto IL_0850;
					IL_081C:
					this.toolStripMenuItem_0.Size = new Size(58, 21);
					goto IL_0830;
					IL_0968:
					this.toolStripMenuItem_13.Name = Class15.smethod_17(1807888138 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
					num = 41;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						goto IL_099D;
					}
					continue;
					IL_0952:
					this.toolStripSeparator_1.Size = new Size(245, 6);
					goto IL_0968;
					IL_0B63:
					this.toolStripSeparator_1.Name = Class15.smethod_17(1760305361 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_0952;
					IL_0B43:
					this.toolStripMenuItem_12.Text = Class15.smethod_17(1603807246 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
					goto IL_0B63;
					IL_0B2C:
					this.toolStripMenuItem_12.Size = new Size(248, 22);
					goto IL_0B43;
					IL_1067:
					this.toolStripMenuItem_12.Name = Class15.smethod_17(1793855410 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
					goto IL_0B2C;
					IL_0A44:
					this.toolStripMenuItem_3.Size = new Size(61, 21);
					num = 40;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_0A6D;
					}
					continue;
					IL_0A24:
					this.toolStripMenuItem_3.Name = Class15.smethod_17(1760308861 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
					goto IL_0A44;
					IL_09F3:
					this.toolStripMenuItem_3.Font = new Font(Class15.smethod_17(642133526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_0A24;
					IL_09D4:
					this.toolStripMenuItem_3.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_14 });
					goto IL_09F3;
					IL_09B4:
					this.toolStripMenuItem_13.Text = Class15.smethod_17(2128230706 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
					goto IL_09D4;
					IL_099D:
					this.toolStripMenuItem_13.Size = new Size(248, 22);
					goto IL_09B4;
					IL_0AAD:
					this.toolStripMenuItem_14.Size = new Size(116, 22);
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						goto IL_0AD6;
					}
					continue;
					IL_0A8D:
					this.toolStripMenuItem_14.Name = Class15.smethod_17(564893146 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
					goto IL_0AAD;
					IL_0A6D:
					this.toolStripMenuItem_3.Text = Class15.smethod_17(698998976 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
					goto IL_0A8D;
					IL_0BA9:
					this.QodFuBgdm3 = new ToolStripMenuItem();
					num = 40;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_0BC9;
					}
					continue;
					IL_0B9E:
					this.toolStripMenuItem_20 = new ToolStripMenuItem();
					goto IL_0BA9;
					IL_0B93:
					this.toolStripSeparator_2 = new ToolStripSeparator();
					goto IL_0B9E;
					IL_0BDF:
					this.contextMenuStrip_0.SuspendLayout();
					num = 51;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_0BFF;
					}
					continue;
					IL_0BD4:
					this.statusStrip_0.SuspendLayout();
					goto IL_0BDF;
					IL_0BC9:
					this.menuStrip_0.SuspendLayout();
					goto IL_0BD4;
					IL_0C05:
					this.menuStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3 });
					num = 171;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_0C54;
					}
					continue;
					IL_0BFF:
					base.SuspendLayout();
					goto IL_0C05;
					IL_0CB6:
					this.toolStripMenuItem_0.Font = new Font(Class15.smethod_17(1788629306 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					num = 176;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0CFC;
					}
					continue;
					IL_0C97:
					this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_4 });
					goto IL_0CB6;
					IL_0C77:
					this.menuStrip_0.Text = Class15.smethod_17(299954779 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
					goto IL_0C97;
					IL_0C6B:
					this.menuStrip_0.TabIndex = 0;
					goto IL_0C77;
					IL_0C54:
					this.menuStrip_0.Size = new Size(834, 25);
					goto IL_0C6B;
					IL_0DA3:
					this.menuStrip_0.Name = Class15.smethod_17(635812779 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					goto IL_0C54;
					IL_0D12:
					this.toolStripMenuItem_13 = new ToolStripMenuItem();
					num = 131;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_081C;
					}
					continue;
					IL_0D07:
					this.toolStripSeparator_1 = new ToolStripSeparator();
					goto IL_0D12;
					IL_0CFC:
					this.toolStripMenuItem_12 = new ToolStripMenuItem();
					goto IL_0D07;
					IL_1463:
					this.toolStripSeparator_0 = new ToolStripSeparator();
					goto IL_0CFC;
					IL_0D57:
					this.toolStripMenuItem_8.Name = Class15.smethod_17(2021177418 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
					num = 57;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto Block_4;
					}
					continue;
					IL_0D37:
					this.toolStripMenuItem_7.Text = Class15.smethod_17(1387468138 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
					goto IL_0D57;
					IL_0DC8:
					this.toolStripStatusLabel_2.Name = Class15.smethod_17(1570991919 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
					num = 60;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto Block_5;
					}
					continue;
					IL_1010:
					this.toolStripStatusLabel_2.Font = new Font(Class15.smethod_17(1570982355 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
					goto IL_0DC8;
					IL_0FF0:
					this.toolStripStatusLabel_1.Text = Class15.smethod_17(2060613972 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
					goto IL_1010;
					IL_0E3C:
					base.Controls.Add(this.textBox_0);
					num = 58;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_0E62;
					}
					continue;
					IL_0E73:
					base.Controls.Add(this.menuStrip_0);
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_0E99;
					}
					continue;
					IL_0E62:
					base.Controls.Add(this.statusStrip_0);
					goto IL_0E73;
					IL_0F21:
					this.toolStripMenuItem_18.Name = Class15.smethod_17(1243260370 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					num = 32;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0F56;
					}
					continue;
					IL_0F01:
					this.toolStripMenuItem_19.Text = Class15.smethod_17(2048536377 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					goto IL_0F21;
					IL_0EEA:
					this.toolStripMenuItem_19.Size = new Size(248, 22);
					goto IL_0F01;
					IL_0ECA:
					this.toolStripMenuItem_19.Name = Class15.smethod_17(698994878 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
					goto IL_0EEA;
					IL_0EAA:
					this.toolStripMenuItem_17.Text = Class15.smethod_17(2048536523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
					goto IL_0ECA;
					IL_0F56:
					this.toolStripMenuItem_18.Size = new Size(248, 22);
					num = 66;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_0F82;
					}
					continue;
					IL_0FA2:
					this.toolStripSeparator_2.Name = Class15.smethod_17(635801845 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_6;
					}
					continue;
					IL_0F82:
					this.toolStripMenuItem_18.Text = Class15.smethod_17(1471358833 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e);
					goto IL_0FA2;
					IL_108C:
					this.textBox_0.Dock = DockStyle.Fill;
					num = 125;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto Block_7;
					}
					continue;
					IL_1418:
					this.textBox_0.BackColor = SystemColors.ControlLightLight;
					goto IL_108C;
					IL_13F8:
					this.toolStripStatusLabel_2.Text = Class15.smethod_17(432115863 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
					goto IL_1418;
					IL_10C9:
					this.toolStripMenuItem_5.Text = Class15.smethod_17(676695320 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
					num = 60;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_10FE;
					}
					continue;
					IL_10B2:
					this.toolStripMenuItem_5.Size = new Size(185, 22);
					goto IL_10C9;
					IL_1153:
					this.toolStripMenuItem_5.Name = Class15.smethod_17(1243254600 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					num = 78;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto Block_8;
					}
					continue;
					IL_1233:
					this.toolStripMenuItem_6 = new ToolStripMenuItem();
					num = 95;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_00A5;
					}
					continue;
					IL_1228:
					this.toolStripMenuItem_5 = new ToolStripMenuItem();
					goto IL_1233;
					IL_121D:
					this.toolStripMenuItem_1 = new ToolStripMenuItem();
					goto IL_1228;
					IL_1289:
					this.toolStripMenuItem_4 = new ToolStripMenuItem();
					goto IL_121D;
					IL_127E:
					this.toolStripMenuItem_0 = new ToolStripMenuItem();
					goto IL_1289;
					IL_1296:
					this.toolStripStatusLabel_0.Size = new Size(719, 17);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_12C2;
					}
					continue;
					IL_131D:
					this.toolStripMenuItem_7.Name = Class15.smethod_17(1570984673 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						continue;
					}
					IL_1352:
					this.toolStripMenuItem_7.Size = new Size(248, 22);
					num = 158;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_0D37;
					}
					continue;
					IL_1399:
					this.toolStripMenuItem_8 = new ToolStripMenuItem();
					num = 85;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto Block_13;
					}
					continue;
					IL_138E:
					this.toolStripMenuItem_7 = new ToolStripMenuItem();
					goto IL_1399;
					IL_13BE:
					this.toolStripStatusLabel_1.Name = Class15.smethod_17(1424583078 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
					num = 156;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto Block_14;
					}
					continue;
					IL_1443:
					this.toolStripMenuItem_10 = new ToolStripMenuItem();
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_1463;
					}
					continue;
					IL_1438:
					this.toolStripMenuItem_11 = new ToolStripMenuItem();
					goto IL_1443;
				}
				IL_0126:
				this.toolStripMenuItem_10.Name = Class15.smethod_17(642135630 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
				goto IL_05C3;
				IL_0106:
				this.toolStripMenuItem_11.Text = Class15.smethod_17(2056984347 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
				goto IL_0126;
				Block_14:
				goto IL_01EC;
				Block_7:
				goto IL_01C2;
				Block_6:
				goto IL_027E;
				IL_152E:
				this.toolStripMenuItem_2.Name = Class15.smethod_17(314774943 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927);
				goto IL_03F0;
				IL_14FD:
				this.toolStripMenuItem_2.Font = new Font(Class15.smethod_17(41446913 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
				goto IL_152E;
				IL_092D:
				this.toolStripMenuItem_1.Name = Class15.smethod_17(642135500 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba);
				goto IL_0419;
				IL_08FC:
				this.toolStripMenuItem_1.Font = new Font(Class15.smethod_17(2056982319 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
				goto IL_092D;
				IL_08B9:
				this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_5, this.toolStripMenuItem_6, this.toolStripSeparator_2, this.toolStripMenuItem_20, this.QodFuBgdm3 });
				goto IL_08FC;
				Block_13:
				goto IL_08B9;
				IL_1263:
				this.statusStrip_0 = new StatusStrip();
				goto IL_0442;
				Block_15:
				goto IL_1263;
				IL_1258:
				this.toolStripMenuItem_14 = new ToolStripMenuItem();
				goto IL_1263;
				Block_18:
				goto IL_1258;
				IL_111E:
				this.toolStripMenuItem_6.ShortcutKeyDisplayString = "";
				goto IL_04FF;
				IL_10FE:
				this.toolStripMenuItem_6.Name = Class15.smethod_17(2056979803 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
				goto IL_111E;
				IL_0670:
				this.QodFuBgdm3.ShortcutKeys = Keys.F3;
				goto IL_067D;
				Block_4:
				goto IL_0670;
				IL_0650:
				this.QodFuBgdm3.Name = Class15.smethod_17(1760309455 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
				goto IL_0670;
				Block_19:
				Block_8:
				goto IL_0650;
				IL_0AF6:
				this.statusStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel_0, this.toolStripStatusLabel_1, this.toolStripStatusLabel_2 });
				goto IL_06A9;
				IL_0AD6:
				this.toolStripMenuItem_14.Text = Class15.smethod_17(2048536131 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
				goto IL_0AF6;
				Block_5:
				goto IL_0AD6;
				IL_01A1:
				this.toolStripMenuItem_12.Checked = true;
				num = 152;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_01C2;
				}
				goto IL_1626;
				IL_018B:
				this.toolStripSeparator_0.Size = new Size(245, 6);
				goto IL_01A1;
				IL_016B:
				this.toolStripSeparator_0.Name = Class15.smethod_17(432123705 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
				goto IL_018B;
				IL_014B:
				this.toolStripMenuItem_10.Text = Class15.smethod_17(1603807620 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
				goto IL_016B;
				IL_05C3:
				this.toolStripMenuItem_10.Size = new Size(248, 22);
				goto IL_014B;
				IL_022B:
				this.textBox_0.ReadOnly = true;
				num = 55;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_024C;
				}
				goto IL_1626;
				IL_020B:
				this.textBox_0.Name = Class15.smethod_17(538812595 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
				goto IL_022B;
				IL_01FF:
				this.textBox_0.Multiline = true;
				goto IL_020B;
				IL_01EC:
				this.textBox_0.Location = new Point(0, 25);
				goto IL_01FF;
				IL_01C2:
				this.textBox_0.Font = new Font(Class15.smethod_17(41437237 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), 10f);
				goto IL_01EC;
				IL_0318:
				this.toolStripMenuItem_15.Size = new Size(248, 22);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0344;
				}
				goto IL_1626;
				IL_02F8:
				this.toolStripMenuItem_15.Name = Class15.smethod_17(1807880282 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
				goto IL_0318;
				IL_02E1:
				this.contextMenuStrip_0.Size = new Size(249, 114);
				goto IL_02F8;
				IL_02C1:
				this.contextMenuStrip_0.Name = Class15.smethod_17(486538174 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c);
				goto IL_02E1;
				IL_027E:
				this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_15, this.toolStripMenuItem_16, this.toolStripMenuItem_17, this.toolStripMenuItem_19, this.toolStripMenuItem_18 });
				goto IL_02C1;
				IL_0272:
				this.textBox_0.TabIndex = 2;
				goto IL_027E;
				IL_0258:
				this.textBox_0.Size = new Size(834, 514);
				goto IL_0272;
				IL_024C:
				this.textBox_0.ScrollBars = ScrollBars.Both;
				goto IL_0258;
				IL_03BB:
				this.toolStripMenuItem_17.Name = Class15.smethod_17(1793864130 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a);
				num = 133;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					goto IL_03F0;
				}
				goto IL_1626;
				IL_039B:
				this.toolStripMenuItem_16.Text = Class15.smethod_17(2071402556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
				goto IL_03BB;
				IL_0384:
				this.toolStripMenuItem_16.Size = new Size(248, 22);
				goto IL_039B;
				IL_0364:
				this.toolStripMenuItem_16.Name = Class15.smethod_17(1387473314 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
				goto IL_0384;
				IL_0344:
				this.toolStripMenuItem_15.Text = Class15.smethod_17(699001904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
				goto IL_0364;
				IL_03F0:
				this.toolStripMenuItem_2.Size = new Size(60, 21);
				num = 30;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_1626;
				}
				IL_0419:
				this.toolStripMenuItem_1.Size = new Size(59, 21);
				num = 141;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_0442;
				}
				goto IL_1626;
				IL_044D:
				this.toolStripStatusLabel_1 = new ToolStripStatusLabel();
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
				{
					goto IL_046D;
				}
				goto IL_1626;
				IL_0442:
				this.toolStripStatusLabel_0 = new ToolStripStatusLabel();
				goto IL_044D;
				IL_04B5:
				this.toolStripMenuItem_19 = new ToolStripMenuItem();
				num = 173;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_04D5;
				}
				goto IL_1626;
				IL_04AA:
				this.toolStripMenuItem_17 = new ToolStripMenuItem();
				goto IL_04B5;
				IL_049F:
				this.toolStripMenuItem_16 = new ToolStripMenuItem();
				goto IL_04AA;
				IL_0494:
				this.toolStripMenuItem_15 = new ToolStripMenuItem();
				goto IL_049F;
				IL_0483:
				this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
				goto IL_0494;
				IL_0478:
				this.textBox_0 = new TextBox();
				goto IL_0483;
				IL_046D:
				this.toolStripStatusLabel_2 = new ToolStripStatusLabel();
				goto IL_0478;
				IL_04D5:
				base.AutoScaleDimensions = new SizeF(6f, 12f);
				num = 61;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_04FF;
				}
				goto IL_1626;
				IL_0546:
				this.toolStripMenuItem_2.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItem_7, this.toolStripMenuItem_8, this.toolStripMenuItem_9, this.toolStripMenuItem_11, this.toolStripMenuItem_10, this.toolStripSeparator_0, this.toolStripMenuItem_12, this.toolStripSeparator_1, this.toolStripMenuItem_13 });
				num = 62;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_05C3;
				}
				goto IL_1626;
				IL_0526:
				this.toolStripMenuItem_6.Text = Class15.smethod_17(299950691 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e);
				goto IL_0546;
				IL_050F:
				this.toolStripMenuItem_6.Size = new Size(185, 22);
				goto IL_0526;
				IL_04FF:
				this.toolStripMenuItem_6.ShortcutKeys = (Keys)131137;
				goto IL_050F;
				IL_067D:
				this.QodFuBgdm3.Size = new Size(185, 22);
				num = 44;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_06A9;
				}
				goto IL_1626;
				IL_06DF:
				this.statusStrip_0.Size = new Size(834, 22);
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					goto IL_070B;
				}
				goto IL_1626;
				IL_06BF:
				this.statusStrip_0.Name = Class15.smethod_17(1424580006 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf);
				goto IL_06DF;
				IL_06A9:
				this.statusStrip_0.Location = new Point(0, 539);
				goto IL_06BF;
				IL_0717:
				this.statusStrip_0.Text = Class15.smethod_17(2021177934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
				num = 66;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_074C;
				}
				goto IL_1626;
				IL_070B:
				this.statusStrip_0.TabIndex = 1;
				goto IL_0717;
				IL_074C:
				this.toolStripMenuItem_8.Size = new Size(248, 22);
				num = 105;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					goto IL_01A1;
				}
				goto IL_1626;
			}
			Block_2:
			return;
			IL_1932:
			this.statusStrip_0.PerformLayout();
			IL_193D:
			this.contextMenuStrip_0.ResumeLayout(false);
			IL_1949:
			base.ResumeLayout(false);
			IL_1950:
			base.PerformLayout();
		}

		// Token: 0x040000C3 RID: 195
		private string string_0 = string.Empty;

		// Token: 0x040000C4 RID: 196
		private Encoding encoding_0 = Encoding.Default;

		// Token: 0x040000C5 RID: 197
		private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

		// Token: 0x040000C6 RID: 198
		private SearchItem searchItem_0 = new SearchItem();

		// Token: 0x040000C8 RID: 200
		private MenuStrip menuStrip_0;

		// Token: 0x040000C9 RID: 201
		private StatusStrip statusStrip_0;

		// Token: 0x040000CA RID: 202
		private TextBox textBox_0;

		// Token: 0x040000CB RID: 203
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040000CC RID: 204
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040000CD RID: 205
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x040000CE RID: 206
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x040000CF RID: 207
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x040000D0 RID: 208
		private ToolStripStatusLabel toolStripStatusLabel_1;

		// Token: 0x040000D1 RID: 209
		private ToolStripStatusLabel toolStripStatusLabel_2;

		// Token: 0x040000D2 RID: 210
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x040000D3 RID: 211
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x040000D4 RID: 212
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x040000D5 RID: 213
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x040000D6 RID: 214
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x040000D7 RID: 215
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x040000D8 RID: 216
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x040000D9 RID: 217
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x040000DA RID: 218
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x040000DB RID: 219
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x040000DC RID: 220
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x040000DD RID: 221
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x040000DE RID: 222
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x040000DF RID: 223
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x040000E0 RID: 224
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x040000E1 RID: 225
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x040000E2 RID: 226
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x040000E3 RID: 227
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x040000E4 RID: 228
		private ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x040000E5 RID: 229
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x040000E6 RID: 230
		private ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x040000E7 RID: 231
		private ToolStripMenuItem QodFuBgdm3;
	}
}
