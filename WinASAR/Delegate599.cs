using System;
using System.Linq.Expressions;

// Token: 0x02000467 RID: 1127
internal sealed class Delegate599 : MulticastDelegate
{
	// Token: 0x06002130 RID: 8496
	public extern ConditionalExpression Invoke(Expression expression_0, Expression expression_1, Expression expression_2);

	// Token: 0x06002131 RID: 8497 RVA: 0x0000BD05 File Offset: 0x00009F05
	public static ConditionalExpression smethod_0(Expression expression_0, Expression expression_1, Expression expression_2, Delegate599 delegate599_1)
	{
		return delegate599_1(expression_0, expression_1, expression_2);
	}

	// Token: 0x06002132 RID: 8498
	public extern Delegate599(object object_0, IntPtr intptr_0);

	// Token: 0x06002133 RID: 8499 RVA: 0x0000BD14 File Offset: 0x00009F14
	static Delegate599()
	{
		Class15.smethod_14(typeof(Delegate599).TypeHandle);
	}

	// Token: 0x04000C37 RID: 3127
	internal static Delegate599 delegate599_0;
}
