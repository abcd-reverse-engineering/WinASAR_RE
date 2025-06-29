using System;
using System.Diagnostics;

// Token: 0x0200022F RID: 559
internal sealed class Delegate31 : MulticastDelegate
{
	// Token: 0x06001850 RID: 6224
	public extern Process Invoke(ProcessStartInfo processStartInfo_0);

	// Token: 0x06001851 RID: 6225 RVA: 0x00008459 File Offset: 0x00006659
	public static Process smethod_0(ProcessStartInfo processStartInfo_0, Delegate31 delegate31_1)
	{
		return delegate31_1(processStartInfo_0);
	}

	// Token: 0x06001852 RID: 6226
	public extern Delegate31(object object_0, IntPtr intptr_0);

	// Token: 0x06001853 RID: 6227 RVA: 0x00008464 File Offset: 0x00006664
	static Delegate31()
	{
		Class15.smethod_14(typeof(Delegate31).TypeHandle);
	}

	// Token: 0x040009FF RID: 2559
	internal static Delegate31 delegate31_0;
}
