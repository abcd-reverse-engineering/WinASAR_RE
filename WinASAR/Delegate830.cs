using System;
using System.Data;

// Token: 0x0200054E RID: 1358
internal sealed class Delegate830 : MulticastDelegate
{
	// Token: 0x060024CC RID: 9420
	public extern object Invoke(object object_0, DataColumn dataColumn_0);

	// Token: 0x060024CD RID: 9421 RVA: 0x0000D3DA File Offset: 0x0000B5DA
	public static object smethod_0(object object_0, DataColumn dataColumn_0, Delegate830 delegate830_1)
	{
		return delegate830_1(object_0, dataColumn_0);
	}

	// Token: 0x060024CE RID: 9422
	public extern Delegate830(object object_0, IntPtr intptr_0);

	// Token: 0x060024CF RID: 9423 RVA: 0x0000D3E7 File Offset: 0x0000B5E7
	static Delegate830()
	{
		Class15.smethod_14(typeof(Delegate830).TypeHandle);
	}

	// Token: 0x04000D1E RID: 3358
	internal static Delegate830 delegate830_0;
}
