using System;
using System.Drawing;

// Token: 0x0200028C RID: 652
internal sealed class Delegate124 : MulticastDelegate
{
	// Token: 0x060019C4 RID: 6596
	public extern Bitmap Invoke(object object_0);

	// Token: 0x060019C5 RID: 6597 RVA: 0x00008D81 File Offset: 0x00006F81
	public static Bitmap smethod_0(object object_0, Delegate124 delegate124_1)
	{
		return delegate124_1(object_0);
	}

	// Token: 0x060019C6 RID: 6598
	public extern Delegate124(object object_0, IntPtr intptr_0);

	// Token: 0x060019C7 RID: 6599 RVA: 0x00008D8C File Offset: 0x00006F8C
	static Delegate124()
	{
		Class15.smethod_14(typeof(Delegate124).TypeHandle);
	}

	// Token: 0x04000A5C RID: 2652
	internal static Delegate124 delegate124_0;
}
