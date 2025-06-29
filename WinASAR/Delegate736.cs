using System;

// Token: 0x020004F0 RID: 1264
internal sealed class Delegate736 : MulticastDelegate
{
	// Token: 0x06002354 RID: 9044
	public extern bool Invoke();

	// Token: 0x06002355 RID: 9045 RVA: 0x0000CA92 File Offset: 0x0000AC92
	public static bool smethod_0(Delegate736 delegate736_1)
	{
		return delegate736_1();
	}

	// Token: 0x06002356 RID: 9046
	public extern Delegate736(object object_0, IntPtr intptr_0);

	// Token: 0x06002357 RID: 9047 RVA: 0x0000CA9B File Offset: 0x0000AC9B
	static Delegate736()
	{
		Class15.smethod_14(typeof(Delegate736).TypeHandle);
	}

	// Token: 0x04000CC0 RID: 3264
	internal static Delegate736 delegate736_0;
}
