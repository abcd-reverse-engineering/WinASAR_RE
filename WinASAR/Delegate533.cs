using System;
using System.Linq.Expressions;

// Token: 0x02000425 RID: 1061
internal sealed class Delegate533 : MulticastDelegate
{
	// Token: 0x06002028 RID: 8232
	public extern ConstantExpression Invoke(object object_0, Type type_0);

	// Token: 0x06002029 RID: 8233 RVA: 0x0000B677 File Offset: 0x00009877
	public static ConstantExpression smethod_0(object object_0, Type type_0, Delegate533 delegate533_1)
	{
		return delegate533_1(object_0, type_0);
	}

	// Token: 0x0600202A RID: 8234
	public extern Delegate533(object object_0, IntPtr intptr_0);

	// Token: 0x0600202B RID: 8235 RVA: 0x0000B684 File Offset: 0x00009884
	static Delegate533()
	{
		Class15.smethod_14(typeof(Delegate533).TypeHandle);
	}

	// Token: 0x04000BF5 RID: 3061
	internal static Delegate533 delegate533_0;
}
