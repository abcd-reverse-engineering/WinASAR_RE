using System;

// Token: 0x02000590 RID: 1424
internal sealed class Delegate896 : MulticastDelegate
{
	// Token: 0x060025D4 RID: 9684
	public extern string Invoke(object object_0);

	// Token: 0x060025D5 RID: 9685 RVA: 0x0000DA6A File Offset: 0x0000BC6A
	public static string smethod_0(object object_0, Delegate896 delegate896_1)
	{
		return delegate896_1(object_0);
	}

	// Token: 0x060025D6 RID: 9686
	public extern Delegate896(object object_0, IntPtr intptr_0);

	// Token: 0x060025D7 RID: 9687 RVA: 0x0000DA75 File Offset: 0x0000BC75
	static Delegate896()
	{
		Class15.smethod_14(typeof(Delegate896).TypeHandle);
	}

	// Token: 0x04000D60 RID: 3424
	internal static Delegate896 delegate896_0;
}
