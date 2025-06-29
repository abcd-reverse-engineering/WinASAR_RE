using System;

// Token: 0x020004A5 RID: 1189
internal sealed class Delegate661 : MulticastDelegate
{
	// Token: 0x06002228 RID: 8744
	public extern void Invoke(object object_0, object object_1, object object_2, object[] object_3);

	// Token: 0x06002229 RID: 8745 RVA: 0x0000C33F File Offset: 0x0000A53F
	public static void smethod_0(object object_0, object object_1, object object_2, object[] object_3, Delegate661 delegate661_1)
	{
		delegate661_1(object_0, object_1, object_2, object_3);
	}

	// Token: 0x0600222A RID: 8746
	public extern Delegate661(object object_0, IntPtr intptr_0);

	// Token: 0x0600222B RID: 8747 RVA: 0x0000C350 File Offset: 0x0000A550
	static Delegate661()
	{
		Class15.smethod_14(typeof(Delegate661).TypeHandle);
	}

	// Token: 0x04000C75 RID: 3189
	internal static Delegate661 delegate661_0;
}
