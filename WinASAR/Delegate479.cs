using System;

// Token: 0x020003EF RID: 1007
internal sealed class Delegate479 : MulticastDelegate
{
	// Token: 0x06001F50 RID: 8016
	public extern long Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x06001F51 RID: 8017 RVA: 0x0000B0FB File Offset: 0x000092FB
	public static long smethod_0(ref TimeSpan timeSpan_0, Delegate479 delegate479_1)
	{
		return delegate479_1(ref timeSpan_0);
	}

	// Token: 0x06001F52 RID: 8018
	public extern Delegate479(object object_0, IntPtr intptr_0);

	// Token: 0x06001F53 RID: 8019 RVA: 0x0000B106 File Offset: 0x00009306
	static Delegate479()
	{
		Class15.smethod_14(typeof(Delegate479).TypeHandle);
	}

	// Token: 0x04000BBF RID: 3007
	internal static Delegate479 delegate479_0;
}
