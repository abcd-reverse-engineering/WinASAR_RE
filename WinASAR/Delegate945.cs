using System;

// Token: 0x020005C1 RID: 1473
internal sealed class Delegate945 : MulticastDelegate
{
	// Token: 0x06002698 RID: 9880
	public extern string Invoke(decimal decimal_0);

	// Token: 0x06002699 RID: 9881 RVA: 0x0000DF24 File Offset: 0x0000C124
	public static string smethod_0(decimal decimal_0, Delegate945 delegate945_1)
	{
		return delegate945_1(decimal_0);
	}

	// Token: 0x0600269A RID: 9882
	public extern Delegate945(object object_0, IntPtr intptr_0);

	// Token: 0x0600269B RID: 9883 RVA: 0x0000DF2F File Offset: 0x0000C12F
	static Delegate945()
	{
		Class15.smethod_14(typeof(Delegate945).TypeHandle);
	}

	// Token: 0x04000D91 RID: 3473
	internal static Delegate945 delegate945_0;
}
