using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BE RID: 190
	[Nullable(0)]
	[NullableContext(1)]
	internal static class JavaScriptUtils
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0004CD18 File Offset: 0x0004AF18
		static JavaScriptUtils()
		{
			for (;;)
			{
				IL_02E5:
				for (;;)
				{
					IL_02D0:
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto Block_7;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_01BE;
						case 1:
							goto IL_0231;
						case 2:
							return;
						case 3:
						case 18:
							goto IL_01DD;
						case 4:
							goto IL_0268;
						case 5:
							break;
						case 6:
							JavaScriptUtils.SingleQuoteCharEscapeFlags = new bool[128];
							goto IL_0268;
						case 7:
							goto IL_00CA;
						case 8:
						case 9:
							goto IL_019F;
						case 10:
							goto IL_001F;
						case 11:
							goto IL_00B1;
						case 12:
							goto IL_02D0;
						case 13:
							goto IL_02E5;
						case 14:
							goto IL_0236;
						case 15:
							goto IL_02EE;
						case 16:
							goto IL_0006;
						case 17:
							goto IL_01E9;
						default:
							goto IL_01BE;
						}
						IL_016B:
						IList<char> list;
						IEnumerator<char> enumerator = list.Union(new char[] { '"', '\'', '<', '>', '&' }).GetEnumerator();
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto IL_019F;
						}
						continue;
						IL_00CA:
						try
						{
							while (enumerator.MoveNext())
							{
								for (;;)
								{
									char c = enumerator.Current;
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
									{
										goto IL_00CE;
									}
									IL_00E8:
									switch (num2)
									{
									case 1:
										IL_00CE:
										JavaScriptUtils.DoubleQuoteCharEscapeFlags[(int)c] = true;
										num2 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
										{
											goto IL_00E8;
										}
										break;
									case 2:
										goto IL_0127;
									case 3:
										continue;
									}
									break;
								}
							}
							IL_0127:;
						}
						finally
						{
							if (enumerator != null)
							{
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
								{
									goto IL_015A;
								}
								do
								{
									IL_013F:
									enumerator.Dispose();
									num3 = 1;
								}
								while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0);
								IL_015A:
								switch (num3)
								{
								case 0:
									goto IL_013F;
								case 1:
									break;
								default:
									goto IL_013F;
								}
							}
						}
						goto IL_016B;
						IL_00B1:
						enumerator = list.Union(new char[] { '"' }).GetEnumerator();
						goto IL_00CA;
						IL_001F:
						try
						{
							for (;;)
							{
								if (enumerator.MoveNext())
								{
									goto IL_0023;
								}
								int num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
								{
									break;
								}
								switch (num4)
								{
								case 0:
									goto IL_0023;
								case 1:
									goto IL_006D;
								case 2:
									break;
								case 3:
									continue;
								default:
									goto IL_0023;
								}
								IL_002C:
								char c2;
								JavaScriptUtils.SingleQuoteCharEscapeFlags[(int)c2] = true;
								continue;
								IL_0023:
								c2 = enumerator.Current;
								goto IL_002C;
							}
							IL_006D:;
						}
						finally
						{
							if (enumerator != null)
							{
								int num5 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
								{
									for (;;)
									{
										switch (num5)
										{
										case 1:
											enumerator.Dispose();
											num5 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
											{
												continue;
											}
											break;
										}
										break;
									}
								}
							}
						}
						goto IL_00B1;
						IL_0006:
						enumerator = list.Union(new char[] { '\'' }).GetEnumerator();
						goto IL_001F;
						IL_01DD:
						int num6;
						if (num6 >= 32)
						{
							goto IL_0006;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							goto IL_019F;
						}
						continue;
						IL_01BE:
						num6++;
						goto IL_01DD;
						IL_019F:
						list.Add((char)num6);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_01BE;
						}
						continue;
						IL_01E9:
						list = new List<char> { '\n', '\r', '\t', '\\', '\f', '\b' };
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
						{
							goto IL_0231;
						}
						continue;
						IL_0236:
						JavaScriptUtils.HtmlCharEscapeFlags = new bool[128];
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto IL_01E9;
						}
						continue;
						IL_0268:
						JavaScriptUtils.DoubleQuoteCharEscapeFlags = new bool[128];
						goto IL_0236;
						IL_0231:
						num6 = 0;
						goto IL_01DD;
					}
				}
			}
			Block_7:
			return;
			IL_02EE:
			try
			{
				for (;;)
				{
					IEnumerator<char> enumerator;
					if (enumerator.MoveNext())
					{
						goto IL_0324;
					}
					int num7 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						break;
					}
					IL_030C:
					char c3;
					switch (num7)
					{
					case 1:
						continue;
					case 2:
						goto IL_02F2;
					case 3:
						IL_0324:
						c3 = enumerator.Current;
						num7 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto IL_02F2;
						}
						goto IL_030C;
					}
					break;
					IL_02F2:
					JavaScriptUtils.HtmlCharEscapeFlags[(int)c3] = true;
					num7 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_030C;
					}
				}
			}
			finally
			{
				IEnumerator<char> enumerator;
				if (enumerator != null)
				{
					int num8 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_0395;
					}
					IL_037D:
					enumerator.Dispose();
					num8 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_03A6;
					}
					IL_0395:
					switch (num8)
					{
					case 0:
						goto IL_037D;
					case 1:
						break;
					default:
						goto IL_037D;
					}
				}
				IL_03A6:;
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			for (;;)
			{
				int num;
				if (stringEscapeHandling == StringEscapeHandling.EscapeHtml)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto Block_3;
					}
				}
				else
				{
					if (quoteChar != '"')
					{
						goto IL_0056;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					goto IL_0049;
				case 2:
					continue;
				}
				break;
			}
			goto IL_0050;
			Block_3:
			IL_0049:
			return JavaScriptUtils.HtmlCharEscapeFlags;
			IL_0050:
			return JavaScriptUtils.DoubleQuoteCharEscapeFlags;
			IL_0056:
			return JavaScriptUtils.SingleQuoteCharEscapeFlags;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0004D15C File Offset: 0x0004B35C
		public static bool ShouldEscapeJavaScriptString([Nullable(2)] string s, bool[] charEscapeFlags)
		{
			IL_0099:
			while (s != null)
			{
				for (;;)
				{
					IL_0094:
					int i = 0;
					IL_0087:
					while (i < s.Length)
					{
						for (;;)
						{
							IL_0074:
							char c = s[i];
							IL_0069:
							while ((int)c < charEscapeFlags.Length)
							{
								int num = 10;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
								{
									goto IL_0074;
								}
								for (;;)
								{
									switch (num)
									{
									case 1:
										return false;
									case 2:
									case 3:
										goto IL_0074;
									case 4:
										goto IL_0069;
									case 5:
										goto IL_0081;
									case 6:
										goto IL_0094;
									case 7:
										goto IL_0099;
									case 8:
										return false;
									case 9:
									case 11:
										goto IL_0087;
									case 10:
										if (!charEscapeFlags[(int)c])
										{
											num = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
											{
												continue;
											}
											goto IL_0080;
										}
										break;
									}
									return true;
								}
							}
							return true;
						}
						IL_0081:
						i++;
						continue;
						IL_0080:
						goto IL_0081;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0004D210 File Offset: 0x0004B410
		[NullableContext(2)]
		public static void WriteEscapedJavaScriptString([Nullable(1)] TextWriter writer, string s, char delimiter, bool appendDelimiters, [Nullable(1)] bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			if (!StringUtils.IsNullOrEmpty(s))
			{
				int num = JavaScriptUtils.smethod_0(s, charEscapeFlags, stringEscapeHandling);
				if (num == -1)
				{
					writer.Write(s);
				}
				else
				{
					if (num != 0)
					{
						if (writeBuffer == null || writeBuffer.Length < num)
						{
							writeBuffer = BufferUtils.EnsureBufferSize(bufferPool, num, writeBuffer);
						}
						s.CopyTo(0, writeBuffer, 0, num);
						writer.Write(writeBuffer, 0, num);
					}
					int num2;
					for (int i = num; i < s.Length; i++)
					{
						char c = s[i];
						if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
						{
							string text;
							if (c <= '\\')
							{
								switch (c)
								{
								case '\b':
									text = Class15.smethod_17(1387490708 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
									break;
								case '\t':
									text = Class15.smethod_17(552199386 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f);
									break;
								case '\n':
									text = Class15.smethod_17(2128233454 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
									break;
								case '\v':
									goto IL_0180;
								case '\f':
									text = Class15.smethod_17(2071421702 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
									break;
								case '\r':
									text = Class15.smethod_17(698979550 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
									break;
								default:
									if (c != '\\')
									{
										goto IL_0180;
									}
									text = Class15.smethod_17(432133413 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2);
									break;
								}
							}
							else if (c != '\u0085')
							{
								if (c != '\u2028')
								{
									if (c != '\u2029')
									{
										goto IL_0180;
									}
									text = Class15.smethod_17(1829631961 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
								}
								else
								{
									text = Class15.smethod_17(1243275756 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95);
								}
							}
							else
							{
								text = Class15.smethod_17(564912846 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610);
							}
							IL_0269:
							if (text == null)
							{
								goto IL_031B;
							}
							bool flag = string.Equals(text, Class15.smethod_17(1807897914 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), StringComparison.Ordinal);
							if (i > num)
							{
								num2 = i - num + (flag ? 6 : 0);
								int num3 = (flag ? 6 : 0);
								if (writeBuffer == null || writeBuffer.Length < num2)
								{
									char[] array = BufferUtils.RentBuffer(bufferPool, num2);
									if (flag)
									{
										Array.Copy(writeBuffer, array, 6);
									}
									BufferUtils.ReturnBuffer(bufferPool, writeBuffer);
									writeBuffer = array;
								}
								s.CopyTo(num, writeBuffer, num3, num2 - num3);
								writer.Write(writeBuffer, num3, num2 - num3);
							}
							num = i + 1;
							if (!flag)
							{
								writer.Write(text);
								goto IL_031B;
							}
							writer.Write(writeBuffer, 0, 6);
							goto IL_031B;
							IL_0180:
							if ((int)c >= charEscapeFlags.Length)
							{
								if (stringEscapeHandling != StringEscapeHandling.EscapeNonAscii)
								{
									text = null;
									goto IL_0269;
								}
							}
							if (c == '\'' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
							{
								text = Class15.smethod_17(538830193 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa);
								goto IL_0269;
							}
							if (c == '"' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
							{
								text = Class15.smethod_17(768792440 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
								goto IL_0269;
							}
							if (writeBuffer == null || writeBuffer.Length < 6)
							{
								writeBuffer = BufferUtils.EnsureBufferSize(bufferPool, 6, writeBuffer);
							}
							StringUtils.ToCharAsUnicode(c, writeBuffer);
							text = Class15.smethod_17(2128233334 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9);
							goto IL_0269;
						}
						IL_031B:;
					}
					num2 = s.Length - num;
					if (num2 > 0)
					{
						if (writeBuffer == null || writeBuffer.Length < num2)
						{
							writeBuffer = BufferUtils.EnsureBufferSize(bufferPool, num2, writeBuffer);
						}
						s.CopyTo(num, writeBuffer, 0, num2);
						writer.Write(writeBuffer, 0, num2);
					}
				}
			}
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0004D594 File Offset: 0x0004B794
		public static string ToEscapedJavaScriptString([Nullable(2)] string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			bool[] charEscapeFlags;
			string text;
			for (;;)
			{
				charEscapeFlags = JavaScriptUtils.GetCharEscapeFlags(stringEscapeHandling, delimiter);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_0003;
				}
				IL_0017:
				switch (num)
				{
				case 1:
					IL_0003:
					if (value == null)
					{
						goto IL_005D;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_0017;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0066;
				case 4:
					goto IL_005D;
				case 5:
					return text;
				}
				break;
			}
			int num2 = value.Length;
			goto IL_005F;
			IL_005D:
			num2 = 16;
			IL_005F:
			StringWriter stringWriter = StringUtils.CreateStringWriter(num2);
			IL_0066:
			try
			{
				char[] array = null;
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_0099;
				}
				goto IL_00AB;
				IL_007E:
				text = stringWriter.ToString();
				num3 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_00AB;
				}
				IL_0099:
				JavaScriptUtils.WriteEscapedJavaScriptString(stringWriter, value, delimiter, appendDelimiters, charEscapeFlags, stringEscapeHandling, null, ref array);
				goto IL_007E;
				IL_00AB:
				switch (num3)
				{
				case 0:
					goto IL_0099;
				case 1:
					break;
				case 2:
					goto IL_007E;
				default:
					goto IL_0099;
				}
			}
			finally
			{
				if (stringWriter != null)
				{
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_00F2;
					}
					do
					{
						IL_00D7:
						((IDisposable)stringWriter).Dispose();
						num4 = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0);
					IL_00F2:
					switch (num4)
					{
					case 0:
						goto IL_00D7;
					case 1:
						break;
					default:
						goto IL_00D7;
					}
				}
			}
			return text;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		private static int smethod_0(string string_0, object object_0, StringEscapeHandling stringEscapeHandling_0)
		{
			int num;
			for (;;)
			{
				IL_00F6:
				num = 0;
				IL_00E9:
				while (num != string_0.Length)
				{
					for (;;)
					{
						char c = string_0[num];
						int num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
						{
							goto IL_005C;
						}
						IL_008B:
						switch (num2)
						{
						case 0:
							goto IL_0075;
						case 1:
							goto IL_0024;
						case 2:
							IL_005C:
							if ((int)c < object_0.Length)
							{
								goto IL_0050;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
							{
								goto IL_0075;
							}
							goto IL_008B;
						case 3:
							return num;
						case 4:
							return num;
						case 5:
							goto IL_0050;
						case 6:
							return -1;
						case 7:
							return num;
						case 8:
						case 12:
							goto IL_00E9;
						case 9:
							goto IL_00F6;
						case 10:
							continue;
						case 11:
							break;
						default:
							goto IL_0075;
						}
						IL_0006:
						if (c == '\u2028')
						{
							return num;
						}
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_0024;
						}
						goto IL_008B;
						IL_0075:
						if (stringEscapeHandling_0 == StringEscapeHandling.EscapeNonAscii)
						{
							goto Block_6;
						}
						if (c != '\u0085')
						{
							goto IL_0006;
						}
						return num;
						IL_0033:
						num++;
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
						{
							break;
						}
						goto IL_008B;
						IL_0050:
						if (object_0[(int)c])
						{
							goto Block_4;
						}
						goto IL_0033;
						IL_0024:
						if (c == '\u2029')
						{
							goto Block_2;
						}
						goto IL_0033;
					}
				}
				goto Block_10;
			}
			Block_2:
			return num;
			Block_4:
			return num;
			Block_6:
			return num;
			Block_10:
			return -1;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0004D7CC File Offset: 0x0004B9CC
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [Nullable(2)] [NotNullWhen(false)] out string errorMessage)
		{
			long? num;
			for (;;)
			{
				IL_0241:
				dateTime = default(DateTime);
				for (;;)
				{
					IL_023C:
					errorMessage = null;
					for (;;)
					{
						if (JavaScriptUtils.smethod_1(reader, out num, out errorMessage))
						{
							goto IL_0108;
						}
						goto IL_0006;
						IL_01B8:
						int num2;
						switch (num2)
						{
						case 1:
						case 8:
							return true;
						case 2:
							return false;
						case 3:
							goto IL_0108;
						case 4:
							goto IL_0060;
						case 5:
							return false;
						case 6:
						case 21:
							goto IL_00DE;
						case 7:
						case 13:
							goto IL_0141;
						case 9:
							goto IL_00B1;
						case 10:
						case 15:
							goto IL_0254;
						case 11:
							goto IL_0131;
						case 12:
							goto IL_00A3;
						case 14:
							goto IL_014B;
						case 16:
							goto IL_0006;
						case 17:
							goto IL_00BD;
						case 18:
							goto IL_023C;
						case 19:
							goto IL_0241;
						case 20:
						case 22:
							goto IL_00F8;
						case 23:
							continue;
						case 24:
							goto IL_003D;
						case 25:
							return false;
						}
						return false;
						IL_0006:
						errorMessage = errorMessage ?? Class15.smethod_17(2008575935 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							return false;
						}
						goto IL_01B8;
						IL_0108:
						if (num == null)
						{
							goto IL_0006;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_00A3;
						}
						goto IL_01B8;
						IL_003D:
						List<long> list;
						long? num3;
						list.Add(num3.Value);
						num2 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto IL_0060;
						}
						goto IL_01B8;
						IL_00DE:
						if (!JavaScriptUtils.smethod_1(reader, out num3, out errorMessage))
						{
							return false;
						}
						if (num3 == null)
						{
							goto IL_00F8;
						}
						goto IL_003D;
						IL_00BD:
						long? num4;
						list = new List<long> { num.Value, num4.Value };
						goto IL_00DE;
						IL_00B1:
						if (num4 != null)
						{
							goto IL_00BD;
						}
						goto IL_0254;
						IL_00A3:
						if (JavaScriptUtils.smethod_1(reader, out num4, out errorMessage))
						{
							goto IL_00B1;
						}
						return false;
						IL_0060:
						errorMessage = Class15.smethod_17(1176445818 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
						num2 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto IL_0108;
						}
						goto IL_01B8;
						IL_00F8:
						if (list.Count > 7)
						{
							goto IL_0060;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto IL_0141;
						}
						goto IL_01B8;
						IL_014B:
						dateTime = new DateTime((int)list[0], (int)list[1] + 1, (list[2] != 0L) ? ((int)list[2]) : 1, (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
						{
							goto IL_01B8;
						}
						goto IL_024F;
						IL_0141:
						if (list.Count >= 7)
						{
							goto IL_014B;
						}
						IL_0131:
						list.Add(0L);
						goto IL_0141;
					}
				}
			}
			return false;
			IL_024F:
			return true;
			IL_0254:
			dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(num.Value);
			return true;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0004DA44 File Offset: 0x0004BC44
		private static bool smethod_1(JsonReader jsonReader_0, out long? nullable_0, [NotNullWhen(false)] [Nullable(2)] out string errorMessage)
		{
			for (;;)
			{
				nullable_0 = null;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0055;
				}
				goto IL_00B1;
				do
				{
					IL_006C:
					errorMessage = Class15.smethod_17(299928001 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e) + jsonReader_0.TokenType.ToString();
					num = 7;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0);
				IL_00B1:
				switch (num)
				{
				case 0:
					goto IL_0055;
				case 1:
					continue;
				case 2:
					return true;
				case 3:
					goto IL_0102;
				case 4:
					goto IL_006C;
				case 5:
					return true;
				case 6:
					break;
				case 7:
					return false;
				case 8:
					return false;
				default:
					goto IL_0055;
				}
				IL_0006:
				if (!jsonReader_0.Read())
				{
					goto IL_0102;
				}
				if (jsonReader_0.TokenType == JsonToken.EndConstructor)
				{
					break;
				}
				if (jsonReader_0.TokenType != JsonToken.Integer)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_006C;
					}
					goto IL_00B1;
				}
				else
				{
					nullable_0 = new long?((long)jsonReader_0.Value);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_00B1;
					}
				}
				IL_0055:
				errorMessage = null;
				goto IL_0006;
			}
			return true;
			IL_0102:
			errorMessage = Class15.smethod_17(676722212 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b);
			return false;
		}

		// Token: 0x0400045A RID: 1114
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x0400045B RID: 1115
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x0400045C RID: 1116
		internal static readonly bool[] HtmlCharEscapeFlags;
	}
}
