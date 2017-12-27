using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SkyLine.Models;
namespace SkyLine.DataAccess
{

    public class StudentDA : DataAccessBase<Student>
    {
        public StudentDA() : base()
        {
        }

        public override IEnumerable<Student> GetAll()
        {
            IEnumerable<Student> students = ctx.Students.ToList();
            return students;
        }

        public Student GetById(string id)
        {
            var student = ctx.Students.FirstOrDefault(b => b.StudentID == id);
            return student;
        }

        public override int Add(Student b)
        {
            ctx.Students.Add(b);
            int res = ctx.SaveChanges();
            return res;
        }

        public int Update(string id, Student b)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentInfo> GetAll(StudentSearch searchModel)
        {
            var query = from student in ctx.Students
                        join classDetail in ctx.ClassDetail on student.StudentID equals classDetail.StudentID into classDetailGroup
                        from ClassDetailGroup in classDetailGroup.DefaultIfEmpty()
                        join classes in ctx.Classes on ClassDetailGroup.ClassID equals classes.ClassID into classesGroup
                        from ClassesGroup in classesGroup.DefaultIfEmpty()
                        select new { student, ClassesGroup };

            if (!string.IsNullOrEmpty(searchModel.ParentId))
            {
                query = query.Where(x => x.student.ParentId.Equals(searchModel.ParentId));
            }

            if (!string.IsNullOrEmpty(searchModel.Name))
            {
                query = query.Where(x => string.Format("{0} {1}", x.student.StudentLastName, x.student.StudentName).Contains(searchModel.Name));
            }

            if (searchModel.ClassLevel != null)
            {
                query = query.Where(x => x.ClassesGroup.LevelID == searchModel.ClassLevel.Value);
            }

            if (searchModel.Limit != null)
            {
                query = query.Take(searchModel.Limit.Value);
            }

            if (searchModel.Offset != null)
            {
                query = query.Skip(searchModel.Offset.Value);
            }


            return query.Select(x => new StudentInfo()
            {
                StudentId = x.student.StudentID
                  ,
                StudentLastName = x.student.StudentLastName
                  ,
                StudentName = x.student.StudentName
                 ,
                Gender = x.student.Gender
                 ,
                BirthDate = x.student.BirthDate
                 ,
                ParentId = x.student.ParentId
                 ,
                ImageLink = x.student.ImageLink
                 ,
                ClassName = x.ClassesGroup == null ? null : x.ClassesGroup.ClassName
                 ,
                ClassLevel = x.ClassesGroup == null ? null : (int?)x.ClassesGroup.LevelID
            }).ToList();
        }
    }
}
