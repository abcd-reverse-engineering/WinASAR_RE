using System;
using System.Windows.Forms;

// Token: 0x0200027D RID: 637
internal sealed class Delegate109 : MulticastDelegate
{
	// Token: 0x06001988 RID: 6536
	public extern DialogResult Invoke(object object_0);

	// Token: 0x06001989 RID: 6537 RVA: 0x00008C11 File Offset: 0x00006E11
	public static DialogResult smethod_0(object object_0, Delegate109 delegate109_1)
	{
		return delegate109_1(object_0);
	}

	// Token: 0x0600198A RID: 6538
	public extern Delegate109(object object_0, IntPtr intptr_0);

	// Token: 0x0600198B RID: 6539 RVA: 0x00008C1C File Offset: 0x00006E1C
	static Delegate109()
	{
		Class15.smethod_14(typeof(Delegate109).TypeHandle);
	}

	// Token: 0x04000A4D RID: 2637
	internal static Delegate109 delegate109_0;
}
