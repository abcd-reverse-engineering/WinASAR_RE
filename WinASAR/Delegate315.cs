using System;

// Token: 0x0200034B RID: 843
internal sealed class Delegate315 : MulticastDelegate
{
	// Token: 0x06001CC0 RID: 7360
	public extern int Invoke(ref int int_0);

	// Token: 0x06001CC1 RID: 7361 RVA: 0x0000A05B File Offset: 0x0000825B
	public static int smethod_0(ref int int_0, Delegate315 delegate315_1)
	{
		return delegate315_1(ref int_0);
	}

	// Token: 0x06001CC2 RID: 7362
	public extern Delegate315(object object_0, IntPtr intptr_0);

	// Token: 0x06001CC3 RID: 7363 RVA: 0x0000A066 File Offset: 0x00008266
	static Delegate315()
	{
		Class15.smethod_14(typeof(Delegate315).TypeHandle);
	}

	// Token: 0x04000B1B RID: 2843
	internal static Delegate315 delegate315_0;
}
