using System;

// Token: 0x02000487 RID: 1159
internal sealed class Delegate631 : MulticastDelegate
{
	// Token: 0x060021B0 RID: 8624
	public extern void Invoke(object object_0);

	// Token: 0x060021B1 RID: 8625 RVA: 0x0000C049 File Offset: 0x0000A249
	public static void smethod_0(object object_0, Delegate631 delegate631_1)
	{
		delegate631_1(object_0);
	}

	// Token: 0x060021B2 RID: 8626
	public extern Delegate631(object object_0, IntPtr intptr_0);

	// Token: 0x060021B3 RID: 8627 RVA: 0x0000C054 File Offset: 0x0000A254
	static Delegate631()
	{
		Class15.smethod_14(typeof(Delegate631).TypeHandle);
	}

	// Token: 0x04000C57 RID: 3159
	internal static Delegate631 delegate631_0;
}
