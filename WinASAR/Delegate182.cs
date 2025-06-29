using System;

// Token: 0x020002C6 RID: 710
internal sealed class Delegate182 : MulticastDelegate
{
	// Token: 0x06001AAC RID: 6828
	public extern string Invoke(string string_0, object object_0, object object_1);

	// Token: 0x06001AAD RID: 6829 RVA: 0x00009331 File Offset: 0x00007531
	public static string smethod_0(string string_0, object object_0, object object_1, Delegate182 delegate182_1)
	{
		return delegate182_1(string_0, object_0, object_1);
	}

	// Token: 0x06001AAE RID: 6830
	public extern Delegate182(object object_0, IntPtr intptr_0);

	// Token: 0x06001AAF RID: 6831 RVA: 0x00009340 File Offset: 0x00007540
	static Delegate182()
	{
		Class15.smethod_14(typeof(Delegate182).TypeHandle);
	}

	// Token: 0x04000A96 RID: 2710
	internal static Delegate182 delegate182_0;
}
