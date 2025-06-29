using System;
using System.Globalization;

// Token: 0x020004BF RID: 1215
internal sealed class Delegate687 : MulticastDelegate
{
	// Token: 0x06002290 RID: 8848
	public extern char Invoke(char char_0, CultureInfo cultureInfo_0);

	// Token: 0x06002291 RID: 8849 RVA: 0x0000C5DE File Offset: 0x0000A7DE
	public static char smethod_0(char char_0, CultureInfo cultureInfo_0, Delegate687 delegate687_1)
	{
		return delegate687_1(char_0, cultureInfo_0);
	}

	// Token: 0x06002292 RID: 8850
	public extern Delegate687(object object_0, IntPtr intptr_0);

	// Token: 0x06002293 RID: 8851 RVA: 0x0000C5EB File Offset: 0x0000A7EB
	static Delegate687()
	{
		Class15.smethod_14(typeof(Delegate687).TypeHandle);
	}

	// Token: 0x04000C8F RID: 3215
	internal static Delegate687 delegate687_0;
}
