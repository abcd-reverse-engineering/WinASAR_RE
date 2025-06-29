using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AF RID: 175
	[NullableContext(1)]
	[Nullable(0)]
	internal class ExpressionReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00003FA9 File Offset: 0x000021A9
		internal static ReflectionDelegateFactory Instance
		{
			get
			{
				return ExpressionReflectionDelegateFactory.expressionReflectionDelegateFactory_0;
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0004A87C File Offset: 0x00048A7C
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			ValidationUtils.ArgumentNotNull(method, Class15.smethod_17(1793870250 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
			Type typeFromHandle = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), Class15.smethod_17(564911830 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
			Expression expression = this.method_0(method, typeFromHandle, null, parameterExpression);
			return (ObjectConstructor<object>)Expression.Lambda(typeof(ObjectConstructor<object>), expression, new ParameterExpression[] { parameterExpression }).Compile();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0004A904 File Offset: 0x00048B04
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override MethodCall<T, object> CreateMethodCall<[Nullable(2)] T>(MethodBase method)
		{
			ValidationUtils.ArgumentNotNull(method, Class15.smethod_17(1953663137 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
			Type typeFromHandle = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, Class15.smethod_17(1788740243 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), Class15.smethod_17(543237242 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
			Expression expression = this.method_0(method, typeFromHandle, parameterExpression, parameterExpression2);
			return (MethodCall<T, object>)Expression.Lambda(typeof(MethodCall<T, object>), expression, new ParameterExpression[] { parameterExpression, parameterExpression2 }).Compile();
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0004A9AC File Offset: 0x00048BAC
		private Expression method_0(MethodBase methodBase_0, Type type_0, [Nullable(2)] ParameterExpression targetParameterExpression, ParameterExpression parameterExpression_0)
		{
			Expression expression;
			for (;;)
			{
				IL_057C:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				for (;;)
				{
					IL_0574:
					if (parameters.Length == 0)
					{
						goto IL_0539;
					}
					int num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_0232;
					}
					int num2;
					ParameterInfo parameterInfo;
					IList<ExpressionReflectionDelegateFactory.Class6> list;
					bool flag;
					IList<ParameterExpression> list2;
					IList<Expression> list3;
					Type type;
					for (;;)
					{
						IL_045A:
						switch (num)
						{
						case 1:
							goto IL_0252;
						case 2:
						case 23:
							parameterInfo = parameters[num2];
							num = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
							{
								goto IL_028C;
							}
							continue;
						case 3:
							goto IL_02E3;
						case 4:
							goto IL_01DD;
						case 5:
							goto IL_0058;
						case 6:
						case 36:
							goto IL_00E8;
						case 7:
							goto IL_044E;
						case 8:
							goto IL_0076;
						case 9:
							goto IL_033F;
						case 10:
						case 50:
							goto IL_0232;
						case 11:
						case 33:
							goto IL_009D;
						case 12:
						{
							IEnumerator<ExpressionReflectionDelegateFactory.Class6> enumerator = list.GetEnumerator();
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
							{
								goto IL_033F;
							}
							continue;
						}
						case 13:
							goto IL_01C1;
						case 14:
						case 35:
						case 37:
							goto IL_017A;
						case 15:
							goto IL_0539;
						case 16:
						case 45:
							goto IL_0221;
						case 17:
							goto IL_0092;
						case 18:
							goto IL_01FE;
						case 19:
							goto IL_0574;
						case 20:
							goto IL_057C;
						case 21:
							return expression;
						case 22:
							goto IL_0107;
						case 24:
							goto IL_02F8;
						case 25:
							goto IL_0267;
						case 26:
							goto IL_01FB;
						case 27:
						case 43:
							goto IL_014F;
						case 28:
							goto IL_016E;
						case 29:
							goto IL_0160;
						case 30:
							goto IL_02EC;
						case 31:
							goto IL_02CC;
						case 32:
						case 52:
							goto IL_0006;
						case 34:
							goto IL_00BA;
						case 38:
						case 40:
						case 42:
							goto IL_012B;
						case 39:
							flag = true;
							num = 32;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
							{
								return expression;
							}
							continue;
						case 41:
							goto IL_028C;
						case 44:
							goto IL_0133;
						case 46:
							goto IL_0137;
						case 47:
							goto IL_003F;
						case 48:
							goto IL_025E;
						case 49:
							goto IL_002E;
						case 51:
							goto IL_00E0;
						}
						break;
						IL_0267:
						expression = Expression.Block(list2, list3);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							return expression;
						}
						continue;
						IL_025E:
						list3.Add(expression);
						goto IL_0267;
						IL_033F:
						try
						{
							for (;;)
							{
								IL_03F9:
								IEnumerator<ExpressionReflectionDelegateFactory.Class6> enumerator;
								if (enumerator.MoveNext())
								{
									goto IL_03C5;
								}
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
								{
									break;
								}
								for (;;)
								{
									IL_03A1:
									ExpressionReflectionDelegateFactory.Class6 @class;
									switch (num3)
									{
									case 1:
										goto IL_03F9;
									case 2:
										goto IL_03C5;
									case 3:
										if (!@class.bool_0)
										{
											goto IL_036B;
										}
										num3 = 4;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
										{
											continue;
										}
										goto IL_03E2;
									case 4:
									case 6:
										goto IL_0346;
									case 5:
										goto IL_036B;
									}
									goto Block_21;
									IL_0346:
									list2.Add(@class.object_0);
									num3 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
									{
										goto Block_19;
									}
									continue;
									IL_036B:
									list3.Add(Expression.Assign(@class.object_0, @class.expression_0));
									goto IL_0346;
								}
								IL_03E2:
								continue;
								for (;;)
								{
									IL_03C5:
									ExpressionReflectionDelegateFactory.Class6 @class = enumerator.Current;
									num3 = 3;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
									{
										goto IL_03A1;
									}
								}
							}
							Block_19:
							Block_21:
							goto IL_025E;
						}
						finally
						{
							IEnumerator<ExpressionReflectionDelegateFactory.Class6> enumerator;
							if (enumerator != null)
							{
								int num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
								{
									goto IL_043C;
								}
								IL_0424:
								enumerator.Dispose();
								num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
								{
									goto IL_044D;
								}
								IL_043C:
								switch (num4)
								{
								case 0:
									goto IL_0424;
								case 1:
									break;
								default:
									goto IL_0424;
								}
							}
							IL_044D:;
						}
						goto IL_044E;
						IL_028C:
						type = parameterInfo.ParameterType;
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
						{
							goto Block_10;
						}
					}
					goto IL_019C;
					IL_02E3:
					ParameterExpression parameterExpression;
					Expression expression2 = parameterExpression;
					goto IL_0076;
					IL_02CC:
					list.Add(new ExpressionReflectionDelegateFactory.Class6(expression2, parameterExpression, parameterInfo.IsOut));
					goto IL_02E3;
					IL_02F8:
					num2 = 0;
					goto IL_0221;
					IL_044E:
					list = new List<ExpressionReflectionDelegateFactory.Class6>();
					goto IL_02F8;
					Block_10:
					goto IL_01FB;
					IL_0006:
					Expression expression3 = Expression.Constant(num2);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						goto IL_019C;
					}
					goto IL_045A;
					IL_003F:
					if (!flag)
					{
						goto IL_0076;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						goto IL_0058;
					}
					goto IL_045A;
					IL_002E:
					Expression expression4;
					expression2 = this.method_1(expression4, type, !flag);
					goto IL_003F;
					IL_019C:
					expression4 = Expression.ArrayIndex(parameterExpression_0, expression3);
					goto IL_002E;
					IL_0058:
					parameterExpression = Expression.Variable(type);
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_045A;
					}
					IL_0076:
					Expression[] array;
					array[num2] = expression2;
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_0092;
					}
					goto IL_045A;
					IL_009D:
					if (!methodBase_0.IsConstructor)
					{
						goto IL_00E0;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_00BA;
					}
					goto IL_045A;
					IL_02EC:
					list = CollectionUtils.ArrayEmpty<ExpressionReflectionDelegateFactory.Class6>();
					goto IL_009D;
					IL_0221:
					if (num2 >= parameters.Length)
					{
						goto IL_009D;
					}
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
					{
						goto IL_01C1;
					}
					goto IL_045A;
					IL_0092:
					num2++;
					goto IL_0221;
					IL_00BA:
					expression = Expression.New((ConstructorInfo)methodBase_0, array);
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_012B;
					}
					goto IL_045A;
					IL_0107:
					expression = Expression.Call((MethodInfo)methodBase_0, array);
					num = 40;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto IL_012B;
					}
					goto IL_045A;
					IL_00E0:
					if (!methodBase_0.IsStatic)
					{
						goto IL_00E8;
					}
					goto IL_0107;
					IL_017A:
					if (list.Count <= 0)
					{
						return expression;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_019C;
					}
					goto IL_045A;
					IL_016E:
					expression = this.method_1(expression, type_0, false);
					goto IL_017A;
					IL_0133:
					MethodInfo methodInfo;
					if (methodInfo != null)
					{
						goto IL_0137;
					}
					goto IL_016E;
					IL_012B:
					methodInfo = methodBase_0 as MethodInfo;
					goto IL_0133;
					IL_00E8:
					expression = Expression.Call(this.method_1(targetParameterExpression, methodBase_0.DeclaringType, false), (MethodInfo)methodBase_0, array);
					goto IL_012B;
					IL_0160:
					expression = this.method_1(expression, type_0, false);
					goto IL_017A;
					IL_0137:
					if (methodInfo.ReturnType != typeof(void))
					{
						goto IL_0160;
					}
					IL_014F:
					expression = Expression.Block(expression, Expression.Constant(null));
					goto IL_017A;
					IL_01C1:
					list3 = new List<Expression>();
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_01DD;
					}
					goto IL_045A;
					IL_0252:
					list2 = new List<ParameterExpression>();
					goto IL_01C1;
					IL_01DD:
					type = type.GetElementType();
					num = 39;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_01FB;
					}
					goto IL_045A;
					IL_01FE:
					if (type.IsByRef)
					{
						goto IL_01DD;
					}
					num = 52;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto IL_0006;
					}
					goto IL_045A;
					IL_01FB:
					flag = false;
					goto IL_01FE;
					IL_0232:
					array = new Expression[parameters.Length];
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						goto IL_0252;
					}
					goto IL_045A;
					IL_0539:
					array = CollectionUtils.ArrayEmpty<Expression>();
					num = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_02EC;
					}
					goto IL_045A;
				}
			}
			return expression;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0004AF58 File Offset: 0x00049158
		public override Func<T> CreateDefaultConstructor<[Nullable(2)] T>(Type type)
		{
			ExpressionReflectionDelegateFactory.<>c__DisplayClass7_0<T> CS$<>8__locals1 = new ExpressionReflectionDelegateFactory.<>c__DisplayClass7_0<T>();
			CS$<>8__locals1.type_0 = type;
			ValidationUtils.ArgumentNotNull(CS$<>8__locals1.type_0, Class15.smethod_17(314787145 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			if (CS$<>8__locals1.type_0.IsAbstract())
			{
				return new Func<T>(CS$<>8__locals1.method_0);
			}
			Func<T> func;
			try
			{
				Type typeFromHandle = typeof(T);
				Expression expression = Expression.New(CS$<>8__locals1.type_0);
				expression = this.method_1(expression, typeFromHandle, false);
				func = (Func<T>)Expression.Lambda(typeof(Func<T>), expression, new ParameterExpression[0]).Compile();
			}
			catch
			{
				func = new Func<T>(CS$<>8__locals1.method_1);
			}
			return func;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0004B014 File Offset: 0x00049214
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, Class15.smethod_17(538827109 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
			Type typeFromHandle = typeof(T);
			Type typeFromHandle2 = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, Class15.smethod_17(2008568757 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
			MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException(Class15.smethod_17(676710908 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
			}
			Expression expression;
			if (getMethod.IsStatic)
			{
				expression = Expression.MakeMemberAccess(null, propertyInfo);
			}
			else
			{
				expression = Expression.MakeMemberAccess(this.method_1(parameterExpression, propertyInfo.DeclaringType, false), propertyInfo);
			}
			expression = this.method_1(expression, typeFromHandle2, false);
			return (Func<T, object>)Expression.Lambda(typeof(Func<T, object>), expression, new ParameterExpression[] { parameterExpression }).Compile();
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0004B0EC File Offset: 0x000492EC
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			ValidationUtils.ArgumentNotNull(fieldInfo, Class15.smethod_17(676710832 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
			ParameterExpression parameterExpression = Expression.Parameter(typeof(T), Class15.smethod_17(594347438 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			Expression expression;
			if (fieldInfo.IsStatic)
			{
				expression = Expression.Field(null, fieldInfo);
			}
			else
			{
				expression = Expression.Field(this.method_1(parameterExpression, fieldInfo.DeclaringType, false), fieldInfo);
			}
			expression = this.method_1(expression, typeof(object), false);
			return Expression.Lambda<Func<T, object>>(expression, new ParameterExpression[] { parameterExpression }).Compile();
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0004B188 File Offset: 0x00049388
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			ValidationUtils.ArgumentNotNull(fieldInfo, Class15.smethod_17(2056999009 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
			if (!fieldInfo.DeclaringType.IsValueType() && !fieldInfo.IsInitOnly)
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(T), Class15.smethod_17(538824035 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
				ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), Class15.smethod_17(698995872 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
				Expression expression;
				if (fieldInfo.IsStatic)
				{
					expression = Expression.Field(null, fieldInfo);
				}
				else
				{
					expression = Expression.Field(this.method_1(parameterExpression, fieldInfo.DeclaringType, false), fieldInfo);
				}
				Expression expression2 = this.method_1(parameterExpression2, expression.Type, false);
				BinaryExpression binaryExpression = Expression.Assign(expression, expression2);
				return (Action<T, object>)Expression.Lambda(typeof(Action<T, object>), binaryExpression, new ParameterExpression[] { parameterExpression, parameterExpression2 }).Compile();
			}
			return LateBoundReflectionDelegateFactory.Instance.CreateSet<T>(fieldInfo);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0004B28C File Offset: 0x0004948C
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, Class15.smethod_17(613097523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
			if (propertyInfo.DeclaringType.IsValueType())
			{
				return LateBoundReflectionDelegateFactory.Instance.CreateSet<T>(propertyInfo);
			}
			Type typeFromHandle = typeof(T);
			Type typeFromHandle2 = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, Class15.smethod_17(277620042 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			ParameterExpression parameterExpression2 = Expression.Parameter(typeFromHandle2, Class15.smethod_17(486538794 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
			Expression expression = this.method_1(parameterExpression2, propertyInfo.PropertyType, false);
			MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (setMethod == null)
			{
				throw new ArgumentException(Class15.smethod_17(2008568775 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
			}
			Expression expression2;
			if (setMethod.IsStatic)
			{
				expression2 = Expression.Call(setMethod, expression);
			}
			else
			{
				expression2 = Expression.Call(this.method_1(parameterExpression, propertyInfo.DeclaringType, false), setMethod, new Expression[] { expression });
			}
			return (Action<T, object>)Expression.Lambda(typeof(Action<T, object>), expression2, new ParameterExpression[] { parameterExpression, parameterExpression2 }).Compile();
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0004B3B8 File Offset: 0x000495B8
		private Expression method_1(Expression expression_0, Type type_0, bool bool_0 = false)
		{
			Expression expression;
			for (;;)
			{
				IL_0161:
				Type type = expression_0.Type;
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_00C6;
				}
				MethodInfo method;
				for (;;)
				{
					IL_0115:
					switch (num)
					{
					case 1:
					case 6:
					case 15:
						goto IL_0186;
					case 2:
					case 13:
						goto IL_0097;
					case 3:
						return expression_0;
					case 4:
						goto IL_0061;
					case 5:
						goto IL_0072;
					case 7:
						goto IL_00D3;
					case 8:
						if (!(method != null))
						{
							goto IL_0186;
						}
						break;
					case 9:
						goto IL_00C6;
					case 10:
						goto IL_0161;
					case 11:
						goto IL_0067;
					case 12:
						goto IL_00A5;
					case 14:
						goto IL_0006;
					case 16:
						goto IL_01AA;
					}
					expression = Expression.Condition(Expression.TypeIs(expression_0, type_0), expression, Expression.Call(method, expression_0));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto IL_0180;
					}
				}
				IL_0006:
				method = typeof(Convert).GetMethod(Class15.smethod_17(486509860 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c) + type_0.Name, new Type[] { typeof(object) });
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_0072;
				}
				goto IL_0115;
				IL_0067:
				if (type_0.IsPrimitive())
				{
					goto IL_0006;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					break;
				}
				goto IL_0115;
				IL_0061:
				if (bool_0)
				{
					goto IL_0067;
				}
				goto IL_0186;
				IL_0072:
				expression = Expression.Unbox(expression_0, type_0);
				goto IL_0061;
				IL_00A5:
				if (type_0.IsAssignableFrom(type))
				{
					break;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_0061;
				}
				goto IL_0115;
				IL_00D3:
				if (type.IsValueType())
				{
					goto IL_0097;
				}
				goto IL_00A5;
				IL_00C6:
				if (!(type == type_0))
				{
					goto IL_00D3;
				}
				break;
				IL_0097:
				if (!type_0.IsValueType())
				{
					goto Block_4;
				}
				goto IL_0072;
			}
			return expression_0;
			Block_4:
			goto IL_01AA;
			IL_0180:
			IL_0186:
			return Expression.Condition(Expression.Equal(expression_0, Expression.Constant(null, typeof(object))), Expression.Default(type_0), expression);
			IL_01AA:
			return Expression.Convert(expression_0, type_0);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0004B578 File Offset: 0x00049778
		public ExpressionReflectionDelegateFactory()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0004B5AC File Offset: 0x000497AC
		static ExpressionReflectionDelegateFactory()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0021;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				ExpressionReflectionDelegateFactory.expressionReflectionDelegateFactory_0 = new ExpressionReflectionDelegateFactory();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
				{
					break;
				}
				goto IL_0024;
				IL_0021:
				goto IL_0003;
			}
		}

		// Token: 0x04000425 RID: 1061
		private static readonly ExpressionReflectionDelegateFactory expressionReflectionDelegateFactory_0;

		// Token: 0x020000B0 RID: 176
		[Nullable(0)]
		private class Class6
		{
			// Token: 0x0600072D RID: 1837 RVA: 0x0004B60C File Offset: 0x0004980C
			public Class6(Expression expression_1, ParameterExpression parameterExpression_0, bool bool_1)
			{
				for (;;)
				{
					this.expression_0 = expression_1;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_0025;
					}
					IL_002E:
					switch (num)
					{
					case 0:
						goto IL_0025;
					case 1:
						return;
					case 2:
						continue;
					case 3:
						break;
					default:
						goto IL_0025;
					}
					IL_000A:
					this.bool_0 = bool_1;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						break;
					}
					goto IL_002E;
					IL_0025:
					this.object_0 = parameterExpression_0;
					goto IL_000A;
				}
			}

			// Token: 0x04000427 RID: 1063
			public Expression expression_0;

			// Token: 0x04000428 RID: 1064
			public object object_0;

			// Token: 0x04000429 RID: 1065
			public bool bool_0;
		}
	}
}
