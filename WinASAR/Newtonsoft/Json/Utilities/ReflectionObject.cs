using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CE RID: 206
	[Nullable(0)]
	[NullableContext(1)]
	internal class ReflectionObject
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00004431 File Offset: 0x00002631
		[Nullable(new byte[] { 2, 1 })]
		public ObjectConstructor<object> Creator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00004439 File Offset: 0x00002639
		public IDictionary<string, ReflectionMember> Members { get; }

		// Token: 0x06000810 RID: 2064 RVA: 0x00004441 File Offset: 0x00002641
		private ReflectionObject([Nullable(new byte[] { 2, 1 })] ObjectConstructor<object> creator)
		{
			this.Members = new Dictionary<string, ReflectionMember>();
			this.Creator = creator;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000445D File Offset: 0x0000265D
		[return: Nullable(2)]
		public object GetValue(object target, string member)
		{
			return this.Members[member].Getter(target);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
		public void SetValue(object target, string member, [Nullable(2)] object value)
		{
			for (;;)
			{
				this.Members[member].Setter(target, value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
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

		// Token: 0x06000813 RID: 2067 RVA: 0x00004476 File Offset: 0x00002676
		public Type GetType(string member)
		{
			return this.Members[member].MemberType;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00004489 File Offset: 0x00002689
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return ReflectionObject.Create(t, null, memberNames);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0004EB08 File Offset: 0x0004CD08
		public static ReflectionObject Create(Type t, [Nullable(2)] MethodBase creator, params string[] memberNames)
		{
			ReflectionObject reflectionObject;
			MemberInfo memberInfo;
			string text;
			for (;;)
			{
				IL_042E:
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				int num = 37;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_00BC;
				}
				MemberTypes memberTypes;
				ReflectionMember reflectionMember;
				for (;;)
				{
					IL_0363:
					ObjectConstructor<object> objectConstructor;
					switch (num)
					{
					case 1:
						goto IL_0139;
					case 2:
					case 15:
						goto IL_0043;
					case 3:
						goto IL_0450;
					case 4:
						goto IL_0014;
					case 5:
						goto IL_01BA;
					case 6:
					case 10:
					case 18:
					case 30:
					case 43:
						goto IL_00BC;
					case 7:
						return reflectionObject;
					case 8:
						goto IL_00EF;
					case 9:
						goto IL_019C;
					case 11:
						goto IL_023C;
					case 12:
						goto IL_0100;
					case 13:
						if (memberTypes == MemberTypes.Method)
						{
							goto IL_02A9;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
						{
							continue;
						}
						break;
					case 14:
						goto IL_0155;
					case 16:
						goto IL_02B2;
					case 17:
					case 28:
						goto IL_021C;
					case 19:
						goto IL_00DF;
					case 20:
					case 29:
					case 41:
						goto IL_025C;
					case 21:
						goto IL_0313;
					case 22:
						goto IL_008E;
					case 23:
						goto IL_0069;
					case 24:
						goto IL_004A;
					case 25:
						goto IL_0062;
					case 26:
						goto IL_0192;
					case 27:
						goto IL_0313;
					case 31:
						reflectionMember.Getter = new Func<object, object>(CS$<>8__locals1.method_0);
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
						{
							goto IL_0014;
						}
						continue;
					case 32:
						goto IL_0107;
					case 33:
						goto IL_0285;
					case 34:
						goto IL_027D;
					case 35:
						goto IL_0173;
					case 36:
					case 42:
						goto IL_00F5;
					case 37:
						objectConstructor = null;
						num = 40;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							goto IL_01FE;
						}
						continue;
					case 38:
						goto IL_042E;
					case 39:
						goto IL_027A;
					case 40:
						goto IL_02A9;
					case 44:
						goto IL_01FE;
					case 45:
						goto IL_000F;
					case 46:
						goto IL_01AC;
					case 47:
						goto IL_0006;
					}
					goto Block_19;
					IL_0014:
					MethodInfo methodInfo;
					if (!(methodInfo.ReturnType != typeof(void)))
					{
						goto IL_0043;
					}
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_0062;
					}
					continue;
					IL_000F:
					ParameterInfo[] parameters;
					if (parameters.Length == 0)
					{
						goto IL_0014;
					}
					goto IL_0043;
					IL_0006:
					parameters = methodInfo.GetParameters();
					goto IL_000F;
					IL_02B2:
					if (!methodInfo.IsPublic)
					{
						goto Block_13;
					}
					goto IL_0006;
					IL_02A9:
					methodInfo = (MethodInfo)memberInfo;
					goto IL_02B2;
					IL_0069:
					ReflectionObject.<>c__DisplayClass11_2 CS$<>8__locals2;
					CS$<>8__locals2.methodCall_0 = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_008E;
					}
					continue;
					IL_0062:
					CS$<>8__locals2 = new ReflectionObject.<>c__DisplayClass11_2();
					goto IL_0069;
					IL_004A:
					if (methodInfo.ReturnType == typeof(void))
					{
						goto IL_0062;
					}
					goto IL_00BC;
					IL_0043:
					if (parameters.Length == 1)
					{
						goto IL_004A;
					}
					goto IL_00BC;
					IL_008E:
					reflectionMember.Setter = new Action<object, object>(CS$<>8__locals2.method_0);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto Block_3;
					}
					continue;
					IL_01FE:
					if (creator != null)
					{
						goto IL_0285;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						continue;
					}
					IL_021C:
					if (ReflectionUtils.HasDefaultConstructor(t, false))
					{
						goto IL_023C;
					}
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						continue;
					}
					IL_025C:
					reflectionObject = new ReflectionObject(objectConstructor);
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						break;
					}
					continue;
					IL_023C:
					ReflectionObject.<>c__DisplayClass11_0 CS$<>8__locals3 = new ReflectionObject.<>c__DisplayClass11_0();
					CS$<>8__locals3.func_0 = reflectionDelegateFactory.CreateDefaultConstructor<object>(t);
					objectConstructor = new ObjectConstructor<object>(CS$<>8__locals3.method_0);
					goto IL_025C;
					IL_0285:
					objectConstructor = reflectionDelegateFactory.CreateParameterizedConstructor(creator);
					num = 29;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
					{
						goto Block_12;
					}
					continue;
					IL_0313:
					CS$<>8__locals1.methodCall_0 = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto Block_16;
					}
				}
				IL_027D:
				int num2 = 0;
				goto IL_00F5;
				IL_027A:
				goto IL_027D;
				Block_12:
				Block_13:
				Block_16:
				goto IL_00BC;
				IL_0354:
				if (memberTypes == MemberTypes.Property)
				{
					goto IL_0192;
				}
				break;
				Block_19:
				goto IL_0354;
				IL_00BC:
				reflectionMember.MemberType = ReflectionUtils.GetMemberUnderlyingType(memberInfo);
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_00DF;
				}
				goto IL_0363;
				IL_01AC:
				if (ReflectionUtils.CanSetMemberValue(memberInfo, false, false))
				{
					goto IL_01BA;
				}
				goto IL_00BC;
				IL_0192:
				if (ReflectionUtils.CanReadMemberValue(memberInfo, false))
				{
					goto IL_019C;
				}
				goto IL_01AC;
				IL_0173:
				if (memberTypes == MemberTypes.Field)
				{
					goto IL_0192;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
				{
					goto IL_00BC;
				}
				goto IL_0363;
				IL_0107:
				MemberInfo[] member = t.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
				if (member.Length != 1)
				{
					goto Block_4;
				}
				memberInfo = member.Single<MemberInfo>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					goto IL_0139;
				}
				goto IL_0363;
				IL_0100:
				text = memberNames[num2];
				goto IL_0107;
				IL_00F5:
				if (num2 < memberNames.Length)
				{
					goto IL_0100;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto Block_8;
				}
				goto IL_0363;
				IL_00EF:
				num2++;
				goto IL_00F5;
				IL_00DF:
				reflectionObject.Members[text] = reflectionMember;
				goto IL_00EF;
				IL_0139:
				reflectionMember = new ReflectionMember();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_0363;
				}
				IL_0155:
				memberTypes = memberInfo.MemberType();
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_0173;
				}
				goto IL_0363;
				IL_01BA:
				reflectionMember.Setter = reflectionDelegateFactory.CreateSet<object>(memberInfo);
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
				{
					goto Block_7;
				}
				goto IL_0363;
				IL_019C:
				reflectionMember.Getter = reflectionDelegateFactory.CreateGet<object>(memberInfo);
				goto IL_01AC;
			}
			Block_3:
			goto IL_0450;
			Block_4:
			throw new ArgumentException(Class15.smethod_17(2071424762 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).FormatWith(CultureInfo.InvariantCulture, text));
			Block_7:
			Block_8:
			return reflectionObject;
			IL_0450:
			throw new ArgumentException(Class15.smethod_17(1396547756 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, memberInfo.MemberType(), memberInfo.Name));
		}

		// Token: 0x04000479 RID: 1145
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private readonly ObjectConstructor<object> objectConstructor_0;

		// Token: 0x0400047A RID: 1146
		[CompilerGenerated]
		private readonly IDictionary<string, ReflectionMember> idictionary_0;
	}
}
