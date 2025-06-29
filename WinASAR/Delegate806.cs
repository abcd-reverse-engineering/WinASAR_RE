using System;

// Token: 0x02000536 RID: 1334
internal sealed class Delegate806 : MulticastDelegate
{
	// Token: 0x0600246C RID: 9324
	public extern int Invoke(ref DateTime dateTime_0, DateTime dateTime_1);

	// Token: 0x0600246D RID: 9325 RVA: 0x0000D176 File Offset: 0x0000B376
	public static int smethod_0(ref DateTime dateTime_0, DateTime dateTime_1, Delegate806 delegate806_1)
	{
		return delegate806_1(ref dateTime_0, dateTime_1);
	}

	// Token: 0x0600246E RID: 9326
	public extern Delegate806(object object_0, IntPtr intptr_0);

	// Token: 0x0600246F RID: 9327 RVA: 0x0000D183 File Offset: 0x0000B383
	static Delegate806()
	{
		Class15.smethod_14(typeof(Delegate806).TypeHandle);
	}

	// Token: 0x04000D06 RID: 3334
	internal static Delegate806 delegate806_0;
}
