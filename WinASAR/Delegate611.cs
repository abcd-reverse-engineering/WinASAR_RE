using System;

// Token: 0x02000473 RID: 1139
internal sealed class Delegate611 : MulticastDelegate
{
	// Token: 0x06002160 RID: 8544
	public extern Delegate Invoke(object object_0);

	// Token: 0x06002161 RID: 8545 RVA: 0x0000BE49 File Offset: 0x0000A049
	public static Delegate smethod_0(object object_0, Delegate611 delegate611_1)
	{
		return delegate611_1(object_0);
	}

	// Token: 0x06002162 RID: 8546
	public extern Delegate611(object object_0, IntPtr intptr_0);

	// Token: 0x06002163 RID: 8547 RVA: 0x0000BE54 File Offset: 0x0000A054
	static Delegate611()
	{
		Class15.smethod_14(typeof(Delegate611).TypeHandle);
	}

	// Token: 0x04000C43 RID: 3139
	internal static Delegate611 delegate611_0;
}
