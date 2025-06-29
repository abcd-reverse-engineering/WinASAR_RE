using System;

// Token: 0x020004CA RID: 1226
internal sealed class Delegate698 : MulticastDelegate
{
	// Token: 0x060022BC RID: 8892
	public extern Type Invoke(object object_0);

	// Token: 0x060022BD RID: 8893 RVA: 0x0000C6EE File Offset: 0x0000A8EE
	public static Type smethod_0(object object_0, Delegate698 delegate698_1)
	{
		return delegate698_1(object_0);
	}

	// Token: 0x060022BE RID: 8894
	public extern Delegate698(object object_0, IntPtr intptr_0);

	// Token: 0x060022BF RID: 8895 RVA: 0x0000C6F9 File Offset: 0x0000A8F9
	static Delegate698()
	{
		Class15.smethod_14(typeof(Delegate698).TypeHandle);
	}

	// Token: 0x04000C9A RID: 3226
	internal static Delegate698 delegate698_0;
}
