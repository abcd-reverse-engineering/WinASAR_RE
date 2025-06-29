using System;
using System.Drawing;

// Token: 0x02000294 RID: 660
internal sealed class Delegate132 : MulticastDelegate
{
	// Token: 0x060019E4 RID: 6628
	public extern void Invoke(object object_0, string string_0, Image image_0);

	// Token: 0x060019E5 RID: 6629 RVA: 0x00008E47 File Offset: 0x00007047
	public static void smethod_0(object object_0, string string_0, Image image_0, Delegate132 delegate132_1)
	{
		delegate132_1(object_0, string_0, image_0);
	}

	// Token: 0x060019E6 RID: 6630
	public extern Delegate132(object object_0, IntPtr intptr_0);

	// Token: 0x060019E7 RID: 6631 RVA: 0x00008E56 File Offset: 0x00007056
	static Delegate132()
	{
		Class15.smethod_14(typeof(Delegate132).TypeHandle);
	}

	// Token: 0x04000A64 RID: 2660
	internal static Delegate132 delegate132_0;
}
