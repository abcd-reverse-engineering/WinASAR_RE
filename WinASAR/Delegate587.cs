using System;
using System.Dynamic;
using System.Linq.Expressions;

// Token: 0x0200045B RID: 1115
internal sealed class Delegate587 : MulticastDelegate
{
	// Token: 0x06002100 RID: 8448
	public extern DynamicMetaObject Invoke(object object_0, Expression expression_0);

	// Token: 0x06002101 RID: 8449 RVA: 0x0000BBDD File Offset: 0x00009DDD
	public static DynamicMetaObject smethod_0(object object_0, Expression expression_0, Delegate587 delegate587_1)
	{
		return delegate587_1(object_0, expression_0);
	}

	// Token: 0x06002102 RID: 8450
	public extern Delegate587(object object_0, IntPtr intptr_0);

	// Token: 0x06002103 RID: 8451 RVA: 0x0000BBEA File Offset: 0x00009DEA
	static Delegate587()
	{
		Class15.smethod_14(typeof(Delegate587).TypeHandle);
	}

	// Token: 0x04000C2B RID: 3115
	internal static Delegate587 delegate587_0;
}
