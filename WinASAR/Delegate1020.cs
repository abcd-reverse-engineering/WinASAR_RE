using System;

// Token: 0x0200060C RID: 1548
internal sealed class Delegate1020 : MulticastDelegate
{
	// Token: 0x060027C4 RID: 10180
	public extern object Invoke(Type type_0, long long_0);

	// Token: 0x060027C5 RID: 10181 RVA: 0x0000E6CA File Offset: 0x0000C8CA
	public static object smethod_0(Type type_0, long long_0, Delegate1020 delegate1020_1)
	{
		return delegate1020_1(type_0, long_0);
	}

	// Token: 0x060027C6 RID: 10182
	public extern Delegate1020(object object_0, IntPtr intptr_0);

	// Token: 0x060027C7 RID: 10183 RVA: 0x0000E6D7 File Offset: 0x0000C8D7
	static Delegate1020()
	{
		Class15.smethod_14(typeof(Delegate1020).TypeHandle);
	}

	// Token: 0x04000DDC RID: 3548
	internal static Delegate1020 delegate1020_0;
}
