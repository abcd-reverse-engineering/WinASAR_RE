using System;

// Token: 0x0200036C RID: 876
internal sealed class Delegate348 : MulticastDelegate
{
	// Token: 0x06001D44 RID: 7492
	public extern Type Invoke(object object_0);

	// Token: 0x06001D45 RID: 7493 RVA: 0x0000A3C1 File Offset: 0x000085C1
	public static Type smethod_0(object object_0, Delegate348 delegate348_1)
	{
		return delegate348_1(object_0);
	}

	// Token: 0x06001D46 RID: 7494
	public extern Delegate348(object object_0, IntPtr intptr_0);

	// Token: 0x06001D47 RID: 7495 RVA: 0x0000A3CC File Offset: 0x000085CC
	static Delegate348()
	{
		Class15.smethod_14(typeof(Delegate348).TypeHandle);
	}

	// Token: 0x04000B3C RID: 2876
	internal static Delegate348 delegate348_0;
}
