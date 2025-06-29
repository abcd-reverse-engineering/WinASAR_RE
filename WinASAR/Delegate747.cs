using System;

// Token: 0x020004FB RID: 1275
internal sealed class Delegate747 : MulticastDelegate
{
	// Token: 0x06002380 RID: 9088
	public extern object Invoke(object object_0, int[] int_0);

	// Token: 0x06002381 RID: 9089 RVA: 0x0000CBAA File Offset: 0x0000ADAA
	public static object smethod_0(object object_0, int[] int_0, Delegate747 delegate747_1)
	{
		return delegate747_1(object_0, int_0);
	}

	// Token: 0x06002382 RID: 9090
	public extern Delegate747(object object_0, IntPtr intptr_0);

	// Token: 0x06002383 RID: 9091 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
	static Delegate747()
	{
		Class15.smethod_14(typeof(Delegate747).TypeHandle);
	}

	// Token: 0x04000CCB RID: 3275
	internal static Delegate747 delegate747_0;
}
