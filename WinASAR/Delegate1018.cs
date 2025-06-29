using System;

// Token: 0x0200060A RID: 1546
internal sealed class Delegate1018 : MulticastDelegate
{
	// Token: 0x060027BC RID: 10172
	public extern object Invoke(Type type_0, byte byte_0);

	// Token: 0x060027BD RID: 10173 RVA: 0x0000E696 File Offset: 0x0000C896
	public static object smethod_0(Type type_0, byte byte_0, Delegate1018 delegate1018_1)
	{
		return delegate1018_1(type_0, byte_0);
	}

	// Token: 0x060027BE RID: 10174
	public extern Delegate1018(object object_0, IntPtr intptr_0);

	// Token: 0x060027BF RID: 10175 RVA: 0x0000E6A3 File Offset: 0x0000C8A3
	static Delegate1018()
	{
		Class15.smethod_14(typeof(Delegate1018).TypeHandle);
	}

	// Token: 0x04000DDA RID: 3546
	internal static Delegate1018 delegate1018_0;
}
