using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000051 RID: 81
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002903 File Offset: 0x00000B03
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00026E40 File Offset: 0x00025040
		public string Id
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000290B File Offset: 0x00000B0B
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00026E78 File Offset: 0x00025078
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002913 File Offset: 0x00000B13
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00026EB0 File Offset: 0x000250B0
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000291B File Offset: 0x00000B1B
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00026EE8 File Offset: 0x000250E8
		public Type ItemConverterType
		{
			[CompilerGenerated]
			get
			{
				return this.type_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.type_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002923 File Offset: 0x00000B23
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00026F20 File Offset: 0x00025120
		[Nullable(new byte[] { 2, 1 })]
		public object[] ItemConverterParameters
		{
			[CompilerGenerated]
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.object_0;
			}
			[CompilerGenerated]
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				for (;;)
				{
					this.object_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000292B File Offset: 0x00000B2B
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00026F58 File Offset: 0x00025158
		public Type NamingStrategyType
		{
			get
			{
				return this.type_1;
			}
			set
			{
				for (;;)
				{
					this.type_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						IL_0003:
						this.NamingStrategyInstance = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto IL_001B;
						}
						break;
					case 2:
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002933 File Offset: 0x00000B33
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00026FB0 File Offset: 0x000251B0
		[Nullable(new byte[] { 2, 1 })]
		public object[] NamingStrategyParameters
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.object_1;
			}
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				for (;;)
				{
					this.object_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					IL_0003:
					this.NamingStrategyInstance = null;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_001B;
					}
					break;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000293B File Offset: 0x00000B3B
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00027008 File Offset: 0x00025208
		internal NamingStrategy NamingStrategyInstance
		{
			[CompilerGenerated]
			get
			{
				return this.namingStrategy_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.namingStrategy_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002943 File Offset: 0x00000B43
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00027040 File Offset: 0x00025240
		public bool IsReference
		{
			get
			{
				return this._isReference.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._isReference = new bool?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002950 File Offset: 0x00000B50
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0002707C File Offset: 0x0002527C
		public bool ItemIsReference
		{
			get
			{
				return this._itemIsReference.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._itemIsReference = new bool?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000295D File Offset: 0x00000B5D
		// (set) Token: 0x0600023D RID: 573 RVA: 0x000270B8 File Offset: 0x000252B8
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			get
			{
				return this._itemReferenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._itemReferenceLoopHandling = new ReferenceLoopHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000296A File Offset: 0x00000B6A
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000270F4 File Offset: 0x000252F4
		public TypeNameHandling ItemTypeNameHandling
		{
			get
			{
				return this._itemTypeNameHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._itemTypeNameHandling = new TypeNameHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x06000240 RID: 576 RVA: 0x00027130 File Offset: 0x00025330
		protected JsonContainerAttribute()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00027164 File Offset: 0x00025364
		[NullableContext(1)]
		protected JsonContainerAttribute(string id)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Id = id;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x040001D2 RID: 466
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001D3 RID: 467
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040001D4 RID: 468
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040001D5 RID: 469
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x040001D6 RID: 470
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private object[] object_0;

		// Token: 0x040001D7 RID: 471
		[CompilerGenerated]
		private NamingStrategy namingStrategy_0;

		// Token: 0x040001D8 RID: 472
		internal bool? _isReference;

		// Token: 0x040001D9 RID: 473
		internal bool? _itemIsReference;

		// Token: 0x040001DA RID: 474
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x040001DB RID: 475
		internal TypeNameHandling? _itemTypeNameHandling;

		// Token: 0x040001DC RID: 476
		private Type type_1;

		// Token: 0x040001DD RID: 477
		[Nullable(new byte[] { 2, 1 })]
		private object[] object_1;
	}
}
