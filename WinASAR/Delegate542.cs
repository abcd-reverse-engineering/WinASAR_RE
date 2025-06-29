using System;
using System.Linq.Expressions;

// Token: 0x0200042E RID: 1070
internal sealed class Delegate542 : MulticastDelegate
{
	// Token: 0x0600204C RID: 8268
	public extern ConditionalExpression Invoke(Expression expression_0, Expression expression_1, Expression expression_2, Type type_0);

	// Token: 0x0600204D RID: 8269 RVA: 0x0000B75B File Offset: 0x0000995B
	public static ConditionalExpression smethod_0(Expression expression_0, Expression expression_1, Expression expression_2, Type type_0, Delegate542 delegate542_1)
	{
		return delegate542_1(expression_0, expression_1, expression_2, type_0);
	}

	// Token: 0x0600204E RID: 8270
	public extern Delegate542(object object_0, IntPtr intptr_0);

	// Token: 0x0600204F RID: 8271 RVA: 0x0000B76C File Offset: 0x0000996C
	static Delegate542()
	{
		Class15.smethod_14(typeof(Delegate542).TypeHandle);
	}

	// Token: 0x04000BFE RID: 3070
	internal static Delegate542 delegate542_0;
}
