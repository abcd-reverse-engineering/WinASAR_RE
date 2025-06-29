using System;
using System.Linq.Expressions;

// Token: 0x02000481 RID: 1153
internal sealed class Delegate625 : MulticastDelegate
{
	// Token: 0x06002198 RID: 8600
	public extern TypeBinaryExpression Invoke(Expression expression_0, Type type_0);

	// Token: 0x06002199 RID: 8601 RVA: 0x0000BFAF File Offset: 0x0000A1AF
	public static TypeBinaryExpression smethod_0(Expression expression_0, Type type_0, Delegate625 delegate625_1)
	{
		return delegate625_1(expression_0, type_0);
	}

	// Token: 0x0600219A RID: 8602
	public extern Delegate625(object object_0, IntPtr intptr_0);

	// Token: 0x0600219B RID: 8603 RVA: 0x0000BFBC File Offset: 0x0000A1BC
	static Delegate625()
	{
		Class15.smethod_14(typeof(Delegate625).TypeHandle);
	}

	// Token: 0x04000C51 RID: 3153
	internal static Delegate625 delegate625_0;
}
