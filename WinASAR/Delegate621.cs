using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x0200047D RID: 1149
internal sealed class Delegate621 : MulticastDelegate
{
	// Token: 0x06002188 RID: 8584
	public extern MemberExpression Invoke(Expression expression_0, FieldInfo fieldInfo_0);

	// Token: 0x06002189 RID: 8585 RVA: 0x0000BF49 File Offset: 0x0000A149
	public static MemberExpression smethod_0(Expression expression_0, FieldInfo fieldInfo_0, Delegate621 delegate621_1)
	{
		return delegate621_1(expression_0, fieldInfo_0);
	}

	// Token: 0x0600218A RID: 8586
	public extern Delegate621(object object_0, IntPtr intptr_0);

	// Token: 0x0600218B RID: 8587 RVA: 0x0000BF56 File Offset: 0x0000A156
	static Delegate621()
	{
		Class15.smethod_14(typeof(Delegate621).TypeHandle);
	}

	// Token: 0x04000C4D RID: 3149
	internal static Delegate621 delegate621_0;
}
