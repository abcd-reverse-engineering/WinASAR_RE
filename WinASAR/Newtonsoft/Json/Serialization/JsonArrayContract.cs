using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FF RID: 255
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00004A50 File Offset: 0x00002C50
		public Type CollectionItemType { get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00004A58 File Offset: 0x00002C58
		public bool IsMultidimensionalArray { get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00004A60 File Offset: 0x00002C60
		internal bool IsArray { get; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00004A68 File Offset: 0x00002C68
		internal bool ShouldCreateWrapper { get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00004A70 File Offset: 0x00002C70
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00058480 File Offset: 0x00056680
		internal bool CanDeserialize
		{
			[CompilerGenerated]
			get
			{
				return this.bool_4;
			}
			[CompilerGenerated]
			private set
			{
				for (;;)
				{
					this.bool_4 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00004A78 File Offset: 0x00002C78
		[Nullable(new byte[] { 2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				if (this.objectConstructor_1 == null && this.constructorInfo_0 != null)
				{
					this.objectConstructor_1 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(this.constructorInfo_0);
				}
				return this.objectConstructor_1;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00004AAC File Offset: 0x00002CAC
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Nullable(new byte[] { 2, 1 })]
		public ObjectConstructor<object> OverrideCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.objectConstructor_2;
			}
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				this.objectConstructor_2 = value;
				this.CanDeserialize = true;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00004AC4 File Offset: 0x00002CC4
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x000584B8 File Offset: 0x000566B8
		public bool HasParameterizedCreator
		{
			[CompilerGenerated]
			get
			{
				return this.bool_5;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_5 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000584F0 File Offset: 0x000566F0
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				IL_0044:
				while (!this.HasParameterizedCreator)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						for (;;)
						{
							switch (num)
							{
							case 1:
								if (this.objectConstructor_1 != null)
								{
									return true;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
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
					return this.constructorInfo_0 != null;
				}
				return true;
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00058560 File Offset: 0x00056760
		[NullableContext(1)]
		public JsonArrayContract(Type underlyingType)
			: base(underlyingType)
		{
			for (;;)
			{
				IL_075F:
				this.ContractType = JsonContractType.Array;
				for (;;)
				{
					IL_000E:
					this.IsArray = base.CreatedType.IsArray || (this.NonNullableUnderlyingType.IsGenericType() && this.NonNullableUnderlyingType.GetGenericTypeDefinition().FullName == Class15.smethod_17(432130453 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
					int num = 53;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_0064;
					}
					bool flag;
					for (;;)
					{
						IL_05F2:
						ObjectConstructor<object> objectConstructor;
						switch (num)
						{
						case 1:
						case 48:
							goto IL_03FC;
						case 3:
						case 67:
							goto IL_025E;
						case 4:
							goto IL_0169;
						case 5:
							goto IL_0387;
						case 6:
							goto IL_0291;
						case 7:
						case 40:
							goto IL_01A6;
						case 8:
						case 60:
							goto IL_00DF;
						case 9:
							goto IL_0531;
						case 10:
						case 19:
						case 54:
							return;
						case 11:
						case 12:
						case 21:
						case 23:
						case 37:
						case 49:
							goto IL_0099;
						case 13:
							goto IL_0511;
						case 14:
							goto IL_055C;
						case 15:
						case 38:
							goto IL_01FC;
						case 16:
							goto IL_013A;
						case 17:
							goto IL_0170;
						case 18:
							goto IL_03A3;
						case 20:
							goto IL_0347;
						case 22:
							if (this.CollectionItemType != null)
							{
								goto IL_0310;
							}
							num = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
							{
								continue;
							}
							return;
						case 24:
							goto IL_0433;
						case 25:
							goto IL_0588;
						case 26:
						case 50:
							goto IL_04B3;
						case 27:
							goto IL_045E;
						case 28:
							goto IL_075F;
						case 29:
							goto IL_037F;
						case 30:
							this.CollectionItemType = this.type_3.GetGenericArguments()[0];
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
							{
								goto Block_20;
							}
							continue;
						case 31:
							goto IL_010B;
						case 32:
							goto IL_0064;
						case 33:
							goto IL_0597;
						case 34:
						case 71:
							goto IL_003C;
						case 35:
							goto IL_032A;
						case 36:
							goto IL_0360;
						case 39:
							goto IL_02A9;
						case 41:
							goto IL_018C;
						case 42:
							goto IL_01C3;
						case 43:
						case 47:
						case 62:
							goto IL_02E7;
						case 44:
							goto IL_0261;
						case 45:
							goto IL_044F;
						case 46:
							goto IL_058F;
						case 51:
							goto IL_03E0;
						case 52:
							goto IL_0353;
						case 53:
							if (this.IsArray)
							{
								goto IL_0531;
							}
							goto IL_055C;
						case 55:
							goto IL_04F1;
						case 56:
							goto IL_00BB;
						case 57:
							goto IL_048F;
						case 58:
							this.objectConstructor_1 = objectConstructor;
							num = 59;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
							{
								goto Block_17;
							}
							continue;
						case 59:
							this.IsReadOnlyOrFixedSize = true;
							num = 20;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
							{
								goto IL_03E0;
							}
							continue;
						case 61:
							goto IL_0310;
						case 63:
							goto IL_026D;
						case 64:
							goto IL_0212;
						case 65:
							goto IL_000E;
						case 66:
							goto IL_0096;
						case 68:
						case 69:
							goto IL_007B;
						case 70:
							flag = this.HasParameterizedCreatorInternal;
							num = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
							{
								goto Block_9;
							}
							continue;
						}
						goto Block_22;
						IL_0291:
						flag = true;
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_02A9;
						}
						continue;
						IL_026D:
						this.type_3 = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
						goto IL_0291;
						IL_02A9:
						this.IsMultidimensionalArray = base.CreatedType.IsArray && base.UnderlyingType.GetArrayRank() > 1;
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
						{
							goto Block_11;
						}
						continue;
						IL_032A:
						Type type;
						base.CreatedType = type;
						num = 58;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							goto IL_0347;
						}
						continue;
						IL_0310:
						if (ImmutableCollectionsUtils.TryBuildImmutableForArrayContract(this.NonNullableUnderlyingType, this.CollectionItemType, out type, out objectConstructor))
						{
							goto IL_032A;
						}
						return;
						IL_0387:
						this.IsReadOnlyOrFixedSize = false;
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
						{
							goto IL_03A3;
						}
						continue;
						IL_037F:
						Type type2;
						this.type_3 = type2;
						goto IL_0387;
						IL_0360:
						if (this.NonNullableUnderlyingType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
						{
							goto IL_037F;
						}
						goto IL_02E7;
						IL_0353:
						if (this.NonNullableUnderlyingType.IsGenericType())
						{
							goto IL_0360;
						}
						goto IL_02E7;
						IL_0347:
						this.method_0(this.NonNullableUnderlyingType);
						goto IL_0353;
						IL_04B3:
						this.constructorInfo_0 = CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
						goto IL_0347;
						IL_048F:
						base.CreatedType = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
						goto IL_04B3;
						IL_045E:
						if (ReflectionUtils.IsGenericDefinition(base.UnderlyingType, typeof(IEnumerable<>)))
						{
							goto IL_048F;
						}
						num = 26;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
						{
							return;
						}
						continue;
						IL_044F:
						this.CollectionItemType = type2.GetGenericArguments()[0];
						goto IL_045E;
						IL_0433:
						if (ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(IEnumerable<>), out type2))
						{
							goto IL_044F;
						}
						goto IL_025E;
						IL_03FC:
						if (!ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(ICollection<>), out this.type_3))
						{
							goto IL_0433;
						}
						num = 30;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							goto IL_037F;
						}
						continue;
						IL_03A3:
						this.IsReadOnlyOrFixedSize = true;
						num = 32;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
						{
							goto IL_026D;
						}
						continue;
						IL_03E0:
						this.CanDeserialize = true;
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
						{
							goto IL_03FC;
						}
						continue;
						IL_0531:
						this.CollectionItemType = ReflectionUtils.GetCollectionItemType(base.UnderlyingType);
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
						{
							goto IL_03A3;
						}
						continue;
						IL_055C:
						if (typeof(IList).IsAssignableFrom(this.NonNullableUnderlyingType))
						{
							goto IL_04F1;
						}
						num = 48;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
						{
							goto IL_0588;
						}
					}
					Block_9:
					goto IL_0099;
					IL_0511:
					this.CollectionItemType = this.type_3.GetGenericArguments()[0];
					goto IL_003C;
					IL_04F1:
					if (ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(ICollection<>), out this.type_3))
					{
						goto IL_0511;
					}
					Block_17:
					goto IL_01FC;
					Block_20:
					goto IL_010B;
					IL_02E7:
					this.type_3 = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
					goto IL_0169;
					IL_0261:
					this.ShouldCreateWrapper = true;
					goto IL_0099;
					IL_025E:
					flag = false;
					goto IL_0261;
					IL_058F:
					flag = true;
					goto IL_0099;
					IL_0588:
					this.ShouldCreateWrapper = false;
					goto IL_058F;
					IL_0597:
					this.ShouldCreateWrapper = true;
					goto IL_0099;
					Block_11:
					Block_22:
					goto IL_0056;
					IL_0099:
					this.CanDeserialize = flag;
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_01A6;
					}
					goto IL_05F2;
					IL_0096:
					flag = true;
					goto IL_0099;
					IL_007B:
					this.IsReadOnlyOrFixedSize = ReflectionUtils.InheritsGenericDefinition(this.NonNullableUnderlyingType, typeof(ReadOnlyCollection<>));
					goto IL_0096;
					IL_0064:
					this.constructorInfo_0 = CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
					goto IL_007B;
					IL_0056:
					if (this.CollectionItemType != null)
					{
						goto IL_0064;
					}
					goto IL_007B;
					IL_003C:
					if (!(this.NonNullableUnderlyingType == typeof(IList)))
					{
						goto IL_0056;
					}
					goto IL_0212;
					IL_01FC:
					this.CollectionItemType = ReflectionUtils.GetCollectionItemType(this.NonNullableUnderlyingType);
					goto IL_003C;
					IL_00DF:
					this.constructorInfo_0 = CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
					num = 41;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_010B;
					}
					goto IL_05F2;
					IL_00BB:
					base.CreatedType = typeof(HashSet<>).MakeGenericType(new Type[] { this.CollectionItemType });
					goto IL_00DF;
					IL_01A6:
					if (ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(ISet<>)))
					{
						goto IL_00BB;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto IL_0169;
					}
					goto IL_05F2;
					IL_013A:
					if (!ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(IList<>)))
					{
						goto IL_01A6;
					}
					goto IL_01C3;
					IL_010B:
					if (ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(ICollection<>)))
					{
						goto IL_01C3;
					}
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto IL_013A;
					}
					goto IL_05F2;
					IL_0170:
					this.ShouldCreateWrapper = true;
					num = 70;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_018C;
					}
					goto IL_05F2;
					IL_0169:
					this.IsReadOnlyOrFixedSize = true;
					goto IL_0170;
					IL_018C:
					flag = true;
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						goto IL_013A;
					}
					goto IL_05F2;
					IL_01C3:
					base.CreatedType = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
					num = 40;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_01FC;
					}
					goto IL_05F2;
					IL_0212:
					base.CreatedType = typeof(List<object>);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0056;
					}
					goto IL_05F2;
				}
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00058CDC File Offset: 0x00056EDC
		[NullableContext(1)]
		internal Interface0 CreateWrapper(object list)
		{
			IL_00F7:
			while (this.objectConstructor_0 == null)
			{
				Type type;
				for (;;)
				{
					IL_00BF:
					this.type_4 = typeof(CollectionWrapper<>).MakeGenericType(new Type[] { this.CollectionItemType });
					int num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_0068;
							case 2:
								goto IL_0137;
							case 3:
								goto IL_00BF;
							case 4:
								goto IL_00F7;
							case 5:
							case 11:
								goto IL_0105;
							case 6:
								goto IL_0125;
							case 7:
							case 10:
								goto IL_0006;
							case 8:
								if (!ReflectionUtils.InheritsGenericDefinition(this.type_3, typeof(List<>)))
								{
									goto IL_0068;
								}
								num = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
								{
									goto IL_0006;
								}
								continue;
							}
							goto Block_5;
							IL_0006:
							type = typeof(ICollection<>).MakeGenericType(new Type[] { this.CollectionItemType });
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
							{
								goto Block_1;
							}
							continue;
							IL_0068:
							if (!(this.type_3.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
							{
								goto Block_4;
							}
							goto IL_0006;
						}
					}
				}
				Block_1:
				goto IL_010D;
				Block_4:
				goto IL_0105;
				Block_5:
				goto IL_010D;
				IL_0105:
				type = this.type_3;
				IL_010D:
				ConstructorInfo constructor = this.type_4.GetConstructor(new Type[] { type });
				IL_0125:
				this.objectConstructor_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
				break;
			}
			IL_0137:
			return (Interface0)this.objectConstructor_0(new object[] { list });
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00058E3C File Offset: 0x0005703C
		[NullableContext(1)]
		internal IList CreateTemporaryCollection()
		{
			IL_00E9:
			while (this.func_1 == null)
			{
				for (;;)
				{
					IL_00DE:
					if (this.IsMultidimensionalArray)
					{
						goto IL_00A7;
					}
					goto IL_00CA;
					int num;
					Type type2;
					for (;;)
					{
						IL_0076:
						Type type;
						switch (num)
						{
						case 1:
							goto IL_0053;
						case 3:
							goto IL_00CA;
						case 4:
							type = typeof(List<>).MakeGenericType(new Type[] { type2 });
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
							{
								goto IL_0053;
							}
							continue;
						case 5:
							goto IL_0006;
						case 6:
						case 9:
							goto IL_00F5;
						case 7:
							goto IL_00E9;
						case 8:
							goto IL_00DE;
						}
						break;
						IL_0053:
						this.func_1 = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type);
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
						{
							goto IL_00F4;
						}
					}
					goto IL_00A7;
					IL_000C:
					Type type3;
					type2 = type3;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_00A7;
					}
					goto IL_0076;
					IL_0006:
					type3 = this.CollectionItemType;
					goto IL_000C;
					IL_00A7:
					type3 = typeof(object);
					goto IL_000C;
					IL_00CA:
					if (!(this.CollectionItemType == null))
					{
						goto IL_0006;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_00A7;
					}
					goto IL_0076;
				}
				IL_00F4:
				IL_00F5:
				return (IList)this.func_1();
			}
			goto IL_00F5;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00058F50 File Offset: 0x00057150
		[NullableContext(1)]
		private void method_0(Type type_5)
		{
			while (!this.HasParameterizedCreatorInternal)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_004F;
				}
				IL_0074:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_004F:
					if (type_5.Name == Class15.smethod_17(82292528 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909))
					{
						goto IL_001A;
					}
					return;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_001A;
				default:
					return;
				}
				IL_0025:
				this.objectConstructor_1 = FSharpUtils.Instance.CreateSeq(this.CollectionItemType);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					break;
				}
				goto IL_0074;
				IL_001A:
				FSharpUtils.EnsureInitialized(type_5.Assembly());
				goto IL_0025;
			}
		}

		// Token: 0x040004FD RID: 1277
		[CompilerGenerated]
		private readonly Type type_2;

		// Token: 0x040004FE RID: 1278
		[CompilerGenerated]
		private readonly bool bool_1;

		// Token: 0x040004FF RID: 1279
		private readonly Type type_3;

		// Token: 0x04000500 RID: 1280
		private Type type_4;

		// Token: 0x04000501 RID: 1281
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_0;

		// Token: 0x04000502 RID: 1282
		[Nullable(new byte[] { 2, 1 })]
		private Func<object> func_1;

		// Token: 0x04000503 RID: 1283
		[CompilerGenerated]
		private readonly bool bool_2;

		// Token: 0x04000504 RID: 1284
		[CompilerGenerated]
		private readonly bool bool_3;

		// Token: 0x04000505 RID: 1285
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04000506 RID: 1286
		private readonly ConstructorInfo constructorInfo_0;

		// Token: 0x04000507 RID: 1287
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_1;

		// Token: 0x04000508 RID: 1288
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_2;

		// Token: 0x04000509 RID: 1289
		[CompilerGenerated]
		private bool bool_5;
	}
}
