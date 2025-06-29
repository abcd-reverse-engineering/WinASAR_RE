using System;

// Token: 0x0200051C RID: 1308
internal sealed class Delegate780 : MulticastDelegate
{
	// Token: 0x06002404 RID: 9220
	public extern bool Invoke(int int_0);

	// Token: 0x06002405 RID: 9221 RVA: 0x0000CEE6 File Offset: 0x0000B0E6
	public static bool smethod_0(int int_0, Delegate780 delegate780_1)
	{
		return delegate780_1(int_0);
	}

	// Token: 0x06002406 RID: 9222
	public extern Delegate780(object object_0, IntPtr intptr_0);

	// Token: 0x06002407 RID: 9223 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
	static Delegate780()
	{
		Class15.smethod_14(typeof(Delegate780).TypeHandle);
	}

	// Token: 0x04000CEC RID: 3308
	internal static Delegate780 delegate780_0;
}
