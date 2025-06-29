using System;

// Token: 0x020004BA RID: 1210
internal sealed class Delegate682 : MulticastDelegate
{
	// Token: 0x0600227C RID: 8828
	public extern object Invoke(Type type_0);

	// Token: 0x0600227D RID: 8829 RVA: 0x0000C55A File Offset: 0x0000A75A
	public static object smethod_0(Type type_0, Delegate682 delegate682_1)
	{
		return delegate682_1(type_0);
	}

	// Token: 0x0600227E RID: 8830
	public extern Delegate682(object object_0, IntPtr intptr_0);

	// Token: 0x0600227F RID: 8831 RVA: 0x0000C565 File Offset: 0x0000A765
	static Delegate682()
	{
		Class15.smethod_14(typeof(Delegate682).TypeHandle);
	}

	// Token: 0x04000C8A RID: 3210
	internal static Delegate682 delegate682_0;
}
