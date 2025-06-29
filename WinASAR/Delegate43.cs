using System;
using System.Windows.Forms;

// Token: 0x0200023B RID: 571
internal sealed class Delegate43 : MulticastDelegate
{
	// Token: 0x06001880 RID: 6272
	public extern void Invoke(object object_0, AnchorStyles anchorStyles_0);

	// Token: 0x06001881 RID: 6273 RVA: 0x0000857F File Offset: 0x0000677F
	public static void smethod_0(object object_0, AnchorStyles anchorStyles_0, Delegate43 delegate43_1)
	{
		delegate43_1(object_0, anchorStyles_0);
	}

	// Token: 0x06001882 RID: 6274
	public extern Delegate43(object object_0, IntPtr intptr_0);

	// Token: 0x06001883 RID: 6275 RVA: 0x0000858C File Offset: 0x0000678C
	static Delegate43()
	{
		Class15.smethod_14(typeof(Delegate43).TypeHandle);
	}

	// Token: 0x04000A0B RID: 2571
	internal static Delegate43 delegate43_0;
}
