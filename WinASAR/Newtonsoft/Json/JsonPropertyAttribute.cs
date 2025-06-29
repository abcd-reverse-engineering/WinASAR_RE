using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200005F RID: 95
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(2)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00002C8D File Offset: 0x00000E8D
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000290F8 File Offset: 0x000272F8
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00002C95 File Offset: 0x00000E95
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00029130 File Offset: 0x00027330
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00002C9D File Offset: 0x00000E9D
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00029168 File Offset: 0x00027368
		public Type NamingStrategyType
		{
			[CompilerGenerated]
			get
			{
				return this.type_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.type_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00002CA5 File Offset: 0x00000EA5
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000291A0 File Offset: 0x000273A0
		[Nullable(new byte[] { 2, 1 })]
		public object[] NamingStrategyParameters
		{
			[CompilerGenerated]
			[return: Nullable(new byte[] { 2, 1 })]
			get
			{
				return this.object_1;
			}
			[CompilerGenerated]
			[param: Nullable(new byte[] { 2, 1 })]
			set
			{
				for (;;)
				{
					this.object_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00002CAD File Offset: 0x00000EAD
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000291D8 File Offset: 0x000273D8
		public NullValueHandling NullValueHandling
		{
			get
			{
				return this._nullValueHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._nullValueHandling = new NullValueHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002CBA File Offset: 0x00000EBA
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00029214 File Offset: 0x00027414
		public DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._defaultValueHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._defaultValueHandling = new DefaultValueHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002CC7 File Offset: 0x00000EC7
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00029250 File Offset: 0x00027450
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._referenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._referenceLoopHandling = new ReferenceLoopHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00002CD4 File Offset: 0x00000ED4
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0002928C File Offset: 0x0002748C
		public ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._objectCreationHandling = new ObjectCreationHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002CE1 File Offset: 0x00000EE1
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000292C8 File Offset: 0x000274C8
		public TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._typeNameHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._typeNameHandling = new TypeNameHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00002CEE File Offset: 0x00000EEE
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00029304 File Offset: 0x00027504
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002CFB File Offset: 0x00000EFB
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00029340 File Offset: 0x00027540
		public int Order
		{
			get
			{
				return this._order.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._order = new int?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002D08 File Offset: 0x00000F08
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0002937C File Offset: 0x0002757C
		public Required Required
		{
			get
			{
				return this._required.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._required = new Required?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002D15 File Offset: 0x00000F15
		// (set) Token: 0x060002FA RID: 762 RVA: 0x000293B8 File Offset: 0x000275B8
		public string PropertyName
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00002D1D File Offset: 0x00000F1D
		// (set) Token: 0x060002FC RID: 764 RVA: 0x000293F0 File Offset: 0x000275F0
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00002D2A File Offset: 0x00000F2A
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0002942C File Offset: 0x0002762C
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00002D37 File Offset: 0x00000F37
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00029468 File Offset: 0x00027668
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
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

		// Token: 0x06000301 RID: 769 RVA: 0x000294A4 File Offset: 0x000276A4
		public JsonPropertyAttribute()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000294D8 File Offset: 0x000276D8
		[NullableContext(1)]
		public JsonPropertyAttribute(string propertyName)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.PropertyName = propertyName;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
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

		// Token: 0x04000205 RID: 517
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x04000206 RID: 518
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x04000207 RID: 519
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000208 RID: 520
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000209 RID: 521
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x0400020A RID: 522
		internal bool? _isReference;

		// Token: 0x0400020B RID: 523
		internal int? _order;

		// Token: 0x0400020C RID: 524
		internal Required? _required;

		// Token: 0x0400020D RID: 525
		internal bool? _itemIsReference;

		// Token: 0x0400020E RID: 526
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x0400020F RID: 527
		internal TypeNameHandling? _itemTypeNameHandling;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x04000211 RID: 529
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private object[] object_0;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private Type type_1;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private object[] object_1;

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private string string_0;
	}
}
