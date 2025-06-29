using System;
using System.Drawing;

// Token: 0x02000329 RID: 809
internal sealed class Delegate281 : MulticastDelegate
{
	// Token: 0x06001C38 RID: 7224
	public extern void Invoke(object object_0, Font font_0);

	// Token: 0x06001C39 RID: 7225 RVA: 0x00009CF5 File Offset: 0x00007EF5
	public static void smethod_0(object object_0, Font font_0, Delegate281 delegate281_1)
	{
		delegate281_1(object_0, font_0);
	}

	// Token: 0x06001C3A RID: 7226
	public extern Delegate281(object object_0, IntPtr intptr_0);

	// Token: 0x06001C3B RID: 7227 RVA: 0x00009D02 File Offset: 0x00007F02
	static Delegate281()
	{
		Class15.smethod_14(typeof(Delegate281).TypeHandle);
	}

	// Token: 0x04000AF9 RID: 2809
	internal static Delegate281 delegate281_0;
}
