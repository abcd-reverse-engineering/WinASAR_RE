using System;
using System.Drawing;

// Token: 0x02000246 RID: 582
internal sealed class Delegate54 : MulticastDelegate
{
	// Token: 0x060018AC RID: 6316
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x060018AD RID: 6317 RVA: 0x00008699 File Offset: 0x00006899
	public static void smethod_0(object object_0, Color color_0, Delegate54 delegate54_1)
	{
		delegate54_1(object_0, color_0);
	}

	// Token: 0x060018AE RID: 6318
	public extern Delegate54(object object_0, IntPtr intptr_0);

	// Token: 0x060018AF RID: 6319 RVA: 0x000086A6 File Offset: 0x000068A6
	static Delegate54()
	{
		Class15.smethod_14(typeof(Delegate54).TypeHandle);
	}

	// Token: 0x04000A16 RID: 2582
	internal static Delegate54 delegate54_0;
}
