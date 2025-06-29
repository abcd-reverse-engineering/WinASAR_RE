using System;

// Token: 0x0200023A RID: 570
internal sealed class Delegate42 : MulticastDelegate
{
	// Token: 0x0600187C RID: 6268
	public extern void Invoke(object object_0);

	// Token: 0x0600187D RID: 6269 RVA: 0x00008567 File Offset: 0x00006767
	public static void smethod_0(object object_0, Delegate42 delegate42_1)
	{
		delegate42_1(object_0);
	}

	// Token: 0x0600187E RID: 6270
	public extern Delegate42(object object_0, IntPtr intptr_0);

	// Token: 0x0600187F RID: 6271 RVA: 0x00008572 File Offset: 0x00006772
	static Delegate42()
	{
		Class15.smethod_14(typeof(Delegate42).TypeHandle);
	}

	// Token: 0x04000A0A RID: 2570
	internal static Delegate42 delegate42_0;
}
