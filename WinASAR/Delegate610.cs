using System;
using System.Linq.Expressions;

// Token: 0x02000472 RID: 1138
internal sealed class Delegate610 : MulticastDelegate
{
	// Token: 0x0600215C RID: 8540
	public extern LambdaExpression Invoke(Type type_0, Expression expression_0, ParameterExpression[] parameterExpression_0);

	// Token: 0x0600215D RID: 8541 RVA: 0x0000BE2D File Offset: 0x0000A02D
	public static LambdaExpression smethod_0(Type type_0, Expression expression_0, ParameterExpression[] parameterExpression_0, Delegate610 delegate610_1)
	{
		return delegate610_1(type_0, expression_0, parameterExpression_0);
	}

	// Token: 0x0600215E RID: 8542
	public extern Delegate610(object object_0, IntPtr intptr_0);

	// Token: 0x0600215F RID: 8543 RVA: 0x0000BE3C File Offset: 0x0000A03C
	static Delegate610()
	{
		Class15.smethod_14(typeof(Delegate610).TypeHandle);
	}

	// Token: 0x04000C42 RID: 3138
	internal static Delegate610 delegate610_0;
}
