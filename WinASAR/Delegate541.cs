using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x0200042D RID: 1069
internal sealed class Delegate541 : MulticastDelegate
{
	// Token: 0x06002048 RID: 8264
	public extern MethodCallExpression Invoke(Expression expression_0, MethodInfo methodInfo_0, IEnumerable<Expression> ienumerable_0);

	// Token: 0x06002049 RID: 8265 RVA: 0x0000B73F File Offset: 0x0000993F
	public static MethodCallExpression smethod_0(Expression expression_0, MethodInfo methodInfo_0, IEnumerable<Expression> ienumerable_0, Delegate541 delegate541_1)
	{
		return delegate541_1(expression_0, methodInfo_0, ienumerable_0);
	}

	// Token: 0x0600204A RID: 8266
	public extern Delegate541(object object_0, IntPtr intptr_0);

	// Token: 0x0600204B RID: 8267 RVA: 0x0000B74E File Offset: 0x0000994E
	static Delegate541()
	{
		Class15.smethod_14(typeof(Delegate541).TypeHandle);
	}

	// Token: 0x04000BFD RID: 3069
	internal static Delegate541 delegate541_0;
}
