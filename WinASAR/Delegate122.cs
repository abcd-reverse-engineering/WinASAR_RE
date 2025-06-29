using System;
using System.Windows.Forms;

// Token: 0x0200028A RID: 650
internal sealed class Delegate122 : MulticastDelegate
{
	// Token: 0x060019BC RID: 6588
	public extern ImageList Invoke(object object_0);

	// Token: 0x060019BD RID: 6589 RVA: 0x00008D51 File Offset: 0x00006F51
	public static ImageList smethod_0(object object_0, Delegate122 delegate122_1)
	{
		return delegate122_1(object_0);
	}

	// Token: 0x060019BE RID: 6590
	public extern Delegate122(object object_0, IntPtr intptr_0);

	// Token: 0x060019BF RID: 6591 RVA: 0x00008D5C File Offset: 0x00006F5C
	static Delegate122()
	{
		Class15.smethod_14(typeof(Delegate122).TypeHandle);
	}

	// Token: 0x04000A5A RID: 2650
	internal static Delegate122 delegate122_0;
}
