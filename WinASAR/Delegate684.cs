using System;

// Token: 0x020004BC RID: 1212
internal sealed class Delegate684 : MulticastDelegate
{
	// Token: 0x06002284 RID: 8836
	public extern string Invoke(IFormatProvider iformatProvider_0, string string_0, object[] object_0);

	// Token: 0x06002285 RID: 8837 RVA: 0x0000C592 File Offset: 0x0000A792
	public static string smethod_0(IFormatProvider iformatProvider_0, string string_0, object[] object_0, Delegate684 delegate684_1)
	{
		return delegate684_1(iformatProvider_0, string_0, object_0);
	}

	// Token: 0x06002286 RID: 8838
	public extern Delegate684(object object_0, IntPtr intptr_0);

	// Token: 0x06002287 RID: 8839 RVA: 0x0000C5A1 File Offset: 0x0000A7A1
	static Delegate684()
	{
		Class15.smethod_14(typeof(Delegate684).TypeHandle);
	}

	// Token: 0x04000C8C RID: 3212
	internal static Delegate684 delegate684_0;
}
