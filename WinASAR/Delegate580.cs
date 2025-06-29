using System;

// Token: 0x02000454 RID: 1108
internal sealed class Delegate580 : MulticastDelegate
{
	// Token: 0x060020E4 RID: 8420
	public extern Type Invoke(object object_0);

	// Token: 0x060020E5 RID: 8421 RVA: 0x0000BB2D File Offset: 0x00009D2D
	public static Type smethod_0(object object_0, Delegate580 delegate580_1)
	{
		return delegate580_1(object_0);
	}

	// Token: 0x060020E6 RID: 8422
	public extern Delegate580(object object_0, IntPtr intptr_0);

	// Token: 0x060020E7 RID: 8423 RVA: 0x0000BB38 File Offset: 0x00009D38
	static Delegate580()
	{
		Class15.smethod_14(typeof(Delegate580).TypeHandle);
	}

	// Token: 0x04000C24 RID: 3108
	internal static Delegate580 delegate580_0;
}
