using System;
using System.Windows.Forms;

// Token: 0x0200029D RID: 669
internal sealed class Delegate141 : MulticastDelegate
{
	// Token: 0x06001A08 RID: 6664
	public extern ColumnHeader Invoke(object object_0, int int_0);

	// Token: 0x06001A09 RID: 6665 RVA: 0x00008F23 File Offset: 0x00007123
	public static ColumnHeader smethod_0(object object_0, int int_0, Delegate141 delegate141_1)
	{
		return delegate141_1(object_0, int_0);
	}

	// Token: 0x06001A0A RID: 6666
	public extern Delegate141(object object_0, IntPtr intptr_0);

	// Token: 0x06001A0B RID: 6667 RVA: 0x00008F30 File Offset: 0x00007130
	static Delegate141()
	{
		Class15.smethod_14(typeof(Delegate141).TypeHandle);
	}

	// Token: 0x04000A6D RID: 2669
	internal static Delegate141 delegate141_0;
}
