using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200006A RID: 106
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonTextWriter : JsonWriter
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00035F44 File Offset: 0x00034144
		[Nullable(1)]
		private Base64Encoder Base64Encoder_0
		{
			[NullableContext(1)]
			get
			{
				while (this.base64Encoder_0 == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
					{
						goto IL_0015;
					}
					IL_0037:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0057;
					}
					IL_0015:
					this.base64Encoder_0 = new Base64Encoder(this.textWriter_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_0037;
					}
					break;
				}
				IL_0057:
				return this.base64Encoder_0;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000031F5 File Offset: 0x000013F5
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000031FD File Offset: 0x000013FD
		public IArrayPool<char> ArrayPool
		{
			get
			{
				return this.iarrayPool_0;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException(Class15.smethod_17(543250556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				}
				this.iarrayPool_0 = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00035FB0 File Offset: 0x000341B0
		public int Indentation
		{
			get
			{
				return this.int_0;
			}
			set
			{
				for (;;)
				{
					int num;
					if (value < 0)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
						{
							break;
						}
					}
					else
					{
						this.int_0 = value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
						{
							break;
						}
					}
					switch (num)
					{
					case 1:
						goto IL_004D;
					case 2:
						continue;
					}
					break;
				}
				return;
				IL_004D:
				throw new ArgumentException(Class15.smethod_17(538820159 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000322C File Offset: 0x0000142C
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00036028 File Offset: 0x00034228
		public char QuoteChar
		{
			get
			{
				return this.char_1;
			}
			set
			{
				for (;;)
				{
					if (value == '"')
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_0034;
					}
					IL_001B:
					switch (num)
					{
					default:
						IL_0034:
						if (value != '\'')
						{
							goto Block_1;
						}
						break;
					case 1:
						continue;
					case 2:
						goto IL_0074;
					case 3:
						goto IL_0058;
					case 4:
						return;
					}
					IL_0003:
					this.char_1 = value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_001B;
					}
					goto IL_0073;
				}
				Block_1:
				IL_0058:
				throw new ArgumentException(Class15.smethod_17(1760297415 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039));
				IL_0073:
				IL_0074:
				this.method_14();
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00003234 File Offset: 0x00001434
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000360B0 File Offset: 0x000342B0
		public char IndentChar
		{
			get
			{
				return this.char_0;
			}
			set
			{
				while (value != this.char_0)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0032;
					}
					IL_004D:
					switch (num)
					{
					case 0:
						return;
					case 1:
						IL_0032:
						this.char_0 = value;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
						{
							goto IL_004D;
						}
						break;
					case 2:
						continue;
					case 3:
						break;
					default:
						return;
					}
					this.char_3 = null;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						break;
					}
					goto IL_004D;
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00036130 File Offset: 0x00034330
		public bool QuoteName
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
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

		// Token: 0x0600046F RID: 1135 RVA: 0x00036168 File Offset: 0x00034368
		[NullableContext(1)]
		public JsonTextWriter(TextWriter textWriter)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
			{
				goto IL_00AD;
			}
			for (;;)
			{
				IL_00B3:
				switch (num)
				{
				case 1:
					goto IL_006E;
				case 2:
					goto IL_00AD;
				case 3:
					goto IL_003C;
				case 4:
					return;
				case 5:
					this.char_0 = ' ';
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						continue;
					}
					break;
				case 6:
					goto IL_0088;
				case 7:
					goto IL_0022;
				case 8:
					goto IL_00E5;
				}
				break;
			}
			goto IL_0055;
			IL_0022:
			this.char_1 = '"';
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
			{
				goto IL_00B3;
			}
			IL_003C:
			this.bool_2 = true;
			num = 5;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
			{
				goto IL_00B3;
			}
			IL_0055:
			this.int_0 = 2;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
			{
				goto IL_00B3;
			}
			IL_006E:
			this.method_14();
			num = 4;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
			{
				return;
			}
			goto IL_00B3;
			IL_0088:
			this.textWriter_0 = textWriter;
			goto IL_0022;
			IL_00AD:
			if (textWriter != null)
			{
				goto IL_0088;
			}
			IL_00E5:
			throw new ArgumentNullException(Class15.smethod_17(1387476884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00036278 File Offset: 0x00034478
		public override void Flush()
		{
			for (;;)
			{
				this.textWriter_0.Flush();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
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

		// Token: 0x06000471 RID: 1137 RVA: 0x000362B4 File Offset: 0x000344B4
		public override void Close()
		{
			for (;;)
			{
				base.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0003;
				}
				IL_001A:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_13();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_001A;
				}
				break;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0003630C File Offset: 0x0003450C
		private void method_13()
		{
			for (;;)
			{
				if (this.char_2 != null)
				{
					goto IL_0079;
				}
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					goto IL_0048;
				}
				IL_0051:
				switch (num)
				{
				case 0:
					goto IL_0023;
				case 1:
					return;
				case 2:
					IL_0079:
					BufferUtils.ReturnBuffer(this.iarrayPool_0, this.char_2);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
					{
						goto IL_0048;
					}
					goto IL_0051;
				case 3:
					goto IL_0048;
				case 4:
				case 7:
					break;
				case 5:
					continue;
				case 6:
					return;
				default:
					goto IL_0023;
				}
				IL_0006:
				if (!base.CloseOutput)
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_0023;
				}
				goto IL_0051;
				IL_0048:
				this.char_2 = null;
				goto IL_0006;
				IL_0023:
				TextWriter textWriter = this.textWriter_0;
				if (textWriter == null)
				{
					return;
				}
				textWriter.Close();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					break;
				}
				goto IL_0051;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000363DC File Offset: 0x000345DC
		public override void WriteStartObject()
		{
			for (;;)
			{
				base.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0024;
				}
				do
				{
					IL_0003:
					this.textWriter_0.Write('{');
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0);
				IL_0024:
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

		// Token: 0x06000474 RID: 1140 RVA: 0x00036440 File Offset: 0x00034640
		public override void WriteStartArray()
		{
			for (;;)
			{
				IL_0035:
				base.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.textWriter_0.Write('[');
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0035;
					}
					return;
				}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000364A0 File Offset: 0x000346A0
		[NullableContext(1)]
		public override void WriteStartConstructor(string name)
		{
			for (;;)
			{
				base.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0044;
				}
				IL_0066:
				switch (num)
				{
				case 1:
					IL_0044:
					this.textWriter_0.Write(Class15.smethod_17(432115541 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
					goto IL_0024;
				case 2:
					continue;
				case 3:
					goto IL_0024;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				this.textWriter_0.Write('(');
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					break;
				}
				goto IL_0066;
				IL_0024:
				this.textWriter_0.Write(name);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_0003;
				}
				goto IL_0066;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0003654C File Offset: 0x0003474C
		protected override void WriteEnd(JsonToken token)
		{
			for (;;)
			{
				switch (token)
				{
				case JsonToken.EndObject:
					goto IL_0059;
				case JsonToken.EndArray:
				{
					this.textWriter_0.Write(']');
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						switch (num)
						{
						case 1:
							goto IL_0059;
						case 2:
							goto IL_0068;
						case 3:
							continue;
						case 4:
							return;
						case 5:
							return;
						}
						goto Block_2;
					}
					return;
				}
				case JsonToken.EndConstructor:
					goto IL_009A;
				}
				goto Block_3;
			}
			Block_2:
			return;
			Block_3:
			goto IL_0068;
			IL_0059:
			this.textWriter_0.Write('}');
			return;
			IL_0068:
			throw JsonWriterException.Create(this, Class15.smethod_17(1802351241 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4) + token.ToString(), null);
			IL_009A:
			this.textWriter_0.Write(')');
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00036600 File Offset: 0x00034800
		[NullableContext(1)]
		public override void WritePropertyName(string name)
		{
			for (;;)
			{
				IL_005D:
				base.InternalWritePropertyName(name);
				for (;;)
				{
					this.method_16(name, this.bool_2);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0024;
					}
					do
					{
						IL_0003:
						this.textWriter_0.Write(':');
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0);
					IL_0024:
					switch (num)
					{
					case 0:
						goto IL_0003;
					case 1:
						return;
					case 2:
						break;
					case 3:
						goto IL_005D;
					default:
						goto IL_0003;
					}
				}
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00036674 File Offset: 0x00034874
		[NullableContext(1)]
		public override void WritePropertyName(string name, bool escape)
		{
			for (;;)
			{
				IL_00FA:
				base.InternalWritePropertyName(name);
				for (;;)
				{
					if (escape)
					{
						goto IL_0006;
					}
					goto IL_00E6;
					IL_0049:
					int num;
					switch (num)
					{
					case 1:
					case 2:
						goto IL_0084;
					case 3:
						continue;
					case 4:
						goto IL_00FA;
					case 5:
						goto IL_00D8;
					case 6:
						goto IL_0027;
					case 7:
						IL_0006:
						this.method_16(name, this.bool_2);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
						{
							goto IL_0084;
						}
						goto IL_0049;
					case 8:
						goto IL_00C7;
					case 9:
						IL_00E6:
						if (this.bool_2)
						{
							goto IL_00C7;
						}
						goto IL_00D8;
					case 10:
						goto IL_00BC;
					}
					return;
					IL_0027:
					this.textWriter_0.Write(this.char_1);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0049;
					}
					IL_0084:
					this.textWriter_0.Write(':');
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						return;
					}
					goto IL_0049;
					IL_00BC:
					if (!this.bool_2)
					{
						goto IL_0084;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_0027;
					}
					goto IL_0049;
					IL_00D8:
					this.textWriter_0.Write(name);
					goto IL_00BC;
					IL_00C7:
					this.textWriter_0.Write(this.char_1);
					goto IL_00D8;
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00003244 File Offset: 0x00001444
		internal override void OnStringEscapeHandlingChanged()
		{
			this.method_14();
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00036788 File Offset: 0x00034988
		private void method_14()
		{
			for (;;)
			{
				this.bool_3 = JavaScriptUtils.GetCharEscapeFlags(base.StringEscapeHandling, this.char_1);
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

		// Token: 0x0600047B RID: 1147 RVA: 0x000367D0 File Offset: 0x000349D0
		protected override void WriteIndent()
		{
			for (;;)
			{
				int num = base.Top * this.int_0;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_008B;
				}
				goto IL_0095;
				IL_0026:
				int num3;
				this.textWriter_0.Write(this.char_3, num3, Math.Min(num, 12));
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					continue;
				}
				goto IL_0095;
				IL_0006:
				if ((num -= 12) <= 0)
				{
					break;
				}
				num2 = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0026;
				}
				goto IL_0095;
				IL_0056:
				this.textWriter_0.Write(this.char_3, 0, num3 + Math.Min(num, 12));
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0006;
				}
				goto IL_0095;
				IL_008B:
				num3 = this.Fjubsqgbmy();
				goto IL_0056;
				IL_0095:
				switch (num2)
				{
				case 0:
					goto IL_008B;
				case 1:
					break;
				case 2:
				case 6:
					goto IL_0006;
				case 3:
					goto IL_0056;
				case 4:
				case 5:
					goto IL_0026;
				case 7:
					return;
				default:
					goto IL_008B;
				}
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000368C0 File Offset: 0x00034AC0
		private int Fjubsqgbmy()
		{
			string newLine;
			int length;
			for (;;)
			{
				newLine = this.textWriter_0.NewLine;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_009A;
				}
				IL_00A5:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_0063;
				case 1:
					IL_009A:
					length = newLine.Length;
					goto IL_007B;
				case 2:
					continue;
				case 3:
				case 5:
					break;
				case 4:
					return length;
				case 6:
					goto IL_002C;
				case 7:
					goto IL_010E;
				case 8:
					goto IL_007B;
				case 9:
					goto IL_0068;
				case 10:
				case 14:
					goto IL_0023;
				case 11:
					goto IL_001D;
				case 12:
					goto IL_0006;
				case 13:
					IL_004D:
					if (flag)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
						{
							goto IL_0063;
						}
						goto IL_00A5;
					}
					break;
				default:
					goto IL_0063;
				}
				IL_002F:
				if (flag)
				{
					return length;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					break;
				}
				goto IL_00A5;
				IL_0023:
				int num2;
				if (num2 == length)
				{
					goto IL_002F;
				}
				goto IL_0006;
				IL_001D:
				num2++;
				goto IL_0023;
				IL_0006:
				if (newLine[num2] != this.char_3[num2])
				{
					goto IL_002C;
				}
				goto IL_001D;
				IL_007B:
				bool flag2;
				if (this.char_3 == null)
				{
					flag2 = false;
					goto IL_0077;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0068;
				}
				goto IL_00A5;
				IL_002C:
				flag = false;
				goto IL_002F;
				IL_0077:
				flag = flag2;
				goto IL_004D;
				IL_0068:
				flag2 = this.char_3.Length == 12 + length;
				goto IL_0077;
				IL_0063:
				num2 = 0;
				goto IL_0023;
			}
			IL_010E:
			this.char_3 = (newLine + new string(this.char_0, 12)).ToCharArray();
			return length;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000369FC File Offset: 0x00034BFC
		protected override void WriteValueDelimiter()
		{
			for (;;)
			{
				this.textWriter_0.Write(',');
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
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

		// Token: 0x0600047E RID: 1150 RVA: 0x00036A3C File Offset: 0x00034C3C
		protected override void WriteIndentSpace()
		{
			for (;;)
			{
				this.textWriter_0.Write(' ');
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
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

		// Token: 0x0600047F RID: 1151 RVA: 0x00036A7C File Offset: 0x00034C7C
		[NullableContext(1)]
		private void method_15(string string_1, JsonToken jsonToken_0)
		{
			for (;;)
			{
				this.textWriter_0.Write(string_1);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
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

		// Token: 0x06000480 RID: 1152 RVA: 0x00036AB8 File Offset: 0x00034CB8
		public override void WriteValue(object value)
		{
			for (;;)
			{
				if (value is BigInteger)
				{
					goto IL_006A;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto Block_3;
				}
				IL_002B:
				BigInteger bigInteger;
				switch (num)
				{
				case 1:
					IL_006A:
					bigInteger = (BigInteger)value;
					goto IL_004F;
				case 2:
					goto IL_004F;
				case 3:
					return;
				case 4:
					goto IL_0006;
				case 5:
					goto IL_0098;
				case 6:
					continue;
				}
				break;
				IL_0006:
				this.method_15(bigInteger.ToString(CultureInfo.InvariantCulture), JsonToken.String);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_002B;
				}
				break;
				IL_004F:
				base.InternalWriteValue(JsonToken.Integer);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0006;
				}
				goto IL_002B;
			}
			return;
			Block_3:
			IL_0098:
			base.WriteValue(value);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00036B64 File Offset: 0x00034D64
		public override void WriteNull()
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Null);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(JsonConvert.Null, JsonToken.Null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00036BC4 File Offset: 0x00034DC4
		public override void WriteUndefined()
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Undefined);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(JsonConvert.Undefined, JsonToken.Undefined);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00036C24 File Offset: 0x00034E24
		public override void WriteRaw(string json)
		{
			for (;;)
			{
				base.InternalWriteRaw();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
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
				this.textWriter_0.Write(json);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
				{
					goto IL_0020;
				}
				break;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00036C80 File Offset: 0x00034E80
		public override void WriteValue(string value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0003;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					goto IL_0006;
				case 2:
					IL_0003:
					if (value == null)
					{
						goto IL_0006;
					}
					goto IL_0062;
				case 3:
					continue;
				case 4:
					goto IL_0062;
				case 5:
					return;
				}
				break;
				IL_0006:
				this.method_15(JsonConvert.Null, JsonToken.Null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_0024;
				}
				break;
			}
			return;
			IL_0062:
			this.method_16(value, true);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00036CF8 File Offset: 0x00034EF8
		[NullableContext(1)]
		private void method_16(string string_1, bool bool_4)
		{
			for (;;)
			{
				this.method_19();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
				{
					goto IL_0003;
				}
				IL_003F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				JavaScriptUtils.WriteEscapedJavaScriptString(this.textWriter_0, string_1, this.char_1, bool_4, this.bool_3, base.StringEscapeHandling, this.iarrayPool_0, ref this.char_2);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_003F;
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00036D74 File Offset: 0x00034F74
		public override void WriteValue(int value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_23(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_001B;
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00036DCC File Offset: 0x00034FCC
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_20((long)((ulong)value));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_001C;
				}
				break;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00036E28 File Offset: 0x00035028
		public override void WriteValue(long value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_20(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
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

		// Token: 0x06000489 RID: 1161 RVA: 0x00036E80 File Offset: 0x00035080
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_21(value, false);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_001C;
				}
				break;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00036EDC File Offset: 0x000350DC
		public override void WriteValue(float value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Float);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_0003;
				}
				IL_002E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_15(JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_002E;
				}
				break;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000324C File Offset: 0x0000144C
		public override void WriteValue(float? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.Float);
			this.method_15(JsonConvert.ToString(value.GetValueOrDefault(), base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00036F48 File Offset: 0x00035148
		public override void WriteValue(double value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Float);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_0003;
				}
				IL_002E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_15(JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_002E;
				}
				break;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003285 File Offset: 0x00001485
		public override void WriteValue(double? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.Float);
			this.method_15(JsonConvert.ToString(value.GetValueOrDefault(), base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00036FB4 File Offset: 0x000351B4
		public override void WriteValue(bool value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Boolean);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0025;
				}
				do
				{
					IL_0003:
					this.method_15(JsonConvert.ToString(value), JsonToken.Boolean);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0);
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

		// Token: 0x0600048F RID: 1167 RVA: 0x00037018 File Offset: 0x00035218
		public override void WriteValue(short value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_23((int)value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
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

		// Token: 0x06000490 RID: 1168 RVA: 0x00037070 File Offset: 0x00035270
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_001E;
				}
				do
				{
					IL_0003:
					this.method_23((int)value);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0);
				IL_001E:
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

		// Token: 0x06000491 RID: 1169 RVA: 0x000370CC File Offset: 0x000352CC
		public override void WriteValue(char value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
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
				this.method_15(JsonConvert.ToString(value), JsonToken.String);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0003712C File Offset: 0x0003532C
		public override void WriteValue(byte value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_23((int)value);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00037184 File Offset: 0x00035384
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_23((int)value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000371DC File Offset: 0x000353DC
		public override void WriteValue(decimal value)
		{
			for (;;)
			{
				base.InternalWriteValue(JsonToken.Float);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_15(JsonConvert.ToString(value), JsonToken.Float);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_0021;
				}
				break;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0003723C File Offset: 0x0003543C
		public override void WriteValue(DateTime value)
		{
			int num2;
			for (;;)
			{
				IL_00DB:
				base.InternalWriteValue(JsonToken.Date);
				for (;;)
				{
					value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_005B;
					}
					IL_008D:
					switch (num)
					{
					case 0:
						goto IL_005B;
					case 1:
						goto IL_00E6;
					case 2:
						goto IL_0026;
					case 3:
						continue;
					case 4:
						goto IL_00DB;
					case 5:
						break;
					case 6:
						goto IL_00FA;
					case 7:
						return;
					case 8:
						return;
					default:
						goto IL_005B;
					}
					IL_0006:
					num2 = this.method_17(value);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto Block_1;
					}
					goto IL_008D;
					IL_005B:
					if (StringUtils.IsNullOrEmpty(base.DateFormatString))
					{
						goto IL_0006;
					}
					this.textWriter_0.Write(this.char_1);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						goto IL_008D;
					}
					IL_0026:
					this.textWriter_0.Write(value.ToString(base.DateFormatString, base.Culture));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto Block_2;
					}
					goto IL_008D;
				}
			}
			Block_1:
			goto IL_00FA;
			Block_2:
			IL_00E6:
			this.textWriter_0.Write(this.char_1);
			return;
			IL_00FA:
			this.textWriter_0.Write(this.char_2, 0, num2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00037358 File Offset: 0x00035558
		private int method_17(DateTime dateTime_0)
		{
			int num2;
			for (;;)
			{
				this.method_19();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					goto IL_0003;
				}
				IL_003D:
				switch (num)
				{
				case 1:
					IL_0003:
					num2 = 0;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_003D;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_009F;
				case 4:
					return num2;
				case 5:
					goto IL_0078;
				}
				this.char_2[num2++] = this.char_1;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_003D;
				}
				break;
			}
			IL_0078:
			num2 = DateTimeUtils.WriteDateTimeString(this.char_2, num2, dateTime_0, null, dateTime_0.Kind, base.DateFormatHandling);
			IL_009F:
			this.char_2[num2++] = this.char_1;
			return num2;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0003741C File Offset: 0x0003561C
		public override void WriteValue(byte[] value)
		{
			while (value != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_0071;
				}
				IL_008D:
				switch (num)
				{
				case 0:
					goto IL_00C3;
				case 1:
					IL_0071:
					base.InternalWriteValue(JsonToken.Bytes);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_003C;
					}
					goto IL_008D;
				case 2:
					continue;
				case 3:
					goto IL_005F;
				case 4:
					goto IL_003C;
				case 5:
					return;
				case 6:
					return;
				case 7:
					break;
				case 8:
					goto IL_00D5;
				default:
					goto IL_00C3;
				}
				IL_001A:
				this.Base64Encoder_0.Flush();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_00C3;
				}
				goto IL_008D;
				IL_005F:
				this.Base64Encoder_0.Encode(value, 0, value.Length);
				goto IL_001A;
				IL_003C:
				this.textWriter_0.Write(this.char_1);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_005F;
				}
				goto IL_008D;
				IL_00C3:
				this.textWriter_0.Write(this.char_1);
				return;
			}
			IL_00D5:
			this.WriteNull();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00037504 File Offset: 0x00035704
		public override void WriteValue(DateTimeOffset value)
		{
			for (;;)
			{
				IL_00D4:
				base.InternalWriteValue(JsonToken.Date);
				for (;;)
				{
					if (StringUtils.IsNullOrEmpty(base.DateFormatString))
					{
						goto IL_00A2;
					}
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_003B;
					}
					IL_004E:
					int num2;
					switch (num)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
						IL_003B:
						this.textWriter_0.Write(this.char_1);
						goto IL_0006;
					case 4:
						IL_00A2:
						num2 = this.method_18(value);
						goto IL_007A;
					case 5:
						goto IL_007A;
					case 6:
						continue;
					case 7:
						goto IL_00D4;
					case 8:
						goto IL_0006;
					}
					goto Block_2;
					IL_0006:
					this.textWriter_0.Write(value.ToString(base.DateFormatString, base.Culture));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto Block_1;
					}
					goto IL_004E;
					IL_007A:
					this.textWriter_0.Write(this.char_2, 0, num2);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						return;
					}
					goto IL_004E;
				}
			}
			Block_1:
			Block_2:
			this.textWriter_0.Write(this.char_1);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00037604 File Offset: 0x00035804
		private int method_18(DateTimeOffset dateTimeOffset_0)
		{
			int num;
			for (;;)
			{
				IL_00D4:
				this.method_19();
				for (;;)
				{
					IL_00BD:
					num = 0;
					int num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						goto IL_0078;
					}
					do
					{
						IL_009D:
						switch (num2)
						{
						case 1:
							goto IL_002C;
						case 2:
							goto IL_0078;
						case 3:
							goto IL_00BD;
						case 4:
							goto IL_00D4;
						case 5:
							this.char_2[num++] = this.char_1;
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
							{
								goto IL_002C;
							}
							continue;
						}
						return num;
						IL_002C:
						num = DateTimeUtils.WriteDateTimeString(this.char_2, num, (base.DateFormatHandling == DateFormatHandling.IsoDateFormat) ? dateTimeOffset_0.DateTime : dateTimeOffset_0.UtcDateTime, new TimeSpan?(dateTimeOffset_0.Offset), DateTimeKind.Local, base.DateFormatHandling);
						num2 = 2;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0);
					IL_0078:
					this.char_2[num++] = this.char_1;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_009D;
					}
					return num;
				}
			}
			return num;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000376F0 File Offset: 0x000358F0
		public override void WriteValue(Guid value)
		{
			string text;
			for (;;)
			{
				base.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_003A;
				}
				do
				{
					IL_0003:
					text = value.ToString(Class15.smethod_17(1678088462 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a), CultureInfo.InvariantCulture);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0);
				IL_003A:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					goto IL_0076;
				case 3:
					goto IL_0087;
				case 4:
					return;
				case 5:
					goto IL_0094;
				default:
					goto IL_0003;
				}
			}
			IL_0076:
			this.textWriter_0.Write(this.char_1);
			IL_0087:
			this.textWriter_0.Write(text);
			IL_0094:
			this.textWriter_0.Write(this.char_1);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000377A4 File Offset: 0x000359A4
		public override void WriteValue(TimeSpan value)
		{
			for (;;)
			{
				IL_00B2:
				base.InternalWriteValue(JsonToken.String);
				for (;;)
				{
					IL_008C:
					string text = value.ToString(null, CultureInfo.InvariantCulture);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_0006;
					}
					goto IL_006C;
					do
					{
						IL_0029:
						this.textWriter_0.Write(text);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0);
					for (;;)
					{
						IL_006C:
						switch (num)
						{
						case 1:
							this.textWriter_0.Write(this.char_1);
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
							{
								continue;
							}
							return;
						case 2:
							goto IL_0006;
						case 3:
							return;
						case 4:
							goto IL_008C;
						case 5:
							goto IL_00B2;
						}
						break;
					}
					goto IL_0029;
					IL_0006:
					this.textWriter_0.Write(this.char_1);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto IL_0029;
					}
					goto IL_006C;
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00037870 File Offset: 0x00035A70
		public override void WriteValue(Uri value)
		{
			for (;;)
			{
				if (value == null)
				{
					goto IL_000D;
				}
				base.InternalWriteValue(JsonToken.String);
				goto IL_0040;
				IL_0024:
				int num;
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0040:
					this.method_16(value.OriginalString, true);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						return;
					}
					goto IL_0024;
				case 3:
					IL_000D:
					this.WriteNull();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_0024;
					}
					break;
				case 4:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000378F0 File Offset: 0x00035AF0
		public override void WriteComment(string text)
		{
			for (;;)
			{
				base.InternalWriteComment();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					goto IL_0003;
				}
				IL_0034:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006B;
				case 3:
					goto IL_0077;
				case 4:
					return;
				}
				IL_0003:
				this.textWriter_0.Write(Class15.smethod_17(1953689195 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					goto IL_0034;
				}
				break;
			}
			IL_006B:
			this.textWriter_0.Write(text);
			IL_0077:
			this.textWriter_0.Write(Class15.smethod_17(1042101891 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00037994 File Offset: 0x00035B94
		[NullableContext(1)]
		public override void WriteWhitespace(string ws)
		{
			for (;;)
			{
				IL_0034:
				base.InternalWriteWhitespace(ws);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.textWriter_0.Write(ws);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0034;
					}
					return;
				}
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000379F4 File Offset: 0x00035BF4
		private void method_19()
		{
			while (this.char_2 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
				{
					goto IL_0015;
				}
				IL_0039:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0015:
				this.char_2 = BufferUtils.RentBuffer(this.iarrayPool_0, 35);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_0039;
				}
				break;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00037A5C File Offset: 0x00035C5C
		private void method_20(long long_0)
		{
			bool flag;
			while (long_0 >= 0L)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0042;
				}
				IL_0051:
				switch (num)
				{
				case 0:
					goto IL_0042;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					goto IL_0017;
				case 4:
					break;
				case 5:
					IL_0090:
					this.method_21((ulong)((!flag) ? long_0 : (-(ulong)long_0)), flag);
					break;
				default:
					goto IL_0042;
				}
				return;
				IL_0017:
				this.textWriter_0.Write((char)(48L + long_0));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					return;
				}
				goto IL_0051;
				IL_0042:
				if (long_0 <= 9L)
				{
					goto IL_0017;
				}
				break;
			}
			flag = long_0 < 0L;
			goto IL_0090;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00037B0C File Offset: 0x00035D0C
		private void method_21(ulong ulong_0, bool bool_4)
		{
			IL_005B:
			int num2;
			while (!bool_4 & (ulong_0 <= 9UL))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.textWriter_0.Write((char)(48UL + ulong_0));
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_005B;
						case 3:
							return;
						case 4:
							goto IL_0083;
						}
						break;
					}
					return;
					IL_0083:
					this.textWriter_0.Write(this.char_2, 0, num2);
					return;
				}
				return;
			}
			num2 = this.method_22(ulong_0, bool_4);
			goto IL_0083;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00037BB0 File Offset: 0x00035DB0
		private int method_22(ulong ulong_0, bool bool_4)
		{
			IL_0115:
			while (ulong_0 > 4294967295UL)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_00C9;
				}
				int num2;
				for (;;)
				{
					IL_00D1:
					switch (num)
					{
					case 1:
						goto IL_0115;
					case 2:
						num2++;
						goto IL_005A;
					case 3:
						goto IL_0033;
					case 4:
						goto IL_0084;
					case 5:
						goto IL_0026;
					case 6:
						goto IL_00A4;
					case 7:
						return num2;
					case 8:
						goto IL_009B;
					case 9:
						goto IL_0076;
					case 10:
						goto IL_007C;
					case 11:
						goto IL_005A;
					case 12:
						goto IL_012A;
					case 13:
						goto IL_0020;
					}
					goto Block_5;
					IL_005A:
					this.char_2[0] = '-';
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_0076;
					}
				}
				IL_0020:
				if (ulong_0 != 0UL)
				{
					goto IL_0026;
				}
				return num2;
				IL_009B:
				ulong num3;
				ulong_0 = num3;
				goto IL_0020;
				IL_00A4:
				int num4;
				ulong num5;
				this.char_2[--num4] = (char)(48UL + num5);
				goto IL_009B;
				Block_5:
				goto IL_00C9;
				IL_0033:
				num5 = ulong_0 - num3 * 10UL;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					continue;
				}
				goto IL_00D1;
				IL_0026:
				num3 = ulong_0 / 10UL;
				goto IL_0033;
				IL_0084:
				if (!bool_4)
				{
					goto IL_0076;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					continue;
				}
				goto IL_00D1;
				IL_007C:
				num2 = MathUtils.IntLength(ulong_0);
				goto IL_0084;
				IL_00C9:
				this.method_19();
				goto IL_007C;
				IL_0076:
				num4 = num2;
				goto IL_0026;
			}
			IL_012A:
			return this.method_25((uint)ulong_0, bool_4);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00037CF0 File Offset: 0x00035EF0
		private void method_23(int int_1)
		{
			for (;;)
			{
				if (int_1 >= 0)
				{
					goto IL_0077;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0018;
				}
				IL_0052:
				switch (num)
				{
				default:
					IL_0077:
					if (int_1 <= 9)
					{
						goto IL_009C;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_0052;
					}
					break;
				case 1:
				case 6:
					break;
				case 2:
					goto IL_009C;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_0030;
				case 7:
					continue;
				}
				IL_0018:
				bool flag = int_1 < 0;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_0052;
				}
				IL_0030:
				this.method_24((uint)(flag ? (-(uint)int_1) : int_1), flag);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_0052;
				}
				break;
			}
			return;
			IL_009C:
			this.textWriter_0.Write((char)(48 + int_1));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00037DAC File Offset: 0x00035FAC
		private void method_24(uint uint_0, bool bool_4)
		{
			for (;;)
			{
				if (!bool_4 & (uint_0 <= 9U))
				{
					goto IL_0067;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0006;
				}
				IL_0047:
				int num2;
				switch (num)
				{
				case 1:
					IL_0067:
					this.textWriter_0.Write((char)(48U + uint_0));
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto Block_2;
					}
					goto IL_0047;
				case 2:
					IL_0006:
					num2 = this.method_25(uint_0, bool_4);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_0047;
					}
					break;
				case 3:
					continue;
				case 4:
					return;
				case 5:
					return;
				}
				this.textWriter_0.Write(this.char_2, 0, num2);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_0047;
				}
				goto IL_00B7;
			}
			Block_2:
			return;
			IL_00B7:;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00037E74 File Offset: 0x00036074
		private int method_25(uint uint_0, bool bool_4)
		{
			int num;
			for (;;)
			{
				IL_0107:
				this.method_19();
				for (;;)
				{
					IL_00FC:
					num = MathUtils.IntLength((ulong)uint_0);
					for (;;)
					{
						IL_00F6:
						if (bool_4)
						{
							goto IL_00D7;
						}
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
						{
							goto IL_00C5;
						}
						int num5;
						for (;;)
						{
							IL_0069:
							uint num4;
							switch (num2)
							{
							case 1:
								goto IL_0021;
							case 2:
							case 5:
								goto IL_00AA;
							case 4:
								return num;
							case 6:
							{
								uint num3;
								uint_0 = num3;
								goto IL_0049;
							}
							case 7:
								goto IL_0049;
							case 8:
								goto IL_00F6;
							case 9:
							{
								uint num3;
								num4 = uint_0 - num3 * 10U;
								num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
								{
									goto IL_0021;
								}
								continue;
							}
							case 10:
								goto IL_00D7;
							case 11:
								goto IL_00CB;
							case 12:
								goto IL_00FC;
							case 13:
								goto IL_0107;
							}
							break;
							IL_0021:
							this.char_2[--num5] = (char)(48U + num4);
							num2 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
							{
								break;
							}
							continue;
							IL_0049:
							if (uint_0 == 0U)
							{
								return num;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
							{
								goto Block_3;
							}
						}
						goto IL_00C5;
						Block_3:
						goto IL_00AA;
						goto IL_00C5;
						for (;;)
						{
							IL_00AA:
							uint num3 = uint_0 / 10U;
							num2 = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
							{
								goto IL_0069;
							}
						}
						IL_00C5:
						num5 = num;
						goto IL_00AA;
						IL_00CB:
						this.char_2[0] = '-';
						goto IL_00C5;
						IL_00D7:
						num++;
						goto IL_00CB;
					}
				}
			}
			return num;
		}

		// Token: 0x040002AC RID: 684
		[Nullable(1)]
		private readonly TextWriter textWriter_0;

		// Token: 0x040002AD RID: 685
		private Base64Encoder base64Encoder_0;

		// Token: 0x040002AE RID: 686
		private char char_0;

		// Token: 0x040002AF RID: 687
		private int int_0;

		// Token: 0x040002B0 RID: 688
		private char char_1;

		// Token: 0x040002B1 RID: 689
		private bool bool_2;

		// Token: 0x040002B2 RID: 690
		private bool[] bool_3;

		// Token: 0x040002B3 RID: 691
		private char[] char_2;

		// Token: 0x040002B4 RID: 692
		private IArrayPool<char> iarrayPool_0;

		// Token: 0x040002B5 RID: 693
		private char[] char_3;
	}
}
