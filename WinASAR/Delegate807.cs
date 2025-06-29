using System;

// Token: 0x02000537 RID: 1335
internal sealed class Delegate807 : MulticastDelegate
{
	// Token: 0x06002470 RID: 9328
	public extern int Invoke(ref DateTimeOffset dateTimeOffset_0, DateTimeOffset dateTimeOffset_1);

	// Token: 0x06002471 RID: 9329 RVA: 0x0000D190 File Offset: 0x0000B390
	public static int smethod_0(ref DateTimeOffset dateTimeOffset_0, DateTimeOffset dateTimeOffset_1, Delegate807 delegate807_1)
	{
		return delegate807_1(ref dateTimeOffset_0, dateTimeOffset_1);
	}

	// Token: 0x06002472 RID: 9330
	public extern Delegate807(object object_0, IntPtr intptr_0);

	// Token: 0x06002473 RID: 9331 RVA: 0x0000D19D File Offset: 0x0000B39D
	static Delegate807()
	{
		Class15.smethod_14(typeof(Delegate807).TypeHandle);
	}

	// Token: 0x04000D07 RID: 3335
	internal static Delegate807 delegate807_0;
}
