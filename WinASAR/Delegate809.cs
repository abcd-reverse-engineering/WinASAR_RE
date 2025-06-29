using System;

// Token: 0x02000539 RID: 1337
internal sealed class Delegate809 : MulticastDelegate
{
	// Token: 0x06002478 RID: 9336
	public extern int Invoke(ref TimeSpan timeSpan_0, TimeSpan timeSpan_1);

	// Token: 0x06002479 RID: 9337 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
	public static int smethod_0(ref TimeSpan timeSpan_0, TimeSpan timeSpan_1, Delegate809 delegate809_1)
	{
		return delegate809_1(ref timeSpan_0, timeSpan_1);
	}

	// Token: 0x0600247A RID: 9338
	public extern Delegate809(object object_0, IntPtr intptr_0);

	// Token: 0x0600247B RID: 9339 RVA: 0x0000D1D1 File Offset: 0x0000B3D1
	static Delegate809()
	{
		Class15.smethod_14(typeof(Delegate809).TypeHandle);
	}

	// Token: 0x04000D09 RID: 3337
	internal static Delegate809 delegate809_0;
}
