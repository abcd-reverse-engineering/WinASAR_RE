using System;

// Token: 0x02000382 RID: 898
internal sealed class Delegate370 : MulticastDelegate
{
	// Token: 0x06001D9C RID: 7580
	public extern void Invoke(object object_0);

	// Token: 0x06001D9D RID: 7581 RVA: 0x0000A605 File Offset: 0x00008805
	public static void smethod_0(object object_0, Delegate370 delegate370_1)
	{
		delegate370_1(object_0);
	}

	// Token: 0x06001D9E RID: 7582
	public extern Delegate370(object object_0, IntPtr intptr_0);

	// Token: 0x06001D9F RID: 7583 RVA: 0x0000A610 File Offset: 0x00008810
	static Delegate370()
	{
		Class15.smethod_14(typeof(Delegate370).TypeHandle);
	}

	// Token: 0x04000B52 RID: 2898
	internal static Delegate370 delegate370_0;
}
