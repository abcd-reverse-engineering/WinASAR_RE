using System;
using System.Windows.Forms;

// Token: 0x02000265 RID: 613
internal sealed class Delegate85 : MulticastDelegate
{
	// Token: 0x06001928 RID: 6440
	public extern Keys Invoke(object object_0);

	// Token: 0x06001929 RID: 6441 RVA: 0x000089B1 File Offset: 0x00006BB1
	public static Keys smethod_0(object object_0, Delegate85 delegate85_1)
	{
		return delegate85_1(object_0);
	}

	// Token: 0x0600192A RID: 6442
	public extern Delegate85(object object_0, IntPtr intptr_0);

	// Token: 0x0600192B RID: 6443 RVA: 0x000089BC File Offset: 0x00006BBC
	static Delegate85()
	{
		Class15.smethod_14(typeof(Delegate85).TypeHandle);
	}

	// Token: 0x04000A35 RID: 2613
	internal static Delegate85 delegate85_0;
}
