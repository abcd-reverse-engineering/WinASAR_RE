using System;
using System.Linq.Expressions;

// Token: 0x02000483 RID: 1155
internal sealed class Delegate627 : MulticastDelegate
{
	// Token: 0x060021A0 RID: 8608
	public extern DefaultExpression Invoke(Type type_0);

	// Token: 0x060021A1 RID: 8609 RVA: 0x0000BFE3 File Offset: 0x0000A1E3
	public static DefaultExpression smethod_0(Type type_0, Delegate627 delegate627_1)
	{
		return delegate627_1(type_0);
	}

	// Token: 0x060021A2 RID: 8610
	public extern Delegate627(object object_0, IntPtr intptr_0);

	// Token: 0x060021A3 RID: 8611 RVA: 0x0000BFEE File Offset: 0x0000A1EE
	static Delegate627()
	{
		Class15.smethod_14(typeof(Delegate627).TypeHandle);
	}

	// Token: 0x04000C53 RID: 3155
	internal static Delegate627 delegate627_0;
}
