using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000060 RID: 96
	[Nullable(0)]
	[NullableContext(2)]
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00002D44 File Offset: 0x00000F44
		protected JsonReader.State CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002D4C File Offset: 0x00000F4C
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00029528 File Offset: 0x00027728
		public bool CloseInput
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00002D54 File Offset: 0x00000F54
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00029560 File Offset: 0x00027760
		public bool SupportMultipleContent
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002D5C File Offset: 0x00000F5C
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00029598 File Offset: 0x00027798
		public virtual char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			protected internal set
			{
				for (;;)
				{
					this._quoteChar = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00002D64 File Offset: 0x00000F64
		// (set) Token: 0x0600030E RID: 782 RVA: 0x000295D0 File Offset: 0x000277D0
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this.dateTimeZoneHandling_0;
			}
			set
			{
				while (value >= DateTimeZoneHandling.Local)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0015;
					}
					IL_002A:
					switch (num)
					{
					case 0:
						goto IL_0055;
					case 1:
						IL_0015:
						if (value > DateTimeZoneHandling.RoundtripKind)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
							{
								goto IL_002A;
							}
							goto IL_0055;
						}
						else
						{
							this.dateTimeZoneHandling_0 = value;
						}
						break;
					case 2:
						continue;
					case 3:
						break;
					default:
						goto IL_0055;
					}
					return;
				}
				IL_0055:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(277633428 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00002D6C File Offset: 0x00000F6C
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00029650 File Offset: 0x00027850
		public DateParseHandling DateParseHandling
		{
			get
			{
				return this._dateParseHandling;
			}
			set
			{
				for (;;)
				{
					if (value >= DateParseHandling.None)
					{
						goto IL_004B;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						break;
					}
					IL_001B:
					switch (num)
					{
					case 1:
					case 2:
						goto IL_0071;
					case 3:
						continue;
					case 4:
						return;
					}
					IL_004B:
					if (value > DateParseHandling.DateTimeOffset)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
						{
							break;
						}
						goto IL_001B;
					}
					else
					{
						this._dateParseHandling = value;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
						{
							goto IL_001B;
						}
						return;
					}
				}
				IL_0071:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1176462326 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00002D74 File Offset: 0x00000F74
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000296EC File Offset: 0x000278EC
		public FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._floatParseHandling;
			}
			set
			{
				while (value >= FloatParseHandling.Double)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_0015;
					}
					IL_0045:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					case 3:
						goto IL_006A;
					}
					IL_0015:
					if (value > FloatParseHandling.Decimal)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							break;
						}
						goto IL_0045;
					}
					else
					{
						this._floatParseHandling = value;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_0045;
						}
					}
					return;
				}
				IL_006A:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(564896464 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00002D7C File Offset: 0x00000F7C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00029780 File Offset: 0x00027980
		public string DateFormatString
		{
			get
			{
				return this.string_0;
			}
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00002D84 File Offset: 0x00000F84
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000297B8 File Offset: 0x000279B8
		public int? MaxDepth
		{
			get
			{
				return this.nullable_0;
			}
			set
			{
				int? num = value;
				if ((num.GetValueOrDefault() <= 0) & (num != null))
				{
					throw new ArgumentException(Class15.smethod_17(1760302967 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), Class15.smethod_17(2071405424 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
				}
				this.nullable_0 = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00002D8C File Offset: 0x00000F8C
		public virtual JsonToken TokenType
		{
			get
			{
				return this.jsonToken_0;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00002D94 File Offset: 0x00000F94
		public virtual object Value
		{
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00029818 File Offset: 0x00027A18
		public virtual Type ValueType
		{
			get
			{
				object obj;
				for (;;)
				{
					obj = this.object_0;
					if (obj != null)
					{
						goto IL_002F;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
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
				return null;
				IL_002F:
				return obj.GetType();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0002985C File Offset: 0x00027A5C
		public virtual int Depth
		{
			get
			{
				int num2;
				for (;;)
				{
					List<JsonPosition> list = this.list_0;
					if (list == null)
					{
						goto IL_0045;
					}
					int num = list.Count;
					IL_0012:
					num2 = num;
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						switch (num3)
						{
						case 1:
							goto IL_0049;
						case 2:
							goto IL_0045;
						case 3:
							continue;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_0063;
						}
						break;
					}
					goto IL_0048;
					IL_0045:
					num = 0;
					goto IL_0012;
				}
				return num2;
				IL_0048:
				IL_0049:
				if (JsonTokenUtils.IsStartToken(this.TokenType))
				{
					return num2;
				}
				IL_0056:
				if (this.jsonPosition_0.Type == JsonContainerType.None)
				{
					return num2;
				}
				IL_0063:
				return num2 + 1;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000298D4 File Offset: 0x00027AD4
		[Nullable(1)]
		public virtual string Path
		{
			[NullableContext(1)]
			get
			{
				while (this.jsonPosition_0.Type != JsonContainerType.None)
				{
					if (this._currentState == JsonReader.State.ArrayStart)
					{
						goto IL_0070;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_0055;
					}
					IL_0034:
					JsonPosition? jsonPosition;
					JsonPosition? jsonPosition2;
					switch (num)
					{
					default:
						IL_0055:
						if (this._currentState != JsonReader.State.ConstructorStart)
						{
							goto IL_005F;
						}
						goto IL_0070;
					case 1:
						jsonPosition = null;
						break;
					case 2:
						break;
					case 3:
						IL_008F:
						return string.Empty;
					case 4:
						continue;
					case 5:
						IL_00A2:
						return JsonPosition.BuildPath(this.list_0, jsonPosition2);
					case 6:
						goto IL_005F;
					}
					JsonPosition? jsonPosition3 = jsonPosition;
					goto IL_00A0;
					IL_006B:
					bool flag;
					if (flag)
					{
						jsonPosition3 = new JsonPosition?(this.jsonPosition_0);
						goto IL_00A0;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						goto IL_0055;
					}
					goto IL_0034;
					IL_0070:
					flag = false;
					goto IL_006B;
					IL_005F:
					flag = this._currentState != JsonReader.State.ObjectStart;
					goto IL_006B;
					IL_00A0:
					jsonPosition2 = jsonPosition3;
					goto IL_00A2;
				}
				goto IL_008F;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00029990 File Offset: 0x00027B90
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000299D0 File Offset: 0x00027BD0
		[Nullable(1)]
		public CultureInfo Culture
		{
			[NullableContext(1)]
			get
			{
				CultureInfo invariantCulture;
				while ((invariantCulture = this.cultureInfo_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					invariantCulture = CultureInfo.InvariantCulture;
					break;
				}
				return invariantCulture;
			}
			[NullableContext(1)]
			set
			{
				for (;;)
				{
					this.cultureInfo_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
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

		// Token: 0x0600031E RID: 798 RVA: 0x00029A08 File Offset: 0x00027C08
		internal JsonPosition GetPosition(int depth)
		{
			while (this.list_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0015;
				}
				IL_0034:
				switch (num)
				{
				case 1:
					IL_0015:
					if (depth >= this.list_0.Count)
					{
						goto IL_0061;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						goto IL_0034;
					}
					break;
				case 2:
					continue;
				}
				return this.list_0[depth];
			}
			IL_0061:
			return this.jsonPosition_0;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00029A7C File Offset: 0x00027C7C
		protected JsonReader()
		{
			for (;;)
			{
				IL_00AA:
				this._currentState = JsonReader.State.Start;
				for (;;)
				{
					IL_00A1:
					this.dateTimeZoneHandling_0 = DateTimeZoneHandling.RoundtripKind;
					for (;;)
					{
						this._dateParseHandling = DateParseHandling.DateTime;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0047;
						}
						IL_0062:
						switch (num)
						{
						case 0:
							goto IL_0047;
						case 1:
							return;
						case 2:
							goto IL_00AA;
						case 3:
							goto IL_002C;
						case 4:
							break;
						case 5:
							continue;
						case 6:
							goto IL_00A1;
						default:
							goto IL_0047;
						}
						IL_000D:
						this.nullable_0 = new int?(64);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto IL_0062;
						}
						IL_002C:
						this.CloseInput = true;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
						{
							return;
						}
						goto IL_0062;
						IL_0047:
						this._floatParseHandling = FloatParseHandling.Double;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
						{
							goto IL_000D;
						}
						goto IL_0062;
					}
				}
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00029B40 File Offset: 0x00027D40
		private void method_0(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				IL_0120:
				this.method_4();
				while (this.jsonPosition_0.Type != JsonContainerType.None)
				{
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_00B4;
					}
					IL_00C9:
					switch (num)
					{
					case 1:
						goto IL_0080;
					case 2:
						goto IL_009E;
					case 4:
						goto IL_012B;
					case 5:
						goto IL_013B;
					case 6:
						goto IL_0134;
					case 7:
						goto IL_00BC;
					case 8:
						continue;
					case 9:
						goto IL_0120;
					case 10:
						IL_00B4:
						if (this.list_0 == null)
						{
							goto IL_00BC;
						}
						goto IL_005D;
					case 11:
						goto IL_005D;
					case 12:
						goto IL_016C;
					case 13:
						goto IL_0020;
					case 14:
						return;
					}
					goto Block_5;
					IL_0020:
					int num2 = this.Depth + 1;
					int? num3 = this.nullable_0;
					if ((num2 > num3.GetValueOrDefault()) & (num3 != null))
					{
						goto IL_012B;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto Block_3;
					}
					goto IL_00C9;
					IL_009E:
					if (this.nullable_0 != null)
					{
						goto IL_0020;
					}
					return;
					IL_005D:
					this.list_0.Add(this.jsonPosition_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0080;
					}
					goto IL_00C9;
					IL_00BC:
					this.list_0 = new List<JsonPosition>();
					goto IL_005D;
					IL_0080:
					this.jsonPosition_0 = new JsonPosition(jsonContainerType_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_009E;
					}
					goto IL_00C9;
				}
				goto IL_016C;
			}
			Block_3:
			Block_5:
			return;
			IL_012B:
			if (!this.bool_0)
			{
				goto IL_0134;
			}
			return;
			IL_0134:
			this.bool_0 = true;
			IL_013B:
			throw JsonReaderException.Create(this, Class15.smethod_17(1953692095 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, this.nullable_0));
			IL_016C:
			this.jsonPosition_0 = new JsonPosition(jsonContainerType_0);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00029CC8 File Offset: 0x00027EC8
		private JsonContainerType method_1()
		{
			JsonPosition jsonPosition;
			for (;;)
			{
				if (this.list_0 == null)
				{
					goto IL_0112;
				}
				goto IL_011C;
				IL_006A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_0020;
				case 1:
					goto IL_00CC;
				case 2:
				case 4:
					goto IL_00F4;
				case 3:
					goto IL_003E;
				case 5:
				case 9:
					goto IL_0112;
				case 6:
					goto IL_00B1;
				case 7:
					goto IL_0104;
				case 8:
				case 11:
				case 14:
					goto IL_013C;
				case 10:
					continue;
				case 12:
					break;
				case 13:
					IL_011C:
					if (this.list_0.Count <= 0)
					{
						goto IL_0112;
					}
					break;
				default:
					goto IL_0020;
				}
				jsonPosition = this.jsonPosition_0;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0020;
				}
				goto IL_006A;
				IL_003E:
				this.list_0.RemoveAt(this.list_0.Count - 1);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					goto IL_006A;
				}
				goto IL_00F4;
				IL_0020:
				this.jsonPosition_0 = this.list_0[this.list_0.Count - 1];
				goto IL_003E;
				IL_00B1:
				this.bool_0 = false;
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					break;
				}
				goto IL_006A;
				IL_00CC:
				int depth = this.Depth;
				int? num2 = this.nullable_0;
				if (!((depth <= num2.GetValueOrDefault()) & (num2 != null)))
				{
					break;
				}
				goto IL_00B1;
				IL_00F4:
				if (this.nullable_0 == null)
				{
					break;
				}
				goto IL_00CC;
				IL_0104:
				this.jsonPosition_0 = default(JsonPosition);
				goto IL_00F4;
				IL_0112:
				jsonPosition = this.jsonPosition_0;
				goto IL_0104;
			}
			IL_013C:
			return jsonPosition.Type;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002D9C File Offset: 0x00000F9C
		private JsonContainerType method_2()
		{
			return this.jsonPosition_0.Type;
		}

		// Token: 0x06000323 RID: 803
		public abstract bool Read();

		// Token: 0x06000324 RID: 804 RVA: 0x00029E18 File Offset: 0x00028018
		public virtual int? vmethod_0()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken != JsonToken.None)
			{
				switch (jsonToken)
				{
				case JsonToken.Integer:
				case JsonToken.Float:
				{
					object value = this.Value;
					int num;
					if (value is int)
					{
						num = (int)value;
						return new int?(num);
					}
					if (value is BigInteger)
					{
						BigInteger bigInteger = (BigInteger)value;
						num = (int)bigInteger;
					}
					else
					{
						try
						{
							num = Convert.ToInt32(value, CultureInfo.InvariantCulture);
						}
						catch (Exception ex)
						{
							throw JsonReaderException.Create(this, Class15.smethod_17(926370121 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296).FormatWith(CultureInfo.InvariantCulture, value), ex);
						}
					}
					this.SetToken(JsonToken.Integer, num, false);
					return new int?(num);
				}
				case JsonToken.String:
				{
					string text = (string)this.Value;
					return this.ReadInt32String(text);
				}
				case JsonToken.Null:
				case JsonToken.EndArray:
					goto IL_0101;
				}
				throw JsonReaderException.Create(this, Class15.smethod_17(1953691925 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			}
			IL_0101:
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00029F40 File Offset: 0x00028140
		internal int? ReadInt32String(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			int num;
			if (!int.TryParse(s, NumberStyles.Integer, this.Culture, out num))
			{
				this.SetToken(JsonToken.String, s, false);
				throw JsonReaderException.Create(this, Class15.smethod_17(698996896 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, s));
			}
			this.SetToken(JsonToken.Integer, num, false);
			return new int?(num);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00029FC0 File Offset: 0x000281C0
		public virtual string ReadAsString()
		{
			JsonToken jsonToken;
			string text;
			object value;
			IFormattable formattable;
			for (;;)
			{
				IL_015B:
				jsonToken = this.method_8();
				for (;;)
				{
					IL_014E:
					if (jsonToken > JsonToken.String)
					{
						goto IL_0125;
					}
					int num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						goto IL_0061;
					}
					for (;;)
					{
						IL_00BE:
						switch (num)
						{
						case 1:
						case 9:
							goto IL_01E1;
						case 2:
						case 17:
							goto IL_0174;
						case 3:
							goto IL_014E;
						case 4:
							goto IL_015B;
						case 5:
						case 21:
							goto IL_01D3;
						case 6:
							goto IL_01C3;
						case 7:
							goto IL_00B2;
						case 8:
							return text;
						case 10:
							goto IL_0029;
						case 11:
							goto IL_0088;
						case 12:
							goto IL_0125;
						case 13:
							goto IL_01AB;
						case 14:
							if (jsonToken != JsonToken.None)
							{
								goto IL_00B2;
							}
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
							{
								goto Block_9;
							}
							continue;
						case 15:
						case 16:
							goto IL_01A2;
						case 18:
							if (jsonToken != JsonToken.EndArray)
							{
								goto IL_0088;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
							{
								goto Block_6;
							}
							continue;
						case 19:
							goto IL_01AF;
						case 20:
							goto IL_0047;
						case 22:
							goto IL_0020;
						}
						break;
						IL_0047:
						value = this.Value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							break;
						}
						continue;
						IL_0088:
						if (!JsonTokenUtils.IsPrimitiveToken(jsonToken))
						{
							goto Block_7;
						}
						goto IL_0047;
						IL_00B2:
						if (jsonToken != JsonToken.String)
						{
							goto IL_0088;
						}
						goto IL_0165;
					}
					goto IL_0061;
					IL_0029:
					if (formattable != null)
					{
						goto IL_01C3;
					}
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto Block_3;
					}
					goto IL_00BE;
					IL_0020:
					formattable = value as IFormattable;
					goto IL_0029;
					IL_0061:
					if (value == null)
					{
						goto Block_4;
					}
					goto IL_0020;
					IL_0125:
					if (jsonToken == JsonToken.Null)
					{
						goto IL_01E1;
					}
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						break;
					}
					goto IL_00BE;
				}
				Block_9:;
			}
			Block_3:
			goto IL_01A2;
			Block_4:
			goto IL_0174;
			Block_6:
			goto IL_01E1;
			Block_7:
			goto IL_0174;
			IL_0165:
			return (string)this.Value;
			IL_0174:
			throw JsonReaderException.Create(this, Class15.smethod_17(768777136 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			IL_01A2:
			Uri uri = value as Uri;
			IL_01AB:
			string text2;
			if (uri != null)
			{
				text2 = uri.OriginalString;
				goto IL_01BF;
			}
			IL_01AF:
			text2 = value.ToString();
			IL_01BF:
			text = text2;
			goto IL_01D3;
			IL_01C3:
			text = formattable.ToString(null, this.Culture);
			IL_01D3:
			this.SetToken(JsonToken.String, text, false);
			return text;
			IL_01E1:
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0002A1B0 File Offset: 0x000283B0
		public virtual byte[] ReadAsBytes()
		{
			JsonToken jsonToken;
			byte[] array;
			byte[] array2;
			byte[] array3;
			for (;;)
			{
				IL_01DF:
				jsonToken = this.method_8();
				int num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
				{
					goto Block_11;
				}
				for (;;)
				{
					string text;
					switch (num)
					{
					case 1:
						return array;
					case 2:
						return array2;
					case 3:
						goto IL_0095;
					case 4:
						goto IL_00B8;
					case 5:
						goto IL_0298;
					case 6:
					case 7:
						goto IL_0248;
					case 8:
						goto IL_0147;
					case 9:
						goto IL_0286;
					case 10:
						goto IL_00B2;
					case 11:
					case 15:
					case 28:
						goto IL_0006;
					case 12:
						goto IL_0130;
					case 13:
						goto IL_005C;
					case 14:
						goto IL_027D;
					case 16:
						goto IL_0155;
					case 17:
						goto IL_00FE;
					case 18:
						goto IL_013C;
					case 19:
						goto IL_028F;
					case 20:
						goto IL_008F;
					case 21:
						goto IL_0107;
					case 22:
						return array3;
					case 23:
						goto IL_0034;
					case 24:
						goto IL_0205;
					case 25:
						if (text.Length == 0)
						{
							goto IL_0130;
						}
						goto IL_013C;
					case 26:
						if (jsonToken <= JsonToken.String)
						{
							goto IL_0034;
						}
						goto IL_00FE;
					case 27:
						goto IL_01DF;
					}
					goto Block_10;
					IL_0006:
					this.SetToken(JsonToken.Bytes, array, false);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_1;
					}
					continue;
					IL_0130:
					array = CollectionUtils.ArrayEmpty<byte>();
					goto IL_0006;
					IL_0034:
					switch (jsonToken)
					{
					case JsonToken.None:
						goto IL_02B2;
					case JsonToken.StartObject:
						IL_008F:
						this.ReadIntoWrappedTypeObject();
						goto IL_0095;
					case JsonToken.StartArray:
						goto IL_023A;
					default:
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
						{
							continue;
						}
						break;
					}
					IL_005C:
					if (jsonToken != JsonToken.String)
					{
						goto Block_3;
					}
					text = (string)this.Value;
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto Block_4;
					}
					continue;
					IL_0095:
					array3 = this.ReadAsBytes();
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_00B2;
					}
					continue;
					IL_00B8:
					if (this.TokenType != JsonToken.EndObject)
					{
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
						{
							goto Block_6;
						}
						continue;
					}
					else
					{
						this.SetToken(JsonToken.Bytes, array3, false);
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto Block_7;
						}
						continue;
					}
					IL_00B2:
					this.ReaderReadAndAssert();
					goto IL_00B8;
					IL_0107:
					if (jsonToken == JsonToken.EndArray)
					{
						goto IL_02B2;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto Block_9;
					}
					continue;
					IL_00FE:
					if (jsonToken != JsonToken.Null)
					{
						goto IL_0107;
					}
					goto IL_02B2;
					IL_0147:
					Guid guid;
					array = guid.ToByteArray();
					goto IL_0006;
					IL_013C:
					if (ConvertUtils.TryConvertGuid(text, out guid))
					{
						goto IL_0147;
					}
					IL_0155:
					array = Convert.FromBase64String(text);
					goto IL_0006;
				}
			}
			Block_1:
			return array;
			Block_3:
			goto IL_0248;
			Block_4:
			return array2;
			Block_6:
			goto IL_0205;
			Block_7:
			return array3;
			Block_9:
			Block_10:
			goto IL_0242;
			Block_11:
			IL_0205:
			throw JsonReaderException.Create(this, Class15.smethod_17(635804525 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, this.TokenType));
			IL_023A:
			return this.ReadArrayIntoByteArray();
			IL_0242:
			object value;
			if (jsonToken == JsonToken.Bytes)
			{
				value = this.Value;
				goto IL_027D;
			}
			IL_0248:
			throw JsonReaderException.Create(this, Class15.smethod_17(2048531351 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			IL_027D:
			if (!(value is Guid))
			{
				return (byte[])this.Value;
			}
			IL_0286:
			Guid guid2 = (Guid)value;
			IL_028F:
			array2 = guid2.ToByteArray();
			IL_0298:
			this.SetToken(JsonToken.Bytes, array2, false);
			return array2;
			IL_02B2:
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0002A474 File Offset: 0x00028674
		[NullableContext(1)]
		internal byte[] ReadArrayIntoByteArray()
		{
			byte[] array;
			for (;;)
			{
				List<byte> list = new List<byte>();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_004B;
				}
				IL_0072:
				switch (num)
				{
				case 0:
					goto IL_004B;
				case 1:
					return array;
				case 2:
					goto IL_0055;
				case 3:
					goto IL_0043;
				case 4:
					continue;
				case 5:
					goto IL_0028;
				case 6:
					break;
				default:
					goto IL_004B;
				}
				IL_0006:
				this.SetToken(JsonToken.Bytes, array, false);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					break;
				}
				goto IL_0072;
				IL_0028:
				this.SetToken(JsonToken.None);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_004B;
				}
				goto IL_0072;
				IL_0043:
				if (!this.Read())
				{
					goto IL_0028;
				}
				IL_004B:
				if (!this.method_3(list))
				{
					goto IL_0043;
				}
				IL_0055:
				array = list.ToArray();
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0006;
				}
				goto IL_0072;
			}
			return array;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0002A538 File Offset: 0x00028738
		[NullableContext(1)]
		private bool method_3(List<byte> list_1)
		{
			JsonToken tokenType = this.TokenType;
			if (tokenType <= JsonToken.Comment)
			{
				if (tokenType == JsonToken.None)
				{
					throw JsonReaderException.Create(this, Class15.smethod_17(1807882960 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
				}
				if (tokenType == JsonToken.Comment)
				{
					return false;
				}
			}
			else
			{
				if (tokenType == JsonToken.Integer)
				{
					list_1.Add(Convert.ToByte(this.Value, CultureInfo.InvariantCulture));
					return false;
				}
				if (tokenType == JsonToken.EndArray)
				{
					return true;
				}
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(277632632 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98).FormatWith(CultureInfo.InvariantCulture, this.TokenType));
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0002A5CC File Offset: 0x000287CC
		public virtual double? ReadAsDouble()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken != JsonToken.None)
			{
				switch (jsonToken)
				{
				case JsonToken.Integer:
				case JsonToken.Float:
				{
					object value = this.Value;
					double num;
					if (value is double)
					{
						num = (double)value;
						return new double?(num);
					}
					if (value is BigInteger)
					{
						BigInteger bigInteger = (BigInteger)value;
						num = (double)bigInteger;
					}
					else
					{
						num = Convert.ToDouble(value, CultureInfo.InvariantCulture);
					}
					this.SetToken(JsonToken.Float, num, false);
					return new double?(num);
				}
				case JsonToken.String:
					return this.ReadDoubleString((string)this.Value);
				case JsonToken.Null:
				case JsonToken.EndArray:
					goto IL_00CE;
				}
				throw JsonReaderException.Create(this, Class15.smethod_17(552184526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			}
			IL_00CE:
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0002A6B4 File Offset: 0x000288B4
		internal double? ReadDoubleString(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			double num;
			if (!double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, this.Culture, out num))
			{
				this.SetToken(JsonToken.String, s, false);
				throw JsonReaderException.Create(this, Class15.smethod_17(1176464840 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, s));
			}
			this.SetToken(JsonToken.Float, num, false);
			return new double?(num);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0002A738 File Offset: 0x00028938
		public virtual bool? ReadAsBoolean()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken != JsonToken.None)
			{
				switch (jsonToken)
				{
				case JsonToken.Integer:
				case JsonToken.Float:
				{
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
					this.SetToken(JsonToken.Boolean, flag, false);
					return new bool?(flag);
				}
				case JsonToken.String:
					return this.ReadBooleanString((string)this.Value);
				case JsonToken.Boolean:
					return new bool?((bool)this.Value);
				case JsonToken.Null:
				case JsonToken.EndArray:
					goto IL_00D9;
				}
				throw JsonReaderException.Create(this, Class15.smethod_17(1788746619 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			}
			IL_00D9:
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0002A828 File Offset: 0x00028A28
		internal bool? ReadBooleanString(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			bool flag;
			if (!bool.TryParse(s, out flag))
			{
				this.SetToken(JsonToken.String, s, false);
				throw JsonReaderException.Create(this, Class15.smethod_17(676707454 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, s));
			}
			this.SetToken(JsonToken.Boolean, flag, false);
			return new bool?(flag);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		public virtual decimal? ReadAsDecimal()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken != JsonToken.None)
			{
				switch (jsonToken)
				{
				case JsonToken.Integer:
				case JsonToken.Float:
				{
					object value = this.Value;
					decimal num;
					if (value is decimal)
					{
						num = (decimal)value;
						return new decimal?(num);
					}
					if (value is BigInteger)
					{
						BigInteger bigInteger = (BigInteger)value;
						num = (decimal)bigInteger;
					}
					else
					{
						try
						{
							num = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
						}
						catch (Exception ex)
						{
							throw JsonReaderException.Create(this, Class15.smethod_17(432118901 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, value), ex);
						}
					}
					this.SetToken(JsonToken.Float, num, false);
					return new decimal?(num);
				}
				case JsonToken.String:
					return this.ReadDecimalString((string)this.Value);
				case JsonToken.Null:
				case JsonToken.EndArray:
					goto IL_00FD;
				}
				throw JsonReaderException.Create(this, Class15.smethod_17(1829617161 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			}
			IL_00FD:
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0002A9C8 File Offset: 0x00028BC8
		internal decimal? ReadDecimalString(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			decimal num;
			if (decimal.TryParse(s, NumberStyles.Number, this.Culture, out num))
			{
				this.SetToken(JsonToken.Float, num, false);
				return new decimal?(num);
			}
			if (ConvertUtils.DecimalTryParse(s.ToCharArray(), 0, s.Length, out num) == ParseResult.Success)
			{
				this.SetToken(JsonToken.Float, num, false);
				return new decimal?(num);
			}
			this.SetToken(JsonToken.String, s, false);
			throw JsonReaderException.Create(this, Class15.smethod_17(1270973904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112).FormatWith(CultureInfo.InvariantCulture, s));
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0002AA78 File Offset: 0x00028C78
		public virtual DateTime? ReadAsDateTime()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken <= JsonToken.String)
			{
				if (jsonToken == JsonToken.None)
				{
					goto IL_00A8;
				}
				if (jsonToken == JsonToken.String)
				{
					return this.ReadDateTimeString((string)this.Value);
				}
			}
			else
			{
				if (jsonToken == JsonToken.Null || jsonToken == JsonToken.EndArray)
				{
					goto IL_00A8;
				}
				if (jsonToken == JsonToken.Date)
				{
					object value = this.Value;
					if (value is DateTimeOffset)
					{
						this.SetToken(JsonToken.Date, ((DateTimeOffset)value).DateTime, false);
					}
					return new DateTime?((DateTime)this.Value);
				}
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(2060599430 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, this.TokenType));
			IL_00A8:
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0002AB38 File Offset: 0x00028D38
		internal DateTime? ReadDateTimeString(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			DateTime dateTime;
			if (DateTimeUtils.TryParseDateTime(s, this.DateTimeZoneHandling, this.string_0, this.Culture, out dateTime))
			{
				dateTime = DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
				this.SetToken(JsonToken.Date, dateTime, false);
				return new DateTime?(dateTime);
			}
			if (!DateTime.TryParse(s, this.Culture, DateTimeStyles.RoundtripKind, out dateTime))
			{
				throw JsonReaderException.Create(this, Class15.smethod_17(1570988793 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, s));
			}
			dateTime = DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
			this.SetToken(JsonToken.Date, dateTime, false);
			return new DateTime?(dateTime);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0002AC00 File Offset: 0x00028E00
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			JsonToken jsonToken = this.method_8();
			if (jsonToken <= JsonToken.String)
			{
				if (jsonToken == JsonToken.None)
				{
					goto IL_00A7;
				}
				if (jsonToken == JsonToken.String)
				{
					string text = (string)this.Value;
					return this.ReadDateTimeOffsetString(text);
				}
			}
			else
			{
				if (jsonToken == JsonToken.Null || jsonToken == JsonToken.EndArray)
				{
					goto IL_00A7;
				}
				if (jsonToken == JsonToken.Date)
				{
					object value = this.Value;
					if (value is DateTime)
					{
						DateTime dateTime = (DateTime)value;
						this.SetToken(JsonToken.Date, new DateTimeOffset(dateTime), false);
					}
					return new DateTimeOffset?((DateTimeOffset)this.Value);
				}
			}
			throw JsonReaderException.Create(this, Class15.smethod_17(594372008 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, jsonToken));
			IL_00A7:
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			if (StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(JsonToken.Null, null, false);
				return null;
			}
			DateTimeOffset dateTimeOffset;
			if (DateTimeUtils.TryParseDateTimeOffset(s, this.string_0, this.Culture, out dateTimeOffset))
			{
				this.SetToken(JsonToken.Date, dateTimeOffset, false);
				return new DateTimeOffset?(dateTimeOffset);
			}
			if (!DateTimeOffset.TryParse(s, this.Culture, DateTimeStyles.RoundtripKind, out dateTimeOffset))
			{
				this.SetToken(JsonToken.String, s, false);
				throw JsonReaderException.Create(this, Class15.smethod_17(613111619 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, s));
			}
			this.SetToken(JsonToken.Date, dateTimeOffset, false);
			return new DateTimeOffset?(dateTimeOffset);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0002AD70 File Offset: 0x00028F70
		internal void ReaderReadAndAssert()
		{
			while (!this.Read())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw this.CreateUnexpectedEndException();
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002DA9 File Offset: 0x00000FA9
		[NullableContext(1)]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return JsonReaderException.Create(this, Class15.smethod_17(486536460 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0002ADB4 File Offset: 0x00028FB4
		internal void ReadIntoWrappedTypeObject()
		{
			for (;;)
			{
				this.ReaderReadAndAssert();
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0081;
				}
				IL_008C:
				switch (num)
				{
				case 1:
					goto IL_0054;
				case 2:
				case 6:
				case 7:
					goto IL_010B;
				case 3:
					goto IL_0017;
				case 4:
					goto IL_000C;
				case 5:
					goto IL_00E4;
				case 8:
					IL_0081:
					if (this.Value == null)
					{
						goto Block_3;
					}
					goto IL_0054;
				case 9:
					continue;
				case 10:
					goto IL_0006;
				case 11:
					return;
				}
				goto Block_4;
				IL_0017:
				if (this.Value.ToString().StartsWith(Class15.smethod_17(299942307 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), StringComparison.Ordinal))
				{
					goto IL_00DE;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_0054;
				}
				goto IL_008C;
				IL_000C:
				if (this.Value != null)
				{
					goto IL_0017;
				}
				break;
				IL_0006:
				this.ReaderReadAndAssert();
				goto IL_000C;
				IL_0054:
				if (this.Value.ToString() == Class15.smethod_17(635805603 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2))
				{
					goto IL_0006;
				}
				break;
			}
			Block_3:
			goto IL_010B;
			Block_4:
			IL_00DE:
			this.ReaderReadAndAssert();
			IL_00E4:
			if (this.Value.ToString() == Class15.smethod_17(768777454 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7))
			{
				return;
			}
			IL_010B:
			throw JsonReaderException.Create(this, Class15.smethod_17(2021167018 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, JsonToken.StartObject));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0002AEF8 File Offset: 0x000290F8
		public void Skip()
		{
			for (;;)
			{
				if (this.TokenType != JsonToken.PropertyName)
				{
					goto IL_0078;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					goto IL_0018;
				}
				IL_0030:
				switch (num)
				{
				case 0:
					goto IL_0018;
				case 1:
					continue;
				case 2:
				case 7:
					return;
				case 3:
					goto IL_006D;
				case 4:
					goto IL_0062;
				case 5:
					break;
				case 6:
					goto IL_0078;
				default:
					goto IL_0018;
				}
				IL_0058:
				int depth;
				if (depth < this.Depth)
				{
					goto IL_0062;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_0030;
				}
				IL_0018:
				this.Read();
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_0030;
				}
				goto IL_0078;
				IL_0062:
				if (!this.Read())
				{
					break;
				}
				goto IL_0058;
				IL_006D:
				depth = this.Depth;
				goto IL_0062;
				IL_0078:
				if (JsonTokenUtils.IsStartToken(this.TokenType))
				{
					goto IL_006D;
				}
				break;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0002AFB0 File Offset: 0x000291B0
		protected void SetToken(JsonToken newToken)
		{
			for (;;)
			{
				this.SetToken(newToken, null, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
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

		// Token: 0x06000339 RID: 825 RVA: 0x0002AFEC File Offset: 0x000291EC
		protected void SetToken(JsonToken newToken, object value)
		{
			for (;;)
			{
				this.SetToken(newToken, value, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
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

		// Token: 0x0600033A RID: 826 RVA: 0x0002B028 File Offset: 0x00029228
		protected void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
			for (;;)
			{
				IL_01DC:
				this.jsonToken_0 = newToken;
				for (;;)
				{
					IL_01D2:
					this.object_0 = value;
					for (;;)
					{
						IL_0183:
						int num;
						switch (newToken)
						{
						case JsonToken.StartObject:
							this._currentState = JsonReader.State.ObjectStart;
							num = 13;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								goto Block_9;
							}
							break;
						case JsonToken.StartArray:
							this._currentState = JsonReader.State.ArrayStart;
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
							{
								goto IL_0043;
							}
							break;
						case JsonToken.StartConstructor:
							this._currentState = JsonReader.State.ConstructorStart;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
							{
								goto IL_0043;
							}
							break;
						case JsonToken.PropertyName:
							this._currentState = JsonReader.State.Property;
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
							{
								goto Block_6;
							}
							break;
						case JsonToken.Comment:
							return;
						case JsonToken.Raw:
						case JsonToken.Integer:
						case JsonToken.Float:
						case JsonToken.String:
						case JsonToken.Boolean:
						case JsonToken.Null:
						case JsonToken.Undefined:
						case JsonToken.Date:
						case JsonToken.Bytes:
							goto IL_021A;
						case JsonToken.EndObject:
							this.method_5(JsonToken.EndObject);
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								goto Block_5;
							}
							break;
						case JsonToken.EndArray:
							this.method_5(JsonToken.EndArray);
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
							{
								goto Block_4;
							}
							break;
						case JsonToken.EndConstructor:
							this.method_5(JsonToken.EndConstructor);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
							{
								goto Block_1;
							}
							break;
						default:
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								goto Block_10;
							}
							break;
						}
						for (;;)
						{
							IL_005E:
							switch (num)
							{
							case 1:
								goto IL_0043;
							case 2:
								this.method_0(JsonContainerType.Array);
								num = 5;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
								{
									goto Block_2;
								}
								continue;
							case 3:
								goto IL_01F9;
							case 4:
								return;
							case 5:
								return;
							case 6:
								return;
							case 7:
								return;
							case 8:
								goto IL_01D2;
							case 9:
								goto IL_01DC;
							case 10:
								goto IL_0183;
							case 11:
								return;
							case 12:
								return;
							case 13:
								goto IL_0210;
							case 14:
								return;
							case 15:
								return;
							}
							goto Block_3;
						}
						IL_0043:
						this.method_0(JsonContainerType.Constructor);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
						{
							goto IL_005E;
						}
						goto IL_01F3;
					}
				}
				Block_5:;
			}
			Block_1:
			return;
			Block_2:
			return;
			Block_3:
			return;
			Block_4:
			return;
			Block_6:
			goto IL_01F9;
			Block_9:
			goto IL_0210;
			Block_10:
			return;
			IL_01F3:
			return;
			IL_01F9:
			this.jsonPosition_0.PropertyName = (string)value;
			return;
			IL_0210:
			this.method_0(JsonContainerType.Object);
			return;
			IL_021A:
			this.SetPostValueState(updateIndex);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0002B258 File Offset: 0x00029458
		internal void SetPostValueState(bool updateIndex)
		{
			for (;;)
			{
				if (this.method_2() == JsonContainerType.None)
				{
					goto IL_006A;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_004E;
				}
				IL_001D:
				switch (num)
				{
				default:
					goto IL_004E;
				case 1:
					continue;
				case 2:
					goto IL_0098;
				case 3:
				case 8:
					goto IL_0095;
				case 4:
					goto IL_006A;
				case 5:
				case 9:
					break;
				case 7:
				case 10:
					return;
				}
				IL_0006:
				this.method_6();
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_001D;
				}
				goto IL_006A;
				IL_004E:
				this._currentState = JsonReader.State.PostValue;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					break;
				}
				goto IL_001D;
				IL_006A:
				if (!this.SupportMultipleContent)
				{
					goto IL_0006;
				}
				goto IL_004E;
			}
			IL_0095:
			if (!updateIndex)
			{
				return;
			}
			IL_0098:
			this.method_4();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0002B304 File Offset: 0x00029504
		private void method_4()
		{
			for (;;)
			{
				if (this.jsonPosition_0.HasIndex)
				{
					goto IL_0003;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					goto IL_0003;
				}
				IL_0024:
				switch (num)
				{
				case 1:
				case 3:
					return;
				case 2:
					continue;
				}
				IL_0003:
				this.jsonPosition_0.Position = this.jsonPosition_0.Position + 1;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0024;
				}
				break;
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0002B374 File Offset: 0x00029574
		private void method_5(JsonToken jsonToken_1)
		{
			JsonContainerType jsonContainerType;
			for (;;)
			{
				IL_0087:
				jsonContainerType = this.method_1();
				while (this.method_7(jsonToken_1) == jsonContainerType)
				{
					if (this.method_2() != JsonContainerType.None)
					{
						goto IL_005E;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_0020;
					}
					IL_0039:
					switch (num)
					{
					case 1:
						IL_0020:
						if (!this.SupportMultipleContent)
						{
							goto IL_0094;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
						{
							goto IL_0039;
						}
						break;
					case 2:
						goto IL_009C;
					case 3:
						return;
					case 4:
						continue;
					case 5:
						goto IL_0087;
					case 6:
						return;
					}
					IL_005E:
					this._currentState = JsonReader.State.PostValue;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						break;
					}
					goto IL_0039;
				}
				break;
			}
			goto IL_009C;
			IL_0094:
			this.method_6();
			return;
			IL_009C:
			throw JsonReaderException.Create(this, Class15.smethod_17(2128218120 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).FormatWith(CultureInfo.InvariantCulture, jsonToken_1, jsonContainerType));
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002B454 File Offset: 0x00029654
		protected void SetStateBasedOnCurrent()
		{
			JsonContainerType jsonContainerType;
			for (;;)
			{
				jsonContainerType = this.method_2();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_0003;
				}
				IL_0046:
				switch (num)
				{
				case 1:
					goto IL_008E;
				case 2:
					return;
				case 3:
					goto IL_002E;
				case 4:
					return;
				case 5:
					IL_0003:
					switch (jsonContainerType)
					{
					case JsonContainerType.None:
						goto IL_00BB;
					case JsonContainerType.Object:
						goto IL_002E;
					case JsonContainerType.Array:
						goto IL_00C5;
					case JsonContainerType.Constructor:
						goto IL_00CD;
					default:
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
						{
							goto Block_2;
						}
						goto IL_0046;
					}
					break;
				case 6:
					continue;
				case 7:
					return;
				}
				goto Block_3;
				IL_002E:
				this._currentState = JsonReader.State.Object;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_0046;
				}
				return;
			}
			Block_2:
			goto IL_008E;
			Block_3:
			return;
			IL_008E:
			throw JsonReaderException.Create(this, Class15.smethod_17(1760301117 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039).FormatWith(CultureInfo.InvariantCulture, jsonContainerType));
			IL_00BB:
			this.method_6();
			return;
			IL_00C5:
			this._currentState = JsonReader.State.Array;
			return;
			IL_00CD:
			this._currentState = JsonReader.State.Constructor;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0002B538 File Offset: 0x00029738
		private void method_6()
		{
			for (;;)
			{
				this._currentState = (this.SupportMultipleContent ? JsonReader.State.Start : JsonReader.State.Finished);
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

		// Token: 0x06000340 RID: 832 RVA: 0x0002B57C File Offset: 0x0002977C
		private JsonContainerType method_7(JsonToken jsonToken_1)
		{
			for (;;)
			{
				switch (jsonToken_1)
				{
				case JsonToken.EndObject:
					return JsonContainerType.Object;
				case JsonToken.EndArray:
					return JsonContainerType.Array;
				case JsonToken.EndConstructor:
					return JsonContainerType.Constructor;
				default:
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return JsonContainerType.Object;
						}
						goto Block_2;
					}
					goto IL_0040;
				}
				}
			}
			Block_2:
			IL_0040:
			throw JsonReaderException.Create(this, Class15.smethod_17(197576067 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jsonToken_1));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0002B5FC File Offset: 0x000297FC
		void IDisposable.Dispose()
		{
			for (;;)
			{
				this.Dispose(true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
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
				GC.SuppressFinalize(this);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					goto IL_001A;
				}
				break;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0002B654 File Offset: 0x00029854
		protected virtual void Dispose(bool disposing)
		{
			while (this._currentState != JsonReader.State.Closed && disposing)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0015;
				}
				IL_002C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0015:
				this.Close();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_002C;
				}
				break;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0002B6B8 File Offset: 0x000298B8
		public virtual void Close()
		{
			for (;;)
			{
				this._currentState = JsonReader.State.Closed;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_004F;
				case 3:
					return;
				}
				IL_0003:
				this.jsonToken_0 = JsonToken.None;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_001B;
				}
			}
			IL_004F:
			this.object_0 = null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0002B71C File Offset: 0x0002991C
		internal void ReadAndAssert()
		{
			while (this.Read())
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0036;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0036;
					}
				}
				return;
			}
			IL_0036:
			throw JsonSerializationException.Create(this, Class15.smethod_17(299942167 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0002B77C File Offset: 0x0002997C
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
			while (!this.ReadForType(contract, hasConverter))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw JsonSerializationException.Create(this, Class15.smethod_17(1176463568 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0002B7D8 File Offset: 0x000299D8
		internal bool ReadForType(JsonContract contract, bool hasConverter)
		{
			ReadType readType;
			for (;;)
			{
				int num;
				if (hasConverter)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto Block_9;
					}
				}
				else
				{
					if (contract != null)
					{
						readType = contract.InternalReadType;
						goto IL_002B;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						break;
					}
				}
				IL_00F3:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_00BA;
				case 3:
					goto IL_002B;
				case 4:
				case 18:
					goto IL_01AD;
				case 5:
					goto IL_018B;
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 14:
				case 21:
					goto IL_020B;
				case 12:
					goto IL_0194;
				case 13:
					goto IL_0060;
				case 15:
					goto IL_009C;
				case 16:
					goto IL_01A5;
				case 17:
					goto IL_007E;
				case 19:
					goto IL_01B3;
				case 20:
					goto IL_01BA;
				}
				goto Block_8;
				IL_0060:
				this.ReadAsBoolean();
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto Block_4;
				}
				goto IL_00F3;
				IL_002B:
				switch (readType)
				{
				case ReadType.Read:
					goto IL_01B3;
				case ReadType.const_1:
					this.vmethod_0();
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_00F3;
					}
					goto IL_0176;
				case ReadType.const_2:
					goto IL_01BA;
				case ReadType.ReadAsBytes:
					goto IL_018B;
				case ReadType.ReadAsString:
					IL_009C:
					this.ReadAsString();
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto Block_6;
					}
					goto IL_00F3;
				case ReadType.ReadAsDecimal:
					goto IL_0179;
				case ReadType.ReadAsDateTime:
					goto IL_0194;
				case ReadType.ReadAsDateTimeOffset:
					IL_007E:
					this.ReadAsDateTimeOffset();
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto Block_5;
					}
					goto IL_00F3;
				case ReadType.ReadAsDouble:
					IL_00BA:
					this.ReadAsDouble();
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_002B;
					}
					goto IL_00F3;
				case ReadType.ReadAsBoolean:
					goto IL_0060;
				}
				goto Block_3;
			}
			goto IL_01A5;
			Block_3:
			goto IL_01AD;
			Block_4:
			Block_5:
			goto IL_020B;
			Block_6:
			Block_8:
			Block_9:
			goto IL_019E;
			IL_0176:
			goto IL_018B;
			IL_0179:
			this.ReadAsDecimal();
			goto IL_020B;
			IL_018B:
			this.ReadAsBytes();
			goto IL_020B;
			IL_0194:
			this.ReadAsDateTime();
			goto IL_020B;
			IL_019E:
			return this.Read();
			IL_01A5:
			readType = ReadType.Read;
			goto IL_01B3;
			IL_01AD:
			throw new ArgumentOutOfRangeException();
			IL_01B3:
			return this.ReadAndMoveToContent();
			IL_01BA:
			bool flag = this.ReadAndMoveToContent();
			if (this.TokenType == JsonToken.Undefined)
			{
				string text = Class15.smethod_17(1829610185 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae);
				IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
				Type type;
				if (contract != null)
				{
					if ((type = contract.UnderlyingType) != null)
					{
						goto IL_01FF;
					}
				}
				type = typeof(long);
				IL_01FF:
				throw JsonReaderException.Create(this, text.FormatWith(invariantCulture, type));
			}
			return flag;
			IL_020B:
			return this.TokenType > JsonToken.None;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0002B9FC File Offset: 0x00029BFC
		internal bool ReadAndMoveToContent()
		{
			while (this.Read())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this.MoveToContent();
			}
			return false;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0002BA44 File Offset: 0x00029C44
		internal bool MoveToContent()
		{
			for (;;)
			{
				IL_005F:
				JsonToken jsonToken = this.TokenType;
				for (;;)
				{
					IL_0058:
					if (jsonToken != JsonToken.None)
					{
						goto IL_004F;
					}
					IL_0044:
					while (this.Read())
					{
						jsonToken = this.TokenType;
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0058;
						}
						switch (num)
						{
						case 0:
							goto IL_004F;
						case 1:
						case 3:
							goto IL_0058;
						case 2:
							return false;
						case 4:
							goto IL_005F;
						case 5:
							return true;
						case 6:
						case 7:
							break;
						default:
							goto IL_004F;
						}
					}
					goto Block_3;
					IL_004F:
					if (jsonToken != JsonToken.Comment)
					{
						goto Block_4;
					}
					goto IL_0044;
				}
			}
			Block_3:
			return false;
			Block_4:
			return true;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		private JsonToken method_8()
		{
			JsonToken tokenType;
			for (;;)
			{
				if (this.Read())
				{
					tokenType = this.TokenType;
					goto IL_0058;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_003C;
				}
				do
				{
					IL_0021:
					this.SetToken(JsonToken.None);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0);
				IL_003C:
				switch (num)
				{
				case 0:
					goto IL_0021;
				case 1:
					break;
				case 2:
					return JsonToken.None;
				case 3:
					return tokenType;
				case 4:
					IL_0058:
					if (tokenType != JsonToken.Comment)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto Block_1;
						}
						goto IL_003C;
					}
					break;
				default:
					goto IL_0021;
				}
			}
			Block_1:
			return tokenType;
		}

		// Token: 0x04000216 RID: 534
		private JsonToken jsonToken_0;

		// Token: 0x04000217 RID: 535
		private object object_0;

		// Token: 0x04000218 RID: 536
		internal char _quoteChar;

		// Token: 0x04000219 RID: 537
		internal JsonReader.State _currentState;

		// Token: 0x0400021A RID: 538
		private JsonPosition jsonPosition_0;

		// Token: 0x0400021B RID: 539
		private CultureInfo cultureInfo_0;

		// Token: 0x0400021C RID: 540
		private DateTimeZoneHandling dateTimeZoneHandling_0;

		// Token: 0x0400021D RID: 541
		private int? nullable_0;

		// Token: 0x0400021E RID: 542
		private bool bool_0;

		// Token: 0x0400021F RID: 543
		internal DateParseHandling _dateParseHandling;

		// Token: 0x04000220 RID: 544
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x04000221 RID: 545
		private string string_0;

		// Token: 0x04000222 RID: 546
		private List<JsonPosition> list_0;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x02000061 RID: 97
		[NullableContext(0)]
		protected internal enum State
		{
			// Token: 0x04000227 RID: 551
			Start,
			// Token: 0x04000228 RID: 552
			Complete,
			// Token: 0x04000229 RID: 553
			Property,
			// Token: 0x0400022A RID: 554
			ObjectStart,
			// Token: 0x0400022B RID: 555
			Object,
			// Token: 0x0400022C RID: 556
			ArrayStart,
			// Token: 0x0400022D RID: 557
			Array,
			// Token: 0x0400022E RID: 558
			Closed,
			// Token: 0x0400022F RID: 559
			PostValue,
			// Token: 0x04000230 RID: 560
			ConstructorStart,
			// Token: 0x04000231 RID: 561
			Constructor,
			// Token: 0x04000232 RID: 562
			Error,
			// Token: 0x04000233 RID: 563
			Finished
		}
	}
}
