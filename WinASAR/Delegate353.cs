using System;

// Token: 0x02000371 RID: 881
internal sealed class Delegate353 : MulticastDelegate
{
	// Token: 0x06001D58 RID: 7512
	public extern byte[] Invoke(ref Guid guid_0);

	// Token: 0x06001D59 RID: 7513 RVA: 0x0000A445 File Offset: 0x00008645
	public static byte[] smethod_0(ref Guid guid_0, Delegate353 delegate353_1)
	{
		return delegate353_1(ref guid_0);
	}

	// Token: 0x06001D5A RID: 7514
	public extern Delegate353(object object_0, IntPtr intptr_0);

	// Token: 0x06001D5B RID: 7515 RVA: 0x0000A450 File Offset: 0x00008650
	static Delegate353()
	{
		Class15.smethod_14(typeof(Delegate353).TypeHandle);
	}

	// Token: 0x04000B41 RID: 2881
	internal static Delegate353 delegate353_0;
}
