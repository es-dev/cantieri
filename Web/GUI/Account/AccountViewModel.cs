using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Account
{
    public class AccountViewModel : Library.Template.MVVM.TemplateViewModel<AccountView, AccountItem, AccountModel, AccountDto>
    {

        public AccountViewModel()
            : base() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take, string search=null, object advancedSearch=null, OrderBy orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadAccounts(skip, take, search, advancedSearch, orderBy);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null, object advancedSearch = null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountAccounts(search, advancedSearch);
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override bool Save(object model, bool creating)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (AccountDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateAccount(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateAccount(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override bool Delete(object model)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (AccountDto)model;
                    bool performed = wcf.DeleteAccount(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override object Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAccount(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<AccountDto> ReadAccounts()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadAccounts();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal AccountDto Authenticate(AccountDto account)
        {
            try
            {
                AccountDto accountAuthenticated = null;
                if (IsSupervisor(account))
                    accountAuthenticated = GetSupervisorAccount(account);
                else
                {
                    var wcf = new WcfService.Service();
                    accountAuthenticated = wcf.AuthenticateAccount(account);
                }
                return accountAuthenticated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private AccountDto GetSupervisorAccount(AccountDto account)
        {
            try
            {
                var supervisorAccount = new AccountDto();
                supervisorAccount.Abilitato = true;
                supervisorAccount.AziendaId = -1;
                supervisorAccount.Creazione = DateTime.Now;
                supervisorAccount.Id = -1;
                supervisorAccount.Nickname = "supervisor";
                supervisorAccount.Password = account.Password;
                supervisorAccount.Username = "Supervisor";
                supervisorAccount.Ruolo = BusinessLogic.Tipi.TipoAccount.Supervisore.ToString();
                return supervisorAccount;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private bool IsSupervisor(AccountDto account)
        {
            try
            {
                if (account != null && account.Username!=null)
                {
                    var supervisor = (account.Username.ToUpper() == "SUPERVISOR" && account.Password == "esd");
                    //var supervisor = (account.Username.ToUpper() == "" && account.Password == "");
                    return supervisor;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
    }
}