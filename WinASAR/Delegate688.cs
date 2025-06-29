using System;

// Token: 0x020004C0 RID: 1216
internal sealed class Delegate688 : MulticastDelegate
{
	// Token: 0x06002294 RID: 8852
	public extern bool Invoke(char char_0);

	// Token: 0x06002295 RID: 8853 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
	public static bool smethod_0(char char_0, Delegate688 delegate688_0)
	{
		return delegate688_0(char_0);
	}

	// Token: 0x06002296 RID: 8854
	public extern Delegate688(object object_0, IntPtr intptr_0);

	// Token: 0x06002297 RID: 8855 RVA: 0x0000C603 File Offset: 0x0000A803
	static Delegate688()
	{
		Class15.smethod_14(typeof(Delegate688).TypeHandle);
	}

	// Token: 0x04000C90 RID: 3216
	internal static Delegate688 PpJzEyeYqK;
}
