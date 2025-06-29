using System;
using System.IO;

// Token: 0x020002E3 RID: 739
internal sealed class Delegate211 : MulticastDelegate
{
	// Token: 0x06001B20 RID: 6944
	public extern string[] Invoke(string string_0, string string_1, SearchOption searchOption_0);

	// Token: 0x06001B21 RID: 6945 RVA: 0x0000960B File Offset: 0x0000780B
	public static string[] smethod_0(string string_0, string string_1, SearchOption searchOption_0, Delegate211 delegate211_1)
	{
		return delegate211_1(string_0, string_1, searchOption_0);
	}

	// Token: 0x06001B22 RID: 6946
	public extern Delegate211(object object_0, IntPtr intptr_0);

	// Token: 0x06001B23 RID: 6947 RVA: 0x0000961A File Offset: 0x0000781A
	static Delegate211()
	{
		Class15.smethod_14(typeof(Delegate211).TypeHandle);
	}

	// Token: 0x04000AB3 RID: 2739
	internal static Delegate211 delegate211_0;
}
