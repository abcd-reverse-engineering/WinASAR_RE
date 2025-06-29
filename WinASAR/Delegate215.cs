using System;
using System.Windows.Forms;

// Token: 0x020002E7 RID: 743
internal sealed class Delegate215 : MulticastDelegate
{
	// Token: 0x06001B30 RID: 6960
	public extern ToolStripItemCollection Invoke(object object_0);

	// Token: 0x06001B31 RID: 6961 RVA: 0x00009671 File Offset: 0x00007871
	public static ToolStripItemCollection smethod_0(object object_0, Delegate215 delegate215_1)
	{
		return delegate215_1(object_0);
	}

	// Token: 0x06001B32 RID: 6962
	public extern Delegate215(object object_0, IntPtr intptr_0);

	// Token: 0x06001B33 RID: 6963 RVA: 0x0000967C File Offset: 0x0000787C
	static Delegate215()
	{
		Class15.smethod_14(typeof(Delegate215).TypeHandle);
	}

	// Token: 0x04000AB7 RID: 2743
	internal static Delegate215 delegate215_0;
}
