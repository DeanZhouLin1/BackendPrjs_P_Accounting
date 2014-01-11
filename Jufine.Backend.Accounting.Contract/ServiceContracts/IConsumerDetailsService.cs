using System;
using System.Collections.Generic;

using Com.BaseLibrary.Entity;
using Com.BaseLibrary.Contract;

using Jufine.Backend.Accounting.DataContracts;

namespace Jufine.Backend.Accounting.ServiceContracts
{
	public interface IConsumerDetailsService: IServiceBase
	{
		
        
        ConsumerDetails Get(Int32 id);
        List<ConsumerDetails> GetAll();
        void Create(ConsumerDetails consumerDetails);
        void Update(ConsumerDetails consumerDetails);
        void Delete(Int32 id);
        void BatchDelete(List<Int32> keyList);
        QueryResultInfo<ConsumerDetails> Query(QueryConditionInfo<ConsumerDetails> queryCondition);
    }
}
