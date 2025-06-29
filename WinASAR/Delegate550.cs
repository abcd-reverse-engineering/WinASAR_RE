using System;
using System.Dynamic;
using System.Linq.Expressions;

// Token: 0x02000436 RID: 1078
internal sealed class Delegate550 : MulticastDelegate
{
	// Token: 0x0600206C RID: 8300
	public extern BindingRestrictions Invoke(Expression expression_0, Type type_0);

	// Token: 0x0600206D RID: 8301 RVA: 0x0000B825 File Offset: 0x00009A25
	public static BindingRestrictions smethod_0(Expression expression_0, Type type_0, Delegate550 delegate550_1)
	{
		return delegate550_1(expression_0, type_0);
	}

	// Token: 0x0600206E RID: 8302
	public extern Delegate550(object object_0, IntPtr intptr_0);

	// Token: 0x0600206F RID: 8303 RVA: 0x0000B832 File Offset: 0x00009A32
	static Delegate550()
	{
		Class15.smethod_14(typeof(Delegate550).TypeHandle);
	}

	// Token: 0x04000C06 RID: 3078
	internal static Delegate550 delegate550_0;
}
