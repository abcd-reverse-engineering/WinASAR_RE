using System;
using System.Linq.Expressions;

// Token: 0x02000464 RID: 1124
internal sealed class Delegate596 : MulticastDelegate
{
	// Token: 0x06002124 RID: 8484
	public extern ExpressionType Invoke(object object_0);

	// Token: 0x06002125 RID: 8485 RVA: 0x0000BCBD File Offset: 0x00009EBD
	public static ExpressionType smethod_0(object object_0, Delegate596 delegate596_1)
	{
		return delegate596_1(object_0);
	}

	// Token: 0x06002126 RID: 8486
	public extern Delegate596(object object_0, IntPtr intptr_0);

	// Token: 0x06002127 RID: 8487 RVA: 0x0000BCC8 File Offset: 0x00009EC8
	static Delegate596()
	{
		Class15.smethod_14(typeof(Delegate596).TypeHandle);
	}

	// Token: 0x04000C34 RID: 3124
	internal static Delegate596 delegate596_0;
}
