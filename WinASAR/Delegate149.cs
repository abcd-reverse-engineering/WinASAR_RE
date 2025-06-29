using System;

// Token: 0x020002A5 RID: 677
internal sealed class Delegate149 : MulticastDelegate
{
	// Token: 0x06001A28 RID: 6696
	public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

	// Token: 0x06001A29 RID: 6697 RVA: 0x00008FEB File Offset: 0x000071EB
	public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0, Delegate149 delegate149_1)
	{
		return delegate149_1(object_0, string_0, stringComparison_0);
	}

	// Token: 0x06001A2A RID: 6698
	public extern Delegate149(object object_0, IntPtr intptr_0);

	// Token: 0x06001A2B RID: 6699 RVA: 0x00008FFA File Offset: 0x000071FA
	static Delegate149()
	{
		Class15.smethod_14(typeof(Delegate149).TypeHandle);
	}

	// Token: 0x04000A75 RID: 2677
	internal static Delegate149 delegate149_0;
}
