using System;

// Token: 0x0200031F RID: 799
internal sealed class Delegate271 : MulticastDelegate
{
	// Token: 0x06001C10 RID: 7184
	public extern string Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

	// Token: 0x06001C11 RID: 7185 RVA: 0x00009BF1 File Offset: 0x00007DF1
	public static string smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, Delegate271 delegate271_1)
	{
		return delegate271_1(object_0, byte_0, int_0, int_1);
	}

	// Token: 0x06001C12 RID: 7186
	public extern Delegate271(object object_0, IntPtr intptr_0);

	// Token: 0x06001C13 RID: 7187 RVA: 0x00009C02 File Offset: 0x00007E02
	static Delegate271()
	{
		Class15.smethod_14(typeof(Delegate271).TypeHandle);
	}

	// Token: 0x04000AEF RID: 2799
	internal static Delegate271 delegate271_0;
}
