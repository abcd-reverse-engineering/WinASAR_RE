using System;
using System.Drawing;

// Token: 0x0200024B RID: 587
internal sealed class Delegate59 : MulticastDelegate
{
	// Token: 0x060018C0 RID: 6336
	public extern void Invoke(object object_0, Image image_0);

	// Token: 0x060018C1 RID: 6337 RVA: 0x00008717 File Offset: 0x00006917
	public static void smethod_0(object object_0, Image image_0, Delegate59 delegate59_1)
	{
		delegate59_1(object_0, image_0);
	}

	// Token: 0x060018C2 RID: 6338
	public extern Delegate59(object object_0, IntPtr intptr_0);

	// Token: 0x060018C3 RID: 6339 RVA: 0x00008724 File Offset: 0x00006924
	static Delegate59()
	{
		Class15.smethod_14(typeof(Delegate59).TypeHandle);
	}

	// Token: 0x04000A1B RID: 2587
	internal static Delegate59 delegate59_0;
}
