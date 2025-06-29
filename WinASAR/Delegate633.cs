using System;
using System.Reflection;

// Token: 0x02000489 RID: 1161
internal sealed class Delegate633 : MulticastDelegate
{
	// Token: 0x060021B8 RID: 8632
	public extern MethodInfo Invoke(object object_0, Type[] type_0);

	// Token: 0x060021B9 RID: 8633 RVA: 0x0000C07D File Offset: 0x0000A27D
	public static MethodInfo smethod_0(object object_0, Type[] type_0, Delegate633 delegate633_1)
	{
		return delegate633_1(object_0, type_0);
	}

	// Token: 0x060021BA RID: 8634
	public extern Delegate633(object object_0, IntPtr intptr_0);

	// Token: 0x060021BB RID: 8635 RVA: 0x0000C08A File Offset: 0x0000A28A
	static Delegate633()
	{
		Class15.smethod_14(typeof(Delegate633).TypeHandle);
	}

	// Token: 0x04000C59 RID: 3161
	internal static Delegate633 delegate633_0;
}
