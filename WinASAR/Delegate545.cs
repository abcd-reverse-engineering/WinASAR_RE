using System;
using System.Linq.Expressions;

// Token: 0x02000431 RID: 1073
internal sealed class Delegate545 : MulticastDelegate
{
	// Token: 0x06002058 RID: 8280
	public extern BinaryExpression Invoke(Expression expression_0, Expression expression_1);

	// Token: 0x06002059 RID: 8281 RVA: 0x0000B7AD File Offset: 0x000099AD
	public static BinaryExpression smethod_0(Expression expression_0, Expression expression_1, Delegate545 delegate545_1)
	{
		return delegate545_1(expression_0, expression_1);
	}

	// Token: 0x0600205A RID: 8282
	public extern Delegate545(object object_0, IntPtr intptr_0);

	// Token: 0x0600205B RID: 8283 RVA: 0x0000B7BA File Offset: 0x000099BA
	static Delegate545()
	{
		Class15.smethod_14(typeof(Delegate545).TypeHandle);
	}

	// Token: 0x04000C01 RID: 3073
	internal static Delegate545 delegate545_0;
}
