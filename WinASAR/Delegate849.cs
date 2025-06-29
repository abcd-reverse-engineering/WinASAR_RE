using System;

// Token: 0x02000561 RID: 1377
internal sealed class Delegate849 : MulticastDelegate
{
	// Token: 0x06002518 RID: 9496
	public extern TimeSpan Invoke(DateTimeOffset dateTimeOffset_0, DateTimeOffset dateTimeOffset_1);

	// Token: 0x06002519 RID: 9497 RVA: 0x0000D5C6 File Offset: 0x0000B7C6
	public static TimeSpan smethod_0(DateTimeOffset dateTimeOffset_0, DateTimeOffset dateTimeOffset_1, Delegate849 delegate849_1)
	{
		return delegate849_1(dateTimeOffset_0, dateTimeOffset_1);
	}

	// Token: 0x0600251A RID: 9498
	public extern Delegate849(object object_0, IntPtr intptr_0);

	// Token: 0x0600251B RID: 9499 RVA: 0x0000D5D3 File Offset: 0x0000B7D3
	static Delegate849()
	{
		Class15.smethod_14(typeof(Delegate849).TypeHandle);
	}

	// Token: 0x04000D31 RID: 3377
	internal static Delegate849 delegate849_0;
}
