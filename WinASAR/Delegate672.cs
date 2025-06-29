using System;
using System.Reflection;

// Token: 0x020004B0 RID: 1200
internal sealed class Delegate672 : MulticastDelegate
{
	// Token: 0x06002254 RID: 8788
	public extern Attribute[] Invoke(Module module_0, Type type_0, bool bool_0);

	// Token: 0x06002255 RID: 8789 RVA: 0x0000C459 File Offset: 0x0000A659
	public static Attribute[] smethod_0(Module module_0, Type type_0, bool bool_0, Delegate672 delegate672_1)
	{
		return delegate672_1(module_0, type_0, bool_0);
	}

	// Token: 0x06002256 RID: 8790
	public extern Delegate672(object object_0, IntPtr intptr_0);

	// Token: 0x06002257 RID: 8791 RVA: 0x0000C468 File Offset: 0x0000A668
	static Delegate672()
	{
		Class15.smethod_14(typeof(Delegate672).TypeHandle);
	}

	// Token: 0x04000C80 RID: 3200
	internal static Delegate672 delegate672_0;
}
