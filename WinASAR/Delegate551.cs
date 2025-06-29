using System;
using System.Dynamic;
using System.Linq.Expressions;

// Token: 0x02000437 RID: 1079
internal sealed class Delegate551 : MulticastDelegate
{
	// Token: 0x06002070 RID: 8304
	public extern BindingRestrictions Invoke(Expression expression_0, object object_0);

	// Token: 0x06002071 RID: 8305 RVA: 0x0000B83F File Offset: 0x00009A3F
	public static BindingRestrictions smethod_0(Expression expression_0, object object_0, Delegate551 delegate551_1)
	{
		return delegate551_1(expression_0, object_0);
	}

	// Token: 0x06002072 RID: 8306
	public extern Delegate551(object object_0, IntPtr intptr_0);

	// Token: 0x06002073 RID: 8307 RVA: 0x0000B84C File Offset: 0x00009A4C
	static Delegate551()
	{
		Class15.smethod_14(typeof(Delegate551).TypeHandle);
	}

	// Token: 0x04000C07 RID: 3079
	internal static Delegate551 delegate551_0;
}
