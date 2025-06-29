using System;
using System.Runtime.Serialization;

// Token: 0x02000500 RID: 1280
internal sealed class Delegate752 : MulticastDelegate
{
	// Token: 0x06002394 RID: 9108
	public extern object Invoke(ref SerializationEntry serializationEntry_0);

	// Token: 0x06002395 RID: 9109 RVA: 0x0000CC2A File Offset: 0x0000AE2A
	public static object smethod_0(ref SerializationEntry serializationEntry_0, Delegate752 delegate752_1)
	{
		return delegate752_1(ref serializationEntry_0);
	}

	// Token: 0x06002396 RID: 9110
	public extern Delegate752(object object_0, IntPtr intptr_0);

	// Token: 0x06002397 RID: 9111 RVA: 0x0000CC35 File Offset: 0x0000AE35
	static Delegate752()
	{
		Class15.smethod_14(typeof(Delegate752).TypeHandle);
	}

	// Token: 0x04000CD0 RID: 3280
	internal static Delegate752 delegate752_0;
}
