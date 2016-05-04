
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace DAL.Models
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public string SkillName { get; set; }


        public override string ToString()
        {
            return SkillName;
        }

        public static string AddSkill(User user, string skillName, int skillForEdite)
        {
            Skill skill;
            try
            {
                if (skillForEdite == -1)
                {
                    skill = new Skill { User = user, SkillName = skillName };
                    Context.Instance.Skills.Add(skill);
                }
                else
                {
                    skill = Context.Instance.Skills.Where(x => x.SkillID == skillForEdite).FirstOrDefault();
                    skill.User = user;
                    skill.SkillName = skillName;
                }
                Context.Instance.SaveChanges();
                return "OK";
            }
            catch (DbUpdateException ex)
            {
                return ex.Message;
            }     
        }

        public void DelSkill()
        {
            Context.Instance.Skills.Remove(this);
            Context.Instance.SaveChanges();
        }

        public static List<Skill> PrintSkills(int myUserID)
        {
            List<Skill> lstSkills = new List<Skill>();
            var query = Context.Instance.Skills.Select(x => x).Where(s => s.User.UserID == myUserID);
            lstSkills.AddRange(query);
            return lstSkills;
        }


    }
}

