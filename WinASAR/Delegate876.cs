using System;

// Token: 0x0200057C RID: 1404
internal sealed class Delegate876 : MulticastDelegate
{
	// Token: 0x06002584 RID: 9604
	public extern string Invoke(object object_0);

	// Token: 0x06002585 RID: 9605 RVA: 0x0000D884 File Offset: 0x0000BA84
	public static string smethod_0(object object_0, Delegate876 delegate876_1)
	{
		return delegate876_1(object_0);
	}

	// Token: 0x06002586 RID: 9606
	public extern Delegate876(object object_0, IntPtr intptr_0);

	// Token: 0x06002587 RID: 9607 RVA: 0x0000D88F File Offset: 0x0000BA8F
	static Delegate876()
	{
		Class15.smethod_14(typeof(Delegate876).TypeHandle);
	}

	// Token: 0x04000D4C RID: 3404
	internal static Delegate876 delegate876_0;
}
