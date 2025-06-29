using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F6 RID: 246
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorContext
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x000580E4 File Offset: 0x000562E4
		internal ErrorContext([Nullable(2)] object originalObject, [Nullable(2)] object member, string path, Exception error)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
			{
				goto IL_004A;
			}
			goto IL_0065;
			IL_001C:
			this.Path = path;
			num = 4;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
			{
				goto IL_0041;
			}
			goto IL_0065;
			IL_0037:
			this.Error = error;
			goto IL_001C;
			IL_0041:
			this.Member = member;
			goto IL_0037;
			IL_004A:
			this.OriginalObject = originalObject;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
			{
				goto IL_0041;
			}
			IL_0065:
			switch (num)
			{
			case 0:
				goto IL_004A;
			case 1:
				goto IL_0041;
			case 2:
				goto IL_0037;
			case 3:
				goto IL_001C;
			case 4:
				return;
			default:
				goto IL_004A;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00058174 File Offset: 0x00056374
		internal bool Traced
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00004A18 File Offset: 0x00002C18
		public Exception Error { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00004A20 File Offset: 0x00002C20
		[Nullable(2)]
		public object OriginalObject
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00004A28 File Offset: 0x00002C28
		[Nullable(2)]
		public object Member
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00004A30 File Offset: 0x00002C30
		public string Path { get; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00004A38 File Offset: 0x00002C38
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x000581AC File Offset: 0x000563AC
		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x040004EF RID: 1263
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040004F0 RID: 1264
		[CompilerGenerated]
		private readonly Exception exception_0;

		// Token: 0x040004F1 RID: 1265
		[Nullable(2)]
		[CompilerGenerated]
		private readonly object object_0;

		// Token: 0x040004F2 RID: 1266
		[Nullable(2)]
		[CompilerGenerated]
		private readonly object object_1;

		// Token: 0x040004F3 RID: 1267
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x040004F4 RID: 1268
		[CompilerGenerated]
		private bool bool_1;
	}
}
