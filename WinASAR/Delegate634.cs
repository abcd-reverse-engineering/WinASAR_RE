using System;
using System.Reflection;

// Token: 0x0200048A RID: 1162
internal sealed class Delegate634 : MulticastDelegate
{
	// Token: 0x060021BC RID: 8636
	public extern ConstructorInfo Invoke(object object_0, Type[] type_0);

	// Token: 0x060021BD RID: 8637 RVA: 0x0000C097 File Offset: 0x0000A297
	public static ConstructorInfo smethod_0(object object_0, Type[] type_0, Delegate634 delegate634_1)
	{
		return delegate634_1(object_0, type_0);
	}

	// Token: 0x060021BE RID: 8638
	public extern Delegate634(object object_0, IntPtr intptr_0);

	// Token: 0x060021BF RID: 8639 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
	static Delegate634()
	{
		Class15.smethod_14(typeof(Delegate634).TypeHandle);
	}

	// Token: 0x04000C5A RID: 3162
	internal static Delegate634 delegate634_0;
}
