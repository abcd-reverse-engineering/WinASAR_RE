using System;

// Token: 0x020005D7 RID: 1495
internal sealed class Delegate967 : MulticastDelegate
{
	// Token: 0x060026F0 RID: 9968
	public extern byte Invoke(object object_0);

	// Token: 0x060026F1 RID: 9969 RVA: 0x0000E15A File Offset: 0x0000C35A
	public static byte smethod_0(object object_0, Delegate967 delegate967_1)
	{
		return delegate967_1(object_0);
	}

	// Token: 0x060026F2 RID: 9970
	public extern Delegate967(object object_0, IntPtr intptr_0);

	// Token: 0x060026F3 RID: 9971 RVA: 0x0000E165 File Offset: 0x0000C365
	static Delegate967()
	{
		Class15.smethod_14(typeof(Delegate967).TypeHandle);
	}

	// Token: 0x04000DA7 RID: 3495
	internal static Delegate967 delegate967_0;
}
