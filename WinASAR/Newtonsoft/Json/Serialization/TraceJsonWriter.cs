using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000129 RID: 297
	[NullableContext(1)]
	[Nullable(0)]
	internal class TraceJsonWriter : JsonWriter
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00069ECC File Offset: 0x000680CC
		public TraceJsonWriter(JsonWriter innerWriter)
		{
			for (;;)
			{
				this.jsonWriter_0 = innerWriter;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0105;
				}
				IL_011A:
				switch (num)
				{
				case 0:
					goto IL_00C0;
				case 1:
					goto IL_00EF;
				case 2:
					goto IL_00D1;
				case 3:
					IL_0105:
					this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
					goto IL_0084;
				case 4:
					break;
				case 5:
					goto IL_0084;
				case 6:
					goto IL_005C;
				case 7:
					continue;
				case 8:
					goto IL_0049;
				case 9:
					return;
				case 10:
					goto IL_000D;
				default:
					goto IL_00C0;
				}
				IL_001E:
				this.jsonTextWriter_0.FloatFormatHandling = innerWriter.FloatFormatHandling;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					break;
				}
				goto IL_011A;
				IL_000D:
				this.jsonTextWriter_0.DateTimeZoneHandling = innerWriter.DateTimeZoneHandling;
				goto IL_001E;
				IL_0049:
				this.jsonTextWriter_0.DateFormatString = innerWriter.DateFormatString;
				goto IL_000D;
				IL_005C:
				this.jsonTextWriter_0.DateFormatHandling = innerWriter.DateFormatHandling;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
				{
					goto IL_0049;
				}
				goto IL_011A;
				IL_00EF:
				this.jsonTextWriter_0.Culture = innerWriter.Culture;
				goto IL_005C;
				IL_0084:
				this.stringWriter_0.Write(Class15.smethod_17(2071443356 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808) + Environment.NewLine);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_00C0;
				}
				goto IL_011A;
				IL_00D1:
				this.jsonTextWriter_0.Formatting = Formatting.Indented;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_00EF;
				}
				goto IL_011A;
				IL_00C0:
				this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
				goto IL_00D1;
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0000537B File Offset: 0x0000357B
		public string GetSerializedJsonMessage()
		{
			return this.stringWriter_0.ToString();
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0006A048 File Offset: 0x00068248
		public override void WriteValue(decimal value)
		{
			for (;;)
			{
				IL_0053:
				this.jsonTextWriter_0.WriteValue(value);
				for (;;)
				{
					this.jsonWriter_0.WriteValue(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						IL_0003:
						base.WriteValue(value);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_001B;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0053;
					}
					return;
				}
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00005388 File Offset: 0x00003588
		public override void WriteValue(decimal? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0006A0B8 File Offset: 0x000682B8
		public override void WriteValue(bool value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					IL_0003:
					this.jsonWriter_0.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
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
			base.WriteValue(value);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000053BF File Offset: 0x000035BF
		public override void WriteValue(bool? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0006A128 File Offset: 0x00068328
		public override void WriteValue(byte value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_001E;
				}
				IL_002C:
				switch (num)
				{
				case 1:
					IL_001E:
					this.jsonWriter_0.WriteValue(value);
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					break;
				}
				goto IL_002C;
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000053F6 File Offset: 0x000035F6
		public override void WriteValue(byte? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0006A19C File Offset: 0x0006839C
		public override void WriteValue(char value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_001E;
				}
				IL_003E:
				switch (num)
				{
				case 0:
					goto IL_001E;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001E;
				}
				IL_0003:
				base.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					break;
				}
				goto IL_003E;
				IL_001E:
				this.jsonWriter_0.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0003;
				}
				goto IL_003E;
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0000542D File Offset: 0x0000362D
		public override void WriteValue(char? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0006A220 File Offset: 0x00068420
		[NullableContext(2)]
		public override void WriteValue(byte[] value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_0003;
				}
				goto IL_003B;
				IL_0035:
				while (value == null)
				{
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_003B;
					}
				}
				break;
				IL_003B:
				switch (num)
				{
				case 0:
					goto IL_0035;
				case 1:
					IL_0003:
					this.jsonWriter_0.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0035;
					}
					goto IL_003B;
				case 2:
					break;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_0083;
				default:
					goto IL_0035;
				}
			}
			base.WriteValue(value);
			return;
			IL_0083:
			base.WriteUndefined();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0006A2B8 File Offset: 0x000684B8
		public override void WriteValue(DateTime value)
		{
			for (;;)
			{
				IL_0053:
				this.jsonTextWriter_0.WriteValue(value);
				for (;;)
				{
					IL_0033:
					this.jsonWriter_0.WriteValue(value);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						return;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							base.WriteValue(value);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0033;
						case 3:
							goto IL_0053;
						}
						return;
					}
				}
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00005464 File Offset: 0x00003664
		public override void WriteValue(DateTime? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0006A32C File Offset: 0x0006852C
		public override void WriteValue(DateTimeOffset value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_0003;
				}
				goto IL_003C;
				do
				{
					IL_0021:
					base.WriteValue(value);
					num = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0);
				IL_003C:
				switch (num)
				{
				case 0:
					goto IL_0021;
				case 1:
					return;
				case 2:
					IL_0003:
					this.jsonWriter_0.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_0021;
					}
					goto IL_003C;
				case 3:
					break;
				default:
					goto IL_0021;
				}
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0000549B File Offset: 0x0000369B
		public override void WriteValue(DateTimeOffset? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0006A3B0 File Offset: 0x000685B0
		public override void WriteValue(double value)
		{
			for (;;)
			{
				IL_0051:
				this.jsonTextWriter_0.WriteValue(value);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0021;
				}
				for (;;)
				{
					IL_0039:
					switch (num)
					{
					case 1:
						goto IL_0021;
					case 2:
						this.jsonWriter_0.WriteValue(value);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_0021;
						}
						continue;
					case 3:
						goto IL_0051;
					}
					return;
				}
				IL_0021:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_0039;
				}
				break;
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000054D2 File Offset: 0x000036D2
		public override void WriteValue(double? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0006A430 File Offset: 0x00068630
		public override void WriteUndefined()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteUndefined();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_001D;
				}
				goto IL_003C;
				IL_0003:
				base.WriteUndefined();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
				{
					continue;
				}
				goto IL_003C;
				IL_001D:
				this.jsonWriter_0.WriteUndefined();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					goto IL_0003;
				}
				IL_003C:
				switch (num)
				{
				case 0:
					goto IL_001D;
				case 1:
					break;
				case 2:
					return;
				case 3:
					goto IL_0003;
				default:
					goto IL_001D;
				}
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0006A4B4 File Offset: 0x000686B4
		public override void WriteNull()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteNull();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_001D;
				}
				IL_002A:
				switch (num)
				{
				case 1:
					IL_001D:
					this.jsonWriter_0.WriteNull();
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				base.WriteUndefined();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					break;
				}
				goto IL_002A;
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0006A524 File Offset: 0x00068724
		public override void WriteValue(float value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto IL_001E;
				}
				IL_002C:
				switch (num)
				{
				case 1:
					IL_001E:
					this.jsonWriter_0.WriteValue(value);
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					break;
				}
				goto IL_002C;
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00005509 File Offset: 0x00003709
		public override void WriteValue(float? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0006A598 File Offset: 0x00068798
		public override void WriteValue(Guid value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_001C;
				}
				IL_003C:
				switch (num)
				{
				case 0:
					goto IL_001C;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001C;
				}
				IL_0003:
				base.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_003C;
				}
				IL_001C:
				this.jsonWriter_0.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_0003;
				}
				goto IL_003C;
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00005540 File Offset: 0x00003740
		public override void WriteValue(Guid? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0006A61C File Offset: 0x0006881C
		public override void WriteValue(int value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					goto IL_0020;
				}
			}
			IL_0059:
			base.WriteValue(value);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00005577 File Offset: 0x00003777
		public override void WriteValue(int? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0006A68C File Offset: 0x0006888C
		public override void WriteValue(long value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_001E;
				}
				IL_003E:
				switch (num)
				{
				case 1:
					IL_001E:
					this.jsonWriter_0.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0003;
					}
					goto IL_003E;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					break;
				}
				goto IL_003E;
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000055AE File Offset: 0x000037AE
		public override void WriteValue(long? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0006A710 File Offset: 0x00068910
		[NullableContext(2)]
		public override void WriteValue(object value)
		{
			for (;;)
			{
				if (value is BigInteger)
				{
					goto IL_0035;
				}
				this.jsonTextWriter_0.WriteValue(value);
				goto IL_00BF;
				IL_008F:
				int num;
				switch (num)
				{
				case 0:
					goto IL_0078;
				case 1:
					return;
				case 2:
					goto IL_0058;
				case 3:
					goto IL_00FA;
				case 4:
					IL_0035:
					this.jsonTextWriter_0.WriteValue(value);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto Block_2;
					}
					goto IL_008F;
				case 5:
					continue;
				case 6:
					return;
				case 7:
					break;
				case 8:
					IL_00BF:
					this.jsonWriter_0.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto IL_0078;
					}
					goto IL_008F;
				case 9:
					return;
				default:
					goto IL_0078;
				}
				IL_0017:
				base.InternalWriteValue(JsonToken.Integer);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					break;
				}
				goto IL_008F;
				IL_0058:
				this.jsonWriter_0.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0017;
				}
				goto IL_008F;
				IL_0078:
				if (value != null)
				{
					goto IL_00F0;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_0058;
				}
				goto IL_008F;
			}
			Block_2:
			return;
			IL_00F0:
			base.InternalWriteValue(JsonToken.String);
			return;
			IL_00FA:
			base.WriteUndefined();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0006A828 File Offset: 0x00068A28
		public override void WriteValue(sbyte value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
				{
					goto IL_0020;
				}
			}
			IL_0059:
			base.WriteValue(value);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000055E5 File Offset: 0x000037E5
		public override void WriteValue(sbyte? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0006A898 File Offset: 0x00068A98
		public override void WriteValue(short value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteValue(value);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			base.WriteValue(value);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000561C File Offset: 0x0000381C
		public override void WriteValue(short? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0006A908 File Offset: 0x00068B08
		[NullableContext(2)]
		public override void WriteValue(string value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteValue(value);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			base.WriteValue(value);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0006A978 File Offset: 0x00068B78
		public override void WriteValue(TimeSpan value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					goto IL_001E;
				}
				IL_003E:
				switch (num)
				{
				case 0:
					goto IL_001E;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_001E;
				}
				IL_0003:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					break;
				}
				goto IL_003E;
				IL_001E:
				this.jsonWriter_0.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
				{
					goto IL_0003;
				}
				goto IL_003E;
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00005653 File Offset: 0x00003853
		public override void WriteValue(TimeSpan? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0006A9FC File Offset: 0x00068BFC
		public override void WriteValue(uint value)
		{
			for (;;)
			{
				IL_0056:
				this.jsonTextWriter_0.WriteValue(value);
				for (;;)
				{
					this.jsonWriter_0.WriteValue(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_001E;
					}
					do
					{
						IL_0003:
						base.WriteValue(value);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0);
					IL_001E:
					switch (num)
					{
					case 0:
						goto IL_0003;
					case 1:
						return;
					case 2:
						break;
					case 3:
						goto IL_0056;
					default:
						goto IL_0003;
					}
				}
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0000568A File Offset: 0x0000388A
		public override void WriteValue(uint? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0006AA70 File Offset: 0x00068C70
		public override void WriteValue(ulong value)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_001C;
				}
				IL_003C:
				switch (num)
				{
				case 0:
					goto IL_001C;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_001C;
				}
				IL_0003:
				base.WriteValue(value);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_003C;
				}
				IL_001C:
				this.jsonWriter_0.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_0003;
				}
				goto IL_003C;
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000056C1 File Offset: 0x000038C1
		public override void WriteValue(ulong? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0006AAF4 File Offset: 0x00068CF4
		[NullableContext(2)]
		public override void WriteValue(Uri value)
		{
			for (;;)
			{
				IL_007F:
				this.jsonTextWriter_0.WriteValue(value);
				for (;;)
				{
					IL_005F:
					this.jsonWriter_0.WriteValue(value);
					int num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_5;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							goto IL_005F;
						case 3:
							goto IL_007F;
						case 4:
							return;
						case 5:
							if (!(value == null))
							{
								num = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
								{
									goto IL_0003;
								}
								continue;
							}
							break;
						case 6:
							goto IL_0003;
						}
						goto Block_4;
						IL_0003:
						base.WriteValue(value);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							goto Block_1;
						}
					}
				}
			}
			Block_1:
			return;
			Block_4:
			Block_5:
			base.WriteUndefined();
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0006AB98 File Offset: 0x00068D98
		public override void WriteValue(ushort value)
		{
			for (;;)
			{
				IL_0051:
				this.jsonTextWriter_0.WriteValue(value);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0021;
					case 2:
						this.jsonWriter_0.WriteValue(value);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							goto IL_0021;
						}
						continue;
					case 3:
						goto IL_0051;
					}
					return;
					IL_0021:
					base.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000056F8 File Offset: 0x000038F8
		public override void WriteValue(ushort? value)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			if (value != null)
			{
				base.WriteValue(value.GetValueOrDefault());
				return;
			}
			base.WriteUndefined();
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0006AC18 File Offset: 0x00068E18
		public override void WriteWhitespace(string ws)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteWhitespace(ws);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					goto IL_001E;
				}
				IL_002C:
				switch (num)
				{
				case 0:
					goto IL_001E;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001E;
				}
				IL_0003:
				base.WriteWhitespace(ws);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
				{
					break;
				}
				goto IL_002C;
				IL_001E:
				this.jsonWriter_0.WriteWhitespace(ws);
				goto IL_0003;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0006AC8C File Offset: 0x00068E8C
		[NullableContext(2)]
		public override void WriteComment(string text)
		{
			for (;;)
			{
				IL_0056:
				this.jsonTextWriter_0.WriteComment(text);
				for (;;)
				{
					this.jsonWriter_0.WriteComment(text);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto IL_001E;
					}
					do
					{
						IL_0003:
						base.WriteComment(text);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0);
					IL_001E:
					switch (num)
					{
					case 0:
						goto IL_0003;
					case 1:
						return;
					case 2:
						break;
					case 3:
						goto IL_0056;
					default:
						goto IL_0003;
					}
				}
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0006AD00 File Offset: 0x00068F00
		public override void WriteStartArray()
		{
			for (;;)
			{
				IL_0037:
				this.jsonTextWriter_0.WriteStartArray();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.jsonWriter_0.WriteStartArray();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0037;
					case 3:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			base.WriteStartArray();
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0006AD6C File Offset: 0x00068F6C
		public override void WriteEndArray()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteEndArray();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_001B;
				}
				IL_003A:
				switch (num)
				{
				case 0:
					goto IL_001B;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001B;
				}
				IL_0003:
				base.WriteEndArray();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_003A;
				}
				IL_001B:
				this.jsonWriter_0.WriteEndArray();
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_0003;
				}
				goto IL_003A;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0006ADEC File Offset: 0x00068FEC
		public override void WriteStartConstructor(string name)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteStartConstructor(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteStartConstructor(name);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			base.WriteStartConstructor(name);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0006AE5C File Offset: 0x0006905C
		public override void WriteEndConstructor()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteEndConstructor();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_001D;
				}
				goto IL_002A;
				IL_0003:
				base.WriteEndConstructor();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					continue;
				}
				goto IL_002A;
				IL_001D:
				this.jsonWriter_0.WriteEndConstructor();
				goto IL_0003;
				IL_002A:
				switch (num)
				{
				case 0:
					goto IL_001D;
				case 1:
					break;
				case 2:
					return;
				case 3:
					goto IL_0003;
				default:
					goto IL_001D;
				}
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0006AECC File Offset: 0x000690CC
		public override void WritePropertyName(string name)
		{
			for (;;)
			{
				IL_0056:
				this.jsonTextWriter_0.WritePropertyName(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_003E;
				}
				do
				{
					IL_001E:
					this.jsonWriter_0.WritePropertyName(name);
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0);
				for (;;)
				{
					IL_003E:
					switch (num)
					{
					case 1:
						goto IL_001E;
					case 2:
						goto IL_0056;
					case 3:
						base.WritePropertyName(name);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							continue;
						}
						break;
					}
					return;
				}
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0006AF50 File Offset: 0x00069150
		public override void WritePropertyName(string name, bool escape)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WritePropertyName(name, escape);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0003;
				}
				goto IL_003D;
				do
				{
					IL_0022:
					base.WritePropertyName(name);
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0);
				IL_003D:
				switch (num)
				{
				case 0:
					goto IL_0022;
				case 1:
					IL_0003:
					this.jsonWriter_0.WritePropertyName(name, escape);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_0022;
					}
					goto IL_003D;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_0022;
				}
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0006AFD4 File Offset: 0x000691D4
		public override void WriteStartObject()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteStartObject();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					goto IL_001B;
				}
				IL_0028:
				switch (num)
				{
				case 0:
					goto IL_001B;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001B;
				}
				IL_0003:
				base.WriteStartObject();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_0028;
				}
				IL_001B:
				this.jsonWriter_0.WriteStartObject();
				goto IL_0003;
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0006B040 File Offset: 0x00069240
		public override void WriteEndObject()
		{
			for (;;)
			{
				IL_0051:
				this.jsonTextWriter_0.WriteEndObject();
				for (;;)
				{
					this.jsonWriter_0.WriteEndObject();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0003;
					}
					IL_001A:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0051;
					}
					IL_0003:
					base.WriteEndObject();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_001A;
					}
					return;
				}
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0006B0AC File Offset: 0x000692AC
		[NullableContext(2)]
		public override void WriteRawValue(string json)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteRawValue(json);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					return;
				}
				IL_0003:
				this.jsonWriter_0.WriteRawValue(json);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0059:
			base.InternalWriteValue(JsonToken.Undefined);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0006B11C File Offset: 0x0006931C
		[NullableContext(2)]
		public override void WriteRaw(string json)
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteRaw(json);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_0003;
				}
				IL_0039:
				switch (num)
				{
				case 1:
					IL_0003:
					this.jsonWriter_0.WriteRaw(json);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto IL_0039;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				base.WriteRaw(json);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_0039;
				}
				break;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0006B19C File Offset: 0x0006939C
		public override void Close()
		{
			for (;;)
			{
				IL_0051:
				this.jsonTextWriter_0.Close();
				for (;;)
				{
					this.jsonWriter_0.Close();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
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
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_001A;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0051;
					}
					return;
				}
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0006B208 File Offset: 0x00069408
		public override void Flush()
		{
			for (;;)
			{
				this.jsonTextWriter_0.Flush();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
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
				this.jsonWriter_0.Flush();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					goto IL_001F;
				}
				break;
			}
		}

		// Token: 0x040005D3 RID: 1491
		private readonly JsonWriter jsonWriter_0;

		// Token: 0x040005D4 RID: 1492
		private readonly JsonTextWriter jsonTextWriter_0;

		// Token: 0x040005D5 RID: 1493
		private readonly StringWriter stringWriter_0;
	}
}
