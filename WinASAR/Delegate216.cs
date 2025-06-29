using System;
using System.Windows.Forms;

// Token: 0x020002E8 RID: 744
internal sealed class Delegate216 : MulticastDelegate
{
	// Token: 0x06001B34 RID: 6964
	public extern void Invoke(object object_0, ToolStripItem[] toolStripItem_0);

	// Token: 0x06001B35 RID: 6965 RVA: 0x00009689 File Offset: 0x00007889
	public static void smethod_0(object object_0, ToolStripItem[] toolStripItem_0, Delegate216 delegate216_1)
	{
		delegate216_1(object_0, toolStripItem_0);
	}

	// Token: 0x06001B36 RID: 6966
	public extern Delegate216(object object_0, IntPtr intptr_0);

	// Token: 0x06001B37 RID: 6967 RVA: 0x00009696 File Offset: 0x00007896
	static Delegate216()
	{
		Class15.smethod_14(typeof(Delegate216).TypeHandle);
	}

	// Token: 0x04000AB8 RID: 2744
	internal static Delegate216 delegate216_0;
}
