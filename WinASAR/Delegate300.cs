using System;

// Token: 0x0200033C RID: 828
internal sealed class Delegate300 : MulticastDelegate
{
	// Token: 0x06001C84 RID: 7300
	public extern DateTime Invoke(object object_0);

	// Token: 0x06001C85 RID: 7301 RVA: 0x00009EDD File Offset: 0x000080DD
	public static DateTime smethod_0(object object_0, Delegate300 delegate300_1)
	{
		return delegate300_1(object_0);
	}

	// Token: 0x06001C86 RID: 7302
	public extern Delegate300(object object_0, IntPtr intptr_0);

	// Token: 0x06001C87 RID: 7303 RVA: 0x00009EE8 File Offset: 0x000080E8
	static Delegate300()
	{
		Class15.smethod_14(typeof(Delegate300).TypeHandle);
	}

	// Token: 0x04000B0C RID: 2828
	internal static Delegate300 delegate300_0;
}
