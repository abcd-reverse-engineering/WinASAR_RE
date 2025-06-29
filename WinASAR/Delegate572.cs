using System;
using System.Reflection;

// Token: 0x0200044C RID: 1100
internal sealed class Delegate572 : MulticastDelegate
{
	// Token: 0x060020C4 RID: 8388
	public extern MethodInfo Invoke(object object_0, string string_0, Type[] type_0);

	// Token: 0x060020C5 RID: 8389 RVA: 0x0000BA57 File Offset: 0x00009C57
	public static MethodInfo smethod_0(object object_0, string string_0, Type[] type_0, Delegate572 delegate572_1)
	{
		return delegate572_1(object_0, string_0, type_0);
	}

	// Token: 0x060020C6 RID: 8390
	public extern Delegate572(object object_0, IntPtr intptr_0);

	// Token: 0x060020C7 RID: 8391 RVA: 0x0000BA66 File Offset: 0x00009C66
	static Delegate572()
	{
		Class15.smethod_14(typeof(Delegate572).TypeHandle);
	}

	// Token: 0x04000C1C RID: 3100
	internal static Delegate572 delegate572_0;
}
