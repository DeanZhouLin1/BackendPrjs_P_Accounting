
using System;
using System.Collections.Generic;

using Com.BaseLibrary.Entity;
using Com.BaseLibrary.ExceptionHandle;
using Jufine.Backend.Accounting.DataContracts;
using Jufine.Backend.Accounting.ServiceContracts;
using Jufine.Backend.Accounting.DataAccess;

namespace Jufine.Backend.Accounting.Business
{
	public class ConsumerDetailsBL :IConsumerDetailsService
	{
       
		public ConsumerDetails Get(Int32 id)
        {
            try
            {
                return ConsumerDetailsDA.DAO.Get(id);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }
        
        public void Delete(Int32 id)
        {
            try
            {
                 ConsumerDetailsDA.DAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }
        
        public void BatchDelete(List<Int32> keyList)
        {
            try
            {
                ConsumerDetailsDA.DAO.BatchDelete(keyList);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }
    
        public List<ConsumerDetails> GetAll()
        {
            try
            {
                return ConsumerDetailsDA.DAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }

        public void Create(ConsumerDetails consumerDetails)
        {
            try
            {
                ConsumerDetailsDA.DAO.Create(consumerDetails);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }

        public void Update(ConsumerDetails consumerDetails)
        {
            try
            {
                ConsumerDetailsDA.DAO.Update(consumerDetails);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            }
        }
        
        public QueryResultInfo<ConsumerDetails> Query(QueryConditionInfo<ConsumerDetails> queryCondition)
        {
           try
            {
               return ConsumerDetailsDA.DAO.Query(queryCondition);
            }
            catch (Exception ex)
            {
                throw ExceptionFactory.BuildException(ex);
            } 
        }

    }
}
