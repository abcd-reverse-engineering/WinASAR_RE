using System;
using System.Collections;

// Token: 0x02000582 RID: 1410
internal sealed class Delegate882 : MulticastDelegate
{
	// Token: 0x0600259C RID: 9628
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x0600259D RID: 9629 RVA: 0x0000D914 File Offset: 0x0000BB14
	public static IEnumerator smethod_0(object object_0, Delegate882 delegate882_1)
	{
		return delegate882_1(object_0);
	}

	// Token: 0x0600259E RID: 9630
	public extern Delegate882(object object_0, IntPtr intptr_0);

	// Token: 0x0600259F RID: 9631 RVA: 0x0000D91F File Offset: 0x0000BB1F
	static Delegate882()
	{
		Class15.smethod_14(typeof(Delegate882).TypeHandle);
	}

	// Token: 0x04000D52 RID: 3410
	internal static Delegate882 delegate882_0;
}
