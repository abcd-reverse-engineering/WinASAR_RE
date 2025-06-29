using System;

// Token: 0x02000358 RID: 856
internal sealed class Delegate328 : MulticastDelegate
{
	// Token: 0x06001CF4 RID: 7412
	public extern string Invoke(ref float float_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CF5 RID: 7413 RVA: 0x0000A1B3 File Offset: 0x000083B3
	public static string smethod_0(ref float float_0, string string_0, IFormatProvider iformatProvider_0, Delegate328 delegate328_1)
	{
		return delegate328_1(ref float_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CF6 RID: 7414
	public extern Delegate328(object object_0, IntPtr intptr_0);

	// Token: 0x06001CF7 RID: 7415 RVA: 0x0000A1C2 File Offset: 0x000083C2
	static Delegate328()
	{
		Class15.smethod_14(typeof(Delegate328).TypeHandle);
	}

	// Token: 0x04000B28 RID: 2856
	internal static Delegate328 delegate328_0;
}
