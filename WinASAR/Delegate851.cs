using System;

// Token: 0x02000563 RID: 1379
internal sealed class Delegate851 : MulticastDelegate
{
	// Token: 0x06002520 RID: 9504
	public extern DateTime Invoke(ref DateTime dateTime_0, double double_0);

	// Token: 0x06002521 RID: 9505 RVA: 0x0000D5FA File Offset: 0x0000B7FA
	public static DateTime smethod_0(ref DateTime dateTime_0, double double_0, Delegate851 delegate851_1)
	{
		return delegate851_1(ref dateTime_0, double_0);
	}

	// Token: 0x06002522 RID: 9506
	public extern Delegate851(object object_0, IntPtr intptr_0);

	// Token: 0x06002523 RID: 9507 RVA: 0x0000D607 File Offset: 0x0000B807
	static Delegate851()
	{
		Class15.smethod_14(typeof(Delegate851).TypeHandle);
	}

	// Token: 0x04000D33 RID: 3379
	internal static Delegate851 delegate851_0;
}
