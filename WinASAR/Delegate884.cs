using System;

// Token: 0x02000584 RID: 1412
internal sealed class Delegate884 : MulticastDelegate
{
	// Token: 0x060025A4 RID: 9636
	public extern int Invoke(object object_0);

	// Token: 0x060025A5 RID: 9637 RVA: 0x0000D944 File Offset: 0x0000BB44
	public static int smethod_0(object object_0, Delegate884 delegate884_1)
	{
		return delegate884_1(object_0);
	}

	// Token: 0x060025A6 RID: 9638
	public extern Delegate884(object object_0, IntPtr intptr_0);

	// Token: 0x060025A7 RID: 9639 RVA: 0x0000D94F File Offset: 0x0000BB4F
	static Delegate884()
	{
		Class15.smethod_14(typeof(Delegate884).TypeHandle);
	}

	// Token: 0x04000D54 RID: 3412
	internal static Delegate884 delegate884_0;
}
