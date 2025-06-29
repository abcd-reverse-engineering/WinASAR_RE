using System;

// Token: 0x0200035F RID: 863
internal sealed class Delegate335 : MulticastDelegate
{
	// Token: 0x06001D10 RID: 7440
	public extern string Invoke(ref Guid guid_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D11 RID: 7441 RVA: 0x0000A26F File Offset: 0x0000846F
	public static string smethod_0(ref Guid guid_0, string string_0, IFormatProvider iformatProvider_0, Delegate335 delegate335_1)
	{
		return delegate335_1(ref guid_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D12 RID: 7442
	public extern Delegate335(object object_0, IntPtr intptr_0);

	// Token: 0x06001D13 RID: 7443 RVA: 0x0000A27E File Offset: 0x0000847E
	static Delegate335()
	{
		Class15.smethod_14(typeof(Delegate335).TypeHandle);
	}

	// Token: 0x04000B2F RID: 2863
	internal static Delegate335 delegate335_0;
}
