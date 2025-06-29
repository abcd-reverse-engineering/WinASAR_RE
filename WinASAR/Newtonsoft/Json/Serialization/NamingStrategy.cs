using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000121 RID: 289
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class NamingStrategy
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0000521A File Offset: 0x0000341A
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000694C4 File Offset: 0x000676C4
		public bool ProcessDictionaryKeys
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00005222 File Offset: 0x00003422
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000694FC File Offset: 0x000676FC
		public bool ProcessExtensionDataNames
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0000522A File Offset: 0x0000342A
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00069534 File Offset: 0x00067734
		public bool OverrideSpecifiedNames
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
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

		// Token: 0x06000BBB RID: 3003 RVA: 0x0006956C File Offset: 0x0006776C
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			for (;;)
			{
				int num;
				if (!hasSpecifiedName)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						break;
					}
					goto IL_0017;
				}
				IL_002C:
				while (!this.OverrideSpecifiedNames)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_0017;
					}
				}
				break;
				IL_0017:
				switch (num)
				{
				default:
					goto IL_002C;
				case 1:
					return name;
				case 2:
					goto IL_0056;
				case 3:
					break;
				}
			}
			IL_0056:
			return this.ResolvePropertyName(name);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000695D8 File Offset: 0x000677D8
		public virtual string GetExtensionDataName(string name)
		{
			while (this.ProcessExtensionDataNames)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return name;
					}
				}
				return this.ResolvePropertyName(name);
			}
			return name;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00069624 File Offset: 0x00067824
		public virtual string GetDictionaryKey(string key)
		{
			while (!this.ProcessDictionaryKeys)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return key;
			}
			return this.ResolvePropertyName(key);
		}

		// Token: 0x06000BBE RID: 3006
		protected abstract string ResolvePropertyName(string name);

		// Token: 0x06000BBF RID: 3007 RVA: 0x0006966C File Offset: 0x0006786C
		public override int GetHashCode()
		{
			return (((((base.GetType().GetHashCode() * 397) ^ this.ProcessDictionaryKeys.GetHashCode()) * 397) ^ this.ProcessExtensionDataNames.GetHashCode()) * 397) ^ this.OverrideSpecifiedNames.GetHashCode();
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00005232 File Offset: 0x00003432
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as NamingStrategy);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000696C8 File Offset: 0x000678C8
		[NullableContext(2)]
		protected bool Equals(NamingStrategy other)
		{
			while (other != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_003F;
				}
				goto IL_0066;
				IL_001A:
				if (this.ProcessDictionaryKeys != other.ProcessDictionaryKeys)
				{
					return false;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					continue;
				}
				goto IL_0066;
				IL_003F:
				if (!(base.GetType() == other.GetType()))
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_001A;
				}
				IL_0066:
				switch (num)
				{
				case 0:
					goto IL_003F;
				case 1:
					continue;
				case 2:
					goto IL_001A;
				case 3:
					break;
				case 4:
					return false;
				case 5:
					if (this.ProcessExtensionDataNames != other.ProcessExtensionDataNames)
					{
						return false;
					}
					break;
				default:
					goto IL_003F;
				}
				return this.OverrideSpecifiedNames == other.OverrideSpecifiedNames;
			}
			return false;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00069788 File Offset: 0x00067988
		protected NamingStrategy()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040005C3 RID: 1475
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040005C4 RID: 1476
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040005C5 RID: 1477
		[CompilerGenerated]
		private bool bool_2;
	}
}
