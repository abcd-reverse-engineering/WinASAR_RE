using System;
using System.Runtime.Serialization;

// Token: 0x020004FE RID: 1278
internal sealed class Delegate750 : MulticastDelegate
{
	// Token: 0x0600238C RID: 9100
	public extern SerializationInfoEnumerator Invoke(object object_0);

	// Token: 0x0600238D RID: 9101 RVA: 0x0000CBFA File Offset: 0x0000ADFA
	public static SerializationInfoEnumerator smethod_0(object object_0, Delegate750 delegate750_1)
	{
		return delegate750_1(object_0);
	}

	// Token: 0x0600238E RID: 9102
	public extern Delegate750(object object_0, IntPtr intptr_0);

	// Token: 0x0600238F RID: 9103 RVA: 0x0000CC05 File Offset: 0x0000AE05
	static Delegate750()
	{
		Class15.smethod_14(typeof(Delegate750).TypeHandle);
	}

	// Token: 0x04000CCE RID: 3278
	internal static Delegate750 delegate750_0;
}
