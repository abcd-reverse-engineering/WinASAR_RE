using System;
using System.Linq.Expressions;

// Token: 0x02000468 RID: 1128
internal sealed class Delegate600 : MulticastDelegate
{
	// Token: 0x06002134 RID: 8500
	public extern Expression Invoke(object object_0, ConditionalExpression conditionalExpression_0);

	// Token: 0x06002135 RID: 8501 RVA: 0x0000BD21 File Offset: 0x00009F21
	public static Expression smethod_0(object object_0, ConditionalExpression conditionalExpression_0, Delegate600 delegate600_1)
	{
		return delegate600_1(object_0, conditionalExpression_0);
	}

	// Token: 0x06002136 RID: 8502
	public extern Delegate600(object object_0, IntPtr intptr_0);

	// Token: 0x06002137 RID: 8503 RVA: 0x0000BD2E File Offset: 0x00009F2E
	static Delegate600()
	{
		Class15.smethod_14(typeof(Delegate600).TypeHandle);
	}

	// Token: 0x04000C38 RID: 3128
	internal static Delegate600 delegate600_0;
}
