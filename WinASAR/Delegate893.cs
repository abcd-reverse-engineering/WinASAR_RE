using System;

// Token: 0x0200058D RID: 1421
internal sealed class Delegate893 : MulticastDelegate
{
	// Token: 0x060025C8 RID: 9672
	public extern string Invoke(object object_0);

	// Token: 0x060025C9 RID: 9673 RVA: 0x0000DA20 File Offset: 0x0000BC20
	public static string smethod_0(object object_0, Delegate893 delegate893_1)
	{
		return delegate893_1(object_0);
	}

	// Token: 0x060025CA RID: 9674
	public extern Delegate893(object object_0, IntPtr intptr_0);

	// Token: 0x060025CB RID: 9675 RVA: 0x0000DA2B File Offset: 0x0000BC2B
	static Delegate893()
	{
		Class15.smethod_14(typeof(Delegate893).TypeHandle);
	}

	// Token: 0x04000D5D RID: 3421
	internal static Delegate893 delegate893_0;
}
