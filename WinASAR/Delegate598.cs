using System;
using System.Linq.Expressions;

// Token: 0x02000466 RID: 1126
internal sealed class Delegate598 : MulticastDelegate
{
	// Token: 0x0600212C RID: 8492
	public extern Expression Invoke(object object_0);

	// Token: 0x0600212D RID: 8493 RVA: 0x0000BCED File Offset: 0x00009EED
	public static Expression smethod_0(object object_0, Delegate598 delegate598_1)
	{
		return delegate598_1(object_0);
	}

	// Token: 0x0600212E RID: 8494
	public extern Delegate598(object object_0, IntPtr intptr_0);

	// Token: 0x0600212F RID: 8495 RVA: 0x0000BCF8 File Offset: 0x00009EF8
	static Delegate598()
	{
		Class15.smethod_14(typeof(Delegate598).TypeHandle);
	}

	// Token: 0x04000C36 RID: 3126
	internal static Delegate598 delegate598_0;
}
