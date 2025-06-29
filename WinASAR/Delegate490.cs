using System;

// Token: 0x020003FA RID: 1018
internal sealed class Delegate490 : MulticastDelegate
{
	// Token: 0x06001F7C RID: 8060
	public extern TimeSpan Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x06001F7D RID: 8061 RVA: 0x0000B21D File Offset: 0x0000941D
	public static TimeSpan smethod_0(ref TimeSpan timeSpan_0, Delegate490 delegate490_1)
	{
		return delegate490_1(ref timeSpan_0);
	}

	// Token: 0x06001F7E RID: 8062
	public extern Delegate490(object object_0, IntPtr intptr_0);

	// Token: 0x06001F7F RID: 8063 RVA: 0x0000B228 File Offset: 0x00009428
	static Delegate490()
	{
		Class15.smethod_14(typeof(Delegate490).TypeHandle);
	}

	// Token: 0x04000BCA RID: 3018
	internal static Delegate490 delegate490_0;
}
