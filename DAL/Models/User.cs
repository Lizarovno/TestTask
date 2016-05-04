using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string FullName { get; set; }
        public SavedImage Avatar { get; set; }
        public string AboutMe { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Address { get; set; }
        public int EducIDinProfile { get; set; }
        public int ExpIDinProfile { get; set; }
        public List<Skill> UserSkills { get; set; }
        public List<Project> UserProjects { get; set; }
        public List<Education> UserEducations { get; set; }
        public List<Expirience> UserExpiriences { get; set; }

        public static string CreateUser(string firstName, string familyName, string patronymic)
        {
            try
            {
                User us = new User()
                {
                    FirstName = firstName,
                    FamilyName = familyName,
                    Patronymic = patronymic,
                    FullName = String.Format("{0} {1} {2}", firstName, familyName, patronymic)
                };
                Context.Instance.Users.Add(us);
                Context.Instance.SaveChanges();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static List<User> PrintUsers()
        {
            try
            {
                List<User> listUser = new List<User>();
                var query = Context.Instance.Users.Select(x => x);
                foreach (var item in query)
                {
                    listUser.Add(item);
                }
                return listUser;
            }
            catch
            {
                return null;
            }
        }
        public void AddAvatar(string fileName)
        {
            SavedImage img = new SavedImage { FileName = fileName };
            this.Avatar = img;
            Context.Instance.SavedImages.Add(img);
            Context.Instance.SaveChanges();
        }

        public static User ReturnUserByID(int id)
        {
            var query = Context.Instance.Users.Where(x => x.UserID == id).FirstOrDefault();
            return (User)query;
        }

        public  void ChangeName(string firstName, string familyName, string patronymic)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
            this.Patronymic = patronymic;
            this.FullName = String.Format("{0} {1} {2}", firstName, familyName, patronymic);
            Context.Instance.SaveChanges();
        }

        public  string PrintPreferedEducation()
        {
            var query = Context.Instance.Educations.Where(x => x.EducationID == this.EducIDinProfile).FirstOrDefault();
            return (query != null) ? query.ToString() : "Please select education";
        }
        public  string PrintPreferedExpirience()
        {
            var query = Context.Instance.Expiriences.Where(x => x.ExpID == this.ExpIDinProfile).FirstOrDefault();
            return (query != null) ? query.ToString() : "Please select expirience";
        }

        public SavedImage GetAvatar()
        {
            return Context.Instance.SavedImages.Where(x => x.ImageID == this.Avatar.ImageID).FirstOrDefault();
        }

        public void EditeAboutMe(string text)
        {
            this.AboutMe = text;
            Context.Instance.SaveChanges();
        }

        public void EditeEmail(string email)
        {
            this.Email = email;
            Context.Instance.SaveChanges();
        }
        public void EditePhone(string phone)
        {
            this.Phone = phone;
                Context.Instance.SaveChanges();
        }
        public void EditeAddress(string address)
        {
            this.Address = address;
            Context.Instance.SaveChanges();
        }

        public void EditeSkype(string skype)
        {
            this.Skype = skype;
            Context.Instance.SaveChanges();
        }
    }
}
