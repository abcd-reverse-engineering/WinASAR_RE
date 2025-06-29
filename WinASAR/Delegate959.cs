using System;

// Token: 0x020005CF RID: 1487
internal sealed class Delegate959 : MulticastDelegate
{
	// Token: 0x060026D0 RID: 9936
	public extern void Invoke(object object_0, double double_0);

	// Token: 0x060026D1 RID: 9937 RVA: 0x0000E080 File Offset: 0x0000C280
	public static void smethod_0(object object_0, double double_0, Delegate959 delegate959_1)
	{
		delegate959_1(object_0, double_0);
	}

	// Token: 0x060026D2 RID: 9938
	public extern Delegate959(object object_0, IntPtr intptr_0);

	// Token: 0x060026D3 RID: 9939 RVA: 0x0000E08D File Offset: 0x0000C28D
	static Delegate959()
	{
		Class15.smethod_14(typeof(Delegate959).TypeHandle);
	}

	// Token: 0x04000D9F RID: 3487
	internal static Delegate959 delegate959_0;
}
