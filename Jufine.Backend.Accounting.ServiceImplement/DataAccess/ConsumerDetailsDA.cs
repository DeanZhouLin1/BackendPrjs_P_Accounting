using System;
using System.Linq;
using System.Data.Objects;

using Com.BaseLibrary.Service;
using Com.BaseLibrary.Entity;

using Jufine.Backend.Accounting.DataContracts;

namespace Jufine.Backend.Accounting.DataAccess 
{
	internal class ConsumerDetailsDA: DataBase<ConsumerDetails, AccountingEntities>
	{
        
        internal static ConsumerDetailsDA DAO = new ConsumerDetailsDA();
		
        private ConsumerDetailsDA(){ }
        
        protected override void AttachValue(ConsumerDetails newEntity, ConsumerDetails oldEntity)
		{
            oldEntity.Amount = newEntity.Amount;
            oldEntity.Type = newEntity.Type;
            oldEntity.MemoTypeID = newEntity.MemoTypeID;
            oldEntity.Memo = newEntity.Memo;
            oldEntity.CreateUser = newEntity.CreateUser;
            oldEntity.CreateDate = newEntity.CreateDate;
		}
        
        protected override IQueryable<ConsumerDetails> SetWhereClause(QueryConditionInfo<ConsumerDetails> queryCondition, IQueryable<ConsumerDetails> query)
		{
                    if(queryCondition.Condtion.ID > 0)
                    {
                        query = query.Where(c => c.ID==queryCondition.Condtion.ID);
                    }
                    if(queryCondition.Condtion.Amount > 0)
                    {
                        query = query.Where(c => c.Amount==queryCondition.Condtion.Amount);
                    }
                    if(queryCondition.Condtion.Type > 0)
                    {
                        query = query.Where(c => c.Type==queryCondition.Condtion.Type);
                    }
                    if(queryCondition.Condtion.MemoTypeID > 0)
                    {
                        query = query.Where(c => c.MemoTypeID==queryCondition.Condtion.MemoTypeID);
                    }
                    if(!string.IsNullOrEmpty( queryCondition.Condtion.Memo ))
                    {
                        query = query.Where(c => c.Memo.StartsWith(queryCondition.Condtion.Memo));
                    }
                    if(!string.IsNullOrEmpty( queryCondition.Condtion.CreateUser ))
                    {
                        query = query.Where(c => c.CreateUser.StartsWith(queryCondition.Condtion.CreateUser));
                    }
                    if(queryCondition.Condtion.CreateDate>DateTime.MinValue)
                    {
                        query = query.Where(c => c.CreateDate > queryCondition.Condtion.CreateDate);
                    }
                    if(queryCondition.Condtion.CreateDateTo!=null)
                    {
                        query = query.Where(c => c.CreateDate <=queryCondition.Condtion.CreateDateTo);
                    }
            return query;
		}
        
        protected override IQueryable<ConsumerDetails> SetOrder(QueryConditionInfo<ConsumerDetails> queryCondition, IQueryable<ConsumerDetails> query)
		{
            int count = queryCondition.OrderFileds.Count;
			if (count > 0)
			{
                for (int i = count; i > 0; i--)
				{
                    OrderFiledInfo item = queryCondition.OrderFileds[i - i];   
					    if (item.FieldName == "ID")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.ID) : query.OrderByDescending(c => c.ID);
					    }
					    if (item.FieldName == "Amount")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.Amount) : query.OrderByDescending(c => c.Amount);
					    }
					    if (item.FieldName == "Type")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.Type) : query.OrderByDescending(c => c.Type);
					    }
					    if (item.FieldName == "MemoTypeID")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.MemoTypeID) : query.OrderByDescending(c => c.MemoTypeID);
					    }
					    if (item.FieldName == "Memo")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.Memo) : query.OrderByDescending(c => c.Memo);
					    }
					    if (item.FieldName == "CreateUser")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.CreateUser) : query.OrderByDescending(c => c.CreateUser);
					    }
					    if (item.FieldName == "CreateDate")
					    {
                            query = item.OrderDirection == OrderDirection.ASC ? query.OrderBy(c => c.CreateDate) : query.OrderByDescending(c => c.CreateDate);
					    }
				}
			}
			else
			{
				query = query.OrderByDescending(c => c.ID);
			}
            return query;
		}
        
        
    }
}
