using System;

// Token: 0x02000574 RID: 1396
internal sealed class Delegate868 : MulticastDelegate
{
	// Token: 0x06002564 RID: 9572
	public extern string Invoke(object object_0);

	// Token: 0x06002565 RID: 9573 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
	public static string smethod_0(object object_0, Delegate868 delegate868_1)
	{
		return delegate868_1(object_0);
	}

	// Token: 0x06002566 RID: 9574
	public extern Delegate868(object object_0, IntPtr intptr_0);

	// Token: 0x06002567 RID: 9575 RVA: 0x0000D7CB File Offset: 0x0000B9CB
	static Delegate868()
	{
		Class15.smethod_14(typeof(Delegate868).TypeHandle);
	}

	// Token: 0x04000D44 RID: 3396
	internal static Delegate868 delegate868_0;
}
