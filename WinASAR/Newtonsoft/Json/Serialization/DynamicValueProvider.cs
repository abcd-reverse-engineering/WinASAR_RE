using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F5 RID: 245
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicValueProvider : IValueProvider
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x00057EA0 File Offset: 0x000560A0
		public DynamicValueProvider(MemberInfo memberInfo)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
			{
				goto IL_0049;
			}
			do
			{
				IL_001A:
				ValidationUtils.ArgumentNotNull(memberInfo, Class15.smethod_17(926357809 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0);
			IL_0049:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				this.memberInfo_0 = memberInfo;
				break;
			case 2:
				break;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00057F14 File Offset: 0x00056114
		public void SetValue(object target, [Nullable(2)] object value)
		{
			try
			{
				if (this.action_0 != null)
				{
					goto IL_0047;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_0031;
				}
				IL_001D:
				switch (num)
				{
				case 0:
					goto IL_0066;
				case 1:
					IL_0031:
					this.action_0 = DynamicReflectionDelegateFactory.Instance.CreateSet<object>(this.memberInfo_0);
					break;
				case 2:
					break;
				default:
					goto IL_0066;
				}
				IL_0047:
				this.action_0(target, value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_001D;
				}
				IL_0066:;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(1042117101 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00057FF0 File Offset: 0x000561F0
		[return: Nullable(2)]
		public object GetValue(object target)
		{
			object obj;
			try
			{
				if (this.func_0 != null)
				{
					goto IL_0059;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0059;
				}
				for (;;)
				{
					IL_0044:
					switch (num)
					{
					case 1:
						goto IL_0059;
					case 2:
						this.func_0 = DynamicReflectionDelegateFactory.Instance.CreateGet<object>(this.memberInfo_0);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
						{
							continue;
						}
						goto IL_0058;
					}
					break;
				}
				goto IL_0079;
				IL_0058:
				IL_0059:
				obj = this.func_0(target);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0044;
				}
				IL_0079:;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(1396551854 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
			return obj;
		}

		// Token: 0x040004EB RID: 1259
		private readonly MemberInfo memberInfo_0;

		// Token: 0x040004EC RID: 1260
		[Nullable(new byte[] { 2, 1, 2 })]
		private Func<object, object> func_0;

		// Token: 0x040004ED RID: 1261
		[Nullable(new byte[] { 2, 1, 2 })]
		private Action<object, object> action_0;
	}
}
