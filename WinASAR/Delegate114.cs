using System;

// Token: 0x02000282 RID: 642
internal sealed class Delegate114 : MulticastDelegate
{
	// Token: 0x0600199C RID: 6556
	public extern bool Invoke(string string_0);

	// Token: 0x0600199D RID: 6557 RVA: 0x00008C8D File Offset: 0x00006E8D
	public static bool smethod_0(string string_0, Delegate114 delegate114_1)
	{
		return delegate114_1(string_0);
	}

	// Token: 0x0600199E RID: 6558
	public extern Delegate114(object object_0, IntPtr intptr_0);

	// Token: 0x0600199F RID: 6559 RVA: 0x00008C98 File Offset: 0x00006E98
	static Delegate114()
	{
		Class15.smethod_14(typeof(Delegate114).TypeHandle);
	}

	// Token: 0x04000A52 RID: 2642
	internal static Delegate114 delegate114_0;
}
