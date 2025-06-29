using System;

// Token: 0x02000435 RID: 1077
internal sealed class Delegate549 : MulticastDelegate
{
	// Token: 0x06002068 RID: 8296
	public extern Type Invoke(object object_0);

	// Token: 0x06002069 RID: 8297 RVA: 0x0000B80D File Offset: 0x00009A0D
	public static Type smethod_0(object object_0, Delegate549 delegate549_1)
	{
		return delegate549_1(object_0);
	}

	// Token: 0x0600206A RID: 8298
	public extern Delegate549(object object_0, IntPtr intptr_0);

	// Token: 0x0600206B RID: 8299 RVA: 0x0000B818 File Offset: 0x00009A18
	static Delegate549()
	{
		Class15.smethod_14(typeof(Delegate549).TypeHandle);
	}

	// Token: 0x04000C05 RID: 3077
	internal static Delegate549 delegate549_0;
}
