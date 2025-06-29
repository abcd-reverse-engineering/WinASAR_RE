using System;
using System.Windows.Forms;

// Token: 0x02000281 RID: 641
internal sealed class Delegate113 : MulticastDelegate
{
	// Token: 0x06001998 RID: 6552
	public extern void Invoke(object object_0, CheckState checkState_0);

	// Token: 0x06001999 RID: 6553 RVA: 0x00008C73 File Offset: 0x00006E73
	public static void smethod_0(object object_0, CheckState checkState_0, Delegate113 delegate113_1)
	{
		delegate113_1(object_0, checkState_0);
	}

	// Token: 0x0600199A RID: 6554
	public extern Delegate113(object object_0, IntPtr intptr_0);

	// Token: 0x0600199B RID: 6555 RVA: 0x00008C80 File Offset: 0x00006E80
	static Delegate113()
	{
		Class15.smethod_14(typeof(Delegate113).TypeHandle);
	}

	// Token: 0x04000A51 RID: 2641
	internal static Delegate113 delegate113_0;
}
