using System;

// Token: 0x020002C3 RID: 707
internal sealed class Delegate179 : MulticastDelegate
{
	// Token: 0x06001AA0 RID: 6816
	public extern string Invoke(object object_0);

	// Token: 0x06001AA1 RID: 6817 RVA: 0x000092E5 File Offset: 0x000074E5
	public static string smethod_0(object object_0, Delegate179 delegate179_1)
	{
		return delegate179_1(object_0);
	}

	// Token: 0x06001AA2 RID: 6818
	public extern Delegate179(object object_0, IntPtr intptr_0);

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000092F0 File Offset: 0x000074F0
	static Delegate179()
	{
		Class15.smethod_14(typeof(Delegate179).TypeHandle);
	}

	// Token: 0x04000A93 RID: 2707
	internal static Delegate179 delegate179_0;
}
