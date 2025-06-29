using System;

// Token: 0x02000624 RID: 1572
internal sealed class Delegate1044 : MulticastDelegate
{
	// Token: 0x06002824 RID: 10276
	public extern IntPtr Invoke(int int_0);

	// Token: 0x06002825 RID: 10277 RVA: 0x0000E918 File Offset: 0x0000CB18
	public static IntPtr smethod_0(int int_0, Delegate1044 delegate1044_1)
	{
		return delegate1044_1(int_0);
	}

	// Token: 0x06002826 RID: 10278
	public extern Delegate1044(object object_0, IntPtr intptr_0);

	// Token: 0x06002827 RID: 10279 RVA: 0x0000E923 File Offset: 0x0000CB23
	static Delegate1044()
	{
		Class15.smethod_14(typeof(Delegate1044).TypeHandle);
	}

	// Token: 0x04000DF4 RID: 3572
	internal static Delegate1044 delegate1044_0;
}
