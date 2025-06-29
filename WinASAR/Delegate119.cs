using System;

// Token: 0x02000287 RID: 647
internal sealed class Delegate119 : MulticastDelegate
{
	// Token: 0x060019B0 RID: 6576
	public extern string[] Invoke(string string_0);

	// Token: 0x060019B1 RID: 6577 RVA: 0x00008D09 File Offset: 0x00006F09
	public static string[] smethod_0(string string_0, Delegate119 delegate119_1)
	{
		return delegate119_1(string_0);
	}

	// Token: 0x060019B2 RID: 6578
	public extern Delegate119(object object_0, IntPtr intptr_0);

	// Token: 0x060019B3 RID: 6579 RVA: 0x00008D14 File Offset: 0x00006F14
	static Delegate119()
	{
		Class15.smethod_14(typeof(Delegate119).TypeHandle);
	}

	// Token: 0x04000A57 RID: 2647
	internal static Delegate119 delegate119_0;
}
