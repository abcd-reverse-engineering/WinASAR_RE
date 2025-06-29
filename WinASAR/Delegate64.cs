using System;
using System.Drawing;

// Token: 0x02000250 RID: 592
internal sealed class Delegate64 : MulticastDelegate
{
	// Token: 0x060018D4 RID: 6356
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x060018D5 RID: 6357 RVA: 0x00008795 File Offset: 0x00006995
	public static void smethod_0(object object_0, Color color_0, Delegate64 delegate64_1)
	{
		delegate64_1(object_0, color_0);
	}

	// Token: 0x060018D6 RID: 6358
	public extern Delegate64(object object_0, IntPtr intptr_0);

	// Token: 0x060018D7 RID: 6359 RVA: 0x000087A2 File Offset: 0x000069A2
	static Delegate64()
	{
		Class15.smethod_14(typeof(Delegate64).TypeHandle);
	}

	// Token: 0x04000A20 RID: 2592
	internal static Delegate64 delegate64_0;
}
