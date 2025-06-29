using System;
using System.Runtime.Serialization;

// Token: 0x020004FD RID: 1277
internal sealed class Delegate749 : MulticastDelegate
{
	// Token: 0x06002388 RID: 9096
	public extern void Invoke(object object_0, SerializationInfo serializationInfo_0, StreamingContext streamingContext_0);

	// Token: 0x06002389 RID: 9097 RVA: 0x0000CBDE File Offset: 0x0000ADDE
	public static void smethod_0(object object_0, SerializationInfo serializationInfo_0, StreamingContext streamingContext_0, Delegate749 delegate749_1)
	{
		delegate749_1(object_0, serializationInfo_0, streamingContext_0);
	}

	// Token: 0x0600238A RID: 9098
	public extern Delegate749(object object_0, IntPtr intptr_0);

	// Token: 0x0600238B RID: 9099 RVA: 0x0000CBED File Offset: 0x0000ADED
	static Delegate749()
	{
		Class15.smethod_14(typeof(Delegate749).TypeHandle);
	}

	// Token: 0x04000CCD RID: 3277
	internal static Delegate749 delegate749_0;
}
