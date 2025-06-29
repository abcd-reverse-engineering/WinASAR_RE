using System;

// Token: 0x02000626 RID: 1574
internal sealed class Delegate1046 : MulticastDelegate
{
	// Token: 0x0600282C RID: 10284
	public extern Type Invoke(object object_0);

	// Token: 0x0600282D RID: 10285 RVA: 0x0000E94E File Offset: 0x0000CB4E
	public static Type smethod_0(object object_0, Delegate1046 delegate1046_1)
	{
		return delegate1046_1(object_0);
	}

	// Token: 0x0600282E RID: 10286
	public extern Delegate1046(object object_0, IntPtr intptr_0);

	// Token: 0x0600282F RID: 10287 RVA: 0x0000E959 File Offset: 0x0000CB59
	static Delegate1046()
	{
		Class15.smethod_14(typeof(Delegate1046).TypeHandle);
	}

	// Token: 0x04000DF6 RID: 3574
	internal static Delegate1046 delegate1046_0;
}
