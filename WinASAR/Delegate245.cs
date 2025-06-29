using System;
using System.Windows.Forms;

// Token: 0x02000305 RID: 773
internal sealed class Delegate245 : MulticastDelegate
{
	// Token: 0x06001BA8 RID: 7080
	public extern void Invoke(object object_0, DockStyle dockStyle_0);

	// Token: 0x06001BA9 RID: 7081 RVA: 0x00009971 File Offset: 0x00007B71
	public static void smethod_0(object object_0, DockStyle dockStyle_0, Delegate245 delegate245_1)
	{
		delegate245_1(object_0, dockStyle_0);
	}

	// Token: 0x06001BAA RID: 7082
	public extern Delegate245(object object_0, IntPtr intptr_0);

	// Token: 0x06001BAB RID: 7083 RVA: 0x0000997E File Offset: 0x00007B7E
	static Delegate245()
	{
		Class15.smethod_14(typeof(Delegate245).TypeHandle);
	}

	// Token: 0x04000AD5 RID: 2773
	internal static Delegate245 delegate245_0;
}
