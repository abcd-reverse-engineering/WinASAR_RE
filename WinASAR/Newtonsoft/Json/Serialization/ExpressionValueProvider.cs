using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F8 RID: 248
	[Nullable(0)]
	[NullableContext(1)]
	public class ExpressionValueProvider : IValueProvider
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x00058248 File Offset: 0x00056448
		public ExpressionValueProvider(MemberInfo memberInfo)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
			{
				do
				{
					switch (num)
					{
					case 1:
						ValidationUtils.ArgumentNotNull(memberInfo, Class15.smethod_17(613089691 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
						goto IL_001C;
					case 2:
						goto IL_001C;
					}
					break;
					IL_001C:
					this.memberInfo_0 = memberInfo;
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000582C0 File Offset: 0x000564C0
		public void SetValue(object target, [Nullable(2)] object value)
		{
			try
			{
				if (this.action_0 == null)
				{
					goto IL_0035;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_005D;
				}
				IL_001D:
				switch (num)
				{
				case 2:
					goto IL_006A;
				case 3:
					IL_0035:
					this.action_0 = ExpressionReflectionDelegateFactory.Instance.CreateSet<object>(this.memberInfo_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto IL_001D;
					}
					break;
				}
				IL_005D:
				this.action_0(target, value);
				IL_006A:;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(974428553 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000583A0 File Offset: 0x000565A0
		[return: Nullable(2)]
		public object GetValue(object target)
		{
			object obj;
			try
			{
				if (this.func_0 != null)
				{
					goto IL_0044;
				}
				IL_0009:
				this.func_0 = ExpressionReflectionDelegateFactory.Instance.CreateGet<object>(this.memberInfo_0);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					goto IL_0067;
				}
				IL_0030:
				switch (num)
				{
				case 1:
					IL_0044:
					obj = this.func_0(target);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						goto IL_0030;
					}
					break;
				case 2:
					goto IL_0009;
				}
				IL_0067:;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					switch (num2)
					{
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(974428249 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).FormatWith(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), ex);
			}
			return obj;
		}

		// Token: 0x040004F9 RID: 1273
		private readonly MemberInfo memberInfo_0;

		// Token: 0x040004FA RID: 1274
		[Nullable(new byte[] { 2, 1, 2 })]
		private Func<object, object> func_0;

		// Token: 0x040004FB RID: 1275
		[Nullable(new byte[] { 2, 1, 2 })]
		private Action<object, object> action_0;
	}
}
