using System;

// Token: 0x02000538 RID: 1336
internal sealed class Delegate808 : MulticastDelegate
{
	// Token: 0x06002474 RID: 9332
	public extern int Invoke(ref Guid guid_0, Guid guid_1);

	// Token: 0x06002475 RID: 9333 RVA: 0x0000D1AA File Offset: 0x0000B3AA
	public static int smethod_0(ref Guid guid_0, Guid guid_1, Delegate808 delegate808_1)
	{
		return delegate808_1(ref guid_0, guid_1);
	}

	// Token: 0x06002476 RID: 9334
	public extern Delegate808(object object_0, IntPtr intptr_0);

	// Token: 0x06002477 RID: 9335 RVA: 0x0000D1B7 File Offset: 0x0000B3B7
	static Delegate808()
	{
		Class15.smethod_14(typeof(Delegate808).TypeHandle);
	}

	// Token: 0x04000D08 RID: 3336
	internal static Delegate808 delegate808_0;
}
