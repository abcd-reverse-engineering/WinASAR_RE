using System;

// Token: 0x0200057B RID: 1403
internal sealed class Delegate875 : MulticastDelegate
{
	// Token: 0x06002580 RID: 9600
	public extern string Invoke(object object_0);

	// Token: 0x06002581 RID: 9601 RVA: 0x0000D86C File Offset: 0x0000BA6C
	public static string smethod_0(object object_0, Delegate875 delegate875_1)
	{
		return delegate875_1(object_0);
	}

	// Token: 0x06002582 RID: 9602
	public extern Delegate875(object object_0, IntPtr intptr_0);

	// Token: 0x06002583 RID: 9603 RVA: 0x0000D877 File Offset: 0x0000BA77
	static Delegate875()
	{
		Class15.smethod_14(typeof(Delegate875).TypeHandle);
	}

	// Token: 0x04000D4B RID: 3403
	internal static Delegate875 delegate875_0;
}
