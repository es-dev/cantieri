using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using Library.Code;
using System.Linq.Expressions;
using System.Reflection;
using System.Data.Entity.Core.Objects;

namespace DataLayer
{
    public class POCO
    {
        public static EntityCollection<TEntity> GetPOCOObjects<TEntity>(IQueryable<TEntity> query) where TEntity : class
        {
            try
            {
                if (query != null)
                {
                    var objDtos = new EntityCollection<TEntity>();
                    foreach (var obj in query)
                    {
                        var objDto = GetPOCOObject(obj);
                        objDtos.Add(objDto);
                    }
                    return objDtos;
                }
                return null;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null; 
        }

        public static TEntity GetPOCOObject<TEntity>(TEntity objPOCO) where TEntity : class
        {
            try
            {
                if (objPOCO != null)
                {
                    var obj = Activator.CreateInstance<TEntity>();
                    bool performed = CloneObject(obj, objPOCO);
                    if (performed)
                        return obj;
                }
                return null;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static bool CloneObject<TEntity>(TEntity objCloned, TEntity objToClone) where TEntity : class
        {
            try
            {
                if (objToClone != null)
                {
                    var type = objToClone.GetType();
                    var properties = type.GetProperties();
                    foreach (var property in properties)
                    {
                        if (IsScalarProperty(property))
                        {
                            var value = property.GetValue(objToClone);
                            property.SetValue(objCloned, value);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        static bool IsScalarProperty(System.Reflection.PropertyInfo property)
        {
            try
            {
                if (property != null)
                {
                    var attributes = property.GetCustomAttributes(false);
                    int count = (from q in attributes where q.GetType() == typeof(EdmScalarPropertyAttribute) select q).Count();
                    bool exist = (count >= 1);
                    return exist;
                }
                return false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static TEntity GetEntityObject<TEntity>(TEntity objDto, ObjectSet<TEntity> objSet) where TEntity : class
        {
            try
            {
                if (objDto != null)
                {
                    var primaryKey = GetPrimaryKey(objDto);
                    if (primaryKey != null)
                    {
                        var primaryKeyValue = primaryKey.GetValue(objDto);
                        var predicate = GetPredicateByPrimaryKey<TEntity>(primaryKey, primaryKeyValue);
                        var obj = objSet.Where(predicate).FirstOrDefault();
                        return obj;
                    }
                }
                return default(TEntity);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TEntity);
        }

        static Expression<Func<TEntity, bool>> GetPredicateByPrimaryKey<TEntity>(PropertyInfo primaryKey, object primaryKeyValue)
        {
            try
            {
                var parameter = Expression.Parameter(typeof(TEntity), "entityParameter");
                var keyValue = Expression.Property(parameter, primaryKey);
                var pkValue = Expression.Constant(primaryKeyValue, keyValue.Type);
                var body = Expression.Equal(keyValue, pkValue);
                var predicate = Expression.Lambda<Func<TEntity, bool>>(body, parameter);
                return predicate;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static PropertyInfo GetPrimaryKey<TEntity>(TEntity objDto)  //todo: ricavare primary key da Id?
        {
            try
            {
                var type = objDto.GetType();
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    var attributes = property.GetCustomAttributes(false);
                    var attribute = (from q in attributes where q.GetType() == typeof(EdmScalarPropertyAttribute) select q).FirstOrDefault() as EdmScalarPropertyAttribute;
                    if (attribute != null)
                    {
                        bool entityKey = attribute.EntityKeyProperty;
                        if (entityKey)
                            return property;
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

        internal static object GetPrimaryKeyValue(object obj)
        {
            try
            {
                var pKey = POCO.GetPrimaryKey(obj);
                var value = pKey.GetValue(obj);
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}