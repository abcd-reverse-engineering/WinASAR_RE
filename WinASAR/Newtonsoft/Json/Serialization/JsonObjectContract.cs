using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010E RID: 270
	[Nullable(0)]
	[NullableContext(2)]
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00004D8B File Offset: 0x00002F8B
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0005A5D4 File Offset: 0x000587D4
		public MemberSerialization MemberSerialization
		{
			[CompilerGenerated]
			get
			{
				return this.memberSerialization_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.memberSerialization_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00004D93 File Offset: 0x00002F93
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00004D9B File Offset: 0x00002F9B
		public MissingMemberHandling? MissingMemberHandling { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00004DA4 File Offset: 0x00002FA4
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00004DAC File Offset: 0x00002FAC
		public Required? ItemRequired { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00004DB5 File Offset: 0x00002FB5
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00004DBD File Offset: 0x00002FBD
		public NullValueHandling? ItemNullValueHandling { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00004DC6 File Offset: 0x00002FC6
		[Nullable(1)]
		public JsonPropertyCollection Properties
		{
			[NullableContext(1)]
			get;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0005A60C File Offset: 0x0005880C
		[Nullable(1)]
		public JsonPropertyCollection CreatorParameters
		{
			[NullableContext(1)]
			get
			{
				while (this.jsonPropertyCollection_1 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_0015;
					}
					IL_0037:
					switch (num)
					{
					case 0:
						goto IL_0057;
					case 1:
						IL_0015:
						this.jsonPropertyCollection_1 = new JsonPropertyCollection(base.UnderlyingType);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto IL_0037;
						}
						goto IL_0057;
					case 2:
						break;
					default:
						goto IL_0057;
					}
				}
				IL_0057:
				return this.jsonPropertyCollection_1;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00004DCE File Offset: 0x00002FCE
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00004DD6 File Offset: 0x00002FD6
		[Nullable(new byte[] { 2, 1 })]
		public ObjectConstructor<object> OverrideCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.CuSanhevWn;
			}
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				this.CuSanhevWn = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00004DDF File Offset: 0x00002FDF
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00004DE7 File Offset: 0x00002FE7
		[Nullable(new byte[] { 2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.objectConstructor_0;
			}
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				this.objectConstructor_0 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00004DF0 File Offset: 0x00002FF0
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0005A678 File Offset: 0x00058878
		public ExtensionDataSetter ExtensionDataSetter
		{
			[CompilerGenerated]
			get
			{
				return this.extensionDataSetter_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.extensionDataSetter_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00004DF8 File Offset: 0x00002FF8
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0005A6B0 File Offset: 0x000588B0
		public ExtensionDataGetter ExtensionDataGetter
		{
			[CompilerGenerated]
			get
			{
				return this.extensionDataGetter_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.extensionDataGetter_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00004E00 File Offset: 0x00003000
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0005A6E8 File Offset: 0x000588E8
		public Type ExtensionDataValueType
		{
			get
			{
				return this.type_2;
			}
			set
			{
				for (;;)
				{
					IL_004A:
					this.type_2 = value;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.ExtensionDataIsJToken = value != null && typeof(JToken).IsAssignableFrom(value);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_004A;
						}
						return;
					}
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00004E08 File Offset: 0x00003008
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00004E10 File Offset: 0x00003010
		[Nullable(new byte[] { 2, 1, 1 })]
		public Func<string, string> ExtensionDataNameResolver
		{
			[return: Nullable(new byte[] { 2, 1, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 1 })]
			set;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0005A75C File Offset: 0x0005895C
		internal bool HasRequiredOrDefaultValueProperties
		{
			get
			{
				IL_00BF:
				while (this.nullable_6 == null)
				{
					for (;;)
					{
						IL_009C:
						this.nullable_6 = new bool?(false);
						int num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
						{
							goto IL_0006;
						}
						for (;;)
						{
							IL_0070:
							switch (num)
							{
							case 1:
							case 4:
								goto IL_0241;
							case 2:
								goto IL_002F;
							case 3:
								goto IL_000E;
							case 5:
								goto IL_009C;
							case 6:
								goto IL_00BF;
							case 7:
								this.nullable_6 = new bool?(true);
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
								{
									continue;
								}
								goto IL_00D2;
							case 8:
								goto IL_0006;
							}
							goto Block_4;
						}
						IL_000E:
						Required? itemRequired;
						if (itemRequired.GetValueOrDefault(Required.Default) == Required.Default)
						{
							goto IL_002F;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
						{
							break;
						}
						goto IL_0070;
						IL_0006:
						itemRequired = this.ItemRequired;
						goto IL_000E;
						IL_002F:
						IEnumerator<JsonProperty> enumerator = this.Properties.GetEnumerator();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto Block_3;
						}
						goto IL_0070;
					}
					break;
					Block_3:
					Block_4:
					goto IL_00DF;
					IL_00D2:
					break;
					IL_00DF:
					try
					{
						for (;;)
						{
							IEnumerator<JsonProperty> enumerator;
							if (enumerator.MoveNext())
							{
								goto IL_01C9;
							}
							int num2 = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
							{
								goto IL_01C9;
							}
							goto IL_015D;
							IL_00F5:
							DefaultValueHandling? defaultValueHandling;
							DefaultValueHandling defaultValueHandling2;
							if ((defaultValueHandling.GetValueOrDefault() == defaultValueHandling2) & (defaultValueHandling != null))
							{
								goto IL_010D;
							}
							continue;
							IL_00F2:
							defaultValueHandling2 = DefaultValueHandling.Populate;
							goto IL_00F5;
							IL_00F0:
							DefaultValueHandling? defaultValueHandling3;
							defaultValueHandling = defaultValueHandling3;
							goto IL_00F2;
							IL_00EE:
							DefaultValueHandling? defaultValueHandling4;
							defaultValueHandling3 = defaultValueHandling4;
							goto IL_00F0;
							IL_00E6:
							defaultValueHandling4 = null;
							goto IL_00EE;
							IL_0140:
							DefaultValueHandling? defaultValueHandling5;
							if (defaultValueHandling5 == null)
							{
								goto IL_00E6;
							}
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
							{
								goto IL_0130;
							}
							IL_015D:
							JsonProperty jsonProperty;
							switch (num2)
							{
							case 0:
								goto IL_0140;
							case 1:
								goto IL_01FA;
							case 2:
								IL_01C9:
								jsonProperty = enumerator.Current;
								goto IL_01BA;
							case 3:
								goto IL_0130;
							case 4:
								goto IL_00EE;
							case 5:
								goto IL_00F5;
							case 6:
							case 9:
								break;
							case 7:
								goto IL_01F7;
							case 8:
								goto IL_00F2;
							case 10:
								goto IL_01BA;
							case 11:
								goto IL_019D;
							case 12:
								goto IL_00E6;
							case 13:
								continue;
							default:
								goto IL_0140;
							}
							IL_010D:
							this.nullable_6 = new bool?(true);
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
							{
								break;
							}
							goto IL_015D;
							IL_0130:
							defaultValueHandling3 = new DefaultValueHandling?(defaultValueHandling5.GetValueOrDefault() & DefaultValueHandling.Populate);
							goto IL_00F0;
							IL_019D:
							defaultValueHandling5 = jsonProperty.DefaultValueHandling;
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
							{
								goto IL_0140;
							}
							goto IL_015D;
							IL_01BA:
							if (jsonProperty.Required != Required.Default)
							{
								goto IL_010D;
							}
							goto IL_019D;
						}
						IL_01F7:
						IL_01FA:;
					}
					finally
					{
						IEnumerator<JsonProperty> enumerator;
						int num3;
						if (enumerator == null)
						{
							num3 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
							{
								break;
							}
							goto IL_0214;
						}
						do
						{
							IL_0225:
							enumerator.Dispose();
							num3 = 1;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0);
						IL_0214:
						switch (num3)
						{
						default:
							goto IL_0225;
						case 1:
						case 2:
							break;
						}
					}
					break;
				}
				IL_0241:
				return this.nullable_6.GetValueOrDefault();
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		[NullableContext(1)]
		public JsonObjectContract(Type underlyingType)
			: base(underlyingType)
		{
			for (;;)
			{
				this.ContractType = JsonContractType.Object;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_000B;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					IL_000B:
					this.Properties = new JsonPropertyCollection(base.UnderlyingType);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto IL_002D;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0005AA40 File Offset: 0x00058C40
		[SecuritySafeCritical]
		[NullableContext(1)]
		internal object GetUninitializedObject()
		{
			while (!JsonTypeReflector.FullyTrusted)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw new JsonException(Class15.smethod_17(299930885 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, this.NonNullableUnderlyingType));
			}
			return FormatterServices.GetUninitializedObject(this.NonNullableUnderlyingType);
		}

		// Token: 0x04000550 RID: 1360
		[CompilerGenerated]
		private MemberSerialization memberSerialization_0;

		// Token: 0x04000551 RID: 1361
		[CompilerGenerated]
		private MissingMemberHandling? okmaHriLtw;

		// Token: 0x04000552 RID: 1362
		[CompilerGenerated]
		private Required? nullable_4;

		// Token: 0x04000553 RID: 1363
		[CompilerGenerated]
		private NullValueHandling? nullable_5;

		// Token: 0x04000554 RID: 1364
		[Nullable(1)]
		[CompilerGenerated]
		private readonly JsonPropertyCollection jsonPropertyCollection_0;

		// Token: 0x04000555 RID: 1365
		[CompilerGenerated]
		private ExtensionDataSetter extensionDataSetter_0;

		// Token: 0x04000556 RID: 1366
		[CompilerGenerated]
		private ExtensionDataGetter extensionDataGetter_0;

		// Token: 0x04000557 RID: 1367
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1, 1 })]
		private Func<string, string> func_1;

		// Token: 0x04000558 RID: 1368
		internal bool ExtensionDataIsJToken;

		// Token: 0x04000559 RID: 1369
		private bool? nullable_6;

		// Token: 0x0400055A RID: 1370
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> CuSanhevWn;

		// Token: 0x0400055B RID: 1371
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_0;

		// Token: 0x0400055C RID: 1372
		private JsonPropertyCollection jsonPropertyCollection_1;

		// Token: 0x0400055D RID: 1373
		private Type type_2;
	}
}
