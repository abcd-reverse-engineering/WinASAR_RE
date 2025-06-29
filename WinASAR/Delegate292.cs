using System;
using System.Reflection;

// Token: 0x02000334 RID: 820
internal sealed class Delegate292 : MulticastDelegate
{
	// Token: 0x06001C64 RID: 7268
	public extern PropertyInfo Invoke(object object_0, string string_0);

	// Token: 0x06001C65 RID: 7269 RVA: 0x00009E0B File Offset: 0x0000800B
	public static PropertyInfo smethod_0(object object_0, string string_0, Delegate292 delegate292_1)
	{
		return delegate292_1(object_0, string_0);
	}

	// Token: 0x06001C66 RID: 7270
	public extern Delegate292(object object_0, IntPtr intptr_0);

	// Token: 0x06001C67 RID: 7271 RVA: 0x00009E18 File Offset: 0x00008018
	static Delegate292()
	{
		Class15.smethod_14(typeof(Delegate292).TypeHandle);
	}

	// Token: 0x04000B04 RID: 2820
	internal static Delegate292 delegate292_0;
}
