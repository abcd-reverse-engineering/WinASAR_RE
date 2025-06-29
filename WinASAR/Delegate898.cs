using System;

// Token: 0x02000592 RID: 1426
internal sealed class Delegate898 : MulticastDelegate
{
	// Token: 0x060025DC RID: 9692
	public extern string Invoke(object object_0);

	// Token: 0x060025DD RID: 9693 RVA: 0x0000DA9C File Offset: 0x0000BC9C
	public static string smethod_0(object object_0, Delegate898 delegate898_1)
	{
		return delegate898_1(object_0);
	}

	// Token: 0x060025DE RID: 9694
	public extern Delegate898(object object_0, IntPtr intptr_0);

	// Token: 0x060025DF RID: 9695 RVA: 0x0000DAA7 File Offset: 0x0000BCA7
	static Delegate898()
	{
		Class15.smethod_14(typeof(Delegate898).TypeHandle);
	}

	// Token: 0x04000D62 RID: 3426
	internal static Delegate898 delegate898_0;
}
