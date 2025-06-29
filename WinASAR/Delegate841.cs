using System;

// Token: 0x02000559 RID: 1369
internal sealed class Delegate841 : MulticastDelegate
{
	// Token: 0x060024F8 RID: 9464
	public extern DateTimeOffset Invoke(ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x060024F9 RID: 9465 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
	public static DateTimeOffset smethod_0(ref DateTimeOffset dateTimeOffset_0, Delegate841 delegate841_1)
	{
		return delegate841_1(ref dateTimeOffset_0);
	}

	// Token: 0x060024FA RID: 9466
	public extern Delegate841(object object_0, IntPtr intptr_0);

	// Token: 0x060024FB RID: 9467 RVA: 0x0000D4FB File Offset: 0x0000B6FB
	static Delegate841()
	{
		Class15.smethod_14(typeof(Delegate841).TypeHandle);
	}

	// Token: 0x04000D29 RID: 3369
	internal static Delegate841 delegate841_0;
}
