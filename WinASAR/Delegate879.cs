using System;

// Token: 0x0200057F RID: 1407
internal sealed class Delegate879 : MulticastDelegate
{
	// Token: 0x06002590 RID: 9616
	public extern bool Invoke(object object_0);

	// Token: 0x06002591 RID: 9617 RVA: 0x0000D8CC File Offset: 0x0000BACC
	public static bool smethod_0(object object_0, Delegate879 delegate879_1)
	{
		return delegate879_1(object_0);
	}

	// Token: 0x06002592 RID: 9618
	public extern Delegate879(object object_0, IntPtr intptr_0);

	// Token: 0x06002593 RID: 9619 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
	static Delegate879()
	{
		Class15.smethod_14(typeof(Delegate879).TypeHandle);
	}

	// Token: 0x04000D4F RID: 3407
	internal static Delegate879 delegate879_0;
}
