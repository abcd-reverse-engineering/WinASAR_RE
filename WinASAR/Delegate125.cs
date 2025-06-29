using System;
using System.Drawing;

// Token: 0x0200028D RID: 653
internal sealed class Delegate125 : MulticastDelegate
{
	// Token: 0x060019C8 RID: 6600
	public extern void Invoke(object object_0, Image image_0);

	// Token: 0x060019C9 RID: 6601 RVA: 0x00008D99 File Offset: 0x00006F99
	public static void smethod_0(object object_0, Image image_0, Delegate125 delegate125_1)
	{
		delegate125_1(object_0, image_0);
	}

	// Token: 0x060019CA RID: 6602
	public extern Delegate125(object object_0, IntPtr intptr_0);

	// Token: 0x060019CB RID: 6603 RVA: 0x00008DA6 File Offset: 0x00006FA6
	static Delegate125()
	{
		Class15.smethod_14(typeof(Delegate125).TypeHandle);
	}

	// Token: 0x04000A5D RID: 2653
	internal static Delegate125 delegate125_0;
}
