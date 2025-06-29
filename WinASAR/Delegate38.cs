using System;

// Token: 0x02000236 RID: 566
internal sealed class Delegate38 : MulticastDelegate
{
	// Token: 0x0600186C RID: 6252
	public extern void Invoke(object object_0);

	// Token: 0x0600186D RID: 6253 RVA: 0x00008505 File Offset: 0x00006705
	public static void smethod_0(object object_0, Delegate38 delegate38_1)
	{
		delegate38_1(object_0);
	}

	// Token: 0x0600186E RID: 6254
	public extern Delegate38(object object_0, IntPtr intptr_0);

	// Token: 0x0600186F RID: 6255 RVA: 0x00008510 File Offset: 0x00006710
	static Delegate38()
	{
		Class15.smethod_14(typeof(Delegate38).TypeHandle);
	}

	// Token: 0x04000A06 RID: 2566
	internal static Delegate38 delegate38_0;
}
