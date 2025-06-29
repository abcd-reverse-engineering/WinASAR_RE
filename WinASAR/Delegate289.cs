using System;
using System.Windows.Forms;

// Token: 0x02000331 RID: 817
internal sealed class Delegate289 : MulticastDelegate
{
	// Token: 0x06001C58 RID: 7256
	public extern void Invoke(object object_0, ScrollBars scrollBars_0);

	// Token: 0x06001C59 RID: 7257 RVA: 0x00009DBF File Offset: 0x00007FBF
	public static void smethod_0(object object_0, ScrollBars scrollBars_0, Delegate289 delegate289_1)
	{
		delegate289_1(object_0, scrollBars_0);
	}

	// Token: 0x06001C5A RID: 7258
	public extern Delegate289(object object_0, IntPtr intptr_0);

	// Token: 0x06001C5B RID: 7259 RVA: 0x00009DCC File Offset: 0x00007FCC
	static Delegate289()
	{
		Class15.smethod_14(typeof(Delegate289).TypeHandle);
	}

	// Token: 0x04000B01 RID: 2817
	internal static Delegate289 delegate289_0;
}
