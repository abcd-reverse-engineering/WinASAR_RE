using System;
using System.Reflection;

// Token: 0x02000499 RID: 1177
internal sealed class Delegate649 : MulticastDelegate
{
	// Token: 0x060021F8 RID: 8696
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x060021F9 RID: 8697 RVA: 0x0000C219 File Offset: 0x0000A419
	public static MethodInfo smethod_0(object object_0, Delegate649 delegate649_1)
	{
		return delegate649_1(object_0);
	}

	// Token: 0x060021FA RID: 8698
	public extern Delegate649(object object_0, IntPtr intptr_0);

	// Token: 0x060021FB RID: 8699 RVA: 0x0000C224 File Offset: 0x0000A424
	static Delegate649()
	{
		Class15.smethod_14(typeof(Delegate649).TypeHandle);
	}

	// Token: 0x04000C69 RID: 3177
	internal static Delegate649 delegate649_0;
}
