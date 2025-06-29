using System;
using System.Drawing;

// Token: 0x0200024A RID: 586
internal sealed class Delegate58 : MulticastDelegate
{
	// Token: 0x060018BC RID: 6332
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x060018BD RID: 6333 RVA: 0x000086FD File Offset: 0x000068FD
	public static void smethod_0(object object_0, Color color_0, Delegate58 delegate58_1)
	{
		delegate58_1(object_0, color_0);
	}

	// Token: 0x060018BE RID: 6334
	public extern Delegate58(object object_0, IntPtr intptr_0);

	// Token: 0x060018BF RID: 6335 RVA: 0x0000870A File Offset: 0x0000690A
	static Delegate58()
	{
		Class15.smethod_14(typeof(Delegate58).TypeHandle);
	}

	// Token: 0x04000A1A RID: 2586
	internal static Delegate58 delegate58_0;
}
