using System;

// Token: 0x02000581 RID: 1409
internal sealed class Delegate881 : MulticastDelegate
{
	// Token: 0x06002598 RID: 9624
	public extern int Invoke(object object_0);

	// Token: 0x06002599 RID: 9625 RVA: 0x0000D8FC File Offset: 0x0000BAFC
	public static int smethod_0(object object_0, Delegate881 delegate881_1)
	{
		return delegate881_1(object_0);
	}

	// Token: 0x0600259A RID: 9626
	public extern Delegate881(object object_0, IntPtr intptr_0);

	// Token: 0x0600259B RID: 9627 RVA: 0x0000D907 File Offset: 0x0000BB07
	static Delegate881()
	{
		Class15.smethod_14(typeof(Delegate881).TypeHandle);
	}

	// Token: 0x04000D51 RID: 3409
	internal static Delegate881 delegate881_0;
}
