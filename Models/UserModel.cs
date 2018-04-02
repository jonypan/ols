using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framwork;
using System.Data.SqlClient;
namespace Models
{
    public class UserModel
    {
        private OnlineShopDbContext dbContext = null;
        public UserModel()
        {
            dbContext = new OnlineShopDbContext();
        }
        public int Login(string Username, string password)
        {
            //object[] sqlParams = {
            //    new SqlParameter("@_Username",Username),
            //    new SqlParameter("@_Password",password)
            //};

            //int res = dbContext.Database.SqlQuery<int>("SP_Account_Login @_Username,@_Password", sqlParams).SingleOrDefault();
            //return res > 0 ? true : false;
            User res = dbContext.Users.FirstOrDefault(x => x.Email == Username && x.Password == password);
            if (res == null)
                return 0;
            else return res.UserID;
        }
    }
}
