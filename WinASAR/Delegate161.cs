using System;
using System.Windows.Forms;

// Token: 0x020002B1 RID: 689
internal sealed class Delegate161 : MulticastDelegate
{
	// Token: 0x06001A58 RID: 6744
	public extern ListViewItem Invoke(object object_0, int int_0);

	// Token: 0x06001A59 RID: 6745 RVA: 0x0000911F File Offset: 0x0000731F
	public static ListViewItem smethod_0(object object_0, int int_0, Delegate161 delegate161_1)
	{
		return delegate161_1(object_0, int_0);
	}

	// Token: 0x06001A5A RID: 6746
	public extern Delegate161(object object_0, IntPtr intptr_0);

	// Token: 0x06001A5B RID: 6747 RVA: 0x0000912C File Offset: 0x0000732C
	static Delegate161()
	{
		Class15.smethod_14(typeof(Delegate161).TypeHandle);
	}

	// Token: 0x04000A81 RID: 2689
	internal static Delegate161 delegate161_0;
}
