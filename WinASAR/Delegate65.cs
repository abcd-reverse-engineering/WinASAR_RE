using System;
using System.Drawing;

// Token: 0x02000251 RID: 593
internal sealed class Delegate65 : MulticastDelegate
{
	// Token: 0x060018D8 RID: 6360
	public extern void Invoke(object object_0, SizeF sizeF_0);

	// Token: 0x060018D9 RID: 6361 RVA: 0x000087AF File Offset: 0x000069AF
	public static void smethod_0(object object_0, SizeF sizeF_0, Delegate65 delegate65_1)
	{
		delegate65_1(object_0, sizeF_0);
	}

	// Token: 0x060018DA RID: 6362
	public extern Delegate65(object object_0, IntPtr intptr_0);

	// Token: 0x060018DB RID: 6363 RVA: 0x000087BC File Offset: 0x000069BC
	static Delegate65()
	{
		Class15.smethod_14(typeof(Delegate65).TypeHandle);
	}

	// Token: 0x04000A21 RID: 2593
	internal static Delegate65 delegate65_0;
}
