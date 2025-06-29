using System;
using System.Data;

// Token: 0x0200054D RID: 1357
internal sealed class Delegate829 : MulticastDelegate
{
	// Token: 0x060024C8 RID: 9416
	public extern DataColumnCollection Invoke(object object_0);

	// Token: 0x060024C9 RID: 9417 RVA: 0x0000D3C2 File Offset: 0x0000B5C2
	public static DataColumnCollection smethod_0(object object_0, Delegate829 delegate829_1)
	{
		return delegate829_1(object_0);
	}

	// Token: 0x060024CA RID: 9418
	public extern Delegate829(object object_0, IntPtr intptr_0);

	// Token: 0x060024CB RID: 9419 RVA: 0x0000D3CD File Offset: 0x0000B5CD
	static Delegate829()
	{
		Class15.smethod_14(typeof(Delegate829).TypeHandle);
	}

	// Token: 0x04000D1D RID: 3357
	internal static Delegate829 delegate829_0;
}
