using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200017D RID: 381
	[Nullable(0)]
	[NullableContext(1)]
	internal class JPath
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x000068DF File Offset: 0x00004ADF
		public List<PathFilter> Filters { get; }

		// Token: 0x06001120 RID: 4384 RVA: 0x00087378 File Offset: 0x00085578
		public JPath(string expression)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(expression, Class15.smethod_17(197534577 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0041;
				}
				IL_004A:
				switch (num)
				{
				case 1:
					IL_0041:
					this.string_0 = expression;
					goto IL_000A;
				case 2:
					goto IL_0027;
				case 3:
					goto IL_000A;
				case 4:
					continue;
				}
				break;
				IL_000A:
				this.Filters = new List<PathFilter>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_004A;
				}
				IL_0027:
				this.method_0();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					break;
				}
				goto IL_004A;
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0008741C File Offset: 0x0008561C
		private void method_0()
		{
			int num3;
			for (;;)
			{
				IL_01C6:
				int num = this.int_0;
				int num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto Block_14;
				}
				for (;;)
				{
					IL_017E:
					char c;
					switch (num2)
					{
					case 1:
						goto IL_00E5;
					case 2:
						while (this.string_0.Length == 1)
						{
							num2 = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
							{
								goto IL_017E;
							}
						}
						c = this.string_0[this.int_0 + 1];
						goto IL_0028;
					case 3:
						goto IL_01EB;
					case 4:
						this.iHgHyFiPtt();
						goto IL_009F;
					case 5:
						goto IL_01C6;
					case 6:
						goto IL_004C;
					case 7:
						this.iHgHyFiPtt();
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
						{
							goto IL_00F2;
						}
						continue;
					case 8:
						goto IL_00F2;
					case 9:
						return;
					case 10:
						goto IL_0043;
					case 11:
						return;
					case 12:
						goto IL_0077;
					case 13:
						goto IL_009F;
					case 14:
						goto IL_0028;
					case 15:
						goto IL_0006;
					}
					goto Block_13;
					IL_0006:
					num3 = this.int_0;
					num2 = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto Block_1;
					}
					continue;
					IL_004C:
					if (!this.method_1(this.Filters, num, false))
					{
						goto IL_0006;
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto Block_5;
					}
					continue;
					IL_0043:
					if (c == '[')
					{
						goto IL_0077;
					}
					goto IL_004C;
					IL_0028:
					if (c != '.')
					{
						num2 = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto IL_0043;
						}
						continue;
					}
					IL_0077:
					this.int_0++;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto Block_6;
					}
					continue;
					IL_00F2:
					if (this.int_0 >= this.string_0.Length)
					{
						return;
					}
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_00E5;
					}
					continue;
					IL_009F:
					if (this.string_0.Length == this.int_0)
					{
						goto Block_7;
					}
					if (this.string_0[this.int_0] != '$')
					{
						goto IL_004C;
					}
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						continue;
					}
					IL_00E5:
					num = this.int_0;
					goto IL_004C;
				}
			}
			Block_1:
			goto IL_01EB;
			Block_5:
			Block_6:
			return;
			Block_7:
			return;
			Block_13:
			Block_14:
			return;
			IL_01EB:
			throw new JsonException(Class15.smethod_17(1788641626 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1) + this.string_0[num3].ToString());
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0008764C File Offset: 0x0008584C
		private bool method_1(List<PathFilter> list_1, int int_1, bool bool_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			while (this.int_0 < this.string_0.Length && !flag4)
			{
				char c = this.string_0[this.int_0];
				if (c <= ')')
				{
					if (c != ' ')
					{
						if (c == '(')
						{
							goto IL_00C4;
						}
						if (c == ')')
						{
							goto IL_00BD;
						}
					}
					else
					{
						if (this.int_0 < this.string_0.Length)
						{
							flag4 = true;
							continue;
						}
						continue;
					}
				}
				else
				{
					if (c == '.')
					{
						if (this.int_0 > int_1)
						{
							string text = this.string_0.Substring(int_1, this.int_0 - int_1);
							if (text == Class15.smethod_17(543271530 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89))
							{
								text = null;
							}
							list_1.Add(JPath.smethod_0(text, flag));
							flag = false;
						}
						if (this.int_0 + 1 < this.string_0.Length && this.string_0[this.int_0 + 1] == '.')
						{
							flag = true;
							this.int_0++;
						}
						this.int_0++;
						int_1 = this.int_0;
						flag2 = false;
						flag3 = true;
						continue;
					}
					if (c == '[')
					{
						goto IL_00C4;
					}
					if (c == ']')
					{
						goto IL_00BD;
					}
				}
				if (bool_0 && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
				{
					flag4 = true;
					continue;
				}
				if (!flag2)
				{
					this.int_0++;
					continue;
				}
				throw new JsonException(Class15.smethod_17(197534461 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81) + c.ToString());
				IL_00BD:
				flag4 = true;
				continue;
				IL_00C4:
				if (this.int_0 > int_1)
				{
					string text2 = this.string_0.Substring(int_1, this.int_0 - int_1);
					if (text2 == Class15.smethod_17(538793801 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa))
					{
						text2 = null;
					}
					list_1.Add(JPath.smethod_0(text2, flag));
					flag = false;
				}
				list_1.Add(this.method_2(c, flag));
				flag = false;
				this.int_0++;
				int_1 = this.int_0;
				flag2 = true;
				flag3 = false;
			}
			bool flag5 = this.int_0 == this.string_0.Length;
			if (this.int_0 > int_1)
			{
				string text3 = this.string_0.Substring(int_1, this.int_0 - int_1).TrimEnd(new char[0]);
				if (text3 == Class15.smethod_17(1788641508 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1))
				{
					text3 = null;
				}
				list_1.Add(JPath.smethod_0(text3, flag));
			}
			else if (flag3 && (flag5 || bool_0))
			{
				throw new JsonException(Class15.smethod_17(2057035295 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
			}
			return flag5;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0008791C File Offset: 0x00085B1C
		private static PathFilter smethod_0([Nullable(2)] string member, bool bool_0)
		{
			while (bool_0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0036;
					}
				}
				return new ScanFilter(member);
			}
			IL_0036:
			return new FieldFilter(member);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00087968 File Offset: 0x00085B68
		private PathFilter method_2(char char_1, bool bool_0)
		{
			char c2;
			for (;;)
			{
				IL_009C:
				this.int_0++;
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					break;
				}
				for (;;)
				{
					char c;
					switch (num)
					{
					case 0:
						goto IL_0057;
					case 1:
						goto IL_00BE;
					case 2:
						goto IL_002D;
					case 3:
						goto IL_0027;
					case 4:
						goto IL_00DD;
					case 5:
						goto IL_000B;
					case 6:
						if (char_1 != '[')
						{
							goto IL_000B;
						}
						c = ']';
						break;
					case 7:
						goto IL_009C;
					default:
						goto IL_0057;
					}
					IL_0011:
					c2 = c;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_0057;
					}
					continue;
					IL_000B:
					c = ')';
					goto IL_0011;
					IL_002D:
					if (this.string_0[this.int_0] != '\'')
					{
						goto IL_00C8;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto IL_0057;
					}
					continue;
					IL_0027:
					this.iHgHyFiPtt();
					goto IL_002D;
					IL_0057:
					this.method_15(Class15.smethod_17(2021159496 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
					goto IL_0027;
				}
			}
			goto IL_00DD;
			IL_00BE:
			return this.method_14(c2, bool_0);
			IL_00C8:
			if (this.string_0[this.int_0] != '?')
			{
				return this.method_3(c2);
			}
			IL_00DD:
			return this.method_4(c2, bool_0);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00087A64 File Offset: 0x00085C64
		private PathFilter method_3(char char_1)
		{
			int num;
			List<int> list;
			int? num4;
			int? num5;
			int? num6;
			int num10;
			int num11;
			char c;
			for (;;)
			{
				IL_0670:
				num = this.int_0;
				for (;;)
				{
					IL_0666:
					int? num2 = null;
					for (;;)
					{
						IL_0660:
						list = null;
						for (;;)
						{
							IL_065B:
							int num3 = 0;
							for (;;)
							{
								IL_0650:
								num4 = null;
								for (;;)
								{
									IL_0646:
									num5 = null;
									for (;;)
									{
										IL_063C:
										num6 = null;
										for (;;)
										{
											IL_0623:
											if (this.int_0 < this.string_0.Length)
											{
												goto IL_05AB;
											}
											int num7 = 16;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
											{
												goto Block_33;
											}
											int? num9;
											int num12;
											for (;;)
											{
												IL_0436:
												int num8;
												switch (num7)
												{
												case 1:
													goto IL_02B4;
												case 2:
													goto IL_05AB;
												case 3:
													goto IL_0142;
												case 4:
													IL_02AF:
													if (num8 > 0)
													{
														goto IL_02B4;
													}
													num7 = 33;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
													{
														goto IL_021A;
													}
													continue;
												case 5:
													goto IL_03EA;
												case 6:
												case 51:
													goto IL_06FF;
												case 7:
													goto IL_02EF;
												case 8:
													if (num3 == 0)
													{
														goto IL_0315;
													}
													goto IL_0359;
												case 9:
													goto IL_065B;
												case 10:
													goto IL_06B7;
												case 11:
													goto IL_0337;
												case 12:
													goto IL_0798;
												case 13:
													goto IL_015D;
												case 14:
												case 44:
												case 72:
												case 77:
												case 80:
													goto IL_0623;
												case 15:
													goto IL_0112;
												case 16:
													goto IL_0109;
												case 17:
													goto IL_05FC;
												case 18:
													goto IL_0188;
												case 19:
													goto IL_0361;
												case 20:
													goto IL_03CA;
												case 21:
													goto IL_0666;
												case 22:
													goto IL_0670;
												case 23:
													goto IL_06AB;
												case 24:
													goto IL_0753;
												case 25:
													goto IL_0175;
												case 26:
													goto IL_067D;
												case 27:
													goto IL_03AF;
												case 28:
													goto IL_0006;
												case 29:
													goto IL_05C3;
												case 30:
													num9 = num2;
													num7 = 3;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
													{
														goto IL_00A1;
													}
													continue;
												case 31:
													goto IL_01FC;
												case 32:
													goto IL_00DF;
												case 33:
													num = this.int_0;
													num7 = 29;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
													{
														goto IL_0112;
													}
													continue;
												case 34:
													goto IL_0698;
												case 35:
													goto IL_05D1;
												case 36:
													goto IL_00AA;
												case 37:
													goto IL_013B;
												case 38:
													goto IL_0359;
												case 39:
												case 56:
												case 57:
												case 66:
													goto IL_021A;
												case 40:
													IL_00BE:
													if (list != null)
													{
														goto IL_0753;
													}
													if (num3 > 0)
													{
														num7 = 4;
														if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
														{
															goto IL_00DF;
														}
														continue;
													}
													else
													{
														if (num10 == 0)
														{
															goto IL_0738;
														}
														num7 = 26;
														if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
														{
															goto IL_0109;
														}
														continue;
													}
													break;
												case 41:
													goto IL_028F;
												case 42:
													goto IL_001D;
												case 43:
													this.iHgHyFiPtt();
													goto IL_0337;
												case 45:
													goto IL_07BF;
												case 46:
													goto IL_0650;
												case 47:
													goto IL_0646;
												case 48:
													goto IL_02E6;
												case 49:
													goto IL_023D;
												case 50:
													goto IL_01E1;
												case 52:
													if (num3 == 1)
													{
														goto Block_21;
													}
													goto IL_01B0;
												case 53:
													goto IL_0660;
												case 54:
													goto IL_071D;
												case 55:
													goto IL_0315;
												case 58:
													goto IL_0757;
												case 59:
													goto IL_0738;
												case 60:
													goto IL_01D3;
												case 61:
													goto IL_0772;
												case 62:
													num9 = num2;
													goto IL_02EF;
												case 63:
													goto IL_0222;
												case 64:
												case 69:
													goto IL_0164;
												case 65:
													goto IL_06E4;
												case 67:
													goto IL_05DB;
												case 68:
													goto IL_059F;
												case 70:
													goto IL_063C;
												case 71:
													goto IL_05E4;
												case 73:
													goto IL_01B0;
												case 74:
													goto IL_00A1;
												case 75:
													goto IL_0081;
												case 76:
													goto IL_077D;
												case 78:
													goto IL_07E6;
												case 79:
													goto IL_004C;
												}
												goto Block_29;
												IL_004C:
												num11 = Convert.ToInt32(this.string_0.Substring(num, num10), CultureInfo.InvariantCulture);
												num7 = 52;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
												{
													goto Block_6;
												}
												continue;
												IL_00DF:
												if (num10 > 0)
												{
													goto IL_004C;
												}
												goto IL_06FF;
												IL_00B9:
												int valueOrDefault;
												num10 = valueOrDefault - num;
												goto IL_00BE;
												IL_00A1:
												if (num9 != null)
												{
													valueOrDefault = num9.GetValueOrDefault();
													goto IL_00B9;
												}
												IL_00AA:
												valueOrDefault = this.int_0;
												goto IL_00B9;
												IL_0121:
												int valueOrDefault2;
												num12 = valueOrDefault2 - num;
												num7 = 34;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
												{
													goto IL_013B;
												}
												continue;
												IL_0109:
												if (num9 != null)
												{
													valueOrDefault2 = num9.GetValueOrDefault();
													goto IL_0121;
												}
												IL_0112:
												valueOrDefault2 = this.int_0;
												goto IL_0121;
												IL_01B0:
												num6 = new int?(num11);
												num7 = 6;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
												{
													goto Block_15;
												}
												continue;
												IL_01E1:
												this.iHgHyFiPtt();
												num7 = 33;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
												{
													goto IL_01FC;
												}
												continue;
												IL_01D3:
												this.int_0++;
												goto IL_01E1;
												IL_021A:
												num3++;
												goto IL_01D3;
												IL_0361:
												int num13;
												num5 = new int?(num13);
												goto IL_021A;
												IL_0359:
												if (num3 == 1)
												{
													goto IL_0361;
												}
												goto IL_01FC;
												IL_0315:
												num4 = new int?(num13);
												goto IL_021A;
												IL_01FC:
												num6 = new int?(num13);
												num7 = 43;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
												{
													goto IL_021A;
												}
												continue;
												IL_0295:
												int valueOrDefault3;
												num8 = valueOrDefault3 - num;
												num7 = 3;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
												{
													goto IL_02AF;
												}
												continue;
												IL_02E6:
												valueOrDefault3 = num9.GetValueOrDefault();
												goto IL_0295;
												IL_02EF:
												if (num9 != null)
												{
													goto IL_02E6;
												}
												IL_028F:
												valueOrDefault3 = this.int_0;
												goto IL_0295;
												IL_02B4:
												num13 = Convert.ToInt32(this.string_0.Substring(num, num8), CultureInfo.InvariantCulture);
												num7 = 8;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
												{
													goto IL_02EF;
												}
												continue;
												IL_0337:
												num = this.int_0;
												num7 = 35;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
												{
													goto Block_22;
												}
											}
											IL_05C3:
											num2 = null;
											continue;
											Block_6:
											goto IL_05D1;
											Block_15:
											goto IL_0142;
											IL_013B:
											if (num12 != 0)
											{
												goto IL_0142;
											}
											goto IL_071D;
											Block_22:
											goto IL_015D;
											Block_29:
											goto IL_0258;
											IL_0081:
											this.iHgHyFiPtt();
											num7 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
											{
												continue;
											}
											goto IL_0436;
											IL_03EA:
											num2 = new int?(this.int_0);
											num7 = 29;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
											{
												goto IL_0081;
											}
											goto IL_0436;
											IL_059F:
											if (c != ' ')
											{
												goto IL_0006;
											}
											num7 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
											{
												goto IL_03EA;
											}
											goto IL_0436;
											IL_05AB:
											c = this.string_0[this.int_0];
											goto IL_059F;
											IL_001D:
											if (c == '*')
											{
												num7 = 7;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
												{
													goto IL_03CA;
												}
												goto IL_0436;
											}
											else
											{
												if (c != ':')
												{
													goto IL_05DB;
												}
												num7 = 62;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
												{
													goto IL_05D1;
												}
												goto IL_0436;
											}
											IL_0006:
											if (c == char_1)
											{
												num7 = 30;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
												{
													goto IL_0436;
												}
												goto IL_0665;
											}
											else
											{
												if (c == ',')
												{
													goto IL_03AF;
												}
												goto IL_001D;
											}
											IL_05D1:
											num2 = null;
											continue;
											IL_05FC:
											this.int_0++;
											continue;
											IL_05F0:
											if (num2 == null)
											{
												goto IL_05FC;
											}
											goto IL_07BF;
											IL_05E4:
											if (c != '-')
											{
												goto Block_32;
											}
											goto IL_05F0;
											IL_05DB:
											if (!char.IsDigit(c))
											{
												goto IL_05E4;
											}
											goto IL_05F0;
											IL_0142:
											if (list == null)
											{
												goto IL_015D;
											}
											num7 = 47;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
											{
												goto IL_0164;
											}
											goto IL_0436;
											IL_0188:
											this.int_0++;
											num7 = 43;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
											{
												goto Block_14;
											}
											goto IL_0436;
											IL_0175:
											string text;
											list.Add(Convert.ToInt32(text, CultureInfo.InvariantCulture));
											goto IL_0188;
											IL_0164:
											text = this.string_0.Substring(num, num12);
											goto IL_0175;
											IL_015D:
											list = new List<int>();
											goto IL_0164;
											IL_023D:
											this.iHgHyFiPtt();
											num7 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
											{
												goto IL_0258;
											}
											goto IL_0436;
											IL_0222:
											this.method_15(Class15.smethod_17(299907201 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
											goto IL_023D;
											IL_03CA:
											this.int_0++;
											goto IL_0222;
											IL_0258:
											if (this.string_0[this.int_0] == char_1)
											{
												goto IL_06DE;
											}
											num7 = 7;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
											{
												goto Block_17;
											}
											goto IL_0436;
											IL_03AF:
											num9 = num2;
											num7 = 16;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
											{
												goto IL_0142;
											}
											goto IL_0436;
										}
									}
								}
							}
							Block_14:;
						}
					}
					IL_0665:;
				}
			}
			Block_17:
			goto IL_06B7;
			Block_21:
			goto IL_06AB;
			Block_32:
			goto IL_0798;
			Block_33:
			goto IL_06E4;
			IL_067D:
			int num14 = Convert.ToInt32(this.string_0.Substring(num, num10), CultureInfo.InvariantCulture);
			IL_0698:
			return new ArrayIndexFilter
			{
				Index = new int?(num14)
			};
			IL_06AB:
			num5 = new int?(num11);
			goto IL_06FF;
			IL_06B7:
			throw new JsonException(Class15.smethod_17(82251438 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909) + c.ToString());
			IL_06DE:
			return new ArrayIndexFilter();
			IL_06E4:
			throw new JsonException(Class15.smethod_17(197534273 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81));
			IL_06FF:
			return new ArraySliceFilter
			{
				Start = num4,
				End = num5,
				Step = num6
			};
			IL_071D:
			throw new JsonException(Class15.smethod_17(676677696 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
			IL_0738:
			throw new JsonException(Class15.smethod_17(538794025 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
			IL_0753:
			if (num10 == 0)
			{
				goto IL_077D;
			}
			IL_0757:
			int num15 = Convert.ToInt32(this.string_0.Substring(num, num10), CultureInfo.InvariantCulture);
			IL_0772:
			list.Add(num15);
			goto IL_07E6;
			IL_077D:
			throw new JsonException(Class15.smethod_17(2057032081 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
			IL_0798:
			throw new JsonException(Class15.smethod_17(2048584129 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18) + c.ToString());
			IL_07BF:
			throw new JsonException(Class15.smethod_17(594382998 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b) + c.ToString());
			IL_07E6:
			return new ArrayMultipleIndexFilter(list);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00088260 File Offset: 0x00086460
		private void iHgHyFiPtt()
		{
			for (;;)
			{
				if (this.int_0 < this.string_0.Length)
				{
					goto IL_003E;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					break;
				}
				IL_0022:
				switch (num)
				{
				case 0:
				case 4:
					continue;
				case 1:
					return;
				case 2:
					break;
				case 3:
					IL_003E:
					if (this.string_0[this.int_0] != ' ')
					{
						return;
					}
					break;
				default:
					continue;
				}
				this.int_0++;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0022;
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000882F4 File Offset: 0x000864F4
		private PathFilter method_4(char char_1, bool bool_0)
		{
			QueryExpression queryExpression;
			for (;;)
			{
				IL_00E0:
				this.int_0++;
				int num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					goto IL_0095;
				}
				for (;;)
				{
					IL_00A8:
					switch (num)
					{
					case 1:
						goto IL_013E;
					case 2:
						goto IL_0095;
					case 3:
						goto IL_008D;
					case 4:
						goto IL_0144;
					case 5:
						goto IL_0053;
					case 6:
						goto IL_0158;
					case 7:
						goto IL_019D;
					case 8:
						this.method_15(Class15.smethod_17(82247962 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
						goto IL_0053;
					case 9:
						goto IL_00E0;
					case 10:
						goto IL_0195;
					case 11:
						goto IL_0006;
					}
					goto Block_4;
					IL_0053:
					if (this.string_0[this.int_0] == '(')
					{
						goto IL_007F;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto Block_3;
					}
				}
				IL_008D:
				queryExpression = this.method_8();
				goto IL_0095;
				IL_007F:
				this.int_0++;
				goto IL_008D;
				IL_0006:
				this.method_15(Class15.smethod_17(1802328627 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					break;
				}
				goto IL_00A8;
				IL_0095:
				this.int_0++;
				goto IL_0006;
			}
			goto IL_013E;
			Block_3:
			Block_4:
			throw new JsonException(Class15.smethod_17(1788645366 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1) + this.string_0[this.int_0].ToString());
			IL_013E:
			this.iHgHyFiPtt();
			IL_0144:
			if (this.string_0[this.int_0] == char_1)
			{
				if (bool_0)
				{
					goto IL_0195;
				}
				goto IL_019D;
			}
			IL_0158:
			throw new JsonException(Class15.smethod_17(89014600 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454) + this.string_0[this.int_0].ToString());
			IL_0195:
			return new QueryScanFilter(queryExpression);
			IL_019D:
			return new QueryFilter(queryExpression);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000884A8 File Offset: 0x000866A8
		private bool method_5([Nullable(new byte[] { 2, 1 })] out List<PathFilter> expressionPath)
		{
			for (;;)
			{
				if (this.string_0[this.int_0] != '$')
				{
					goto IL_00A3;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_003F;
				}
				IL_005C:
				switch (num)
				{
				case 1:
					return false;
				case 2:
					goto IL_0053;
				case 3:
					goto IL_0014;
				case 4:
					IL_00A3:
					if (this.string_0[this.int_0] == '@')
					{
						goto IL_0053;
					}
					goto IL_008C;
				case 5:
					IL_003F:
					expressionPath = new List<PathFilter> { RootFilter.Instance };
					goto IL_0006;
				case 6:
					continue;
				case 7:
				case 9:
					goto IL_0006;
				case 8:
					goto IL_008C;
				}
				break;
				IL_0014:
				if (!this.method_1(expressionPath, this.int_0, true))
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					break;
				}
				goto IL_005C;
				IL_0006:
				this.int_0++;
				goto IL_0014;
				IL_008C:
				expressionPath = null;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					return false;
				}
				goto IL_005C;
				IL_0053:
				expressionPath = new List<PathFilter>();
				goto IL_0006;
			}
			throw new JsonException(Class15.smethod_17(1042141621 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000885C0 File Offset: 0x000867C0
		private JsonException method_6()
		{
			return new JsonException(Class15.smethod_17(564879220 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610) + this.string_0[this.int_0].ToString());
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00088608 File Offset: 0x00086808
		private object method_7()
		{
			List<PathFilter> list;
			object obj;
			for (;;)
			{
				IL_00D2:
				this.iHgHyFiPtt();
				for (;;)
				{
					if (this.method_5(out list))
					{
						goto IL_0019;
					}
					if (this.method_9(out obj))
					{
						goto IL_00B7;
					}
					goto IL_00E6;
					IL_0060:
					int num;
					switch (num)
					{
					case 1:
						goto IL_00DB;
					case 2:
						IL_00B7:
						this.iHgHyFiPtt();
						goto IL_0088;
					case 3:
						goto IL_0088;
					case 4:
						IL_0019:
						this.iHgHyFiPtt();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							goto IL_0060;
						}
						break;
					case 5:
						return list;
					case 6:
						continue;
					case 7:
						goto IL_00D2;
					}
					this.method_15(Class15.smethod_17(2021162266 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						goto IL_0060;
					}
					goto IL_00E3;
					IL_0088:
					this.method_15(Class15.smethod_17(1985327102 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto Block_3;
					}
					goto IL_0060;
				}
			}
			Block_3:
			IL_00DB:
			return new JValue(obj);
			IL_00E3:
			return list;
			IL_00E6:
			throw this.method_6();
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00088704 File Offset: 0x00086904
		private QueryExpression method_8()
		{
			QueryExpression queryExpression;
			CompositeExpression compositeExpression;
			BooleanQueryExpression booleanQueryExpression;
			for (;;)
			{
				IL_03DB:
				queryExpression = null;
				for (;;)
				{
					IL_03BE:
					compositeExpression = null;
					int num = 32;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0073;
					}
					object obj;
					object obj2;
					for (;;)
					{
						IL_02FB:
						switch (num)
						{
						case 1:
							goto IL_013E;
						case 2:
							goto IL_03E3;
						case 3:
						case 21:
							goto IL_0150;
						case 4:
						case 38:
							goto IL_0173;
						case 5:
							goto IL_0006;
						case 6:
							goto IL_006E;
						case 7:
							return queryExpression;
						case 8:
							goto IL_007B;
						case 9:
							goto IL_00ED;
						case 10:
							goto IL_0028;
						case 11:
							goto IL_0142;
						case 12:
							goto IL_03EA;
						case 13:
							goto IL_0073;
						case 14:
							goto IL_0044;
						case 15:
							goto IL_040A;
						case 16:
						case 29:
							obj = this.method_7();
							num = 41;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
							{
								continue;
							}
							goto IL_03E0;
						case 17:
							goto IL_016F;
						case 18:
						case 45:
							goto IL_0201;
						case 19:
						case 20:
							goto IL_01CE;
						case 22:
							goto IL_01CA;
						case 23:
							goto IL_0111;
						case 24:
							goto IL_0259;
						case 25:
							goto IL_03BE;
						case 26:
							goto IL_03DB;
						case 27:
							goto IL_02D1;
						case 28:
							goto IL_0181;
						case 30:
							if (!this.method_12(Class15.smethod_17(926398621 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296)))
							{
								goto IL_03FB;
							}
							if (compositeExpression == null)
							{
								goto IL_02D1;
							}
							goto IL_0288;
						case 31:
							goto IL_03FB;
						case 32:
						case 44:
							goto IL_0199;
						case 33:
							return booleanQueryExpression;
						case 35:
							goto IL_0288;
						case 36:
							goto IL_01DE;
						case 37:
							goto IL_0403;
						case 39:
							goto IL_0121;
						case 40:
							goto IL_0241;
						case 41:
							obj2 = null;
							goto IL_0241;
						case 42:
							goto IL_00A5;
						case 43:
							goto IL_0154;
						}
						goto Block_19;
						IL_0259:
						if (this.string_0[this.int_0] == '|')
						{
							goto IL_006E;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
						{
							goto Block_15;
						}
						continue;
						IL_0241:
						if (this.string_0[this.int_0] != ')')
						{
							goto IL_0259;
						}
						goto IL_006E;
						IL_0288:
						if (compositeExpression.Operator == QueryOperator.Or)
						{
							goto IL_01CE;
						}
						num = 27;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
						{
							goto Block_17;
						}
					}
					IL_02D1:
					CompositeExpression compositeExpression2 = new CompositeExpression(QueryOperator.Or);
					goto IL_0028;
					Block_15:
					goto IL_0044;
					Block_19:
					goto IL_0098;
					Block_17:
					goto IL_0201;
					IL_0028:
					if (compositeExpression != null)
					{
						goto IL_01DE;
					}
					num = 45;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_02FB;
					}
					IL_0044:
					if (this.string_0[this.int_0] != '&')
					{
						goto IL_0073;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto IL_006E;
					}
					goto IL_02FB;
					IL_007B:
					obj2 = this.method_7();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_0098;
					}
					goto IL_02FB;
					IL_0073:
					QueryOperator queryOperator = this.method_13();
					goto IL_007B;
					IL_00A5:
					if (this.string_0[this.int_0] == ')')
					{
						goto Block_4;
					}
					if (this.string_0[this.int_0] != '&')
					{
						goto IL_0181;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_00ED;
					}
					goto IL_02FB;
					IL_0098:
					booleanQueryExpression = new BooleanQueryExpression(queryOperator, obj, obj2);
					goto IL_00A5;
					IL_006E:
					queryOperator = QueryOperator.Exists;
					goto IL_0098;
					IL_0111:
					if (compositeExpression.Operator == QueryOperator.And)
					{
						goto IL_0173;
					}
					num = 39;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto Block_12;
					}
					goto IL_02FB;
					IL_00ED:
					if (this.method_12(Class15.smethod_17(1793903034 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a)))
					{
						if (compositeExpression != null)
						{
							goto IL_0111;
						}
					}
					else
					{
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
						{
							goto Block_13;
						}
						goto IL_02FB;
					}
					IL_0121:
					CompositeExpression compositeExpression3 = new CompositeExpression(QueryOperator.And);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_013E;
					}
					goto IL_02FB;
					IL_0154:
					if (queryExpression == null)
					{
						goto IL_016F;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0173;
					}
					goto IL_02FB;
					IL_0150:
					compositeExpression = compositeExpression3;
					goto IL_0154;
					IL_0142:
					compositeExpression.Expressions.Add(compositeExpression3);
					goto IL_0150;
					IL_013E:
					if (compositeExpression != null)
					{
						goto IL_0142;
					}
					goto IL_0150;
					IL_0181:
					if (this.string_0[this.int_0] != '|')
					{
						goto IL_0199;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_01CA;
					}
					goto IL_02FB;
					IL_0173:
					compositeExpression.Expressions.Add(booleanQueryExpression);
					goto IL_0181;
					IL_016F:
					queryExpression = compositeExpression;
					goto IL_0173;
					IL_0199:
					if (this.int_0 >= this.string_0.Length)
					{
						goto IL_040A;
					}
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto IL_0028;
					}
					goto IL_02FB;
					IL_01CE:
					compositeExpression.Expressions.Add(booleanQueryExpression);
					goto IL_0199;
					IL_01CA:
					queryExpression = compositeExpression;
					goto IL_01CE;
					IL_0006:
					if (queryExpression == null)
					{
						goto IL_01CA;
					}
					goto IL_01CE;
					IL_0201:
					compositeExpression = compositeExpression2;
					goto IL_0006;
					IL_01DE:
					compositeExpression.Expressions.Add(compositeExpression2);
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
					{
						goto IL_0201;
					}
					goto IL_02FB;
				}
			}
			Block_4:
			goto IL_03E3;
			Block_12:
			goto IL_03FB;
			Block_13:
			goto IL_0403;
			IL_03E0:
			goto IL_040A;
			IL_03E3:
			if (compositeExpression != null)
			{
				goto IL_03EA;
			}
			return booleanQueryExpression;
			IL_03EA:
			compositeExpression.Expressions.Add(booleanQueryExpression);
			return queryExpression;
			IL_03FB:
			throw this.method_6();
			IL_0403:
			throw this.method_6();
			IL_040A:
			throw new JsonException(Class15.smethod_17(2021162266 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00088B38 File Offset: 0x00086D38
		[NullableContext(2)]
		private bool method_9(out object object_0)
		{
			char c;
			StringBuilder stringBuilder;
			for (;;)
			{
				IL_022C:
				c = this.string_0[this.int_0];
				int num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_00E4;
				}
				do
				{
					IL_019D:
					switch (num)
					{
					case 1:
						goto IL_012D;
					case 2:
					case 4:
						goto IL_004E;
					case 3:
						return false;
					case 5:
						goto IL_0148;
					case 6:
					case 13:
						stringBuilder = new StringBuilder();
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto IL_0036;
						}
						continue;
					case 7:
						return true;
					case 8:
						goto IL_02CA;
					case 9:
						goto IL_0338;
					case 10:
						goto IL_0110;
					case 11:
						goto IL_02BE;
					case 12:
					case 25:
						goto IL_0342;
					case 14:
						goto IL_0283;
					case 15:
						goto IL_007B;
					case 16:
						goto IL_00E4;
					case 17:
						goto IL_022C;
					case 18:
						goto IL_028D;
					case 19:
						goto IL_00C2;
					case 20:
						goto IL_02E2;
					case 21:
						return true;
					case 22:
						return true;
					case 23:
						this.int_0++;
						goto IL_004E;
					case 24:
						goto IL_02D3;
					case 26:
						goto IL_0040;
					case 27:
						goto IL_029E;
					case 28:
						return true;
					case 29:
						return true;
					case 30:
						goto IL_0036;
					case 31:
						goto IL_0006;
					case 32:
						goto IL_031B;
					}
					break;
					IL_004E:
					if (this.int_0 < this.string_0.Length)
					{
						goto IL_007B;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto Block_4;
					}
					continue;
					IL_0040:
					this.int_0++;
					goto IL_004E;
					IL_0036:
					stringBuilder.Append(c);
					goto IL_0040;
					IL_007B:
					c = this.string_0[this.int_0];
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0);
				goto IL_00A3;
				IL_0006:
				if (c == ')')
				{
					break;
				}
				stringBuilder.Append(c);
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto Block_2;
				}
				goto IL_019D;
				IL_00A3:
				if (c != ' ')
				{
					goto IL_0006;
				}
				break;
				IL_00C2:
				object_0 = true;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					goto Block_6;
				}
				goto IL_019D;
				IL_0148:
				if (this.method_12(Class15.smethod_17(768775168 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7)))
				{
					goto IL_00C2;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					goto Block_14;
				}
				goto IL_019D;
				IL_00E4:
				if (c == '\'')
				{
					goto Block_7;
				}
				if (char.IsDigit(c))
				{
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_00A3;
					}
					goto IL_019D;
				}
				IL_0110:
				if (c == '-')
				{
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto Block_11;
					}
					goto IL_019D;
				}
				IL_012D:
				if (c != 't')
				{
					goto IL_0265;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_0148;
				}
				goto IL_019D;
			}
			goto IL_02CA;
			Block_2:
			goto IL_0338;
			Block_4:
			goto IL_0342;
			Block_6:
			return true;
			Block_7:
			goto IL_028D;
			Block_11:
			goto IL_0338;
			Block_14:
			goto IL_0342;
			IL_0265:
			if (c == 'f')
			{
				goto IL_031B;
			}
			if (c == 'n')
			{
				goto IL_029E;
			}
			if (c != '/')
			{
				goto IL_0342;
			}
			IL_0283:
			object_0 = this.method_11();
			return true;
			IL_028D:
			object_0 = this.method_10();
			return true;
			IL_029E:
			if (!this.method_12(Class15.smethod_17(1424584582 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf)))
			{
				goto IL_0342;
			}
			IL_02BE:
			object_0 = null;
			return true;
			IL_02CA:
			string text = stringBuilder.ToString();
			IL_02D3:
			if (text.IndexOfAny(JPath.char_0) == -1)
			{
				long num2;
				bool flag = long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out num2);
				object_0 = num2;
				return flag;
			}
			IL_02E2:
			double num3;
			bool flag2 = double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num3);
			object_0 = num3;
			return flag2;
			IL_031B:
			if (!this.method_12(Class15.smethod_17(698996722 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a)))
			{
				goto IL_0342;
			}
			IL_0338:
			object_0 = false;
			return true;
			IL_0342:
			object_0 = null;
			return false;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00088E8C File Offset: 0x0008708C
		private string method_10()
		{
			StringBuilder stringBuilder;
			char c;
			for (;;)
			{
				IL_02EF:
				stringBuilder = new StringBuilder();
				for (;;)
				{
					IL_02DF:
					this.int_0++;
					while (this.int_0 < this.string_0.Length)
					{
						for (;;)
						{
							IL_02A3:
							c = this.string_0[this.int_0];
							for (;;)
							{
								IL_0297:
								if (c == '\\')
								{
									goto IL_015D;
								}
								goto IL_028B;
								int num;
								for (;;)
								{
									IL_01AC:
									switch (num)
									{
									case 1:
										goto IL_02B9;
									case 2:
									case 15:
									case 16:
									case 17:
									case 19:
									case 40:
										goto IL_003E;
									case 3:
										goto IL_00FB;
									case 4:
										goto IL_00B2;
									case 5:
										goto IL_034F;
									case 6:
										goto IL_01A0;
									case 7:
										this.int_0++;
										num = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
										{
											continue;
										}
										break;
									case 8:
										goto IL_00CF;
									case 9:
									case 13:
										goto IL_008C;
									case 10:
									case 37:
										goto IL_011C;
									case 11:
										goto IL_00DB;
									case 12:
										goto IL_0297;
									case 14:
										goto IL_010D;
									case 18:
										goto IL_0116;
									case 20:
										goto IL_02A3;
									case 21:
										goto IL_02DF;
									case 22:
										goto IL_02EF;
									case 23:
									case 34:
										goto IL_028B;
									case 24:
										goto IL_0145;
									case 25:
										goto IL_003A;
									case 26:
									case 28:
									case 29:
									case 41:
									case 47:
										goto IL_0328;
									case 27:
										goto IL_0104;
									case 30:
										goto IL_015D;
									case 31:
										goto IL_0083;
									case 32:
										goto IL_02F9;
									case 33:
										goto IL_0154;
									case 35:
										goto IL_0092;
									case 36:
										goto IL_0070;
									case 39:
										goto IL_0125;
									case 42:
										goto IL_0309;
									case 43:
										goto IL_00D5;
									case 44:
										goto IL_0062;
									case 46:
										goto IL_002E;
									}
									goto Block_15;
								}
								IL_0154:
								char c2 = '\f';
								goto IL_003E;
								IL_01A0:
								if (c != 'f')
								{
									goto Block_14;
								}
								goto IL_0154;
								IL_028B:
								if (c == '\'')
								{
									num = 17;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
									{
										goto Block_16;
									}
									goto IL_01AC;
								}
								else
								{
									this.int_0++;
									num = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
									{
										goto Block_1;
									}
									goto IL_01AC;
								}
								IL_015D:
								if (this.int_0 + 1 >= this.string_0.Length)
								{
									goto IL_028B;
								}
								goto IL_0062;
								IL_003E:
								stringBuilder.Append(c2);
								num = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
								{
									goto Block_3;
								}
								goto IL_01AC;
								IL_003A:
								c2 = c;
								goto IL_003E;
								IL_011C:
								if (c != '/')
								{
									goto IL_0125;
								}
								goto IL_003A;
								IL_0116:
								if (c > '\'')
								{
									goto IL_011C;
								}
								goto IL_0145;
								IL_0083:
								if (c > '\\')
								{
									goto IL_008C;
								}
								goto IL_0116;
								IL_0070:
								c = this.string_0[this.int_0];
								goto IL_0083;
								IL_0062:
								this.int_0++;
								goto IL_0070;
								IL_002E:
								if (c != '\'')
								{
									goto Block_2;
								}
								goto IL_003A;
								IL_0092:
								if (c == 'b')
								{
									goto IL_00B2;
								}
								num = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
								{
									goto Block_5;
								}
								goto IL_01AC;
								IL_008C:
								if (c <= 'f')
								{
									goto IL_0092;
								}
								goto IL_00CF;
								IL_00B2:
								c2 = '\b';
								num = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
								{
									goto IL_003E;
								}
								goto IL_01AC;
								IL_00DB:
								if (c == 't')
								{
									goto IL_00FB;
								}
								num = 29;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
								{
									goto IL_003E;
								}
								goto IL_01AC;
								IL_00D5:
								if (c != 'r')
								{
									goto IL_00DB;
								}
								goto IL_0104;
								IL_00CF:
								if (c != 'n')
								{
									goto IL_00D5;
								}
								goto IL_010D;
								IL_00FB:
								c2 = '\t';
								goto IL_003E;
								IL_0104:
								c2 = '\r';
								goto IL_003E;
								IL_010D:
								c2 = '\n';
								goto IL_003E;
								IL_0125:
								if (c == '\\')
								{
									goto IL_003A;
								}
								num = 4;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
								{
									goto Block_10;
								}
								goto IL_01AC;
								IL_0145:
								if (c != '"')
								{
									goto IL_002E;
								}
								goto IL_003A;
							}
						}
						Block_3:
						Block_15:
						continue;
						IL_02B9:
						stringBuilder.Append(c);
						continue;
						Block_1:
						goto IL_02B9;
					}
					goto Block_19;
				}
			}
			Block_2:
			goto IL_0328;
			Block_5:
			goto IL_034F;
			Block_10:
			Block_14:
			goto IL_0328;
			Block_16:
			goto IL_02F9;
			Block_19:
			goto IL_0309;
			IL_02F9:
			this.int_0++;
			goto IL_034F;
			IL_0309:
			throw new JsonException(Class15.smethod_17(635791559 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
			IL_0328:
			throw new JsonException(Class15.smethod_17(613130303 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6) + c.ToString());
			IL_034F:
			return stringBuilder.ToString();
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000891F0 File Offset: 0x000873F0
		private string method_11()
		{
			int num;
			for (;;)
			{
				IL_01C8:
				num = this.int_0;
				int num2 = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_0124;
				}
				for (;;)
				{
					IL_0168:
					switch (num2)
					{
					case 1:
					case 7:
					case 11:
						goto IL_00FC;
					case 2:
						goto IL_0124;
					case 3:
					case 13:
						goto IL_0088;
					case 4:
					case 6:
						goto IL_009C;
					case 5:
					case 18:
						goto IL_00B2;
					case 8:
						goto IL_01E7;
					case 9:
						this.int_0++;
						num2 = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
						{
							continue;
						}
						goto IL_01C7;
					case 10:
						goto IL_01C8;
					case 12:
						goto IL_005C;
					case 14:
						goto IL_008E;
					case 15:
						goto IL_0202;
					case 16:
						goto IL_0056;
					case 19:
						goto IL_0118;
					case 20:
						goto IL_0006;
					}
					goto Block_6;
				}
				IL_01C7:
				continue;
				IL_0118:
				char c;
				if (char.IsLetter(c))
				{
					goto IL_0124;
				}
				goto IL_0202;
				Block_6:
				IL_002E:
				c = this.string_0[this.int_0];
				num2 = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_0056;
				}
				goto IL_0168;
				IL_005C:
				if (this.int_0 + 1 < this.string_0.Length)
				{
					goto IL_0006;
				}
				num2 = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_00FC;
				}
				goto IL_0168;
				IL_0056:
				if (c == '\\')
				{
					goto IL_005C;
				}
				goto IL_0088;
				IL_00B2:
				c = this.string_0[this.int_0];
				num2 = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					goto IL_00FC;
				}
				goto IL_0168;
				IL_009C:
				if (this.int_0 < this.string_0.Length)
				{
					goto IL_00B2;
				}
				goto IL_0202;
				IL_008E:
				this.int_0++;
				goto IL_009C;
				IL_0088:
				if (c == '/')
				{
					goto IL_008E;
				}
				this.int_0++;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0168;
				}
				IL_00FC:
				if (this.int_0 >= this.string_0.Length)
				{
					break;
				}
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_002E;
				}
				goto IL_0168;
				IL_0006:
				this.int_0 += 2;
				goto IL_00FC;
				IL_0124:
				this.int_0++;
				num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_009C;
				}
				goto IL_0168;
			}
			IL_01E7:
			throw new JsonException(Class15.smethod_17(2021162050 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
			IL_0202:
			return this.string_0.Substring(num, this.int_0 - num);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00089418 File Offset: 0x00087618
		private bool method_12(string string_1)
		{
			for (;;)
			{
				IL_00E3:
				int num = this.int_0;
				int num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					break;
				}
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_0039;
					case 1:
						return true;
					case 2:
						if (this.string_0[num] != string_1[num3])
						{
							return false;
						}
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0060;
						}
						continue;
					case 3:
						goto IL_0078;
					case 4:
						goto IL_00E3;
					case 5:
						return false;
					case 6:
						goto IL_0060;
					case 7:
						num3++;
						goto IL_0006;
					case 8:
					case 11:
						goto IL_0006;
					case 9:
					case 10:
						break;
					default:
						goto IL_0039;
					}
					IL_0010:
					if (num >= this.string_0.Length)
					{
						return false;
					}
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto Block_2;
					}
					continue;
					IL_0006:
					if (num3 < string_1.Length)
					{
						goto IL_0010;
					}
					IL_0039:
					this.int_0 = num;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto Block_3;
					}
					continue;
					IL_0060:
					num++;
					num2 = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						continue;
					}
					IL_0078:
					num3 = 0;
					goto IL_0006;
				}
			}
			Block_2:
			Block_3:
			return true;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0008952C File Offset: 0x0008772C
		private QueryOperator method_13()
		{
			IL_0224:
			while (this.int_0 + 1 < this.string_0.Length)
			{
				IL_0204:
				while (!this.method_12(Class15.smethod_17(538794533 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa)))
				{
					for (;;)
					{
						int num;
						if (this.method_12(Class15.smethod_17(314823213 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927)))
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
							{
								break;
							}
						}
						else
						{
							if (this.method_12(Class15.smethod_17(486474062 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)))
							{
								return QueryOperator.RegexEquals;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
							{
								goto IL_003B;
							}
						}
						IL_016E:
						switch (num)
						{
						case 1:
							goto IL_00DA;
						case 2:
							continue;
						case 3:
							return QueryOperator.NotEquals;
						case 4:
							return QueryOperator.Equals;
						case 5:
							goto IL_00FA;
						case 6:
							return QueryOperator.StrictNotEquals;
						case 7:
							goto IL_011A;
						case 8:
							return QueryOperator.RegexEquals;
						case 9:
							goto IL_026D;
						case 10:
							return QueryOperator.LessThanOrEquals;
						case 11:
							goto IL_00A5;
						case 12:
							goto IL_0204;
						case 13:
							goto IL_0224;
						case 14:
							goto IL_013A;
						case 15:
							return QueryOperator.LessThan;
						case 16:
							goto IL_023F;
						case 17:
							return QueryOperator.GreaterThan;
						case 18:
							return QueryOperator.StrictEquals;
						case 19:
							IL_003B:
							if (this.method_12(Class15.smethod_17(538794563 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa)))
							{
								return QueryOperator.StrictNotEquals;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
							{
								goto IL_016E;
							}
							break;
						case 20:
							return QueryOperator.GreaterThanOrEquals;
						}
						if (this.method_12(Class15.smethod_17(642183880 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba)))
						{
							return QueryOperator.NotEquals;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
						{
							goto IL_016E;
						}
						IL_00A5:
						if (this.method_12(Class15.smethod_17(41464519 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d)))
						{
							return QueryOperator.NotEquals;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
						{
							goto IL_00DA;
						}
						goto IL_016E;
						IL_013A:
						if (this.method_12(Class15.smethod_17(676678170 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b)))
						{
							return QueryOperator.GreaterThan;
						}
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
						{
							goto IL_016E;
						}
						goto IL_025A;
						IL_011A:
						if (!this.method_12(Class15.smethod_17(613131069 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6)))
						{
							goto IL_013A;
						}
						return QueryOperator.GreaterThanOrEquals;
						IL_00FA:
						if (!this.method_12(Class15.smethod_17(2060629890 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177)))
						{
							goto IL_011A;
						}
						return QueryOperator.LessThan;
						IL_00DA:
						if (!this.method_12(Class15.smethod_17(642183896 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba)))
						{
							goto IL_00FA;
						}
						return QueryOperator.LessThanOrEquals;
					}
					return QueryOperator.Equals;
					IL_023F:
					throw new JsonException(Class15.smethod_17(543270742 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
					IL_025A:
					return QueryOperator.LessThanOrEquals;
				}
				return QueryOperator.StrictEquals;
			}
			IL_026D:
			throw new JsonException(Class15.smethod_17(486474696 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000897C4 File Offset: 0x000879C4
		private PathFilter method_14(char char_1, bool bool_0)
		{
			List<string> list;
			string text;
			for (;;)
			{
				IL_0141:
				list = null;
				IL_012B:
				while (this.int_0 < this.string_0.Length)
				{
					for (;;)
					{
						IL_0111:
						text = this.method_10();
						for (;;)
						{
							IL_00F4:
							this.iHgHyFiPtt();
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
							{
								goto IL_001F;
							}
							for (;;)
							{
								IL_009C:
								switch (num)
								{
								case 1:
									goto IL_001F;
								case 2:
								case 9:
									goto IL_0122;
								case 3:
									goto IL_0182;
								case 4:
									goto IL_014A;
								case 5:
									goto IL_0153;
								case 6:
								case 8:
									goto IL_012B;
								case 7:
									goto IL_0141;
								case 10:
									goto IL_015E;
								case 11:
									goto IL_0167;
								case 12:
									goto IL_003A;
								case 13:
									goto IL_0156;
								case 14:
									goto IL_00F4;
								case 15:
									goto IL_006C;
								case 16:
									this.iHgHyFiPtt();
									goto IL_0006;
								case 17:
									goto IL_0146;
								case 18:
									goto IL_0006;
								case 19:
									goto IL_0111;
								}
								goto Block_4;
								IL_0006:
								if (list == null)
								{
									goto IL_011B;
								}
								num = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
								{
									goto IL_001F;
								}
							}
							IL_006C:
							this.int_0++;
							num = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
							{
								goto Block_3;
							}
							goto IL_009C;
							IL_003A:
							if (this.string_0[this.int_0] == char_1)
							{
								goto Block_2;
							}
							if (this.string_0[this.int_0] == ',')
							{
								goto IL_006C;
							}
							goto IL_0182;
							IL_001F:
							this.method_15(Class15.smethod_17(1802328627 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
							goto IL_003A;
						}
					}
					IL_0122:
					list.Add(text);
					continue;
					IL_011B:
					list = new List<string>();
					goto IL_0122;
					Block_4:
					goto IL_011B;
				}
				goto Block_6;
			}
			Block_2:
			goto IL_0146;
			Block_3:
			Block_6:
			goto IL_0167;
			IL_0146:
			if (list == null)
			{
				return JPath.smethod_0(text, bool_0);
			}
			IL_014A:
			list.Add(text);
			IL_0153:
			if (!bool_0)
			{
				goto IL_015E;
			}
			IL_0156:
			return new ScanMultipleFilter(list);
			IL_015E:
			return new FieldMultipleFilter(list);
			IL_0167:
			throw new JsonException(Class15.smethod_17(486476954 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
			IL_0182:
			throw new JsonException(Class15.smethod_17(1953630643 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f) + this.string_0[this.int_0].ToString());
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00089998 File Offset: 0x00087B98
		private void method_15(string string_1)
		{
			while (this.int_0 >= this.string_0.Length)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw new JsonException(string_1);
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000068E7 File Offset: 0x00004AE7
		internal IEnumerable<JToken> Evaluate(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			return JPath.Evaluate(this.Filters, root, t, settings);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000899E8 File Offset: 0x00087BE8
		internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			IEnumerable<JToken> enumerable = new JToken[] { t };
			foreach (PathFilter pathFilter in filters)
			{
				enumerable = pathFilter.ExecuteFilter(root, enumerable, settings);
			}
			return enumerable;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00089A44 File Offset: 0x00087C44
		static JPath()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_002D;
				}
				IL_0030:
				switch (num)
				{
				case 1:
					IL_002D:
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				JPath.char_0 = new char[] { '.', 'E', 'e' };
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					break;
				}
				goto IL_0030;
			}
		}

		// Token: 0x04000799 RID: 1945
		private static readonly char[] char_0;

		// Token: 0x0400079A RID: 1946
		private readonly string string_0;

		// Token: 0x0400079B RID: 1947
		[CompilerGenerated]
		private readonly List<PathFilter> list_0;

		// Token: 0x0400079C RID: 1948
		private int int_0;
	}
}
