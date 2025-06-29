using System;

// Token: 0x02000457 RID: 1111
internal sealed class Delegate583 : MulticastDelegate
{
	// Token: 0x060020F0 RID: 8432
	public extern bool Invoke(object object_0);

	// Token: 0x060020F1 RID: 8433 RVA: 0x0000BB77 File Offset: 0x00009D77
	public static bool smethod_0(object object_0, Delegate583 delegate583_1)
	{
		return delegate583_1(object_0);
	}

	// Token: 0x060020F2 RID: 8434
	public extern Delegate583(object object_0, IntPtr intptr_0);

	// Token: 0x060020F3 RID: 8435 RVA: 0x0000BB82 File Offset: 0x00009D82
	static Delegate583()
	{
		Class15.smethod_14(typeof(Delegate583).TypeHandle);
	}

	// Token: 0x04000C27 RID: 3111
	internal static Delegate583 delegate583_0;
}
