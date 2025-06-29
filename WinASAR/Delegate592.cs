using System;
using System.Linq.Expressions;

// Token: 0x02000460 RID: 1120
internal sealed class Delegate592 : MulticastDelegate
{
	// Token: 0x06002114 RID: 8468
	public extern Expression Invoke(object object_0, Expression expression_0);

	// Token: 0x06002115 RID: 8469 RVA: 0x0000BC5B File Offset: 0x00009E5B
	public static Expression smethod_0(object object_0, Expression expression_0, Delegate592 delegate592_1)
	{
		return delegate592_1(object_0, expression_0);
	}

	// Token: 0x06002116 RID: 8470
	public extern Delegate592(object object_0, IntPtr intptr_0);

	// Token: 0x06002117 RID: 8471 RVA: 0x0000BC68 File Offset: 0x00009E68
	static Delegate592()
	{
		Class15.smethod_14(typeof(Delegate592).TypeHandle);
	}

	// Token: 0x04000C30 RID: 3120
	internal static Delegate592 delegate592_0;
}
