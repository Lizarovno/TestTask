using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Expirience
    {
        [Key]
        public int ExpID { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Post { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime DateTo { get; set; }

        public override string ToString()
        {
            return String.Format("{0}     {1}", Company, Post);
        }

        public static List<Expirience> PrintExp(int myUserID)
        {
            try
            {
                List<Expirience> lstExp = new List<Expirience>();
                var query = Context.Instance.Expiriences.Select(x => x).Where(n => n.User.UserID == myUserID);
                foreach (var item in query)
                {
                    lstExp.Add(item);
                }
                return lstExp;
            }
            catch
            {
                return null;
            }
        }
        public static string AddExp(User user, string company, string post, DateTime dateFrom, DateTime dateTo, int expForEdite = -1)
        {
            Expirience exp;
            if (expForEdite == -1)
            {
                try
                {
                    exp = new Expirience { User = user, Company = company, Post = post, DateFrom = dateFrom, DateTo = dateTo };
                    Context.Instance.Expiriences.Add(exp);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                try
                {
                    exp = Context.Instance.Expiriences.Where(x => x.ExpID == expForEdite).FirstOrDefault();
                    exp.User = user;
                    exp.Company = company;
                    exp.Post = post;
                    exp.DateFrom = dateFrom;
                    exp.DateTo = dateTo;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            Context.Instance.SaveChanges();
            return "OK";
        }
        public string AddPreferredExpirience()
        {
            try
            {
                this.User.ExpIDinProfile = this.ExpID;
                Context.Instance.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void DelExp()
        {
            if (this.User.ExpIDinProfile == this.ExpID)
                this.User.ExpIDinProfile = 0;
            Context.Instance.Expiriences.Remove(this);
            Context.Instance.SaveChanges();
        }
    }
}
