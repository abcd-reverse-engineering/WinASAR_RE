using System;
using System.Collections;

// Token: 0x020003C4 RID: 964
internal sealed class Delegate436 : MulticastDelegate
{
	// Token: 0x06001EA4 RID: 7844
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x06001EA5 RID: 7845 RVA: 0x0000ACA9 File Offset: 0x00008EA9
	public static IEnumerator smethod_0(object object_0, Delegate436 delegate436_1)
	{
		return delegate436_1(object_0);
	}

	// Token: 0x06001EA6 RID: 7846
	public extern Delegate436(object object_0, IntPtr intptr_0);

	// Token: 0x06001EA7 RID: 7847 RVA: 0x0000ACB4 File Offset: 0x00008EB4
	static Delegate436()
	{
		Class15.smethod_14(typeof(Delegate436).TypeHandle);
	}

	// Token: 0x04000B94 RID: 2964
	internal static Delegate436 delegate436_0;
}
