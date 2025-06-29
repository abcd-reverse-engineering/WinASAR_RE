using System;

// Token: 0x02000293 RID: 659
internal sealed class Delegate131 : MulticastDelegate
{
	// Token: 0x060019E0 RID: 6624
	public extern bool Invoke(object object_0, string string_0);

	// Token: 0x060019E1 RID: 6625 RVA: 0x00008E2D File Offset: 0x0000702D
	public static bool smethod_0(object object_0, string string_0, Delegate131 delegate131_1)
	{
		return delegate131_1(object_0, string_0);
	}

	// Token: 0x060019E2 RID: 6626
	public extern Delegate131(object object_0, IntPtr intptr_0);

	// Token: 0x060019E3 RID: 6627 RVA: 0x00008E3A File Offset: 0x0000703A
	static Delegate131()
	{
		Class15.smethod_14(typeof(Delegate131).TypeHandle);
	}

	// Token: 0x04000A63 RID: 2659
	internal static Delegate131 delegate131_0;
}
