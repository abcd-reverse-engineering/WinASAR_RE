using System;
using System.Collections.Generic;
using System.Linq.Expressions;

// Token: 0x0200042F RID: 1071
internal sealed class Delegate543 : MulticastDelegate
{
	// Token: 0x06002050 RID: 8272
	public extern BlockExpression Invoke(IEnumerable<ParameterExpression> ienumerable_0, Expression[] expression_0);

	// Token: 0x06002051 RID: 8273 RVA: 0x0000B779 File Offset: 0x00009979
	public static BlockExpression smethod_0(IEnumerable<ParameterExpression> ienumerable_0, Expression[] expression_0, Delegate543 delegate543_1)
	{
		return delegate543_1(ienumerable_0, expression_0);
	}

	// Token: 0x06002052 RID: 8274
	public extern Delegate543(object object_0, IntPtr intptr_0);

	// Token: 0x06002053 RID: 8275 RVA: 0x0000B786 File Offset: 0x00009986
	static Delegate543()
	{
		Class15.smethod_14(typeof(Delegate543).TypeHandle);
	}

	// Token: 0x04000BFF RID: 3071
	internal static Delegate543 delegate543_0;
}
