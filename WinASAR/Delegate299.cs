using System;

// Token: 0x0200033B RID: 827
internal sealed class Delegate299 : MulticastDelegate
{
	// Token: 0x06001C80 RID: 7296
	public extern string Invoke(object object_0);

	// Token: 0x06001C81 RID: 7297 RVA: 0x00009EC5 File Offset: 0x000080C5
	public static string smethod_0(object object_0, Delegate299 delegate299_1)
	{
		return delegate299_1(object_0);
	}

	// Token: 0x06001C82 RID: 7298
	public extern Delegate299(object object_0, IntPtr intptr_0);

	// Token: 0x06001C83 RID: 7299 RVA: 0x00009ED0 File Offset: 0x000080D0
	static Delegate299()
	{
		Class15.smethod_14(typeof(Delegate299).TypeHandle);
	}

	// Token: 0x04000B0B RID: 2827
	internal static Delegate299 delegate299_0;
}
