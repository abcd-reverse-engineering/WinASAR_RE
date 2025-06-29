using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000109 RID: 265
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00004C1A File Offset: 0x00002E1A
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00004C22 File Offset: 0x00002E22
		[Nullable(new byte[] { 2, 1, 1 })]
		public Func<string, string> DictionaryKeyResolver
		{
			[return: Nullable(new byte[] { 2, 1, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 1 })]
			set;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00004C2B File Offset: 0x00002E2B
		public Type DictionaryKeyType { get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00004C33 File Offset: 0x00002E33
		public Type DictionaryValueType { get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00004C3B File Offset: 0x00002E3B
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000599D4 File Offset: 0x00057BD4
		internal JsonContract KeyContract
		{
			[CompilerGenerated]
			get
			{
				return this.jsonContract_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonContract_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00004C43 File Offset: 0x00002E43
		internal bool ShouldCreateWrapper { get; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00004C4B File Offset: 0x00002E4B
		[Nullable(new byte[] { 2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				if (this.objectConstructor_2 == null && this.constructorInfo_0 != null)
				{
					this.objectConstructor_2 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(this.constructorInfo_0);
				}
				return this.objectConstructor_2;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00004C7F File Offset: 0x00002E7F
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00004C87 File Offset: 0x00002E87
		[Nullable(new byte[] { 2, 1 })]
		public ObjectConstructor<object> OverrideCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.objectConstructor_1;
			}
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				this.objectConstructor_1 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00004C90 File Offset: 0x00002E90
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00059A0C File Offset: 0x00057C0C
		public bool HasParameterizedCreator
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
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00059A44 File Offset: 0x00057C44
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				IL_0037:
				while (!this.HasParameterizedCreator)
				{
					while (this.objectConstructor_2 != null)
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
						{
							break;
						}
						switch (num)
						{
						case 0:
							goto IL_0043;
						case 1:
							return true;
						case 2:
							break;
						case 3:
							goto IL_0037;
						default:
							goto IL_0043;
						}
					}
					IL_0043:
					return this.constructorInfo_0 != null;
				}
				return true;
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00059AA4 File Offset: 0x00057CA4
		[NullableContext(1)]
		public JsonDictionaryContract(Type underlyingType)
			: base(underlyingType)
		{
			for (;;)
			{
				IL_0404:
				this.ContractType = JsonContractType.Dictionary;
				int num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_0244;
				}
				Type type;
				ObjectConstructor<object> objectConstructor;
				for (;;)
				{
					IL_0369:
					Type type2;
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_0158;
					case 3:
						goto IL_003D;
					case 4:
					case 18:
						goto IL_0178;
					case 5:
						if (!(this.DictionaryValueType != null))
						{
							return;
						}
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							continue;
						}
						return;
					case 6:
						goto IL_0228;
					case 7:
						goto IL_01B9;
					case 8:
						if (!ImmutableCollectionsUtils.TryBuildImmutableForDictionaryContract(this.NonNullableUnderlyingType, this.DictionaryKeyType, this.DictionaryValueType, out type, out objectConstructor))
						{
							return;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							continue;
						}
						break;
					case 9:
						goto IL_02CB;
					case 10:
					case 13:
					case 34:
					case 35:
						goto IL_000E;
					case 11:
						goto IL_02B1;
					case 12:
						goto IL_00A2;
					case 14:
						if (ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(IDictionary<, >), out this.type_4))
						{
							goto IL_024E;
						}
						goto IL_02A2;
					case 15:
						goto IL_0113;
					case 16:
						goto IL_0195;
					case 17:
						this.DictionaryValueType = type2;
						goto IL_0277;
					case 19:
						goto IL_02A2;
					case 20:
						goto IL_01E8;
					case 21:
						goto IL_007C;
					case 22:
						goto IL_0277;
					case 23:
						goto IL_024E;
					case 24:
					case 31:
					case 32:
						goto IL_020D;
					case 25:
						goto IL_011E;
					case 26:
						goto IL_00C4;
					case 27:
						goto IL_0220;
					case 28:
						goto IL_0148;
					case 29:
						goto IL_004D;
					case 30:
						goto IL_0171;
					case 33:
						goto IL_0404;
					}
					break;
					IL_020D:
					Type type3;
					while (!(type3 != null))
					{
						num = 35;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
						{
							goto IL_0369;
						}
					}
					goto IL_00A2;
					IL_000E:
					if (!typeof(IDictionary).IsAssignableFrom(base.CreatedType))
					{
						goto IL_0171;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_003D;
					}
					continue;
					IL_00A2:
					if (!(type2 != null))
					{
						goto IL_000E;
					}
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_00C4;
					}
					continue;
					IL_003D:
					if (this.NonNullableUnderlyingType.IsGenericType())
					{
						goto IL_004D;
					}
					goto IL_020D;
					IL_0178:
					this.DictionaryKeyType = type3;
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						goto IL_0195;
					}
					continue;
					IL_0171:
					this.ShouldCreateWrapper = true;
					goto IL_0178;
					IL_0195:
					type2 = this.type_4.GetGenericArguments()[1];
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						goto IL_01B9;
					}
					continue;
					IL_024E:
					type3 = this.type_4.GetGenericArguments()[0];
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_0158;
					}
					continue;
					IL_0277:
					if (!(this.DictionaryKeyType != null))
					{
						return;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_003D;
					}
					continue;
					IL_0113:
					if (!this.HasParameterizedCreatorInternal)
					{
						goto IL_011E;
					}
					goto IL_000E;
					IL_00C4:
					this.constructorInfo_0 = CollectionUtils.ResolveEnumerableCollectionConstructor(base.CreatedType, typeof(KeyValuePair<, >).MakeGenericType(new Type[] { type3, type2 }), typeof(IDictionary<, >).MakeGenericType(new Type[] { type3, type2 }));
					goto IL_0113;
					IL_011E:
					if (this.NonNullableUnderlyingType.Name == Class15.smethod_17(89057526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454))
					{
						goto IL_0148;
					}
					goto IL_000E;
					IL_0158:
					this.objectConstructor_2 = FSharpUtils.Instance.CreateMap(type3, type2);
					goto IL_000E;
					IL_0148:
					FSharpUtils.EnsureInitialized(this.NonNullableUnderlyingType.Assembly());
					goto IL_0158;
					IL_004D:
					if (!(this.NonNullableUnderlyingType.GetGenericTypeDefinition().FullName == Class15.smethod_17(432128237 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2)))
					{
						goto IL_020D;
					}
					IL_007C:
					this.ShouldCreateWrapper = true;
					goto IL_020D;
					IL_01E8:
					base.CreatedType = typeof(Dictionary<, >).MakeGenericType(new Type[] { type3, type2 });
					goto IL_020D;
					IL_02B1:
					if (this.NonNullableUnderlyingType == typeof(IDictionary))
					{
						goto IL_02CB;
					}
					goto IL_020D;
					IL_02A2:
					ReflectionUtils.GetDictionaryKeyValueTypes(this.NonNullableUnderlyingType, out type3, out type2);
					goto IL_02B1;
					IL_02CB:
					base.CreatedType = typeof(Dictionary<object, object>);
					goto IL_020D;
					IL_01B9:
					if (!ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(IDictionary<, >)))
					{
						goto IL_003D;
					}
					num = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_01E8;
					}
				}
				goto IL_0244;
				IL_0228:
				this.IsReadOnlyOrFixedSize = true;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_0244;
				}
				goto IL_0369;
				IL_0220:
				this.objectConstructor_2 = objectConstructor;
				goto IL_0228;
				IL_0244:
				base.CreatedType = type;
				goto IL_0220;
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00059ED8 File Offset: 0x000580D8
		[NullableContext(1)]
		internal Interface1 CreateWrapper(object dictionary)
		{
			for (;;)
			{
				if (this.objectConstructor_0 == null)
				{
					goto IL_007A;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					break;
				}
				IL_005A:
				switch (num)
				{
				case 0:
					goto IL_0034;
				case 1:
				case 5:
					goto IL_00E1;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					IL_007A:
					this.type_5 = typeof(DictionaryWrapper<, >).MakeGenericType(new Type[] { this.DictionaryKeyType, this.DictionaryValueType });
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						goto IL_005A;
					}
					break;
				default:
					goto IL_0034;
				}
				ConstructorInfo constructor = this.type_5.GetConstructor(new Type[] { this.type_4 });
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_005A;
				}
				IL_0034:
				this.objectConstructor_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_005A;
				}
				break;
			}
			IL_00E1:
			return (Interface1)this.objectConstructor_0(new object[] { dictionary });
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00059FE0 File Offset: 0x000581E0
		[NullableContext(1)]
		internal IDictionary CreateTemporaryDictionary()
		{
			while (this.func_2 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_0046;
				}
				IL_00A2:
				switch (num)
				{
				case 0:
					goto IL_0046;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					goto IL_00C9;
				default:
					goto IL_0046;
				}
				IL_001D:
				Type type;
				this.func_2 = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
				{
					break;
				}
				goto IL_00A2;
				IL_0046:
				type = typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					this.DictionaryKeyType ?? typeof(object),
					this.DictionaryValueType ?? typeof(object)
				});
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_001D;
				}
				goto IL_00A2;
			}
			IL_00C9:
			return (IDictionary)this.func_2();
		}

		// Token: 0x04000536 RID: 1334
		[Nullable(new byte[] { 2, 1, 1 })]
		[CompilerGenerated]
		private Func<string, string> func_1;

		// Token: 0x04000537 RID: 1335
		[CompilerGenerated]
		private readonly Type type_2;

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private readonly Type type_3;

		// Token: 0x04000539 RID: 1337
		[CompilerGenerated]
		private JsonContract jsonContract_2;

		// Token: 0x0400053A RID: 1338
		private readonly Type type_4;

		// Token: 0x0400053B RID: 1339
		private Type type_5;

		// Token: 0x0400053C RID: 1340
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_0;

		// Token: 0x0400053D RID: 1341
		[Nullable(new byte[] { 2, 1 })]
		private Func<object> func_2;

		// Token: 0x0400053E RID: 1342
		[CompilerGenerated]
		private readonly bool bool_1;

		// Token: 0x0400053F RID: 1343
		private readonly ConstructorInfo constructorInfo_0;

		// Token: 0x04000540 RID: 1344
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_1;

		// Token: 0x04000541 RID: 1345
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_2;

		// Token: 0x04000542 RID: 1346
		[CompilerGenerated]
		private bool bool_2;
	}
}
