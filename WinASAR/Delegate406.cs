using System;

// Token: 0x020003A6 RID: 934
internal sealed class Delegate406 : MulticastDelegate
{
	// Token: 0x06001E2C RID: 7724
	public extern double Invoke(double double_0);

	// Token: 0x06001E2D RID: 7725 RVA: 0x0000A9A1 File Offset: 0x00008BA1
	public static double smethod_0(double double_0, Delegate406 delegate406_1)
	{
		return delegate406_1(double_0);
	}

	// Token: 0x06001E2E RID: 7726
	public extern Delegate406(object object_0, IntPtr intptr_0);

	// Token: 0x06001E2F RID: 7727 RVA: 0x0000A9AC File Offset: 0x00008BAC
	static Delegate406()
	{
		Class15.smethod_14(typeof(Delegate406).TypeHandle);
	}

	// Token: 0x04000B76 RID: 2934
	internal static Delegate406 delegate406_0;
}
