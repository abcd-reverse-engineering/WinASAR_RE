using System;
using System.Data;

// Token: 0x02000551 RID: 1361
internal sealed class Delegate833 : MulticastDelegate
{
	// Token: 0x060024D8 RID: 9432
	public extern DataRow Invoke(object object_0);

	// Token: 0x060024D9 RID: 9433 RVA: 0x0000D426 File Offset: 0x0000B626
	public static DataRow smethod_0(object object_0, Delegate833 delegate833_1)
	{
		return delegate833_1(object_0);
	}

	// Token: 0x060024DA RID: 9434
	public extern Delegate833(object object_0, IntPtr intptr_0);

	// Token: 0x060024DB RID: 9435 RVA: 0x0000D431 File Offset: 0x0000B631
	static Delegate833()
	{
		Class15.smethod_14(typeof(Delegate833).TypeHandle);
	}

	// Token: 0x04000D21 RID: 3361
	internal static Delegate833 delegate833_0;
}
