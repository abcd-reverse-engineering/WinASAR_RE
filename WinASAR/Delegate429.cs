using System;

// Token: 0x020003BD RID: 957
internal sealed class Delegate429 : MulticastDelegate
{
	// Token: 0x06001E88 RID: 7816
	public extern Array Invoke(Type type_0, int[] int_0);

	// Token: 0x06001E89 RID: 7817 RVA: 0x0000ABF5 File Offset: 0x00008DF5
	public static Array smethod_0(Type type_0, int[] int_0, Delegate429 delegate429_1)
	{
		return delegate429_1(type_0, int_0);
	}

	// Token: 0x06001E8A RID: 7818
	public extern Delegate429(object object_0, IntPtr intptr_0);

	// Token: 0x06001E8B RID: 7819 RVA: 0x0000AC02 File Offset: 0x00008E02
	static Delegate429()
	{
		Class15.smethod_14(typeof(Delegate429).TypeHandle);
	}

	// Token: 0x04000B8D RID: 2957
	internal static Delegate429 delegate429_0;
}
