using System;
using System.Collections;

// Token: 0x020004ED RID: 1261
internal sealed class Delegate733 : MulticastDelegate
{
	// Token: 0x06002348 RID: 9032
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x06002349 RID: 9033 RVA: 0x0000CA40 File Offset: 0x0000AC40
	public static IEnumerator smethod_0(object object_0, Delegate733 delegate733_1)
	{
		return delegate733_1(object_0);
	}

	// Token: 0x0600234A RID: 9034
	public extern Delegate733(object object_0, IntPtr intptr_0);

	// Token: 0x0600234B RID: 9035 RVA: 0x0000CA4B File Offset: 0x0000AC4B
	static Delegate733()
	{
		Class15.smethod_14(typeof(Delegate733).TypeHandle);
	}

	// Token: 0x04000CBD RID: 3261
	internal static Delegate733 delegate733_0;
}
