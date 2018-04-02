
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Code
{
    [Serializable]
    public class UserSession
    {
        public string Username { set; get; }
        public List<Menu> menu { set; get; }
        public UserSession()
        {

        }
        public List<Menu> GetMenuByFatherID(int fatherID)
        {
            return menu.FindAll(x=>x.FatherID == fatherID).ToList();
        }
        public Menu FindMenu(string code)
        {
            return menu.FirstOrDefault(x => x.Code == code);
        }
    }
}