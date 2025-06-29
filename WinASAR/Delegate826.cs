using System;
using System.Data;

// Token: 0x0200054A RID: 1354
internal sealed class Delegate826 : MulticastDelegate
{
	// Token: 0x060024BC RID: 9404
	public extern void Invoke(object object_0, DataTable dataTable_0);

	// Token: 0x060024BD RID: 9405 RVA: 0x0000D378 File Offset: 0x0000B578
	public static void smethod_0(object object_0, DataTable dataTable_0, Delegate826 delegate826_1)
	{
		delegate826_1(object_0, dataTable_0);
	}

	// Token: 0x060024BE RID: 9406
	public extern Delegate826(object object_0, IntPtr intptr_0);

	// Token: 0x060024BF RID: 9407 RVA: 0x0000D385 File Offset: 0x0000B585
	static Delegate826()
	{
		Class15.smethod_14(typeof(Delegate826).TypeHandle);
	}

	// Token: 0x04000D1A RID: 3354
	internal static Delegate826 delegate826_0;
}
