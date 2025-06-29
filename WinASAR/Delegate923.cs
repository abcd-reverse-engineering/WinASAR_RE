using System;

// Token: 0x020005AB RID: 1451
internal sealed class Delegate923 : MulticastDelegate
{
	// Token: 0x06002640 RID: 9792
	public extern string Invoke(object object_0);

	// Token: 0x06002641 RID: 9793 RVA: 0x0000DD02 File Offset: 0x0000BF02
	public static string smethod_0(object object_0, Delegate923 delegate923_1)
	{
		return delegate923_1(object_0);
	}

	// Token: 0x06002642 RID: 9794
	public extern Delegate923(object object_0, IntPtr intptr_0);

	// Token: 0x06002643 RID: 9795 RVA: 0x0000DD0D File Offset: 0x0000BF0D
	static Delegate923()
	{
		Class15.smethod_14(typeof(Delegate923).TypeHandle);
	}

	// Token: 0x04000D7B RID: 3451
	internal static Delegate923 delegate923_0;
}
