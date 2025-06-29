using System;

// Token: 0x0200024D RID: 589
internal sealed class Delegate61 : MulticastDelegate
{
	// Token: 0x060018C8 RID: 6344
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x060018C9 RID: 6345 RVA: 0x0000874B File Offset: 0x0000694B
	public static void smethod_0(object object_0, int int_0, Delegate61 delegate61_1)
	{
		delegate61_1(object_0, int_0);
	}

	// Token: 0x060018CA RID: 6346
	public extern Delegate61(object object_0, IntPtr intptr_0);

	// Token: 0x060018CB RID: 6347 RVA: 0x00008758 File Offset: 0x00006958
	static Delegate61()
	{
		Class15.smethod_14(typeof(Delegate61).TypeHandle);
	}

	// Token: 0x04000A1D RID: 2589
	internal static Delegate61 delegate61_0;
}
