using System;

// Token: 0x02000532 RID: 1330
internal sealed class Delegate802 : MulticastDelegate
{
	// Token: 0x0600245C RID: 9308
	public extern int Invoke(ref double double_0, double double_1);

	// Token: 0x0600245D RID: 9309 RVA: 0x0000D10E File Offset: 0x0000B30E
	public static int smethod_0(ref double double_0, double double_1, Delegate802 delegate802_1)
	{
		return delegate802_1(ref double_0, double_1);
	}

	// Token: 0x0600245E RID: 9310
	public extern Delegate802(object object_0, IntPtr intptr_0);

	// Token: 0x0600245F RID: 9311 RVA: 0x0000D11B File Offset: 0x0000B31B
	static Delegate802()
	{
		Class15.smethod_14(typeof(Delegate802).TypeHandle);
	}

	// Token: 0x04000D02 RID: 3330
	internal static Delegate802 delegate802_0;
}
