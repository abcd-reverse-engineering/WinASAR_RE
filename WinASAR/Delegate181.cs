using System;

// Token: 0x020002C5 RID: 709
internal sealed class Delegate181 : MulticastDelegate
{
	// Token: 0x06001AA8 RID: 6824
	public extern string Invoke(string string_0, object object_0, object object_1, object object_2);

	// Token: 0x06001AA9 RID: 6825 RVA: 0x00009313 File Offset: 0x00007513
	public static string smethod_0(string string_0, object object_0, object object_1, object object_2, Delegate181 delegate181_1)
	{
		return delegate181_1(string_0, object_0, object_1, object_2);
	}

	// Token: 0x06001AAA RID: 6826
	public extern Delegate181(object object_0, IntPtr intptr_0);

	// Token: 0x06001AAB RID: 6827 RVA: 0x00009324 File Offset: 0x00007524
	static Delegate181()
	{
		Class15.smethod_14(typeof(Delegate181).TypeHandle);
	}

	// Token: 0x04000A95 RID: 2709
	internal static Delegate181 delegate181_0;
}
