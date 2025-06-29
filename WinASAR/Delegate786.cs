using System;

// Token: 0x02000522 RID: 1314
internal sealed class Delegate786 : MulticastDelegate
{
	// Token: 0x0600241C RID: 9244
	public extern ushort Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x0600241D RID: 9245 RVA: 0x0000CF7C File Offset: 0x0000B17C
	public static ushort smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate786 delegate786_1)
	{
		return delegate786_1(object_0, iformatProvider_0);
	}

	// Token: 0x0600241E RID: 9246
	public extern Delegate786(object object_0, IntPtr intptr_0);

	// Token: 0x0600241F RID: 9247 RVA: 0x0000CF89 File Offset: 0x0000B189
	static Delegate786()
	{
		Class15.smethod_14(typeof(Delegate786).TypeHandle);
	}

	// Token: 0x04000CF2 RID: 3314
	internal static Delegate786 delegate786_0;
}
