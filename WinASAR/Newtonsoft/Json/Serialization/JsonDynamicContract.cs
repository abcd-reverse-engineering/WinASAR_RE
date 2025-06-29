using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010A RID: 266
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonDynamicContract : JsonContainerContract
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00004C98 File Offset: 0x00002E98
		public JsonPropertyCollection Properties { get; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00004CA0 File Offset: 0x00002EA0
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00004CA8 File Offset: 0x00002EA8
		[Nullable(new byte[] { 2, 1, 1 })]
		public Func<string, string> PropertyNameResolver
		{
			[return: Nullable(new byte[] { 2, 1, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 1 })]
			set;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00004CB1 File Offset: 0x00002EB1
		private static CallSite<Func<CallSite, object, object>> smethod_0(string string_0)
		{
			return CallSite<Func<CallSite, object, object>>.Create(new NoThrowGetBinderMember((GetMemberBinder)DynamicUtils.BinderWrapper.GetMember(string_0, typeof(DynamicUtils))));
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00004CD2 File Offset: 0x00002ED2
		[return: Nullable(new byte[] { 1, 1, 1, 1, 2, 1 })]
		private static CallSite<Func<CallSite, object, object, object>> smethod_1(string string_0)
		{
			return CallSite<Func<CallSite, object, object, object>>.Create(new NoThrowSetBinderMember((SetMemberBinder)DynamicUtils.BinderWrapper.SetMember(string_0, typeof(DynamicUtils))));
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0005A0C8 File Offset: 0x000582C8
		public JsonDynamicContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
			{
				goto IL_0064;
			}
			do
			{
				IL_0049:
				this.ContractType = JsonContractType.Dynamic;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0);
			IL_0064:
			switch (num)
			{
			case 0:
				goto IL_0049;
			case 1:
				this.Properties = new JsonPropertyCollection(base.UnderlyingType);
				break;
			case 2:
				break;
			default:
				goto IL_0049;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0005A160 File Offset: 0x00058360
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] out object value)
		{
			for (;;)
			{
				IL_0088:
				ValidationUtils.ArgumentNotNull(dynamicProvider, Class15.smethod_17(2021187494 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
				for (;;)
				{
					IL_0078:
					CallSite<Func<CallSite, object, object>> callSite = this.threadSafeStore_0.Get(name);
					for (;;)
					{
						IL_0065:
						object obj = callSite.Target(callSite, dynamicProvider);
						for (;;)
						{
							if (obj != NoThrowExpressionVisitor.ErrorResult)
							{
								goto IL_0020;
							}
							value = null;
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
							{
								goto Block_1;
							}
							IL_0035:
							switch (num)
							{
							case 1:
								return true;
							case 2:
								goto IL_0065;
							case 3:
								continue;
							case 4:
								IL_0020:
								value = obj;
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
								{
									goto IL_0035;
								}
								break;
							case 5:
								goto IL_0078;
							case 6:
								goto IL_0088;
							}
							goto Block_2;
						}
					}
				}
			}
			Block_1:
			Block_2:
			return false;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0005A21C File Offset: 0x0005841C
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] object value)
		{
			CallSite<Func<CallSite, object, object, object>> callSite;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(dynamicProvider, Class15.smethod_17(2048543643 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0025;
				}
				do
				{
					IL_0003:
					callSite = this.threadSafeStore_1.Get(name);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0);
				IL_0025:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					goto IL_0068;
				default:
					goto IL_0003;
				}
			}
			IL_0068:
			return callSite.Target(callSite, dynamicProvider, value) != NoThrowExpressionVisitor.ErrorResult;
		}

		// Token: 0x04000544 RID: 1348
		[CompilerGenerated]
		private readonly JsonPropertyCollection jsonPropertyCollection_0;

		// Token: 0x04000545 RID: 1349
		[Nullable(new byte[] { 2, 1, 1 })]
		[CompilerGenerated]
		private Func<string, string> func_1;

		// Token: 0x04000546 RID: 1350
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> threadSafeStore_0 = new ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object>>>(JsonDynamicContract.smethod_0));

		// Token: 0x04000547 RID: 1351
		[Nullable(new byte[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> threadSafeStore_1 = new ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object, object>>>(JsonDynamicContract.smethod_1));
	}
}
