using Models.Framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Models
{
    public class CategoryModel
    {
        private OnlineShopDbContext dbContext = null;
        public CategoryModel()
        {
            dbContext = new OnlineShopDbContext();
        }
        public List<Category> GetAll()
        {
            var res = dbContext.Database.SqlQuery<Category>("SP_Category_GetAll").ToList();
            return res;
        }
        public IEnumerable<Category> GetListPaging(int page, int pageSize)
        {
            var res = dbContext.Categories.ToList().ToPagedList(page, pageSize).ToList();
            return res;
        }
        public Category GetByID(int ID)
        {
            var res = dbContext.Categories.FirstOrDefault(X => X.ID == ID);
            return res;
        }

        public bool Edit(Category category)
        {
            try
            {
                Category baseCategory = dbContext.Categories.FirstOrDefault(X => X.ID == category.ID);

                baseCategory.Name = category.Name;
                baseCategory.MetaTitle = category.MetaTitle;
                baseCategory.ParentID = category.ParentID;
                baseCategory.Image = category.Image;
                baseCategory.Content = category.Content;

                dbContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool Delete(Category category)
        {
            try
            {
                Category baseCategory = dbContext.Categories.FirstOrDefault(X => X.ID == category.ID);

                dbContext.Categories.Remove(baseCategory);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Insert(string name, string meta, int parentID)
        {
            object[] sqlParams = {
                new SqlParameter("@_Name",name),
                new SqlParameter("@_MetaTile",meta),
                new SqlParameter("@_ParentID",parentID)
            };
            var res = dbContext.Database.SqlQuery<int>("SP_Category_Insert @_Name,@_MetaTile,@_ParentID", sqlParams).SingleOrDefault();
            return res > 0 ? true : false;
        }
        public bool Insert(Category category)
        {
            category.CreatedDate = DateTime.Now;
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return category.ID > 0 ? true : false;
        }
    }
}
