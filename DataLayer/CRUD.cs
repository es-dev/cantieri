using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using Library.Code;

namespace DataLayer
{
    public class CRUD<TEntity> where TEntity : class
    {
        ObjectContext context = null;
        ObjectSet<TEntity> objSet = null;

        public CRUD(ObjectContext context) 
        {
            try
            {
                this.context = context;
                var obj = Activator.CreateInstance<TEntity>();
                var type = obj.GetType();
                this.objSet = context.CreateObjectSet<TEntity>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public object Create(TEntity objDto)
        {
            try
            {
                if (objDto != null)
                {
                    var obj=POCO.GetEntityObject(objDto, objSet);
                    if (obj == null)
                    {
                        obj = POCO.GetPOCOObject(objDto); 
                        objSet.AddObject(obj);
                        context.SaveChanges();
                        var value = POCO.GetPrimaryKeyValue(obj);
                        return value;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public EntityCollection<TEntity> Read()
        {
            try
            {
                var query = Query();
                var objDtos = POCO.GetPOCOObjects(query);
                return objDtos;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IQueryable<TEntity> Query()
        {
            try
            {
                var query = (from q in objSet select q);
                return query;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool Update(TEntity objDto)
        {
            try
            {
                if (objDto != null)
                {
                    var obj = POCO.GetEntityObject(objDto, objSet);
                    if (obj != null)
                    {
                        bool performed = POCO.CloneObject(obj, objDto);
                        if (performed)
                        {
                            context.SaveChanges();
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool Delete(TEntity objDto)
        {
            try
            {
                if (objDto != null)
                {
                    var obj = POCO.GetEntityObject(objDto, objSet);
                    if (obj != null)
                    {
                        context.DeleteObject(obj);
                        context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int Count()
        {
            try
            {
                int count = (from q in objSet select q).Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        
    }
}