using System;

// Token: 0x02000579 RID: 1401
internal sealed class Delegate873 : MulticastDelegate
{
	// Token: 0x06002578 RID: 9592
	public extern string Invoke(object object_0);

	// Token: 0x06002579 RID: 9593 RVA: 0x0000D83C File Offset: 0x0000BA3C
	public static string smethod_0(object object_0, Delegate873 delegate873_1)
	{
		return delegate873_1(object_0);
	}

	// Token: 0x0600257A RID: 9594
	public extern Delegate873(object object_0, IntPtr intptr_0);

	// Token: 0x0600257B RID: 9595 RVA: 0x0000D847 File Offset: 0x0000BA47
	static Delegate873()
	{
		Class15.smethod_14(typeof(Delegate873).TypeHandle);
	}

	// Token: 0x04000D49 RID: 3401
	internal static Delegate873 delegate873_0;
}
