using System;
using System.Windows.Forms;

// Token: 0x020002FA RID: 762
internal sealed class Delegate234 : MulticastDelegate
{
	// Token: 0x06001B7C RID: 7036
	public extern void Invoke(object object_0, ToolStripGripStyle toolStripGripStyle_0);

	// Token: 0x06001B7D RID: 7037 RVA: 0x00009857 File Offset: 0x00007A57
	public static void smethod_0(object object_0, ToolStripGripStyle toolStripGripStyle_0, Delegate234 delegate234_1)
	{
		delegate234_1(object_0, toolStripGripStyle_0);
	}

	// Token: 0x06001B7E RID: 7038
	public extern Delegate234(object object_0, IntPtr intptr_0);

	// Token: 0x06001B7F RID: 7039 RVA: 0x00009864 File Offset: 0x00007A64
	static Delegate234()
	{
		Class15.smethod_14(typeof(Delegate234).TypeHandle);
	}

	// Token: 0x04000ACA RID: 2762
	internal static Delegate234 delegate234_0;
}
