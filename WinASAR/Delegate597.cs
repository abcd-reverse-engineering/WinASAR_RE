using System;
using System.Linq.Expressions;

// Token: 0x02000465 RID: 1125
internal sealed class Delegate597 : MulticastDelegate
{
	// Token: 0x06002128 RID: 8488
	public extern Expression Invoke(object object_0);

	// Token: 0x06002129 RID: 8489 RVA: 0x0000BCD5 File Offset: 0x00009ED5
	public static Expression smethod_0(object object_0, Delegate597 delegate597_1)
	{
		return delegate597_1(object_0);
	}

	// Token: 0x0600212A RID: 8490
	public extern Delegate597(object object_0, IntPtr intptr_0);

	// Token: 0x0600212B RID: 8491 RVA: 0x0000BCE0 File Offset: 0x00009EE0
	static Delegate597()
	{
		Class15.smethod_14(typeof(Delegate597).TypeHandle);
	}

	// Token: 0x04000C35 RID: 3125
	internal static Delegate597 delegate597_0;
}
