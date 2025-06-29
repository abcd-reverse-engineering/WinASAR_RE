using System;

// Token: 0x020005B3 RID: 1459
internal sealed class Delegate931 : MulticastDelegate
{
	// Token: 0x06002660 RID: 9824
	public extern bool Invoke(object object_0);

	// Token: 0x06002661 RID: 9825 RVA: 0x0000DDC6 File Offset: 0x0000BFC6
	public static bool smethod_0(object object_0, Delegate931 delegate931_1)
	{
		return delegate931_1(object_0);
	}

	// Token: 0x06002662 RID: 9826
	public extern Delegate931(object object_0, IntPtr intptr_0);

	// Token: 0x06002663 RID: 9827 RVA: 0x0000DDD1 File Offset: 0x0000BFD1
	static Delegate931()
	{
		Class15.smethod_14(typeof(Delegate931).TypeHandle);
	}

	// Token: 0x04000D83 RID: 3459
	internal static Delegate931 delegate931_0;
}
