using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Com.BaseLibrary.Common.Logging;
using Com.BaseLibrary.Configuration;
using Com.BaseLibrary.Utility;
using Com.BaseLibrary.Common.Cryptography;

namespace Jufine.Backend.Accounting.DataAccess
{
    public partial class AccountingEntities : ObjectContext
    {
        private static string connectionstring;
        static AccountingEntities()
        {
            connectionstring = ConfigurationHelper.GetConnectionString("AccountingEntities");
            LogHelper.CustomInfo(connectionstring);
            if (!connectionstring.StartsWith("metadata="))
            {
                connectionstring = Encryptor.Decrypt(connectionstring);
            }
        }

        /// <summary>
        /// 请使用应用程序配置文件的“SecurityEntities”部分中的连接字符串初始化新 SecurityEntities 对象。
        /// </summary>
        public AccountingEntities()
            : base(new EntityConnection(connectionstring), "AccountingEntities")
        {

        }
    }
}
