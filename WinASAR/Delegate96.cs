using System;

// Token: 0x02000270 RID: 624
internal sealed class Delegate96 : MulticastDelegate
{
	// Token: 0x06001954 RID: 6484
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001955 RID: 6485 RVA: 0x00008AC1 File Offset: 0x00006CC1
	public static void smethod_0(object object_0, int int_0, Delegate96 delegate96_1)
	{
		delegate96_1(object_0, int_0);
	}

	// Token: 0x06001956 RID: 6486
	public extern Delegate96(object object_0, IntPtr intptr_0);

	// Token: 0x06001957 RID: 6487 RVA: 0x00008ACE File Offset: 0x00006CCE
	static Delegate96()
	{
		Class15.smethod_14(typeof(Delegate96).TypeHandle);
	}

	// Token: 0x04000A40 RID: 2624
	internal static Delegate96 delegate96_0;
}
