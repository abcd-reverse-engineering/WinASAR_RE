using System;
using System.Windows.Forms;

// Token: 0x020002F6 RID: 758
internal sealed class Delegate230 : MulticastDelegate
{
	// Token: 0x06001B6C RID: 7020
	public extern void Invoke(object object_0, ToolStripItemOverflow toolStripItemOverflow_0);

	// Token: 0x06001B6D RID: 7021 RVA: 0x000097EF File Offset: 0x000079EF
	public static void smethod_0(object object_0, ToolStripItemOverflow toolStripItemOverflow_0, Delegate230 delegate230_1)
	{
		delegate230_1(object_0, toolStripItemOverflow_0);
	}

	// Token: 0x06001B6E RID: 7022
	public extern Delegate230(object object_0, IntPtr intptr_0);

	// Token: 0x06001B6F RID: 7023 RVA: 0x000097FC File Offset: 0x000079FC
	static Delegate230()
	{
		Class15.smethod_14(typeof(Delegate230).TypeHandle);
	}

	// Token: 0x04000AC6 RID: 2758
	internal static Delegate230 delegate230_0;
}
