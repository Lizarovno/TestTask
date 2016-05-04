namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Models;

    //Singleton
    public class Context : DbContext
    {
        //приватный конструктор обеспечивает невозможность создания объекта снаруже класа
        private Context()
            : base("name=Context")
        {
        }

        //хранит единственный экземпляр класа
        private static Context _instance;
        //свойство его возвращает и автоматически создаёт при первом обращении
        public static Context Instance
        {
            get
            {
                if (Context._instance == null)
                {
                    Context._instance = new Context();
                }

                return Context._instance;
            }
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SavedImage> SavedImages { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Expirience> Expiriences { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
    }

}