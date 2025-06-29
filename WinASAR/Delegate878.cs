using System;

// Token: 0x0200057E RID: 1406
internal sealed class Delegate878 : MulticastDelegate
{
	// Token: 0x0600258C RID: 9612
	public extern string Invoke(object object_0);

	// Token: 0x0600258D RID: 9613 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
	public static string smethod_0(object object_0, Delegate878 delegate878_1)
	{
		return delegate878_1(object_0);
	}

	// Token: 0x0600258E RID: 9614
	public extern Delegate878(object object_0, IntPtr intptr_0);

	// Token: 0x0600258F RID: 9615 RVA: 0x0000D8BF File Offset: 0x0000BABF
	static Delegate878()
	{
		Class15.smethod_14(typeof(Delegate878).TypeHandle);
	}

	// Token: 0x04000D4E RID: 3406
	internal static Delegate878 delegate878_0;
}
