using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000110 RID: 272
	[Nullable(0)]
	[NullableContext(2)]
	public class JsonProperty
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00004E21 File Offset: 0x00003021
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0005ACFC File Offset: 0x00058EFC
		internal JsonContract PropertyContract
		{
			[CompilerGenerated]
			get
			{
				return this.jsonContract_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonContract_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00004E29 File Offset: 0x00003029
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0005AD34 File Offset: 0x00058F34
		public string PropertyName
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_0003;
					}
					IL_002D:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					IL_0003:
					this._skipPropertyNameEscape = !JavaScriptUtils.ShouldEscapeJavaScriptString(this.string_0, JavaScriptUtils.HtmlCharEscapeFlags);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_002D;
					}
					break;
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00004E31 File Offset: 0x00003031
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0005ADA0 File Offset: 0x00058FA0
		public Type DeclaringType
		{
			[CompilerGenerated]
			get
			{
				return this.type_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.type_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00004E39 File Offset: 0x00003039
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00004E41 File Offset: 0x00003041
		public int? Order { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00004E4A File Offset: 0x0000304A
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0005ADD8 File Offset: 0x00058FD8
		public string UnderlyingName
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00004E52 File Offset: 0x00003052
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0005AE10 File Offset: 0x00059010
		public IValueProvider ValueProvider
		{
			[CompilerGenerated]
			get
			{
				return this.ivalueProvider_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.ivalueProvider_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00004E5A File Offset: 0x0000305A
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0005AE48 File Offset: 0x00059048
		public GInterface0 AttributeProvider
		{
			[CompilerGenerated]
			get
			{
				return this.ginterface0_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.ginterface0_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00004E62 File Offset: 0x00003062
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0005AE80 File Offset: 0x00059080
		public Type PropertyType
		{
			get
			{
				return this.type_0;
			}
			set
			{
				IL_0053:
				while (this.type_0 != value)
				{
					for (;;)
					{
						this.type_0 = value;
						int num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto IL_0003;
						}
						IL_001B:
						switch (num)
						{
						case 1:
						case 2:
							return;
						case 3:
							goto IL_0053;
						case 4:
							IL_0003:
							this.bool_0 = false;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
							{
								goto IL_001B;
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00004E6A File Offset: 0x0000306A
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0005AEF0 File Offset: 0x000590F0
		public JsonConverter Converter
		{
			[CompilerGenerated]
			get
			{
				return this.jsonConverter_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonConverter_0 = value;
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
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00004E72 File Offset: 0x00003072
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0005AF28 File Offset: 0x00059128
		[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
		public JsonConverter MemberConverter
		{
			get
			{
				return this.Converter;
			}
			set
			{
				for (;;)
				{
					this.Converter = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00004E7A File Offset: 0x0000307A
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0005AF60 File Offset: 0x00059160
		public bool Ignored
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00004E82 File Offset: 0x00003082
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0005AF98 File Offset: 0x00059198
		public bool Readable
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00004E8A File Offset: 0x0000308A
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0005AFD0 File Offset: 0x000591D0
		public bool Writable
		{
			[CompilerGenerated]
			get
			{
				return this.bool_3;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_3 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
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

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00004E92 File Offset: 0x00003092
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0005B008 File Offset: 0x00059208
		public bool HasMemberAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.bool_4;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_4 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
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

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0005B040 File Offset: 0x00059240
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0005B08C File Offset: 0x0005928C
		public object DefaultValue
		{
			get
			{
				while (this._hasExplicitDefaultValue)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						break;
					}
					switch (num)
					{
					case 0:
						goto IL_003B;
					case 1:
						return this.object_0;
					case 2:
						break;
					default:
						goto IL_003B;
					}
				}
				IL_003B:
				return null;
			}
			set
			{
				for (;;)
				{
					IL_002F:
					this._hasExplicitDefaultValue = true;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.object_0 = value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_002F;
						}
						return;
					}
				}
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0005B0E4 File Offset: 0x000592E4
		internal object GetResolvedDefaultValue()
		{
			IL_009C:
			while (!(this.type_0 == null))
			{
				IL_0091:
				while (!this._hasExplicitDefaultValue)
				{
					for (;;)
					{
						if (!this.bool_0)
						{
							goto IL_004D;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							break;
						}
						IL_0021:
						switch (num)
						{
						case 1:
							goto IL_00B8;
						case 2:
							goto IL_0006;
						case 3:
							goto IL_0091;
						case 4:
							goto IL_009C;
						case 6:
							IL_004D:
							this.object_0 = ReflectionUtils.GetDefaultValue(this.type_0);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
							{
								goto IL_0006;
							}
							goto IL_0021;
						case 8:
							continue;
						}
						break;
						IL_0006:
						this.bool_0 = true;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							goto IL_0021;
						}
						break;
					}
					IL_00B1:
					return this.object_0;
				}
				goto IL_00B1;
			}
			IL_00B8:
			return null;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00004E9A File Offset: 0x0000309A
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0005B1AC File Offset: 0x000593AC
		public Required Required
		{
			get
			{
				return this._required.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._required = new Required?(value);
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
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00004EA7 File Offset: 0x000030A7
		public bool IsRequiredSpecified
		{
			get
			{
				return this._required != null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00004EB4 File Offset: 0x000030B4
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00004EBC File Offset: 0x000030BC
		public bool? IsReference { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00004EC5 File Offset: 0x000030C5
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00004ECD File Offset: 0x000030CD
		public NullValueHandling? NullValueHandling { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00004ED6 File Offset: 0x000030D6
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00004EDE File Offset: 0x000030DE
		public DefaultValueHandling? DefaultValueHandling { get; set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00004EE7 File Offset: 0x000030E7
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00004EEF File Offset: 0x000030EF
		public ReferenceLoopHandling? ReferenceLoopHandling { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00004EF8 File Offset: 0x000030F8
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00004F00 File Offset: 0x00003100
		public ObjectCreationHandling? ObjectCreationHandling { get; set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00004F09 File Offset: 0x00003109
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00004F11 File Offset: 0x00003111
		public TypeNameHandling? TypeNameHandling { get; set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00004F1A File Offset: 0x0000311A
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00004F22 File Offset: 0x00003122
		[Nullable(new byte[] { 2, 1 })]
		public Predicate<object> ShouldSerialize
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00004F2B File Offset: 0x0000312B
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00004F33 File Offset: 0x00003133
		[Nullable(new byte[] { 2, 1 })]
		public Predicate<object> ShouldDeserialize
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00004F3C File Offset: 0x0000313C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00004F44 File Offset: 0x00003144
		[Nullable(new byte[] { 2, 1 })]
		public Predicate<object> GetIsSpecified
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00004F4D File Offset: 0x0000314D
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00004F55 File Offset: 0x00003155
		[Nullable(new byte[] { 2, 1, 2 })]
		public Action<object, object> SetIsSpecified
		{
			[return: Nullable(new byte[] { 2, 1, 2 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 2 })]
			set;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0005B1E8 File Offset: 0x000593E8
		[NullableContext(1)]
		public override string ToString()
		{
			string text;
			while ((text = this.PropertyName) == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				text = string.Empty;
				break;
			}
			return text;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00004F5E File Offset: 0x0000315E
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0005B228 File Offset: 0x00059428
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			get
			{
				return this.jsonConverter_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonConverter_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00004F66 File Offset: 0x00003166
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00004F6E File Offset: 0x0000316E
		public bool? ItemIsReference { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00004F77 File Offset: 0x00003177
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00004F7F File Offset: 0x0000317F
		public TypeNameHandling? ItemTypeNameHandling { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00004F88 File Offset: 0x00003188
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00004F90 File Offset: 0x00003190
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		// Token: 0x06000AAE RID: 2734 RVA: 0x0005B260 File Offset: 0x00059460
		[NullableContext(1)]
		internal void WritePropertyName(JsonWriter writer)
		{
			string propertyName;
			for (;;)
			{
				propertyName = this.PropertyName;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					IL_0003:
					if (this._skipPropertyNameEscape)
					{
						goto IL_0063;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_001C;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0063;
				case 4:
					return;
				case 5:
					return;
				}
				break;
			}
			writer.WritePropertyName(propertyName);
			return;
			IL_0063:
			writer.WritePropertyName(propertyName, false);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0005B2DC File Offset: 0x000594DC
		public JsonProperty()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000562 RID: 1378
		internal Required? _required;

		// Token: 0x04000563 RID: 1379
		internal bool _hasExplicitDefaultValue;

		// Token: 0x04000564 RID: 1380
		private object object_0;

		// Token: 0x04000565 RID: 1381
		private bool bool_0;

		// Token: 0x04000566 RID: 1382
		private string string_0;

		// Token: 0x04000567 RID: 1383
		internal bool _skipPropertyNameEscape;

		// Token: 0x04000568 RID: 1384
		private Type type_0;

		// Token: 0x04000569 RID: 1385
		[CompilerGenerated]
		private JsonContract jsonContract_0;

		// Token: 0x0400056A RID: 1386
		[CompilerGenerated]
		private Type type_1;

		// Token: 0x0400056B RID: 1387
		[CompilerGenerated]
		private int? nullable_0;

		// Token: 0x0400056C RID: 1388
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400056D RID: 1389
		[CompilerGenerated]
		private IValueProvider ivalueProvider_0;

		// Token: 0x0400056E RID: 1390
		[CompilerGenerated]
		private GInterface0 ginterface0_0;

		// Token: 0x0400056F RID: 1391
		[CompilerGenerated]
		private JsonConverter jsonConverter_0;

		// Token: 0x04000570 RID: 1392
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000571 RID: 1393
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000572 RID: 1394
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x04000573 RID: 1395
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04000574 RID: 1396
		[CompilerGenerated]
		private bool? nullable_1;

		// Token: 0x04000575 RID: 1397
		[CompilerGenerated]
		private NullValueHandling? nullable_2;

		// Token: 0x04000576 RID: 1398
		[CompilerGenerated]
		private DefaultValueHandling? nullable_3;

		// Token: 0x04000577 RID: 1399
		[CompilerGenerated]
		private ReferenceLoopHandling? nullable_4;

		// Token: 0x04000578 RID: 1400
		[CompilerGenerated]
		private ObjectCreationHandling? nullable_5;

		// Token: 0x04000579 RID: 1401
		[CompilerGenerated]
		private TypeNameHandling? nullable_6;

		// Token: 0x0400057A RID: 1402
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private Predicate<object> predicate_0;

		// Token: 0x0400057B RID: 1403
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private Predicate<object> TchaKfKfEo;

		// Token: 0x0400057C RID: 1404
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private Predicate<object> predicate_1;

		// Token: 0x0400057D RID: 1405
		[Nullable(new byte[] { 2, 1, 2 })]
		[CompilerGenerated]
		private Action<object, object> action_0;

		// Token: 0x0400057E RID: 1406
		[CompilerGenerated]
		private JsonConverter jsonConverter_1;

		// Token: 0x0400057F RID: 1407
		[CompilerGenerated]
		private bool? nullable_7;

		// Token: 0x04000580 RID: 1408
		[CompilerGenerated]
		private TypeNameHandling? nullable_8;

		// Token: 0x04000581 RID: 1409
		[CompilerGenerated]
		private ReferenceLoopHandling? nullable_9;
	}
}
