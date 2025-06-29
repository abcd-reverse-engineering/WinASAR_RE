using System;
using System.Drawing;

// Token: 0x02000301 RID: 769
internal sealed class Delegate241 : MulticastDelegate
{
	// Token: 0x06001B98 RID: 7064
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x06001B99 RID: 7065 RVA: 0x00009909 File Offset: 0x00007B09
	public static void smethod_0(object object_0, Color color_0, Delegate241 delegate241_1)
	{
		delegate241_1(object_0, color_0);
	}

	// Token: 0x06001B9A RID: 7066
	public extern Delegate241(object object_0, IntPtr intptr_0);

	// Token: 0x06001B9B RID: 7067 RVA: 0x00009916 File Offset: 0x00007B16
	static Delegate241()
	{
		Class15.smethod_14(typeof(Delegate241).TypeHandle);
	}

	// Token: 0x04000AD1 RID: 2769
	internal static Delegate241 delegate241_0;
}
