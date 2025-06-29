using System;
using System.Collections;

// Token: 0x02000585 RID: 1413
internal sealed class Delegate885 : MulticastDelegate
{
	// Token: 0x060025A8 RID: 9640
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x060025A9 RID: 9641 RVA: 0x0000D95C File Offset: 0x0000BB5C
	public static IEnumerator smethod_0(object object_0, Delegate885 delegate885_1)
	{
		return delegate885_1(object_0);
	}

	// Token: 0x060025AA RID: 9642
	public extern Delegate885(object object_0, IntPtr intptr_0);

	// Token: 0x060025AB RID: 9643 RVA: 0x0000D967 File Offset: 0x0000BB67
	static Delegate885()
	{
		Class15.smethod_14(typeof(Delegate885).TypeHandle);
	}

	// Token: 0x04000D55 RID: 3413
	internal static Delegate885 delegate885_0;
}
