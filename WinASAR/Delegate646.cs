using System;
using System.Reflection;

// Token: 0x02000496 RID: 1174
internal sealed class Delegate646 : MulticastDelegate
{
	// Token: 0x060021EC RID: 8684
	public extern bool Invoke(MethodBase methodBase_0, MethodBase methodBase_1);

	// Token: 0x060021ED RID: 8685 RVA: 0x0000C1CB File Offset: 0x0000A3CB
	public static bool smethod_0(MethodBase methodBase_0, MethodBase methodBase_1, Delegate646 delegate646_1)
	{
		return delegate646_1(methodBase_0, methodBase_1);
	}

	// Token: 0x060021EE RID: 8686
	public extern Delegate646(object object_0, IntPtr intptr_0);

	// Token: 0x060021EF RID: 8687 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
	static Delegate646()
	{
		Class15.smethod_14(typeof(Delegate646).TypeHandle);
	}

	// Token: 0x04000C66 RID: 3174
	internal static Delegate646 delegate646_0;
}
