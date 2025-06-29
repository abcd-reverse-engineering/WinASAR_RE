using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000B3 RID: 179
	[NullableContext(1)]
	[Nullable(0)]
	internal class FSharpUtils
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x0004B6B0 File Offset: 0x000498B0
		private FSharpUtils(Assembly fsharpCoreAssembly)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
			{
				goto IL_02CC;
			}
			do
			{
				IL_02B1:
				this.Assembly_0 = fsharpCoreAssembly;
				num = 4;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0);
			for (;;)
			{
				IL_02CC:
				MethodInfo methodInfo2;
				Type type2;
				switch (num)
				{
				case 1:
					goto IL_02B1;
				case 2:
					goto IL_0054;
				case 3:
					goto IL_0206;
				case 4:
				{
					Type type = fsharpCoreAssembly.GetType(Class15.smethod_17(2008567811 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
					MethodInfo methodInfo = FSharpUtils.smethod_0(type, Class15.smethod_17(1116144155 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54), BindingFlags.Static | BindingFlags.Public);
					this.IsUnion = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
					methodInfo2 = FSharpUtils.smethod_0(type, Class15.smethod_17(1788766811 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), BindingFlags.Static | BindingFlags.Public);
					goto IL_0194;
				}
				case 5:
					goto IL_0104;
				case 6:
					this.PreComputeUnionTagReader = FSharpUtils.smethod_1(type2, Class15.smethod_17(676711276 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0206;
					}
					continue;
				case 7:
					return;
				case 8:
					goto IL_0080;
				case 9:
					goto IL_00D8;
				case 10:
					goto IL_00AC;
				case 11:
					goto IL_01A8;
				case 12:
					goto IL_0194;
				case 13:
					goto IL_015D;
				case 14:
					goto IL_0121;
				case 15:
					goto IL_0022;
				}
				break;
				IL_0022:
				Type type3 = fsharpCoreAssembly.GetType(Class15.smethod_17(543237760 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_0054;
				}
				continue;
				IL_01A8:
				this.PreComputeUnionConstructor = FSharpUtils.smethod_1(type2, Class15.smethod_17(1760322621 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039));
				goto IL_0022;
				IL_0121:
				Type type4;
				this.methodInfo_0 = type4.GetMethod(Class15.smethod_17(486508528 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					break;
				}
				continue;
				IL_0104:
				type4 = fsharpCoreAssembly.GetType(Class15.smethod_17(299938649 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
				goto IL_0121;
				IL_00D8:
				this.GetUnionCaseInfoFields = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(type3.GetMethod(Class15.smethod_17(676711540 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b)));
				goto IL_0104;
				IL_00AC:
				this.GetUnionCaseInfoDeclaringType = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty(Class15.smethod_17(1985293120 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba)));
				goto IL_00D8;
				IL_0080:
				this.GetUnionCaseInfoTag = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty(Class15.smethod_17(594350904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b)));
				goto IL_00AC;
				IL_0054:
				this.GetUnionCaseInfoName = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty(Class15.smethod_17(2071399480 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)));
				goto IL_0080;
				IL_015D:
				type2 = fsharpCoreAssembly.GetType(Class15.smethod_17(432138923 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0104;
				}
				continue;
				IL_0194:
				this.GetUnionCases = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo2);
				goto IL_015D;
				IL_0206:
				this.PreComputeUnionReader = FSharpUtils.smethod_1(type2, Class15.smethod_17(314790695 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_01A8;
				}
			}
			this.type_0 = fsharpCoreAssembly.GetType(Class15.smethod_17(314791049 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00003FFF File Offset: 0x000021FF
		public static FSharpUtils Instance
		{
			get
			{
				return FSharpUtils.fsharpUtils_0;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00004006 File Offset: 0x00002206
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		public Assembly Assembly_0
		{
			[CompilerGenerated]
			get
			{
				return this.assembly_0;
			}
			[CompilerGenerated]
			private set
			{
				for (;;)
				{
					this.assembly_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0000400E File Offset: 0x0000220E
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00004016 File Offset: 0x00002216
		[Nullable(new byte[] { 1, 2, 1 })]
		public MethodCall<object, object> IsUnion
		{
			[return: Nullable(new byte[] { 1, 2, 1 })]
			get;
			[param: Nullable(new byte[] { 1, 2, 1 })]
			private set;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0000401F File Offset: 0x0000221F
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00004027 File Offset: 0x00002227
		[Nullable(new byte[] { 1, 2, 1 })]
		public MethodCall<object, object> GetUnionCases
		{
			[return: Nullable(new byte[] { 1, 2, 1 })]
			get;
			[param: Nullable(new byte[] { 1, 2, 1 })]
			private set;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00004030 File Offset: 0x00002230
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00004038 File Offset: 0x00002238
		[Nullable(new byte[] { 1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionTagReader
		{
			[return: Nullable(new byte[] { 1, 2, 1 })]
			get;
			[param: Nullable(new byte[] { 1, 2, 1 })]
			private set;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00004041 File Offset: 0x00002241
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00004049 File Offset: 0x00002249
		[Nullable(new byte[] { 1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionReader
		{
			[return: Nullable(new byte[] { 1, 2, 1 })]
			get;
			[param: Nullable(new byte[] { 1, 2, 1 })]
			private set;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00004052 File Offset: 0x00002252
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0000405A File Offset: 0x0000225A
		[Nullable(new byte[] { 1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionConstructor
		{
			[return: Nullable(new byte[] { 1, 2, 1 })]
			get;
			[param: Nullable(new byte[] { 1, 2, 1 })]
			private set;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00004063 File Offset: 0x00002263
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0000406B File Offset: 0x0000226B
		public Func<object, object> GetUnionCaseInfoDeclaringType { get; private set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00004074 File Offset: 0x00002274
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0000407C File Offset: 0x0000227C
		public Func<object, object> GetUnionCaseInfoName { get; private set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00004085 File Offset: 0x00002285
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0000408D File Offset: 0x0000228D
		public Func<object, object> GetUnionCaseInfoTag { get; private set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00004096 File Offset: 0x00002296
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0000409E File Offset: 0x0000229E
		[Nullable(new byte[] { 1, 1, 2 })]
		public MethodCall<object, object> GetUnionCaseInfoFields
		{
			[return: Nullable(new byte[] { 1, 1, 2 })]
			get;
			[param: Nullable(new byte[] { 1, 1, 2 })]
			private set;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0004BA2C File Offset: 0x00049C2C
		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
			for (;;)
			{
				if (FSharpUtils.fsharpUtils_0 == null)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					break;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					goto IL_0060;
				case 2:
					goto IL_0063;
				case 3:
				case 5:
					return;
				case 4:
					continue;
				}
				IL_0003:
				object obj = FSharpUtils.object_0;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_001B;
				}
				goto IL_005F;
			}
			return;
			IL_005F:
			IL_0060:
			bool flag = false;
			IL_0063:
			try
			{
				object obj;
				Monitor.Enter(obj, ref flag);
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					goto IL_00A2;
				}
				IL_007F:
				if (FSharpUtils.fsharpUtils_0 != null)
				{
					goto IL_00BB;
				}
				IL_0086:
				FSharpUtils.fsharpUtils_0 = new FSharpUtils(fsharpCoreAssembly);
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
				{
					goto IL_00BB;
				}
				IL_00A2:
				switch (num2)
				{
				case 0:
					goto IL_0086;
				case 1:
					goto IL_007F;
				case 2:
				case 3:
					break;
				default:
					goto IL_0086;
				}
				IL_00BB:;
			}
			finally
			{
				if (flag)
				{
					goto IL_00E9;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0102;
				}
				IL_00D5:
				switch (num3)
				{
				case 2:
				{
					IL_00E9:
					object obj;
					Monitor.Exit(obj);
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_00D5;
					}
					break;
				}
				}
				IL_0102:;
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0004BB4C File Offset: 0x00049D4C
		private static MethodInfo smethod_0(Type type_1, string string_1, BindingFlags bindingFlags_0)
		{
			MethodInfo methodInfo;
			for (;;)
			{
				methodInfo = type_1.GetMethod(string_1, bindingFlags_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0003;
				}
				IL_003A:
				switch (num)
				{
				case 1:
				case 3:
					return methodInfo;
				case 2:
					goto IL_0021;
				case 4:
					IL_0003:
					if (methodInfo == null)
					{
						goto IL_0021;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto Block_2;
					}
					goto IL_003A;
				case 5:
					continue;
				}
				goto Block_4;
				IL_0021:
				if ((bindingFlags_0 & BindingFlags.NonPublic) == BindingFlags.NonPublic)
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_003A;
				}
				goto IL_007B;
			}
			Block_2:
			return methodInfo;
			Block_4:
			IL_007B:
			methodInfo = type_1.GetMethod(string_1, bindingFlags_0 | BindingFlags.NonPublic);
			return methodInfo;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		[return: Nullable(new byte[] { 1, 2, 1 })]
		private static MethodCall<object, object> smethod_1(Type type_1, string string_1)
		{
			FSharpUtils.<>c__DisplayClass52_0 CS$<>8__locals1 = new FSharpUtils.<>c__DisplayClass52_0();
			MethodInfo methodInfo = FSharpUtils.smethod_0(type_1, string_1, BindingFlags.Static | BindingFlags.Public);
			MethodInfo method = methodInfo.ReturnType.GetMethod(Class15.smethod_17(1743191466 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8), BindingFlags.Instance | BindingFlags.Public);
			CS$<>8__locals1.methodCall_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
			CS$<>8__locals1.methodCall_1 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return new MethodCall<object, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0004BC50 File Offset: 0x00049E50
		public ObjectConstructor<object> CreateSeq(Type t)
		{
			MethodInfo methodInfo = this.methodInfo_0.MakeGenericMethod(new Type[] { t });
			return JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(methodInfo);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0004BC80 File Offset: 0x00049E80
		public ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return (ObjectConstructor<object>)typeof(FSharpUtils).GetMethod(Class15.smethod_17(1243273286 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95)).MakeGenericMethod(new Type[] { keyType, valueType }).Invoke(this, null);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		[NullableContext(2)]
		[return: Nullable(1)]
		public ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
		{
			FSharpUtils.<>c__DisplayClass55_0<TKey, TValue> CS$<>8__locals1 = new FSharpUtils.<>c__DisplayClass55_0<TKey, TValue>();
			ConstructorInfo constructor = this.type_0.MakeGenericType(new Type[]
			{
				typeof(TKey),
				typeof(TValue)
			}).GetConstructor(new Type[] { typeof(IEnumerable<Tuple<TKey, TValue>>) });
			CS$<>8__locals1.objectConstructor_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
			return new ObjectConstructor<object>(CS$<>8__locals1.jbJhxkYbwh);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0004BD44 File Offset: 0x00049F44
		static FSharpUtils()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_0003;
				}
				IL_0015:
				switch (num)
				{
				case 1:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_0015;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			FSharpUtils.object_0 = new object();
		}

		// Token: 0x04000430 RID: 1072
		private static readonly object object_0;

		// Token: 0x04000431 RID: 1073
		[Nullable(2)]
		private static FSharpUtils fsharpUtils_0;

		// Token: 0x04000432 RID: 1074
		private MethodInfo methodInfo_0;

		// Token: 0x04000433 RID: 1075
		private Type type_0;

		// Token: 0x04000434 RID: 1076
		[CompilerGenerated]
		private Assembly assembly_0;

		// Token: 0x04000435 RID: 1077
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 2, 1 })]
		private MethodCall<object, object> JySkphoKoq;

		// Token: 0x04000436 RID: 1078
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 2, 1 })]
		private MethodCall<object, object> methodCall_0;

		// Token: 0x04000437 RID: 1079
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 2, 1 })]
		private MethodCall<object, object> methodCall_1;

		// Token: 0x04000438 RID: 1080
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 2, 1 })]
		private MethodCall<object, object> methodCall_2;

		// Token: 0x04000439 RID: 1081
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 2, 1 })]
		private MethodCall<object, object> methodCall_3;

		// Token: 0x0400043A RID: 1082
		[CompilerGenerated]
		private Func<object, object> func_0;

		// Token: 0x0400043B RID: 1083
		[CompilerGenerated]
		private Func<object, object> func_1;

		// Token: 0x0400043C RID: 1084
		[CompilerGenerated]
		private Func<object, object> func_2;

		// Token: 0x0400043D RID: 1085
		[CompilerGenerated]
		[Nullable(new byte[] { 1, 1, 2 })]
		private MethodCall<object, object> methodCall_4;

		// Token: 0x0400043E RID: 1086
		public const string FSharpSetTypeName = "FSharpSet`1";

		// Token: 0x0400043F RID: 1087
		public const string string_0 = "FSharpList`1";

		// Token: 0x04000440 RID: 1088
		public const string FSharpMapTypeName = "FSharpMap`2";
	}
}
