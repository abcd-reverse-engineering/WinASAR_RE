using System;

// Token: 0x0200035A RID: 858
internal sealed class Delegate330 : MulticastDelegate
{
	// Token: 0x06001CFC RID: 7420
	public extern bool Invoke(double double_0);

	// Token: 0x06001CFD RID: 7421 RVA: 0x0000A1E7 File Offset: 0x000083E7
	public static bool smethod_0(double double_0, Delegate330 delegate330_1)
	{
		return delegate330_1(double_0);
	}

	// Token: 0x06001CFE RID: 7422
	public extern Delegate330(object object_0, IntPtr intptr_0);

	// Token: 0x06001CFF RID: 7423 RVA: 0x0000A1F2 File Offset: 0x000083F2
	static Delegate330()
	{
		Class15.smethod_14(typeof(Delegate330).TypeHandle);
	}

	// Token: 0x04000B2A RID: 2858
	internal static Delegate330 delegate330_0;
}
