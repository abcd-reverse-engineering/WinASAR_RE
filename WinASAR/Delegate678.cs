using System;
using System.Reflection;

// Token: 0x020004B6 RID: 1206
internal sealed class Delegate678 : MulticastDelegate
{
	// Token: 0x0600226C RID: 8812
	public extern MemberInfo[] Invoke(object object_0, string string_0, MemberTypes memberTypes_0, BindingFlags bindingFlags_0);

	// Token: 0x0600226D RID: 8813 RVA: 0x0000C4EE File Offset: 0x0000A6EE
	public static MemberInfo[] smethod_0(object object_0, string string_0, MemberTypes memberTypes_0, BindingFlags bindingFlags_0, Delegate678 delegate678_1)
	{
		return delegate678_1(object_0, string_0, memberTypes_0, bindingFlags_0);
	}

	// Token: 0x0600226E RID: 8814
	public extern Delegate678(object object_0, IntPtr intptr_0);

	// Token: 0x0600226F RID: 8815 RVA: 0x0000C4FF File Offset: 0x0000A6FF
	static Delegate678()
	{
		Class15.smethod_14(typeof(Delegate678).TypeHandle);
	}

	// Token: 0x04000C86 RID: 3206
	internal static Delegate678 delegate678_0;
}
