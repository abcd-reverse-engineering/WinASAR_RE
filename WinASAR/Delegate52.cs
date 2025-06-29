using System;
using System.Windows.Forms;

// Token: 0x02000244 RID: 580
internal sealed class Delegate52 : MulticastDelegate
{
	// Token: 0x060018A4 RID: 6308
	public extern void Invoke(object object_0, LinkBehavior linkBehavior_0);

	// Token: 0x060018A5 RID: 6309 RVA: 0x00008669 File Offset: 0x00006869
	public static void smethod_0(object object_0, LinkBehavior linkBehavior_0, Delegate52 delegate52_1)
	{
		delegate52_1(object_0, linkBehavior_0);
	}

	// Token: 0x060018A6 RID: 6310
	public extern Delegate52(object object_0, IntPtr intptr_0);

	// Token: 0x060018A7 RID: 6311 RVA: 0x00008676 File Offset: 0x00006876
	static Delegate52()
	{
		Class15.smethod_14(typeof(Delegate52).TypeHandle);
	}

	// Token: 0x04000A14 RID: 2580
	internal static Delegate52 delegate52_0;
}
