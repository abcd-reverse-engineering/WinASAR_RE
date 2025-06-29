using System;
using System.Drawing;

// Token: 0x02000254 RID: 596
internal sealed class Delegate68 : MulticastDelegate
{
	// Token: 0x060018E4 RID: 6372
	public extern void Invoke(object object_0, Size size_0);

	// Token: 0x060018E5 RID: 6373 RVA: 0x000087FD File Offset: 0x000069FD
	public static void smethod_0(object object_0, Size size_0, Delegate68 delegate68_1)
	{
		delegate68_1(object_0, size_0);
	}

	// Token: 0x060018E6 RID: 6374
	public extern Delegate68(object object_0, IntPtr intptr_0);

	// Token: 0x060018E7 RID: 6375 RVA: 0x0000880A File Offset: 0x00006A0A
	static Delegate68()
	{
		Class15.smethod_14(typeof(Delegate68).TypeHandle);
	}

	// Token: 0x04000A24 RID: 2596
	internal static Delegate68 delegate68_0;
}
