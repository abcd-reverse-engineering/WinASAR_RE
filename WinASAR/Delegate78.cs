using System;

// Token: 0x0200025E RID: 606
internal sealed class Delegate78 : MulticastDelegate
{
	// Token: 0x0600190C RID: 6412
	public extern void Invoke(object object_0);

	// Token: 0x0600190D RID: 6413 RVA: 0x000088FF File Offset: 0x00006AFF
	public static void smethod_0(object object_0, Delegate78 delegate78_1)
	{
		delegate78_1(object_0);
	}

	// Token: 0x0600190E RID: 6414
	public extern Delegate78(object object_0, IntPtr intptr_0);

	// Token: 0x0600190F RID: 6415 RVA: 0x0000890A File Offset: 0x00006B0A
	static Delegate78()
	{
		Class15.smethod_14(typeof(Delegate78).TypeHandle);
	}

	// Token: 0x04000A2E RID: 2606
	internal static Delegate78 delegate78_0;
}
