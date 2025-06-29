using System;

// Token: 0x0200046F RID: 1135
internal sealed class Delegate607 : MulticastDelegate
{
	// Token: 0x06002150 RID: 8528
	public extern object Invoke(Type type_0, ulong ulong_0);

	// Token: 0x06002151 RID: 8529 RVA: 0x0000BDD5 File Offset: 0x00009FD5
	public static object smethod_0(Type type_0, ulong ulong_0, Delegate607 delegate607_1)
	{
		return delegate607_1(type_0, ulong_0);
	}

	// Token: 0x06002152 RID: 8530
	public extern Delegate607(object object_0, IntPtr intptr_0);

	// Token: 0x06002153 RID: 8531 RVA: 0x0000BDE2 File Offset: 0x00009FE2
	static Delegate607()
	{
		Class15.smethod_14(typeof(Delegate607).TypeHandle);
	}

	// Token: 0x04000C3F RID: 3135
	internal static Delegate607 delegate607_0;
}
