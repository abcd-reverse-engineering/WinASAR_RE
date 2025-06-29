using System;

// Token: 0x02000526 RID: 1318
internal sealed class Delegate790 : MulticastDelegate
{
	// Token: 0x0600242C RID: 9260
	public extern float Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x0600242D RID: 9261 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
	public static float smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate790 delegate790_1)
	{
		return delegate790_1(object_0, iformatProvider_0);
	}

	// Token: 0x0600242E RID: 9262
	public extern Delegate790(object object_0, IntPtr intptr_0);

	// Token: 0x0600242F RID: 9263 RVA: 0x0000CFED File Offset: 0x0000B1ED
	static Delegate790()
	{
		Class15.smethod_14(typeof(Delegate790).TypeHandle);
	}

	// Token: 0x04000CF6 RID: 3318
	internal static Delegate790 delegate790_0;
}
