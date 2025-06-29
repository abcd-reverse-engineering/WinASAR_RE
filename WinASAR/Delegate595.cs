using System;
using System.Linq.Expressions;

// Token: 0x02000463 RID: 1123
internal sealed class Delegate595 : MulticastDelegate
{
	// Token: 0x06002120 RID: 8480
	public extern Expression Invoke(object object_0);

	// Token: 0x06002121 RID: 8481 RVA: 0x0000BCA5 File Offset: 0x00009EA5
	public static Expression smethod_0(object object_0, Delegate595 delegate595_1)
	{
		return delegate595_1(object_0);
	}

	// Token: 0x06002122 RID: 8482
	public extern Delegate595(object object_0, IntPtr intptr_0);

	// Token: 0x06002123 RID: 8483 RVA: 0x0000BCB0 File Offset: 0x00009EB0
	static Delegate595()
	{
		Class15.smethod_14(typeof(Delegate595).TypeHandle);
	}

	// Token: 0x04000C33 RID: 3123
	internal static Delegate595 delegate595_0;
}
