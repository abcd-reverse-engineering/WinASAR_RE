using System;
using System.Data.SqlTypes;

// Token: 0x02000545 RID: 1349
internal sealed class Delegate821 : MulticastDelegate
{
	// Token: 0x060024A8 RID: 9384
	public extern byte[] Invoke(ref SqlBinary sqlBinary_0);

	// Token: 0x060024A9 RID: 9385 RVA: 0x0000D2FE File Offset: 0x0000B4FE
	public static byte[] smethod_0(ref SqlBinary sqlBinary_0, Delegate821 delegate821_1)
	{
		return delegate821_1(ref sqlBinary_0);
	}

	// Token: 0x060024AA RID: 9386
	public extern Delegate821(object object_0, IntPtr intptr_0);

	// Token: 0x060024AB RID: 9387 RVA: 0x0000D309 File Offset: 0x0000B509
	static Delegate821()
	{
		Class15.smethod_14(typeof(Delegate821).TypeHandle);
	}

	// Token: 0x04000D15 RID: 3349
	internal static Delegate821 delegate821_0;
}
