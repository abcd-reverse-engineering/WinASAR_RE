using System;

// Token: 0x02000601 RID: 1537
internal sealed class Delegate1009 : MulticastDelegate
{
	// Token: 0x06002798 RID: 10136
	public extern float Invoke(object object_0);

	// Token: 0x06002799 RID: 10137 RVA: 0x0000E5B2 File Offset: 0x0000C7B2
	public static float smethod_0(object object_0, Delegate1009 delegate1009_1)
	{
		return delegate1009_1(object_0);
	}

	// Token: 0x0600279A RID: 10138
	public extern Delegate1009(object object_0, IntPtr intptr_0);

	// Token: 0x0600279B RID: 10139 RVA: 0x0000E5BD File Offset: 0x0000C7BD
	static Delegate1009()
	{
		Class15.smethod_14(typeof(Delegate1009).TypeHandle);
	}

	// Token: 0x04000DD1 RID: 3537
	internal static Delegate1009 delegate1009_0;
}
