using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000069 RID: 105
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x0002F5D8 File Offset: 0x0002D7D8
		public JsonTextReader(TextReader reader)
		{
			while (reader != null)
			{
				this.CqAbwNtqvn = reader;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0023;
				}
				IL_003B:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_005C:
					throw new ArgumentNullException(Class15.smethod_17(649962494 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
				case 3:
					continue;
				}
				IL_0023:
				this.int_3 = 1;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_003B;
				}
				return;
			}
			goto IL_005C;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000030B2 File Offset: 0x000012B2
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0002F65C File Offset: 0x0002D85C
		[Nullable(2)]
		public JsonNameTable PropertyNameTable
		{
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return this.jsonNameTable_0;
			}
			[CompilerGenerated]
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.jsonNameTable_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
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
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000030BA File Offset: 0x000012BA
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x000030C2 File Offset: 0x000012C2
		[Nullable(2)]
		public IArrayPool<char> ArrayPool
		{
			[NullableContext(2)]
			get
			{
				return this.iarrayPool_0;
			}
			[NullableContext(2)]
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException(Class15.smethod_17(1743160350 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8));
				}
				this.iarrayPool_0 = value;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0002F694 File Offset: 0x0002D894
		private void method_9()
		{
			while (this.stringBuffer_0.IsEmpty)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_0015;
				}
				IL_003C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0015:
				this.stringBuffer_0 = new StringBuffer(this.iarrayPool_0, 1024);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					goto IL_003C;
				}
				break;
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0002F704 File Offset: 0x0002D904
		private void method_10(bool bool_4)
		{
			for (;;)
			{
				if (bool_4)
				{
					goto IL_006A;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_0023;
				}
				do
				{
					IL_0006:
					this.method_11(this.int_1);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0);
				IL_0023:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_0006;
				case 1:
					break;
				case 2:
					return;
				case 3:
					IL_006A:
					if (this.char_0[this.int_1] != '\n')
					{
						goto IL_0006;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_0023;
					}
					break;
				case 5:
					this.int_1++;
					goto IL_0006;
				default:
					goto IL_0006;
				}
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0002F7B0 File Offset: 0x0002D9B0
		private void method_11(int int_4)
		{
			for (;;)
			{
				this.int_3++;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.int_2 = int_4;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_001B;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0002F810 File Offset: 0x0002DA10
		private void method_12(char char_1, ReadType readType_0)
		{
			for (;;)
			{
				this.int_1++;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_0003;
				}
				IL_0033:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_14();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0033;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0072;
				case 4:
					return;
				}
				this.method_30(char_1);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0033;
				}
				break;
			}
			IL_0072:
			this.method_13(char_1, readType_0);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0002F898 File Offset: 0x0002DA98
		private void method_13(char char_1, ReadType readType_0)
		{
			byte[] array;
			Guid guid;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				IL_0309:
				base.SetPostValueState(true);
				for (;;)
				{
					IL_02DA:
					int num;
					string text;
					switch (readType_0)
					{
					case ReadType.const_1:
					case ReadType.ReadAsDecimal:
					case ReadType.ReadAsBoolean:
						return;
					case ReadType.const_2:
					case ReadType.ReadAsDateTime:
					case ReadType.ReadAsDateTimeOffset:
					case ReadType.ReadAsDouble:
						goto IL_029C;
					case ReadType.ReadAsBytes:
						IL_0051:
						if (this.stringReference_0.Length == 0)
						{
							goto IL_0078;
						}
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
						{
							continue;
						}
						goto IL_01DB;
					case ReadType.ReadAsString:
						text = this.stringReference_0.ToString();
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_00FE;
						}
						goto IL_01DB;
					default:
						goto IL_029C;
					}
					DateParseHandling dateParseHandling;
					do
					{
						IL_01AA:
						dateParseHandling = DateParseHandling.DateTimeOffset;
						num = 25;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0);
					for (;;)
					{
						IL_01DB:
						switch (num)
						{
						case 1:
							goto IL_0336;
						case 2:
						case 4:
						case 25:
							goto IL_000E;
						case 3:
							goto IL_0078;
						case 5:
							goto IL_0006;
						case 6:
						case 16:
						case 30:
							goto IL_0328;
						case 7:
							goto IL_02DA;
						case 8:
							goto IL_0309;
						case 9:
							goto IL_00D4;
						case 10:
							goto IL_016B;
						case 11:
							return;
						case 12:
							goto IL_0288;
						case 13:
							goto IL_029C;
						case 14:
							goto IL_014E;
						case 15:
							return;
						case 17:
							goto IL_01C1;
						case 18:
							goto IL_011E;
						case 19:
							goto IL_0361;
						case 20:
						case 23:
							if (this.stringReference_0.Length == 36)
							{
								goto IL_014E;
							}
							goto IL_016B;
						case 21:
							return;
						case 22:
							goto IL_01AA;
						case 24:
							goto IL_0292;
						case 26:
							goto IL_00FE;
						case 27:
							return;
						case 28:
							return;
						case 29:
							goto IL_031C;
						case 31:
							goto IL_0099;
						case 32:
							goto IL_0051;
						}
						goto Block_14;
						IL_016B:
						array = Convert.FromBase64CharArray(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
						{
							goto Block_11;
						}
						continue;
						IL_014E:
						if (!ConvertUtils.TryConvertGuid(this.stringReference_0.ToString(), out guid))
						{
							goto IL_016B;
						}
						goto IL_031C;
					}
					IL_000E:
					if (dateParseHandling == DateParseHandling.DateTime)
					{
						goto IL_0099;
					}
					if (DateTimeUtils.TryParseDateTimeOffset(this.stringReference_0, base.DateFormatString, base.Culture, out dateTimeOffset))
					{
						goto IL_0336;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto Block_3;
					}
					goto IL_01DB;
					IL_0006:
					dateParseHandling = this._dateParseHandling;
					goto IL_000E;
					IL_0288:
					if (readType_0 != ReadType.ReadAsDateTimeOffset)
					{
						goto IL_0006;
					}
					num = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_01AA;
					}
					goto IL_01DB;
					IL_0292:
					if (readType_0 == ReadType.ReadAsDateTime)
					{
						goto IL_01C1;
					}
					goto IL_0288;
					IL_029C:
					if (this._dateParseHandling != DateParseHandling.None)
					{
						goto IL_0292;
					}
					goto IL_0347;
					IL_0078:
					array = CollectionUtils.ArrayEmpty<byte>();
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto Block_6;
					}
					goto IL_01DB;
					IL_0099:
					DateTime dateTime;
					if (!DateTimeUtils.TryParseDateTime(this.stringReference_0, base.DateTimeZoneHandling, base.DateFormatString, base.Culture, out dateTime))
					{
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							goto Block_8;
						}
						goto IL_01DB;
					}
					IL_00D4:
					base.SetToken(JsonToken.Date, dateTime, false);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_0078;
					}
					goto IL_01DB;
					IL_00FE:
					base.SetToken(JsonToken.String, text, false);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_01DB;
					}
					IL_011E:
					this._quoteChar = char_1;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto Block_10;
					}
					goto IL_01DB;
					IL_01C1:
					dateParseHandling = DateParseHandling.DateTime;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_000E;
					}
					goto IL_01DB;
				}
			}
			Block_3:
			goto IL_0347;
			Block_6:
			return;
			Block_8:
			goto IL_0328;
			Block_10:
			return;
			Block_11:
			goto IL_0328;
			Block_14:
			goto IL_0347;
			IL_031C:
			array = guid.ToByteArray();
			IL_0328:
			base.SetToken(JsonToken.Bytes, array, false);
			return;
			IL_0336:
			base.SetToken(JsonToken.Date, dateTimeOffset, false);
			return;
			IL_0347:
			base.SetToken(JsonToken.String, this.stringReference_0.ToString(), false);
			IL_0361:
			this._quoteChar = char_1;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0002FC10 File Offset: 0x0002DE10
		private static void smethod_0(Array array_0, int int_4, Array array_1, int int_5, int int_6)
		{
			for (;;)
			{
				Buffer.BlockCopy(array_0, int_4 * 2, array_1, int_5 * 2, int_6 * 2);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
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

		// Token: 0x0600041D RID: 1053 RVA: 0x0002FC54 File Offset: 0x0002DE54
		private void method_14()
		{
			int num2;
			for (;;)
			{
				IL_00F4:
				int num = this.char_0.Length;
				for (;;)
				{
					IL_00D8:
					if ((double)(num - this.int_1) > (double)num * 0.1)
					{
						goto IL_00A9;
					}
					for (;;)
					{
						IL_00B2:
						num2 = this.int_0 - this.int_1;
						int num3 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
						{
							goto IL_0030;
						}
						IL_0075:
						switch (num3)
						{
						case 1:
							goto IL_0047;
						case 2:
							goto IL_00A9;
						case 3:
							goto IL_00D8;
						case 4:
							goto IL_00F4;
						case 5:
							IL_0030:
							if (num2 <= 0)
							{
								goto IL_0006;
							}
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
							{
								goto IL_0047;
							}
							goto IL_0075;
						case 6:
							goto IL_0108;
						case 7:
							continue;
						case 8:
							return;
						case 9:
							goto IL_0110;
						case 10:
							goto IL_0006;
						}
						goto Block_4;
						IL_0006:
						this.int_2 -= this.int_1;
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
						{
							goto Block_1;
						}
						goto IL_0075;
						IL_0047:
						JsonTextReader.smethod_0(this.char_0, this.int_1, this.char_0, 0, num2);
						num3 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
						{
							goto IL_0006;
						}
						goto IL_0075;
					}
					IL_00A9:
					if (num >= 1073741823)
					{
						goto IL_00B2;
					}
					return;
				}
			}
			Block_1:
			Block_4:
			this.int_1 = 0;
			IL_0108:
			this.int_0 = num2;
			IL_0110:
			this.char_0[this.int_0] = '\0';
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000030E9 File Offset: 0x000012E9
		private int method_15(bool bool_4)
		{
			return this.method_17(bool_4, 0);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0002FD80 File Offset: 0x0002DF80
		private void method_16(bool bool_4, int int_4)
		{
			int num2;
			int num3;
			for (;;)
			{
				IL_024A:
				if (this.int_0 + int_4 >= this.char_0.Length - 1)
				{
					goto IL_022A;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto Block_9;
				}
				char[] array;
				for (;;)
				{
					IL_01A1:
					switch (num)
					{
					case 1:
						goto IL_0006;
					case 2:
					case 20:
						return;
					case 3:
						goto IL_024A;
					case 4:
						goto IL_011C;
					case 5:
						goto IL_0166;
					case 6:
					case 23:
						goto IL_0047;
					case 7:
						goto IL_0095;
					case 8:
						goto IL_0106;
					case 9:
						goto IL_028D;
					case 10:
						goto IL_0012;
					case 11:
						goto IL_0267;
					case 12:
						goto IL_00C4;
					case 13:
						goto IL_022A;
					case 14:
						return;
					case 15:
						goto IL_0276;
					case 16:
						goto IL_00B1;
					case 17:
						goto IL_015E;
					case 18:
						goto IL_02A0;
					case 19:
						goto IL_00EC;
					case 21:
						num2 = this.int_0 - this.int_1;
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto IL_0095;
						}
						continue;
					case 22:
						goto IL_02A9;
					case 24:
						goto IL_001A;
					}
					break;
					for (;;)
					{
						IL_0047:
						this.int_2 -= this.int_1;
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
						{
							goto IL_01A1;
						}
					}
					IL_0095:
					this.int_1 = 0;
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_00B1;
					}
					continue;
					IL_00C4:
					array = BufferUtils.RentBuffer(this.iarrayPool_0, num2 + int_4 + 1);
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_00EC;
					}
					continue;
					IL_00B1:
					if (num2 + int_4 + 1 >= this.char_0.Length)
					{
						goto IL_00C4;
					}
					goto IL_015E;
					IL_00EC:
					if (num2 > 0)
					{
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
						{
							goto IL_0106;
						}
						continue;
					}
					IL_011C:
					BufferUtils.ReturnBuffer(this.iarrayPool_0, this.char_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						break;
					}
					continue;
					IL_0106:
					JsonTextReader.smethod_0(this.char_0, this.int_1, array, 0, num2);
					goto IL_011C;
					IL_0166:
					JsonTextReader.smethod_0(this.char_0, this.int_1, this.char_0, 0, num2);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0047;
					}
					continue;
					IL_015E:
					if (num2 > 0)
					{
						goto IL_0166;
					}
					goto IL_0047;
				}
				goto IL_013F;
				IL_001C:
				int num4;
				num3 = Math.Max(num4, this.int_0 + int_4 + 1);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_013F;
				}
				goto IL_01A1;
				IL_001A:
				int num5;
				num4 = num5;
				goto IL_001C;
				IL_0012:
				if (num5 >= 0)
				{
					goto IL_001A;
				}
				num4 = int.MaxValue;
				goto IL_001C;
				IL_0006:
				num5 = this.char_0.Length * 2;
				goto IL_0012;
				IL_022A:
				if (bool_4)
				{
					goto IL_0006;
				}
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					break;
				}
				goto IL_01A1;
				IL_013F:
				this.char_0 = array;
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					goto IL_022A;
				}
				goto IL_01A1;
			}
			return;
			Block_9:
			return;
			IL_0267:
			char[] array2 = BufferUtils.RentBuffer(this.iarrayPool_0, num3);
			IL_0276:
			JsonTextReader.smethod_0(this.char_0, 0, array2, 0, this.char_0.Length);
			IL_028D:
			BufferUtils.ReturnBuffer(this.iarrayPool_0, this.char_0);
			goto IL_02A9;
			IL_02A0:
			this.int_0 = num2;
			return;
			IL_02A9:
			this.char_0 = array2;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00030040 File Offset: 0x0002E240
		private int method_17(bool bool_4, int int_4)
		{
			int num2;
			for (;;)
			{
				IL_00EA:
				int num;
				if (this.bool_3)
				{
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_008E;
					}
				}
				else
				{
					this.method_16(bool_4, int_4);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						break;
					}
				}
				for (;;)
				{
					IL_00A3:
					switch (num)
					{
					case 1:
						goto IL_008E;
					case 2:
						goto IL_006D;
					case 4:
						goto IL_00FE;
					case 5:
						return 0;
					case 6:
						goto IL_00EA;
					case 7:
						return num2;
					case 8:
					{
						int num3;
						num2 = this.CqAbwNtqvn.Read(this.char_0, this.int_0, num3);
						goto IL_006D;
					}
					case 9:
					{
						int num3 = this.char_0.Length - this.int_0 - 1;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
						{
							goto Block_2;
						}
						continue;
					}
					}
					goto Block_4;
					IL_006D:
					this.int_0 += num2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_008E;
					}
				}
				Block_2:
				continue;
				IL_008E:
				if (num2 == 0)
				{
					goto IL_00FE;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					goto IL_00A3;
				}
				goto IL_00FB;
			}
			return 0;
			Block_4:
			IL_00FB:
			goto IL_0105;
			IL_00FE:
			this.bool_3 = true;
			IL_0105:
			this.char_0[this.int_0] = '\0';
			return num2;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00030164 File Offset: 0x0002E364
		private bool method_18(int int_4, bool bool_4)
		{
			while (this.int_1 + int_4 < this.int_0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003E;
					}
				}
				return true;
			}
			IL_003E:
			return this.method_19(int_4, bool_4);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000301B8 File Offset: 0x0002E3B8
		private bool method_19(int int_4, bool bool_4)
		{
			int num;
			int num3;
			for (;;)
			{
				if (!this.bool_3)
				{
					num = this.int_1 + int_4 - this.int_0 + 1;
					goto IL_008C;
				}
				int num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					break;
				}
				IL_0060:
				switch (num2)
				{
				case 1:
					goto IL_00CB;
				case 2:
					return false;
				case 3:
					IL_008C:
					num3 = 0;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto IL_0060;
					}
					break;
				case 4:
					return false;
				case 5:
					continue;
				case 6:
					goto IL_0022;
				case 7:
					goto IL_0048;
				case 8:
					goto IL_001B;
				}
				IL_0028:
				int num4 = this.method_17(bool_4, num - num3);
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					goto IL_0048;
				}
				goto IL_0060;
				IL_0022:
				if (num3 < num)
				{
					goto IL_0028;
				}
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_0060;
				}
				goto IL_00CA;
				IL_001B:
				num3 += num4;
				goto IL_0022;
				IL_0048:
				if (num4 != 0)
				{
					goto IL_001B;
				}
				goto IL_00CB;
			}
			return false;
			IL_00CA:
			IL_00CB:
			if (num3 >= num)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0003029C File Offset: 0x0002E49C
		public override bool Read()
		{
			for (;;)
			{
				IL_0175:
				this.method_29();
				for (;;)
				{
					JsonReader.State currentState = this._currentState;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_0096;
					}
					IL_010C:
					switch (num)
					{
					case 1:
						IL_0096:
						switch (currentState)
						{
						case JsonReader.State.Start:
						case JsonReader.State.Property:
						case JsonReader.State.ArrayStart:
						case JsonReader.State.Array:
						case JsonReader.State.ConstructorStart:
						case JsonReader.State.Constructor:
							goto IL_01C5;
						case JsonReader.State.Complete:
						case JsonReader.State.Closed:
						case JsonReader.State.Error:
							goto IL_0194;
						case JsonReader.State.ObjectStart:
						case JsonReader.State.Object:
							goto IL_0180;
						case JsonReader.State.PostValue:
							if (!this.method_38(false))
							{
								continue;
							}
							break;
						case JsonReader.State.Finished:
							if (!this.method_18(0, false))
							{
								goto IL_0189;
							}
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								goto IL_0027;
							}
							goto IL_010C;
						default:
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
							{
								goto Block_6;
							}
							goto IL_010C;
						}
						break;
					case 2:
						return false;
					case 3:
					case 10:
						continue;
					case 4:
						goto IL_0175;
					case 5:
						return true;
					case 6:
						goto IL_0194;
					case 7:
						goto IL_01C5;
					case 8:
						return false;
					case 9:
						goto IL_0042;
					case 11:
						goto IL_004A;
					case 12:
						goto IL_0027;
					case 13:
						goto IL_0006;
					}
					goto Block_9;
					IL_0006:
					this.method_52(true);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						break;
					}
					goto IL_010C;
					IL_0027:
					this.method_47();
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_0042;
					}
					goto IL_010C;
					IL_004A:
					base.SetToken(JsonToken.None);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto Block_2;
					}
					goto IL_010C;
					IL_0042:
					if (this.bool_3)
					{
						goto IL_004A;
					}
					if (this.char_0[this.int_1] != '/')
					{
						goto IL_01CF;
					}
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						goto IL_0006;
					}
					goto IL_010C;
				}
			}
			Block_2:
			return false;
			Block_6:
			return true;
			Block_9:
			return true;
			IL_0180:
			return this.method_39();
			IL_0189:
			base.SetToken(JsonToken.None);
			return false;
			IL_0194:
			throw JsonReaderException.Create(this, Class15.smethod_17(299949177 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
			IL_01C5:
			return this.method_44();
			IL_01CF:
			throw JsonReaderException.Create(this, Class15.smethod_17(1387477536 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000030F3 File Offset: 0x000012F3
		public override int? vmethod_0()
		{
			return (int?)this.method_24(ReadType.const_1);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003101 File Offset: 0x00001301
		public override DateTime? ReadAsDateTime()
		{
			return (DateTime?)this.method_20(ReadType.ReadAsDateTime);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000310F File Offset: 0x0000130F
		[NullableContext(2)]
		public override string ReadAsString()
		{
			return (string)this.method_20(ReadType.ReadAsString);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000304B4 File Offset: 0x0002E6B4
		[NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			char c;
			byte[] array;
			for (;;)
			{
				IL_04AC:
				this.method_29();
				for (;;)
				{
					IL_04A7:
					bool flag = false;
					for (;;)
					{
						IL_049D:
						JsonReader.State currentState = this._currentState;
						for (;;)
						{
							IL_045F:
							int num;
							switch (currentState)
							{
							case JsonReader.State.Start:
							case JsonReader.State.Property:
							case JsonReader.State.ArrayStart:
							case JsonReader.State.Array:
							case JsonReader.State.ConstructorStart:
							case JsonReader.State.Constructor:
								goto IL_0422;
							case JsonReader.State.Complete:
							case JsonReader.State.ObjectStart:
							case JsonReader.State.Object:
							case JsonReader.State.Closed:
							case JsonReader.State.Error:
								goto IL_051F;
							case JsonReader.State.PostValue:
								IL_03B1:
								if (this.method_38(true))
								{
									goto Block_25;
								}
								goto IL_0422;
							case JsonReader.State.Finished:
								goto IL_0550;
							default:
								num = 14;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
								{
									goto Block_28;
								}
								break;
							}
							for (;;)
							{
								IL_02A2:
								switch (num)
								{
								case 0:
								case 8:
								case 28:
								case 34:
								case 40:
									goto IL_004C;
								case 1:
									if (c != '\'')
									{
										goto IL_004C;
									}
									goto IL_0080;
								case 2:
								case 18:
									goto IL_0403;
								case 3:
									goto IL_01A6;
								case 4:
									goto IL_01AF;
								case 5:
									goto IL_00CA;
								case 6:
									IL_0089:
									array = (byte[])this.Value;
									num = 21;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
									{
										goto Block_5;
									}
									continue;
								case 7:
									goto IL_03D7;
								case 9:
									goto IL_012F;
								case 10:
									goto IL_0222;
								case 11:
								case 16:
								case 22:
								case 24:
								case 25:
								case 26:
								case 46:
								case 58:
									goto IL_0422;
								case 12:
									goto IL_0411;
								case 13:
									goto IL_0150;
								case 14:
									goto IL_0120;
								case 15:
									goto IL_051F;
								case 17:
									goto IL_051D;
								case 19:
									goto IL_04B7;
								case 20:
									return array;
								case 21:
									if (!flag)
									{
										return array;
									}
									num = 23;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
									{
										goto IL_014A;
									}
									continue;
								case 23:
									goto IL_014A;
								case 27:
									goto IL_00D6;
								case 29:
								case 56:
									goto IL_0117;
								case 30:
									goto IL_0204;
								case 31:
									goto IL_04BE;
								case 32:
									goto IL_03F7;
								case 33:
									goto IL_0129;
								case 35:
									goto IL_005A;
								case 36:
									goto IL_03FD;
								case 37:
								case 63:
									if (c != ' ')
									{
										goto IL_0031;
									}
									goto IL_0411;
								case 38:
									goto IL_03B1;
								case 39:
									goto IL_045F;
								case 41:
									goto IL_00F6;
								case 42:
									goto IL_0556;
								case 43:
									goto IL_01E4;
								case 44:
									goto IL_01B8;
								case 45:
									goto IL_04CC;
								case 47:
									goto IL_04A7;
								case 48:
									goto IL_04AC;
								case 49:
									goto IL_0031;
								case 50:
									goto IL_050B;
								case 51:
									if (c <= '\'')
									{
										goto IL_01E4;
									}
									goto IL_0117;
								case 52:
									goto IL_04C0;
								case 53:
									goto IL_03CC;
								case 54:
									goto IL_03ED;
								case 55:
									goto IL_00BE;
								case 57:
									goto IL_04CE;
								case 59:
									goto IL_049D;
								case 60:
									goto IL_00E8;
								case 61:
									goto IL_00B0;
								case 62:
									goto IL_0514;
								case 64:
									break;
								default:
									goto IL_004C;
								}
								IL_0006:
								base.SetToken(JsonToken.EndArray);
								num = 52;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
								{
									goto Block_1;
								}
								continue;
								IL_00BE:
								if (this._currentState != JsonReader.State.Array)
								{
									goto IL_00CA;
								}
								goto IL_0006;
								IL_00B0:
								this.int_1++;
								goto IL_00BE;
								IL_01A6:
								if (c != ']')
								{
									goto IL_01AF;
								}
								goto IL_00B0;
								IL_0117:
								if (c <= '[')
								{
									goto IL_0120;
								}
								goto IL_01A6;
								IL_0031:
								if (c == '"')
								{
									goto IL_0080;
								}
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
								{
									goto IL_004C;
								}
								continue;
								IL_005A:
								if (!char.IsWhiteSpace(c))
								{
									goto IL_050B;
								}
								num = 58;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
								{
									goto Block_4;
								}
								continue;
								IL_004C:
								this.int_1++;
								goto IL_005A;
								IL_0222:
								switch (c)
								{
								case '\t':
									goto IL_0411;
								case '\n':
									goto IL_03CC;
								case '\v':
								case '\f':
									goto IL_004C;
								case '\r':
									this.method_46(false);
									num = 7;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
									{
										goto Block_20;
									}
									continue;
								default:
									num = 8;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
									{
										goto Block_19;
									}
									continue;
								}
								IL_0204:
								if (c != '\0')
								{
									goto IL_0222;
								}
								num = 13;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
								{
									goto Block_17;
								}
								continue;
								IL_01E4:
								if (c <= '\r')
								{
									goto IL_0204;
								}
								num = 37;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
								{
									goto Block_15;
								}
								continue;
								IL_0080:
								this.method_12(c, ReadType.ReadAsBytes);
								goto IL_0089;
								IL_00F6:
								base.SetToken(JsonToken.StartArray);
								num = 19;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
								{
									goto Block_7;
								}
								continue;
								IL_00E8:
								this.int_1++;
								goto IL_00F6;
								IL_012F:
								if (c == '[')
								{
									goto IL_00E8;
								}
								num = 28;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
								{
									goto IL_014A;
								}
								continue;
								IL_0129:
								if (c != '/')
								{
									goto IL_012F;
								}
								this.method_52(false);
								num = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
								{
									goto Block_11;
								}
								continue;
								IL_0120:
								if (c != ',')
								{
									goto IL_0129;
								}
								goto IL_03D7;
								IL_0150:
								if (this.TokenType != JsonToken.EndObject)
								{
									goto Block_9;
								}
								base.SetToken(JsonToken.Bytes, array, false);
								num = 10;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
								{
									goto Block_10;
								}
								continue;
								IL_014A:
								base.ReaderReadAndAssert();
								goto IL_0150;
								IL_01B8:
								if (c == '{')
								{
									goto IL_03DF;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
								{
									goto IL_004C;
								}
								continue;
								IL_01AF:
								if (c != 'n')
								{
									goto IL_01B8;
								}
								goto IL_04C6;
								IL_00CA:
								if (this._currentState == JsonReader.State.ArrayStart)
								{
									goto IL_0006;
								}
								IL_00D6:
								if (this._currentState == JsonReader.State.PostValue)
								{
									goto IL_0006;
								}
								goto IL_0502;
							}
							IL_0411:
							this.int_1++;
							goto IL_0422;
							Block_17:
							Block_15:
							Block_11:
							Block_5:
							goto IL_0403;
							IL_03FD:
							flag = true;
							goto IL_0422;
							IL_03F7:
							base.ReadIntoWrappedTypeObject();
							goto IL_03FD;
							IL_03ED:
							base.SetToken(JsonToken.StartObject);
							goto IL_03F7;
							IL_03DF:
							this.int_1++;
							goto IL_03ED;
							Block_4:
							goto IL_03F7;
							IL_03D7:
							this.method_23();
							goto IL_0422;
							Block_19:
							goto IL_03D7;
							IL_03CC:
							this.method_45();
							Block_20:
							Block_1:
							IL_0422:
							c = this.char_0[this.int_1];
							num = 51;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
							{
								goto IL_02A2;
							}
							IL_0403:
							if (!this.method_28())
							{
								goto IL_0422;
							}
							goto IL_0514;
						}
					}
				}
			}
			Block_7:
			goto IL_051F;
			Block_9:
			goto IL_04CE;
			Block_10:
			return array;
			Block_25:
			goto IL_04BE;
			Block_28:
			goto IL_051F;
			IL_04B7:
			return base.ReadArrayIntoByteArray();
			IL_04BE:
			return null;
			IL_04C0:
			return null;
			IL_04C6:
			this.method_26();
			IL_04CC:
			return null;
			IL_04CE:
			throw JsonReaderException.Create(this, Class15.smethod_17(1116172945 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, this.TokenType));
			IL_0502:
			throw this.method_22(c);
			IL_050B:
			throw this.method_22(c);
			IL_0514:
			base.SetToken(JsonToken.None, null, false);
			IL_051D:
			return null;
			IL_051F:
			throw JsonReaderException.Create(this, Class15.smethod_17(2060607220 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
			IL_0550:
			this.method_27();
			IL_0556:
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00030A18 File Offset: 0x0002EC18
		[NullableContext(2)]
		private object method_20(ReadType readType_0)
		{
			char c;
			string text;
			for (;;)
			{
				IL_04B4:
				this.method_29();
				int num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_012E;
				}
				do
				{
					IL_03BC:
					switch (num)
					{
					case 1:
					case 2:
					case 17:
					case 30:
					case 42:
						goto IL_0228;
					case 3:
						goto IL_0068;
					case 4:
						goto IL_04FB;
					case 5:
						goto IL_057E;
					case 6:
						goto IL_052B;
					case 7:
						goto IL_0032;
					case 8:
						goto IL_0330;
					case 9:
						goto IL_0015;
					case 10:
						goto IL_04F2;
					case 11:
						goto IL_0371;
					case 12:
					case 29:
						goto IL_004D;
					case 13:
						goto IL_00C1;
					case 14:
						goto IL_018C;
					case 15:
						goto IL_04D4;
					case 16:
						goto IL_050D;
					case 18:
						goto IL_01E2;
					case 19:
						goto IL_00A1;
					case 20:
					case 34:
					case 35:
					case 39:
					case 53:
						goto IL_0038;
					case 21:
					case 44:
						switch (c)
						{
						case ' ':
							goto IL_0100;
						case '!':
						case '#':
						case '$':
						case '%':
						case '&':
						case '(':
						case ')':
						case '*':
						case '+':
							goto IL_0228;
						case '"':
						case '\'':
							goto IL_04E9;
						case ',':
							goto IL_0032;
						case '-':
							if (this.method_18(1, true))
							{
								goto IL_0371;
							}
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
							{
								goto Block_23;
							}
							continue;
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_0509;
						case '/':
							this.method_52(false);
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
							{
								goto Block_26;
							}
							continue;
						}
						goto IL_0330;
					case 22:
						goto IL_020A;
					case 23:
						goto IL_04DC;
					case 24:
						goto IL_0536;
					case 25:
						goto IL_0502;
					case 26:
						goto IL_012E;
					case 27:
						goto IL_04B4;
					case 28:
						goto IL_0047;
					case 31:
						goto IL_01D1;
					case 32:
						goto IL_024B;
					case 33:
						goto IL_051B;
					case 36:
						goto IL_0089;
					case 37:
						goto IL_0100;
					case 38:
						goto IL_0092;
					case 40:
						goto IL_00C8;
					case 41:
						goto IL_0071;
					case 43:
						goto IL_0580;
					case 45:
						goto IL_05B7;
					case 46:
						goto IL_05B9;
					case 47:
						goto IL_05CB;
					case 48:
						goto IL_0563;
					case 49:
						goto IL_0561;
					case 50:
						goto IL_0571;
					case 51:
						goto IL_019E;
					case 52:
						goto IL_0113;
					case 54:
						goto IL_0216;
					case 55:
						goto IL_0080;
					case 56:
						goto IL_05C2;
					case 57:
						if (!this.method_56(text))
						{
							goto IL_0536;
						}
						base.SetToken(JsonToken.String, text);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							continue;
						}
						break;
					case 58:
						goto IL_014B;
					case 59:
						goto IL_0006;
					}
					goto Block_27;
					IL_0330:
					if (c == 'I')
					{
						goto IL_04E1;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto Block_21;
					}
					continue;
					IL_0371:
					if (this.char_0[this.int_1 + 1] != 'I')
					{
						goto IL_04FB;
					}
					num = 15;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0);
				goto IL_0068;
				Block_26:
				goto IL_0038;
				IL_0006:
				if (this._currentState == JsonReader.State.Array)
				{
					goto IL_0015;
				}
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					goto IL_020A;
				}
				goto IL_03BC;
				IL_01E2:
				this.int_1++;
				goto IL_0006;
				IL_0071:
				if (c != ']')
				{
					goto IL_0228;
				}
				goto IL_01E2;
				IL_0068:
				if (c != 'N')
				{
					goto IL_0071;
				}
				goto IL_0553;
				IL_0015:
				base.SetToken(JsonToken.EndArray);
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_0032;
				}
				goto IL_03BC;
				IL_020A:
				if (this._currentState != JsonReader.State.ArrayStart)
				{
					goto IL_0216;
				}
				goto IL_0015;
				IL_004D:
				if (c > ']')
				{
					goto IL_0080;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_0068;
				}
				goto IL_03BC;
				IL_0047:
				if (c > 'I')
				{
					goto IL_004D;
				}
				goto IL_00A1;
				IL_0038:
				c = this.char_0[this.int_1];
				goto IL_0047;
				IL_014B:
				JsonReader.State currentState;
				switch (currentState)
				{
				case JsonReader.State.Start:
				case JsonReader.State.Property:
				case JsonReader.State.ArrayStart:
				case JsonReader.State.Array:
				case JsonReader.State.ConstructorStart:
				case JsonReader.State.Constructor:
					goto IL_0038;
				case JsonReader.State.PostValue:
					IL_018C:
					if (!this.method_38(true))
					{
						goto IL_0038;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto Block_17;
					}
					goto IL_03BC;
				case JsonReader.State.Finished:
					goto IL_05B1;
				}
				break;
				IL_0100:
				this.int_1++;
				goto IL_0038;
				IL_00C8:
				switch (c)
				{
				case '\t':
					goto IL_0100;
				case '\n':
					IL_0113:
					this.method_45();
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_012E;
					}
					goto IL_03BC;
				case '\v':
				case '\f':
					goto IL_0228;
				case '\r':
					this.method_46(false);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_0038;
					}
					goto IL_03BC;
				default:
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_0228;
					}
					goto IL_03BC;
				}
				IL_00C1:
				if (c != '\0')
				{
					goto IL_00C8;
				}
				goto IL_01D1;
				IL_00A1:
				if (c <= '\r')
				{
					goto IL_00C1;
				}
				num = 44;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0228;
				}
				goto IL_03BC;
				IL_0032:
				this.method_23();
				goto IL_0038;
				IL_012E:
				currentState = this._currentState;
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					goto IL_014B;
				}
				goto IL_03BC;
				IL_0257:
				string text2;
				text = text2;
				num = 57;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					goto Block_16;
				}
				goto IL_03BC;
				IL_023B:
				if (readType_0 != ReadType.ReadAsString)
				{
					goto Block_15;
				}
				if (c != 't')
				{
					goto IL_024B;
				}
				text2 = JsonConvert.True;
				goto IL_0257;
				IL_0092:
				if (c != 't')
				{
					goto IL_0228;
				}
				goto IL_023B;
				IL_0089:
				if (c != 'n')
				{
					goto IL_0092;
				}
				goto IL_055B;
				IL_0080:
				if (c != 'f')
				{
					goto IL_0089;
				}
				goto IL_023B;
				IL_024B:
				text2 = JsonConvert.False;
				goto IL_0257;
				IL_0216:
				if (this._currentState == JsonReader.State.PostValue)
				{
					goto IL_0015;
				}
				goto IL_054A;
				IL_019E:
				if (!char.IsWhiteSpace(c))
				{
					goto Block_11;
				}
				goto IL_0038;
				IL_0228:
				this.int_1++;
				goto IL_019E;
				IL_01D1:
				if (this.method_28())
				{
					goto Block_13;
				}
				goto IL_0038;
			}
			goto IL_0580;
			Block_11:
			goto IL_05B9;
			Block_13:
			goto IL_05C2;
			Block_15:
			goto IL_0563;
			Block_16:
			Block_17:
			goto IL_057E;
			Block_21:
			return text;
			Block_23:
			goto IL_04FB;
			Block_27:
			return text;
			IL_04D4:
			return this.method_62(readType_0);
			IL_04DC:
			return null;
			IL_04E1:
			return this.method_64(readType_0);
			IL_04E9:
			this.method_12(c, readType_0);
			IL_04F2:
			return this.method_21(readType_0);
			IL_04FB:
			this.method_49(readType_0);
			IL_0502:
			return this.Value;
			IL_0509:
			if (readType_0 == ReadType.ReadAsString)
			{
				this.method_49(ReadType.ReadAsString);
				goto IL_052B;
			}
			IL_050D:
			this.int_1++;
			IL_051B:
			throw this.method_22(c);
			IL_052B:
			return this.Value;
			IL_0536:
			throw this.method_22(this.char_0[this.int_1]);
			IL_054A:
			throw this.method_22(c);
			IL_0553:
			return this.method_66(readType_0);
			IL_055B:
			this.method_26();
			IL_0561:
			return null;
			IL_0563:
			this.int_1++;
			IL_0571:
			throw this.method_22(c);
			IL_057E:
			return null;
			IL_0580:
			throw JsonReaderException.Create(this, Class15.smethod_17(1788634298 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
			IL_05B1:
			this.method_27();
			IL_05B7:
			return null;
			IL_05B9:
			throw this.method_22(c);
			IL_05C2:
			base.SetToken(JsonToken.None, null, false);
			IL_05CB:
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00030FF4 File Offset: 0x0002F1F4
		[NullableContext(2)]
		private object method_21(ReadType readType_0)
		{
			DateTime dateTime;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				object obj;
				switch (readType_0)
				{
				case ReadType.ReadAsBytes:
				case ReadType.ReadAsString:
					goto IL_00C7;
				case ReadType.ReadAsDateTime:
					obj = this.Value;
					goto IL_0010;
				case ReadType.ReadAsDateTimeOffset:
					obj = this.Value;
					goto IL_0086;
				}
				goto Block_4;
				IL_0039:
				int num;
				switch (num)
				{
				case 1:
					goto IL_00EA;
				case 2:
					goto IL_00C7;
				case 3:
					goto IL_00CE;
				case 4:
					continue;
				case 5:
					IL_0086:
					if (obj is DateTimeOffset)
					{
						goto IL_0069;
					}
					goto IL_0109;
				case 6:
					goto IL_00F2;
				case 7:
					goto IL_0069;
				case 8:
					goto IL_001C;
				case 9:
					IL_0010:
					if (obj is DateTime)
					{
						goto IL_001C;
					}
					goto IL_00F2;
				}
				break;
				IL_001C:
				dateTime = (DateTime)obj;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					goto IL_0039;
				}
				goto IL_00E9;
				IL_0069:
				dateTimeOffset = (DateTimeOffset)obj;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					break;
				}
				goto IL_0039;
			}
			goto IL_00BF;
			Block_4:
			goto IL_00CE;
			IL_00BF:
			return dateTimeOffset;
			IL_00C7:
			return this.Value;
			IL_00CE:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(1788634346 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
			IL_00E9:
			IL_00EA:
			return dateTime;
			IL_00F2:
			return base.ReadDateTimeString((string)this.Value);
			IL_0109:
			return base.ReadDateTimeOffsetString((string)this.Value);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000311D File Offset: 0x0000131D
		private JsonReaderException method_22(char char_1)
		{
			return JsonReaderException.Create(this, Class15.smethod_17(2128221612 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).FormatWith(CultureInfo.InvariantCulture, char_1));
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00031120 File Offset: 0x0002F320
		public override bool? ReadAsBoolean()
		{
			this.method_29();
			switch (this._currentState)
			{
			case JsonReader.State.Start:
			case JsonReader.State.Property:
			case JsonReader.State.ArrayStart:
			case JsonReader.State.Array:
			case JsonReader.State.ConstructorStart:
			case JsonReader.State.Constructor:
				break;
			case JsonReader.State.Complete:
			case JsonReader.State.ObjectStart:
			case JsonReader.State.Object:
			case JsonReader.State.Closed:
			case JsonReader.State.Error:
				goto IL_02D6;
			case JsonReader.State.PostValue:
				if (this.method_38(true))
				{
					return null;
				}
				break;
			case JsonReader.State.Finished:
				this.method_27();
				return null;
			default:
				goto IL_02D6;
			}
			char c;
			do
			{
				c = this.char_0[this.int_1];
				if (c <= '9')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.method_45();
							continue;
						case '\v':
						case '\f':
							goto IL_008B;
						case '\r':
							this.method_46(false);
							continue;
						default:
							switch (c)
							{
							case ' ':
								break;
							case '!':
							case '#':
							case '$':
							case '%':
							case '&':
							case '(':
							case ')':
							case '*':
							case '+':
								goto IL_008B;
							case '"':
							case '\'':
								goto IL_019D;
							case ',':
								this.method_23();
								continue;
							case '-':
							case '.':
							case '0':
							case '1':
							case '2':
							case '3':
							case '4':
							case '5':
							case '6':
							case '7':
							case '8':
							case '9':
								goto IL_01BD;
							case '/':
								this.method_52(false);
								continue;
							default:
								goto IL_008B;
							}
							break;
						}
						this.int_1++;
						continue;
					}
					if (!this.method_28())
					{
						continue;
					}
					goto IL_0218;
				}
				else if (c <= 'f')
				{
					if (c == ']')
					{
						goto IL_022B;
					}
					if (c == 'f')
					{
						goto IL_0279;
					}
				}
				else
				{
					if (c == 'n')
					{
						goto IL_02C6;
					}
					if (c == 't')
					{
						goto IL_0279;
					}
				}
				IL_008B:
				this.int_1++;
			}
			while (char.IsWhiteSpace(c));
			throw this.method_22(c);
			IL_019D:
			this.method_12(c, ReadType.Read);
			return base.ReadBooleanString(this.stringReference_0.ToString());
			IL_01BD:
			this.method_49(ReadType.Read);
			object value = this.Value;
			bool flag;
			if (value is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value;
				flag = bigInteger != 0L;
			}
			else
			{
				flag = Convert.ToBoolean(this.Value, CultureInfo.InvariantCulture);
			}
			base.SetToken(JsonToken.Boolean, flag, false);
			return new bool?(flag);
			IL_0218:
			base.SetToken(JsonToken.None, null, false);
			return null;
			IL_022B:
			this.int_1++;
			if (this._currentState != JsonReader.State.Array && this._currentState != JsonReader.State.ArrayStart)
			{
				if (this._currentState != JsonReader.State.PostValue)
				{
					throw this.method_22(c);
				}
			}
			base.SetToken(JsonToken.EndArray);
			return null;
			IL_0279:
			bool flag2;
			string text = ((flag2 = c == 't') ? JsonConvert.True : JsonConvert.False);
			if (!this.method_56(text))
			{
				throw this.method_22(this.char_0[this.int_1]);
			}
			base.SetToken(JsonToken.Boolean, BoxedPrimitives.Get(flag2));
			return new bool?(flag2);
			IL_02C6:
			this.method_26();
			return null;
			IL_02D6:
			throw JsonReaderException.Create(this, Class15.smethod_17(2071409976 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00031444 File Offset: 0x0002F644
		private void method_23()
		{
			for (;;)
			{
				this.int_1++;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0054;
				}
				IL_0037:
				while (this._currentState == JsonReader.State.PostValue)
				{
					base.SetStateBasedOnCurrent();
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0054;
					}
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0003;
				}
				IL_0054:
				switch (num)
				{
				case 0:
					goto IL_0037;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				case 4:
					goto IL_0093;
				default:
					goto IL_0037;
				}
				IL_0003:
				base.SetToken(JsonToken.Undefined);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					break;
				}
				goto IL_0054;
			}
			IL_0093:
			object obj = this.method_22(',');
			this.int_1--;
			throw obj;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000314FC File Offset: 0x0002F6FC
		[NullableContext(2)]
		private object method_24(ReadType readType_0)
		{
			char c;
			for (;;)
			{
				IL_03CB:
				this.method_29();
				for (;;)
				{
					IL_03A8:
					JsonReader.State currentState = this._currentState;
					int num = 43;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						goto IL_00FC;
					}
					for (;;)
					{
						IL_02D5:
						switch (num)
						{
						case 1:
							goto IL_0450;
						case 2:
							goto IL_0211;
						case 3:
						case 30:
						case 38:
						case 41:
							goto IL_0192;
						case 4:
							goto IL_023A;
						case 6:
							goto IL_0220;
						case 7:
							goto IL_043F;
						case 8:
							goto IL_0189;
						case 9:
							goto IL_0472;
						case 10:
							goto IL_03D3;
						case 12:
						case 47:
							if (c != ']')
							{
								goto IL_0211;
							}
							goto IL_0220;
						case 13:
							goto IL_0118;
						case 14:
							goto IL_0448;
						case 15:
							goto IL_0034;
						case 16:
							goto IL_0038;
						case 18:
							goto IL_017A;
						case 20:
							goto IL_03A8;
						case 21:
							goto IL_03CB;
						case 22:
							goto IL_0437;
						case 23:
						case 49:
							goto IL_0006;
						case 24:
							goto IL_0180;
						case 25:
							goto IL_0144;
						case 26:
							goto IL_046A;
						case 27:
							goto IL_0424;
						case 29:
							goto IL_0056;
						case 31:
							goto IL_00FC;
						case 32:
							goto IL_0154;
						case 34:
							goto IL_03D5;
						case 35:
							goto IL_0419;
						case 36:
							goto IL_022E;
						case 37:
							goto IL_00CE;
						case 39:
							goto IL_0246;
						case 40:
							goto IL_042C;
						case 42:
							goto IL_01A0;
						case 43:
							switch (currentState)
							{
							case JsonReader.State.Start:
							case JsonReader.State.Property:
							case JsonReader.State.ArrayStart:
							case JsonReader.State.Array:
							case JsonReader.State.ConstructorStart:
							case JsonReader.State.Constructor:
								break;
							case JsonReader.State.Complete:
							case JsonReader.State.ObjectStart:
							case JsonReader.State.Object:
							case JsonReader.State.Closed:
							case JsonReader.State.Error:
								goto IL_03E2;
							case JsonReader.State.PostValue:
								goto IL_0118;
							case JsonReader.State.Finished:
								this.method_27();
								num = 10;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
								{
									continue;
								}
								goto IL_03DF;
							default:
								num = 37;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
								{
									goto Block_15;
								}
								continue;
							}
							break;
						case 44:
							goto IL_03E2;
						case 45:
							goto IL_00E3;
						case 46:
							goto IL_047B;
						case 48:
							goto IL_002B;
						}
						goto Block_16;
						IL_0246:
						if (this._currentState != JsonReader.State.PostValue)
						{
							goto IL_041B;
						}
						num = 27;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
						{
							break;
						}
						continue;
						IL_023A:
						if (this._currentState != JsonReader.State.ArrayStart)
						{
							goto IL_0246;
						}
						goto IL_0424;
						IL_022E:
						if (this._currentState != JsonReader.State.Array)
						{
							goto IL_023A;
						}
						goto IL_0424;
						IL_0220:
						this.int_1++;
						goto IL_022E;
					}
					goto IL_0118;
					IL_0211:
					if (c != 'n')
					{
						goto IL_0192;
					}
					goto IL_0413;
					Block_16:
					goto IL_01A9;
					IL_0006:
					if (this.method_28())
					{
						goto IL_0472;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_01A9;
					}
					goto IL_02D5;
					IL_0034:
					if (c != '\0')
					{
						goto IL_0038;
					}
					goto IL_0006;
					IL_002B:
					if (c <= '9')
					{
						goto IL_0034;
					}
					goto IL_017A;
					IL_01A9:
					c = this.char_0[this.int_1];
					goto IL_002B;
					IL_00E3:
					if (this.char_0[this.int_1 + 1] != 'I')
					{
						goto IL_00FC;
					}
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						break;
					}
					goto IL_02D5;
					IL_0056:
					switch (c)
					{
					case ' ':
						IL_0144:
						this.int_1++;
						goto IL_01A9;
					case '!':
					case '#':
					case '$':
					case '%':
					case '&':
					case '(':
					case ')':
					case '*':
					case '+':
						goto IL_0192;
					case '"':
					case '\'':
						goto IL_042E;
					case ',':
						IL_00CE:
						this.method_23();
						goto IL_01A9;
					case '-':
						if (this.method_18(1, true))
						{
							goto IL_00E3;
						}
						goto IL_00FC;
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						goto IL_0441;
					case '/':
						this.method_52(false);
						goto IL_01A9;
					default:
						goto IL_0192;
					}
					IL_0038:
					switch (c)
					{
					case '\t':
						goto IL_0144;
					case '\n':
						IL_0154:
						this.method_45();
						goto IL_01A9;
					case '\v':
					case '\f':
						goto IL_0192;
					case '\r':
						this.method_46(false);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
						{
							goto IL_01A9;
						}
						goto IL_02D5;
					}
					goto IL_0056;
					IL_00FC:
					this.method_49(readType_0);
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						goto IL_02D5;
					}
					IL_0118:
					if (this.method_38(true))
					{
						goto IL_043F;
					}
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_01A9;
					}
					goto IL_02D5;
					IL_017A:
					if (c <= 'N')
					{
						goto IL_0180;
					}
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto Block_10;
					}
					goto IL_02D5;
					IL_01A0:
					if (char.IsWhiteSpace(c))
					{
						goto IL_01A9;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto Block_9;
					}
					goto IL_02D5;
					IL_0192:
					this.int_1++;
					goto IL_01A0;
					IL_0189:
					if (c != 'N')
					{
						goto IL_0192;
					}
					goto IL_0459;
					IL_0180:
					if (c != 'I')
					{
						goto IL_0189;
					}
					goto IL_0461;
				}
			}
			Block_9:
			goto IL_0450;
			Block_10:
			goto IL_046A;
			Block_15:
			goto IL_03E2;
			IL_03D3:
			return null;
			IL_03D5:
			return this.Value;
			IL_03DF:
			goto IL_0450;
			IL_03E2:
			throw JsonReaderException.Create(this, Class15.smethod_17(1788634298 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
			IL_0413:
			this.method_26();
			IL_0419:
			return null;
			IL_041B:
			throw this.method_22(c);
			IL_0424:
			base.SetToken(JsonToken.EndArray);
			IL_042C:
			return null;
			IL_042E:
			this.method_12(c, readType_0);
			IL_0437:
			return this.method_25(readType_0);
			IL_043F:
			return null;
			IL_0441:
			this.method_49(readType_0);
			IL_0448:
			return this.Value;
			IL_0450:
			throw this.method_22(c);
			IL_0459:
			return this.method_66(readType_0);
			IL_0461:
			return this.method_64(readType_0);
			IL_046A:
			return this.method_62(readType_0);
			IL_0472:
			base.SetToken(JsonToken.None, null, false);
			IL_047B:
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00031988 File Offset: 0x0002FB88
		[NullableContext(2)]
		private object method_25(ReadType readType_0)
		{
			while (readType_0 != ReadType.const_1)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0015;
				}
				IL_002A:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006D;
				case 3:
					goto IL_00AC;
				case 4:
					goto IL_0091;
				}
				IL_0015:
				if (readType_0 == ReadType.ReadAsDecimal)
				{
					return base.ReadDecimalString(this.stringReference_0.ToString());
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_002A;
				}
				IL_006D:
				if (readType_0 == ReadType.ReadAsDouble)
				{
					return base.ReadDoubleString(this.stringReference_0.ToString());
				}
				IL_0091:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(642128838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba));
			}
			IL_00AC:
			return base.ReadInt32String(this.stringReference_0.ToString());
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000314A File Offset: 0x0000134A
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return (DateTimeOffset?)this.method_20(ReadType.ReadAsDateTimeOffset);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003158 File Offset: 0x00001358
		public override decimal? ReadAsDecimal()
		{
			return (decimal?)this.method_24(ReadType.ReadAsDecimal);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003166 File Offset: 0x00001366
		public override double? ReadAsDouble()
		{
			return (double?)this.method_24(ReadType.ReadAsDouble);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00031A60 File Offset: 0x0002FC60
		private void method_26()
		{
			for (;;)
			{
				int num;
				if (this.method_18(1, true))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_007C;
					}
				}
				else
				{
					this.int_1 = this.int_0;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						break;
					}
					goto IL_007C;
				}
				IL_0066:
				while (this.char_0[this.int_1 + 1] != 'u')
				{
					this.int_1 += 2;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_007C;
					}
				}
				goto IL_0029;
				IL_007C:
				switch (num)
				{
				case 0:
					goto IL_0066;
				case 1:
					continue;
				case 2:
					goto IL_00C1;
				case 3:
					break;
				case 4:
					goto IL_00CB;
				case 5:
					return;
				default:
					goto IL_0066;
				}
				IL_0029:
				this.method_59();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto Block_2;
				}
				goto IL_007C;
			}
			goto IL_00C1;
			Block_2:
			return;
			IL_00C1:
			throw base.CreateUnexpectedEndException();
			IL_00CB:
			throw this.method_22(this.char_0[this.int_1 - 1]);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00031B50 File Offset: 0x0002FD50
		private void method_27()
		{
			for (;;)
			{
				if (this.method_18(0, false))
				{
					goto IL_0003;
				}
				goto IL_0063;
				IL_001A:
				int num;
				switch (num)
				{
				case 1:
					goto IL_0043;
				case 2:
					goto IL_0090;
				case 3:
					IL_0003:
					this.method_47();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
					{
						goto IL_001A;
					}
					goto IL_0043;
				case 4:
					continue;
				case 5:
					return;
				case 6:
					goto IL_005C;
				case 7:
					goto IL_0063;
				}
				break;
				IL_0063:
				base.SetToken(JsonToken.None);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					break;
				}
				goto IL_001A;
				IL_005C:
				this.method_52(false);
				goto IL_0063;
				IL_0043:
				if (this.bool_3)
				{
					return;
				}
				if (this.char_0[this.int_1] == '/')
				{
					goto IL_005C;
				}
				goto IL_0090;
			}
			return;
			IL_0090:
			throw JsonReaderException.Create(this, Class15.smethod_17(486533616 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00031C28 File Offset: 0x0002FE28
		private bool method_28()
		{
			IL_0057:
			while (this.int_0 == this.int_1)
			{
				IL_004B:
				while (this.method_15(false) == 0)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						for (;;)
						{
							switch (num)
							{
							case 1:
								this.bool_3 = true;
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
								{
									continue;
								}
								break;
							case 2:
								return false;
							case 3:
								goto IL_004B;
							case 4:
								goto IL_0057;
							}
							break;
						}
					}
					return true;
				}
				return false;
			}
			this.int_1++;
			return false;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		private void method_29()
		{
			for (;;)
			{
				IL_0077:
				if (this.char_0 == null)
				{
					goto IL_0039;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					break;
				}
				for (;;)
				{
					IL_001D:
					switch (num)
					{
					case 1:
						goto IL_0077;
					case 2:
						this.char_0[0] = '\0';
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_0039;
					}
					return;
				}
				IL_0039:
				this.char_0 = BufferUtils.RentBuffer(this.iarrayPool_0, 1024);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_001D;
				}
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00031D48 File Offset: 0x0002FF48
		private void method_30(char char_1)
		{
			int num;
			int num3;
			char c2;
			int num5;
			for (;;)
			{
				IL_0627:
				num = this.int_1;
				int num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_03F4;
				}
				char c;
				int num4;
				for (;;)
				{
					IL_0488:
					switch (num2)
					{
					case 0:
						goto IL_032C;
					case 1:
					case 5:
					case 7:
					case 19:
					case 20:
					case 28:
					case 44:
					case 85:
						goto IL_03F4;
					case 2:
					case 41:
					case 43:
					case 57:
					case 81:
					case 99:
						goto IL_0006;
					case 3:
						goto IL_004D;
					case 4:
						goto IL_0627;
					case 6:
						goto IL_02D0;
					case 8:
						goto IL_0254;
					case 9:
						goto IL_03A5;
					case 10:
						goto IL_033E;
					case 11:
						goto IL_0335;
					case 12:
						goto IL_03FA;
					case 13:
						goto IL_0246;
					case 14:
						goto IL_0144;
					case 15:
						break;
					case 16:
					case 64:
					case 68:
					case 83:
					case 100:
						goto IL_06BF;
					case 17:
					case 48:
						goto IL_0199;
					case 18:
						goto IL_0367;
					case 21:
						goto IL_00CB;
					case 22:
					case 34:
					case 35:
						goto IL_0284;
					case 23:
						goto IL_01BD;
					case 24:
					case 46:
						goto IL_027A;
					case 25:
					case 70:
						goto IL_0459;
					case 26:
						goto IL_02B2;
					case 27:
						goto IL_012C;
					case 29:
						goto IL_0055;
					case 30:
						goto IL_03C3;
					case 31:
						goto IL_00D3;
					case 32:
						goto IL_0221;
					case 33:
						goto IL_0406;
					case 36:
						goto IL_0166;
					case 37:
						goto IL_0415;
					case 38:
						goto IL_01E7;
					case 39:
					case 67:
						goto IL_035B;
					case 40:
						goto IL_008E;
					case 42:
					case 66:
						goto IL_0293;
					case 45:
						num++;
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							goto IL_032C;
						}
						continue;
					case 47:
						goto IL_01D1;
					case 49:
						goto IL_018D;
					case 50:
						goto IL_02BB;
					case 51:
						goto IL_005D;
					case 52:
						goto IL_028C;
					case 53:
						goto IL_010C;
					case 54:
						goto IL_0649;
					case 55:
						goto IL_0098;
					case 56:
						goto IL_009F;
					case 58:
						goto IL_0071;
					case 59:
						goto IL_023F;
					case 60:
						goto IL_00DC;
					case 61:
						goto IL_024B;
					case 62:
						goto IL_0185;
					case 63:
						goto IL_0201;
					case 65:
						goto IL_03F0;
					case 69:
					case 87:
						goto IL_0300;
					case 71:
						goto IL_0683;
					case 72:
						goto IL_030F;
					case 73:
						goto IL_01EB;
					case 74:
						goto IL_00F9;
					case 75:
						goto IL_06C7;
					case 76:
						num3 = this.int_1;
						num2 = 22;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
						{
							goto IL_027A;
						}
						continue;
					case 77:
						if (!this.method_18(2, true))
						{
							goto IL_035B;
						}
						goto IL_01BD;
					case 78:
						goto IL_00E5;
					case 79:
						goto IL_03E4;
					case 80:
						goto IL_02C4;
					case 82:
						goto IL_06AF;
					case 84:
						return;
					case 86:
						goto IL_0106;
					case 88:
						goto IL_0651;
					case 89:
						goto IL_00AC;
					case 90:
						goto IL_040F;
					case 91:
						goto IL_039F;
					case 92:
						goto IL_03C9;
					case 93:
						goto IL_0034;
					case 94:
						goto IL_002B;
					case 95:
						goto IL_0306;
					case 96:
						goto IL_01F9;
					case 97:
						goto IL_006B;
					case 98:
						goto IL_017D;
					default:
						goto IL_032C;
					}
					IL_01A5:
					bool flag = false;
					num2 = 77;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_01BD;
					}
					continue;
					IL_0199:
					if (StringUtils.IsHighSurrogate(c))
					{
						goto IL_01A5;
					}
					goto IL_0293;
					IL_018D:
					if (!StringUtils.IsLowSurrogate(c))
					{
						goto IL_0199;
					}
					goto IL_028C;
					IL_0185:
					c = this.method_34();
					goto IL_018D;
					IL_017D:
					this.int_1 = num;
					goto IL_0185;
					IL_033E:
					switch (c2)
					{
					case 'r':
						goto IL_039F;
					case 's':
						goto IL_06BF;
					case 't':
						IL_03A5:
						c = '\t';
						num2 = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
						{
							goto Block_21;
						}
						continue;
					case 'u':
						goto IL_017D;
					default:
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto Block_20;
						}
						continue;
					}
					IL_0335:
					if (c2 != 'n')
					{
						goto IL_033E;
					}
					goto IL_03C3;
					IL_0300:
					if (c2 <= 'f')
					{
						goto IL_0306;
					}
					goto IL_0335;
					IL_0201:
					if (!StringUtils.IsLowSurrogate(c))
					{
						goto IL_0221;
					}
					num2 = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_0284;
					}
					continue;
					IL_01F9:
					c = this.method_34();
					goto IL_0201;
					IL_01EB:
					this.int_1 += 2;
					goto IL_01F9;
					IL_01E7:
					char c3 = c;
					goto IL_01EB;
					IL_01D1:
					if (this.char_0[this.int_1 + 1] == 'u')
					{
						goto IL_01E7;
					}
					goto IL_035B;
					IL_01BD:
					if (this.char_0[this.int_1] == '\\')
					{
						goto IL_01D1;
					}
					goto IL_035B;
					IL_0221:
					if (!StringUtils.IsHighSurrogate(c))
					{
						goto IL_024B;
					}
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
					{
						goto IL_023F;
					}
					continue;
					IL_0254:
					this.method_32(c3, num3, num4);
					num2 = 76;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_035B;
					}
					continue;
					IL_0284:
					this.method_9();
					goto IL_0254;
					IL_024B:
					c3 = '\ufffd';
					goto IL_0284;
					IL_0246:
					flag = true;
					goto IL_0284;
					IL_023F:
					c3 = '\ufffd';
					goto IL_0246;
					IL_0293:
					num = this.int_1;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_032C;
					}
					continue;
					IL_028C:
					c = '\ufffd';
					goto IL_0293;
					IL_02D0:
					c = '\\';
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						goto IL_032C;
					}
					continue;
					IL_02C4:
					if (c2 != '\\')
					{
						goto Block_13;
					}
					goto IL_02D0;
					IL_02BB:
					if (c2 != '/')
					{
						goto IL_02C4;
					}
					goto IL_03F0;
					IL_02B2:
					if (c2 > '\'')
					{
						goto IL_02BB;
					}
					goto IL_03C9;
					IL_032C:
					if (c2 <= '\\')
					{
						goto IL_02B2;
					}
					num2 = 52;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0300;
					}
					continue;
					IL_030F:
					if (c2 == 'f')
					{
						goto IL_0367;
					}
					num2 = 100;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_02D0;
					}
					continue;
					IL_0306:
					if (c2 != 'b')
					{
						goto IL_030F;
					}
					goto IL_012C;
					IL_0367:
					c = '\f';
					num2 = 85;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_19;
					}
					continue;
					IL_03C9:
					if (c2 == '"')
					{
						goto IL_03F0;
					}
					num2 = 70;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_03E4;
					}
					continue;
					IL_027A:
					if (!flag)
					{
						goto IL_0293;
					}
					goto IL_01A5;
					IL_035B:
					c = '\ufffd';
					goto IL_027A;
				}
				Block_21:
				goto IL_0144;
				IL_03F0:
				c = c2;
				goto IL_03F4;
				IL_03E4:
				if (c2 != '\'')
				{
					goto Block_23;
				}
				goto IL_03F0;
				IL_03C3:
				c = '\n';
				goto IL_03F4;
				IL_039F:
				c = '\r';
				goto IL_03F4;
				IL_0415:
				if (this.method_15(true) == 0)
				{
					goto Block_24;
				}
				goto IL_0006;
				IL_040F:
				num--;
				goto IL_0415;
				IL_0459:
				if (this.int_0 == num - 1)
				{
					goto IL_040F;
				}
				IL_0006:
				char c4 = this.char_0[num++];
				num2 = 76;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_002B;
				}
				goto IL_0488;
				IL_005D:
				this.stringBuffer_0.Position = 0;
				goto IL_0006;
				IL_0055:
				num3 = this.int_1;
				goto IL_005D;
				IL_004D:
				num5 = this.int_1;
				goto IL_0055;
				IL_0034:
				if (c4 != '\0')
				{
					goto IL_006B;
				}
				num2 = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_004D;
				}
				goto IL_0488;
				IL_002B:
				if (c4 <= '\r')
				{
					goto IL_0034;
				}
				goto IL_00D3;
				IL_0071:
				if (c4 == '\r')
				{
					goto IL_008E;
				}
				num2 = 81;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					goto IL_0098;
				}
				goto IL_0488;
				IL_006B:
				if (c4 != '\n')
				{
					goto IL_0071;
				}
				IL_00AC:
				this.int_1 = num - 1;
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_00CB;
				}
				goto IL_0488;
				IL_010C:
				c2 = this.char_0[num];
				num2 = 45;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_012C;
				}
				goto IL_0488;
				IL_0106:
				num4 = num - 1;
				goto IL_010C;
				IL_00F9:
				if (this.method_18(0, true))
				{
					goto IL_0106;
				}
				goto IL_0683;
				IL_00E5:
				if (c4 != '\\')
				{
					goto IL_0006;
				}
				this.int_1 = num;
				goto IL_00F9;
				IL_00DC:
				if (c4 != '\'')
				{
					goto IL_00E5;
				}
				goto IL_0166;
				IL_00D3:
				if (c4 != '"')
				{
					goto IL_00DC;
				}
				goto IL_0166;
				IL_012C:
				c = '\b';
				num2 = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_0488;
				}
				IL_0144:
				num = this.int_1;
				num2 = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0006;
				}
				goto IL_0488;
				IL_00CB:
				this.method_45();
				goto IL_0144;
				IL_009F:
				num = this.int_1;
				goto IL_0006;
				IL_0098:
				this.method_46(true);
				goto IL_009F;
				IL_008E:
				this.int_1 = num - 1;
				goto IL_0098;
				IL_0166:
				if (this.char_0[num - 1] == char_1)
				{
					break;
				}
				goto IL_0006;
				IL_0406:
				num3 = num;
				goto IL_0006;
				IL_03FA:
				this.method_32(c, num3, num4);
				goto IL_0406;
				IL_03F4:
				this.method_9();
				goto IL_03FA;
			}
			goto IL_06AF;
			Block_13:
			Block_19:
			Block_20:
			Block_23:
			goto IL_06BF;
			Block_24:
			IL_0649:
			this.int_1 = num;
			IL_0651:
			throw JsonReaderException.Create(this, Class15.smethod_17(1802354191 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4).FormatWith(CultureInfo.InvariantCulture, char_1));
			IL_0683:
			throw JsonReaderException.Create(this, Class15.smethod_17(2021168756 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, char_1));
			IL_06AF:
			this.method_31(num - 1, num5, num3);
			return;
			IL_06BF:
			this.int_1 = num;
			IL_06C7:
			throw JsonReaderException.Create(this, Class15.smethod_17(82305752 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(552187302 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f) + c2.ToString()));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00032464 File Offset: 0x00030664
		private void method_31(int int_4, int int_5, int int_6)
		{
			for (;;)
			{
				if (int_5 != int_6)
				{
					goto IL_00BC;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					break;
				}
				IL_008F:
				switch (num)
				{
				case 1:
					goto IL_007A;
				case 2:
					this.stringReference_0 = new StringReference(this.char_0, int_5, int_4 - int_5);
					goto IL_0043;
				case 3:
					continue;
				case 4:
				case 6:
					goto IL_0043;
				case 5:
					goto IL_0021;
				case 7:
					goto IL_00BC;
				case 8:
					this.stringBuffer_0.Append(this.iarrayPool_0, this.char_0, int_6, int_4 - int_6);
					goto IL_0021;
				}
				break;
				IL_0043:
				this.int_1 = int_4 + 1;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					break;
				}
				goto IL_008F;
				IL_0021:
				this.stringReference_0 = new StringReference(this.stringBuffer_0.InternalBuffer, 0, this.stringBuffer_0.Position);
				goto IL_0043;
				IL_00BC:
				this.method_9();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					goto IL_008F;
				}
				IL_007A:
				if (int_4 <= int_6)
				{
					goto IL_0021;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_008F;
				}
				goto IL_00BC;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00032568 File Offset: 0x00030768
		private void method_32(char char_1, int int_4, int int_5)
		{
			for (;;)
			{
				if (int_5 > int_4)
				{
					goto IL_0045;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0006;
				}
				IL_0029:
				switch (num)
				{
				case 2:
					continue;
				case 3:
					return;
				case 4:
					IL_0045:
					this.stringBuffer_0.Append(this.iarrayPool_0, this.char_0, int_4, int_5 - int_4);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_0029;
					}
					break;
				}
				IL_0006:
				this.stringBuffer_0.Append(this.iarrayPool_0, char_1);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0029;
				}
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0003260C File Offset: 0x0003080C
		private char method_33(bool bool_4)
		{
			int num2;
			for (;;)
			{
				if (bool_4)
				{
					goto IL_002C;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_00BE;
				case 3:
					IL_002C:
					if (!ConvertUtils.TryHexTextToInt(this.char_0, this.int_1, this.int_1 + 4, out num2))
					{
						goto IL_0086;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0014;
					}
					goto IL_0083;
				}
				break;
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(635798949 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
			IL_0083:
			goto IL_00BE;
			IL_0086:
			throw JsonReaderException.Create(this, Class15.smethod_17(2008563267 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, new string(this.char_0, this.int_1, 4)));
			IL_00BE:
			char c = Convert.ToChar(num2);
			this.int_1 += 4;
			return c;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003174 File Offset: 0x00001374
		private char method_34()
		{
			return this.method_33(this.method_18(4, true));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000326EC File Offset: 0x000308EC
		private void method_35()
		{
			for (;;)
			{
				int num = this.int_1;
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_0064;
				}
				IL_0071:
				switch (num2)
				{
				case 0:
					goto IL_001C;
				case 1:
				case 4:
					goto IL_0064;
				case 2:
					continue;
				case 3:
					return;
				case 5:
					return;
				case 6:
					goto IL_0031;
				case 7:
					goto IL_0024;
				case 8:
					break;
				default:
					goto IL_001C;
				}
				IL_0006:
				char c;
				if (c == '\0')
				{
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_001C;
					}
					goto IL_0071;
				}
				else
				{
					if (this.method_36(c, num))
					{
						break;
					}
					num++;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_0071;
					}
				}
				IL_0064:
				c = this.char_0[num];
				goto IL_0006;
				IL_0031:
				if (this.method_15(true) != 0)
				{
					goto IL_0064;
				}
				return;
				IL_0024:
				if (this.int_0 == num)
				{
					goto IL_0031;
				}
				return;
				IL_001C:
				this.int_1 = num;
				goto IL_0024;
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000327B8 File Offset: 0x000309B8
		private bool method_36(char char_1, int int_4)
		{
			for (;;)
			{
				if (char_1 > 'X')
				{
					goto IL_017A;
				}
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0020;
				}
				IL_0136:
				switch (num)
				{
				case 0:
					goto IL_0128;
				case 1:
					goto IL_00CD;
				case 2:
					goto IL_00A1;
				case 3:
					goto IL_0099;
				case 4:
					goto IL_0109;
				case 5:
					goto IL_00E7;
				case 6:
					break;
				case 7:
					goto IL_00A8;
				case 8:
					return false;
				case 9:
					goto IL_00EF;
				case 10:
					IL_0020:
					switch (char_1)
					{
					case '+':
					case '-':
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
						return false;
					case ',':
					case '/':
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
						goto IL_00A1;
					}
					goto IL_0099;
				case 11:
					continue;
				case 12:
				case 14:
					return true;
				case 13:
					IL_017A:
					switch (char_1)
					{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
						return false;
					default:
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto IL_0128;
						}
						goto IL_0136;
					}
					break;
				default:
					goto IL_0128;
				}
				IL_00B3:
				if (char_1 == ',')
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_00CD;
				}
				goto IL_0136;
				IL_00A8:
				if (!char.IsWhiteSpace(char_1))
				{
					goto IL_00B3;
				}
				break;
				IL_00A1:
				this.int_1 = int_4;
				goto IL_00A8;
				IL_00CD:
				if (char_1 == '}')
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_00E7;
				}
				goto IL_0136;
				IL_00EF:
				if (char_1 == ')')
				{
					break;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0109;
				}
				goto IL_0136;
				IL_00E7:
				if (char_1 != ']')
				{
					goto IL_00EF;
				}
				break;
				IL_0109:
				if (char_1 != '/')
				{
					goto IL_01C3;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					break;
				}
				goto IL_0136;
				IL_0099:
				if (char_1 != 'X')
				{
					goto IL_00A1;
				}
				return false;
				IL_0128:
				if (char_1 == 'x')
				{
					goto Block_7;
				}
				goto IL_00A1;
			}
			return true;
			Block_7:
			return false;
			IL_01C3:
			throw JsonReaderException.Create(this, Class15.smethod_17(1788741113 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, char_1));
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000329B8 File Offset: 0x00030BB8
		private void method_37()
		{
			for (;;)
			{
				this.stringBuffer_0.Position = 0;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.stringReference_0 = default(StringReference);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_0020;
				}
				break;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00032A1C File Offset: 0x00030C1C
		private bool method_38(bool bool_4)
		{
			char c;
			for (;;)
			{
				IL_034F:
				c = this.char_0[this.int_1];
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_021E;
				}
				for (;;)
				{
					IL_024D:
					switch (num)
					{
					case 1:
					case 3:
					case 17:
					case 18:
					case 20:
					case 28:
					case 32:
						goto IL_034F;
					case 2:
						goto IL_00A6;
					case 4:
						goto IL_0393;
					case 5:
						goto IL_013E;
					case 6:
					case 7:
						goto IL_00C1;
					case 8:
					case 19:
					case 21:
					case 30:
					case 39:
						goto IL_015C;
					case 9:
						goto IL_00F3;
					case 10:
						return true;
					case 11:
						goto IL_0378;
					case 12:
						return true;
					case 13:
						goto IL_01CB;
					case 14:
						goto IL_0077;
					case 15:
						return true;
					case 16:
						goto IL_0030;
					case 22:
						goto IL_0083;
					case 23:
						return false;
					case 24:
						goto IL_023E;
					case 25:
						goto IL_033B;
					case 26:
						return true;
					case 27:
					case 41:
						goto IL_00E5;
					case 29:
						goto IL_03FB;
					case 31:
						goto IL_021E;
					case 33:
					case 34:
						goto IL_0059;
					case 35:
					case 48:
						if (c > '/')
						{
							goto IL_0059;
						}
						goto IL_01CB;
					case 36:
						goto IL_00E1;
					case 37:
						if (this.Depth != 0)
						{
							goto IL_03A8;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							goto Block_21;
						}
						continue;
					case 38:
					case 47:
						if (!base.SupportMultipleContent)
						{
							goto IL_03A8;
						}
						num = 37;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
						{
							goto Block_19;
						}
						continue;
					case 40:
						return false;
					case 42:
						goto IL_0182;
					case 43:
						goto IL_039B;
					case 44:
						goto IL_0333;
					case 45:
						return false;
					case 46:
						goto IL_03D5;
					case 49:
						goto IL_0006;
					}
					goto Block_25;
					IL_0006:
					if (c == '/')
					{
						this.method_52(!bool_4);
						goto IL_0030;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						break;
					}
					continue;
					IL_01CB:
					if (c != ',')
					{
						goto IL_0006;
					}
					goto IL_03ED;
					IL_0030:
					if (bool_4)
					{
						break;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto Block_4;
					}
					continue;
					IL_0059:
					if (c != ']')
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
						{
							goto IL_0077;
						}
					}
					else
					{
						this.int_1++;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							goto Block_16;
						}
					}
				}
				continue;
				IL_023E:
				if (c != ')')
				{
					goto IL_015C;
				}
				goto IL_0382;
				IL_00F3:
				if (this.method_15(false) == 0)
				{
					goto IL_03D5;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					continue;
				}
				goto IL_024D;
				IL_00E5:
				if (this.int_0 == this.int_1)
				{
					goto IL_00F3;
				}
				this.int_1++;
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_015C;
				}
				goto IL_024D;
				IL_00E1:
				if (c == '\0')
				{
					goto IL_00E5;
				}
				goto IL_013E;
				IL_00A6:
				if (c <= '\r')
				{
					goto IL_00E1;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_00C1;
				}
				goto IL_024D;
				IL_021E:
				if (c <= ')')
				{
					goto IL_00A6;
				}
				num = 35;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_0077;
				}
				goto IL_024D;
				IL_0083:
				this.int_1++;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_00A6;
				}
				goto IL_024D;
				IL_0077:
				if (c != '}')
				{
					goto IL_015C;
				}
				goto IL_0083;
				IL_0182:
				this.method_46(false);
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					continue;
				}
				goto IL_024D;
				IL_013E:
				switch (c)
				{
				case '\t':
					IL_0323:
					this.int_1++;
					continue;
				case '\n':
					IL_0333:
					this.method_45();
					continue;
				default:
					IL_015C:
					if (char.IsWhiteSpace(c))
					{
						goto IL_033B;
					}
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto Block_14;
					}
					goto IL_024D;
				case '\r':
					goto IL_0182;
				}
				IL_00C1:
				if (c == ' ')
				{
					goto IL_0323;
				}
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					goto IL_015C;
				}
				goto IL_024D;
				IL_033B:
				this.int_1++;
			}
			Block_4:
			return true;
			Block_14:
			return true;
			Block_16:
			goto IL_03E3;
			Block_19:
			goto IL_03FB;
			Block_21:
			goto IL_0393;
			Block_25:
			goto IL_03E3;
			IL_0378:
			base.SetToken(JsonToken.EndObject);
			return true;
			IL_0382:
			this.int_1++;
			goto IL_039B;
			IL_0393:
			base.SetStateBasedOnCurrent();
			return false;
			IL_039B:
			base.SetToken(JsonToken.EndConstructor);
			return true;
			IL_03A8:
			throw JsonReaderException.Create(this, Class15.smethod_17(698991698 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, c));
			IL_03D5:
			this._currentState = JsonReader.State.Finished;
			return false;
			IL_03E3:
			base.SetToken(JsonToken.EndArray);
			return true;
			IL_03ED:
			this.int_1++;
			IL_03FB:
			base.SetStateBasedOnCurrent();
			return false;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00032E30 File Offset: 0x00031030
		private bool method_39()
		{
			for (;;)
			{
				char c = this.char_0[this.int_1];
				int num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0006;
				}
				goto IL_0101;
				IL_0037:
				this.method_45();
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					continue;
				}
				goto IL_0101;
				IL_0013:
				switch (c)
				{
				case '\t':
					IL_01A2:
					this.int_1++;
					continue;
				case '\n':
					goto IL_0037;
				case '\v':
				case '\f':
					goto IL_00C4;
				case '\r':
					this.method_46(false);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						continue;
					}
					goto IL_0101;
				default:
					goto IL_00C4;
				}
				IL_000F:
				if (c != '\0')
				{
					goto IL_0013;
				}
				goto IL_0078;
				IL_0006:
				if (c <= '\r')
				{
					goto IL_000F;
				}
				goto IL_00A0;
				IL_00D0:
				this.int_1++;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					continue;
				}
				goto IL_0101;
				IL_00C4:
				if (char.IsWhiteSpace(c))
				{
					goto IL_00D0;
				}
				goto IL_01F3;
				IL_00A9:
				if (c == '/')
				{
					goto IL_01FA;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_00C4;
				}
				goto IL_0101;
				IL_00A0:
				if (c != ' ')
				{
					goto IL_00A9;
				}
				goto IL_01A2;
				IL_0101:
				switch (num)
				{
				case 1:
				case 2:
				case 8:
					goto IL_00C4;
				case 3:
				case 13:
				case 14:
				case 21:
				case 22:
				case 23:
				case 27:
					continue;
				case 4:
				case 19:
					goto IL_01F3;
				case 5:
					return true;
				case 6:
					goto IL_0013;
				case 7:
					if (c != '}')
					{
						goto IL_00C4;
					}
					goto IL_01D9;
				case 9:
					goto IL_0037;
				case 10:
					goto IL_01D9;
				case 11:
					goto IL_00A0;
				case 12:
					goto IL_01E1;
				case 15:
					return false;
				case 16:
					goto IL_000F;
				case 17:
					goto IL_00D0;
				case 18:
					goto IL_00A9;
				case 20:
					return true;
				case 24:
					goto IL_01A2;
				case 25:
					goto IL_0183;
				case 26:
					goto IL_0006;
				}
				IL_0078:
				if (this.int_0 != this.int_1)
				{
					this.int_1++;
					continue;
				}
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_0101;
				}
				IL_0183:
				if (this.method_15(false) == 0)
				{
					return false;
				}
			}
			IL_01D9:
			base.SetToken(JsonToken.EndObject);
			IL_01E1:
			this.int_1++;
			return true;
			IL_01F3:
			return this.method_40();
			IL_01FA:
			this.method_52(true);
			return true;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00033040 File Offset: 0x00031240
		private bool method_40()
		{
			for (;;)
			{
				IL_029C:
				char c = this.char_0[this.int_1];
				for (;;)
				{
					if (c == '"')
					{
						goto IL_0251;
					}
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_01AC;
					}
					IL_01D9:
					switch (num)
					{
					case 0:
						goto IL_010C;
					case 1:
					case 9:
						goto IL_013C;
					case 2:
						goto IL_0251;
					case 3:
						goto IL_00B2;
					case 4:
						goto IL_00C0;
					case 5:
						goto IL_01C9;
					case 6:
						goto IL_0024;
					case 7:
						goto IL_0050;
					case 8:
						goto IL_0157;
					case 10:
						IL_01AC:
						if (c != '\'')
						{
							goto IL_01C9;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto IL_0251;
						}
						goto IL_01D9;
					case 11:
						goto IL_0088;
					case 12:
						goto IL_0192;
					case 13:
						goto IL_02AD;
					case 14:
						goto IL_02E6;
					case 15:
					case 23:
						goto IL_0114;
					case 16:
						goto IL_002C;
					case 17:
					case 24:
						goto IL_00B8;
					case 18:
						goto IL_006B;
					case 19:
						goto IL_00EE;
					case 20:
						return true;
					case 21:
						continue;
					case 22:
						goto IL_029C;
					case 25:
						goto IL_004C;
					case 26:
						break;
					default:
						goto IL_010C;
					}
					IL_0006:
					string text;
					base.SetToken(JsonToken.PropertyName, text);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						goto IL_0024;
					}
					goto IL_01D9;
					IL_0157:
					if (this.char_0[this.int_1] == ':')
					{
						this.int_1++;
						goto IL_0006;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto Block_6;
					}
					goto IL_01D9;
					IL_002C:
					this.method_37();
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto Block_1;
					}
					goto IL_01D9;
					IL_0024:
					char c2;
					this._quoteChar = c2;
					goto IL_002C;
					IL_0050:
					this.method_14();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
					{
						goto IL_006B;
					}
					goto IL_01D9;
					IL_004C:
					c2 = c;
					goto IL_0050;
					IL_006B:
					this.method_30(c2);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_01D9;
					}
					IL_0088:
					text = this.stringReference_0.ToString();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_010C;
					}
					goto IL_01D9;
					IL_00EE:
					if (text != null)
					{
						goto IL_013C;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_0088;
					}
					goto IL_01D9;
					IL_00C0:
					text = this.PropertyNameTable.Get(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length);
					goto IL_00EE;
					IL_00B8:
					if (this.PropertyNameTable != null)
					{
						goto IL_00C0;
					}
					goto IL_0114;
					IL_00B2:
					this.method_42();
					goto IL_00B8;
					IL_010C:
					this.method_14();
					goto IL_00B2;
					IL_0114:
					text = this.stringReference_0.ToString();
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_01D9;
					}
					IL_013C:
					this.method_47();
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_0157;
					}
					goto IL_01D9;
					IL_0192:
					c2 = '\0';
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_010C;
					}
					goto IL_01D9;
					IL_01C9:
					if (this.method_41(c))
					{
						goto IL_0192;
					}
					goto IL_02AD;
					IL_0251:
					this.int_1++;
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_004C;
					}
					goto IL_01D9;
				}
			}
			Block_1:
			return true;
			Block_6:
			goto IL_02E6;
			IL_02AD:
			throw JsonReaderException.Create(this, Class15.smethod_17(1396572064 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
			IL_02E6:
			throw JsonReaderException.Create(this, Class15.smethod_17(2008562853 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00033370 File Offset: 0x00031570
		private bool method_41(char char_1)
		{
			for (;;)
			{
				if (!char.IsLetterOrDigit(char_1))
				{
					goto IL_002C;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0057;
				case 3:
					IL_002C:
					if (char_1 != '_')
					{
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
						{
							goto IL_0014;
						}
						goto IL_0056;
					}
					break;
				}
				break;
			}
			return true;
			IL_0056:
			IL_0057:
			return char_1 == '$';
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000333DC File Offset: 0x000315DC
		private void method_42()
		{
			for (;;)
			{
				IL_00F3:
				int num = this.int_1;
				for (;;)
				{
					IL_00E2:
					char c = this.char_0[this.int_1];
					for (;;)
					{
						if (c != '\0')
						{
							goto IL_005C;
						}
						goto IL_00C3;
						IL_007C:
						int num2;
						switch (num2)
						{
						case 1:
							goto IL_0100;
						case 2:
							continue;
						case 3:
							return;
						case 4:
							IL_005C:
							if (this.method_43(c, num))
							{
								return;
							}
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
							{
								goto IL_007C;
							}
							goto IL_00E1;
						case 5:
							IL_00C3:
							if (this.int_0 == this.int_1)
							{
								num2 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
								{
									goto IL_0039;
								}
								goto IL_007C;
							}
							else
							{
								this.stringReference_0 = new StringReference(this.char_0, num, this.int_1 - num);
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
								{
									goto IL_007C;
								}
							}
							break;
						case 6:
						case 8:
							goto IL_00E2;
						case 7:
							goto IL_0039;
						case 9:
							goto IL_00F3;
						}
						goto Block_5;
						IL_0039:
						if (this.method_15(true) != 0)
						{
							break;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto Block_3;
						}
						goto IL_007C;
					}
					IL_00E1:;
				}
			}
			Block_3:
			Block_5:
			return;
			IL_0100:
			throw JsonReaderException.Create(this, Class15.smethod_17(1603797078 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00033508 File Offset: 0x00031708
		private bool method_43(char char_1, int int_4)
		{
			for (;;)
			{
				IL_00CB:
				int num;
				if (this.method_41(char_1))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_0072;
					}
				}
				else
				{
					if (char.IsWhiteSpace(char_1))
					{
						goto IL_0025;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						continue;
					}
				}
				for (;;)
				{
					IL_0097:
					switch (num)
					{
					case 1:
						goto IL_00CB;
					case 2:
						if (char_1 != ':')
						{
							goto IL_00E0;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							goto Block_5;
						}
						continue;
					case 3:
						return false;
					case 4:
						return true;
					case 5:
						goto IL_0025;
					}
					break;
				}
				goto IL_0072;
				Block_5:
				IL_0025:
				this.stringReference_0 = new StringReference(this.char_0, int_4, this.int_1 - int_4);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					break;
				}
				goto IL_0097;
				IL_0072:
				this.int_1++;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
				{
					goto Block_6;
				}
				goto IL_0097;
			}
			return true;
			Block_6:
			return false;
			IL_00E0:
			throw JsonReaderException.Create(this, Class15.smethod_17(1603797226 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, char_1));
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00033624 File Offset: 0x00031824
		private bool method_44()
		{
			char c;
			char c2;
			for (;;)
			{
				IL_0556:
				c = this.char_0[this.int_1];
				int num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0255;
				}
				goto IL_03EC;
				do
				{
					IL_018F:
					this.method_45();
					num = 72;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0);
				for (;;)
				{
					IL_03EC:
					switch (num)
					{
					case 1:
						return true;
					case 2:
					case 8:
					case 24:
					case 32:
					case 56:
					case 60:
					case 73:
						goto IL_0018;
					case 3:
						goto IL_0631;
					case 4:
						goto IL_052F;
					case 5:
						return true;
					case 6:
						goto IL_0183;
					case 9:
						goto IL_03C6;
					case 10:
						goto IL_01EA;
					case 11:
						goto IL_066E;
					case 12:
					case 42:
						if (c <= 'f')
						{
							goto IL_03C6;
						}
						goto IL_01DB;
					case 13:
						goto IL_0160;
					case 14:
					case 57:
						goto IL_01DB;
					case 15:
						goto IL_027B;
					case 16:
						goto IL_03CF;
					case 17:
					case 36:
						return true;
					case 18:
						return true;
					case 19:
						return true;
					case 20:
					case 43:
						return true;
					case 21:
						return true;
					case 22:
					case 41:
					case 49:
					case 51:
					case 59:
					case 72:
						goto IL_0556;
					case 23:
						goto IL_0275;
					case 25:
						goto IL_02A2;
					case 26:
						return true;
					case 27:
						goto IL_01E4;
					case 28:
						goto IL_000F;
					case 29:
						return true;
					case 30:
						goto IL_003B;
					case 31:
						goto IL_02A8;
					case 33:
						goto IL_013F;
					case 34:
						goto IL_0299;
					case 35:
						goto IL_0592;
					case 37:
						goto IL_0121;
					case 38:
						return true;
					case 39:
						goto IL_0372;
					case 40:
						goto IL_0654;
					case 44:
						switch (c)
						{
						case '\'':
							goto IL_0612;
						case '(':
						case '*':
						case '+':
						case '.':
							goto IL_0018;
						case ')':
							goto IL_05AF;
						case ',':
							base.SetToken(JsonToken.Undefined);
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
							{
								goto Block_31;
							}
							continue;
						case '-':
							if (this.method_18(1, true))
							{
								goto IL_0372;
							}
							goto IL_0234;
						case '/':
							this.method_52(true);
							num = 27;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								goto Block_34;
							}
							continue;
						default:
							num = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 45:
						goto IL_02D9;
					case 46:
						return true;
					case 47:
						goto IL_0282;
					case 48:
						goto IL_0255;
					case 50:
						goto IL_05FF;
					case 52:
						goto IL_05DE;
					case 53:
					case 55:
						goto IL_0234;
					case 54:
						goto IL_0612;
					case 58:
						goto IL_0076;
					case 61:
						return true;
					case 62:
						goto IL_01CC;
					case 63:
						return true;
					case 64:
						goto IL_0666;
					case 65:
						goto IL_01AC;
					case 66:
						goto IL_005B;
					case 67:
						goto IL_018F;
					case 68:
						return true;
					case 69:
						return true;
					case 70:
						goto IL_00FB;
					case 71:
						goto IL_00D5;
					case 74:
						goto IL_0624;
					case 75:
						return false;
					case 76:
						goto IL_0006;
					case 77:
						goto IL_0660;
					}
					goto Block_36;
					IL_0006:
					if (c != 'u')
					{
						break;
					}
					this.method_60();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						goto Block_8;
					}
					continue;
					IL_01DB:
					if (c <= 't')
					{
						goto IL_01E4;
					}
					goto IL_0006;
					IL_00FB:
					c2 = this.char_0[this.int_1 + 1];
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						continue;
					}
					IL_0121:
					if (c2 != 'u')
					{
						goto IL_0660;
					}
					num = 52;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_013F;
					}
					continue;
					IL_01EA:
					if (c == 't')
					{
						goto IL_05E9;
					}
					num = 73;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto Block_19;
					}
					continue;
					IL_01E4:
					if (c != 'n')
					{
						goto IL_01EA;
					}
					if (!this.method_18(1, true))
					{
						goto IL_05F1;
					}
					num = 51;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_00FB;
					}
					continue;
					IL_0234:
					this.method_49(ReadType.Read);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto Block_22;
					}
					continue;
					IL_0372:
					if (this.char_0[this.int_1 + 1] != 'I')
					{
						goto IL_0234;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						continue;
					}
					IL_02D9:
					this.method_62(ReadType.Read);
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto Block_28;
					}
					continue;
					IL_03CF:
					if (c == ']')
					{
						goto IL_0584;
					}
					num = 62;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						continue;
					}
					goto IL_0581;
					IL_03C6:
					if (c != '[')
					{
						goto IL_03CF;
					}
					goto IL_059C;
				}
				IL_000F:
				if (c != '{')
				{
					goto IL_0018;
				}
				goto IL_0646;
				IL_052F:
				this.int_1++;
				continue;
				Block_36:
				goto IL_0094;
				IL_01CC:
				if (c == 'f')
				{
					goto IL_0608;
				}
				Block_30:
				goto IL_0018;
				IL_00D5:
				if (this.method_15(false) != 0)
				{
					continue;
				}
				num = 48;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto Block_10;
				}
				goto IL_03EC;
				IL_0282:
				if (this.int_0 == this.int_1)
				{
					goto IL_00D5;
				}
				this.int_1++;
				continue;
				IL_027B:
				if (c == '\0')
				{
					goto IL_0282;
				}
				goto IL_013F;
				IL_0275:
				if (c <= ' ')
				{
					goto IL_027B;
				}
				goto IL_0299;
				IL_0255:
				if (c <= 'N')
				{
					goto IL_0275;
				}
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					break;
				}
				goto IL_03EC;
				IL_003B:
				if (!char.IsNumber(c))
				{
					goto IL_005B;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0094;
				}
				goto IL_03EC;
				IL_0018:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_003B;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					break;
				}
				goto IL_03EC;
				IL_005B:
				if (c == '-')
				{
					goto IL_0094;
				}
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_03EC;
				}
				IL_0076:
				if (c != '.')
				{
					goto IL_063A;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_03EC;
				}
				IL_0094:
				this.method_49(ReadType.Read);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto Block_7;
				}
				goto IL_03EC;
				IL_0160:
				this.int_1++;
				num = 59;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					goto IL_03EC;
				}
				IL_0183:
				if (c != ' ')
				{
					goto IL_0018;
				}
				goto IL_0160;
				IL_01AC:
				if (c == '"')
				{
					goto IL_0612;
				}
				num = 44;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
				{
					goto IL_0183;
				}
				goto IL_03EC;
				IL_0299:
				if (c <= '/')
				{
					goto IL_01AC;
				}
				IL_02A2:
				if (c != 'I')
				{
					goto IL_02A8;
				}
				this.method_64(ReadType.Read);
				num = 69;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					break;
				}
				goto IL_03EC;
				IL_013F:
				switch (c)
				{
				case '\t':
					goto IL_0160;
				case '\n':
					goto IL_018F;
				case '\v':
				case '\f':
					goto IL_0018;
				case '\r':
					this.method_46(false);
					continue;
				default:
					goto IL_0183;
				}
				IL_02A8:
				if (c != 'N')
				{
					goto IL_0018;
				}
				goto IL_05CD;
			}
			goto IL_0631;
			Block_7:
			return true;
			Block_8:
			return true;
			Block_10:
			return false;
			Block_19:
			goto IL_05DE;
			Block_22:
			return true;
			goto IL_0631;
			Block_28:
			return true;
			Block_31:
			goto IL_0631;
			Block_34:
			return true;
			IL_0581:
			return true;
			IL_0584:
			this.int_1++;
			IL_0592:
			base.SetToken(JsonToken.EndArray);
			return true;
			IL_059C:
			this.int_1++;
			goto IL_0631;
			IL_05AF:
			this.int_1++;
			goto IL_0624;
			IL_05CD:
			this.method_66(ReadType.Read);
			return true;
			IL_05DE:
			this.method_59();
			return true;
			IL_05E9:
			this.method_58();
			return true;
			IL_05F1:
			this.int_1++;
			IL_05FF:
			throw base.CreateUnexpectedEndException();
			IL_0608:
			this.method_61();
			return true;
			IL_0612:
			this.method_12(c, ReadType.Read);
			return true;
			IL_0624:
			base.SetToken(JsonToken.EndConstructor);
			return true;
			IL_0631:
			base.SetToken(JsonToken.StartArray);
			return true;
			IL_063A:
			throw this.method_22(c);
			IL_0646:
			this.int_1++;
			IL_0654:
			base.SetToken(JsonToken.StartObject);
			return true;
			IL_0660:
			if (c2 != 'e')
			{
				goto IL_066E;
			}
			IL_0666:
			this.method_48();
			return true;
			IL_066E:
			throw this.method_22(this.char_0[this.int_1]);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00033CB4 File Offset: 0x00031EB4
		private void method_45()
		{
			for (;;)
			{
				this.int_1++;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_11(this.int_1);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
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

		// Token: 0x06000446 RID: 1094 RVA: 0x00033D18 File Offset: 0x00031F18
		private void method_46(bool bool_4)
		{
			for (;;)
			{
				this.int_1++;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_10(this.method_18(1, bool_4));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
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

		// Token: 0x06000447 RID: 1095 RVA: 0x00033D80 File Offset: 0x00031F80
		private void method_47()
		{
			for (;;)
			{
				IL_010F:
				char c = this.char_0[this.int_1];
				IL_00BC:
				while (c != '\0')
				{
					IL_00B3:
					while (c != '\n')
					{
						for (;;)
						{
							if (c == '\r')
							{
								goto IL_0075;
							}
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								goto IL_0006;
							}
							IL_0020:
							switch (num)
							{
							case 1:
								goto IL_0075;
							case 2:
							case 4:
							case 5:
							case 7:
							case 17:
								goto IL_010F;
							case 3:
								goto IL_00B3;
							case 6:
								goto IL_00BC;
							case 8:
								goto IL_00DF;
							case 9:
							case 12:
								return;
							case 10:
								goto IL_00E7;
							case 11:
								goto IL_00CF;
							case 13:
								goto IL_00C6;
							case 14:
								return;
							case 15:
								continue;
							case 16:
								goto IL_00F5;
							}
							IL_0006:
							if (c == ' ')
							{
								goto IL_00CF;
							}
							num = 13;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
							{
								goto IL_0020;
							}
							IL_0075:
							this.method_46(false);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
							{
								break;
							}
							goto IL_0020;
						}
						goto IL_010F;
						IL_00CF:
						this.int_1++;
						goto IL_010F;
						IL_00C6:
						if (char.IsWhiteSpace(c))
						{
							goto IL_00CF;
						}
						return;
					}
					IL_00DF:
					this.method_45();
					goto IL_010F;
					IL_00F5:
					if (this.method_15(false) == 0)
					{
						goto Block_8;
					}
					goto IL_010F;
				}
				IL_00E7:
				if (this.int_0 == this.int_1)
				{
					goto IL_00F5;
				}
				this.int_1++;
			}
			Block_8:;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00033EB0 File Offset: 0x000320B0
		private void method_48()
		{
			IL_02F9:
			while (this.method_56(Class15.smethod_17(1603800954 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c)))
			{
				int num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_01E4;
				}
				int num2;
				int num3;
				for (;;)
				{
					IL_0256:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_011C;
					case 3:
						goto IL_0378;
					case 4:
						goto IL_0320;
					case 5:
					case 26:
						goto IL_003C;
					case 6:
						goto IL_024B;
					case 7:
					case 12:
					case 14:
					case 24:
					case 33:
						goto IL_017C;
					case 8:
						goto IL_0159;
					case 9:
						goto IL_0064;
					case 10:
						goto IL_0085;
					case 11:
						goto IL_0045;
					case 13:
						goto IL_007F;
					case 15:
						goto IL_023F;
					case 16:
						goto IL_00F8;
					case 17:
						goto IL_00B0;
					case 18:
						goto IL_0194;
					case 19:
						goto IL_0114;
					case 20:
						num2 = this.int_1;
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
						{
							goto Block_14;
						}
						continue;
					case 21:
						goto IL_00D3;
					case 22:
					case 29:
						goto IL_0101;
					case 23:
						goto IL_010A;
					case 25:
						goto IL_0020;
					case 27:
						goto IL_00AA;
					case 28:
						num3 = this.int_1;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
						{
							continue;
						}
						break;
					case 30:
						goto IL_01E4;
					case 31:
						goto IL_02F9;
					case 32:
						if (this.method_15(true) == 0)
						{
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 34:
						goto IL_012C;
					case 35:
						goto IL_00D9;
					case 36:
						goto IL_033C;
					}
					goto Block_15;
				}
				IL_024B:
				this.method_45();
				goto IL_017C;
				IL_023F:
				this.method_46(true);
				Block_14:
				goto IL_017C;
				Block_15:
				goto IL_0053;
				Block_11:
				IL_0320:
				throw JsonReaderException.Create(this, Class15.smethod_17(543245614 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				IL_0020:
				char c;
				if (c == '\0')
				{
					goto IL_012C;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_003C;
				}
				goto IL_0256;
				IL_0053:
				c = this.char_0[this.int_1];
				goto IL_0020;
				IL_0045:
				this.int_1++;
				goto IL_0053;
				IL_003C:
				if (char.IsLetterOrDigit(c))
				{
					goto IL_0045;
				}
				IL_0064:
				if (c != '\r')
				{
					goto IL_00D3;
				}
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_007F;
				}
				goto IL_0256;
				IL_00B0:
				string text;
				base.SetToken(JsonToken.StartConstructor, text);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					return;
				}
				goto IL_0256;
				IL_00AA:
				this.method_37();
				goto IL_00B0;
				IL_0085:
				if (this.char_0[this.int_1] != '(')
				{
					goto IL_033C;
				}
				this.int_1++;
				goto IL_00AA;
				IL_007F:
				this.method_47();
				goto IL_0085;
				IL_00D9:
				num2 = this.int_1;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_011C;
				}
				goto IL_0256;
				IL_00D3:
				if (c == '\n')
				{
					goto IL_00D9;
				}
				goto IL_00F8;
				IL_012C:
				if (this.int_0 == this.int_1)
				{
					num = 32;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto IL_017C;
					}
					goto IL_0256;
				}
				else
				{
					num2 = this.int_1;
				}
				IL_0159:
				this.int_1++;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_017C;
				}
				goto IL_0256;
				IL_0194:
				text = this.stringReference_0.ToString();
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0378;
				}
				goto IL_0256;
				IL_017C:
				this.stringReference_0 = new StringReference(this.char_0, num3, num2 - num3);
				goto IL_0194;
				IL_011C:
				this.int_1++;
				goto IL_017C;
				IL_0114:
				num2 = this.int_1;
				goto IL_011C;
				IL_00F8:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_0101;
				}
				goto IL_0114;
				IL_010A:
				num2 = this.int_1;
				goto IL_017C;
				IL_0101:
				if (c == '(')
				{
					goto IL_010A;
				}
				goto IL_0378;
				IL_01E4:
				this.method_47();
				num = 28;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_003C;
				}
				goto IL_0256;
				IL_033C:
				throw JsonReaderException.Create(this, Class15.smethod_17(486531858 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
				IL_0378:
				throw JsonReaderException.Create(this, Class15.smethod_17(82308754 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909).FormatWith(CultureInfo.InvariantCulture, c));
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(642125906 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba));
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00034280 File Offset: 0x00032480
		private void method_49(ReadType readType_0)
		{
			for (;;)
			{
				IL_0072:
				this.method_14();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_002C;
				}
				char c;
				int num2;
				for (;;)
				{
					IL_0052:
					switch (num)
					{
					case 1:
						this.method_50(readType_0, c, num2);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_002C;
					case 3:
						goto IL_001D;
					case 4:
						goto IL_0072;
					case 5:
						goto IL_0003;
					}
					return;
				}
				IL_001D:
				c = this.char_0[this.int_1];
				goto IL_002C;
				IL_0003:
				this.method_35();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					break;
				}
				goto IL_0052;
				IL_002C:
				num2 = this.int_1;
				goto IL_0003;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00034320 File Offset: 0x00032520
		private void method_50(ReadType readType_0, char char_1, int int_4)
		{
			ParseResult parseResult2;
			for (;;)
			{
				IL_0B57:
				base.SetPostValueState(true);
				for (;;)
				{
					IL_0B23:
					this.stringReference_0 = new StringReference(this.char_0, int_4, this.int_1 - int_4);
					int num = 44;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_07D7;
					}
					goto IL_09A8;
					IL_0585:
					bool flag;
					while (flag)
					{
						num = 41;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
						{
							goto IL_09A8;
						}
					}
					goto IL_0589;
					JsonToken jsonToken;
					object obj;
					ParseResult parseResult;
					for (;;)
					{
						IL_09A8:
						switch (num)
						{
						case 1:
							goto IL_07B2;
						case 2:
						case 38:
							goto IL_033B;
						case 3:
							goto IL_05B7;
						case 4:
							goto IL_05C5;
						case 5:
						case 60:
							goto IL_0084;
						case 6:
							goto IL_00C5;
						case 7:
							goto IL_0662;
						case 8:
						case 19:
							goto IL_0429;
						case 9:
						case 62:
							goto IL_00CE;
						case 10:
						case 26:
							goto IL_0C1F;
						case 11:
							goto IL_0358;
						case 12:
							goto IL_0B23;
						case 13:
							goto IL_0B57;
						case 14:
							goto IL_099F;
						case 15:
							goto IL_0371;
						case 16:
							goto IL_0443;
						case 20:
							goto IL_03FA;
						case 21:
						case 65:
							goto IL_01F8;
						case 23:
							goto IL_0820;
						case 24:
						case 56:
							goto IL_0D1D;
						case 25:
							goto IL_05E3;
						case 27:
							goto IL_0C3B;
						case 28:
							goto IL_0059;
						case 29:
						case 49:
							goto IL_0021;
						case 30:
							goto IL_0430;
						case 31:
							goto IL_01ED;
						case 32:
							goto IL_08E0;
						case 33:
							goto IL_05FC;
						case 34:
							goto IL_0614;
						case 35:
						case 42:
							goto IL_01F4;
						case 36:
						case 70:
							goto IL_0585;
						case 37:
							goto IL_03B5;
						case 39:
							goto IL_00D6;
						case 40:
							goto IL_024D;
						case 41:
							goto IL_080D;
						case 43:
							goto IL_0222;
						case 44:
						case 45:
							goto IL_0735;
						case 46:
							goto IL_0589;
						case 47:
							goto IL_0537;
						case 48:
							goto IL_0172;
						case 50:
						case 53:
							goto IL_062D;
						case 51:
							goto IL_0675;
						case 54:
							goto IL_023F;
						case 55:
							base.SetToken(jsonToken, obj, false);
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
							{
								goto Block_30;
							}
							continue;
						case 57:
							goto IL_004B;
						case 58:
							goto IL_0654;
						case 59:
							goto IL_050A;
						case 61:
							goto IL_015F;
						case 63:
							goto IL_0B6C;
						case 64:
							goto IL_03DD;
						case 66:
							goto IL_0502;
						case 67:
							goto IL_07D7;
						case 68:
							goto IL_0BE7;
						case 69:
							if (this.stringReference_0.Chars[this.stringReference_0.StartIndex + 1] == 'e')
							{
								goto IL_01A6;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
							{
								goto IL_07B2;
							}
							continue;
						case 71:
							goto IL_0164;
						case 72:
							goto IL_0CAC;
						case 73:
							goto IL_040D;
						case 74:
							return;
						case 75:
							goto IL_031B;
						case 76:
							goto IL_076F;
						case 77:
							goto IL_0260;
						case 79:
							if (parseResult != ParseResult.Success)
							{
								goto IL_0C73;
							}
							num = 62;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
							{
								goto IL_076F;
							}
							continue;
						case 80:
							goto IL_0118;
						case 81:
							goto IL_005E;
						case 82:
							goto IL_0555;
						case 84:
							goto IL_0BAF;
						case 86:
							goto IL_01A9;
						case 87:
							goto IL_0050;
						case 88:
							goto IL_0066;
						case 89:
							goto IL_014F;
						case 90:
							goto IL_0C73;
						}
						goto Block_33;
					}
					IL_08E0:
					string text;
					try
					{
						if (!text.StartsWith(Class15.smethod_17(2128224212 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), StringComparison.OrdinalIgnoreCase))
						{
							goto IL_0933;
						}
						IL_0900:
						Convert.ToInt64(text, 16);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							goto IL_0951;
						}
						IL_091B:
						switch (num2)
						{
						case 2:
							IL_0933:
							Convert.ToInt64(text, 8);
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
							{
								goto IL_091B;
							}
							break;
						case 3:
							goto IL_0900;
						}
						IL_0951:
						goto IL_0537;
					}
					catch (Exception ex)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
						{
							switch (num3)
							{
							}
						}
						throw this.method_51(Class15.smethod_17(552188128 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, text), ex);
					}
					goto IL_099F;
					IL_076F:
					decimal num4;
					obj = BoxedPrimitives.Get(num4);
					goto IL_00CE;
					IL_099F:
					obj = text;
					Block_33:
					goto IL_0006;
					IL_0820:
					string text2;
					try
					{
						long num5;
						if (text2.StartsWith(Class15.smethod_17(82309078 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), StringComparison.OrdinalIgnoreCase))
						{
							num5 = Convert.ToInt64(text2, 16);
							goto IL_0874;
						}
						int num6 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
						{
							goto IL_086C;
						}
						IL_085F:
						switch (num6)
						{
						default:
							IL_086C:
							num5 = Convert.ToInt64(text2, 8);
							break;
						case 1:
							IL_0892:
							goto IL_0084;
						}
						IL_0874:
						obj = BoxedPrimitives.Get(Convert.ToDecimal(num5));
						num6 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							goto IL_0892;
						}
						goto IL_085F;
					}
					catch (Exception ex2)
					{
						int num7 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							switch (num7)
							{
							}
						}
						throw this.method_51(Class15.smethod_17(649964530 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, text2), ex2);
					}
					goto IL_08E0;
					IL_080D:
					text2 = this.stringReference_0.ToString();
					goto IL_0820;
					IL_07B2:
					bool flag2 = this.stringReference_0.Chars[this.stringReference_0.StartIndex + 1] != 'E';
					goto IL_01A7;
					IL_0006:
					this.method_37();
					num = 55;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_0021;
					}
					goto IL_09A8;
					IL_0059:
					jsonToken = JsonToken.Integer;
					goto IL_0006;
					IL_0050:
					long num8;
					obj = BoxedPrimitives.Get(num8);
					goto IL_0059;
					IL_004B:
					if (parseResult == ParseResult.Success)
					{
						goto IL_0050;
					}
					goto IL_005E;
					IL_0021:
					parseResult = ConvertUtils.Int64TryParse(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length, out num8);
					goto IL_004B;
					IL_0066:
					double num9;
					if (this._floatParseHandling == FloatParseHandling.Decimal)
					{
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
						{
							goto IL_0084;
						}
						goto IL_09A8;
					}
					else
					{
						if (double.TryParse(this.stringReference_0.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num9))
						{
							goto IL_00C5;
						}
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
						{
							goto Block_6;
						}
						goto IL_09A8;
					}
					IL_005E:
					if (parseResult == ParseResult.Overflow)
					{
						goto IL_00D6;
					}
					goto IL_0066;
					IL_0084:
					jsonToken = JsonToken.Float;
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_0006;
					}
					goto IL_09A8;
					IL_05C5:
					obj = BoxedPrimitives.Get(char_1 - 48m);
					goto IL_0084;
					IL_0555:
					bool flag3;
					if (flag3)
					{
						goto IL_05C5;
					}
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						goto IL_0585;
					}
					goto IL_09A8;
					IL_01A9:
					switch (readType_0)
					{
					case ReadType.Read:
					case ReadType.const_2:
						IL_0358:
						if (flag3)
						{
							goto IL_03B5;
						}
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto IL_0371;
						}
						goto IL_09A8;
					case ReadType.const_1:
						IL_01ED:
						if (!flag3)
						{
							goto IL_01F4;
						}
						goto IL_031B;
					case ReadType.ReadAsBytes:
					case ReadType.ReadAsDateTime:
					case ReadType.ReadAsDateTimeOffset:
						goto IL_0C1F;
					case ReadType.ReadAsString:
						IL_03FA:
						text = this.stringReference_0.ToString();
						goto IL_040D;
					case ReadType.ReadAsDecimal:
						goto IL_0555;
					case ReadType.ReadAsDouble:
						IL_05E3:
						if (!flag3)
						{
							goto IL_0614;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
						{
							goto IL_05FC;
						}
						goto IL_09A8;
					default:
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto Block_10;
						}
						goto IL_09A8;
					}
					IL_01A7:
					flag = flag2;
					goto IL_01A9;
					IL_01A6:
					flag2 = false;
					goto IL_01A7;
					IL_015F:
					if (char_1 == '0')
					{
						goto IL_0164;
					}
					goto IL_01A6;
					IL_015D:
					bool flag4;
					flag3 = flag4;
					goto IL_015F;
					IL_014F:
					flag4 = this.stringReference_0.Length == 1;
					goto IL_015D;
					IL_07D7:
					if (!char.IsDigit(char_1))
					{
						flag4 = false;
						goto IL_015D;
					}
					goto IL_014F;
					IL_05B7:
					decimal num10;
					obj = BoxedPrimitives.Get(num10);
					goto IL_0084;
					IL_0589:
					if (ConvertUtils.DecimalTryParse(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length, out num10) == ParseResult.Success)
					{
						goto IL_05B7;
					}
					goto IL_0BE7;
					IL_00D6:
					string text3 = this.stringReference_0.ToString();
					if (text3.Length > 380)
					{
						goto IL_0CE4;
					}
					obj = JsonTextReader.smethod_1(text3, CultureInfo.InvariantCulture);
					num = 43;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_09A8;
					}
					IL_0118:
					jsonToken = JsonToken.Integer;
					num = 91;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto Block_5;
					}
					goto IL_09A8;
					IL_0222:
					if (parseResult2 != ParseResult.Success)
					{
						goto IL_0B6C;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						goto IL_023F;
					}
					goto IL_09A8;
					IL_01F8:
					int num11;
					parseResult2 = ConvertUtils.Int32TryParse(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length, out num11);
					goto IL_0222;
					IL_01F4:
					if (!flag)
					{
						goto IL_01F8;
					}
					goto IL_024D;
					IL_031B:
					obj = BoxedPrimitives.Get((int)(char_1 - '0'));
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto IL_033B;
					}
					goto IL_09A8;
					IL_0260:
					string text4;
					try
					{
						int num12;
						if (text4.StartsWith(Class15.smethod_17(538818851 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa), StringComparison.OrdinalIgnoreCase))
						{
							num12 = Convert.ToInt32(text4, 16);
							goto IL_02B7;
						}
						int num13 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto IL_02AF;
						}
						IL_029F:
						switch (num13)
						{
						case 0:
							goto IL_02D0;
						case 1:
							IL_02AF:
							num12 = Convert.ToInt32(text4, 8);
							break;
						default:
							goto IL_02D0;
						}
						IL_02B7:
						obj = BoxedPrimitives.Get(num12);
						num13 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							goto IL_029F;
						}
						IL_02D0:
						goto IL_033B;
					}
					catch (Exception ex3)
					{
						int num14 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
						{
							switch (num14)
							{
							}
						}
						throw this.method_51(Class15.smethod_17(552188086 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, text4), ex3);
					}
					goto IL_031B;
					IL_024D:
					text4 = this.stringReference_0.ToString();
					goto IL_0260;
					IL_033B:
					jsonToken = JsonToken.Integer;
					num = 53;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						goto IL_0006;
					}
					goto IL_09A8;
					IL_023F:
					obj = BoxedPrimitives.Get(num11);
					goto IL_033B;
					IL_0371:
					parseResult = ConvertUtils.DecimalTryParse(this.stringReference_0.Chars, this.stringReference_0.StartIndex, this.stringReference_0.Length, out num4);
					num = 79;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_00D6;
					}
					goto IL_09A8;
					IL_03B5:
					obj = BoxedPrimitives.Get((long)((ulong)char_1 - 48UL));
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_09A8;
					}
					IL_03DD:
					jsonToken = JsonToken.Integer;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto IL_0006;
					}
					goto IL_09A8;
					IL_040D:
					if (flag)
					{
						num = 32;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							goto IL_0429;
						}
						goto IL_09A8;
					}
					IL_050A:
					double num15;
					if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out num15))
					{
						goto IL_0BAF;
					}
					num = 45;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_09A8;
					}
					IL_0537:
					jsonToken = JsonToken.String;
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
					{
						goto IL_00C5;
					}
					goto IL_09A8;
					IL_0614:
					if (flag)
					{
						goto IL_0662;
					}
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_062D;
					}
					goto IL_09A8;
					IL_0735:
					jsonToken = JsonToken.Float;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						goto IL_0006;
					}
					goto IL_09A8;
					IL_0675:
					string text5;
					try
					{
						long num16;
						if (text5.StartsWith(Class15.smethod_17(82309078 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), StringComparison.OrdinalIgnoreCase))
						{
							num16 = Convert.ToInt64(text5, 16);
							goto IL_06CC;
						}
						int num17 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto IL_06C4;
						}
						IL_06B4:
						switch (num17)
						{
						case 0:
							goto IL_06EA;
						case 1:
							IL_06C4:
							num16 = Convert.ToInt64(text5, 8);
							break;
						default:
							goto IL_06EA;
						}
						IL_06CC:
						obj = BoxedPrimitives.Get(Convert.ToDouble(num16));
						num17 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto IL_06B4;
						}
						IL_06EA:;
					}
					catch (Exception ex4)
					{
						int num18 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							switch (num18)
							{
							}
						}
						throw this.method_51(Class15.smethod_17(1793862266 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, text5), ex4);
					}
					goto IL_0735;
					IL_0662:
					text5 = this.stringReference_0.ToString();
					goto IL_0675;
					IL_0654:
					double num19;
					obj = BoxedPrimitives.Get(num19);
					goto IL_0735;
					IL_062D:
					if (double.TryParse(this.stringReference_0.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num19))
					{
						goto IL_0654;
					}
					goto IL_0C3B;
					IL_05FC:
					obj = BoxedPrimitives.Get((double)char_1 - 48.0);
					goto IL_0735;
					IL_00CE:
					jsonToken = JsonToken.Float;
					goto IL_0006;
					IL_00C5:
					obj = BoxedPrimitives.Get(num9);
					goto IL_00CE;
					IL_0502:
					jsonToken = JsonToken.Integer;
					goto IL_0006;
					IL_0443:
					string text6;
					try
					{
						if (!text6.StartsWith(Class15.smethod_17(1570993767 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), StringComparison.OrdinalIgnoreCase))
						{
							goto IL_04AC;
						}
						int num20 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
						{
							goto IL_0488;
						}
						IL_0477:
						long num21;
						switch (num20)
						{
						default:
							IL_0488:
							num21 = Convert.ToInt64(text6, 16);
							break;
						case 1:
							goto IL_0502;
						case 2:
							IL_04AC:
							num21 = Convert.ToInt64(text6, 8);
							break;
						}
						obj = BoxedPrimitives.Get(num21);
						num20 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
						{
							goto IL_0477;
						}
					}
					catch (Exception ex5)
					{
						int num22 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
						{
							switch (num22)
							{
							}
						}
						throw this.method_51(Class15.smethod_17(1387475342 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, text6), ex5);
					}
					goto IL_0502;
					IL_0430:
					text6 = this.stringReference_0.ToString();
					goto IL_0443;
					IL_0429:
					if (flag)
					{
						goto IL_0430;
					}
					goto IL_0021;
					IL_0164:
					if (this.stringReference_0.Length <= 1)
					{
						goto IL_01A6;
					}
					IL_0172:
					if (this.stringReference_0.Chars[this.stringReference_0.StartIndex + 1] == '.')
					{
						goto IL_01A6;
					}
					num = 69;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_01F4;
					}
					goto IL_09A8;
				}
			}
			Block_5:
			goto IL_0CAC;
			Block_6:
			goto IL_0D1D;
			Block_10:
			goto IL_0C1F;
			Block_30:
			return;
			IL_0B6C:
			if (parseResult2 == ParseResult.Overflow)
			{
				goto IL_0CAC;
			}
			throw this.method_51(Class15.smethod_17(2056990917 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0BAF:
			throw this.method_51(Class15.smethod_17(1042100259 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0BE7:
			throw this.method_51(Class15.smethod_17(613106455 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0C1F:
			throw JsonReaderException.Create(this, Class15.smethod_17(1760298007 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039));
			IL_0C3B:
			throw this.method_51(Class15.smethod_17(1424585472 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0C73:
			throw this.method_51(Class15.smethod_17(1678083934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0CAC:
			throw this.method_51(Class15.smethod_17(2021170290 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0CE4:
			throw this.method_51(Class15.smethod_17(2060605200 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
			IL_0D1D:
			throw this.method_51(Class15.smethod_17(1570993775 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, this.stringReference_0.ToString()), null);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000350C4 File Offset: 0x000332C4
		private JsonReaderException method_51(string string_1, [Nullable(2)] Exception ex = null)
		{
			for (;;)
			{
				base.SetToken(JsonToken.Undefined, null, false);
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
			return JsonReaderException.Create(this, string_1, ex);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00003184 File Offset: 0x00001384
		private static object smethod_1(string string_1, IFormatProvider iformatProvider_0)
		{
			return BigInteger.Parse(string_1, iformatProvider_0);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00035108 File Offset: 0x00033308
		private void method_52(bool bool_4)
		{
			int num2;
			for (;;)
			{
				IL_0313:
				this.int_1++;
				IL_0303:
				while (this.method_18(1, false))
				{
					if (this.char_0[this.int_1] == '*')
					{
						goto IL_0209;
					}
					goto IL_02EC;
					int num;
					char c;
					bool flag;
					do
					{
						IL_021C:
						switch (num)
						{
						case 1:
							goto IL_00BB;
						case 2:
							goto IL_02EC;
						case 3:
						case 5:
							goto IL_020C;
						case 4:
							return;
						case 6:
							goto IL_005C;
						case 7:
							goto IL_0323;
						case 8:
							goto IL_0209;
						case 9:
							goto IL_0354;
						case 10:
							return;
						case 11:
							goto IL_0129;
						case 12:
							goto IL_016F;
						case 13:
							goto IL_018C;
						case 14:
							goto IL_006D;
						case 15:
							goto IL_019F;
						case 16:
							goto IL_01EA;
						case 17:
							return;
						case 18:
							goto IL_0098;
						case 19:
							goto IL_0343;
						case 20:
							goto IL_0055;
						case 21:
							goto IL_0303;
						case 22:
							goto IL_0313;
						case 23:
							goto IL_0067;
						case 24:
							goto IL_017E;
						case 25:
							goto IL_00D4;
						case 26:
						case 29:
						case 35:
						case 36:
						case 39:
							goto IL_00EF;
						case 27:
							return;
						case 28:
							goto IL_0198;
						case 30:
							if (c != '\0')
							{
								goto IL_016F;
							}
							goto IL_017E;
						case 32:
							goto IL_003A;
						case 33:
							goto IL_02CF;
						case 34:
							goto IL_0103;
						case 37:
							goto IL_0381;
						case 40:
							goto IL_0020;
						case 41:
							goto IL_0365;
						}
						goto Block_14;
						IL_019F:
						this.method_53(bool_4, num2, this.int_1);
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
						{
							goto Block_11;
						}
						continue;
						IL_0198:
						if (flag)
						{
							goto IL_019F;
						}
						goto IL_0365;
						IL_018C:
						if (this.method_15(true) == 0)
						{
							goto IL_0198;
						}
						goto IL_00EF;
						IL_017E:
						if (this.int_0 == this.int_1)
						{
							goto IL_018C;
						}
						this.int_1++;
						num = 36;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0);
					goto IL_0067;
					IL_016F:
					if (c == '\n')
					{
						goto IL_0055;
					}
					Block_14:
					goto IL_0088;
					IL_003A:
					if (c > '\n')
					{
						goto IL_0067;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						goto IL_0055;
					}
					goto IL_021C;
					IL_00EF:
					c = this.char_0[this.int_1];
					goto IL_003A;
					IL_0020:
					if (this.char_0[this.int_1] == '/')
					{
						goto IL_0103;
					}
					goto IL_00EF;
					IL_006D:
					if (c == '*')
					{
						goto IL_0098;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_0088;
					}
					goto IL_021C;
					IL_0067:
					if (c != '\r')
					{
						goto IL_006D;
					}
					if (!flag)
					{
						this.method_46(true);
						goto IL_00EF;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto Block_9;
					}
					goto IL_021C;
					IL_0098:
					this.int_1++;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_00BB;
					}
					goto IL_021C;
					IL_0103:
					this.method_53(bool_4, num2, this.int_1 - 1);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_021C;
					}
					IL_0129:
					this.int_1++;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto Block_8;
					}
					goto IL_021C;
					IL_01EA:
					num2 = this.int_1;
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_00EF;
					}
					goto IL_021C;
					IL_020C:
					this.int_1++;
					goto IL_01EA;
					IL_0209:
					flag = false;
					goto IL_020C;
					IL_02CF:
					flag = true;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto IL_020C;
					}
					goto IL_021C;
					IL_02EC:
					if (this.char_0[this.int_1] == '/')
					{
						goto IL_02CF;
					}
					goto IL_0381;
					IL_005C:
					this.method_45();
					goto IL_00EF;
					IL_0055:
					if (!flag)
					{
						goto IL_005C;
					}
					goto IL_0343;
					IL_0088:
					this.int_1++;
					goto IL_00EF;
					IL_00BB:
					if (flag)
					{
						goto IL_00EF;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_021C;
					}
					IL_00D4:
					if (this.method_18(0, true))
					{
						goto IL_0020;
					}
					goto IL_00EF;
				}
				goto Block_17;
			}
			Block_8:
			return;
			Block_9:
			goto IL_0354;
			Block_11:
			return;
			Block_17:
			IL_0323:
			throw JsonReaderException.Create(this, Class15.smethod_17(299947237 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
			IL_0343:
			this.method_53(bool_4, num2, this.int_1);
			return;
			IL_0354:
			this.method_53(bool_4, num2, this.int_1);
			return;
			IL_0365:
			throw JsonReaderException.Create(this, Class15.smethod_17(89039512 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454));
			IL_0381:
			throw JsonReaderException.Create(this, Class15.smethod_17(676703164 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, this.char_0[this.int_1]));
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000354D0 File Offset: 0x000336D0
		private void method_53(bool bool_4, int int_4, int int_5)
		{
			for (;;)
			{
				if (bool_4)
				{
					goto IL_0003;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					break;
				}
				IL_002A:
				switch (num)
				{
				case 2:
					continue;
				case 3:
					IL_0003:
					base.SetToken(JsonToken.Comment, new string(this.char_0, int_4, int_5 - int_4));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_002A;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003192 File Offset: 0x00001392
		private bool method_54(string string_1)
		{
			return this.method_55(this.method_18(string_1.Length - 1, true), string_1);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00035540 File Offset: 0x00033740
		private bool method_55(bool bool_4, string string_1)
		{
			IL_00AA:
			while (bool_4)
			{
				int i = 0;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
				{
					goto IL_0076;
				}
				IL_0069:
				while (i < string_1.Length)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_0076;
					}
				}
				goto IL_00D4;
				for (;;)
				{
					IL_0076:
					switch (num)
					{
					case 1:
					case 10:
						if (this.char_0[this.int_1 + i] != string_1[i])
						{
							goto Block_2;
						}
						i++;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
						{
							continue;
						}
						break;
					case 3:
						return true;
					case 4:
						return false;
					case 5:
						goto IL_00BC;
					case 6:
						goto IL_00D4;
					case 7:
						goto IL_00B0;
					case 8:
						goto IL_00AA;
					case 9:
						goto IL_00C3;
					}
					goto Block_5;
				}
				Block_2:
				goto IL_00C3;
				Block_5:
				goto IL_0069;
				IL_00BC:
				throw base.CreateUnexpectedEndException();
				IL_00C3:
				this.int_1 += i;
				return false;
				IL_00D4:
				this.int_1 += string_1.Length;
				return true;
			}
			IL_00B0:
			this.int_1 = this.int_0;
			goto IL_00BC;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00035638 File Offset: 0x00033838
		private bool method_56(string string_1)
		{
			while (this.method_54(string_1))
			{
				if (this.method_18(0, false))
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						goto IL_001F;
					}
					IL_0045:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						goto IL_0072;
					case 3:
						return false;
					case 4:
						continue;
					}
					IL_001F:
					if (this.method_57(this.char_0[this.int_1]))
					{
						return true;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto IL_0045;
					}
					IL_0072:
					return this.char_0[this.int_1] == '\0';
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000356CC File Offset: 0x000338CC
		private bool method_57(char char_1)
		{
			char c;
			for (;;)
			{
				IL_0180:
				if (char_1 <= ')')
				{
					goto IL_004B;
				}
				goto IL_0175;
				IL_009A:
				int num;
				while (base.CurrentState == JsonReader.State.ConstructorStart)
				{
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_0115;
					}
				}
				return false;
				for (;;)
				{
					IL_0115:
					switch (num)
					{
					case 1:
						goto IL_00C4;
					case 2:
					case 10:
						goto IL_0026;
					case 3:
						return false;
					case 4:
						goto IL_016A;
					case 5:
						goto IL_0068;
					case 6:
						goto IL_009A;
					case 7:
						return true;
					case 8:
						c = this.char_0[this.int_1 + 1];
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
						{
							continue;
						}
						break;
					case 9:
						return true;
					case 11:
						return true;
					case 12:
						goto IL_00AA;
					case 13:
						goto IL_019C;
					case 14:
						goto IL_0070;
					case 15:
						goto IL_0175;
					case 16:
						goto IL_004B;
					case 17:
						goto IL_0180;
					case 18:
						goto IL_001B;
					}
					goto Block_11;
				}
				IL_0026:
				if (!char.IsWhiteSpace(char_1))
				{
					return false;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_016A;
				}
				goto IL_0115;
				IL_001B:
				if (char_1 == '}')
				{
					break;
				}
				goto IL_0026;
				IL_0070:
				if (char_1 != ')')
				{
					goto IL_0026;
				}
				if (base.CurrentState != JsonReader.State.Constructor)
				{
					goto IL_009A;
				}
				return true;
				IL_0068:
				if (char_1 != ' ')
				{
					goto IL_0070;
				}
				return true;
				IL_00AA:
				if (char_1 == ',')
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_00C4;
				}
				goto IL_0115;
				IL_0175:
				if (char_1 <= '/')
				{
					goto IL_00AA;
				}
				goto IL_016A;
				IL_00C4:
				if (char_1 != '/')
				{
					goto IL_0026;
				}
				if (!this.method_18(1, false))
				{
					return false;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto Block_10;
				}
				goto IL_0115;
				IL_016A:
				if (char_1 == ']')
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_001B;
				}
				goto IL_0115;
				IL_004B:
				switch (char_1)
				{
				case '\t':
				case '\n':
				case '\r':
					return true;
				case '\v':
				case '\f':
					goto IL_0026;
				}
				goto IL_0068;
			}
			return true;
			Block_10:
			return false;
			Block_11:
			if (c != '*')
			{
				goto IL_019C;
			}
			return true;
			IL_019C:
			return c == '/';
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00035884 File Offset: 0x00033A84
		private void method_58()
		{
			while (this.method_56(JsonConvert.True))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					goto IL_0015;
				}
				IL_0033:
				switch (num)
				{
				case 1:
					IL_0015:
					base.SetToken(JsonToken.Boolean, BoxedPrimitives.BooleanTrue);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						goto IL_0033;
					}
					break;
				case 2:
					continue;
				}
				return;
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(2071411230 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00035908 File Offset: 0x00033B08
		private void method_59()
		{
			IL_0044:
			while (this.method_56(JsonConvert.Null))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 1:
							base.SetToken(JsonToken.Null);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0044;
						}
						break;
					}
				}
				return;
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(1788636096 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0003598C File Offset: 0x00033B8C
		private void method_60()
		{
			IL_0044:
			while (this.method_56(JsonConvert.Undefined))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 1:
							base.SetToken(JsonToken.Undefined);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0044;
						}
						break;
					}
				}
				return;
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(2008561299 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00035A10 File Offset: 0x00033C10
		private void method_61()
		{
			while (!this.method_56(JsonConvert.False))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0059;
					case 3:
						return;
					}
				}
				throw JsonReaderException.Create(this, Class15.smethod_17(124834974 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
			}
			IL_0059:
			base.SetToken(JsonToken.Boolean, BoxedPrimitives.BooleanFalse);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000031AA File Offset: 0x000013AA
		private object method_62(ReadType readType_0)
		{
			return this.method_63(readType_0, this.method_56(JsonConvert.NegativeInfinity));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00035A84 File Offset: 0x00033C84
		private object method_63(ReadType readType_0, bool bool_4)
		{
			while (bool_4)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					goto IL_007A;
				}
				IL_008E:
				switch (num)
				{
				case 0:
					goto IL_007A;
				case 1:
					continue;
				case 2:
				case 7:
					goto IL_0033;
				case 3:
					goto IL_00CB;
				case 4:
					goto IL_0111;
				case 5:
					return JsonConvert.NegativeInfinity;
				case 6:
					goto IL_0052;
				case 8:
					break;
				default:
					goto IL_007A;
				}
				IL_001A:
				if (readType_0 != ReadType.ReadAsDouble)
				{
					goto IL_00D9;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_0033;
				}
				goto IL_008E;
				IL_0052:
				if (readType_0 != ReadType.ReadAsString)
				{
					goto IL_001A;
				}
				base.SetToken(JsonToken.String, JsonConvert.NegativeInfinity);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_0033;
				}
				goto IL_008E;
				IL_007A:
				if (readType_0 != ReadType.Read)
				{
					goto IL_0052;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto IL_008E;
				}
				continue;
				IL_0033:
				if (this._floatParseHandling != FloatParseHandling.Double)
				{
					goto IL_00D9;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					goto IL_008E;
				}
				IL_00CB:
				base.SetToken(JsonToken.Float, BoxedPrimitives.DoubleNegativeInfinity);
				goto IL_0111;
				IL_00D9:
				throw JsonReaderException.Create(this, Class15.smethod_17(676703374 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
				IL_0111:
				return double.NegativeInfinity;
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(698993884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000031BE File Offset: 0x000013BE
		private object method_64(ReadType readType_0)
		{
			return this.method_65(readType_0, this.method_56(JsonConvert.PositiveInfinity));
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00035BB0 File Offset: 0x00033DB0
		private object method_65(ReadType readType_0, bool bool_4)
		{
			IL_0047:
			while (bool_4)
			{
				while (readType_0 != ReadType.Read)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						switch (num)
						{
						default:
							continue;
						case 1:
							goto IL_0067;
						case 2:
							break;
						case 3:
							goto IL_0085;
						case 4:
							goto IL_004A;
						case 5:
							goto IL_0047;
						case 6:
							goto IL_006B;
						case 7:
							goto IL_007F;
						case 8:
							IL_00A9:
							base.SetToken(JsonToken.Float, BoxedPrimitives.DoublePositiveInfinity);
							break;
						case 9:
							goto IL_008D;
						}
						return double.PositiveInfinity;
					}
					IL_0067:
					if (readType_0 == ReadType.ReadAsString)
					{
						base.SetToken(JsonToken.String, JsonConvert.PositiveInfinity);
						goto IL_007F;
					}
					IL_006B:
					if (readType_0 == ReadType.ReadAsDouble)
					{
						break;
					}
					goto IL_008D;
					IL_007F:
					return JsonConvert.PositiveInfinity;
					IL_008D:
					throw JsonReaderException.Create(this, Class15.smethod_17(1788635854 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
				}
				IL_0085:
				if (this._floatParseHandling != FloatParseHandling.Double)
				{
					goto IL_008D;
				}
				goto IL_00A9;
			}
			IL_004A:
			throw JsonReaderException.Create(this, Class15.smethod_17(613106895 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000031D2 File Offset: 0x000013D2
		private object method_66(ReadType readType_0)
		{
			return this.method_67(readType_0, this.method_56(JsonConvert.NaN));
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00035C80 File Offset: 0x00033E80
		private object method_67(ReadType readType_0, bool bool_4)
		{
			IL_00B5:
			while (bool_4)
			{
				for (;;)
				{
					if (readType_0 != ReadType.Read)
					{
						goto IL_0091;
					}
					int num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_001D;
					}
					IL_0057:
					switch (num)
					{
					case 1:
						goto IL_003A;
					case 2:
						IL_0091:
						if (readType_0 != ReadType.ReadAsString)
						{
							goto IL_0087;
						}
						goto IL_0106;
					case 3:
						goto IL_0087;
					case 4:
					case 5:
						IL_001D:
						if (this._floatParseHandling != FloatParseHandling.Double)
						{
							goto IL_00EA;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							goto IL_003A;
						}
						goto IL_0057;
					case 6:
						goto IL_00CE;
					case 7:
						goto IL_00B5;
					case 8:
						goto IL_0113;
					case 9:
						continue;
					}
					break;
					IL_003A:
					base.SetToken(JsonToken.Float, BoxedPrimitives.DoubleNaN);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_0057;
					}
					break;
					IL_0087:
					if (readType_0 != ReadType.ReadAsDouble)
					{
						goto IL_00EA;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						break;
					}
					goto IL_0057;
				}
				return double.NaN;
				IL_00CE:
				throw JsonReaderException.Create(this, Class15.smethod_17(1985300808 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
				IL_00EA:
				throw JsonReaderException.Create(this, Class15.smethod_17(41440589 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
				IL_0106:
				base.SetToken(JsonToken.String, JsonConvert.NaN);
				IL_0113:
				return JsonConvert.NaN;
			}
			goto IL_00CE;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00035DA8 File Offset: 0x00033FA8
		public override void Close()
		{
			for (;;)
			{
				IL_00EB:
				base.Close();
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_0081;
				}
				for (;;)
				{
					IL_00B8:
					switch (num)
					{
					case 1:
						return;
					case 3:
						this.char_0 = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_0081;
					case 5:
						goto IL_00EB;
					case 6:
					case 9:
						goto IL_0006;
					case 7:
						goto IL_005C;
					case 8:
						goto IL_0031;
					}
					break;
				}
				goto IL_0054;
				IL_0006:
				this.stringBuffer_0.Clear(this.iarrayPool_0);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					break;
				}
				goto IL_00B8;
				IL_0054:
				if (base.CloseInput)
				{
					goto IL_005C;
				}
				goto IL_0006;
				IL_0031:
				BufferUtils.ReturnBuffer(this.iarrayPool_0, this.char_0);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_0054;
				}
				goto IL_00B8;
				IL_0081:
				if (this.char_0 != null)
				{
					goto IL_0031;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_0054;
				}
				goto IL_00B8;
				IL_005C:
				TextReader cqAbwNtqvn = this.CqAbwNtqvn;
				if (cqAbwNtqvn == null)
				{
					goto IL_0006;
				}
				cqAbwNtqvn.Close();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0006;
				}
				goto IL_00B8;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002C18 File Offset: 0x00000E18
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00035EC0 File Offset: 0x000340C0
		public int LineNumber
		{
			get
			{
				for (;;)
				{
					if (base.CurrentState == JsonReader.State.Start)
					{
						goto IL_0034;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						break;
					}
					IL_0014:
					switch (num)
					{
					case 1:
						continue;
					case 3:
						IL_0034:
						if (this.LinePosition == 0)
						{
							goto IL_0064;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto IL_0014;
						}
						break;
					case 4:
						return 0;
					case 5:
						goto IL_0064;
					}
					break;
				}
				goto IL_006F;
				IL_0064:
				if (this.TokenType == JsonToken.Comment)
				{
					goto IL_006F;
				}
				return 0;
				IL_006F:
				return this.int_3;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000031E6 File Offset: 0x000013E6
		public int LinePosition
		{
			get
			{
				return this.int_1 - this.int_2;
			}
		}

		// Token: 0x040002A0 RID: 672
		private readonly TextReader CqAbwNtqvn;

		// Token: 0x040002A1 RID: 673
		[Nullable(2)]
		private char[] char_0;

		// Token: 0x040002A2 RID: 674
		private int int_0;

		// Token: 0x040002A3 RID: 675
		private int int_1;

		// Token: 0x040002A4 RID: 676
		private int int_2;

		// Token: 0x040002A5 RID: 677
		private int int_3;

		// Token: 0x040002A6 RID: 678
		private bool bool_3;

		// Token: 0x040002A7 RID: 679
		private StringBuffer stringBuffer_0;

		// Token: 0x040002A8 RID: 680
		private StringReference stringReference_0;

		// Token: 0x040002A9 RID: 681
		[Nullable(2)]
		private IArrayPool<char> iarrayPool_0;

		// Token: 0x040002AA RID: 682
		[CompilerGenerated]
		[Nullable(2)]
		private JsonNameTable jsonNameTable_0;
	}
}
