using System;

// Token: 0x02000351 RID: 849
internal sealed class Delegate321 : MulticastDelegate
{
	// Token: 0x06001CD8 RID: 7384
	public extern string Invoke(ref int int_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CD9 RID: 7385 RVA: 0x0000A0EF File Offset: 0x000082EF
	public static string smethod_0(ref int int_0, string string_0, IFormatProvider iformatProvider_0, Delegate321 delegate321_1)
	{
		return delegate321_1(ref int_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CDA RID: 7386
	public extern Delegate321(object object_0, IntPtr intptr_0);

	// Token: 0x06001CDB RID: 7387 RVA: 0x0000A0FE File Offset: 0x000082FE
	static Delegate321()
	{
		Class15.smethod_14(typeof(Delegate321).TypeHandle);
	}

	// Token: 0x04000B21 RID: 2849
	internal static Delegate321 delegate321_0;
}
