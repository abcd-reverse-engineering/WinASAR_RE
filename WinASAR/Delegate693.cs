using System;
using System.Reflection;

// Token: 0x020004C5 RID: 1221
internal sealed class Delegate693 : MulticastDelegate
{
	// Token: 0x060022A8 RID: 8872
	public extern MemberTypes Invoke(object object_0);

	// Token: 0x060022A9 RID: 8873 RVA: 0x0000C676 File Offset: 0x0000A876
	public static MemberTypes smethod_0(object object_0, Delegate693 delegate693_1)
	{
		return delegate693_1(object_0);
	}

	// Token: 0x060022AA RID: 8874
	public extern Delegate693(object object_0, IntPtr intptr_0);

	// Token: 0x060022AB RID: 8875 RVA: 0x0000C681 File Offset: 0x0000A881
	static Delegate693()
	{
		Class15.smethod_14(typeof(Delegate693).TypeHandle);
	}

	// Token: 0x04000C95 RID: 3221
	internal static Delegate693 delegate693_0;
}
