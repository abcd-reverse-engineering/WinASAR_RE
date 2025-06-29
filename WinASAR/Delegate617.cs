using System;
using System.Linq.Expressions;

// Token: 0x02000479 RID: 1145
internal sealed class Delegate617 : MulticastDelegate
{
	// Token: 0x06002178 RID: 8568
	public extern BlockExpression Invoke(Expression expression_0, Expression expression_1);

	// Token: 0x06002179 RID: 8569 RVA: 0x0000BEE3 File Offset: 0x0000A0E3
	public static BlockExpression smethod_0(Expression expression_0, Expression expression_1, Delegate617 delegate617_1)
	{
		return delegate617_1(expression_0, expression_1);
	}

	// Token: 0x0600217A RID: 8570
	public extern Delegate617(object object_0, IntPtr intptr_0);

	// Token: 0x0600217B RID: 8571 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
	static Delegate617()
	{
		Class15.smethod_14(typeof(Delegate617).TypeHandle);
	}

	// Token: 0x04000C49 RID: 3145
	internal static Delegate617 delegate617_0;
}
