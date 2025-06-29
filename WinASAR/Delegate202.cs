using System;
using System.Windows.Forms;

// Token: 0x020002DA RID: 730
internal sealed class Delegate202 : MulticastDelegate
{
	// Token: 0x06001AFC RID: 6908
	public extern MouseButtons Invoke(object object_0);

	// Token: 0x06001AFD RID: 6909 RVA: 0x0000952D File Offset: 0x0000772D
	public static MouseButtons smethod_0(object object_0, Delegate202 delegate202_1)
	{
		return delegate202_1(object_0);
	}

	// Token: 0x06001AFE RID: 6910
	public extern Delegate202(object object_0, IntPtr intptr_0);

	// Token: 0x06001AFF RID: 6911 RVA: 0x00009538 File Offset: 0x00007738
	static Delegate202()
	{
		Class15.smethod_14(typeof(Delegate202).TypeHandle);
	}

	// Token: 0x04000AAA RID: 2730
	internal static Delegate202 delegate202_0;
}
