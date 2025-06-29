using System;

// Token: 0x020005A7 RID: 1447
internal sealed class Delegate919 : MulticastDelegate
{
	// Token: 0x06002630 RID: 9776
	public extern string Invoke(object object_0);

	// Token: 0x06002631 RID: 9777 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
	public static string smethod_0(object object_0, Delegate919 delegate919_1)
	{
		return delegate919_1(object_0);
	}

	// Token: 0x06002632 RID: 9778
	public extern Delegate919(object object_0, IntPtr intptr_0);

	// Token: 0x06002633 RID: 9779 RVA: 0x0000DCAB File Offset: 0x0000BEAB
	static Delegate919()
	{
		Class15.smethod_14(typeof(Delegate919).TypeHandle);
	}

	// Token: 0x04000D77 RID: 3447
	internal static Delegate919 delegate919_0;
}
