using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A6 RID: 166
	[NullableContext(1)]
	[Nullable(0)]
	internal static class DynamicUtils
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00003F47 File Offset: 0x00002147
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			return dynamicProvider.GetMetaObject(Expression.Constant(dynamicProvider)).GetDynamicMemberNames();
		}

		// Token: 0x020000A7 RID: 167
		[Nullable(0)]
		internal static class BinderWrapper
		{
			// Token: 0x060006ED RID: 1773 RVA: 0x0004919C File Offset: 0x0004739C
			private static void smethod_0()
			{
				IL_00CA:
				while (!DynamicUtils.BinderWrapper.bool_0)
				{
					IL_00A0:
					while (!(Type.GetType(Class15.smethod_17(1743150204 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8), false) == null))
					{
						int num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							goto IL_00CA;
						}
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_0043;
							case 1:
								goto IL_00A0;
							case 2:
								goto IL_0048;
							case 3:
							case 7:
								return;
							case 4:
								goto IL_00CA;
							case 5:
								goto IL_00D7;
							case 6:
								DynamicUtils.BinderWrapper.object_0 = DynamicUtils.BinderWrapper.smethod_1(new int[1]);
								break;
							case 8:
								break;
							default:
								goto IL_0043;
							}
							DynamicUtils.BinderWrapper.QmDhovryvn = DynamicUtils.BinderWrapper.smethod_1(new int[] { 0, 3 });
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
							{
								goto IL_0043;
							}
							continue;
							IL_0048:
							DynamicUtils.BinderWrapper.bool_0 = true;
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
							{
								break;
							}
							continue;
							IL_0043:
							DynamicUtils.BinderWrapper.smethod_2();
							goto IL_0048;
						}
						return;
					}
					IL_00D7:
					throw new InvalidOperationException(Class15.smethod_17(197528475 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(277643766 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98)));
				}
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x000492BC File Offset: 0x000474BC
			private static object smethod_1(params int[] values)
			{
				Array array;
				for (;;)
				{
					IL_010D:
					Type type = Type.GetType(Class15.smethod_17(82258410 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), true);
					for (;;)
					{
						IL_00EE:
						Type type2 = Type.GetType(Class15.smethod_17(1760378745 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), true);
						for (;;)
						{
							array = Array.CreateInstance(type, values.Length);
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
							{
								goto IL_0083;
							}
							goto IL_009A;
							IL_0076:
							int i;
							while (i < values.Length)
							{
								num = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
								{
									goto IL_009A;
								}
							}
							return array;
							IL_009A:
							object obj2;
							switch (num)
							{
							case 0:
							case 5:
								goto IL_0076;
							case 1:
							case 8:
							{
								MethodBase method = type.GetMethod(Class15.smethod_17(486509868 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), new Type[]
								{
									type2,
									typeof(string)
								});
								object obj = null;
								object[] array2 = new object[2];
								array2[0] = 0;
								obj2 = method.Invoke(obj, array2);
								goto IL_0051;
							}
							case 2:
								IL_0083:
								i = 0;
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
								{
									goto IL_0076;
								}
								goto IL_009A;
							case 3:
								return array;
							case 4:
								break;
							case 6:
								continue;
							case 7:
								goto IL_0051;
							case 9:
								goto IL_00EE;
							case 10:
								goto IL_010D;
							default:
								goto IL_0076;
							}
							IL_005C:
							i++;
							goto IL_0076;
							IL_0051:
							array.SetValue(obj2, i);
							goto IL_005C;
						}
					}
				}
				return array;
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x000493F8 File Offset: 0x000475F8
			private static void smethod_2()
			{
				for (;;)
				{
					IL_0189:
					Type type = Type.GetType(Class15.smethod_17(635784831 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), true);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_013B;
					}
					Type type2;
					Type type3;
					Type type4;
					for (;;)
					{
						IL_015D:
						MethodInfo method;
						switch (num)
						{
						case 1:
							goto IL_013B;
						case 2:
							goto IL_0189;
						case 3:
							goto IL_0116;
						case 4:
							method = type2.GetMethod(Class15.smethod_17(1953747841 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f), new Type[]
							{
								type3,
								typeof(string),
								typeof(Type),
								type4
							});
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
							{
								goto IL_0116;
							}
							continue;
						case 5:
							goto IL_004D;
						case 6:
							goto IL_009A;
						case 7:
							goto IL_0031;
						case 8:
							goto IL_0006;
						}
						return;
						IL_0116:
						DynamicUtils.BinderWrapper.methodCall_1 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
						{
							return;
						}
					}
					IL_0006:
					MethodInfo method2;
					DynamicUtils.BinderWrapper.methodCall_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method2);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						break;
					}
					goto IL_015D;
					IL_004D:
					method2 = type2.GetMethod(Class15.smethod_17(2048603085 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), new Type[]
					{
						type3,
						typeof(string),
						typeof(Type),
						type4
					});
					goto IL_0006;
					IL_0031:
					type4 = typeof(IEnumerable<>).MakeGenericType(new Type[] { type });
					goto IL_004D;
					IL_009A:
					type2 = Type.GetType(Class15.smethod_17(974396497 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), true);
					goto IL_0031;
					IL_013B:
					type3 = Type.GetType(Class15.smethod_17(486464048 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), true);
					goto IL_009A;
				}
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x000495C4 File Offset: 0x000477C4
			public static CallSiteBinder GetMember(string name, Type context)
			{
				for (;;)
				{
					DynamicUtils.BinderWrapper.smethod_0();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
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
				return (CallSiteBinder)DynamicUtils.BinderWrapper.methodCall_0(null, new object[]
				{
					0,
					name,
					context,
					DynamicUtils.BinderWrapper.object_0
				});
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x00049628 File Offset: 0x00047828
			public static CallSiteBinder SetMember(string name, Type context)
			{
				for (;;)
				{
					DynamicUtils.BinderWrapper.smethod_0();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
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
				return (CallSiteBinder)DynamicUtils.BinderWrapper.methodCall_1(null, new object[]
				{
					0,
					name,
					context,
					DynamicUtils.BinderWrapper.QmDhovryvn
				});
			}

			// Token: 0x0400040A RID: 1034
			public const string string_0 = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x0400040B RID: 1035
			[Nullable(2)]
			private static object object_0;

			// Token: 0x0400040C RID: 1036
			[Nullable(2)]
			private static object QmDhovryvn;

			// Token: 0x0400040D RID: 1037
			[Nullable(2)]
			private static MethodCall<object, object> methodCall_0;

			// Token: 0x0400040E RID: 1038
			[Nullable(2)]
			private static MethodCall<object, object> methodCall_1;

			// Token: 0x0400040F RID: 1039
			private static bool bool_0;
		}
	}
}
