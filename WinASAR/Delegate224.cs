using System;
using System.Windows.Forms;

// Token: 0x020002F0 RID: 752
internal sealed class Delegate224 : MulticastDelegate
{
	// Token: 0x06001B54 RID: 6996
	public extern void Invoke(object object_0, ToolStripItemImageScaling toolStripItemImageScaling_0);

	// Token: 0x06001B55 RID: 6997 RVA: 0x00009757 File Offset: 0x00007957
	public static void smethod_0(object object_0, ToolStripItemImageScaling toolStripItemImageScaling_0, Delegate224 delegate224_1)
	{
		delegate224_1(object_0, toolStripItemImageScaling_0);
	}

	// Token: 0x06001B56 RID: 6998
	public extern Delegate224(object object_0, IntPtr intptr_0);

	// Token: 0x06001B57 RID: 6999 RVA: 0x00009764 File Offset: 0x00007964
	static Delegate224()
	{
		Class15.smethod_14(typeof(Delegate224).TypeHandle);
	}

	// Token: 0x04000AC0 RID: 2752
	internal static Delegate224 delegate224_0;
}
