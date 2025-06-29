using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200005C RID: 92
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00002C5E File Offset: 0x00000E5E
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00028940 File Offset: 0x00026B40
		public MemberSerialization MemberSerialization
		{
			get
			{
				return this.memberSerialization_0;
			}
			set
			{
				for (;;)
				{
					this.memberSerialization_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00002C66 File Offset: 0x00000E66
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00028978 File Offset: 0x00026B78
		public MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._missingMemberHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._missingMemberHandling = new MissingMemberHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00002C73 File Offset: 0x00000E73
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000289B4 File Offset: 0x00026BB4
		public NullValueHandling ItemNullValueHandling
		{
			get
			{
				return this._itemNullValueHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._itemNullValueHandling = new NullValueHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00002C80 File Offset: 0x00000E80
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000289F0 File Offset: 0x00026BF0
		public Required ItemRequired
		{
			get
			{
				return this._itemRequired.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._itemRequired = new Required?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
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

		// Token: 0x060002D2 RID: 722 RVA: 0x00028A2C File Offset: 0x00026C2C
		public JsonObjectAttribute()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00028A60 File Offset: 0x00026C60
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.MemberSerialization = memberSerialization;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00028AB4 File Offset: 0x00026CB4
		[NullableContext(1)]
		public JsonObjectAttribute(string id)
			: base(id)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040001F5 RID: 501
		private MemberSerialization memberSerialization_0;

		// Token: 0x040001F6 RID: 502
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x040001F7 RID: 503
		internal Required? _itemRequired;

		// Token: 0x040001F8 RID: 504
		internal NullValueHandling? _itemNullValueHandling;
	}
}
