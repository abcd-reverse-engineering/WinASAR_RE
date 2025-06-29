using System;

// Token: 0x0200055F RID: 1375
internal sealed class Delegate847 : MulticastDelegate
{
	// Token: 0x06002510 RID: 9488
	public extern TimeSpan Invoke(DateTime dateTime_0, DateTime dateTime_1);

	// Token: 0x06002511 RID: 9489 RVA: 0x0000D594 File Offset: 0x0000B794
	public static TimeSpan smethod_0(DateTime dateTime_0, DateTime dateTime_1, Delegate847 delegate847_1)
	{
		return delegate847_1(dateTime_0, dateTime_1);
	}

	// Token: 0x06002512 RID: 9490
	public extern Delegate847(object object_0, IntPtr intptr_0);

	// Token: 0x06002513 RID: 9491 RVA: 0x0000D5A1 File Offset: 0x0000B7A1
	static Delegate847()
	{
		Class15.smethod_14(typeof(Delegate847).TypeHandle);
	}

	// Token: 0x04000D2F RID: 3375
	internal static Delegate847 delegate847_0;
}
