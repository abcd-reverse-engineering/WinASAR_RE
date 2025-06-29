using System;
using System.Collections;

// Token: 0x02000547 RID: 1351
internal sealed class Delegate823 : MulticastDelegate
{
	// Token: 0x060024B0 RID: 9392
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x060024B1 RID: 9393 RVA: 0x0000D32E File Offset: 0x0000B52E
	public static IEnumerator smethod_0(object object_0, Delegate823 delegate823_1)
	{
		return delegate823_1(object_0);
	}

	// Token: 0x060024B2 RID: 9394
	public extern Delegate823(object object_0, IntPtr intptr_0);

	// Token: 0x060024B3 RID: 9395 RVA: 0x0000D339 File Offset: 0x0000B539
	static Delegate823()
	{
		Class15.smethod_14(typeof(Delegate823).TypeHandle);
	}

	// Token: 0x04000D17 RID: 3351
	internal static Delegate823 delegate823_0;
}
