using System;

// Token: 0x020005BD RID: 1469
internal sealed class Delegate941 : MulticastDelegate
{
	// Token: 0x06002688 RID: 9864
	public extern string Invoke(object object_0, string string_0);

	// Token: 0x06002689 RID: 9865 RVA: 0x0000DEBE File Offset: 0x0000C0BE
	public static string smethod_0(object object_0, string string_0, Delegate941 delegate941_1)
	{
		return delegate941_1(object_0, string_0);
	}

	// Token: 0x0600268A RID: 9866
	public extern Delegate941(object object_0, IntPtr intptr_0);

	// Token: 0x0600268B RID: 9867 RVA: 0x0000DECB File Offset: 0x0000C0CB
	static Delegate941()
	{
		Class15.smethod_14(typeof(Delegate941).TypeHandle);
	}

	// Token: 0x04000D8D RID: 3469
	internal static Delegate941 delegate941_0;
}
