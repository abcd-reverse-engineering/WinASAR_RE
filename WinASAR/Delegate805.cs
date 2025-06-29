using System;

// Token: 0x02000535 RID: 1333
internal sealed class Delegate805 : MulticastDelegate
{
	// Token: 0x06002468 RID: 9320
	public extern int Invoke(ref bool bool_0, bool bool_1);

	// Token: 0x06002469 RID: 9321 RVA: 0x0000D15C File Offset: 0x0000B35C
	public static int smethod_0(ref bool bool_0, bool bool_1, Delegate805 delegate805_1)
	{
		return delegate805_1(ref bool_0, bool_1);
	}

	// Token: 0x0600246A RID: 9322
	public extern Delegate805(object object_0, IntPtr intptr_0);

	// Token: 0x0600246B RID: 9323 RVA: 0x0000D169 File Offset: 0x0000B369
	static Delegate805()
	{
		Class15.smethod_14(typeof(Delegate805).TypeHandle);
	}

	// Token: 0x04000D05 RID: 3333
	internal static Delegate805 delegate805_0;
}
