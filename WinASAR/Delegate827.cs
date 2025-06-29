using System;
using System.Data;

// Token: 0x0200054B RID: 1355
internal sealed class Delegate827 : MulticastDelegate
{
	// Token: 0x060024C0 RID: 9408
	public extern DataRowCollection Invoke(object object_0);

	// Token: 0x060024C1 RID: 9409 RVA: 0x0000D392 File Offset: 0x0000B592
	public static DataRowCollection smethod_0(object object_0, Delegate827 delegate827_1)
	{
		return delegate827_1(object_0);
	}

	// Token: 0x060024C2 RID: 9410
	public extern Delegate827(object object_0, IntPtr intptr_0);

	// Token: 0x060024C3 RID: 9411 RVA: 0x0000D39D File Offset: 0x0000B59D
	static Delegate827()
	{
		Class15.smethod_14(typeof(Delegate827).TypeHandle);
	}

	// Token: 0x04000D1B RID: 3355
	internal static Delegate827 delegate827_0;
}
