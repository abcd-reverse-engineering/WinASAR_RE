using System;
using System.Data;

// Token: 0x02000553 RID: 1363
internal sealed class Delegate835 : MulticastDelegate
{
	// Token: 0x060024E0 RID: 9440
	public extern void Invoke(object object_0, DataColumn dataColumn_0);

	// Token: 0x060024E1 RID: 9441 RVA: 0x0000D458 File Offset: 0x0000B658
	public static void smethod_0(object object_0, DataColumn dataColumn_0, Delegate835 delegate835_1)
	{
		delegate835_1(object_0, dataColumn_0);
	}

	// Token: 0x060024E2 RID: 9442
	public extern Delegate835(object object_0, IntPtr intptr_0);

	// Token: 0x060024E3 RID: 9443 RVA: 0x0000D465 File Offset: 0x0000B665
	static Delegate835()
	{
		Class15.smethod_14(typeof(Delegate835).TypeHandle);
	}

	// Token: 0x04000D23 RID: 3363
	internal static Delegate835 delegate835_0;
}
