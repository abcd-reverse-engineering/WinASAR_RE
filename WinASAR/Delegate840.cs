using System;

// Token: 0x02000558 RID: 1368
internal sealed class Delegate840 : MulticastDelegate
{
	// Token: 0x060024F4 RID: 9460
	public extern Type Invoke(object object_0);

	// Token: 0x060024F5 RID: 9461 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
	public static Type smethod_0(object object_0, Delegate840 delegate840_1)
	{
		return delegate840_1(object_0);
	}

	// Token: 0x060024F6 RID: 9462
	public extern Delegate840(object object_0, IntPtr intptr_0);

	// Token: 0x060024F7 RID: 9463 RVA: 0x0000D4E3 File Offset: 0x0000B6E3
	static Delegate840()
	{
		Class15.smethod_14(typeof(Delegate840).TypeHandle);
	}

	// Token: 0x04000D28 RID: 3368
	internal static Delegate840 delegate840_0;
}
