using System;
using System.Windows.Forms;

// Token: 0x02000303 RID: 771
internal sealed class Delegate243 : MulticastDelegate
{
	// Token: 0x06001BA0 RID: 7072
	public extern void Invoke(object object_0, ColumnHeader[] columnHeader_0);

	// Token: 0x06001BA1 RID: 7073 RVA: 0x0000993D File Offset: 0x00007B3D
	public static void smethod_0(object object_0, ColumnHeader[] columnHeader_0, Delegate243 delegate243_1)
	{
		delegate243_1(object_0, columnHeader_0);
	}

	// Token: 0x06001BA2 RID: 7074
	public extern Delegate243(object object_0, IntPtr intptr_0);

	// Token: 0x06001BA3 RID: 7075 RVA: 0x0000994A File Offset: 0x00007B4A
	static Delegate243()
	{
		Class15.smethod_14(typeof(Delegate243).TypeHandle);
	}

	// Token: 0x04000AD3 RID: 2771
	internal static Delegate243 delegate243_0;
}
