using System;
using System.Reflection;

// Token: 0x020004C4 RID: 1220
internal sealed class Delegate692 : MulticastDelegate
{
	// Token: 0x060022A4 RID: 8868
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x060022A5 RID: 8869 RVA: 0x0000C65E File Offset: 0x0000A85E
	public static MethodInfo smethod_0(object object_0, Delegate692 delegate692_1)
	{
		return delegate692_1(object_0);
	}

	// Token: 0x060022A6 RID: 8870
	public extern Delegate692(object object_0, IntPtr intptr_0);

	// Token: 0x060022A7 RID: 8871 RVA: 0x0000C669 File Offset: 0x0000A869
	static Delegate692()
	{
		Class15.smethod_14(typeof(Delegate692).TypeHandle);
	}

	// Token: 0x04000C94 RID: 3220
	internal static Delegate692 delegate692_0;
}
