using System;
using System.Reflection;

// Token: 0x020004D3 RID: 1235
internal sealed class Delegate707 : MulticastDelegate
{
	// Token: 0x060022E0 RID: 8928
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x060022E1 RID: 8929 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
	public static MethodInfo smethod_0(object object_0, Delegate707 delegate707_1)
	{
		return delegate707_1(object_0);
	}

	// Token: 0x060022E2 RID: 8930
	public extern Delegate707(object object_0, IntPtr intptr_0);

	// Token: 0x060022E3 RID: 8931 RVA: 0x0000C7D3 File Offset: 0x0000A9D3
	static Delegate707()
	{
		Class15.smethod_14(typeof(Delegate707).TypeHandle);
	}

	// Token: 0x04000CA3 RID: 3235
	internal static Delegate707 delegate707_0;
}
