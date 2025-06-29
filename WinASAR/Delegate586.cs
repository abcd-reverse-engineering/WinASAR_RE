using System;
using System.Reflection;

// Token: 0x0200045A RID: 1114
internal sealed class Delegate586 : MulticastDelegate
{
	// Token: 0x060020FC RID: 8444
	public extern MethodInfo Invoke(object object_0, bool bool_0);

	// Token: 0x060020FD RID: 8445 RVA: 0x0000BBC3 File Offset: 0x00009DC3
	public static MethodInfo smethod_0(object object_0, bool bool_0, Delegate586 delegate586_1)
	{
		return delegate586_1(object_0, bool_0);
	}

	// Token: 0x060020FE RID: 8446
	public extern Delegate586(object object_0, IntPtr intptr_0);

	// Token: 0x060020FF RID: 8447 RVA: 0x0000BBD0 File Offset: 0x00009DD0
	static Delegate586()
	{
		Class15.smethod_14(typeof(Delegate586).TypeHandle);
	}

	// Token: 0x04000C2A RID: 3114
	internal static Delegate586 delegate586_0;
}
