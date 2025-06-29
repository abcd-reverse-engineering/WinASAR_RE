using System;

// Token: 0x020003A3 RID: 931
internal sealed class Delegate403 : MulticastDelegate
{
	// Token: 0x06001E20 RID: 7712
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06001E21 RID: 7713 RVA: 0x0000A955 File Offset: 0x00008B55
	public static bool smethod_0(string string_0, string string_1, Delegate403 delegate403_1)
	{
		return delegate403_1(string_0, string_1);
	}

	// Token: 0x06001E22 RID: 7714
	public extern Delegate403(object object_0, IntPtr intptr_0);

	// Token: 0x06001E23 RID: 7715 RVA: 0x0000A962 File Offset: 0x00008B62
	static Delegate403()
	{
		Class15.smethod_14(typeof(Delegate403).TypeHandle);
	}

	// Token: 0x04000B73 RID: 2931
	internal static Delegate403 delegate403_0;
}
