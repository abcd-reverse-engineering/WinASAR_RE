using System;

// Token: 0x020003AD RID: 941
internal sealed class Delegate413 : MulticastDelegate
{
	// Token: 0x06001E48 RID: 7752
	public extern bool Invoke(string string_0, string string_1, StringComparison stringComparison_0);

	// Token: 0x06001E49 RID: 7753 RVA: 0x0000AA53 File Offset: 0x00008C53
	public static bool smethod_0(string string_0, string string_1, StringComparison stringComparison_0, Delegate413 delegate413_1)
	{
		return delegate413_1(string_0, string_1, stringComparison_0);
	}

	// Token: 0x06001E4A RID: 7754
	public extern Delegate413(object object_0, IntPtr intptr_0);

	// Token: 0x06001E4B RID: 7755 RVA: 0x0000AA62 File Offset: 0x00008C62
	static Delegate413()
	{
		Class15.smethod_14(typeof(Delegate413).TypeHandle);
	}

	// Token: 0x04000B7D RID: 2941
	internal static Delegate413 delegate413_0;
}
