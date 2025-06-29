using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CC RID: 204
	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x0004E93C File Offset: 0x0004CB3C
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public Func<T, object> CreateGet<[Nullable(2)] T>(MemberInfo memberInfo)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo != null)
			{
				if (propertyInfo.PropertyType.IsByRef)
				{
					throw new InvalidOperationException(Class15.smethod_17(1424567846 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, propertyInfo));
				}
				return this.CreateGet<T>(propertyInfo);
			}
			else
			{
				FieldInfo fieldInfo = memberInfo as FieldInfo;
				if (fieldInfo == null)
				{
					throw new Exception(Class15.smethod_17(1793882286 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, memberInfo));
				}
				return this.CreateGet<T>(fieldInfo);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0004E9C8 File Offset: 0x0004CBC8
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public Action<T, object> CreateSet<[Nullable(2)] T>(MemberInfo memberInfo)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo != null)
			{
				return this.CreateSet<T>(propertyInfo);
			}
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			if (fieldInfo == null)
			{
				throw new Exception(Class15.smethod_17(1760319431 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039).FormatWith(CultureInfo.InvariantCulture, memberInfo));
			}
			return this.CreateSet<T>(fieldInfo);
		}

		// Token: 0x060007F9 RID: 2041
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public abstract MethodCall<T, object> CreateMethodCall<[Nullable(2)] T>(MethodBase method);

		// Token: 0x060007FA RID: 2042
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x060007FB RID: 2043
		public abstract Func<T> CreateDefaultConstructor<[Nullable(2)] T>(Type type);

		// Token: 0x060007FC RID: 2044
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public abstract Func<T, object> CreateGet<[Nullable(2)] T>(PropertyInfo propertyInfo);

		// Token: 0x060007FD RID: 2045
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public abstract Func<T, object> CreateGet<[Nullable(2)] T>(FieldInfo fieldInfo);

		// Token: 0x060007FE RID: 2046
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public abstract Action<T, object> CreateSet<[Nullable(2)] T>(FieldInfo fieldInfo);

		// Token: 0x060007FF RID: 2047
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public abstract Action<T, object> CreateSet<[Nullable(2)] T>(PropertyInfo propertyInfo);

		// Token: 0x06000800 RID: 2048 RVA: 0x0004EA20 File Offset: 0x0004CC20
		protected ReflectionDelegateFactory()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
