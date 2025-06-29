using System;
using System.Reflection;

// Token: 0x0200049B RID: 1179
internal sealed class Delegate651 : MulticastDelegate
{
	// Token: 0x06002200 RID: 8704
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x06002201 RID: 8705 RVA: 0x0000C249 File Offset: 0x0000A449
	public static MethodInfo smethod_0(object object_0, Delegate651 delegate651_1)
	{
		return delegate651_1(object_0);
	}

	// Token: 0x06002202 RID: 8706
	public extern Delegate651(object object_0, IntPtr intptr_0);

	// Token: 0x06002203 RID: 8707 RVA: 0x0000C254 File Offset: 0x0000A454
	static Delegate651()
	{
		Class15.smethod_14(typeof(Delegate651).TypeHandle);
	}

	// Token: 0x04000C6B RID: 3179
	internal static Delegate651 delegate651_0;
}
