using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(0)]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00004172 File Offset: 0x00002372
		internal static ReflectionDelegateFactory Instance
		{
			get
			{
				return LateBoundReflectionDelegateFactory.lateBoundReflectionDelegateFactory_0;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0004DC5C File Offset: 0x0004BE5C
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0();
			CS$<>8__locals1.methodBase_0 = method;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.methodBase_0, Class15.smethod_17(594350468 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			CS$<>8__locals1.constructorInfo_0 = CS$<>8__locals1.methodBase_0 as ConstructorInfo;
			if (CS$<>8__locals1.constructorInfo_0 != null)
			{
				return new ObjectConstructor<object>(CS$<>8__locals1.method_0);
			}
			return new ObjectConstructor<object>(CS$<>8__locals1.method_1);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override MethodCall<T, object> CreateMethodCall<[Nullable(2)] T>(MethodBase method)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T>();
			CS$<>8__locals1.methodBase_0 = method;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.methodBase_0, Class15.smethod_17(594350468 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			CS$<>8__locals1.constructorInfo_0 = CS$<>8__locals1.methodBase_0 as ConstructorInfo;
			if (CS$<>8__locals1.constructorInfo_0 != null)
			{
				return new MethodCall<T, object>(CS$<>8__locals1.method_0);
			}
			return new MethodCall<T, object>(CS$<>8__locals1.method_1);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0004DD34 File Offset: 0x0004BF34
		public override Func<T> CreateDefaultConstructor<[Nullable(2)] T>(Type type)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T>();
			CS$<>8__locals1.type_0 = type;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.type_0, Class15.smethod_17(1387480562 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
			if (CS$<>8__locals1.type_0.IsValueType())
			{
				return new Func<T>(CS$<>8__locals1.method_0);
			}
			CS$<>8__locals1.constructorInfo_0 = ReflectionUtils.GetDefaultConstructor(CS$<>8__locals1.type_0, true);
			if (CS$<>8__locals1.constructorInfo_0 == null)
			{
				throw new InvalidOperationException(Class15.smethod_17(89062956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454) + CS$<>8__locals1.type_0.FullName);
			}
			return new Func<T>(CS$<>8__locals1.method_1);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00004179 File Offset: 0x00002379
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T>();
			CS$<>8__locals1.wodhTifjBo = propertyInfo;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.wodhTifjBo, Class15.smethod_17(768797540 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7));
			return new Func<T, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000041B2 File Offset: 0x000023B2
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T>();
			CS$<>8__locals1.fieldInfo_0 = fieldInfo;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.fieldInfo_0, Class15.smethod_17(41431375 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
			return new Func<T, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000041EB File Offset: 0x000023EB
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T>();
			CS$<>8__locals1.fieldInfo_0 = fieldInfo;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.fieldInfo_0, Class15.smethod_17(1788766487 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
			return new Action<T, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00004224 File Offset: 0x00002424
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> CS$<>8__locals1 = new LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T>();
			CS$<>8__locals1.propertyInfo_0 = propertyInfo;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.propertyInfo_0, Class15.smethod_17(1793870214 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
			return new Action<T, object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		public LateBoundReflectionDelegateFactory()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0004DE14 File Offset: 0x0004C014
		static LateBoundReflectionDelegateFactory()
		{
			for (;;)
			{
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					goto IL_0003;
				}
				IL_0031:
				switch (num)
				{
				case 1:
					goto IL_0016;
				case 2:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto IL_0016;
					}
					goto IL_0031;
				case 3:
					continue;
				}
				break;
				IL_0016:
				LateBoundReflectionDelegateFactory.lateBoundReflectionDelegateFactory_0 = new LateBoundReflectionDelegateFactory();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_0031;
				}
				break;
			}
		}

		// Token: 0x0400045F RID: 1119
		private static readonly LateBoundReflectionDelegateFactory lateBoundReflectionDelegateFactory_0;
	}
}
