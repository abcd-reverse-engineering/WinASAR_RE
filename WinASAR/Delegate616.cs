using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x02000478 RID: 1144
internal sealed class Delegate616 : MulticastDelegate
{
	// Token: 0x06002174 RID: 8564
	public extern MethodCallExpression Invoke(Expression expression_0, MethodInfo methodInfo_0, Expression[] expression_1);

	// Token: 0x06002175 RID: 8565 RVA: 0x0000BEC7 File Offset: 0x0000A0C7
	public static MethodCallExpression smethod_0(Expression expression_0, MethodInfo methodInfo_0, Expression[] expression_1, Delegate616 delegate616_1)
	{
		return delegate616_1(expression_0, methodInfo_0, expression_1);
	}

	// Token: 0x06002176 RID: 8566
	public extern Delegate616(object object_0, IntPtr intptr_0);

	// Token: 0x06002177 RID: 8567 RVA: 0x0000BED6 File Offset: 0x0000A0D6
	static Delegate616()
	{
		Class15.smethod_14(typeof(Delegate616).TypeHandle);
	}

	// Token: 0x04000C48 RID: 3144
	internal static Delegate616 delegate616_0;
}
