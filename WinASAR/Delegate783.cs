using System;

// Token: 0x0200051F RID: 1311
internal sealed class Delegate783 : MulticastDelegate
{
	// Token: 0x06002410 RID: 9232
	public extern char Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002411 RID: 9233 RVA: 0x0000CF30 File Offset: 0x0000B130
	public static char smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate783 delegate783_1)
	{
		return delegate783_1(object_0, iformatProvider_0);
	}

	// Token: 0x06002412 RID: 9234
	public extern Delegate783(object object_0, IntPtr intptr_0);

	// Token: 0x06002413 RID: 9235 RVA: 0x0000CF3D File Offset: 0x0000B13D
	static Delegate783()
	{
		Class15.smethod_14(typeof(Delegate783).TypeHandle);
	}

	// Token: 0x04000CEF RID: 3311
	internal static Delegate783 delegate783_0;
}
