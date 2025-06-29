using System;

// Token: 0x02000284 RID: 644
internal sealed class Delegate116 : MulticastDelegate
{
	// Token: 0x060019A4 RID: 6564
	public extern string Invoke(ref char char_0);

	// Token: 0x060019A5 RID: 6565 RVA: 0x00008CBD File Offset: 0x00006EBD
	public static string smethod_0(ref char char_0, Delegate116 delegate116_1)
	{
		return delegate116_1(ref char_0);
	}

	// Token: 0x060019A6 RID: 6566
	public extern Delegate116(object object_0, IntPtr intptr_0);

	// Token: 0x060019A7 RID: 6567 RVA: 0x00008CC8 File Offset: 0x00006EC8
	static Delegate116()
	{
		Class15.smethod_14(typeof(Delegate116).TypeHandle);
	}

	// Token: 0x04000A54 RID: 2644
	internal static Delegate116 delegate116_0;
}
