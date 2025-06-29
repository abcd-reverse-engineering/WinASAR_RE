using System;

// Token: 0x02000322 RID: 802
internal sealed class Delegate274 : MulticastDelegate
{
	// Token: 0x06001C1C RID: 7196
	public extern void Invoke(object object_0);

	// Token: 0x06001C1D RID: 7197 RVA: 0x00009C45 File Offset: 0x00007E45
	public static void smethod_0(object object_0, Delegate274 delegate274_1)
	{
		delegate274_1(object_0);
	}

	// Token: 0x06001C1E RID: 7198
	public extern Delegate274(object object_0, IntPtr intptr_0);

	// Token: 0x06001C1F RID: 7199 RVA: 0x00009C50 File Offset: 0x00007E50
	static Delegate274()
	{
		Class15.smethod_14(typeof(Delegate274).TypeHandle);
	}

	// Token: 0x04000AF2 RID: 2802
	internal static Delegate274 delegate274_0;
}
