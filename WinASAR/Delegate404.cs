using System;
using System.Collections.Generic;

// Token: 0x020003A4 RID: 932
internal sealed class Delegate404 : MulticastDelegate
{
	// Token: 0x06001E24 RID: 7716
	public extern string Invoke(string string_0, IEnumerable<string> ienumerable_0);

	// Token: 0x06001E25 RID: 7717 RVA: 0x0000A96F File Offset: 0x00008B6F
	public static string smethod_0(string string_0, IEnumerable<string> ienumerable_0, Delegate404 delegate404_1)
	{
		return delegate404_1(string_0, ienumerable_0);
	}

	// Token: 0x06001E26 RID: 7718
	public extern Delegate404(object object_0, IntPtr intptr_0);

	// Token: 0x06001E27 RID: 7719 RVA: 0x0000A97C File Offset: 0x00008B7C
	static Delegate404()
	{
		Class15.smethod_14(typeof(Delegate404).TypeHandle);
	}

	// Token: 0x04000B74 RID: 2932
	internal static Delegate404 delegate404_0;
}
