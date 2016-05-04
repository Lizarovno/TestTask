namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Models;

    //Singleton
    public class Context : DbContext
    {
        //��������� ����������� ������������ ������������� �������� ������� ������� �����
        private Context()
            : base("name=Context")
        {
        }

        //������ ������������ ��������� �����
        private static Context _instance;
        //�������� ��� ���������� � ������������� ������ ��� ������ ���������
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