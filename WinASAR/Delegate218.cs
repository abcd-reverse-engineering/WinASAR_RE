using System;

// Token: 0x020002EA RID: 746
internal sealed class Delegate218 : MulticastDelegate
{
	// Token: 0x06001B3C RID: 6972
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001B3D RID: 6973 RVA: 0x000096BB File Offset: 0x000078BB
	public static void smethod_0(object object_0, string string_0, Delegate218 delegate218_1)
	{
		delegate218_1(object_0, string_0);
	}

	// Token: 0x06001B3E RID: 6974
	public extern Delegate218(object object_0, IntPtr intptr_0);

	// Token: 0x06001B3F RID: 6975 RVA: 0x000096C8 File Offset: 0x000078C8
	static Delegate218()
	{
		Class15.smethod_14(typeof(Delegate218).TypeHandle);
	}

	// Token: 0x04000ABA RID: 2746
	internal static Delegate218 delegate218_0;
}
