using System;
using System.Reflection;

// Token: 0x02000623 RID: 1571
internal sealed class Delegate1043 : MulticastDelegate
{
	// Token: 0x06002820 RID: 10272
	public extern MemberInfo Invoke(object object_0, int int_0);

	// Token: 0x06002821 RID: 10273 RVA: 0x0000E8FE File Offset: 0x0000CAFE
	public static MemberInfo smethod_0(object object_0, int int_0, Delegate1043 delegate1043_1)
	{
		return delegate1043_1(object_0, int_0);
	}

	// Token: 0x06002822 RID: 10274
	public extern Delegate1043(object object_0, IntPtr intptr_0);

	// Token: 0x06002823 RID: 10275 RVA: 0x0000E90B File Offset: 0x0000CB0B
	static Delegate1043()
	{
		Class15.smethod_14(typeof(Delegate1043).TypeHandle);
	}

	// Token: 0x04000DF3 RID: 3571
	internal static Delegate1043 delegate1043_0;
}
