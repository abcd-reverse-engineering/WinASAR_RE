using System;
using System.Collections.Generic;
using System.Linq.Expressions;

// Token: 0x02000421 RID: 1057
internal sealed class Delegate529 : MulticastDelegate
{
	// Token: 0x06002018 RID: 8216
	public extern NewArrayExpression Invoke(Type type_0, IEnumerable<Expression> ienumerable_0);

	// Token: 0x06002019 RID: 8217 RVA: 0x0000B613 File Offset: 0x00009813
	public static NewArrayExpression smethod_0(Type type_0, IEnumerable<Expression> ienumerable_0, Delegate529 delegate529_1)
	{
		return delegate529_1(type_0, ienumerable_0);
	}

	// Token: 0x0600201A RID: 8218
	public extern Delegate529(object object_0, IntPtr intptr_0);

	// Token: 0x0600201B RID: 8219 RVA: 0x0000B620 File Offset: 0x00009820
	static Delegate529()
	{
		Class15.smethod_14(typeof(Delegate529).TypeHandle);
	}

	// Token: 0x04000BF1 RID: 3057
	internal static Delegate529 delegate529_0;
}
