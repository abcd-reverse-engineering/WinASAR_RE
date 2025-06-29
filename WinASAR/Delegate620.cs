using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x0200047C RID: 1148
internal sealed class Delegate620 : MulticastDelegate
{
	// Token: 0x06002184 RID: 8580
	public extern MemberExpression Invoke(Expression expression_0, MemberInfo memberInfo_0);

	// Token: 0x06002185 RID: 8581 RVA: 0x0000BF2F File Offset: 0x0000A12F
	public static MemberExpression smethod_0(Expression expression_0, MemberInfo memberInfo_0, Delegate620 delegate620_1)
	{
		return delegate620_1(expression_0, memberInfo_0);
	}

	// Token: 0x06002186 RID: 8582
	public extern Delegate620(object object_0, IntPtr intptr_0);

	// Token: 0x06002187 RID: 8583 RVA: 0x0000BF3C File Offset: 0x0000A13C
	static Delegate620()
	{
		Class15.smethod_14(typeof(Delegate620).TypeHandle);
	}

	// Token: 0x04000C4C RID: 3148
	internal static Delegate620 delegate620_0;
}
