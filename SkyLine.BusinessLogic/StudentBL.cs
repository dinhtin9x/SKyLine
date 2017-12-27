using System; using System.Collections.Generic; using System.Reflection; using SkyLine.DataAccess; using SkyLine.Models;  namespace SkyLine.BusinessLogic {     public class StudentBL     {         public StudentBL()         {         }         /// <summary>         /// Gets all.         /// </summary>         /// <returns>The all.</returns>         public IEnumerable<Student> GetAll(){             return new StudentDA().GetAll();         }          /// <summary>         /// Gets the by identifier.         /// </summary>         /// <returns>The by identifier.</returns>         /// <param name="id">Identifier.</param>         public Student GetById(string id){             return new StudentDA().GetById(id);         }

        public IEnumerable<StudentInfo> GetAll(StudentSearch searchModel)
        {
            return new StudentDA().GetAll(searchModel);
        }     } }
