using System;
using System.Windows.Forms;

// Token: 0x02000272 RID: 626
internal sealed class Delegate98 : MulticastDelegate
{
	// Token: 0x0600195C RID: 6492
	public extern void Invoke(object object_0, Padding padding_0);

	// Token: 0x0600195D RID: 6493 RVA: 0x00008AF5 File Offset: 0x00006CF5
	public static void smethod_0(object object_0, Padding padding_0, Delegate98 delegate98_1)
	{
		delegate98_1(object_0, padding_0);
	}

	// Token: 0x0600195E RID: 6494
	public extern Delegate98(object object_0, IntPtr intptr_0);

	// Token: 0x0600195F RID: 6495 RVA: 0x00008B02 File Offset: 0x00006D02
	static Delegate98()
	{
		Class15.smethod_14(typeof(Delegate98).TypeHandle);
	}

	// Token: 0x04000A42 RID: 2626
	internal static Delegate98 delegate98_0;
}
