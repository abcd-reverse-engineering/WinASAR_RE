using System;
using System.Drawing;

// Token: 0x0200023D RID: 573
internal sealed class Delegate45 : MulticastDelegate
{
	// Token: 0x06001888 RID: 6280
	public extern void Invoke(object object_0, Point point_0);

	// Token: 0x06001889 RID: 6281 RVA: 0x000085B3 File Offset: 0x000067B3
	public static void smethod_0(object object_0, Point point_0, Delegate45 delegate45_1)
	{
		delegate45_1(object_0, point_0);
	}

	// Token: 0x0600188A RID: 6282
	public extern Delegate45(object object_0, IntPtr intptr_0);

	// Token: 0x0600188B RID: 6283 RVA: 0x000085C0 File Offset: 0x000067C0
	static Delegate45()
	{
		Class15.smethod_14(typeof(Delegate45).TypeHandle);
	}

	// Token: 0x04000A0D RID: 2573
	internal static Delegate45 delegate45_0;
}
