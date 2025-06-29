using System;
using System.Diagnostics;

// Token: 0x020004EC RID: 1260
internal sealed class Delegate732 : MulticastDelegate
{
	// Token: 0x06002344 RID: 9028
	public extern TraceListenerCollection Invoke();

	// Token: 0x06002345 RID: 9029 RVA: 0x0000CA2A File Offset: 0x0000AC2A
	public static TraceListenerCollection smethod_0(Delegate732 delegate732_1)
	{
		return delegate732_1();
	}

	// Token: 0x06002346 RID: 9030
	public extern Delegate732(object object_0, IntPtr intptr_0);

	// Token: 0x06002347 RID: 9031 RVA: 0x0000CA33 File Offset: 0x0000AC33
	static Delegate732()
	{
		Class15.smethod_14(typeof(Delegate732).TypeHandle);
	}

	// Token: 0x04000CBC RID: 3260
	internal static Delegate732 delegate732_0;
}
