using System;

// Token: 0x02000589 RID: 1417
internal sealed class Delegate889 : MulticastDelegate
{
	// Token: 0x060025B8 RID: 9656
	public extern string Invoke(object object_0);

	// Token: 0x060025B9 RID: 9657 RVA: 0x0000D9BC File Offset: 0x0000BBBC
	public static string smethod_0(object object_0, Delegate889 delegate889_1)
	{
		return delegate889_1(object_0);
	}

	// Token: 0x060025BA RID: 9658
	public extern Delegate889(object object_0, IntPtr intptr_0);

	// Token: 0x060025BB RID: 9659 RVA: 0x0000D9C7 File Offset: 0x0000BBC7
	static Delegate889()
	{
		Class15.smethod_14(typeof(Delegate889).TypeHandle);
	}

	// Token: 0x04000D59 RID: 3417
	internal static Delegate889 delegate889_0;
}
