using System;

// Token: 0x020004C1 RID: 1217
internal sealed class Delegate689 : MulticastDelegate
{
	// Token: 0x06002298 RID: 8856
	public extern bool Invoke(char char_0);

	// Token: 0x06002299 RID: 8857 RVA: 0x0000C610 File Offset: 0x0000A810
	public static bool smethod_0(char char_0, Delegate689 delegate689_1)
	{
		return delegate689_1(char_0);
	}

	// Token: 0x0600229A RID: 8858
	public extern Delegate689(object object_0, IntPtr intptr_0);

	// Token: 0x0600229B RID: 8859 RVA: 0x0000C61B File Offset: 0x0000A81B
	static Delegate689()
	{
		Class15.smethod_14(typeof(Delegate689).TypeHandle);
	}

	// Token: 0x04000C91 RID: 3217
	internal static Delegate689 delegate689_0;
}
