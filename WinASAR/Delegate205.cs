using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x020002DD RID: 733
internal sealed class Delegate205 : MulticastDelegate
{
	// Token: 0x06001B08 RID: 6920
	public extern void Invoke(object object_0, Control control_0, Point point_0);

	// Token: 0x06001B09 RID: 6921 RVA: 0x00009575 File Offset: 0x00007775
	public static void smethod_0(object object_0, Control control_0, Point point_0, Delegate205 delegate205_1)
	{
		delegate205_1(object_0, control_0, point_0);
	}

	// Token: 0x06001B0A RID: 6922
	public extern Delegate205(object object_0, IntPtr intptr_0);

	// Token: 0x06001B0B RID: 6923 RVA: 0x00009584 File Offset: 0x00007784
	static Delegate205()
	{
		Class15.smethod_14(typeof(Delegate205).TypeHandle);
	}

	// Token: 0x04000AAD RID: 2733
	internal static Delegate205 delegate205_0;
}
