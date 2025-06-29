using System;

// Token: 0x020003E7 RID: 999
internal sealed class Delegate471 : MulticastDelegate
{
	// Token: 0x06001F30 RID: 7984
	public extern int Invoke(object object_0);

	// Token: 0x06001F31 RID: 7985 RVA: 0x0000B037 File Offset: 0x00009237
	public static int smethod_0(object object_0, Delegate471 delegate471_1)
	{
		return delegate471_1(object_0);
	}

	// Token: 0x06001F32 RID: 7986
	public extern Delegate471(object object_0, IntPtr intptr_0);

	// Token: 0x06001F33 RID: 7987 RVA: 0x0000B042 File Offset: 0x00009242
	static Delegate471()
	{
		Class15.smethod_14(typeof(Delegate471).TypeHandle);
	}

	// Token: 0x04000BB7 RID: 2999
	internal static Delegate471 delegate471_0;
}
