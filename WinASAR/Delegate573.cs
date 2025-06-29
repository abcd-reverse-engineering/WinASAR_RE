using System;
using System.Reflection;

// Token: 0x0200044D RID: 1101
internal sealed class Delegate573 : MulticastDelegate
{
	// Token: 0x060020C8 RID: 8392
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x060020C9 RID: 8393 RVA: 0x0000BA73 File Offset: 0x00009C73
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate573 delegate573_1)
	{
		return delegate573_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x060020CA RID: 8394
	public extern Delegate573(object object_0, IntPtr intptr_0);

	// Token: 0x060020CB RID: 8395 RVA: 0x0000BA80 File Offset: 0x00009C80
	static Delegate573()
	{
		Class15.smethod_14(typeof(Delegate573).TypeHandle);
	}

	// Token: 0x04000C1D RID: 3101
	internal static Delegate573 delegate573_0;
}
