using System;
using System.Runtime.Serialization;

// Token: 0x02000501 RID: 1281
internal sealed class Delegate753 : MulticastDelegate
{
	// Token: 0x06002398 RID: 9112
	public extern string Invoke(ref SerializationEntry serializationEntry_0);

	// Token: 0x06002399 RID: 9113 RVA: 0x0000CC42 File Offset: 0x0000AE42
	public static string smethod_0(ref SerializationEntry serializationEntry_0, Delegate753 delegate753_1)
	{
		return delegate753_1(ref serializationEntry_0);
	}

	// Token: 0x0600239A RID: 9114
	public extern Delegate753(object object_0, IntPtr intptr_0);

	// Token: 0x0600239B RID: 9115 RVA: 0x0000CC4D File Offset: 0x0000AE4D
	static Delegate753()
	{
		Class15.smethod_14(typeof(Delegate753).TypeHandle);
	}

	// Token: 0x04000CD1 RID: 3281
	internal static Delegate753 delegate753_0;
}
