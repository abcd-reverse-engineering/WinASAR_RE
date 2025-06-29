using System;

// Token: 0x02000326 RID: 806
internal sealed class Delegate278 : MulticastDelegate
{
	// Token: 0x06001C2C RID: 7212
	public extern int Invoke(object object_0);

	// Token: 0x06001C2D RID: 7213 RVA: 0x00009CAB File Offset: 0x00007EAB
	public static int smethod_0(object object_0, Delegate278 delegate278_1)
	{
		return delegate278_1(object_0);
	}

	// Token: 0x06001C2E RID: 7214
	public extern Delegate278(object object_0, IntPtr intptr_0);

	// Token: 0x06001C2F RID: 7215 RVA: 0x00009CB6 File Offset: 0x00007EB6
	static Delegate278()
	{
		Class15.smethod_14(typeof(Delegate278).TypeHandle);
	}

	// Token: 0x04000AF6 RID: 2806
	internal static Delegate278 delegate278_0;
}
