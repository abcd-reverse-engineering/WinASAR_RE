using System;
using System.Linq.Expressions;

// Token: 0x02000482 RID: 1154
internal sealed class Delegate626 : MulticastDelegate
{
	// Token: 0x0600219C RID: 8604
	public extern BinaryExpression Invoke(Expression expression_0, Expression expression_1);

	// Token: 0x0600219D RID: 8605 RVA: 0x0000BFC9 File Offset: 0x0000A1C9
	public static BinaryExpression smethod_0(Expression expression_0, Expression expression_1, Delegate626 delegate626_1)
	{
		return delegate626_1(expression_0, expression_1);
	}

	// Token: 0x0600219E RID: 8606
	public extern Delegate626(object object_0, IntPtr intptr_0);

	// Token: 0x0600219F RID: 8607 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
	static Delegate626()
	{
		Class15.smethod_14(typeof(Delegate626).TypeHandle);
	}

	// Token: 0x04000C52 RID: 3154
	internal static Delegate626 delegate626_0;
}
