using System;

// Token: 0x02000528 RID: 1320
internal sealed class Delegate792 : MulticastDelegate
{
	// Token: 0x06002434 RID: 9268
	public extern uint Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002435 RID: 9269 RVA: 0x0000D012 File Offset: 0x0000B212
	public static uint smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate792 delegate792_1)
	{
		return delegate792_1(object_0, iformatProvider_0);
	}

	// Token: 0x06002436 RID: 9270
	public extern Delegate792(object object_0, IntPtr intptr_0);

	// Token: 0x06002437 RID: 9271 RVA: 0x0000D01F File Offset: 0x0000B21F
	static Delegate792()
	{
		Class15.smethod_14(typeof(Delegate792).TypeHandle);
	}

	// Token: 0x04000CF8 RID: 3320
	internal static Delegate792 delegate792_0;
}
