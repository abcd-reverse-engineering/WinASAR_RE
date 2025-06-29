using System;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x02000476 RID: 1142
internal sealed class Delegate614 : MulticastDelegate
{
	// Token: 0x0600216C RID: 8556
	public extern NewExpression Invoke(ConstructorInfo constructorInfo_0, Expression[] expression_0);

	// Token: 0x0600216D RID: 8557 RVA: 0x0000BE93 File Offset: 0x0000A093
	public static NewExpression smethod_0(ConstructorInfo constructorInfo_0, Expression[] expression_0, Delegate614 delegate614_1)
	{
		return delegate614_1(constructorInfo_0, expression_0);
	}

	// Token: 0x0600216E RID: 8558
	public extern Delegate614(object object_0, IntPtr intptr_0);

	// Token: 0x0600216F RID: 8559 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
	static Delegate614()
	{
		Class15.smethod_14(typeof(Delegate614).TypeHandle);
	}

	// Token: 0x04000C46 RID: 3142
	internal static Delegate614 delegate614_0;
}
