using System;

// Token: 0x02000518 RID: 1304
internal sealed class Delegate776 : MulticastDelegate
{
	// Token: 0x060023F4 RID: 9204
	public extern object Invoke(object object_0);

	// Token: 0x060023F5 RID: 9205 RVA: 0x0000CE84 File Offset: 0x0000B084
	public static object smethod_0(object object_0, Delegate776 delegate776_1)
	{
		return delegate776_1(object_0);
	}

	// Token: 0x060023F6 RID: 9206
	public extern Delegate776(object object_0, IntPtr intptr_0);

	// Token: 0x060023F7 RID: 9207 RVA: 0x0000CE8F File Offset: 0x0000B08F
	static Delegate776()
	{
		Class15.smethod_14(typeof(Delegate776).TypeHandle);
	}

	// Token: 0x04000CE8 RID: 3304
	internal static Delegate776 delegate776_0;
}
