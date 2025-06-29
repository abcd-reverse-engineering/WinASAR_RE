using System;

// Token: 0x02000560 RID: 1376
internal sealed class Delegate848 : MulticastDelegate
{
	// Token: 0x06002514 RID: 9492
	public extern double Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x06002515 RID: 9493 RVA: 0x0000D5AE File Offset: 0x0000B7AE
	public static double smethod_0(ref TimeSpan timeSpan_0, Delegate848 delegate848_1)
	{
		return delegate848_1(ref timeSpan_0);
	}

	// Token: 0x06002516 RID: 9494
	public extern Delegate848(object object_0, IntPtr intptr_0);

	// Token: 0x06002517 RID: 9495 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
	static Delegate848()
	{
		Class15.smethod_14(typeof(Delegate848).TypeHandle);
	}

	// Token: 0x04000D30 RID: 3376
	internal static Delegate848 delegate848_0;
}
