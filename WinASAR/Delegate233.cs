using System;
using System.Windows.Forms;

// Token: 0x020002F9 RID: 761
internal sealed class Delegate233 : MulticastDelegate
{
	// Token: 0x06001B78 RID: 7032
	public extern void Invoke(object object_0, ToolStripItemAlignment toolStripItemAlignment_0);

	// Token: 0x06001B79 RID: 7033 RVA: 0x0000983D File Offset: 0x00007A3D
	public static void smethod_0(object object_0, ToolStripItemAlignment toolStripItemAlignment_0, Delegate233 delegate233_1)
	{
		delegate233_1(object_0, toolStripItemAlignment_0);
	}

	// Token: 0x06001B7A RID: 7034
	public extern Delegate233(object object_0, IntPtr intptr_0);

	// Token: 0x06001B7B RID: 7035 RVA: 0x0000984A File Offset: 0x00007A4A
	static Delegate233()
	{
		Class15.smethod_14(typeof(Delegate233).TypeHandle);
	}

	// Token: 0x04000AC9 RID: 2761
	internal static Delegate233 delegate233_0;
}
