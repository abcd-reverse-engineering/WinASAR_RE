using System;
using System.Collections.Generic;
using System.Linq.Expressions;

// Token: 0x0200047A RID: 1146
internal sealed class Delegate618 : MulticastDelegate
{
	// Token: 0x0600217C RID: 8572
	public extern BlockExpression Invoke(IEnumerable<ParameterExpression> ienumerable_0, IEnumerable<Expression> ienumerable_1);

	// Token: 0x0600217D RID: 8573 RVA: 0x0000BEFD File Offset: 0x0000A0FD
	public static BlockExpression smethod_0(IEnumerable<ParameterExpression> ienumerable_0, IEnumerable<Expression> ienumerable_1, Delegate618 delegate618_1)
	{
		return delegate618_1(ienumerable_0, ienumerable_1);
	}

	// Token: 0x0600217E RID: 8574
	public extern Delegate618(object object_0, IntPtr intptr_0);

	// Token: 0x0600217F RID: 8575 RVA: 0x0000BF0A File Offset: 0x0000A10A
	static Delegate618()
	{
		Class15.smethod_14(typeof(Delegate618).TypeHandle);
	}

	// Token: 0x04000C4A RID: 3146
	internal static Delegate618 delegate618_0;
}
