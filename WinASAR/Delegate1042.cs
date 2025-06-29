using System;

// Token: 0x02000622 RID: 1570
internal sealed class Delegate1042 : MulticastDelegate
{
	// Token: 0x0600281C RID: 10268
	public extern IntPtr Invoke(ref RuntimeMethodHandle runtimeMethodHandle_0);

	// Token: 0x0600281D RID: 10269 RVA: 0x0000E8E6 File Offset: 0x0000CAE6
	public static IntPtr smethod_0(ref RuntimeMethodHandle runtimeMethodHandle_0, Delegate1042 delegate1042_1)
	{
		return delegate1042_1(ref runtimeMethodHandle_0);
	}

	// Token: 0x0600281E RID: 10270
	public extern Delegate1042(object object_0, IntPtr intptr_0);

	// Token: 0x0600281F RID: 10271 RVA: 0x0000E8F1 File Offset: 0x0000CAF1
	static Delegate1042()
	{
		Class15.smethod_14(typeof(Delegate1042).TypeHandle);
	}

	// Token: 0x04000DF2 RID: 3570
	internal static Delegate1042 delegate1042_0;
}
