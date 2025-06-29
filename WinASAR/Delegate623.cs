using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x0200047F RID: 1151
internal sealed class Delegate623 : MulticastDelegate
{
	// Token: 0x06002190 RID: 8592
	public extern MethodCallExpression Invoke(MethodInfo methodInfo_0, Expression expression_0);

	// Token: 0x06002191 RID: 8593 RVA: 0x0000BF7B File Offset: 0x0000A17B
	public static MethodCallExpression smethod_0(MethodInfo methodInfo_0, Expression expression_0, Delegate623 delegate623_1)
	{
		return delegate623_1(methodInfo_0, expression_0);
	}

	// Token: 0x06002192 RID: 8594
	public extern Delegate623(object object_0, IntPtr intptr_0);

	// Token: 0x06002193 RID: 8595 RVA: 0x0000BF88 File Offset: 0x0000A188
	static Delegate623()
	{
		Class15.smethod_14(typeof(Delegate623).TypeHandle);
	}

	// Token: 0x04000C4F RID: 3151
	internal static Delegate623 delegate623_0;
}
