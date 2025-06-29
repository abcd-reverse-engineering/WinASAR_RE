using System;
using System.Reflection;

// Token: 0x020004D4 RID: 1236
internal sealed class Delegate708 : MulticastDelegate
{
	// Token: 0x060022E4 RID: 8932
	public extern ConstructorInfo[] Invoke(object object_0);

	// Token: 0x060022E5 RID: 8933 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
	public static ConstructorInfo[] smethod_0(object object_0, Delegate708 delegate708_1)
	{
		return delegate708_1(object_0);
	}

	// Token: 0x060022E6 RID: 8934
	public extern Delegate708(object object_0, IntPtr intptr_0);

	// Token: 0x060022E7 RID: 8935 RVA: 0x0000C7EB File Offset: 0x0000A9EB
	static Delegate708()
	{
		Class15.smethod_14(typeof(Delegate708).TypeHandle);
	}

	// Token: 0x04000CA4 RID: 3236
	internal static Delegate708 delegate708_0;
}
