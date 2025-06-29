using System;

// Token: 0x0200038D RID: 909
internal sealed class Delegate381 : MulticastDelegate
{
	// Token: 0x06001DC8 RID: 7624
	public extern bool Invoke(char char_0);

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0000A725 File Offset: 0x00008925
	public static bool smethod_0(char char_0, Delegate381 delegate381_1)
	{
		return delegate381_1(char_0);
	}

	// Token: 0x06001DCA RID: 7626
	public extern Delegate381(object object_0, IntPtr intptr_0);

	// Token: 0x06001DCB RID: 7627 RVA: 0x0000A730 File Offset: 0x00008930
	static Delegate381()
	{
		Class15.smethod_14(typeof(Delegate381).TypeHandle);
	}

	// Token: 0x04000B5D RID: 2909
	internal static Delegate381 delegate381_0;
}
