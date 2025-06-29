using System;
using System.Linq.Expressions;

// Token: 0x02000424 RID: 1060
internal sealed class Delegate532 : MulticastDelegate
{
	// Token: 0x06002024 RID: 8228
	public extern UnaryExpression Invoke(Expression expression_0, Type type_0);

	// Token: 0x06002025 RID: 8229 RVA: 0x0000B65D File Offset: 0x0000985D
	public static UnaryExpression smethod_0(Expression expression_0, Type type_0, Delegate532 delegate532_1)
	{
		return delegate532_1(expression_0, type_0);
	}

	// Token: 0x06002026 RID: 8230
	public extern Delegate532(object object_0, IntPtr intptr_0);

	// Token: 0x06002027 RID: 8231 RVA: 0x0000B66A File Offset: 0x0000986A
	static Delegate532()
	{
		Class15.smethod_14(typeof(Delegate532).TypeHandle);
	}

	// Token: 0x04000BF4 RID: 3060
	internal static Delegate532 delegate532_0;
}
