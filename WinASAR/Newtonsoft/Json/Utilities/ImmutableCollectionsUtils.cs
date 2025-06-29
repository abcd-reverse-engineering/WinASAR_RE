using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000B8 RID: 184
	[Nullable(0)]
	[NullableContext(1)]
	internal static class ImmutableCollectionsUtils
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x0004C1D0 File Offset: 0x0004A3D0
		internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, [NotNullWhen(true)] [Nullable(2)] out Type createdType, [Nullable(new byte[] { 2, 1 })] [NotNullWhen(true)] out ObjectConstructor<object> parameterizedCreator)
		{
			MethodInfo methodInfo;
			Type type2;
			for (;;)
			{
				if (underlyingType.IsGenericType())
				{
					goto IL_015A;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
				{
					break;
				}
				IL_00B6:
				switch (num)
				{
				case 1:
					goto IL_004A;
				case 2:
					continue;
				case 3:
					goto IL_009E;
				case 4:
					goto IL_003D;
				case 5:
					goto IL_008E;
				case 6:
					goto IL_0150;
				case 7:
					goto IL_0079;
				case 8:
					goto IL_010D;
				case 9:
					IL_015A:
					goto IL_0150;
				case 10:
					goto IL_0188;
				case 11:
					goto IL_019B;
				case 12:
					goto IL_0064;
				case 13:
					goto IL_0010;
				case 14:
					goto IL_0140;
				case 15:
					goto IL_0006;
				case 16:
					goto IL_01B6;
				case 17:
					return false;
				case 18:
					return true;
				}
				break;
				IL_004A:
				createdType = null;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					break;
				}
				goto IL_00B6;
				IL_0006:
				Type type;
				if (type != null)
				{
					goto IL_0010;
				}
				goto IL_004A;
				IL_010D:
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo immutableCollectionTypeInfo = ImmutableCollectionsUtils.ilist_0.FirstOrDefault(new Func<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo, bool>(CS$<>8__locals1.method_0));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_009E;
				}
				goto IL_00B6;
				IL_0140:
				Type genericTypeDefinition;
				CS$<>8__locals1.string_0 = genericTypeDefinition.FullName;
				goto IL_010D;
				IL_0150:
				genericTypeDefinition = underlyingType.GetGenericTypeDefinition();
				goto IL_0140;
				IL_003D:
				if (!(methodInfo != null))
				{
					goto IL_004A;
				}
				goto IL_0188;
				IL_0010:
				methodInfo = type.GetMethods().FirstOrDefault(new Func<MethodInfo, bool>(ImmutableCollectionsUtils.<>c.<>c_0.method_0));
				goto IL_003D;
				IL_008E:
				if (type2 != null)
				{
					goto IL_0006;
				}
				goto IL_004A;
				IL_0079:
				type = genericTypeDefinition.Assembly().GetType(immutableCollectionTypeInfo.BuilderTypeName);
				goto IL_008E;
				IL_0064:
				type2 = genericTypeDefinition.Assembly().GetType(immutableCollectionTypeInfo.CreatedTypeName);
				goto IL_0079;
				IL_009E:
				if (immutableCollectionTypeInfo == null)
				{
					goto IL_004A;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_0064;
				}
				goto IL_00B6;
			}
			goto IL_01B1;
			IL_0188:
			createdType = type2.MakeGenericType(new Type[] { collectionItemType });
			IL_019B:
			MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(new Type[] { collectionItemType });
			goto IL_01B6;
			IL_01B1:
			parameterizedCreator = null;
			return false;
			IL_01B6:
			parameterizedCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(methodInfo2);
			return true;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
		internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, [Nullable(2)] [NotNullWhen(true)] out Type createdType, [Nullable(new byte[] { 2, 1 })] [NotNullWhen(true)] out ObjectConstructor<object> parameterizedCreator)
		{
			Type type2;
			MethodInfo methodInfo;
			for (;;)
			{
				if (underlyingType.IsGenericType())
				{
					goto IL_00BA;
				}
				goto IL_0174;
				IL_00DE:
				int num;
				switch (num)
				{
				case 0:
					goto IL_008D;
				case 1:
				case 11:
				case 19:
					goto IL_0174;
				case 2:
					goto IL_0061;
				case 3:
					goto IL_01B9;
				case 4:
					goto IL_01A2;
				case 5:
					goto IL_01D0;
				case 6:
					goto IL_013D;
				case 7:
					goto IL_006E;
				case 8:
					break;
				case 9:
					goto IL_0033;
				case 10:
					goto IL_00C6;
				case 12:
					goto IL_004C;
				case 13:
					goto IL_0037;
				case 14:
					goto IL_016A;
				case 15:
					return false;
				case 16:
					goto IL_0006;
				case 17:
					goto IL_00BA;
				case 18:
					continue;
				case 20:
					return true;
				default:
					goto IL_008D;
				}
				IL_000E:
				ImmutableCollectionsUtils.<>c__DisplayClass25_0 CS$<>8__locals1;
				Type genericTypeDefinition;
				CS$<>8__locals1.string_0 = genericTypeDefinition.FullName;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_008D;
				}
				goto IL_00DE;
				IL_0006:
				genericTypeDefinition = underlyingType.GetGenericTypeDefinition();
				goto IL_000E;
				IL_00BA:
				CS$<>8__locals1 = new ImmutableCollectionsUtils.<>c__DisplayClass25_0();
				goto IL_0006;
				IL_006E:
				Type type;
				if (type != null)
				{
					goto IL_013D;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_008D;
				}
				goto IL_00DE;
				IL_0061:
				if (type2 != null)
				{
					goto IL_006E;
				}
				goto IL_0174;
				IL_004C:
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo immutableCollectionTypeInfo;
				type = genericTypeDefinition.Assembly().GetType(immutableCollectionTypeInfo.BuilderTypeName);
				goto IL_0061;
				IL_0037:
				type2 = genericTypeDefinition.Assembly().GetType(immutableCollectionTypeInfo.CreatedTypeName);
				goto IL_004C;
				IL_0033:
				if (immutableCollectionTypeInfo != null)
				{
					goto IL_0037;
				}
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_00BA;
				}
				goto IL_00DE;
				IL_008D:
				immutableCollectionTypeInfo = ImmutableCollectionsUtils.ilist_1.FirstOrDefault(new Func<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo, bool>(CS$<>8__locals1.method_0));
				goto IL_0033;
				IL_00C6:
				parameterizedCreator = null;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_00DE;
				}
				break;
				IL_0174:
				createdType = null;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_00C6;
				}
				goto IL_00DE;
				IL_016A:
				if (!(methodInfo != null))
				{
					goto IL_0174;
				}
				goto IL_01A2;
				IL_013D:
				methodInfo = type.GetMethods().FirstOrDefault(new Func<MethodInfo, bool>(ImmutableCollectionsUtils.<>c.<>c_0.method_1));
				goto IL_016A;
			}
			return false;
			IL_01A2:
			createdType = type2.MakeGenericType(new Type[] { keyItemType, valueItemType });
			IL_01B9:
			MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(new Type[] { keyItemType, valueItemType });
			IL_01D0:
			parameterizedCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(methodInfo2);
			return true;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0004C598 File Offset: 0x0004A798
		static ImmutableCollectionsUtils()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_03FB;
				}
				IL_0401:
				switch (num)
				{
				case 0:
					goto IL_03FB;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					goto IL_0108;
				case 4:
					break;
				default:
					goto IL_03FB;
				}
				IL_0006:
				ImmutableCollectionsUtils.ilist_1 = new List<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>
				{
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(89062376 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), Class15.smethod_17(1243277276 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95), Class15.smethod_17(676721568 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(552199654 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), Class15.smethod_17(1042115877 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad), Class15.smethod_17(486522836 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(2048545531 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), Class15.smethod_17(552198826 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), Class15.smethod_17(538829769 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa))
				};
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					break;
				}
				goto IL_0401;
				IL_0108:
				ImmutableCollectionsUtils.ilist_0 = new List<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>
				{
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(1424561280 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), Class15.smethod_17(41432557 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), Class15.smethod_17(1176443774 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(124827092 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719), Class15.smethod_17(486508046 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), Class15.smethod_17(974437563 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(698986448 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a), Class15.smethod_17(974438371 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), Class15.smethod_17(1788767783 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(2048552725 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), Class15.smethod_17(314791569 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), Class15.smethod_17(649973594 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(594352010 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b), Class15.smethod_17(1678107320 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a), Class15.smethod_17(1243276476 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(1570967779 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), Class15.smethod_17(1807904540 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), Class15.smethod_17(1802366429 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(197563889 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), Class15.smethod_17(1788760181 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), Class15.smethod_17(1802366149 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(2021180636 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Class15.smethod_17(1678105700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a), Class15.smethod_17(41421131 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(1743176186 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8), Class15.smethod_17(642140218 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Class15.smethod_17(486521452 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo(Class15.smethod_17(1387490022 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923), Class15.smethod_17(1396550616 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), Class15.smethod_17(2057005861 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48))
				};
				goto IL_0006;
				IL_03FB:
				goto IL_0108;
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ilist_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ilist_1;

		// Token: 0x020000B9 RID: 185
		[Nullable(0)]
		internal class ImmutableCollectionTypeInfo
		{
			// Token: 0x06000778 RID: 1912 RVA: 0x0004C9D8 File Offset: 0x0004ABD8
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
			{
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_001A;
				}
				for (;;)
				{
					IL_0066:
					switch (num)
					{
					case 1:
						goto IL_0033;
					case 2:
						this.CreatedTypeName = createdTypeName;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							continue;
						}
						break;
					case 3:
						goto IL_001A;
					}
					break;
				}
				return;
				IL_001A:
				this.ContractTypeName = contractTypeName;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					goto IL_0066;
				}
				IL_0033:
				this.BuilderTypeName = builderTypeName;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0066;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000779 RID: 1913 RVA: 0x000040F8 File Offset: 0x000022F8
			// (set) Token: 0x0600077A RID: 1914 RVA: 0x0004CA68 File Offset: 0x0004AC68
			public string ContractTypeName
			{
				[CompilerGenerated]
				get
				{
					return this.string_0;
				}
				[CompilerGenerated]
				set
				{
					for (;;)
					{
						this.string_0 = value;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
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

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600077B RID: 1915 RVA: 0x00004100 File Offset: 0x00002300
			// (set) Token: 0x0600077C RID: 1916 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
			public string CreatedTypeName
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
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
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

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600077D RID: 1917 RVA: 0x00004108 File Offset: 0x00002308
			// (set) Token: 0x0600077E RID: 1918 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
			public string BuilderTypeName
			{
				[CompilerGenerated]
				get
				{
					return this.string_2;
				}
				[CompilerGenerated]
				set
				{
					for (;;)
					{
						this.string_2 = value;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
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

			// Token: 0x0400044E RID: 1102
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400044F RID: 1103
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000450 RID: 1104
			[CompilerGenerated]
			private string string_2;
		}
	}
}
