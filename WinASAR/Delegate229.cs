using System;
using System.Windows.Forms;

// Token: 0x020002F5 RID: 757
internal sealed class Delegate229 : MulticastDelegate
{
	// Token: 0x06001B68 RID: 7016
	public extern void Invoke(object object_0, ToolStripItemDisplayStyle toolStripItemDisplayStyle_0);

	// Token: 0x06001B69 RID: 7017 RVA: 0x000097D5 File Offset: 0x000079D5
	public static void smethod_0(object object_0, ToolStripItemDisplayStyle toolStripItemDisplayStyle_0, Delegate229 delegate229_1)
	{
		delegate229_1(object_0, toolStripItemDisplayStyle_0);
	}

	// Token: 0x06001B6A RID: 7018
	public extern Delegate229(object object_0, IntPtr intptr_0);

	// Token: 0x06001B6B RID: 7019 RVA: 0x000097E2 File Offset: 0x000079E2
	static Delegate229()
	{
		Class15.smethod_14(typeof(Delegate229).TypeHandle);
	}

	// Token: 0x04000AC5 RID: 2757
	internal static Delegate229 delegate229_0;
}
