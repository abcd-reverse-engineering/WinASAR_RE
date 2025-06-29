using System;

// Token: 0x02000575 RID: 1397
internal sealed class Delegate869 : MulticastDelegate
{
	// Token: 0x06002568 RID: 9576
	public extern string Invoke(object object_0);

	// Token: 0x06002569 RID: 9577 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
	public static string smethod_0(object object_0, Delegate869 delegate869_1)
	{
		return delegate869_1(object_0);
	}

	// Token: 0x0600256A RID: 9578
	public extern Delegate869(object object_0, IntPtr intptr_0);

	// Token: 0x0600256B RID: 9579 RVA: 0x0000D7E3 File Offset: 0x0000B9E3
	static Delegate869()
	{
		Class15.smethod_14(typeof(Delegate869).TypeHandle);
	}

	// Token: 0x04000D45 RID: 3397
	internal static Delegate869 delegate869_0;
}
