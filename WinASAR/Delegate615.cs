using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x02000477 RID: 1143
internal sealed class Delegate615 : MulticastDelegate
{
	// Token: 0x06002170 RID: 8560
	public extern MethodCallExpression Invoke(MethodInfo methodInfo_0, Expression[] expression_0);

	// Token: 0x06002171 RID: 8561 RVA: 0x0000BEAD File Offset: 0x0000A0AD
	public static MethodCallExpression smethod_0(MethodInfo methodInfo_0, Expression[] expression_0, Delegate615 delegate615_1)
	{
		return delegate615_1(methodInfo_0, expression_0);
	}

	// Token: 0x06002172 RID: 8562
	public extern Delegate615(object object_0, IntPtr intptr_0);

	// Token: 0x06002173 RID: 8563 RVA: 0x0000BEBA File Offset: 0x0000A0BA
	static Delegate615()
	{
		Class15.smethod_14(typeof(Delegate615).TypeHandle);
	}

	// Token: 0x04000C47 RID: 3143
	internal static Delegate615 delegate615_0;
}
