using System;

// Token: 0x0200060D RID: 1549
internal sealed class Delegate1021 : MulticastDelegate
{
	// Token: 0x060027C8 RID: 10184
	public extern int Invoke();

	// Token: 0x060027C9 RID: 10185 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
	public static int smethod_0(Delegate1021 delegate1021_1)
	{
		return delegate1021_1();
	}

	// Token: 0x060027CA RID: 10186
	public extern Delegate1021(object object_0, IntPtr intptr_0);

	// Token: 0x060027CB RID: 10187 RVA: 0x0000E6ED File Offset: 0x0000C8ED
	static Delegate1021()
	{
		Class15.smethod_14(typeof(Delegate1021).TypeHandle);
	}

	// Token: 0x04000DDD RID: 3549
	internal static Delegate1021 delegate1021_0;
}
