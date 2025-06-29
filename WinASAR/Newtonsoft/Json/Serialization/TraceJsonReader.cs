using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000128 RID: 296
	[NullableContext(1)]
	[Nullable(0)]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x00069C04 File Offset: 0x00067E04
		public TraceJsonReader(JsonReader innerReader)
		{
			int num = 5;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
			{
				do
				{
					switch (num)
					{
					case 0:
						goto IL_0087;
					case 1:
						goto IL_004B;
					case 2:
						break;
					case 3:
						return;
					case 4:
						goto IL_00CA;
					case 5:
						this.VdUqJltisy = innerReader;
						break;
					default:
						goto IL_0087;
					}
					this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						continue;
					}
					IL_004B:
					this.stringWriter_0.Write(Class15.smethod_17(1760333523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039) + Environment.NewLine);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						continue;
					}
					IL_0087:
					this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0);
				IL_00CA:
				this.jsonTextWriter_0.Formatting = Formatting.Indented;
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00005275 File Offset: 0x00003475
		public string GetDeserializedJsonMessage()
		{
			return this.stringWriter_0.ToString();
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00005282 File Offset: 0x00003482
		public override bool Read()
		{
			bool flag = this.VdUqJltisy.Read();
			this.WriteCurrentToken();
			return flag;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00005295 File Offset: 0x00003495
		public override int? vmethod_0()
		{
			int? num = this.VdUqJltisy.vmethod_0();
			this.WriteCurrentToken();
			return num;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000052A8 File Offset: 0x000034A8
		[NullableContext(2)]
		public override string ReadAsString()
		{
			string text = this.VdUqJltisy.ReadAsString();
			this.WriteCurrentToken();
			return text;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000052BB File Offset: 0x000034BB
		[NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			byte[] array = this.VdUqJltisy.ReadAsBytes();
			this.WriteCurrentToken();
			return array;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000052CE File Offset: 0x000034CE
		public override decimal? ReadAsDecimal()
		{
			decimal? num = this.VdUqJltisy.ReadAsDecimal();
			this.WriteCurrentToken();
			return num;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000052E1 File Offset: 0x000034E1
		public override double? ReadAsDouble()
		{
			double? num = this.VdUqJltisy.ReadAsDouble();
			this.WriteCurrentToken();
			return num;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000052F4 File Offset: 0x000034F4
		public override bool? ReadAsBoolean()
		{
			bool? flag = this.VdUqJltisy.ReadAsBoolean();
			this.WriteCurrentToken();
			return flag;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00005307 File Offset: 0x00003507
		public override DateTime? ReadAsDateTime()
		{
			DateTime? dateTime = this.VdUqJltisy.ReadAsDateTime();
			this.WriteCurrentToken();
			return dateTime;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0000531A File Offset: 0x0000351A
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			DateTimeOffset? dateTimeOffset = this.VdUqJltisy.ReadAsDateTimeOffset();
			this.WriteCurrentToken();
			return dateTimeOffset;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00069CE8 File Offset: 0x00067EE8
		public void WriteCurrentToken()
		{
			for (;;)
			{
				this.jsonTextWriter_0.WriteToken(this.VdUqJltisy, false, false, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0000532D File Offset: 0x0000352D
		public override int Depth
		{
			get
			{
				return this.VdUqJltisy.Depth;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0000533A File Offset: 0x0000353A
		public override string Path
		{
			get
			{
				return this.VdUqJltisy.Path;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00005347 File Offset: 0x00003547
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00069D2C File Offset: 0x00067F2C
		public override char QuoteChar
		{
			get
			{
				return this.VdUqJltisy.QuoteChar;
			}
			protected internal set
			{
				for (;;)
				{
					this.VdUqJltisy.QuoteChar = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00005354 File Offset: 0x00003554
		public override JsonToken TokenType
		{
			get
			{
				return this.VdUqJltisy.TokenType;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00005361 File Offset: 0x00003561
		[Nullable(2)]
		public override object Value
		{
			[NullableContext(2)]
			get
			{
				return this.VdUqJltisy.Value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0000536E File Offset: 0x0000356E
		[Nullable(2)]
		public override Type ValueType
		{
			[NullableContext(2)]
			get
			{
				return this.VdUqJltisy.ValueType;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00069D68 File Offset: 0x00067F68
		public override void Close()
		{
			for (;;)
			{
				this.VdUqJltisy.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
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

		// Token: 0x06000BFC RID: 3068 RVA: 0x00069DA4 File Offset: 0x00067FA4
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo;
			for (;;)
			{
				jsonLineInfo = this.VdUqJltisy as IJsonLineInfo;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0050;
				}
				IL_0003:
				if (jsonLineInfo == null)
				{
					break;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0018;
				}
			}
			return false;
			IL_0050:
			return jsonLineInfo.HasLineInfo();
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00069E08 File Offset: 0x00068008
		int IJsonLineInfo.LineNumber
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				for (;;)
				{
					IL_0033:
					jsonLineInfo = this.VdUqJltisy as IJsonLineInfo;
					while (jsonLineInfo != null)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							switch (num)
							{
							case 1:
								return 0;
							case 2:
								continue;
							case 3:
								goto IL_0033;
							}
							goto Block_2;
						}
						goto IL_0042;
					}
					return 0;
				}
				Block_2:
				IL_0042:
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00069E64 File Offset: 0x00068064
		int IJsonLineInfo.LinePosition
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				for (;;)
				{
					jsonLineInfo = this.VdUqJltisy as IJsonLineInfo;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_001C;
					}
					IL_0015:
					while (jsonLineInfo == null)
					{
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_001C;
						}
					}
					break;
					IL_001C:
					switch (num)
					{
					case 0:
						goto IL_0015;
					case 1:
						break;
					case 2:
						return 0;
					default:
						goto IL_0015;
					}
				}
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x040005CF RID: 1487
		private readonly JsonReader VdUqJltisy;

		// Token: 0x040005D0 RID: 1488
		private readonly JsonTextWriter jsonTextWriter_0;

		// Token: 0x040005D1 RID: 1489
		private readonly StringWriter stringWriter_0;
	}
}
