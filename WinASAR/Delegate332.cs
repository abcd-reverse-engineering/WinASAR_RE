using System;

// Token: 0x0200035C RID: 860
internal sealed class Delegate332 : MulticastDelegate
{
	// Token: 0x06001D04 RID: 7428
	public extern string Invoke(ref byte byte_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D05 RID: 7429 RVA: 0x0000A21B File Offset: 0x0000841B
	public static string smethod_0(ref byte byte_0, string string_0, IFormatProvider iformatProvider_0, Delegate332 delegate332_1)
	{
		return delegate332_1(ref byte_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D06 RID: 7430
	public extern Delegate332(object object_0, IntPtr intptr_0);

	// Token: 0x06001D07 RID: 7431 RVA: 0x0000A22A File Offset: 0x0000842A
	static Delegate332()
	{
		Class15.smethod_14(typeof(Delegate332).TypeHandle);
	}

	// Token: 0x04000B2C RID: 2860
	internal static Delegate332 delegate332_0;
}
