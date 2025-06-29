using System;

// Token: 0x02000525 RID: 1317
internal sealed class Delegate789 : MulticastDelegate
{
	// Token: 0x06002428 RID: 9256
	public extern sbyte Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002429 RID: 9257 RVA: 0x0000CFC6 File Offset: 0x0000B1C6
	public static sbyte smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate789 delegate789_1)
	{
		return delegate789_1(object_0, iformatProvider_0);
	}

	// Token: 0x0600242A RID: 9258
	public extern Delegate789(object object_0, IntPtr intptr_0);

	// Token: 0x0600242B RID: 9259 RVA: 0x0000CFD3 File Offset: 0x0000B1D3
	static Delegate789()
	{
		Class15.smethod_14(typeof(Delegate789).TypeHandle);
	}

	// Token: 0x04000CF5 RID: 3317
	internal static Delegate789 delegate789_0;
}
