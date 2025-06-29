using System;
using System.Linq.Expressions;

// Token: 0x020005F8 RID: 1528
internal sealed class Delegate1000 : MulticastDelegate
{
	// Token: 0x06002774 RID: 10100
	public extern ExpressionType Invoke(object object_0);

	// Token: 0x06002775 RID: 10101 RVA: 0x0000E4D2 File Offset: 0x0000C6D2
	public static ExpressionType smethod_0(object object_0, Delegate1000 delegate1000_1)
	{
		return delegate1000_1(object_0);
	}

	// Token: 0x06002776 RID: 10102
	public extern Delegate1000(object object_0, IntPtr intptr_0);

	// Token: 0x06002777 RID: 10103 RVA: 0x0000E4DD File Offset: 0x0000C6DD
	static Delegate1000()
	{
		Class15.smethod_14(typeof(Delegate1000).TypeHandle);
	}

	// Token: 0x04000DC8 RID: 3528
	internal static Delegate1000 delegate1000_0;
}
