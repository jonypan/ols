
using Models.Framwork;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FunctionModel
    {
        private OnlineShopDbContext dbContext = null;
        public FunctionModel()
        {
            dbContext = new OnlineShopDbContext();
        }
        public List<Menu> GetMenu(int userID)
        {
            object[] sqlParams = {
                new SqlParameter("@_UserID",userID)
            };

            List<Menu> res = dbContext.Database.SqlQuery<Menu>("[cms].[SP_Functions_GetList] @_UserID", sqlParams).ToList();
            return res;
        }
        public List<Function> GetAll()
        {
            return dbContext.Functions.ToList();
        }
    }
}
