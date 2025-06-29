using System;

// Token: 0x02000411 RID: 1041
internal sealed class Delegate513 : MulticastDelegate
{
	// Token: 0x06001FD8 RID: 8152
	public extern bool Invoke(object object_0);

	// Token: 0x06001FD9 RID: 8153 RVA: 0x0000B467 File Offset: 0x00009667
	public static bool smethod_0(object object_0, Delegate513 delegate513_1)
	{
		return delegate513_1(object_0);
	}

	// Token: 0x06001FDA RID: 8154
	public extern Delegate513(object object_0, IntPtr intptr_0);

	// Token: 0x06001FDB RID: 8155 RVA: 0x0000B472 File Offset: 0x00009672
	static Delegate513()
	{
		Class15.smethod_14(typeof(Delegate513).TypeHandle);
	}

	// Token: 0x04000BE1 RID: 3041
	internal static Delegate513 delegate513_0;
}
