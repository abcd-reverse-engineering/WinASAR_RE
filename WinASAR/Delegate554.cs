using System;
using System.Reflection.Emit;

// Token: 0x0200043A RID: 1082
internal sealed class Delegate554 : MulticastDelegate
{
	// Token: 0x0600207C RID: 8316
	public extern ILGenerator Invoke(object object_0);

	// Token: 0x0600207D RID: 8317 RVA: 0x0000B889 File Offset: 0x00009A89
	public static ILGenerator smethod_0(object object_0, Delegate554 delegate554_1)
	{
		return delegate554_1(object_0);
	}

	// Token: 0x0600207E RID: 8318
	public extern Delegate554(object object_0, IntPtr intptr_0);

	// Token: 0x0600207F RID: 8319 RVA: 0x0000B894 File Offset: 0x00009A94
	static Delegate554()
	{
		Class15.smethod_14(typeof(Delegate554).TypeHandle);
	}

	// Token: 0x04000C0A RID: 3082
	internal static Delegate554 delegate554_0;
}
