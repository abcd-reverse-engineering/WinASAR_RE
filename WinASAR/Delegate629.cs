using System;
using System.Reflection;

// Token: 0x02000485 RID: 1157
internal sealed class Delegate629 : MulticastDelegate
{
	// Token: 0x060021A8 RID: 8616
	public extern MethodInfo Invoke(object object_0, string string_0);

	// Token: 0x060021A9 RID: 8617 RVA: 0x0000C015 File Offset: 0x0000A215
	public static MethodInfo smethod_0(object object_0, string string_0, Delegate629 delegate629_1)
	{
		return delegate629_1(object_0, string_0);
	}

	// Token: 0x060021AA RID: 8618
	public extern Delegate629(object object_0, IntPtr intptr_0);

	// Token: 0x060021AB RID: 8619 RVA: 0x0000C022 File Offset: 0x0000A222
	static Delegate629()
	{
		Class15.smethod_14(typeof(Delegate629).TypeHandle);
	}

	// Token: 0x04000C55 RID: 3157
	internal static Delegate629 delegate629_0;
}
