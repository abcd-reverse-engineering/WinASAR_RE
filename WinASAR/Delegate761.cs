using System;
using System.Text;

// Token: 0x02000509 RID: 1289
internal sealed class Delegate761 : MulticastDelegate
{
	// Token: 0x060023B8 RID: 9144
	public extern StringBuilder Invoke(object object_0);

	// Token: 0x060023B9 RID: 9145 RVA: 0x0000CD04 File Offset: 0x0000AF04
	public static StringBuilder smethod_0(object object_0, Delegate761 delegate761_1)
	{
		return delegate761_1(object_0);
	}

	// Token: 0x060023BA RID: 9146
	public extern Delegate761(object object_0, IntPtr intptr_0);

	// Token: 0x060023BB RID: 9147 RVA: 0x0000CD0F File Offset: 0x0000AF0F
	static Delegate761()
	{
		Class15.smethod_14(typeof(Delegate761).TypeHandle);
	}

	// Token: 0x04000CD9 RID: 3289
	internal static Delegate761 delegate761_0;
}
