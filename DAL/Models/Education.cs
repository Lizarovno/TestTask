using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public string Institution { get; set; }
        [Required]
        public string Specialty { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public SavedImage Diplome { get; set; }

        public override string ToString()
        {
            return String.Format("{0}     {1}", Institution, Specialty);
        }


        public static List<Education> PrintEducation(int myUserID)
        {
            try
            {
                List<Education> listEducation = new List<Education>();
                var query = Context.Instance.Educations.Select(x => x).Where(n => n.User.UserID == myUserID);
                foreach (var item in query)
                {
                    listEducation.Add(item);
                }
                return listEducation;
            }
            catch
            {
                return null;
            }
        }
        public static string AddEducation(User user, string specialty, string institution, DateTime dateFrom, DateTime dateTo, int educationForEdite = -1)
        {
            Education educ;
            if (educationForEdite == -1)
            {
                try
                {
                    educ = new Education { User = user, Institution = institution, Specialty = specialty, DateFrom = dateFrom, DateTo = dateTo };
                    Context.Instance.Educations.Add(educ);
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
                    educ = Context.Instance.Educations.Where(x => x.EducationID == educationForEdite).FirstOrDefault();
                    educ.User = user;
                    educ.Institution = institution;
                    educ.Specialty = specialty;
                    educ.DateFrom = dateFrom;
                    educ.DateTo = dateTo;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            Context.Instance.SaveChanges();

            return "OK";
        }

        public string AddPreferredEducation()
        {
            try
            {
                this.User.EducIDinProfile = this.EducationID;
                Context.Instance.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public  void DelEducation()
        {
            if (this.User.EducIDinProfile == this.EducationID)
                this.User.EducIDinProfile = 0;

            Context.Instance.Educations.Remove(this);
            Context.Instance.SaveChanges();
        }
    }
}
