using System;
using System.Windows.Forms;

// Token: 0x02000300 RID: 768
internal sealed class Delegate240 : MulticastDelegate
{
	// Token: 0x06001B94 RID: 7060
	public extern void Invoke(object object_0, LinkBehavior linkBehavior_0);

	// Token: 0x06001B95 RID: 7061 RVA: 0x000098EF File Offset: 0x00007AEF
	public static void smethod_0(object object_0, LinkBehavior linkBehavior_0, Delegate240 delegate240_1)
	{
		delegate240_1(object_0, linkBehavior_0);
	}

	// Token: 0x06001B96 RID: 7062
	public extern Delegate240(object object_0, IntPtr intptr_0);

	// Token: 0x06001B97 RID: 7063 RVA: 0x000098FC File Offset: 0x00007AFC
	static Delegate240()
	{
		Class15.smethod_14(typeof(Delegate240).TypeHandle);
	}

	// Token: 0x04000AD0 RID: 2768
	internal static Delegate240 delegate240_0;
}
