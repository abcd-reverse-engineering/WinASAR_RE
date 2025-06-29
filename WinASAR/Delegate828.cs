using System;
using System.Data;

// Token: 0x0200054C RID: 1356
internal sealed class Delegate828 : MulticastDelegate
{
	// Token: 0x060024C4 RID: 9412
	public extern DataTable Invoke(object object_0);

	// Token: 0x060024C5 RID: 9413 RVA: 0x0000D3AA File Offset: 0x0000B5AA
	public static DataTable smethod_0(object object_0, Delegate828 delegate828_1)
	{
		return delegate828_1(object_0);
	}

	// Token: 0x060024C6 RID: 9414
	public extern Delegate828(object object_0, IntPtr intptr_0);

	// Token: 0x060024C7 RID: 9415 RVA: 0x0000D3B5 File Offset: 0x0000B5B5
	static Delegate828()
	{
		Class15.smethod_14(typeof(Delegate828).TypeHandle);
	}

	// Token: 0x04000D1C RID: 3356
	internal static Delegate828 delegate828_0;
}
