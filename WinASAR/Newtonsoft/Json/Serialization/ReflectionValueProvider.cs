using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000125 RID: 293
	[Nullable(0)]
	[NullableContext(1)]
	public class ReflectionValueProvider : IValueProvider
	{
		// Token: 0x06000BD5 RID: 3029 RVA: 0x00069860 File Offset: 0x00067A60
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(memberInfo, Class15.smethod_17(432130257 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
				{
					goto IL_000A;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				IL_000A:
				this.memberInfo_0 = memberInfo;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000698D4 File Offset: 0x00067AD4
		public void SetValue(object target, [Nullable(2)] object value)
		{
			try
			{
				ReflectionUtils.SetMemberValue(this.memberInfo_0, target, value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					switch (num)
					{
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(197561675 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00069978 File Offset: 0x00067B78
		[return: Nullable(2)]
		public object GetValue(object target)
		{
			object memberValue;
			try
			{
				PropertyInfo propertyInfo = this.memberInfo_0 as PropertyInfo;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
				{
					goto IL_0044;
				}
				goto IL_004B;
				IL_0022:
				if (!propertyInfo.PropertyType.IsByRef)
				{
					goto IL_008B;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0064;
				}
				goto IL_004B;
				IL_0044:
				if (propertyInfo != null)
				{
					goto IL_0022;
				}
				goto IL_008B;
				IL_004B:
				switch (num)
				{
				case 0:
					goto IL_0044;
				case 1:
					break;
				case 2:
					return memberValue;
				case 3:
					goto IL_0022;
				default:
					goto IL_0044;
				}
				IL_0064:
				throw new InvalidOperationException(Class15.smethod_17(1788761969 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, propertyInfo));
				IL_008B:
				memberValue = ReflectionUtils.GetMemberValue(this.memberInfo_0, target);
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(1570977393 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
			return memberValue;
		}

		// Token: 0x040005CA RID: 1482
		private readonly MemberInfo memberInfo_0;
	}
}
