using System;
using System.Drawing;

// Token: 0x0200026F RID: 623
internal sealed class Delegate95 : MulticastDelegate
{
	// Token: 0x06001950 RID: 6480
	public extern void Invoke(object object_0, Font font_0);

	// Token: 0x06001951 RID: 6481 RVA: 0x00008AA7 File Offset: 0x00006CA7
	public static void smethod_0(object object_0, Font font_0, Delegate95 delegate95_1)
	{
		delegate95_1(object_0, font_0);
	}

	// Token: 0x06001952 RID: 6482
	public extern Delegate95(object object_0, IntPtr intptr_0);

	// Token: 0x06001953 RID: 6483 RVA: 0x00008AB4 File Offset: 0x00006CB4
	static Delegate95()
	{
		Class15.smethod_14(typeof(Delegate95).TypeHandle);
	}

	// Token: 0x04000A3F RID: 2623
	internal static Delegate95 delegate95_0;
}
