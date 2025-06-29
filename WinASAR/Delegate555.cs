using System;

// Token: 0x0200043B RID: 1083
internal sealed class Delegate555 : MulticastDelegate
{
	// Token: 0x06002080 RID: 8320
	public extern Delegate Invoke(object object_0, Type type_0);

	// Token: 0x06002081 RID: 8321 RVA: 0x0000B8A1 File Offset: 0x00009AA1
	public static Delegate smethod_0(object object_0, Type type_0, Delegate555 delegate555_1)
	{
		return delegate555_1(object_0, type_0);
	}

	// Token: 0x06002082 RID: 8322
	public extern Delegate555(object object_0, IntPtr intptr_0);

	// Token: 0x06002083 RID: 8323 RVA: 0x0000B8AE File Offset: 0x00009AAE
	static Delegate555()
	{
		Class15.smethod_14(typeof(Delegate555).TypeHandle);
	}

	// Token: 0x04000C0B RID: 3083
	internal static Delegate555 delegate555_0;
}
