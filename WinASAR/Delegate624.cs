using System;
using System.Linq.Expressions;

// Token: 0x02000480 RID: 1152
internal sealed class Delegate624 : MulticastDelegate
{
	// Token: 0x06002194 RID: 8596
	public extern UnaryExpression Invoke(Expression expression_0, Type type_0);

	// Token: 0x06002195 RID: 8597 RVA: 0x0000BF95 File Offset: 0x0000A195
	public static UnaryExpression smethod_0(Expression expression_0, Type type_0, Delegate624 delegate624_1)
	{
		return delegate624_1(expression_0, type_0);
	}

	// Token: 0x06002196 RID: 8598
	public extern Delegate624(object object_0, IntPtr intptr_0);

	// Token: 0x06002197 RID: 8599 RVA: 0x0000BFA2 File Offset: 0x0000A1A2
	static Delegate624()
	{
		Class15.smethod_14(typeof(Delegate624).TypeHandle);
	}

	// Token: 0x04000C50 RID: 3152
	internal static Delegate624 delegate624_0;
}
