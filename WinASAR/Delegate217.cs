using System;
using System.Windows.Forms;

// Token: 0x020002E9 RID: 745
internal sealed class Delegate217 : MulticastDelegate
{
	// Token: 0x06001B38 RID: 6968
	public extern ToolStripItemCollection Invoke(object object_0);

	// Token: 0x06001B39 RID: 6969 RVA: 0x000096A3 File Offset: 0x000078A3
	public static ToolStripItemCollection smethod_0(object object_0, Delegate217 delegate217_1)
	{
		return delegate217_1(object_0);
	}

	// Token: 0x06001B3A RID: 6970
	public extern Delegate217(object object_0, IntPtr intptr_0);

	// Token: 0x06001B3B RID: 6971 RVA: 0x000096AE File Offset: 0x000078AE
	static Delegate217()
	{
		Class15.smethod_14(typeof(Delegate217).TypeHandle);
	}

	// Token: 0x04000AB9 RID: 2745
	internal static Delegate217 delegate217_0;
}
