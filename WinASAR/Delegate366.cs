using System;

// Token: 0x0200037E RID: 894
internal sealed class Delegate366 : MulticastDelegate
{
	// Token: 0x06001D8C RID: 7564
	public extern DateTime Invoke(ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x06001D8D RID: 7565 RVA: 0x0000A595 File Offset: 0x00008795
	public static DateTime smethod_0(ref DateTimeOffset dateTimeOffset_0, Delegate366 delegate366_1)
	{
		return delegate366_1(ref dateTimeOffset_0);
	}

	// Token: 0x06001D8E RID: 7566
	public extern Delegate366(object object_0, IntPtr intptr_0);

	// Token: 0x06001D8F RID: 7567 RVA: 0x0000A5A0 File Offset: 0x000087A0
	static Delegate366()
	{
		Class15.smethod_14(typeof(Delegate366).TypeHandle);
	}

	// Token: 0x04000B4E RID: 2894
	internal static Delegate366 delegate366_0;
}
