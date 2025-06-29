using System;

// Token: 0x020003A1 RID: 929
internal sealed class Delegate401 : MulticastDelegate
{
	// Token: 0x06001E18 RID: 7704
	public extern TimeSpan Invoke(ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x06001E19 RID: 7705 RVA: 0x0000A921 File Offset: 0x00008B21
	public static TimeSpan smethod_0(ref DateTimeOffset dateTimeOffset_0, Delegate401 delegate401_1)
	{
		return delegate401_1(ref dateTimeOffset_0);
	}

	// Token: 0x06001E1A RID: 7706
	public extern Delegate401(object object_0, IntPtr intptr_0);

	// Token: 0x06001E1B RID: 7707 RVA: 0x0000A92C File Offset: 0x00008B2C
	static Delegate401()
	{
		Class15.smethod_14(typeof(Delegate401).TypeHandle);
	}

	// Token: 0x04000B71 RID: 2929
	internal static Delegate401 delegate401_0;
}
