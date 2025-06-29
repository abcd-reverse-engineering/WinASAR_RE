using System;
using System.Reflection;

// Token: 0x020004B8 RID: 1208
internal sealed class Delegate680 : MulticastDelegate
{
	// Token: 0x06002274 RID: 8820
	public extern PropertyInfo[] Invoke(object object_0, BindingFlags bindingFlags_0);

	// Token: 0x06002275 RID: 8821 RVA: 0x0000C526 File Offset: 0x0000A726
	public static PropertyInfo[] smethod_0(object object_0, BindingFlags bindingFlags_0, Delegate680 delegate680_1)
	{
		return delegate680_1(object_0, bindingFlags_0);
	}

	// Token: 0x06002276 RID: 8822
	public extern Delegate680(object object_0, IntPtr intptr_0);

	// Token: 0x06002277 RID: 8823 RVA: 0x0000C533 File Offset: 0x0000A733
	static Delegate680()
	{
		Class15.smethod_14(typeof(Delegate680).TypeHandle);
	}

	// Token: 0x04000C88 RID: 3208
	internal static Delegate680 delegate680_0;
}
