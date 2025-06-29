using System;
using System.Windows.Forms;

// Token: 0x020002B7 RID: 695
internal sealed class Delegate167 : MulticastDelegate
{
	// Token: 0x06001A70 RID: 6768
	public extern ListViewItem Invoke(object object_0, int int_0);

	// Token: 0x06001A71 RID: 6769 RVA: 0x000091B7 File Offset: 0x000073B7
	public static ListViewItem smethod_0(object object_0, int int_0, Delegate167 delegate167_1)
	{
		return delegate167_1(object_0, int_0);
	}

	// Token: 0x06001A72 RID: 6770
	public extern Delegate167(object object_0, IntPtr intptr_0);

	// Token: 0x06001A73 RID: 6771 RVA: 0x000091C4 File Offset: 0x000073C4
	static Delegate167()
	{
		Class15.smethod_14(typeof(Delegate167).TypeHandle);
	}

	// Token: 0x04000A87 RID: 2695
	internal static Delegate167 delegate167_0;
}
