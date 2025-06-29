using System;

// Token: 0x020004A8 RID: 1192
internal sealed class Delegate664 : MulticastDelegate
{
	// Token: 0x06002234 RID: 8756
	public extern bool Invoke(object object_0);

	// Token: 0x06002235 RID: 8757 RVA: 0x0000C38D File Offset: 0x0000A58D
	public static bool smethod_0(object object_0, Delegate664 delegate664_1)
	{
		return delegate664_1(object_0);
	}

	// Token: 0x06002236 RID: 8758
	public extern Delegate664(object object_0, IntPtr intptr_0);

	// Token: 0x06002237 RID: 8759 RVA: 0x0000C398 File Offset: 0x0000A598
	static Delegate664()
	{
		Class15.smethod_14(typeof(Delegate664).TypeHandle);
	}

	// Token: 0x04000C78 RID: 3192
	internal static Delegate664 delegate664_0;
}
