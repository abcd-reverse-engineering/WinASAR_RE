using System;
using System.Windows.Forms;

// Token: 0x02000255 RID: 597
internal sealed class Delegate69 : MulticastDelegate
{
	// Token: 0x060018E8 RID: 6376
	public extern void Invoke(object object_0, Control control_0);

	// Token: 0x060018E9 RID: 6377 RVA: 0x00008817 File Offset: 0x00006A17
	public static void smethod_0(object object_0, Control control_0, Delegate69 delegate69_1)
	{
		delegate69_1(object_0, control_0);
	}

	// Token: 0x060018EA RID: 6378
	public extern Delegate69(object object_0, IntPtr intptr_0);

	// Token: 0x060018EB RID: 6379 RVA: 0x00008824 File Offset: 0x00006A24
	static Delegate69()
	{
		Class15.smethod_14(typeof(Delegate69).TypeHandle);
	}

	// Token: 0x04000A25 RID: 2597
	internal static Delegate69 delegate69_0;
}
