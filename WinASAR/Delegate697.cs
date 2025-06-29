using System;

// Token: 0x020004C9 RID: 1225
internal sealed class Delegate697 : MulticastDelegate
{
	// Token: 0x060022B8 RID: 8888
	public extern bool Invoke(object object_0);

	// Token: 0x060022B9 RID: 8889 RVA: 0x0000C6D6 File Offset: 0x0000A8D6
	public static bool smethod_0(object object_0, Delegate697 delegate697_1)
	{
		return delegate697_1(object_0);
	}

	// Token: 0x060022BA RID: 8890
	public extern Delegate697(object object_0, IntPtr intptr_0);

	// Token: 0x060022BB RID: 8891 RVA: 0x0000C6E1 File Offset: 0x0000A8E1
	static Delegate697()
	{
		Class15.smethod_14(typeof(Delegate697).TypeHandle);
	}

	// Token: 0x04000C99 RID: 3225
	internal static Delegate697 delegate697_0;
}
