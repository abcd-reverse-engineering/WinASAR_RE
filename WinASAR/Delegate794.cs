using System;

// Token: 0x0200052A RID: 1322
internal sealed class Delegate794 : MulticastDelegate
{
	// Token: 0x0600243C RID: 9276
	public extern string Invoke(byte[] byte_0);

	// Token: 0x0600243D RID: 9277 RVA: 0x0000D046 File Offset: 0x0000B246
	public static string smethod_0(byte[] byte_0, Delegate794 delegate794_1)
	{
		return delegate794_1(byte_0);
	}

	// Token: 0x0600243E RID: 9278
	public extern Delegate794(object object_0, IntPtr intptr_0);

	// Token: 0x0600243F RID: 9279 RVA: 0x0000D051 File Offset: 0x0000B251
	static Delegate794()
	{
		Class15.smethod_14(typeof(Delegate794).TypeHandle);
	}

	// Token: 0x04000CFA RID: 3322
	internal static Delegate794 delegate794_0;
}
