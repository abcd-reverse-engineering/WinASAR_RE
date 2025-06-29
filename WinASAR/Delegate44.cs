using System;
using System.Windows.Forms;

// Token: 0x0200023C RID: 572
internal sealed class Delegate44 : MulticastDelegate
{
	// Token: 0x06001884 RID: 6276
	public extern void Invoke(object object_0, DialogResult dialogResult_0);

	// Token: 0x06001885 RID: 6277 RVA: 0x00008599 File Offset: 0x00006799
	public static void smethod_0(object object_0, DialogResult dialogResult_0, Delegate44 delegate44_1)
	{
		delegate44_1(object_0, dialogResult_0);
	}

	// Token: 0x06001886 RID: 6278
	public extern Delegate44(object object_0, IntPtr intptr_0);

	// Token: 0x06001887 RID: 6279 RVA: 0x000085A6 File Offset: 0x000067A6
	static Delegate44()
	{
		Class15.smethod_14(typeof(Delegate44).TypeHandle);
	}

	// Token: 0x04000A0C RID: 2572
	internal static Delegate44 delegate44_0;
}
