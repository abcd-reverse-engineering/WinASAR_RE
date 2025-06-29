using System;

// Token: 0x02000429 RID: 1065
internal sealed class Delegate537 : MulticastDelegate
{
	// Token: 0x06002038 RID: 8248
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06002039 RID: 8249 RVA: 0x0000B6DB File Offset: 0x000098DB
	public static bool smethod_0(Type type_0, Type type_1, Delegate537 delegate537_0)
	{
		return delegate537_0(type_0, type_1);
	}

	// Token: 0x0600203A RID: 8250
	public extern Delegate537(object object_0, IntPtr intptr_0);

	// Token: 0x0600203B RID: 8251 RVA: 0x0000B6E8 File Offset: 0x000098E8
	static Delegate537()
	{
		Class15.smethod_14(typeof(Delegate537).TypeHandle);
	}

	// Token: 0x04000BF9 RID: 3065
	internal static Delegate537 umgiwUeprV;
}
