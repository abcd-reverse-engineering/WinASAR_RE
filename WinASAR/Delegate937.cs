using System;

// Token: 0x020005B9 RID: 1465
internal sealed class Delegate937 : MulticastDelegate
{
	// Token: 0x06002678 RID: 9848
	public extern bool Invoke(object object_0);

	// Token: 0x06002679 RID: 9849 RVA: 0x0000DE5C File Offset: 0x0000C05C
	public static bool smethod_0(object object_0, Delegate937 delegate937_1)
	{
		return delegate937_1(object_0);
	}

	// Token: 0x0600267A RID: 9850
	public extern Delegate937(object object_0, IntPtr intptr_0);

	// Token: 0x0600267B RID: 9851 RVA: 0x0000DE67 File Offset: 0x0000C067
	static Delegate937()
	{
		Class15.smethod_14(typeof(Delegate937).TypeHandle);
	}

	// Token: 0x04000D89 RID: 3465
	internal static Delegate937 delegate937_0;
}
