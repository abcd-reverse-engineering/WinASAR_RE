using System;

// Token: 0x020003F9 RID: 1017
internal sealed class Delegate489 : MulticastDelegate
{
	// Token: 0x06001F78 RID: 8056
	public extern TimeSpan Invoke(TimeSpan timeSpan_0, TimeSpan timeSpan_1);

	// Token: 0x06001F79 RID: 8057 RVA: 0x0000B203 File Offset: 0x00009403
	public static TimeSpan smethod_0(TimeSpan timeSpan_0, TimeSpan timeSpan_1, Delegate489 delegate489_1)
	{
		return delegate489_1(timeSpan_0, timeSpan_1);
	}

	// Token: 0x06001F7A RID: 8058
	public extern Delegate489(object object_0, IntPtr intptr_0);

	// Token: 0x06001F7B RID: 8059 RVA: 0x0000B210 File Offset: 0x00009410
	static Delegate489()
	{
		Class15.smethod_14(typeof(Delegate489).TypeHandle);
	}

	// Token: 0x04000BC9 RID: 3017
	internal static Delegate489 delegate489_0;
}
