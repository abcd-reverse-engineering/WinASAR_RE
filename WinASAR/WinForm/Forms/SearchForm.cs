using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using WinASAR.Common.Models;

namespace WinASAR.WinForm.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class SearchForm : Form
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B2 RID: 178 RVA: 0x0001E400 File Offset: 0x0001C600
		// (remove) Token: 0x060000B3 RID: 179 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		public event SearchForm.SearchEventHandler SearchSubmitted
		{
			[CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_0090:
					SearchForm.SearchEventHandler searchEventHandler = this.searchEventHandler_0;
					for (;;)
					{
						SearchForm.SearchEventHandler searchEventHandler2 = searchEventHandler;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
						{
							goto IL_0006;
						}
						goto IL_004C;
						do
						{
							IL_0027:
							SearchForm.SearchEventHandler searchEventHandler3;
							searchEventHandler = Interlocked.CompareExchange<SearchForm.SearchEventHandler>(ref this.searchEventHandler_0, searchEventHandler3, searchEventHandler2);
							num = 2;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0);
						IL_004C:
						switch (num)
						{
						case 0:
							goto IL_0027;
						case 1:
						{
							IL_0006:
							SearchForm.SearchEventHandler searchEventHandler3 = (SearchForm.SearchEventHandler)Delegate.Combine(searchEventHandler2, value);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
							{
								goto IL_0027;
							}
							goto IL_004C;
						}
						case 2:
							if (searchEventHandler == searchEventHandler2)
							{
								return;
							}
							break;
						case 3:
							break;
						case 4:
							goto IL_0090;
						case 5:
							return;
						default:
							goto IL_0027;
						}
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				for (;;)
				{
					SearchForm.SearchEventHandler searchEventHandler = this.searchEventHandler_0;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						goto IL_000C;
					}
					IL_0055:
					switch (num)
					{
					case 0:
						goto IL_0022;
					case 1:
						goto IL_000C;
					case 2:
						continue;
					case 3:
						return;
					case 4:
						goto IL_0031;
					case 5:
						break;
					default:
						goto IL_0022;
					}
					IL_0003:
					SearchForm.SearchEventHandler searchEventHandler2;
					if (searchEventHandler != searchEventHandler2)
					{
						goto IL_000C;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0055;
					}
					break;
					IL_0031:
					SearchForm.SearchEventHandler searchEventHandler3;
					searchEventHandler = Interlocked.CompareExchange<SearchForm.SearchEventHandler>(ref this.searchEventHandler_0, searchEventHandler3, searchEventHandler2);
					goto IL_0003;
					IL_0022:
					searchEventHandler3 = (SearchForm.SearchEventHandler)Delegate.Remove(searchEventHandler2, value);
					goto IL_0031;
					IL_000C:
					searchEventHandler2 = searchEventHandler;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						goto IL_0022;
					}
					goto IL_0055;
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001E54C File Offset: 0x0001C74C
		public SearchForm(SearchItem searchItem = null)
		{
			for (;;)
			{
				this.method_4();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_000A;
				}
				IL_003A:
				switch (num)
				{
				case 1:
					IL_000A:
					this.InitializeEvent();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_003A;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				this.InitializeData(searchItem);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_003A;
				}
				break;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		public void InitializeData(SearchItem searchItem = null)
		{
			for (;;)
			{
				IL_005A:
				object[] array = new object[1];
				for (;;)
				{
					IL_003A:
					array[0] = searchItem;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						return;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							Class24.smethod_1(23, array, this);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_003A;
						case 3:
							goto IL_005A;
						}
						return;
					}
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001E644 File Offset: 0x0001C844
		public void InitializeEvent()
		{
			for (;;)
			{
				object[] array = new object[0];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
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
				Class24.smethod_1(24, array, this);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		private void method_0(SearchItem searchItem_0)
		{
			for (;;)
			{
				SearchForm.SearchEventHandler searchEventHandler = this.searchEventHandler_0;
				int num;
				if (searchEventHandler != null)
				{
					searchEventHandler(searchItem_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						break;
					}
				}
				else
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto Block_2;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				break;
			}
			return;
			Block_2:;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0001E704 File Offset: 0x0001C904
		private void method_1(object sender, KeyEventArgs e)
		{
			while (e.KeyCode == Keys.Return)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					goto IL_0015;
				}
				IL_002E:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0015:
					this.method_2(sender, e);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_002E;
					}
					return;
				case 2:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001E764 File Offset: 0x0001C964
		private void method_2(object sender, EventArgs e)
		{
			for (;;)
			{
				IL_0086:
				string text = this.comboBox_0.Text;
				for (;;)
				{
					IL_0077:
					bool @checked = this.checkBox_0.Checked;
					for (;;)
					{
						IL_005E:
						SearchItem searchItem = new SearchItem
						{
							Keyword = text,
							IsMatchCase = @checked
						};
						for (;;)
						{
							base.Visible = false;
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
							{
								goto IL_0006;
							}
							IL_001F:
							switch (num)
							{
							case 1:
								goto IL_0096;
							case 2:
								continue;
							case 3:
								return;
							case 4:
								goto IL_005E;
							case 5:
								goto IL_0077;
							case 6:
								goto IL_0086;
							}
							IL_0006:
							this.method_0(searchItem);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
							{
								goto IL_001F;
							}
							goto IL_0095;
						}
					}
				}
			}
			IL_0095:
			IL_0096:
			base.Close();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0001E810 File Offset: 0x0001CA10
		private void method_3(object sender, EventArgs e)
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
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

		// Token: 0x060000BC RID: 188 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		private void method_4()
		{
			for (;;)
			{
				IL_082E:
				this.nuCobQsoJP = new GroupBox();
				int num = 54;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_055C;
				}
				do
				{
					IL_070E:
					switch (num)
					{
					case 1:
						goto IL_0314;
					case 2:
						goto IL_042E;
					case 3:
						goto IL_00B8;
					case 4:
						goto IL_0101;
					case 5:
						goto IL_0369;
					case 6:
						goto IL_0682;
					case 7:
						goto IL_0095;
					case 8:
						goto IL_06B4;
					case 9:
						goto IL_0343;
					case 10:
						goto IL_0550;
					case 11:
						goto IL_01EF;
					case 12:
						this.nuCobQsoJP.Controls.Add(this.label_0);
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto IL_0027;
						}
						continue;
					case 13:
						goto IL_02B3;
					case 14:
						goto IL_02DF;
					case 15:
						goto IL_043A;
					case 16:
						goto IL_0446;
					case 17:
						goto IL_0585;
					case 18:
						goto IL_022A;
					case 19:
						goto IL_04AA;
					case 20:
						goto IL_0250;
					case 21:
						this.nuCobQsoJP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
						goto IL_06B4;
					case 22:
						goto IL_0186;
					case 23:
						goto IL_03F6;
					case 24:
						goto IL_05F1;
					case 25:
						goto IL_055C;
					case 26:
						goto IL_04DB;
					case 27:
						goto IL_0027;
					case 28:
						goto IL_02BF;
					case 29:
						goto IL_03DA;
					case 30:
						goto IL_00D8;
					case 31:
						goto IL_012F;
					case 32:
						goto IL_061D;
					case 33:
						this.nuCobQsoJP.Location = new Point(12, 12);
						goto IL_0682;
					case 34:
						goto IL_01BB;
					case 35:
						this.nuCobQsoJP.Controls.Add(this.comboBox_0);
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_042E;
						}
						continue;
					case 36:
						goto IL_01C7;
					case 37:
						goto IL_049F;
					case 38:
						goto IL_0338;
					case 39:
						goto IL_00A1;
					case 40:
						base.FormBorderStyle = FormBorderStyle.FixedSingle;
						goto IL_061D;
					case 41:
						goto IL_045A;
					case 42:
						goto IL_0068;
					case 43:
						goto IL_03BF;
					case 44:
						this.button_0.TabIndex = 1;
						goto IL_05F1;
					case 45:
						this.label_0.TabIndex = 0;
						num = 42;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0338;
						}
						continue;
					case 46:
						goto IL_0543;
					case 47:
						goto IL_0204;
					case 48:
						this.Text = Class15.smethod_17(2060615320 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto Block_7;
						}
						continue;
					case 49:
						goto IL_04EB;
					case 50:
						goto IL_0047;
					case 51:
						goto IL_04CF;
					case 52:
						goto IL_01DC;
					case 53:
						goto IL_010E;
					case 54:
						this.checkBox_0 = new CheckBox();
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_049F;
						}
						continue;
					case 55:
						goto IL_082E;
					case 56:
						this.comboBox_0.Size = new Size(242, 20);
						goto IL_042E;
					case 57:
						goto IL_02CB;
					case 58:
						goto IL_0146;
					case 59:
						base.MinimizeBox = false;
						goto IL_03BF;
					case 60:
						goto IL_038A;
					case 61:
						goto IL_034E;
					case 62:
						goto IL_0166;
					case 63:
						goto IL_0088;
					case 64:
						goto IL_032D;
					case 65:
						goto IL_017A;
					case 66:
						goto IL_01E3;
					case 67:
						goto IL_02A7;
					case 68:
						goto IL_027B;
					case 69:
						goto IL_0006;
					}
					return;
					IL_0006:
					this.checkBox_0.TabIndex = 2;
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_0027;
					}
					continue;
					IL_0314:
					this.checkBox_0.Size = new Size(102, 16);
					goto IL_0006;
					IL_0047:
					this.checkBox_0.UseVisualStyleBackColor = true;
					num = 46;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto IL_0068;
					}
					continue;
					IL_0027:
					this.checkBox_0.Text = Class15.smethod_17(543254416 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89);
					goto IL_0047;
					IL_00D8:
					this.button_0.Size = new Size(85, 23);
					num = 44;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0101;
					}
					continue;
					IL_00B8:
					this.button_0.Name = Class15.smethod_17(1396560540 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
					goto IL_00D8;
					IL_00A1:
					this.button_0.Location = new Point(297, 19);
					goto IL_00B8;
					IL_0095:
					this.button_0.DialogResult = DialogResult.Cancel;
					goto IL_00A1;
					IL_0088:
					this.button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
					goto IL_0095;
					IL_0068:
					this.label_0.Text = Class15.smethod_17(2021179222 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
					goto IL_0088;
					IL_010E:
					this.button_1.DialogResult = DialogResult.Cancel;
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_012F;
					}
					continue;
					IL_0101:
					this.button_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
					goto IL_010E;
					IL_0186:
					this.button_1.Text = Class15.smethod_17(1788629272 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_01BB;
					}
					continue;
					IL_017A:
					this.button_1.TabIndex = 2;
					goto IL_0186;
					IL_0166:
					this.button_1.Size = new Size(85, 23);
					goto IL_017A;
					IL_0146:
					this.button_1.Name = Class15.smethod_17(1243251230 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
					goto IL_0166;
					IL_012F:
					this.button_1.Location = new Point(297, 56);
					goto IL_0146;
					IL_0204:
					base.Controls.Add(this.button_1);
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto IL_022A;
					}
					continue;
					IL_01EF:
					base.ClientSize = new Size(394, 145);
					goto IL_0204;
					IL_01E3:
					base.CancelButton = this.button_1;
					goto IL_01EF;
					IL_01DC:
					base.AutoScaleMode = AutoScaleMode.Font;
					goto IL_01E3;
					IL_01C7:
					base.AutoScaleDimensions = new SizeF(6f, 12f);
					goto IL_01DC;
					IL_01BB:
					this.button_1.UseVisualStyleBackColor = true;
					goto IL_01C7;
					IL_022A:
					base.Controls.Add(this.button_0);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						continue;
					}
					IL_0250:
					base.Controls.Add(this.nuCobQsoJP);
					num = 40;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto IL_00D8;
					}
					continue;
					IL_027B:
					this.nuCobQsoJP.Size = new Size(272, 114);
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_02A7;
					}
					continue;
					IL_0682:
					this.nuCobQsoJP.Name = Class15.smethod_17(2056983355 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
					goto IL_027B;
					IL_02DF:
					this.checkBox_0.Name = Class15.smethod_17(277636700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto IL_0314;
					}
					continue;
					IL_02CB:
					this.checkBox_0.Location = new Point(13, 82);
					goto IL_02DF;
					IL_02BF:
					this.checkBox_0.AutoSize = true;
					goto IL_02CB;
					IL_02B3:
					this.nuCobQsoJP.TabStop = false;
					goto IL_02BF;
					IL_02A7:
					this.nuCobQsoJP.TabIndex = 0;
					goto IL_02B3;
					IL_034E:
					base.SuspendLayout();
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						break;
					}
					continue;
					IL_0343:
					this.nuCobQsoJP.SuspendLayout();
					goto IL_034E;
					IL_0338:
					this.button_1 = new Button();
					goto IL_0343;
					IL_032D:
					this.button_0 = new Button();
					goto IL_0338;
					IL_038A:
					this.label_0.Size = new Size(53, 12);
					num = 45;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
					{
						goto IL_02DF;
					}
					continue;
					IL_045A:
					this.label_0.Name = Class15.smethod_17(2008551659 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
					goto IL_038A;
					IL_0446:
					this.label_0.Location = new Point(11, 18);
					goto IL_045A;
					IL_043A:
					this.label_0.AutoSize = true;
					goto IL_0446;
					IL_042E:
					this.comboBox_0.TabIndex = 1;
					goto IL_043A;
					IL_03DA:
					base.ShowInTaskbar = false;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_03F6;
					}
					continue;
					IL_03BF:
					base.Name = Class15.smethod_17(2056983185 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
					goto IL_03DA;
					IL_03F6:
					base.StartPosition = FormStartPosition.CenterParent;
					num = 48;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_012F;
					}
					continue;
					IL_04AA:
					this.label_0 = new Label();
					num = 63;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_032D;
					}
					continue;
					IL_049F:
					this.comboBox_0 = new ComboBox();
					goto IL_04AA;
					IL_04EB:
					this.button_0.UseVisualStyleBackColor = true;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto IL_0101;
					}
					continue;
					IL_05F1:
					this.button_0.Text = Class15.smethod_17(2021179070 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8);
					goto IL_04EB;
					IL_061D:
					base.MaximizeBox = false;
					num = 59;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto Block_10;
					}
					continue;
					IL_06B4:
					this.nuCobQsoJP.Controls.Add(this.checkBox_0);
					num = 35;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0);
				goto IL_0369;
				Block_10:
				goto IL_04DB;
				IL_04CF:
				this.nuCobQsoJP.ResumeLayout(false);
				goto IL_04DB;
				Block_7:
				goto IL_04CF;
				IL_0550:
				this.comboBox_0.FormattingEnabled = true;
				goto IL_055C;
				IL_0543:
				this.comboBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
				goto IL_0550;
				IL_0369:
				base.ResumeLayout(false);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					break;
				}
				goto IL_070E;
				IL_04DB:
				this.nuCobQsoJP.PerformLayout();
				goto IL_0369;
				IL_055C:
				this.comboBox_0.Location = new Point(13, 46);
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_070E;
				}
				IL_0585:
				this.comboBox_0.Name = Class15.smethod_17(564895050 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
				num = 56;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_04DB;
				}
				goto IL_070E;
			}
		}

		// Token: 0x040000AF RID: 175
		[CompilerGenerated]
		private SearchForm.SearchEventHandler searchEventHandler_0;

		// Token: 0x040000B1 RID: 177
		private GroupBox nuCobQsoJP;

		// Token: 0x040000B2 RID: 178
		private Button button_0;

		// Token: 0x040000B3 RID: 179
		private Button button_1;

		// Token: 0x040000B4 RID: 180
		private CheckBox checkBox_0;

		// Token: 0x040000B5 RID: 181
		private ComboBox comboBox_0;

		// Token: 0x040000B6 RID: 182
		private Label label_0;

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x060000C1 RID: 193
		public delegate void SearchEventHandler(SearchItem searchItem);
	}
}
