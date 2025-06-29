using System;

// Token: 0x020004E0 RID: 1248
internal sealed class Delegate720 : MulticastDelegate
{
	// Token: 0x06002314 RID: 8980
	public extern object Invoke(object object_0);

	// Token: 0x06002315 RID: 8981 RVA: 0x0000C902 File Offset: 0x0000AB02
	public static object smethod_0(object object_0, Delegate720 delegate720_1)
	{
		return delegate720_1(object_0);
	}

	// Token: 0x06002316 RID: 8982
	public extern Delegate720(object object_0, IntPtr intptr_0);

	// Token: 0x06002317 RID: 8983 RVA: 0x0000C90D File Offset: 0x0000AB0D
	static Delegate720()
	{
		Class15.smethod_14(typeof(Delegate720).TypeHandle);
	}

	// Token: 0x04000CB0 RID: 3248
	internal static Delegate720 delegate720_0;
}
