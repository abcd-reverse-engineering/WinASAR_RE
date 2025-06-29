using System;
using System.Runtime.Serialization;

// Token: 0x020004FF RID: 1279
internal sealed class Delegate751 : MulticastDelegate
{
	// Token: 0x06002390 RID: 9104
	public extern SerializationEntry Invoke(object object_0);

	// Token: 0x06002391 RID: 9105 RVA: 0x0000CC12 File Offset: 0x0000AE12
	public static SerializationEntry smethod_0(object object_0, Delegate751 delegate751_1)
	{
		return delegate751_1(object_0);
	}

	// Token: 0x06002392 RID: 9106
	public extern Delegate751(object object_0, IntPtr intptr_0);

	// Token: 0x06002393 RID: 9107 RVA: 0x0000CC1D File Offset: 0x0000AE1D
	static Delegate751()
	{
		Class15.smethod_14(typeof(Delegate751).TypeHandle);
	}

	// Token: 0x04000CCF RID: 3279
	internal static Delegate751 delegate751_0;
}
