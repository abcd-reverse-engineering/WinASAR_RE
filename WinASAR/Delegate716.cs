using System;

// Token: 0x020004DC RID: 1244
internal sealed class Delegate716 : MulticastDelegate
{
	// Token: 0x06002304 RID: 8964
	public extern string Invoke(object object_0);

	// Token: 0x06002305 RID: 8965 RVA: 0x0000C8A2 File Offset: 0x0000AAA2
	public static string smethod_0(object object_0, Delegate716 delegate716_1)
	{
		return delegate716_1(object_0);
	}

	// Token: 0x06002306 RID: 8966
	public extern Delegate716(object object_0, IntPtr intptr_0);

	// Token: 0x06002307 RID: 8967 RVA: 0x0000C8AD File Offset: 0x0000AAAD
	static Delegate716()
	{
		Class15.smethod_14(typeof(Delegate716).TypeHandle);
	}

	// Token: 0x04000CAC RID: 3244
	internal static Delegate716 delegate716_0;
}
