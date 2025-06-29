using System;
using System.Text.RegularExpressions;

// Token: 0x02000544 RID: 1348
internal sealed class Delegate820 : MulticastDelegate
{
	// Token: 0x060024A4 RID: 9380
	public extern bool Invoke(string string_0, string string_1, RegexOptions regexOptions_0);

	// Token: 0x060024A5 RID: 9381 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
	public static bool smethod_0(string string_0, string string_1, RegexOptions regexOptions_0, Delegate820 delegate820_1)
	{
		return delegate820_1(string_0, string_1, regexOptions_0);
	}

	// Token: 0x060024A6 RID: 9382
	public extern Delegate820(object object_0, IntPtr intptr_0);

	// Token: 0x060024A7 RID: 9383 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
	static Delegate820()
	{
		Class15.smethod_14(typeof(Delegate820).TypeHandle);
	}

	// Token: 0x04000D14 RID: 3348
	internal static Delegate820 delegate820_0;
}
