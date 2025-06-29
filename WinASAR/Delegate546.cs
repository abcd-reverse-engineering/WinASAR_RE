using System;
using System.Linq.Expressions;

// Token: 0x02000432 RID: 1074
internal sealed class Delegate546 : MulticastDelegate
{
	// Token: 0x0600205C RID: 8284
	public extern DefaultExpression Invoke();

	// Token: 0x0600205D RID: 8285 RVA: 0x0000B7C7 File Offset: 0x000099C7
	public static DefaultExpression smethod_0(Delegate546 delegate546_1)
	{
		return delegate546_1();
	}

	// Token: 0x0600205E RID: 8286
	public extern Delegate546(object object_0, IntPtr intptr_0);

	// Token: 0x0600205F RID: 8287 RVA: 0x0000B7D0 File Offset: 0x000099D0
	static Delegate546()
	{
		Class15.smethod_14(typeof(Delegate546).TypeHandle);
	}

	// Token: 0x04000C02 RID: 3074
	internal static Delegate546 delegate546_0;
}
