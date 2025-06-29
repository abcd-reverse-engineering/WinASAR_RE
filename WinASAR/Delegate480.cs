using System;

// Token: 0x020003F0 RID: 1008
internal sealed class Delegate480 : MulticastDelegate
{
	// Token: 0x06001F54 RID: 8020
	public extern DateTime Invoke(ref DateTime dateTime_0, long long_0);

	// Token: 0x06001F55 RID: 8021 RVA: 0x0000B113 File Offset: 0x00009313
	public static DateTime smethod_0(ref DateTime dateTime_0, long long_0, Delegate480 delegate480_1)
	{
		return delegate480_1(ref dateTime_0, long_0);
	}

	// Token: 0x06001F56 RID: 8022
	public extern Delegate480(object object_0, IntPtr intptr_0);

	// Token: 0x06001F57 RID: 8023 RVA: 0x0000B120 File Offset: 0x00009320
	static Delegate480()
	{
		Class15.smethod_14(typeof(Delegate480).TypeHandle);
	}

	// Token: 0x04000BC0 RID: 3008
	internal static Delegate480 delegate480_0;
}
