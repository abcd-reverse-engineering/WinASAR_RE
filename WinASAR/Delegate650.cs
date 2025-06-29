using System;
using System.Reflection;

// Token: 0x0200049A RID: 1178
internal sealed class Delegate650 : MulticastDelegate
{
	// Token: 0x060021FC RID: 8700
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x060021FD RID: 8701 RVA: 0x0000C231 File Offset: 0x0000A431
	public static MethodInfo smethod_0(object object_0, Delegate650 delegate650_1)
	{
		return delegate650_1(object_0);
	}

	// Token: 0x060021FE RID: 8702
	public extern Delegate650(object object_0, IntPtr intptr_0);

	// Token: 0x060021FF RID: 8703 RVA: 0x0000C23C File Offset: 0x0000A43C
	static Delegate650()
	{
		Class15.smethod_14(typeof(Delegate650).TypeHandle);
	}

	// Token: 0x04000C6A RID: 3178
	internal static Delegate650 delegate650_0;
}
