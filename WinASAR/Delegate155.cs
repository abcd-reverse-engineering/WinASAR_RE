using System;
using System.Collections;

// Token: 0x020002AB RID: 683
internal sealed class Delegate155 : MulticastDelegate
{
	// Token: 0x06001A40 RID: 6720
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x06001A41 RID: 6721 RVA: 0x0000908B File Offset: 0x0000728B
	public static IEnumerator smethod_0(object object_0, Delegate155 delegate155_1)
	{
		return delegate155_1(object_0);
	}

	// Token: 0x06001A42 RID: 6722
	public extern Delegate155(object object_0, IntPtr intptr_0);

	// Token: 0x06001A43 RID: 6723 RVA: 0x00009096 File Offset: 0x00007296
	static Delegate155()
	{
		Class15.smethod_14(typeof(Delegate155).TypeHandle);
	}

	// Token: 0x04000A7B RID: 2683
	internal static Delegate155 delegate155_0;
}
