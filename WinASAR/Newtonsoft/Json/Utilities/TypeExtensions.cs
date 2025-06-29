using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E0 RID: 224
	[NullableContext(1)]
	[Nullable(0)]
	internal static class TypeExtensions
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00004793 File Offset: 0x00002993
		public static MethodInfo Method(this Delegate d)
		{
			return d.Method;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0000479B File Offset: 0x0000299B
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return memberInfo.MemberType;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000047A3 File Offset: 0x000029A3
		public static bool ContainsGenericParameters(this Type type)
		{
			return type.ContainsGenericParameters;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000047AB File Offset: 0x000029AB
		public static bool IsInterface(this Type type)
		{
			return type.IsInterface;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000047B3 File Offset: 0x000029B3
		public static bool IsGenericType(this Type type)
		{
			return type.IsGenericType;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000047BB File Offset: 0x000029BB
		public static bool IsGenericTypeDefinition(this Type type)
		{
			return type.IsGenericTypeDefinition;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000047C3 File Offset: 0x000029C3
		[return: Nullable(2)]
		public static Type BaseType(this Type type)
		{
			return type.BaseType;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000047CB File Offset: 0x000029CB
		public static Assembly Assembly(this Type type)
		{
			return type.Assembly;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000047D3 File Offset: 0x000029D3
		public static bool IsEnum(this Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000047DB File Offset: 0x000029DB
		public static bool IsClass(this Type type)
		{
			return type.IsClass;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000047E3 File Offset: 0x000029E3
		public static bool IsSealed(this Type type)
		{
			return type.IsSealed;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000047EB File Offset: 0x000029EB
		public static bool IsAbstract(this Type type)
		{
			return type.IsAbstract;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000047F3 File Offset: 0x000029F3
		public static bool IsVisible(this Type type)
		{
			return type.IsVisible;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000047FB File Offset: 0x000029FB
		public static bool IsValueType(this Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00004803 File Offset: 0x00002A03
		public static bool IsPrimitive(this Type type)
		{
			return type.IsPrimitive;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000526C0 File Offset: 0x000508C0
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, [Nullable(2)] [NotNullWhen(true)] out Type match)
		{
			Type type2;
			for (;;)
			{
				IL_0125:
				type2 = type;
				for (;;)
				{
					if (!(type2 != null))
					{
						goto IL_00DD;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_00E6;
					}
					IL_0089:
					switch (num)
					{
					case 0:
						goto IL_006D;
					case 1:
					case 13:
						IL_00E6:
						if (!string.Equals(type2.FullName, fullTypeName, StringComparison.Ordinal))
						{
							type2 = type2.BaseType();
							continue;
						}
						goto IL_012A;
					case 2:
						return true;
					case 3:
						goto IL_0068;
					case 4:
						return true;
					case 5:
					case 16:
						continue;
					case 6:
						return false;
					case 7:
						goto IL_0135;
					case 8:
					case 10:
						break;
					case 9:
						IL_00DD:
						if (!searchInterfaces)
						{
							goto IL_0135;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							goto IL_006D;
						}
						goto IL_0089;
					case 11:
						goto IL_0130;
					case 12:
					case 18:
						goto IL_005A;
					case 14:
						goto IL_012A;
					case 15:
						goto IL_0054;
					case 17:
						goto IL_0125;
					default:
						goto IL_006D;
					}
					IL_002C:
					Type[] interfaces;
					int num2;
					if (string.Equals(interfaces[num2].Name, fullTypeName, StringComparison.Ordinal))
					{
						goto IL_0130;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_0054;
					}
					goto IL_0089;
					IL_005A:
					if (num2 >= interfaces.Length)
					{
						goto IL_0135;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_002C;
					}
					goto IL_0089;
					IL_0068:
					num2 = 0;
					goto IL_005A;
					IL_0054:
					num2++;
					goto IL_005A;
					IL_006D:
					interfaces = type.GetInterfaces();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						goto IL_0068;
					}
					goto IL_0089;
				}
			}
			IL_012A:
			match = type2;
			return true;
			IL_0130:
			match = type;
			return true;
			IL_0135:
			match = null;
			return false;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00052808 File Offset: 0x00050A08
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			Type type2;
			return type.AssignableToTypeName(fullTypeName, searchInterfaces, out type2);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00052820 File Offset: 0x00050A20
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			for (;;)
			{
				IL_0146:
				Type type2 = type;
				IL_0139:
				while (type2 != null)
				{
					for (;;)
					{
						IEnumerator<Type> enumerator = ((IEnumerable<Type>)type2.GetInterfaces()).GetEnumerator();
						for (;;)
						{
							IL_0123:
							try
							{
								for (;;)
								{
									if (enumerator.MoveNext())
									{
										goto IL_0069;
									}
									int num = 7;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
									{
										break;
									}
									IL_001A:
									switch (num)
									{
									case 0:
										goto IL_0069;
									case 1:
										goto IL_009A;
									case 2:
										goto IL_009D;
									case 3:
										continue;
									case 4:
										goto IL_005C;
									case 5:
										break;
									case 6:
										goto IL_004F;
									case 7:
										goto IL_0097;
									default:
										goto IL_0069;
									}
									IL_0042:
									Type type3;
									if (!type3.ImplementInterface(interfaceType))
									{
										continue;
									}
									num = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
									{
										goto IL_001A;
									}
									break;
									IL_004F:
									if (type3 != null)
									{
										goto IL_0042;
									}
									continue;
									IL_005C:
									if (!(type3 == interfaceType))
									{
										goto IL_004F;
									}
									break;
									IL_0069:
									type3 = enumerator.Current;
									goto IL_005C;
								}
								goto IL_009A;
								IL_0097:
								goto IL_00E4;
								IL_009A:
								bool flag = true;
								IL_009D:
								return flag;
							}
							finally
							{
								if (enumerator != null)
								{
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
									{
										for (;;)
										{
											switch (num2)
											{
											case 1:
												enumerator.Dispose();
												num2 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
												{
													continue;
												}
												break;
											}
											break;
										}
									}
								}
							}
							for (;;)
							{
								IL_00E4:
								type2 = type2.BaseType();
								int num3 = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
								{
									switch (num3)
									{
									case 1:
										continue;
									case 2:
										return false;
									case 3:
										goto IL_0123;
									case 4:
									case 6:
										goto IL_0139;
									case 5:
										goto IL_0146;
									}
									goto Block_3;
								}
								break;
							}
						}
						Block_3:;
					}
				}
				break;
			}
			return false;
		}
	}
}
