using System;
using System.Drawing;

// Token: 0x0200024F RID: 591
internal sealed class Delegate63 : MulticastDelegate
{
	// Token: 0x060018D0 RID: 6352
	public extern Color Invoke();

	// Token: 0x060018D1 RID: 6353 RVA: 0x0000877F File Offset: 0x0000697F
	public static Color smethod_0(Delegate63 delegate63_1)
	{
		return delegate63_1();
	}

	// Token: 0x060018D2 RID: 6354
	public extern Delegate63(object object_0, IntPtr intptr_0);

	// Token: 0x060018D3 RID: 6355 RVA: 0x00008788 File Offset: 0x00006988
	static Delegate63()
	{
		Class15.smethod_14(typeof(Delegate63).TypeHandle);
	}

	// Token: 0x04000A1F RID: 2591
	internal static Delegate63 delegate63_0;
}
