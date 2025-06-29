using System;
using System.Linq.Expressions;

// Token: 0x02000474 RID: 1140
internal sealed class Delegate612 : MulticastDelegate
{
	// Token: 0x06002164 RID: 8548
	public extern BinaryExpression Invoke(Expression expression_0, Expression expression_1);

	// Token: 0x06002165 RID: 8549 RVA: 0x0000BE61 File Offset: 0x0000A061
	public static BinaryExpression smethod_0(Expression expression_0, Expression expression_1, Delegate612 delegate612_1)
	{
		return delegate612_1(expression_0, expression_1);
	}

	// Token: 0x06002166 RID: 8550
	public extern Delegate612(object object_0, IntPtr intptr_0);

	// Token: 0x06002167 RID: 8551 RVA: 0x0000BE6E File Offset: 0x0000A06E
	static Delegate612()
	{
		Class15.smethod_14(typeof(Delegate612).TypeHandle);
	}

	// Token: 0x04000C44 RID: 3140
	internal static Delegate612 delegate612_0;
}
